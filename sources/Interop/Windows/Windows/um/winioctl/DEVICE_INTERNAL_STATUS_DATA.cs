// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct DEVICE_INTERNAL_STATUS_DATA
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORDLONG")]
    public ulong T10VendorId;

    [NativeTypeName("DWORD")]
    public uint DataSet1Length;

    [NativeTypeName("DWORD")]
    public uint DataSet2Length;

    [NativeTypeName("DWORD")]
    public uint DataSet3Length;

    [NativeTypeName("DWORD")]
    public uint DataSet4Length;

    public byte StatusDataVersion;

    [NativeTypeName("BYTE [3]")]
    public fixed byte Reserved[3];

    [NativeTypeName("BYTE [128]")]
    public fixed byte ReasonIdentifier[128];

    [NativeTypeName("DWORD")]
    public uint StatusDataLength;

    [NativeTypeName("BYTE [1]")]
    public fixed byte StatusData[1];
}
