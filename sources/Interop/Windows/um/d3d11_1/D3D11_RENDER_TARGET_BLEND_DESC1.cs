// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_RENDER_TARGET_BLEND_DESC1
    {
        [NativeTypeName("BOOL")]
        public int BlendEnable;

        [NativeTypeName("BOOL")]
        public int LogicOpEnable;

        public D3D11_BLEND SrcBlend;

        public D3D11_BLEND DestBlend;

        public D3D11_BLEND_OP BlendOp;

        public D3D11_BLEND SrcBlendAlpha;

        public D3D11_BLEND DestBlendAlpha;

        public D3D11_BLEND_OP BlendOpAlpha;

        public D3D11_LOGIC_OP LogicOp;

        [NativeTypeName("UINT8")]
        public byte RenderTargetWriteMask;
    }
}
