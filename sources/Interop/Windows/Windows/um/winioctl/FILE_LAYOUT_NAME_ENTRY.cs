// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct FILE_LAYOUT_NAME_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint NextNameOffset;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;

    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort FileName[1];
}
