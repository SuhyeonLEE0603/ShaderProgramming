#version 330

in vec3 a_Position;

uniform float u_Time = 0;
uniform float u_Period = 2.0;

const vec3 c_StartPos = vec3(-1, 0, 0);
const vec3 c_Velocity = vec3(2.0, 0, 0);
const float c_Pi = 3.141592;

void Line()
{
	float newTime = abs(fract(u_Time/u_Period) - 0.5) * 2.0;
	vec4 newPosition;
	newPosition.xyz = 
	(c_StartPos + a_Position) +
	c_Velocity * newTime;
	newPosition.w = 1;
	gl_Position = newPosition;
}

void Circle()
{
	float newTime = fract(u_Time) * c_Pi * 2.0;
	vec2 trans = vec2(cos(newTime), sin(newTime));
	vec4 newPosition;
	newPosition.xy = a_Position.xy + trans;
	newPosition.zw = vec2(0, 1);
	gl_Position = newPosition;
}

void main()
{
	//Line();
	Circle();
}
