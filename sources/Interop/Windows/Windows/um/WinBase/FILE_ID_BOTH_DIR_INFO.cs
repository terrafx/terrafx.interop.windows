// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct FILE_ID_BOTH_DIR_INFO
{
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    [NativeTypeName("DWORD")]
    public uint FileIndex;

    public LARGE_INTEGER CreationTime;

    public LARGE_INTEGER LastAccessTime;

    public LARGE_INTEGER LastWriteTime;

    public LARGE_INTEGER ChangeTime;

    public LARGE_INTEGER EndOfFile;

    public LARGE_INTEGER AllocationSize;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    [NativeTypeName("DWORD")]
    public uint EaSize;

    [NativeTypeName("CCHAR")]
    public sbyte ShortNameLength;

    [NativeTypeName("WCHAR [12]")]
    public fixed ushort ShortName[12];

    public LARGE_INTEGER FileId;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort FileName[1];
}
