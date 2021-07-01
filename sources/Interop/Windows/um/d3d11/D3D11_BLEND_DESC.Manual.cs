// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D3D11_BLEND_DESC
    {
        public static readonly D3D11_BLEND_DESC DEFAULT = new D3D11_BLEND_DESC {
            AlphaToCoverageEnable = FALSE,
            IndependentBlendEnable = FALSE,
            RenderTarget = new _RenderTarget_e__FixedBuffer {
                e0 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e1 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e2 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e3 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e4 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e5 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e6 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
                e7 = D3D11_RENDER_TARGET_BLEND_DESC.DEFAULT,
            },
        };
    }
}
