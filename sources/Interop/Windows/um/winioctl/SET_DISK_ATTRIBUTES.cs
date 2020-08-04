// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SET_DISK_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("BOOLEAN")]
        public byte Persist;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved1[3];

        [NativeTypeName("DWORDLONG")]
        public ulong Attributes;

        [NativeTypeName("DWORDLONG")]
        public ulong AttributesMask;

        [NativeTypeName("DWORD [4]")]
        public fixed uint Reserved2[4];
    }
}
