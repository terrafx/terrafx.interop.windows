// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE"]/*' />
public partial struct EMREXTESCAPE
{
    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.iEscape"]/*' />
    public int iEscape;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.cbEscData"]/*' />
    public int cbEscData;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.EscData"]/*' />
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
