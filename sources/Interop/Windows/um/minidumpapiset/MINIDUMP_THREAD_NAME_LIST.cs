// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_THREAD_NAME_LIST
    {
        [NativeTypeName("ULONG")]
        public uint NumberOfThreadNames;

        [NativeTypeName("MINIDUMP_THREAD_NAME [0]")]
        public _ThreadNames_e__FixedBuffer ThreadNames;

        public partial struct _ThreadNames_e__FixedBuffer
        {
            public MINIDUMP_THREAD_NAME e0;

            public ref MINIDUMP_THREAD_NAME this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MINIDUMP_THREAD_NAME> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1);
        }
    }
}
