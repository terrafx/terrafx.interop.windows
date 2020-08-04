// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_DATA_SET_LB_PROVISIONING_STATE_V2
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORDLONG")]
        public ulong SlabSizeInBytes;

        [NativeTypeName("DWORDLONG")]
        public ulong SlabOffsetDeltaInBytes;

        [NativeTypeName("DWORD")]
        public uint SlabAllocationBitMapBitCount;

        [NativeTypeName("DWORD")]
        public uint SlabAllocationBitMapLength;

        [NativeTypeName("DWORD [1]")]
        public fixed uint SlabAllocationBitMap[1];
    }
}
