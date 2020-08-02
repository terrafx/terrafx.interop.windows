// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2
    {
        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        [NativeTypeName("DWORD")]
        public uint ViolationLimitFlags;

        [NativeTypeName("DWORD64")]
        public ulong IoReadBytes;

        [NativeTypeName("DWORD64")]
        public ulong IoReadBytesLimit;

        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytes;

        [NativeTypeName("DWORD64")]
        public ulong IoWriteBytesLimit;

        public LARGE_INTEGER PerJobUserTime;

        public LARGE_INTEGER PerJobUserTimeLimit;

        [NativeTypeName("DWORD64")]
        public ulong JobMemory;

        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12073:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public ref ulong JobHighMemoryLimit => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobHighMemoryLimit, 1));

        public ref ulong JobMemoryLimit => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.JobMemoryLimit, 1));

        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12078:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.RateControlTolerance, 1));

        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.CpuRateControlTolerance, 1));

        [NativeTypeName("JOBOBJECT_LIMIT_VIOLATION_INFORMATION_2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12083:5)")]
        public _Anonymous3_e__Union Anonymous3;

        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.RateControlToleranceLimit, 1));

        public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous3.CpuRateControlToleranceLimit, 1));

        [NativeTypeName("DWORD64")]
        public ulong JobLowMemoryLimit;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlToleranceLimit;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;

        public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlToleranceLimit;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobHighMemoryLimit;

            [FieldOffset(0)]
            [NativeTypeName("DWORD64")]
            public ulong JobMemoryLimit;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlToleranceLimit;

            [FieldOffset(0)]
            public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlToleranceLimit;
        }
    }
}
