// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct IMAGEHLP_DEFERRED_SYMBOL_LOADW64
{
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;

    [NativeTypeName("DWORD")]
    public uint CheckSum;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("WCHAR [261]")]
    public fixed ushort FileName[261];

    [NativeTypeName("BOOLEAN")]
    public byte Reparse;

    public HANDLE hFile;

    [NativeTypeName("DWORD")]
    public uint Flags;
}
