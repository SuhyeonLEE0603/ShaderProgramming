#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
layout(location=0) out vec4 FragColor;

in vec4 v_Color;

void main()
{
	//FragColor = vec4(u_Color.r, u_Color.g, u_Color.b, u_Color.a);
	FragColor = v_Color;
}
