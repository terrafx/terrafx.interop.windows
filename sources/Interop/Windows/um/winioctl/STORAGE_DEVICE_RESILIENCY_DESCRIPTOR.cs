// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_DEVICE_RESILIENCY_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NameOffset;

        [NativeTypeName("DWORD")]
        public uint NumberOfLogicalCopies;

        [NativeTypeName("DWORD")]
        public uint NumberOfPhysicalCopies;

        [NativeTypeName("DWORD")]
        public uint PhysicalDiskRedundancy;

        [NativeTypeName("DWORD")]
        public uint NumberOfColumns;

        [NativeTypeName("DWORD")]
        public uint Interleave;
    }
}
