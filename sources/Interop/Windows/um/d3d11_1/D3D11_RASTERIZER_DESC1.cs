// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_RASTERIZER_DESC1
    {
        public D3D11_FILL_MODE FillMode;

        public D3D11_CULL_MODE CullMode;

        public BOOL FrontCounterClockwise;

        [NativeTypeName("INT")]
        public int DepthBias;

        [NativeTypeName("FLOAT")]
        public float DepthBiasClamp;

        [NativeTypeName("FLOAT")]
        public float SlopeScaledDepthBias;

        public BOOL DepthClipEnable;

        public BOOL ScissorEnable;

        public BOOL MultisampleEnable;

        public BOOL AntialiasedLineEnable;

        [NativeTypeName("UINT")]
        public uint ForcedSampleCount;
    }
}
