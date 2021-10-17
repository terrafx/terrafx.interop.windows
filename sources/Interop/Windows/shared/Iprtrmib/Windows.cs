// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define IPRTRMGR_PID 10000")]
        public const int IPRTRMGR_PID = 10000;

        [NativeTypeName("#define IF_NUMBER 0")]
        public const int IF_NUMBER = 0;

        [NativeTypeName("#define IF_TABLE (IF_NUMBER          + 1)")]
        public const int IF_TABLE = (0 + 1);

        [NativeTypeName("#define IF_ROW (IF_TABLE           + 1)")]
        public const int IF_ROW = ((0 + 1) + 1);

        [NativeTypeName("#define IP_STATS (IF_ROW             + 1)")]
        public const int IP_STATS = (((0 + 1) + 1) + 1);

        [NativeTypeName("#define IP_ADDRTABLE (IP_STATS           + 1)")]
        public const int IP_ADDRTABLE = ((((0 + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_ADDRROW (IP_ADDRTABLE       + 1)")]
        public const int IP_ADDRROW = (((((0 + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDNUMBER (IP_ADDRROW         + 1)")]
        public const int IP_FORWARDNUMBER = ((((((0 + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDTABLE (IP_FORWARDNUMBER   + 1)")]
        public const int IP_FORWARDTABLE = (((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDROW (IP_FORWARDTABLE    + 1)")]
        public const int IP_FORWARDROW = ((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_NETTABLE (IP_FORWARDROW      + 1)")]
        public const int IP_NETTABLE = (((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_NETROW (IP_NETTABLE        + 1)")]
        public const int IP_NETROW = ((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ICMP_STATS (IP_NETROW          + 1)")]
        public const int ICMP_STATS = (((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_STATS (ICMP_STATS         + 1)")]
        public const int TCP_STATS = ((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_TABLE (TCP_STATS          + 1)")]
        public const int TCP_TABLE = (((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_ROW (TCP_TABLE          + 1)")]
        public const int TCP_ROW = ((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_STATS (TCP_ROW            + 1)")]
        public const int UDP_STATS = (((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_TABLE (UDP_STATS          + 1)")]
        public const int UDP_TABLE = ((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_ROW (UDP_TABLE          + 1)")]
        public const int UDP_ROW = (((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE (UDP_ROW            + 1)")]
        public const int MCAST_MFE = ((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE_STATS (MCAST_MFE          + 1)")]
        public const int MCAST_MFE_STATS = (((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define BEST_IF (MCAST_MFE_STATS    + 1)")]
        public const int BEST_IF = ((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define BEST_ROUTE (BEST_IF            + 1)")]
        public const int BEST_ROUTE = (((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define PROXY_ARP (BEST_ROUTE         + 1)")]
        public const int PROXY_ARP = ((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_IF_ENTRY (PROXY_ARP          + 1)")]
        public const int MCAST_IF_ENTRY = (((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_GLOBAL (MCAST_IF_ENTRY     + 1)")]
        public const int MCAST_GLOBAL = ((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IF_STATUS (MCAST_GLOBAL       + 1)")]
        public const int IF_STATUS = (((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_BOUNDARY (IF_STATUS          + 1)")]
        public const int MCAST_BOUNDARY = ((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_SCOPE (MCAST_BOUNDARY     + 1)")]
        public const int MCAST_SCOPE = (((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_MATCHING (MCAST_SCOPE        + 1)")]
        public const int DEST_MATCHING = ((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_LONGER (DEST_MATCHING      + 1)")]
        public const int DEST_LONGER = (((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_SHORTER (DEST_LONGER        + 1)")]
        public const int DEST_SHORTER = ((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_MATCHING (DEST_SHORTER       + 1)")]
        public const int ROUTE_MATCHING = (((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_LONGER (ROUTE_MATCHING     + 1)")]
        public const int ROUTE_LONGER = ((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_SHORTER (ROUTE_LONGER       + 1)")]
        public const int ROUTE_SHORTER = (((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_STATE (ROUTE_SHORTER      + 1)")]
        public const int ROUTE_STATE = ((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE_STATS_EX (ROUTE_STATE        + 1)")]
        public const int MCAST_MFE_STATS_EX = (((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP6_STATS (MCAST_MFE_STATS_EX + 1)")]
        public const int IP6_STATS = ((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP6_STATS (IP6_STATS          + 1)")]
        public const int UDP6_STATS = (((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP6_STATS (UDP6_STATS         + 1)")]
        public const int TCP6_STATS = ((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define NUMBER_OF_EXPORTED_VARIABLES (TCP6_STATS + 1)")]
        public const int NUMBER_OF_EXPORTED_VARIABLES = (((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MAX_SCOPE_NAME_LEN 255")]
        public const int MAX_SCOPE_NAME_LEN = 255;

        [NativeTypeName("#define MAX_MIB_OFFSET 8")]
        public const int MAX_MIB_OFFSET = 8;
    }
}
