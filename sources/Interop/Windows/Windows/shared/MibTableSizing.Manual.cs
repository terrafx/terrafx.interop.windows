// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h, ipmib.h, Iprtrmib.h, tcpmib.h, and udpmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    private const int MibTableAlignmentSize = 8;

    public static nuint SIZEOF_IFTABLE(uint entryCount)
        => GetMibTableSize<MIB_IFTABLE, MIB_IFROW>(entryCount);

    public static nuint SIZEOF_IPADDRTABLE(uint entryCount)
        => GetMibTableSize<MIB_IPADDRTABLE, MIB_IPADDRROW_XP>(entryCount);

    public static nuint SIZEOF_IPFORWARDTABLE(uint entryCount)
        => GetMibTableSize<MIB_IPFORWARDTABLE, MIB_IPFORWARDROW>(entryCount);

    public static nuint SIZEOF_IPNETTABLE(uint entryCount)
        => GetMibTableSize<MIB_IPNETTABLE, MIB_IPNETROW_LH>(entryCount);

    public static nuint SIZEOF_MCAST_IF_TABLE(uint entryCount)
        => GetMibTableSize<MIB_IPMCAST_IF_TABLE, MIB_IPMCAST_IF_ENTRY>(entryCount);

    public static nuint SIZEOF_MIB_MFE(uint entryCount)
        => unchecked((nuint)SIZEOF_BASIC_MIB_MFE + ((nuint)entryCount * ((nuint)sizeof(MIB_IPMCAST_MFE) - SIZEOF_BASIC_MIB_MFE)));

    public static nuint SIZEOF_MIB_MFE_STATS(uint entryCount)
        => unchecked((nuint)SIZEOF_BASIC_MIB_MFE_STATS + ((nuint)entryCount * ((nuint)sizeof(MIB_IPMCAST_MFE_STATS) - SIZEOF_BASIC_MIB_MFE_STATS)));

    public static nuint SIZEOF_MIB_MFE_STATS_EX(uint entryCount)
        => unchecked((nuint)SIZEOF_BASIC_MIB_MFE_STATS_EX + ((nuint)entryCount * ((nuint)sizeof(MIB_IPMCAST_MFE_STATS_EX_XP) - SIZEOF_BASIC_MIB_MFE_STATS_EX)));

    public static nuint SIZEOF_BOUNDARY_TABLE(uint entryCount)
        => GetMibTableSize<MIB_IPMCAST_BOUNDARY_TABLE, MIB_IPMCAST_BOUNDARY>(entryCount);

    public static nuint SIZEOF_TCPTABLE(uint entryCount)
        => GetMibTableSize<MIB_TCPTABLE, MIB_TCPROW_LH>(entryCount);

    public static nuint SIZEOF_TCPTABLE2(uint entryCount)
        => GetMibTableSize<MIB_TCPTABLE2, MIB_TCPROW2>(entryCount);

    public static nuint SIZEOF_TCPTABLE_OWNER_PID(uint entryCount)
        => GetMibTableSize<MIB_TCPTABLE_OWNER_PID, MIB_TCPROW_OWNER_PID>(entryCount);

    public static nuint SIZEOF_TCPTABLE_OWNER_MODULE(uint entryCount)
        => GetMibTableSize<MIB_TCPTABLE_OWNER_MODULE, MIB_TCPROW_OWNER_MODULE>(entryCount);

    public static nuint SIZEOF_TCP6TABLE(uint entryCount)
        => GetMibTableSize<MIB_TCP6TABLE, MIB_TCP6ROW>(entryCount);

    public static nuint SIZEOF_TCP6TABLE2(uint entryCount)
        => GetMibTableSize<MIB_TCP6TABLE2, MIB_TCP6ROW2>(entryCount);

    public static nuint SIZEOF_TCP6TABLE_OWNER_PID(uint entryCount)
        => GetMibTableSize<MIB_TCP6TABLE_OWNER_PID, MIB_TCP6ROW_OWNER_PID>(entryCount);

    public static nuint SIZEOF_TCP6TABLE_OWNER_MODULE(uint entryCount)
        => GetMibTableSize<MIB_TCP6TABLE_OWNER_MODULE, MIB_TCP6ROW_OWNER_MODULE>(entryCount);

    public static nuint SIZEOF_UDPTABLE(uint entryCount)
        => GetMibTableSize<MIB_UDPTABLE, MIB_UDPROW>(entryCount);

    public static nuint SIZEOF_UDPTABLE_OWNER_PID(uint entryCount)
        => GetMibTableSize<MIB_UDPTABLE_OWNER_PID, MIB_UDPROW_OWNER_PID>(entryCount);

    public static nuint SIZEOF_UDPTABLE_OWNER_MODULE(uint entryCount)
        => GetMibTableSize<MIB_UDPTABLE_OWNER_MODULE, MIB_UDPROW_OWNER_MODULE>(entryCount);

    public static nuint SIZEOF_UDPTABLE2(uint entryCount)
        => GetMibTableSize<MIB_UDPTABLE2, MIB_UDPROW2>(entryCount);

    public static nuint SIZEOF_UDP6TABLE(uint entryCount)
        => GetMibTableSize<MIB_UDP6TABLE, MIB_UDP6ROW>(entryCount);

    public static nuint SIZEOF_UDP6TABLE_OWNER_PID(uint entryCount)
        => GetMibTableSize<MIB_UDP6TABLE_OWNER_PID, MIB_UDP6ROW_OWNER_PID>(entryCount);

    public static nuint SIZEOF_UDP6TABLE_OWNER_MODULE(uint entryCount)
        => GetMibTableSize<MIB_UDP6TABLE_OWNER_MODULE, MIB_UDP6ROW_OWNER_MODULE>(entryCount);

    public static nuint SIZEOF_UDP6TABLE2(uint entryCount)
        => GetMibTableSize<MIB_UDP6TABLE2, MIB_UDP6ROW2>(entryCount);

    public static nuint MIB_INFO_SIZE<T>() where T : unmanaged
        => (nuint)MAX.MAX_MIB_OFFSET + (nuint)sizeof(T);

    public static nuint MIB_INFO_SIZE_IN_DWORDS<T>() where T : unmanaged
        => (MIB_INFO_SIZE<T>() / (nuint)sizeof(uint)) + 1;

    public static T* CAST_MIB_INFO<T>(MIB_OPAQUE_INFO* info) where T : unmanaged
        => (T*)((byte*)info + MAX.MAX_MIB_OFFSET);

    private static nuint GetMibTableSize<TTable, TEntry>(uint entryCount)
        where TTable : struct
        where TEntry : unmanaged
    {
        nuint tableOffset = unchecked((nuint)Marshal.OffsetOf<TTable>("table").ToInt64());
        return unchecked(tableOffset + ((nuint)entryCount * (nuint)sizeof(TEntry)) + MibTableAlignmentSize);
    }
}
