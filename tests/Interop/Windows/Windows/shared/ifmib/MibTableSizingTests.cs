// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h, ipmib.h, Iprtrmib.h, tcpmib.h, and udpmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates table buffer sizing helpers for all supported MIB table layouts.</summary>
    [Test]
    public static void MibTableSizingTest()
    {
        const uint entryCount = 3;

        AssertTableSize<MIB_IFTABLE, MIB_IFROW>(SIZEOF_IFTABLE(entryCount), entryCount);
        AssertTableSize<MIB_IPADDRTABLE, MIB_IPADDRROW_XP>(SIZEOF_IPADDRTABLE(entryCount), entryCount);
        AssertTableSize<MIB_IPFORWARDTABLE, MIB_IPFORWARDROW>(SIZEOF_IPFORWARDTABLE(entryCount), entryCount);
        AssertTableSize<MIB_IPNETTABLE, MIB_IPNETROW_LH>(SIZEOF_IPNETTABLE(entryCount), entryCount);
        AssertTableSize<MIB_IPMCAST_IF_TABLE, MIB_IPMCAST_IF_ENTRY>(SIZEOF_MCAST_IF_TABLE(entryCount), entryCount);
        AssertTableSize<MIB_IPMCAST_BOUNDARY_TABLE, MIB_IPMCAST_BOUNDARY>(SIZEOF_BOUNDARY_TABLE(entryCount), entryCount);
        AssertTableSize<MIB_TCPTABLE, MIB_TCPROW_LH>(SIZEOF_TCPTABLE(entryCount), entryCount);
        AssertTableSize<MIB_TCPTABLE2, MIB_TCPROW2>(SIZEOF_TCPTABLE2(entryCount), entryCount);
        AssertTableSize<MIB_TCPTABLE_OWNER_PID, MIB_TCPROW_OWNER_PID>(SIZEOF_TCPTABLE_OWNER_PID(entryCount), entryCount);
        AssertTableSize<MIB_TCPTABLE_OWNER_MODULE, MIB_TCPROW_OWNER_MODULE>(SIZEOF_TCPTABLE_OWNER_MODULE(entryCount), entryCount);
        AssertTableSize<MIB_TCP6TABLE, MIB_TCP6ROW>(SIZEOF_TCP6TABLE(entryCount), entryCount);
        AssertTableSize<MIB_TCP6TABLE2, MIB_TCP6ROW2>(SIZEOF_TCP6TABLE2(entryCount), entryCount);
        AssertTableSize<MIB_TCP6TABLE_OWNER_PID, MIB_TCP6ROW_OWNER_PID>(SIZEOF_TCP6TABLE_OWNER_PID(entryCount), entryCount);
        AssertTableSize<MIB_TCP6TABLE_OWNER_MODULE, MIB_TCP6ROW_OWNER_MODULE>(SIZEOF_TCP6TABLE_OWNER_MODULE(entryCount), entryCount);
        AssertTableSize<MIB_UDPTABLE, MIB_UDPROW>(SIZEOF_UDPTABLE(entryCount), entryCount);
        AssertTableSize<MIB_UDPTABLE_OWNER_PID, MIB_UDPROW_OWNER_PID>(SIZEOF_UDPTABLE_OWNER_PID(entryCount), entryCount);
        AssertTableSize<MIB_UDPTABLE_OWNER_MODULE, MIB_UDPROW_OWNER_MODULE>(SIZEOF_UDPTABLE_OWNER_MODULE(entryCount), entryCount);
        AssertTableSize<MIB_UDPTABLE2, MIB_UDPROW2>(SIZEOF_UDPTABLE2(entryCount), entryCount);
        AssertTableSize<MIB_UDP6TABLE, MIB_UDP6ROW>(SIZEOF_UDP6TABLE(entryCount), entryCount);
        AssertTableSize<MIB_UDP6TABLE_OWNER_PID, MIB_UDP6ROW_OWNER_PID>(SIZEOF_UDP6TABLE_OWNER_PID(entryCount), entryCount);
        AssertTableSize<MIB_UDP6TABLE_OWNER_MODULE, MIB_UDP6ROW_OWNER_MODULE>(SIZEOF_UDP6TABLE_OWNER_MODULE(entryCount), entryCount);
        AssertTableSize<MIB_UDP6TABLE2, MIB_UDP6ROW2>(SIZEOF_UDP6TABLE2(entryCount), entryCount);

        Assert.That(SIZEOF_BASIC_MIB_MFE, Is.EqualTo((uint)Marshal.OffsetOf<MIB_IPMCAST_MFE>("rgmioOutInfo").ToInt32()));
        Assert.That(SIZEOF_MIB_MFE(entryCount), Is.EqualTo((nuint)SIZEOF_BASIC_MIB_MFE + ((nuint)entryCount * ((nuint)Unsafe.SizeOf<MIB_IPMCAST_MFE>() - SIZEOF_BASIC_MIB_MFE))));
        Assert.That(SIZEOF_BASIC_MIB_MFE_STATS, Is.EqualTo((uint)Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS>("rgmiosOutStats").ToInt32()));
        Assert.That(SIZEOF_MIB_MFE_STATS(entryCount), Is.EqualTo((nuint)SIZEOF_BASIC_MIB_MFE_STATS + ((nuint)entryCount * ((nuint)Unsafe.SizeOf<MIB_IPMCAST_MFE_STATS>() - SIZEOF_BASIC_MIB_MFE_STATS))));
        Assert.That(SIZEOF_BASIC_MIB_MFE_STATS_EX, Is.EqualTo((uint)Marshal.OffsetOf<MIB_IPMCAST_MFE_STATS_EX_XP>("rgmiosOutStats").ToInt32()));
        Assert.That(SIZEOF_MIB_MFE_STATS_EX(entryCount), Is.EqualTo((nuint)SIZEOF_BASIC_MIB_MFE_STATS_EX + ((nuint)entryCount * ((nuint)Unsafe.SizeOf<MIB_IPMCAST_MFE_STATS_EX_XP>() - SIZEOF_BASIC_MIB_MFE_STATS_EX))));
    }

    /// <summary>Validates opaque MIB buffer sizing and data-pointer helpers.</summary>
    [Test]
    public static void MibOpaqueInfoSizingTest()
    {
        Assert.That(MIB_INFO_SIZE<int>(), Is.EqualTo((nuint)12));
        Assert.That(MIB_INFO_SIZE_IN_DWORDS<int>(), Is.EqualTo((nuint)4));
        Assert.That(MIB_INFO_SIZE<ulong>(), Is.EqualTo((nuint)16));
        Assert.That(MIB_INFO_SIZE_IN_DWORDS<ulong>(), Is.EqualTo((nuint)5));

        MIB_OPAQUE_INFO info = default;
        int* data = CAST_MIB_INFO<int>(&info);
        Assert.That((nint)data - (nint)(&info), Is.EqualTo((nint)MAX.MAX_MIB_OFFSET));
    }

    /// <summary>Validates ICMP type classification macros.</summary>
    [Test]
    public static void IcmpTypeClassificationTest()
    {
        Assert.That(ICMP6_ISTYPEINFORMATIONAL(ICMP6_TYPE.ICMP6_ECHO_REQUEST), Is.True);
        Assert.That(ICMP6_ISTYPEINFORMATIONAL(ICMP6_TYPE.ICMP6_DST_UNREACH), Is.False);
        Assert.That(ICMP6_ISTYPEERROR(ICMP6_TYPE.ICMP6_DST_UNREACH), Is.True);
        Assert.That(ICMP6_ISTYPEERROR(ICMP6_TYPE.ICMP6_ECHO_REPLY), Is.False);
        Assert.That(ICMP4_ISTYPEERROR(ICMP4_TYPE.ICMP4_DST_UNREACH), Is.True);
        Assert.That(ICMP4_ISTYPEERROR(ICMP4_TYPE.ICMP4_TIME_EXCEEDED), Is.True);
        Assert.That(ICMP4_ISTYPEERROR(ICMP4_TYPE.ICMP4_ECHO_REPLY), Is.False);
    }

    private static void AssertTableSize<TTable, TEntry>(nuint actual, uint entryCount)
        where TTable : struct
        where TEntry : unmanaged
    {
        nuint offset = unchecked((nuint)Marshal.OffsetOf<TTable>("table").ToInt64());
        nuint expected = unchecked(offset + ((nuint)entryCount * (nuint)Unsafe.SizeOf<TEntry>()) + 8);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
