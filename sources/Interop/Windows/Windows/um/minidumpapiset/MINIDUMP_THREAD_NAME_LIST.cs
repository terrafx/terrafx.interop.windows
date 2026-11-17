// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_NAME_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME_LIST"]/*' />
public partial struct MINIDUMP_THREAD_NAME_LIST
{
    /// <include file='MINIDUMP_THREAD_NAME_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME_LIST.NumberOfThreadNames"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfThreadNames;

    /// <include file='MINIDUMP_THREAD_NAME_LIST.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME_LIST.ThreadNames"]/*' />
    [NativeTypeName("MINIDUMP_THREAD_NAME[0]")]
    public _ThreadNames_e__FixedBuffer ThreadNames;

    /// <include file='_ThreadNames_e__FixedBuffer.xml' path='doc/member[@name="_ThreadNames_e__FixedBuffer"]/*' />
    public partial struct _ThreadNames_e__FixedBuffer
    {
        public MINIDUMP_THREAD_NAME e0;

        [UnscopedRef]
        public ref MINIDUMP_THREAD_NAME this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MINIDUMP_THREAD_NAME> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
