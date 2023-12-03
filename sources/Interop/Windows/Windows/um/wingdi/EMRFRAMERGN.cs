// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN"]/*' />
public partial struct EMRFRAMERGN
{
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.emr"]/*' />
    public EMR emr;

    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.cbRgnData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbRgnData;

    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.ihBrush"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihBrush;

    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.szlStroke"]/*' />
    [NativeTypeName("SIZEL")]
    public SIZE szlStroke;

    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.RgnData"]/*' />
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
