// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE"]/*' />
public partial struct EMRNAMEDESCAPE
{
    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.emr"]/*' />
    public EMR emr;

    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.iEscape"]/*' />
    public int iEscape;

    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.cbDriver"]/*' />
    public int cbDriver;

    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.cbEscData"]/*' />
    public int cbEscData;

    /// <include file='EMRNAMEDESCAPE.xml' path='doc/member[@name="EMRNAMEDESCAPE.EscData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _EscData_e__FixedBuffer EscData;

    /// <include file='_EscData_e__FixedBuffer.xml' path='doc/member[@name="_EscData_e__FixedBuffer"]/*' />
    public partial struct _EscData_e__FixedBuffer
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
