// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_THREAD_EX_LIST
    {
        [NativeTypeName("ULONG32")]
        public uint NumberOfThreads;

        [NativeTypeName("MINIDUMP_THREAD_EX [0]")]
        public _Threads_e__FixedBuffer Threads;

        public partial struct _Threads_e__FixedBuffer
        {
            public MINIDUMP_THREAD_EX e0;

            public ref MINIDUMP_THREAD_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MINIDUMP_THREAD_EX> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1);
        }
    }
}
