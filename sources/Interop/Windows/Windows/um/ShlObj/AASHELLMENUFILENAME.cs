// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME"]/*' />
public partial struct AASHELLMENUFILENAME
{
    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.cbTotal"]/*' />
    public short cbTotal;

    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.rgbReserved"]/*' />
    [NativeTypeName("BYTE[12]")]
    public _rgbReserved_e__FixedBuffer rgbReserved;

    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.szFileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _szFileName_e__FixedBuffer szFileName;

    /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
    [InlineArray(12)]
    public partial struct _rgbReserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_szFileName_e__FixedBuffer.xml' path='doc/member[@name="_szFileName_e__FixedBuffer"]/*' />
    public partial struct _szFileName_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
