#version 330

// location=0 : 0�� �ε���(������ ����)�� ���ε� �Ǿ� �ִ� ���۸� ����϶�
layout(location=0) out vec4 FragColor;

uniform vec4 u_Color;

void main()
{
	//FragColor = vec4(u_Color.r, u_Color.g, u_Color.b, u_Color.a);
	FragColor = vec4(1, 1, 1, 1);
}
