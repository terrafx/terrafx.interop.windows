// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN"]/*' />
public partial struct EMRFILLRGN
{
    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.emr"]/*' />
    public EMR emr;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.cbRgnData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbRgnData;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.ihBrush"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihBrush;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.RgnData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _RgnData_e__FixedBuffer RgnData;

    /// <include file='_RgnData_e__FixedBuffer.xml' path='doc/member[@name="_RgnData_e__FixedBuffer"]/*' />
    public partial struct _RgnData_e__FixedBuffer
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
