#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
layout(location=0) out vec4 FragColor;

in vec2 v_TexPos;

uniform sampler2D u_Texture;

void main()
{
	//FragColor = texture(v_TexPos, u_Texture);
	FragColor = vec4(1, 0, 0, 1);
}
