// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA"]/*' />
public partial struct DEVICE_INTERNAL_STATUS_DATA
{
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.T10VendorId"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong T10VendorId;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet1Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSet1Length;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet2Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSet2Length;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet3Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSet3Length;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet4Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSet4Length;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusDataVersion"]/*' />
    public byte StatusDataVersion;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.ReasonIdentifier"]/*' />
    [NativeTypeName("BYTE[128]")]
    public _ReasonIdentifier_e__FixedBuffer ReasonIdentifier;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint StatusDataLength;

    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _StatusData_e__FixedBuffer StatusData;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ReasonIdentifier_e__FixedBuffer.xml' path='doc/member[@name="_ReasonIdentifier_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _ReasonIdentifier_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_StatusData_e__FixedBuffer.xml' path='doc/member[@name="_StatusData_e__FixedBuffer"]/*' />
    public partial struct _StatusData_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
