#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
layout(location=0) out vec4 FragColor;

uniform float u_Time;

in vec4 v_Color;

const float c_Pi = 3.14;

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

// 시험문제 : 물방울이 떨이지는 효과 -> 시작시간을 다르게 하고 퍼져있음
void Circles()
{
	float circleCount = 10; // 0 ~ 1
	vec2 circleCenter = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, circleCenter);
	float inputs = circleCount * c_Pi * 4 * dist + u_Time * 20;
	float sinValue = pow(sin(inputs), 16);
	FragColor = vec4(sinValue);
}

void SinGraph()
{
	vec2 newTexPos = vec2(v_Color.r * 2 * c_Pi, v_Color.g * 2 - 1);
	float period = 2.5;
	float amp = 0.2;
	float speed = 10;
	// float sinValue = amp * sin(newTexPos.x * period - u_Time) - amp * sin(- u_Time);
	float sinValue = v_Color.r * amp * sin(newTexPos.x * period - u_Time * speed);
	float width = 0.5;
	width = width * (1 - v_Color.r);
	if(sinValue < newTexPos.y + width && sinValue > newTexPos.y - width)
	{
		FragColor = vec4((sinValue + 1) / 2);
	}
	else
	{
		// 출력X
		discard;
		//FragColor = vec4(0);
	}

}

void main()
{
	//Circle();
	//Circles();
	SinGraph();
}
