// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SCM_PD_DEVICE_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    public Guid DeviceGuid;

    [NativeTypeName("DWORD")]
    public uint UnsafeShutdownCount;

    [NativeTypeName("DWORD64")]
    public ulong PersistentMemorySizeInBytes;

    [NativeTypeName("DWORD64")]
    public ulong VolatileMemorySizeInBytes;

    [NativeTypeName("DWORD64")]
    public ulong TotalMemorySizeInBytes;

    [NativeTypeName("DWORD")]
    public uint SlotNumber;

    [NativeTypeName("DWORD")]
    public uint DeviceHandle;

    [NativeTypeName("WORD")]
    public ushort PhysicalId;

    public byte NumberOfFormatInterfaceCodes;

    [NativeTypeName("WORD [8]")]
    public fixed ushort FormatInterfaceCodes[8];

    [NativeTypeName("DWORD")]
    public uint VendorId;

    [NativeTypeName("DWORD")]
    public uint ProductId;

    [NativeTypeName("DWORD")]
    public uint SubsystemDeviceId;

    [NativeTypeName("DWORD")]
    public uint SubsystemVendorId;

    public byte ManufacturingLocation;

    public byte ManufacturingWeek;

    public byte ManufacturingYear;

    [NativeTypeName("DWORD")]
    public uint SerialNumber4Byte;

    [NativeTypeName("DWORD")]
    public uint SerialNumberLengthInChars;

    [NativeTypeName("CHAR [1]")]
    public fixed sbyte SerialNumber[1];
}
