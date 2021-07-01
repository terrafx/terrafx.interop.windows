// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_BLEND;
using static TerraFX.Interop.D3D11_BLEND_OP;
using static TerraFX.Interop.D3D11_COLOR_WRITE_ENABLE;
using static TerraFX.Interop.D3D11_LOGIC_OP;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D3D11_RENDER_TARGET_BLEND_DESC1
    {
        public static readonly D3D11_RENDER_TARGET_BLEND_DESC1 DEFAULT = new D3D11_RENDER_TARGET_BLEND_DESC1 {
            BlendEnable = FALSE,
            LogicOpEnable = FALSE,
            SrcBlend = D3D11_BLEND_ONE,
            DestBlend = D3D11_BLEND_ZERO,
            BlendOp = D3D11_BLEND_OP_ADD,
            SrcBlendAlpha = D3D11_BLEND_ONE,
            DestBlendAlpha = D3D11_BLEND_ZERO,
            BlendOpAlpha = D3D11_BLEND_OP_ADD,
            LogicOp = D3D11_LOGIC_OP_NOOP,
            RenderTargetWriteMask = (byte)D3D11_COLOR_WRITE_ENABLE_ALL,
        };
    }
}
