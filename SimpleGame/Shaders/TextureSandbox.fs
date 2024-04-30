#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
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

void P4()
{
	vec2 newTexPos;
	float tx = fract(v_TexPos.x * 3);	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y / 3 + (floor(v_TexPos.x * 3)) / 3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P5()
{
	float padding = 0.5;
	float countX = 3;
	float countY = 3;
	vec2 newTexPos;
	float tx =  fract(padding * floor(v_TexPos.y * countY)) + v_TexPos.x * countX;	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = fract(v_TexPos.y * countY);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P6()
{
	vec2 newTexPos;
	float tx = v_TexPos.x;	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

// 시험 BGR 세로로 렌더
// 시험 RGB 세로로 2개 가로로 2개, 오른쪽은 0.5부터 시작

void main()
{
	// P1();
	// P2();
	// P3();
	// P4();
	// P5();
	P6();
}
