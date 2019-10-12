// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_CULL_MODE;
using static TerraFX.Interop.D3D12_FILL_MODE;
using static TerraFX.Interop.D3D12_CONSERVATIVE_RASTERIZATION_MODE;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D3D12_RASTERIZER_DESC
    {
        public static readonly D3D12_RASTERIZER_DESC DEFAULT = new D3D12_RASTERIZER_DESC(fillMode: D3D12_FILL_MODE_SOLID, cullMode: D3D12_CULL_MODE_BACK, frontCounterClockwise:  FALSE, depthBias: D3D12_DEFAULT_DEPTH_BIAS, depthBiasClamp: D3D12_DEFAULT_DEPTH_BIAS_CLAMP, slopeScaledDepthBias: D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS, depthClipEnable: TRUE, multisampleEnable: FALSE, antialiasedLineEnable: FALSE, forcedSampleCount: 0, conservativeRaster: D3D12_CONSERVATIVE_RASTERIZATION_MODE_OFF);

        public D3D12_FILL_MODE FillMode;

        public D3D12_CULL_MODE CullMode;

        [NativeTypeName("BOOL")]
        public int FrontCounterClockwise;

        [NativeTypeName("INT")]
        public int DepthBias;

        [NativeTypeName("FLOAT")]
        public float DepthBiasClamp;

        [NativeTypeName("FLOAT")]
        public float SlopeScaledDepthBias;

        [NativeTypeName("BOOL")]
        public int DepthClipEnable;

        [NativeTypeName("BOOL")]
        public int MultisampleEnable;

        [NativeTypeName("BOOL")]
        public int AntialiasedLineEnable;

        [NativeTypeName("UINT")]
        public uint ForcedSampleCount;

        public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;

        public D3D12_RASTERIZER_DESC(D3D12_FILL_MODE fillMode, D3D12_CULL_MODE cullMode, int frontCounterClockwise, int depthBias, float depthBiasClamp, float slopeScaledDepthBias, int depthClipEnable, int multisampleEnable, int antialiasedLineEnable, uint forcedSampleCount, D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster)
        {
            FillMode = fillMode;
            CullMode = cullMode;
            FrontCounterClockwise = frontCounterClockwise;
            DepthBias = depthBias;
            DepthBiasClamp = depthBiasClamp;
            SlopeScaledDepthBias = slopeScaledDepthBias;
            DepthClipEnable = depthClipEnable;
            MultisampleEnable = multisampleEnable;
            AntialiasedLineEnable = antialiasedLineEnable;
            ForcedSampleCount = forcedSampleCount;
            ConservativeRaster = conservativeRaster;
        }
    }
}
