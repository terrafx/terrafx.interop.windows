// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MIBICMPSTATS_EX_XPSP1
    {
        [NativeTypeName("DWORD")]
        public uint dwMsgs;

        [NativeTypeName("DWORD")]
        public uint dwErrors;

        [NativeTypeName("DWORD [256]")]
        public fixed uint rgdwTypeCount[256];
    }
}
