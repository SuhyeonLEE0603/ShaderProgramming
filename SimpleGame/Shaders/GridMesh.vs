#version 330

in vec3 a_Position;

uniform float u_Time;

const float c_Pi = 3.141592;

void main()
{
	vec4 newPosition = vec4(a_Position, 1);

	float sinInput = (a_Position.x + 0.5) * 2 * c_Pi;
	newPosition.y = newPosition.y + 0.5 * sin(sinInput + u_Time);
	gl_Position = newPosition;
}
