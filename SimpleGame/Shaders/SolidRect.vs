#version 330

in vec3 a_Position;
// 매 프레임 const형으로 set 할 수 있음
uniform vec4 u_Trans;

void main()
{
	vec4 newPosition;
	newPosition.xy = a_Position.xy*u_Trans.w * 10 + u_Trans.xy;
	newPosition.z = 0;
	newPosition.w = 1;
	newPosition.x += 0.5;
	gl_Position = newPosition;
}
