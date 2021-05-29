// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D11_DEPTH_WRITE_MASK;
using static TerraFX.Interop.D3D11_COMPARISON_FUNC;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D3D11_DEPTH_STENCIL_DESC
    {
        public static readonly D3D11_DEPTH_STENCIL_DESC DEFAULT = new D3D11_DEPTH_STENCIL_DESC {
            DepthEnable = TRUE,
            DepthWriteMask = D3D11_DEPTH_WRITE_MASK_ALL,
            DepthFunc = D3D11_COMPARISON_LESS,
            StencilEnable = FALSE,
            StencilReadMask = D3D11_DEFAULT_STENCIL_READ_MASK,
            StencilWriteMask = D3D11_DEFAULT_STENCIL_WRITE_MASK,
            FrontFace = D3D11_DEPTH_STENCILOP_DESC.DEFAULT,
            BackFace = D3D11_DEPTH_STENCILOP_DESC.DEFAULT,
        };

        public D3D11_DEPTH_STENCIL_DESC([NativeTypeName("BOOL")] int depthEnable, D3D11_DEPTH_WRITE_MASK depthWriteMask, D3D11_COMPARISON_FUNC depthFunc, [NativeTypeName("BOOL")] int stencilEnable, [NativeTypeName("UINT8")] byte stencilReadMask, [NativeTypeName("UINT8")] byte stencilWriteMask, D3D11_STENCIL_OP frontStencilFailOp, D3D11_STENCIL_OP frontStencilDepthFailOp, D3D11_STENCIL_OP frontStencilPassOp, D3D11_COMPARISON_FUNC frontStencilFunc, D3D11_STENCIL_OP backStencilFailOp, D3D11_STENCIL_OP backStencilDepthFailOp, D3D11_STENCIL_OP backStencilPassOp, D3D11_COMPARISON_FUNC backStencilFunc)
        {
            DepthEnable = depthEnable;
            DepthWriteMask = depthWriteMask;
            DepthFunc = depthFunc;
            StencilEnable = stencilEnable;
            StencilReadMask = stencilReadMask;
            StencilWriteMask = stencilWriteMask;
            FrontFace.StencilFailOp = frontStencilFailOp;
            FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
            FrontFace.StencilPassOp = frontStencilPassOp;
            FrontFace.StencilFunc = frontStencilFunc;
            BackFace.StencilFailOp = backStencilFailOp;
            BackFace.StencilDepthFailOp = backStencilDepthFailOp;
            BackFace.StencilPassOp = backStencilPassOp;
            BackFace.StencilFunc = backStencilFunc;
        }
    }
}
