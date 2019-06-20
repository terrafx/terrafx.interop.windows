// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Interop.D3D12_COMPARISON_FUNC;
using static TerraFX.Interop.D3D12_STENCIL_OP;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_DEPTH_STENCILOP_DESC
    {
        #region Default Instances
        public static readonly D3D12_DEPTH_STENCILOP_DESC DEFAULT = new D3D12_DEPTH_STENCILOP_DESC() {
            StencilFailOp = D3D12_STENCIL_OP_KEEP,
            StencilDepthFailOp = D3D12_STENCIL_OP_KEEP,
            StencilPassOp = D3D12_STENCIL_OP_KEEP,
            StencilFunc = D3D12_COMPARISON_FUNC_ALWAYS
        };
        #endregion

        #region Fields
        public D3D12_STENCIL_OP StencilFailOp;

        public D3D12_STENCIL_OP StencilDepthFailOp;

        public D3D12_STENCIL_OP StencilPassOp;

        public D3D12_COMPARISON_FUNC StencilFunc;
        #endregion
    }
}
