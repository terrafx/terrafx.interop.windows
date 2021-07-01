// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SD_ENUM_SDS_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint Hash;

        [NativeTypeName("DWORD")]
        public uint SecurityId;

        [NativeTypeName("DWORDLONG")]
        public ulong Offset;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Descriptor[1];
    }
}
