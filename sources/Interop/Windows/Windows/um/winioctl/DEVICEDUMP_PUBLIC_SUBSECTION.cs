// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_PUBLIC_SUBSECTION
{
    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.GPLogTable"]/*' />
    [NativeTypeName("GP_LOG_PAGE_DESCRIPTOR[16]")]
    public _GPLogTable_e__FixedBuffer GPLogTable;

    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.szDescription"]/*' />
    [NativeTypeName("CHAR[16]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.bData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bData_e__FixedBuffer bData;

    /// <include file='_GPLogTable_e__FixedBuffer.xml' path='doc/member[@name="_GPLogTable_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _GPLogTable_e__FixedBuffer
    {
        public GP_LOG_PAGE_DESCRIPTOR e0;
    }

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_bData_e__FixedBuffer.xml' path='doc/member[@name="_bData_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _bData_e__FixedBuffer
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
