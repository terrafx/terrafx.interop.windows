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
    result.uvw = float3(input.uvw[0], input.uvw[1], transform[0][0] - 0.5f);

    return result;
}

// pixel shader
SamplerState samplerInput : register(s0);
Texture1D texture1dInput : register(t0);
Texture2D texture2dInput : register(t1);
Texture3D texture3dInput : register(t2);

float4 PSMain(PSInput input) : SV_TARGET
{
    // 1d linear color gradient
    float4 color1d = texture1dInput.Sample(samplerInput, input.uvw[0]);
    // 2d black/white checker board
    float4 color2d = texture2dInput.Sample(samplerInput, float2(input.uvw[0], input.uvw[1]));
    // 3d sphere
    float intensity = texture3dInput.Sample(samplerInput, input.uvw);
    float4 color3d = float4(intensity, intensity, intensity, 1.0f);
    float4 color = color1d * color2d * color3d;
    return color;
}
