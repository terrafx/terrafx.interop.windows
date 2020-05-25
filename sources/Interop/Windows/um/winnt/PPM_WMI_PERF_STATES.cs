// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PPM_WMI_PERF_STATES
    {
        [NativeTypeName("DWORD")]
        public uint Count;

        [NativeTypeName("DWORD")]
        public uint MaxFrequency;

        [NativeTypeName("DWORD")]
        public uint CurrentState;

        [NativeTypeName("DWORD")]
        public uint MaxPerfState;

        [NativeTypeName("DWORD")]
        public uint MinPerfState;

        [NativeTypeName("DWORD")]
        public uint LowestPerfState;

        [NativeTypeName("DWORD")]
        public uint ThermalConstraint;

        [NativeTypeName("BYTE")]
        public byte BusyAdjThreshold;

        [NativeTypeName("BYTE")]
        public byte PolicyType;

        [NativeTypeName("BYTE")]
        public byte Type;

        [NativeTypeName("BYTE")]
        public byte Reserved;

        [NativeTypeName("DWORD")]
        public uint TimerInterval;

        [NativeTypeName("DWORD64")]
        public ulong TargetProcessors;

        [NativeTypeName("DWORD")]
        public uint PStateHandler;

        [NativeTypeName("DWORD")]
        public uint PStateContext;

        [NativeTypeName("DWORD")]
        public uint TStateHandler;

        [NativeTypeName("DWORD")]
        public uint TStateContext;

        [NativeTypeName("DWORD")]
        public uint FeedbackHandler;

        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("DWORD64")]
        public ulong Reserved2;

        [NativeTypeName("PPM_WMI_PERF_STATE [1]")]
        public _State_e__FixedBuffer State;

        public partial struct _State_e__FixedBuffer
        {
            internal PPM_WMI_PERF_STATE e0;

            public ref PPM_WMI_PERF_STATE this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<PPM_WMI_PERF_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
