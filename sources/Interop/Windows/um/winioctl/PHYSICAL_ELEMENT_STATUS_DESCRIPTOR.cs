// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PHYSICAL_ELEMENT_STATUS_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint ElementIdentifier;

        public byte PhysicalElementType;

        public byte PhysicalElementHealth;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved1[2];

        [NativeTypeName("DWORDLONG")]
        public ulong AssociatedCapacity;

        [NativeTypeName("DWORD [4]")]
        public fixed uint Reserved2[4];
    }
}
