// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PERFORMANCE_DATA
    {
        [NativeTypeName("WORD")]
        public ushort Size;

        [NativeTypeName("BYTE")]
        public byte Version;

        [NativeTypeName("BYTE")]
        public byte HwCountersCount;

        [NativeTypeName("DWORD")]
        public uint ContextSwitchCount;

        [NativeTypeName("DWORD64")]
        public ulong WaitReasonBitMap;

        [NativeTypeName("DWORD64")]
        public ulong CycleTime;

        [NativeTypeName("DWORD")]
        public uint RetryCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("HARDWARE_COUNTER_DATA [16]")]
        public _HwCounters_e__FixedBuffer HwCounters;

        public partial struct _HwCounters_e__FixedBuffer
        {
            public HARDWARE_COUNTER_DATA e0;
            public HARDWARE_COUNTER_DATA e1;
            public HARDWARE_COUNTER_DATA e2;
            public HARDWARE_COUNTER_DATA e3;
            public HARDWARE_COUNTER_DATA e4;
            public HARDWARE_COUNTER_DATA e5;
            public HARDWARE_COUNTER_DATA e6;
            public HARDWARE_COUNTER_DATA e7;
            public HARDWARE_COUNTER_DATA e8;
            public HARDWARE_COUNTER_DATA e9;
            public HARDWARE_COUNTER_DATA e10;
            public HARDWARE_COUNTER_DATA e11;
            public HARDWARE_COUNTER_DATA e12;
            public HARDWARE_COUNTER_DATA e13;
            public HARDWARE_COUNTER_DATA e14;
            public HARDWARE_COUNTER_DATA e15;

            public ref HARDWARE_COUNTER_DATA this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<HARDWARE_COUNTER_DATA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
