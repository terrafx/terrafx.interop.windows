// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_META_COMMAND_PARAMETER_DESC
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* Name;

        public D3D12_META_COMMAND_PARAMETER_TYPE Type;

        public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;

        public D3D12_RESOURCE_STATES RequiredResourceState;

        [NativeTypeName("UINT")]
        public uint StructureOffset;
    }
}
