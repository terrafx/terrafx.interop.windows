// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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
            internal HARDWARE_COUNTER_DATA e0;
            internal HARDWARE_COUNTER_DATA e1;
            internal HARDWARE_COUNTER_DATA e2;
            internal HARDWARE_COUNTER_DATA e3;
            internal HARDWARE_COUNTER_DATA e4;
            internal HARDWARE_COUNTER_DATA e5;
            internal HARDWARE_COUNTER_DATA e6;
            internal HARDWARE_COUNTER_DATA e7;
            internal HARDWARE_COUNTER_DATA e8;
            internal HARDWARE_COUNTER_DATA e9;
            internal HARDWARE_COUNTER_DATA e10;
            internal HARDWARE_COUNTER_DATA e11;
            internal HARDWARE_COUNTER_DATA e12;
            internal HARDWARE_COUNTER_DATA e13;
            internal HARDWARE_COUNTER_DATA e14;
            internal HARDWARE_COUNTER_DATA e15;

            public ref HARDWARE_COUNTER_DATA this[int index] => ref AsSpan()[index];

            public Span<HARDWARE_COUNTER_DATA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
