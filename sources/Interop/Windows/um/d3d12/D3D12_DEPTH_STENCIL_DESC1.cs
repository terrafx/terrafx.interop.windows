// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_DEPTH_STENCIL_DESC1
    {
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

        [NativeTypeName("BOOL")]
        public int DepthBoundsTestEnable;
    }
}
