// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class GUID
{
    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_DeviceArrivedLaunch"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DeviceArrivedLaunch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0x9E, 0x0D, 0x74,
                0xF1, 0x70,
                0xD1, 0x11,
                0xAD,
                0x10,
                0x00,
                0xA0,
                0x24,
                0x38,
                0xAD,
                0x48
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_ScanImage"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ScanImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0xA7, 0xC5, 0xA6,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_ScanPrintImage"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ScanPrintImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x25, 0xF4, 0x41, 0xB4,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_ScanFaxImage"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_ScanFaxImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x93, 0xB7, 0x0E, 0xC0,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_STIUserDefined1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STIUserDefined1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x95, 0xB7, 0x0E, 0xC0,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_STIUserDefined2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STIUserDefined2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC5, 0xE9, 0x7A, 0xC7,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='GUID.xml' path='doc/member[@name="GUID.GUID_STIUserDefined3"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_STIUserDefined3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0xE9, 0x7A, 0xC7,
                0x6E, 0x8C,
                0xD2, 0x11,
                0x97,
                0x7A,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x92,
                0x6F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
