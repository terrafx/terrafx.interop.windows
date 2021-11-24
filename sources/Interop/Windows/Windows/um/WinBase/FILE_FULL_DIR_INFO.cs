// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public unsafe partial struct FILE_FULL_DIR_INFO
{
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;

    [NativeTypeName("ULONG")]
    public uint FileIndex;

    public LARGE_INTEGER CreationTime;

    public LARGE_INTEGER LastAccessTime;

    public LARGE_INTEGER LastWriteTime;

    public LARGE_INTEGER ChangeTime;

    public LARGE_INTEGER EndOfFile;

    public LARGE_INTEGER AllocationSize;

    [NativeTypeName("ULONG")]
    public uint FileAttributes;

    [NativeTypeName("ULONG")]
    public uint FileNameLength;

    [NativeTypeName("ULONG")]
    public uint EaSize;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort FileName[1];
}
