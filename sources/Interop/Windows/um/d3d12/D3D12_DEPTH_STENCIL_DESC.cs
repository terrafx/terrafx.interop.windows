// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_DEPTH_WRITE_MASK;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_DEPTH_STENCIL_DESC
    {
        #region Default Instances
        public static readonly D3D12_DEPTH_STENCIL_DESC DEFAULT = new D3D12_DEPTH_STENCIL_DESC() {
            DepthEnable = TRUE,
            DepthWriteMask = D3D12_DEPTH_WRITE_MASK_ALL,
            DepthFunc = D3D12_COMPARISON_FUNC_LESS,
            StencilEnable = FALSE,
            StencilReadMask = (byte)D3D12_DEFAULT_STENCIL_READ_MASK,
            StencilWriteMask = (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK,
            FrontFace = D3D12_DEPTH_STENCILOP_DESC.DEFAULT,
            BackFace = D3D12_DEPTH_STENCILOP_DESC.DEFAULT
        };
        #endregion

        #region Fields
        [NativeTypeName("BOOL")]
        public int DepthEnable;

        public D3D12_DEPTH_WRITE_MASK DepthWriteMask;

        public D3D12_COMPARISON_FUNC DepthFunc;

        [NativeTypeName("BOOL")]
        public int StencilEnable;

        [NativeTypeName("UINT8")]
        public byte StencilReadMask;

        [NativeTypeName("UINT8")]
        public byte StencilWriteMask;

        public D3D12_DEPTH_STENCILOP_DESC FrontFace;

        public D3D12_DEPTH_STENCILOP_DESC BackFace;
        #endregion

        #region Constructors
        public D3D12_DEPTH_STENCIL_DESC(int depthEnable, D3D12_DEPTH_WRITE_MASK depthWriteMask, D3D12_COMPARISON_FUNC depthFunc, int  stencilEnable, byte stencilReadMask, byte stencilWriteMask, D3D12_STENCIL_OP frontStencilFailOp, D3D12_STENCIL_OP frontStencilDepthFailOp, D3D12_STENCIL_OP frontStencilPassOp, D3D12_COMPARISON_FUNC frontStencilFunc, D3D12_STENCIL_OP backStencilFailOp, D3D12_STENCIL_OP backStencilDepthFailOp, D3D12_STENCIL_OP backStencilPassOp, D3D12_COMPARISON_FUNC backStencilFunc)
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
        #endregion
    }
}
