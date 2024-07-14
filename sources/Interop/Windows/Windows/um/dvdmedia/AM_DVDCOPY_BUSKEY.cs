// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY"]/*' />
public partial struct AM_DVDCOPY_BUSKEY
{
    /// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY.BusKey"]/*' />
    [NativeTypeName("BYTE[5]")]
    public _BusKey_e__FixedBuffer BusKey;

    /// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY.Reserved"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_BusKey_e__FixedBuffer.xml' path='doc/member[@name="_BusKey_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _BusKey_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    public partial struct _Reserved_e__FixedBuffer
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
