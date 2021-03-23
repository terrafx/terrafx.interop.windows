// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// types
cbuffer SceneConstantBuffer : register(b0)
{
    matrix transform;
};

struct VSInput
{
    float3 position : POSITION;
    float3 uvw : TEXCOORD;
};

struct PSInput
{
    float4 position : SV_POSITION;
    float3 uvw : TEXCOORD;
};

// vertex shader
PSInput VSMain(VSInput input)
{
    PSInput result;

    float4 pos4 = float4(input.position, 1.0f);
    pos4 = mul(pos4, transform);
    result.position = pos4;
    result.uv = input.uv;

    return result;
}

// pixel shader
Texture1D texture1dInput : register(t0);
SamplerState sampler1dInput : register(s0);
Texture2D texture2dInput : register(t1);
SamplerState sampler2dInput : register(s1);
Texture3D texture3dInput : register(t2);
SamplerState sampler3dInput : register(s2);

float4 PSMain(PSInput input) : SV_TARGET
{
    float4 color1d = texture1dInput.Sample(sampler1dInput, input.uvw[0]);
    float4 color2d = texture2dInput.Sample(sampler2dInput, float2(input.uvw[0], input.uvw[2]));
    float4 color3d = texture3dInput.Sample(sampler3dInput, input.uvw);
    float4 color = 0.33f * color1d + 0.33f * color2d + 0.33f * color3d;
    return color;
}
