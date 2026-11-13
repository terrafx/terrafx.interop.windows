// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static bool ICMP6_ISTYPEINFORMATIONAL([NativeTypeName("ICMP6_TYPE")] ICMP6_TYPE type)
        => (((int)type & ICMP6_INFOMSG_MASK) != 0);

    public static bool ICMP6_ISTYPEERROR([NativeTypeName("ICMP6_TYPE")] ICMP6_TYPE type)
        => !ICMP6_ISTYPEINFORMATIONAL(type);

    public static bool ICMP4_ISTYPEERROR([NativeTypeName("ICMP4_TYPE")] ICMP4_TYPE type)
        => (type == ICMP4_TYPE.ICMP4_DST_UNREACH)
        || (type == ICMP4_TYPE.ICMP4_SOURCE_QUENCH)
        || (type == ICMP4_TYPE.ICMP4_REDIRECT)
        || (type == ICMP4_TYPE.ICMP4_PARAM_PROB)
        || (type == ICMP4_TYPE.ICMP4_TIME_EXCEEDED);

    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE, rgmioOutInfo[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Marshal.OffsetOf<MIB_IPMCAST_MFE>("rgmioOutInfo").ToInt32();
    }

    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS, rgmiosOutStats[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS>("rgmiosOutStats").ToInt32();
    }

    [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS_EX (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS_EX, rgmiosOutStats[0]))")]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS_EX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS_EX_XP>("rgmiosOutStats").ToInt32();
    }
}
