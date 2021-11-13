// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SYSTEM_POWER_POLICY
    {
        [NativeTypeName("DWORD")]
        public uint Revision;

        public POWER_ACTION_POLICY PowerButton;

        public POWER_ACTION_POLICY SleepButton;

        public POWER_ACTION_POLICY LidClose;

        public SYSTEM_POWER_STATE LidOpenWake;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        public POWER_ACTION_POLICY Idle;

        [NativeTypeName("DWORD")]
        public uint IdleTimeout;

        public byte IdleSensitivity;

        public byte DynamicThrottle;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Spare2[2];

        public SYSTEM_POWER_STATE MinSleep;

        public SYSTEM_POWER_STATE MaxSleep;

        public SYSTEM_POWER_STATE ReducedLatencySleep;

        [NativeTypeName("DWORD")]
        public uint WinLogonFlags;

        [NativeTypeName("DWORD")]
        public uint Spare3;

        [NativeTypeName("DWORD")]
        public uint DozeS4Timeout;

        [NativeTypeName("DWORD")]
        public uint BroadcastCapacityResolution;

        [NativeTypeName("SYSTEM_POWER_LEVEL [4]")]
        public _DischargePolicy_e__FixedBuffer DischargePolicy;

        [NativeTypeName("DWORD")]
        public uint VideoTimeout;

        [NativeTypeName("BOOLEAN")]
        public byte VideoDimDisplay;

        [NativeTypeName("DWORD [3]")]
        public fixed uint VideoReserved[3];

        [NativeTypeName("DWORD")]
        public uint SpindownTimeout;

        [NativeTypeName("BOOLEAN")]
        public byte OptimizeForPower;

        public byte FanThrottleTolerance;

        public byte ForcedThrottle;

        public byte MinThrottle;

        public POWER_ACTION_POLICY OverThrottled;

        public partial struct _DischargePolicy_e__FixedBuffer
        {
            public SYSTEM_POWER_LEVEL e0;
            public SYSTEM_POWER_LEVEL e1;
            public SYSTEM_POWER_LEVEL e2;
            public SYSTEM_POWER_LEVEL e3;

            public ref SYSTEM_POWER_LEVEL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SYSTEM_POWER_LEVEL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }
}
