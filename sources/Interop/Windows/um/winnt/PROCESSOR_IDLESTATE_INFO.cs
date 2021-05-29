// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_IDLESTATE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        [NativeTypeName("BYTE")]
        public byte DemotePercent;

        [NativeTypeName("BYTE")]
        public byte PromotePercent;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Spare[2];
    }
}
