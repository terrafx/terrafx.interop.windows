// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HEAP_MEMORY_USAGE_INFORMATION.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_INFORMATION"]/*' />
public partial struct HEAP_MEMORY_USAGE_INFORMATION
{
    /// <include file='HEAP_MEMORY_USAGE_INFORMATION.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_INFORMATION.Version"]/*' />
    [NativeTypeName("WORD")]
    public ushort Version;

    /// <include file='HEAP_MEMORY_USAGE_INFORMATION.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_INFORMATION.EntryCount"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint EntryCount;

    /// <include file='HEAP_MEMORY_USAGE_INFORMATION.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_INFORMATION.Entries"]/*' />
    [NativeTypeName("HEAP_MEMORY_USAGE_ENTRY[1]")]
    public _Entries_e__FixedBuffer Entries;

    /// <include file='_Entries_e__FixedBuffer.xml' path='doc/member[@name="_Entries_e__FixedBuffer"]/*' />
    public partial struct _Entries_e__FixedBuffer
    {
        public HEAP_MEMORY_USAGE_ENTRY e0;

        [UnscopedRef]
        public ref HEAP_MEMORY_USAGE_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<HEAP_MEMORY_USAGE_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
