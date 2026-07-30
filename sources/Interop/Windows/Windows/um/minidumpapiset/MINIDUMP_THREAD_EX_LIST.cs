// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_EX_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_LIST"]/*' />
public partial struct MINIDUMP_THREAD_EX_LIST
{
    /// <include file='MINIDUMP_THREAD_EX_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_LIST.NumberOfThreads"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfThreads;

    /// <include file='MINIDUMP_THREAD_EX_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_EX_LIST.Threads"]/*' />
    [NativeTypeName("MINIDUMP_THREAD_EX[0]")]
    public _Threads_e__FixedBuffer Threads;

    /// <include file='_Threads_e__FixedBuffer.xml' path='doc/member[@name="_Threads_e__FixedBuffer"]/*' />
    public partial struct _Threads_e__FixedBuffer
    {
        public MINIDUMP_THREAD_EX e0;

        [UnscopedRef]
        public ref MINIDUMP_THREAD_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MINIDUMP_THREAD_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
