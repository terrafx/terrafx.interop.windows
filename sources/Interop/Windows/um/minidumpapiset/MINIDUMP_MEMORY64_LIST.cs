// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_MEMORY64_LIST
    {
        [NativeTypeName("ULONG64")]
        public ulong NumberOfMemoryRanges;

        [NativeTypeName("RVA64")]
        public ulong BaseRva;

        [NativeTypeName("MINIDUMP_MEMORY_DESCRIPTOR64 [0]")]
        public _MemoryRanges_e__FixedBuffer MemoryRanges;

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public partial struct _MemoryRanges_e__FixedBuffer
        {
            public MINIDUMP_MEMORY_DESCRIPTOR64 e0;

            public ref MINIDUMP_MEMORY_DESCRIPTOR64 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MINIDUMP_MEMORY_DESCRIPTOR64> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1);
        }
    }
}
