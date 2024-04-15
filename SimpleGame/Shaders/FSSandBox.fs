#version 330

// location=0 : 0�� �ε���(������ ����)�� ���ε� �Ǿ� �ִ� ���۸� ����϶�
layout(location=0) out vec4 FragColor;

in vec4 v_Color;

void FilledCircle()
{
	vec4 newColor = vec4(1, 1, 1, 1);
	float r = 0.5f;
	vec2 center = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, center);
	if(dist < r)
	{
		newColor = vec4(1, 1, 1, 1);
	}
	else
	{
		newColor = vec4(0, 0, 0, 0);
		
	}
	FragColor = newColor;
}

void Circle()
{
	vec4 newColor = vec4(1, 1, 1, 1);
	float r = 0.5;
	float width = 0.05;
	vec2 center = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, center);

	if(dist > r - width && dist < r)
	{
		newColor = vec4(1, 1, 1, 1);
	}
	else
	{
		newColor = vec4(0, 0, 0, 0);
	}
	FragColor = newColor;
}
void main()
{
	Circle();
}