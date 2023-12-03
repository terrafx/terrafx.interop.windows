// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB"]/*' />
public partial struct WORD_BLOB
{
    /// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB.asData"]/*' />
    [NativeTypeName("unsigned short[1]")]
    public _asData_e__FixedBuffer asData;

    /// <include file='_asData_e__FixedBuffer.xml' path='doc/member[@name="_asData_e__FixedBuffer"]/*' />
    public partial struct _asData_e__FixedBuffer
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
