// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct FLOATING_SAVE_AREA
{
    [NativeTypeName("DWORD")]
    public uint ControlWord;

    [NativeTypeName("DWORD")]
    public uint StatusWord;

    [NativeTypeName("DWORD")]
    public uint TagWord;

    [NativeTypeName("DWORD")]
    public uint ErrorOffset;

    [NativeTypeName("DWORD")]
    public uint ErrorSelector;

    [NativeTypeName("DWORD")]
    public uint DataOffset;

    [NativeTypeName("DWORD")]
    public uint DataSelector;

    [NativeTypeName("BYTE [80]")]
    public fixed byte RegisterArea[80];

    [NativeTypeName("DWORD")]
    public uint Spare0;
}
