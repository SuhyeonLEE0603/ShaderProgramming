#version 330

// location=0 : 0�� �ε���(������ ����)�� ���ε� �Ǿ� �ִ� ���۸� ����϶�
layout(location=0) out vec4 FragColor;

in vec2 v_TexPos;

uniform sampler2D u_Texture;

void main()
{
	//FragColor = texture(v_TexPos, u_Texture);
	FragColor = vec4(1, 0, 0, 1);
}
