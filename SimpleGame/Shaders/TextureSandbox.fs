#version 330

// location=0 : 0�� �ε���(������ ����)�� ���ε� �Ǿ� �ִ� ���۸� ����϶�
layout(location=0) out vec4 FragColor;
in vec2 v_TexPos;

uniform sampler2D u_Texture;

void P1()
{
	float tx = v_TexPos.x;
	float ty = fract(v_TexPos.y * 2);
	vec2 newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P2()
{
	float tx = v_TexPos.x;
	float ty = 1 - abs(v_TexPos.y * 2 - 1);
	vec2 newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P3()
{
	vec2 newTexPos;
	float tx = fract(v_TexPos.x * 3);	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y / 3 + (2 - floor(v_TexPos.x * 3)) / 3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}
void main()
{
	// P1();
	// P2();
	P3();
}
