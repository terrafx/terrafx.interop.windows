// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_TEMPERATURE_DATA_DESCRIPTOR
{
    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.CriticalTemperature"]/*' />
    public short CriticalTemperature;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.WarningTemperature"]/*' />
    public short WarningTemperature;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.InfoCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort InfoCount;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.Reserved0"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.Reserved1"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='STORAGE_TEMPERATURE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_TEMPERATURE_DATA_DESCRIPTOR.TemperatureInfo"]/*' />
    [NativeTypeName("STORAGE_TEMPERATURE_INFO[1]")]
    public _TemperatureInfo_e__FixedBuffer TemperatureInfo;

    /// <include file='_Reserved0_e__FixedBuffer.xml' path='doc/member[@name="_Reserved0_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_TemperatureInfo_e__FixedBuffer.xml' path='doc/member[@name="_TemperatureInfo_e__FixedBuffer"]/*' />
    public partial struct _TemperatureInfo_e__FixedBuffer
    {
        public STORAGE_TEMPERATURE_INFO e0;

        [UnscopedRef]
        public ref STORAGE_TEMPERATURE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_TEMPERATURE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
