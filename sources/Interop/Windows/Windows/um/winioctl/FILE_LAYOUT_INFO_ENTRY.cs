// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct FILE_LAYOUT_INFO_ENTRY
{
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:15218:5)")]
    public _BasicInformation_e__Struct BasicInformation;

    [NativeTypeName("DWORD")]
    public uint OwnerId;

    [NativeTypeName("DWORD")]
    public uint SecurityId;

    [NativeTypeName("USN")]
    public long Usn;

    public STORAGE_RESERVE_ID StorageReserveId;

    public partial struct _BasicInformation_e__Struct
    {
        public LARGE_INTEGER CreationTime;

        public LARGE_INTEGER LastAccessTime;

        public LARGE_INTEGER LastWriteTime;

        public LARGE_INTEGER ChangeTime;

        [NativeTypeName("DWORD")]
        public uint FileAttributes;
    }
}
