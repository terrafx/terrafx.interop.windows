// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public static void IN6_SET_ADDR_UNSPECIFIED([NativeTypeName("PIN6_ADDR")] IN6_ADDR* a)
        {
            Unsafe.InitBlockUnaligned(a->u.Byte, 0, (uint)(sizeof(IN6_ADDR)));
        }

        public static void IN6_SET_ADDR_LOOPBACK([NativeTypeName("PIN6_ADDR")] IN6_ADDR* a)
        {
            Unsafe.InitBlockUnaligned(a->u.Byte, 0, (uint)(sizeof(IN6_ADDR)));
            a->u.Byte[15] = 1;
        }

        public static void IN6ADDR_SETANY([NativeTypeName("PSOCKADDR_IN6")] SOCKADDR_IN6* a)
        {
            a->sin6_family = 23;
            a->sin6_port = 0;
            a->sin6_flowinfo = 0;
            IN6_SET_ADDR_UNSPECIFIED(&a->sin6_addr);
            a->Anonymous.sin6_scope_id = 0;
        }

        public static void IN6ADDR_SETLOOPBACK([NativeTypeName("PSOCKADDR_IN6")] SOCKADDR_IN6* a)
        {
            a->sin6_family = 23;
            a->sin6_port = 0;
            a->sin6_flowinfo = 0;
            IN6_SET_ADDR_LOOPBACK(&a->sin6_addr);
            a->Anonymous.sin6_scope_id = 0;
        }

        [NativeTypeName("#define IFF_UP 0x00000001")]
        public const int IFF_UP = 0x00000001;

        [NativeTypeName("#define IFF_BROADCAST 0x00000002")]
        public const int IFF_BROADCAST = 0x00000002;

        [NativeTypeName("#define IFF_LOOPBACK 0x00000004")]
        public const int IFF_LOOPBACK = 0x00000004;

        [NativeTypeName("#define IFF_POINTTOPOINT 0x00000008")]
        public const int IFF_POINTTOPOINT = 0x00000008;

        [NativeTypeName("#define IFF_MULTICAST 0x00000010")]
        public const int IFF_MULTICAST = 0x00000010;

        [NativeTypeName("#define IPV6_ADDRESS_BITS RTL_BITS_OF(IN6_ADDR)")]
        public const uint IPV6_ADDRESS_BITS = (16 * 8);

        [NativeTypeName("#define IN6ADDR_LINKLOCALPREFIX_LENGTH 64")]
        public const int IN6ADDR_LINKLOCALPREFIX_LENGTH = 64;

        [NativeTypeName("#define IN6ADDR_MULTICASTPREFIX_LENGTH 8")]
        public const int IN6ADDR_MULTICASTPREFIX_LENGTH = 8;

        [NativeTypeName("#define IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH 104")]
        public const int IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH = 104;

        [NativeTypeName("#define IN6ADDR_V4MAPPEDPREFIX_LENGTH 96")]
        public const int IN6ADDR_V4MAPPEDPREFIX_LENGTH = 96;

        [NativeTypeName("#define IN6ADDR_6TO4PREFIX_LENGTH 16")]
        public const int IN6ADDR_6TO4PREFIX_LENGTH = 16;

        [NativeTypeName("#define IN6ADDR_TEREDOPREFIX_LENGTH 32")]
        public const int IN6ADDR_TEREDOPREFIX_LENGTH = 32;

        [NativeTypeName("#define SIO_GET_INTERFACE_LIST _IOR('t', 127, ULONG)")]
        public const int SIO_GET_INTERFACE_LIST = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (127));

        [NativeTypeName("#define SIO_GET_INTERFACE_LIST_EX _IOR('t', 126, ULONG)")]
        public const int SIO_GET_INTERFACE_LIST_EX = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (126));

        [NativeTypeName("#define SIO_SET_MULTICAST_FILTER _IOW('t', 125, ULONG)")]
        public const uint SIO_SET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (125));

        [NativeTypeName("#define SIO_GET_MULTICAST_FILTER _IOW('t', 124 | IOC_IN, ULONG)")]
        public const uint SIO_GET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (124 | 0x80000000));

        [NativeTypeName("#define SIOCSIPMSFILTER SIO_SET_MULTICAST_FILTER")]
        public const uint SIOCSIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (125));

        [NativeTypeName("#define SIOCGIPMSFILTER SIO_GET_MULTICAST_FILTER")]
        public const uint SIOCGIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (124 | 0x80000000));

        [NativeTypeName("#define SIOCSMSFILTER _IOW('t', 126, ULONG)")]
        public const uint SIOCSMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (126));

        [NativeTypeName("#define SIOCGMSFILTER _IOW('t', 127 | IOC_IN, ULONG)")]
        public const uint SIOCGMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (127 | 0x80000000));

        [NativeTypeName("#define SIO_IDEAL_SEND_BACKLOG_QUERY _IOR('t', 123, ULONG)")]
        public const int SIO_IDEAL_SEND_BACKLOG_QUERY = (0x40000000 | (((int)(4) & 0x7f) << 16) | (('t') << 8) | (123));

        [NativeTypeName("#define SIO_IDEAL_SEND_BACKLOG_CHANGE _IO('t', 122)")]
        public const int SIO_IDEAL_SEND_BACKLOG_CHANGE = (0x20000000 | (('t') << 8) | (122));

        [NativeTypeName("#define MCAST_JOIN_GROUP 41")]
        public const int MCAST_JOIN_GROUP = 41;

        [NativeTypeName("#define MCAST_LEAVE_GROUP 42")]
        public const int MCAST_LEAVE_GROUP = 42;

        [NativeTypeName("#define MCAST_BLOCK_SOURCE 43")]
        public const int MCAST_BLOCK_SOURCE = 43;

        [NativeTypeName("#define MCAST_UNBLOCK_SOURCE 44")]
        public const int MCAST_UNBLOCK_SOURCE = 44;

        [NativeTypeName("#define MCAST_JOIN_SOURCE_GROUP 45")]
        public const int MCAST_JOIN_SOURCE_GROUP = 45;

        [NativeTypeName("#define MCAST_LEAVE_SOURCE_GROUP 46")]
        public const int MCAST_LEAVE_SOURCE_GROUP = 46;

        [NativeTypeName("#define IPV6_HOPOPTS 1")]
        public const int IPV6_HOPOPTS = 1;

        [NativeTypeName("#define IPV6_HDRINCL 2")]
        public const int IPV6_HDRINCL = 2;

        [NativeTypeName("#define IPV6_UNICAST_HOPS 4")]
        public const int IPV6_UNICAST_HOPS = 4;

        [NativeTypeName("#define IPV6_MULTICAST_IF 9")]
        public const int IPV6_MULTICAST_IF = 9;

        [NativeTypeName("#define IPV6_MULTICAST_HOPS 10")]
        public const int IPV6_MULTICAST_HOPS = 10;

        [NativeTypeName("#define IPV6_MULTICAST_LOOP 11")]
        public const int IPV6_MULTICAST_LOOP = 11;

        [NativeTypeName("#define IPV6_ADD_MEMBERSHIP 12")]
        public const int IPV6_ADD_MEMBERSHIP = 12;

        [NativeTypeName("#define IPV6_JOIN_GROUP IPV6_ADD_MEMBERSHIP")]
        public const int IPV6_JOIN_GROUP = 12;

        [NativeTypeName("#define IPV6_DROP_MEMBERSHIP 13")]
        public const int IPV6_DROP_MEMBERSHIP = 13;

        [NativeTypeName("#define IPV6_LEAVE_GROUP IPV6_DROP_MEMBERSHIP")]
        public const int IPV6_LEAVE_GROUP = 13;

        [NativeTypeName("#define IPV6_DONTFRAG 14")]
        public const int IPV6_DONTFRAG = 14;

        [NativeTypeName("#define IPV6_PKTINFO 19")]
        public const int IPV6_PKTINFO = 19;

        [NativeTypeName("#define IPV6_HOPLIMIT 21")]
        public const int IPV6_HOPLIMIT = 21;

        [NativeTypeName("#define IPV6_PROTECTION_LEVEL 23")]
        public const int IPV6_PROTECTION_LEVEL = 23;

        [NativeTypeName("#define IPV6_RECVIF 24")]
        public const int IPV6_RECVIF = 24;

        [NativeTypeName("#define IPV6_RECVDSTADDR 25")]
        public const int IPV6_RECVDSTADDR = 25;

        [NativeTypeName("#define IPV6_CHECKSUM 26")]
        public const int IPV6_CHECKSUM = 26;

        [NativeTypeName("#define IPV6_V6ONLY 27")]
        public const int IPV6_V6ONLY = 27;

        [NativeTypeName("#define IPV6_IFLIST 28")]
        public const int IPV6_IFLIST = 28;

        [NativeTypeName("#define IPV6_ADD_IFLIST 29")]
        public const int IPV6_ADD_IFLIST = 29;

        [NativeTypeName("#define IPV6_DEL_IFLIST 30")]
        public const int IPV6_DEL_IFLIST = 30;

        [NativeTypeName("#define IPV6_UNICAST_IF 31")]
        public const int IPV6_UNICAST_IF = 31;

        [NativeTypeName("#define IPV6_RTHDR 32")]
        public const int IPV6_RTHDR = 32;

        [NativeTypeName("#define IPV6_GET_IFLIST 33")]
        public const int IPV6_GET_IFLIST = 33;

        [NativeTypeName("#define IPV6_RECVRTHDR 38")]
        public const int IPV6_RECVRTHDR = 38;

        [NativeTypeName("#define IPV6_TCLASS 39")]
        public const int IPV6_TCLASS = 39;

        [NativeTypeName("#define IPV6_RECVTCLASS 40")]
        public const int IPV6_RECVTCLASS = 40;

        [NativeTypeName("#define IPV6_ECN 50")]
        public const int IPV6_ECN = 50;

        [NativeTypeName("#define IPV6_RECVECN 50")]
        public const int IPV6_RECVECN = 50;

        [NativeTypeName("#define IPV6_PKTINFO_EX 51")]
        public const int IPV6_PKTINFO_EX = 51;

        [NativeTypeName("#define IPV6_WFP_REDIRECT_RECORDS 60")]
        public const int IPV6_WFP_REDIRECT_RECORDS = 60;

        [NativeTypeName("#define IPV6_WFP_REDIRECT_CONTEXT 70")]
        public const int IPV6_WFP_REDIRECT_CONTEXT = 70;

        [NativeTypeName("#define IPV6_MTU_DISCOVER 71")]
        public const int IPV6_MTU_DISCOVER = 71;

        [NativeTypeName("#define IPV6_MTU 72")]
        public const int IPV6_MTU = 72;

        [NativeTypeName("#define IPV6_NRT_INTERFACE 74")]
        public const int IPV6_NRT_INTERFACE = 74;

        [NativeTypeName("#define IPV6_RECVERR 75")]
        public const int IPV6_RECVERR = 75;

        [NativeTypeName("#define IPV6_USER_MTU 76")]
        public const int IPV6_USER_MTU = 76;

        [NativeTypeName("#define PROTECTION_LEVEL_UNRESTRICTED 10")]
        public const int PROTECTION_LEVEL_UNRESTRICTED = 10;

        [NativeTypeName("#define PROTECTION_LEVEL_EDGERESTRICTED 20")]
        public const int PROTECTION_LEVEL_EDGERESTRICTED = 20;

        [NativeTypeName("#define PROTECTION_LEVEL_RESTRICTED 30")]
        public const int PROTECTION_LEVEL_RESTRICTED = 30;

        [NativeTypeName("#define PROTECTION_LEVEL_DEFAULT ((UINT)-1)")]
        public const uint PROTECTION_LEVEL_DEFAULT = unchecked((uint)(-1));

        [NativeTypeName("#define INET_ADDRSTRLEN 22")]
        public const int INET_ADDRSTRLEN = 22;

        [NativeTypeName("#define INET6_ADDRSTRLEN 65")]
        public const int INET6_ADDRSTRLEN = 65;

        [NativeTypeName("#define TCP_OFFLOAD_NO_PREFERENCE 0")]
        public const int TCP_OFFLOAD_NO_PREFERENCE = 0;

        [NativeTypeName("#define TCP_OFFLOAD_NOT_PREFERRED 1")]
        public const int TCP_OFFLOAD_NOT_PREFERRED = 1;

        [NativeTypeName("#define TCP_OFFLOAD_PREFERRED 2")]
        public const int TCP_OFFLOAD_PREFERRED = 2;

        [NativeTypeName("#define TCP_EXPEDITED_1122 0x0002")]
        public const int TCP_EXPEDITED_1122 = 0x0002;

        [NativeTypeName("#define TCP_KEEPALIVE 3")]
        public const int TCP_KEEPALIVE = 3;

        [NativeTypeName("#define TCP_MAXSEG 4")]
        public const int TCP_MAXSEG = 4;

        [NativeTypeName("#define TCP_MAXRT 5")]
        public const int TCP_MAXRT = 5;

        [NativeTypeName("#define TCP_STDURG 6")]
        public const int TCP_STDURG = 6;

        [NativeTypeName("#define TCP_NOURG 7")]
        public const int TCP_NOURG = 7;

        [NativeTypeName("#define TCP_ATMARK 8")]
        public const int TCP_ATMARK = 8;

        [NativeTypeName("#define TCP_NOSYNRETRIES 9")]
        public const int TCP_NOSYNRETRIES = 9;

        [NativeTypeName("#define TCP_TIMESTAMPS 10")]
        public const int TCP_TIMESTAMPS = 10;

        [NativeTypeName("#define TCP_OFFLOAD_PREFERENCE 11")]
        public const int TCP_OFFLOAD_PREFERENCE = 11;

        [NativeTypeName("#define TCP_CONGESTION_ALGORITHM 12")]
        public const int TCP_CONGESTION_ALGORITHM = 12;

        [NativeTypeName("#define TCP_DELAY_FIN_ACK 13")]
        public const int TCP_DELAY_FIN_ACK = 13;

        [NativeTypeName("#define TCP_MAXRTMS 14")]
        public const int TCP_MAXRTMS = 14;

        [NativeTypeName("#define TCP_FASTOPEN 15")]
        public const int TCP_FASTOPEN = 15;

        [NativeTypeName("#define TCP_KEEPCNT 16")]
        public const int TCP_KEEPCNT = 16;

        [NativeTypeName("#define TCP_KEEPIDLE TCP_KEEPALIVE")]
        public const int TCP_KEEPIDLE = 3;

        [NativeTypeName("#define TCP_KEEPINTVL 17")]
        public const int TCP_KEEPINTVL = 17;

        [NativeTypeName("#define TCP_FAIL_CONNECT_ON_ICMP_ERROR 18")]
        public const int TCP_FAIL_CONNECT_ON_ICMP_ERROR = 18;

        [NativeTypeName("#define TCP_ICMP_ERROR_INFO 19")]
        public const int TCP_ICMP_ERROR_INFO = 19;

        [NativeTypeName("#define UDP_SEND_MSG_SIZE 2")]
        public const int UDP_SEND_MSG_SIZE = 2;

        [NativeTypeName("#define UDP_RECV_MAX_COALESCED_SIZE 3")]
        public const int UDP_RECV_MAX_COALESCED_SIZE = 3;

        [NativeTypeName("#define UDP_COALESCED_INFO 3")]
        public const int UDP_COALESCED_INFO = 3;
    }
}
