// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STORAGE_PHYSICAL_NODE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint NodeId;

        [NativeTypeName("DWORD")]
        public uint AdapterCount;

        [NativeTypeName("DWORD")]
        public uint AdapterDataLength;

        [NativeTypeName("DWORD")]
        public uint AdapterDataOffset;

        [NativeTypeName("DWORD")]
        public uint DeviceCount;

        [NativeTypeName("DWORD")]
        public uint DeviceDataLength;

        [NativeTypeName("DWORD")]
        public uint DeviceDataOffset;

        [NativeTypeName("DWORD [3]")]
        public fixed uint Reserved[3];
    }
}
