// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='METARECORD.xml' path='doc/member[@name="METARECORD"]/*' />
public partial struct METARECORD
{
    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint rdSize;

    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdFunction"]/*' />
    [NativeTypeName("WORD")]
    public ushort rdFunction;

    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdParm"]/*' />
    [NativeTypeName("WORD[1]")]
    public _rdParm_e__FixedBuffer rdParm;

    /// <include file='_rdParm_e__FixedBuffer.xml' path='doc/member[@name="_rdParm_e__FixedBuffer"]/*' />
    public partial struct _rdParm_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
