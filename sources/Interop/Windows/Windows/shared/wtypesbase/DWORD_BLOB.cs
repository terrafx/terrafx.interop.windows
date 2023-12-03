// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB"]/*' />
public partial struct DWORD_BLOB
{
    /// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB.alData"]/*' />
    [NativeTypeName("ULONG[1]")]
    public _alData_e__FixedBuffer alData;

    /// <include file='_alData_e__FixedBuffer.xml' path='doc/member[@name="_alData_e__FixedBuffer"]/*' />
    public partial struct _alData_e__FixedBuffer
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
