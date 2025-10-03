// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MEMORY64_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY64_LIST"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_MEMORY64_LIST
{
    /// <include file='MINIDUMP_MEMORY64_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY64_LIST.NumberOfMemoryRanges"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong NumberOfMemoryRanges;

    /// <include file='MINIDUMP_MEMORY64_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY64_LIST.BaseRva"]/*' />
    [NativeTypeName("RVA64")]
    public ulong BaseRva;

    /// <include file='MINIDUMP_MEMORY64_LIST.xml' path='doc/member[@name="MINIDUMP_MEMORY64_LIST.MemoryRanges"]/*' />
    [NativeTypeName("MINIDUMP_MEMORY_DESCRIPTOR64[0]")]
    public _MemoryRanges_e__FixedBuffer MemoryRanges;

    /// <include file='_MemoryRanges_e__FixedBuffer.xml' path='doc/member[@name="_MemoryRanges_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _MemoryRanges_e__FixedBuffer
    {
        public MINIDUMP_MEMORY_DESCRIPTOR64 e0;

        [UnscopedRef]
        public ref MINIDUMP_MEMORY_DESCRIPTOR64 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MINIDUMP_MEMORY_DESCRIPTOR64> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
