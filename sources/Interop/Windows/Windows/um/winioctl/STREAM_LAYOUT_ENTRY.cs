// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct STREAM_LAYOUT_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint NextStreamOffset;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ExtentInformationOffset;

    public LARGE_INTEGER AllocationSize;

    public LARGE_INTEGER EndOfFile;

    [NativeTypeName("DWORD")]
    public uint StreamInformationOffset;

    [NativeTypeName("DWORD")]
    public uint AttributeTypeCode;

    [NativeTypeName("DWORD")]
    public uint AttributeFlags;

    [NativeTypeName("DWORD")]
    public uint StreamIdentifierLength;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort StreamIdentifier[1];
}
