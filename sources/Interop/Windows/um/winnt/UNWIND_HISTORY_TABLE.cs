// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct UNWIND_HISTORY_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint Count;

        public byte LocalHint;

        public byte GlobalHint;

        public byte Search;

        public byte Once;

        [NativeTypeName("ULONG_PTR")]
        public nuint LowAddress;

        [NativeTypeName("ULONG_PTR")]
        public nuint HighAddress;

        [NativeTypeName("UNWIND_HISTORY_TABLE_ENTRY [12]")]
        public _Entry_e__FixedBuffer Entry;

        public partial struct _Entry_e__FixedBuffer
        {
            public UNWIND_HISTORY_TABLE_ENTRY e0;
            public UNWIND_HISTORY_TABLE_ENTRY e1;
            public UNWIND_HISTORY_TABLE_ENTRY e2;
            public UNWIND_HISTORY_TABLE_ENTRY e3;
            public UNWIND_HISTORY_TABLE_ENTRY e4;
            public UNWIND_HISTORY_TABLE_ENTRY e5;
            public UNWIND_HISTORY_TABLE_ENTRY e6;
            public UNWIND_HISTORY_TABLE_ENTRY e7;
            public UNWIND_HISTORY_TABLE_ENTRY e8;
            public UNWIND_HISTORY_TABLE_ENTRY e9;
            public UNWIND_HISTORY_TABLE_ENTRY e10;
            public UNWIND_HISTORY_TABLE_ENTRY e11;

            public ref UNWIND_HISTORY_TABLE_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<UNWIND_HISTORY_TABLE_ENTRY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 12);
        }
    }
}
