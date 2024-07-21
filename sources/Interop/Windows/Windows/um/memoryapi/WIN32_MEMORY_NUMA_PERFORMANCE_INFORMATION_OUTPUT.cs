// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT.xml' path='doc/member[@name="WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT"]/*' />
public partial struct WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT
{
    /// <include file='WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT.xml' path='doc/member[@name="WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT.EntryCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint EntryCount;

    /// <include file='WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT.xml' path='doc/member[@name="WIN32_MEMORY_NUMA_PERFORMANCE_INFORMATION_OUTPUT.PerformanceEntries"]/*' />
    [NativeTypeName("WIN32_MEMORY_NUMA_PERFORMANCE_ENTRY[1]")]
    public _PerformanceEntries_e__FixedBuffer PerformanceEntries;

    /// <include file='_PerformanceEntries_e__FixedBuffer.xml' path='doc/member[@name="_PerformanceEntries_e__FixedBuffer"]/*' />
    public partial struct _PerformanceEntries_e__FixedBuffer
    {
        public WIN32_MEMORY_NUMA_PERFORMANCE_ENTRY e0;

        [UnscopedRef]
        public ref WIN32_MEMORY_NUMA_PERFORMANCE_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WIN32_MEMORY_NUMA_PERFORMANCE_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
