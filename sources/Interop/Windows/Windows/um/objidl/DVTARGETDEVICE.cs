// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct DVTARGETDEVICE
{
    [NativeTypeName("DWORD")]
    public uint tdSize;

    [NativeTypeName("WORD")]
    public ushort tdDriverNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdDeviceNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdPortNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdExtDevmodeOffset;

    [NativeTypeName("BYTE [1]")]
    public fixed byte tdData[1];
}
