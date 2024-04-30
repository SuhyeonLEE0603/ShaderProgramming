#version 330

// location=0 : 0번 인덱스(프레임 버퍼)에 바인딩 되어 있는 버퍼를 출력하라
layout(location=0) out vec4 FragColor;
in vec2 v_TexPos;

uniform sampler2D u_Texture;
uniform sampler2D u_NumberTexture[10];
uniform sampler2D u_NumbersTexture;
uniform float u_Time;

void P1()
{
	float tx = v_TexPos.x;
	float ty = fract(v_TexPos.y * 2);
	vec2 newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P2()
{
	float tx = v_TexPos.x;
	float ty = 1 - abs(v_TexPos.y * 2 - 1);
	vec2 newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P3()
{
	vec2 newTexPos;
	float tx = fract(v_TexPos.x * 3);	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y / 3 + (2 - floor(v_TexPos.x * 3)) / 3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P4()
{
	vec2 newTexPos;
	float tx = fract(v_TexPos.x * 3);	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y / 3 + (floor(v_TexPos.x * 3)) / 3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P5()
{
	float padding = 0.5;
	float countX = 3;
	float countY = 3;
	vec2 newTexPos;
	float tx =  fract(padding * floor(v_TexPos.y * countY)) + v_TexPos.x * countX;	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = fract(v_TexPos.y * countY);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P6()
{
	vec2 newTexPos;
	float tx = v_TexPos.x;	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y;
	newTexPos = vec2(tx, ty);

	int texID = int(u_Time) % 10;
	FragColor = texture(u_NumberTexture[texID], newTexPos);
}

void P7()
{
	vec2 newTexPos;
	float xResol = 5;
	float yResol = 2;
	float id = 5;
	float indexX = float(int(id) % int(xResol));
	float indexY = floor(id / xResol);
	float tx = v_TexPos.x / xResol + indexX * (1 / xResol);	// 0 ~ 0.2
	float ty = v_TexPos.y / yResol + indexY * (1 / yResol);	// 0 ~ 0.5
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_NumbersTexture, newTexPos);
}

// 시험 BGR 세로로 렌더
void T1()
{
	vec2 newTexPos;
	float tx = fract(v_TexPos.x * 3);	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = v_TexPos.y / 3 + (2 - floor(v_TexPos.x * 3)) / 3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

// 시험 RGB 세로로 2개 가로로 2개, 오른쪽은 0.5부터 시작
void T2()
{
	float padding = 0.5;
	float countX = 2;
	float countY = 2;
	vec2 newTexPos;
	float tx =  fract(padding * floor(v_TexPos.y * countY)) + v_TexPos.x * countX;	// 0 ~ 1, 0 ~ 1, 0 ~ 1
	float ty = fract(v_TexPos.y * countY);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}


void main()
{
	// P1();
	// P2();
	// P3();
	// P4();
	// P5();
	// P6();
	// P7();
	T1();
	//T2();
}
