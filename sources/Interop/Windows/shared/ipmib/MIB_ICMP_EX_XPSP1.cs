// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_ICMP_EX_XPSP1
    {
        [NativeTypeName("MIBICMPSTATS_EX")]
        public MIBICMPSTATS_EX_XPSP1 icmpInStats;

        [NativeTypeName("MIBICMPSTATS_EX")]
        public MIBICMPSTATS_EX_XPSP1 icmpOutStats;
    }
}
