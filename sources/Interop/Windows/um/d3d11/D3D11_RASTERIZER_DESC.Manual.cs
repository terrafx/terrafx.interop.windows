// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_CULL_MODE;
using static TerraFX.Interop.D3D11_FILL_MODE;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D3D11_RASTERIZER_DESC
    {
        public static readonly D3D11_RASTERIZER_DESC DEFAULT = new D3D11_RASTERIZER_DESC(
            fillMode: D3D11_FILL_SOLID,
            cullMode: D3D11_CULL_BACK,
            frontCounterClockwise: FALSE,
            depthBias: D3D11_DEFAULT_DEPTH_BIAS,
            depthBiasClamp: D3D11_DEFAULT_DEPTH_BIAS_CLAMP,
            slopeScaledDepthBias: D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS,
            depthClipEnable: TRUE,
            scissorEnable: FALSE,
            multisampleEnable: FALSE,
            antialiasedLineEnable: FALSE
        );

        public D3D11_RASTERIZER_DESC(D3D11_FILL_MODE fillMode, D3D11_CULL_MODE cullMode, [NativeTypeName("BOOL")] int frontCounterClockwise, [NativeTypeName("INT")] int depthBias, [NativeTypeName("FLOAT")] float depthBiasClamp, [NativeTypeName("FLOAT")] float slopeScaledDepthBias, [NativeTypeName("BOOL")] int depthClipEnable, [NativeTypeName("BOOL")] int scissorEnable, [NativeTypeName("BOOL")] int multisampleEnable, [NativeTypeName("BOOL")] int antialiasedLineEnable)
        {
            FillMode = fillMode;
            CullMode = cullMode;
            FrontCounterClockwise = frontCounterClockwise;
            DepthBias = depthBias;
            DepthBiasClamp = depthBiasClamp;
            SlopeScaledDepthBias = slopeScaledDepthBias;
            DepthClipEnable = depthClipEnable;
            ScissorEnable = scissorEnable;
            MultisampleEnable = multisampleEnable;
            AntialiasedLineEnable = antialiasedLineEnable;
        }
    }
}
