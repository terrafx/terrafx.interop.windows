// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SYSTEM_POWER_LEVEL
    {
        [NativeTypeName("BOOLEAN")]
        public byte Enable;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Spare[3];

        [NativeTypeName("DWORD")]
        public uint BatteryLevel;

        public POWER_ACTION_POLICY PowerPolicy;

        public SYSTEM_POWER_STATE MinSystemState;
    }
}
