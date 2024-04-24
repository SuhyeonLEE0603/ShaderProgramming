#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
layout(location=0) out vec4 FragColor;
in vec2 v_TexPos;

uniform sampler2D u_Texture;

void main()
{
	float tx = v_TexPos.x;
	float ty = fract(v_TexPos.y * 2);
	vec2 newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}
