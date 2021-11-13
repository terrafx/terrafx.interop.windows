// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.16299.0")]
    public unsafe partial struct FILE_NOTIFY_EXTENDED_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        [NativeTypeName("DWORD")]
        public uint Action;

        public LARGE_INTEGER CreationTime;

        public LARGE_INTEGER LastModificationTime;

        public LARGE_INTEGER LastChangeTime;

        public LARGE_INTEGER LastAccessTime;

        public LARGE_INTEGER AllocatedLength;

        public LARGE_INTEGER FileSize;

        [NativeTypeName("DWORD")]
        public uint FileAttributes;

        [NativeTypeName("DWORD")]
        public uint ReparsePointTag;

        public LARGE_INTEGER FileId;

        public LARGE_INTEGER ParentFileId;

        [NativeTypeName("DWORD")]
        public uint FileNameLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}
