// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct TAPE_GET_DRIVE_PARAMETERS
{
    [NativeTypeName("BOOLEAN")]
    public byte ECC;

    [NativeTypeName("BOOLEAN")]
    public byte Compression;

    [NativeTypeName("BOOLEAN")]
    public byte DataPadding;

    [NativeTypeName("BOOLEAN")]
    public byte ReportSetmarks;

    [NativeTypeName("DWORD")]
    public uint DefaultBlockSize;

    [NativeTypeName("DWORD")]
    public uint MaximumBlockSize;

    [NativeTypeName("DWORD")]
    public uint MinimumBlockSize;

    [NativeTypeName("DWORD")]
    public uint MaximumPartitionCount;

    [NativeTypeName("DWORD")]
    public uint FeaturesLow;

    [NativeTypeName("DWORD")]
    public uint FeaturesHigh;

    [NativeTypeName("DWORD")]
    public uint EOTWarningZoneSize;
}
