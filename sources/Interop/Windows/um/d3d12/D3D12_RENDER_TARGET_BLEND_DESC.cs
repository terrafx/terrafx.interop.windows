// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Interop.D3D12_BLEND;
using static TerraFX.Interop.D3D12_BLEND_OP;
using static TerraFX.Interop.D3D12_COLOR_WRITE_ENABLE;
using static TerraFX.Interop.D3D12_LOGIC_OP;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_RENDER_TARGET_BLEND_DESC
    {
        #region Default Instances
        public static readonly D3D12_RENDER_TARGET_BLEND_DESC DEFAULT = new D3D12_RENDER_TARGET_BLEND_DESC() {
            BlendEnable = FALSE,
            LogicOpEnable = FALSE,
            SrcBlend = D3D12_BLEND_ONE,
            DestBlend = D3D12_BLEND_ZERO,
            BlendOp = D3D12_BLEND_OP_ADD,
            SrcBlendAlpha = D3D12_BLEND_ONE,
            DestBlendAlpha = D3D12_BLEND_ZERO,
            BlendOpAlpha = D3D12_BLEND_OP_ADD,
            LogicOp = D3D12_LOGIC_OP_NOOP,
            RenderTargetWriteMask = (byte)D3D12_COLOR_WRITE_ENABLE_ALL
        };
        #endregion

        #region Fields
        [NativeTypeName("BOOL")]
        public int BlendEnable;

        [NativeTypeName("BOOL")]
        public int LogicOpEnable;

        public D3D12_BLEND SrcBlend;

        public D3D12_BLEND DestBlend;

        public D3D12_BLEND_OP BlendOp;

        public D3D12_BLEND SrcBlendAlpha;

        public D3D12_BLEND DestBlendAlpha;

        public D3D12_BLEND_OP BlendOpAlpha;

        public D3D12_LOGIC_OP LogicOp;

        [NativeTypeName("UINT8")]
        public byte RenderTargetWriteMask;
        #endregion
    }
}
