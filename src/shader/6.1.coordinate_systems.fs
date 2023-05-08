#version 330 core
out vec4 FragColor;

// in vec3 ourColor;
in vec2 TexCoord;

//uniform float mixValue;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform vec3 colorVal;


void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	// FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
	// FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(1.0 - TexCoord.x, TexCoord.y)), 0.2);
	// FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), mixValue);
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), colorVal.y);
	// FragColor = vec4(colorVal, 1.0f);
}