// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD"]/*' />
public partial struct ENHMETARECORD
{
    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.iType"]/*' />
    [NativeTypeName("DWORD")]
    public uint iType;

    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.nSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nSize;

    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.dParm"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _dParm_e__FixedBuffer dParm;

    /// <include file='_dParm_e__FixedBuffer.xml' path='doc/member[@name="_dParm_e__FixedBuffer"]/*' />
    public partial struct _dParm_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
