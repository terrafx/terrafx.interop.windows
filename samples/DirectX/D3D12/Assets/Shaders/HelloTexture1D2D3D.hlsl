// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// types
cbuffer SceneConstantBuffer : register(b0)
{
    matrix transform;
};

struct VSInput
{
    float3 position : POSITION;
    float2 uv : TEXCOORD;
};

struct PSInput
{
    float4 position : SV_POSITION;
    float u : TEXCOORD;
};

// vertex shader
PSInput VSMain(VSInput input)
{
    PSInput result;

    float4 pos4 = float4(input.position, 1.0f);
    pos4 = mul(pos4, transform);
    result.position = pos4;
    result.u = input.uv[0];

    return result;
}

// pixel shader
Texture1D textureInput : register(t0);
SamplerState samplerInput : register(s0);

float4 PSMain(PSInput input) : SV_TARGET
{
    float4 color = textureInput.Sample(samplerInput, input.u);
    return color;
}
