#version 330

// location=0 : 0�� �ε���(������ ����)�� ���ε� �Ǿ� �ִ� ���۸� ����϶�
layout(location=0) out vec4 FragColor;
in vec2 v_TexPos;

void main()
{
	FragColor = vec4(v_TexPos, 0, 1);
}
