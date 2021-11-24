// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct EXTLOGFONTW
{
    public LOGFONTW elfLogFont;

    [NativeTypeName("WCHAR [64]")]
    public fixed ushort elfFullName[64];

    [NativeTypeName("WCHAR [32]")]
    public fixed ushort elfStyle[32];

    [NativeTypeName("DWORD")]
    public uint elfVersion;

    [NativeTypeName("DWORD")]
    public uint elfStyleSize;

    [NativeTypeName("DWORD")]
    public uint elfMatch;

    [NativeTypeName("DWORD")]
    public uint elfReserved;

    [NativeTypeName("BYTE [4]")]
    public fixed byte elfVendorId[4];

    [NativeTypeName("DWORD")]
    public uint elfCulture;

    public PANOSE elfPanose;
}
