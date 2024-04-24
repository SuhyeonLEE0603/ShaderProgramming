#version 330

in vec3 a_Position;

out vec4 v_Color;

uniform float u_Time;

const float c_Pi = 3.141592;

void main()
{
	vec4 newPosition = vec4(a_Position, 1);

	float scaledValue = a_Position.x + 0.5;
	float period = 2;
	float sinInput = period * scaledValue * 2 * c_Pi;
	float timeScale = 6;
	float sinValue = sin(sinInput - u_Time * timeScale);
	float width = 0.5 * (1 - scaledValue);
	newPosition.y = width * newPosition.y + scaledValue * width * sinValue;

	v_Color = vec4((sinValue + 1) / 2);
	gl_Position = newPosition;
}
