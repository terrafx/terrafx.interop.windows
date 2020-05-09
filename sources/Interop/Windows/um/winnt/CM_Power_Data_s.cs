// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CM_Power_Data_s
    {
        [NativeTypeName("DWORD")]
        public uint PD_Size;

        public DEVICE_POWER_STATE PD_MostRecentPowerState;

        [NativeTypeName("DWORD")]
        public uint PD_Capabilities;

        [NativeTypeName("DWORD")]
        public uint PD_D1Latency;

        [NativeTypeName("DWORD")]
        public uint PD_D2Latency;

        [NativeTypeName("DWORD")]
        public uint PD_D3Latency;

        [NativeTypeName("DEVICE_POWER_STATE [7]")]
        public _PD_PowerStateMapping_e__FixedBuffer PD_PowerStateMapping;

        public SYSTEM_POWER_STATE PD_DeepestSystemWake;

        public partial struct _PD_PowerStateMapping_e__FixedBuffer
        {
            internal DEVICE_POWER_STATE e0;
            internal DEVICE_POWER_STATE e1;
            internal DEVICE_POWER_STATE e2;
            internal DEVICE_POWER_STATE e3;
            internal DEVICE_POWER_STATE e4;
            internal DEVICE_POWER_STATE e5;
            internal DEVICE_POWER_STATE e6;

            public ref DEVICE_POWER_STATE this[int index] => ref AsSpan()[index];

            public Span<DEVICE_POWER_STATE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 7);
        }
    }
}
