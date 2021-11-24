// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct CM_POWER_DATA
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
        public DEVICE_POWER_STATE e0;
        public DEVICE_POWER_STATE e1;
        public DEVICE_POWER_STATE e2;
        public DEVICE_POWER_STATE e3;
        public DEVICE_POWER_STATE e4;
        public DEVICE_POWER_STATE e5;
        public DEVICE_POWER_STATE e6;

        public ref DEVICE_POWER_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<DEVICE_POWER_STATE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 7);
    }
}
