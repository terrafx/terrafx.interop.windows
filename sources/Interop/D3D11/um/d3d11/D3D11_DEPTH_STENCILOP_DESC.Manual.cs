// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_STENCIL_OP;
using static TerraFX.Interop.D3D11_COMPARISON_FUNC;

namespace TerraFX.Interop
{
    public partial struct D3D11_DEPTH_STENCILOP_DESC
    {
        public static readonly D3D11_DEPTH_STENCILOP_DESC DEFAULT = new D3D11_DEPTH_STENCILOP_DESC {
            StencilFailOp = D3D11_STENCIL_OP_KEEP,
            StencilDepthFailOp = D3D11_STENCIL_OP_KEEP,
            StencilPassOp = D3D11_STENCIL_OP_KEEP,
            StencilFunc = D3D11_COMPARISON_ALWAYS,
        };
    }
}
