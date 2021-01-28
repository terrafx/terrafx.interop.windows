// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_BLEND_DESC
    {
        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        [NativeTypeName("BOOL [8]")]
        public fixed int BlendEnable[8];

        public D3D10_BLEND SrcBlend;

        public D3D10_BLEND DestBlend;

        public D3D10_BLEND_OP BlendOp;

        public D3D10_BLEND SrcBlendAlpha;

        public D3D10_BLEND DestBlendAlpha;

        public D3D10_BLEND_OP BlendOpAlpha;

        [NativeTypeName("UINT8 [8]")]
        public fixed byte RenderTargetWriteMask[8];
    }
}
