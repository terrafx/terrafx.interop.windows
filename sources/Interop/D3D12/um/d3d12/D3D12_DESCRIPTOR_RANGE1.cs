// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_DESCRIPTOR_RANGE1
    {
        public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;

        [NativeTypeName("UINT")]
        public uint NumDescriptors;

        [NativeTypeName("UINT")]
        public uint BaseShaderRegister;

        [NativeTypeName("UINT")]
        public uint RegisterSpace;

        public D3D12_DESCRIPTOR_RANGE_FLAGS Flags;

        [NativeTypeName("UINT")]
        public uint OffsetInDescriptorsFromTableStart;
    }
}
