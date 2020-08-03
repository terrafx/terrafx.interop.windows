// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY
    {
        [NativeTypeName("DWORDLONG")]
        public ulong Offset;

        [NativeTypeName("DWORD")]
        public uint NameFlags;

        [NativeTypeName("LONGLONG")]
        public long FileId;

        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("LONGLONG")]
        public long Reserved3;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}
