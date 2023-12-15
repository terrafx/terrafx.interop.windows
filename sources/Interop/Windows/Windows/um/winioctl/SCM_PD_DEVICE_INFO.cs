// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO"]/*' />
public partial struct SCM_PD_DEVICE_INFO
{
    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.DeviceGuid"]/*' />
    public Guid DeviceGuid;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.UnsafeShutdownCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint UnsafeShutdownCount;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.PersistentMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong PersistentMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.VolatileMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong VolatileMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.TotalMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TotalMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SlotNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint SlotNumber;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.DeviceHandle"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceHandle;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.PhysicalId"]/*' />
    [NativeTypeName("WORD")]
    public ushort PhysicalId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.NumberOfFormatInterfaceCodes"]/*' />
    public byte NumberOfFormatInterfaceCodes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.FormatInterfaceCodes"]/*' />
    [NativeTypeName("WORD[8]")]
    public _FormatInterfaceCodes_e__FixedBuffer FormatInterfaceCodes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.VendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint VendorId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ProductId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProductId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SubsystemDeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubsystemDeviceId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SubsystemVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubsystemVendorId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingLocation"]/*' />
    public byte ManufacturingLocation;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingWeek"]/*' />
    public byte ManufacturingWeek;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingYear"]/*' />
    public byte ManufacturingYear;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumber4Byte"]/*' />
    [NativeTypeName("DWORD")]
    public uint SerialNumber4Byte;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumberLengthInChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint SerialNumberLengthInChars;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumber"]/*' />
    [NativeTypeName("CHAR[1]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    /// <include file='_FormatInterfaceCodes_e__FixedBuffer.xml' path='doc/member[@name="_FormatInterfaceCodes_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _FormatInterfaceCodes_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_SerialNumber_e__FixedBuffer.xml' path='doc/member[@name="_SerialNumber_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
