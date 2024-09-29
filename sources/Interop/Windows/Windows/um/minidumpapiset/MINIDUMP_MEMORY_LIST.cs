// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MEMORY_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_LIST"]/*' />
public partial struct MINIDUMP_MEMORY_LIST
{
    /// <include file='MINIDUMP_MEMORY_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_LIST.NumberOfMemoryRanges"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfMemoryRanges;

    /// <include file='MINIDUMP_MEMORY_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY_LIST.MemoryRanges"]/*' />
    [NativeTypeName("MINIDUMP_MEMORY_DESCRIPTOR[0]")]
    public _MemoryRanges_e__FixedBuffer MemoryRanges;

    /// <include file='_MemoryRanges_e__FixedBuffer.xml' path='doc/member[@name="_MemoryRanges_e__FixedBuffer"]/*' />
    public partial struct _MemoryRanges_e__FixedBuffer
    {
        public MINIDUMP_MEMORY_DESCRIPTOR e0;

        [UnscopedRef]
        public ref MINIDUMP_MEMORY_DESCRIPTOR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MINIDUMP_MEMORY_DESCRIPTOR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
