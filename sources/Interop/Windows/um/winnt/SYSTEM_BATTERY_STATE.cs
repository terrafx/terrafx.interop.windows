// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SYSTEM_BATTERY_STATE
    {
        [NativeTypeName("BOOLEAN")]
        public byte AcOnLine;

        [NativeTypeName("BOOLEAN")]
        public byte BatteryPresent;

        [NativeTypeName("BOOLEAN")]
        public byte Charging;

        [NativeTypeName("BOOLEAN")]
        public byte Discharging;

        [NativeTypeName("BOOLEAN [3]")]
        public fixed byte Spare1[3];

        [NativeTypeName("BYTE")]
        public byte Tag;

        [NativeTypeName("DWORD")]
        public uint MaxCapacity;

        [NativeTypeName("DWORD")]
        public uint RemainingCapacity;

        [NativeTypeName("DWORD")]
        public uint Rate;

        [NativeTypeName("DWORD")]
        public uint EstimatedTime;

        [NativeTypeName("DWORD")]
        public uint DefaultAlert1;

        [NativeTypeName("DWORD")]
        public uint DefaultAlert2;
    }
}
