// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_MEMORY_LIST
    {
        [NativeTypeName("ULONG32")]
        public uint NumberOfMemoryRanges;

        [NativeTypeName("MINIDUMP_MEMORY_DESCRIPTOR [0]")]
        public _MemoryRanges_e__FixedBuffer MemoryRanges;

        public partial struct _MemoryRanges_e__FixedBuffer
        {
            public MINIDUMP_MEMORY_DESCRIPTOR e0;

            public ref MINIDUMP_MEMORY_DESCRIPTOR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MINIDUMP_MEMORY_DESCRIPTOR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1);
        }
    }
}
