// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define AF_UNSPEC 0")]
        public const int AF_UNSPEC = 0;

        [NativeTypeName("#define AF_UNIX 1")]
        public const int AF_UNIX = 1;

        [NativeTypeName("#define AF_INET 2")]
        public const int AF_INET = 2;

        [NativeTypeName("#define AF_IMPLINK 3")]
        public const int AF_IMPLINK = 3;

        [NativeTypeName("#define AF_PUP 4")]
        public const int AF_PUP = 4;

        [NativeTypeName("#define AF_CHAOS 5")]
        public const int AF_CHAOS = 5;

        [NativeTypeName("#define AF_NS 6")]
        public const int AF_NS = 6;

        [NativeTypeName("#define AF_IPX AF_NS")]
        public const int AF_IPX = 6;

        [NativeTypeName("#define AF_ISO 7")]
        public const int AF_ISO = 7;

        [NativeTypeName("#define AF_OSI AF_ISO")]
        public const int AF_OSI = 7;

        [NativeTypeName("#define AF_ECMA 8")]
        public const int AF_ECMA = 8;

        [NativeTypeName("#define AF_DATAKIT 9")]
        public const int AF_DATAKIT = 9;

        [NativeTypeName("#define AF_CCITT 10")]
        public const int AF_CCITT = 10;

        [NativeTypeName("#define AF_SNA 11")]
        public const int AF_SNA = 11;

        [NativeTypeName("#define AF_DECnet 12")]
        public const int AF_DECnet = 12;

        [NativeTypeName("#define AF_DLI 13")]
        public const int AF_DLI = 13;

        [NativeTypeName("#define AF_LAT 14")]
        public const int AF_LAT = 14;

        [NativeTypeName("#define AF_HYLINK 15")]
        public const int AF_HYLINK = 15;

        [NativeTypeName("#define AF_APPLETALK 16")]
        public const int AF_APPLETALK = 16;

        [NativeTypeName("#define AF_NETBIOS 17")]
        public const int AF_NETBIOS = 17;

        [NativeTypeName("#define AF_VOICEVIEW 18")]
        public const int AF_VOICEVIEW = 18;

        [NativeTypeName("#define AF_FIREFOX 19")]
        public const int AF_FIREFOX = 19;

        [NativeTypeName("#define AF_UNKNOWN1 20")]
        public const int AF_UNKNOWN1 = 20;

        [NativeTypeName("#define AF_BAN 21")]
        public const int AF_BAN = 21;

        [NativeTypeName("#define AF_ATM 22")]
        public const int AF_ATM = 22;

        [NativeTypeName("#define AF_INET6 23")]
        public const int AF_INET6 = 23;

        [NativeTypeName("#define AF_CLUSTER 24")]
        public const int AF_CLUSTER = 24;

        [NativeTypeName("#define AF_12844 25")]
        public const int AF_12844 = 25;

        [NativeTypeName("#define AF_IRDA 26")]
        public const int AF_IRDA = 26;

        [NativeTypeName("#define AF_NETDES 28")]
        public const int AF_NETDES = 28;

        [NativeTypeName("#define AF_TCNPROCESS 29")]
        public const int AF_TCNPROCESS = 29;

        [NativeTypeName("#define AF_TCNMESSAGE 30")]
        public const int AF_TCNMESSAGE = 30;

        [NativeTypeName("#define AF_ICLFXBM 31")]
        public const int AF_ICLFXBM = 31;

        [NativeTypeName("#define AF_BTH 32")]
        public const int AF_BTH = 32;

        [NativeTypeName("#define AF_LINK 33")]
        public const int AF_LINK = 33;

        [NativeTypeName("#define AF_HYPERV 34")]
        public const int AF_HYPERV = 34;

        [NativeTypeName("#define AF_MAX 35")]
        public const int AF_MAX = 35;

        [NativeTypeName("#define SOCK_STREAM 1")]
        public const int SOCK_STREAM = 1;

        [NativeTypeName("#define SOCK_DGRAM 2")]
        public const int SOCK_DGRAM = 2;

        [NativeTypeName("#define SOCK_RAW 3")]
        public const int SOCK_RAW = 3;

        [NativeTypeName("#define SOCK_RDM 4")]
        public const int SOCK_RDM = 4;

        [NativeTypeName("#define SOCK_SEQPACKET 5")]
        public const int SOCK_SEQPACKET = 5;

        [NativeTypeName("#define SOL_SOCKET 0xffff")]
        public const int SOL_SOCKET = 0xffff;

        [NativeTypeName("#define SOL_IP (SOL_SOCKET-4)")]
        public const int SOL_IP = (0xffff - 4);

        [NativeTypeName("#define SOL_IPV6 (SOL_SOCKET-5)")]
        public const int SOL_IPV6 = (0xffff - 5);

        [NativeTypeName("#define SO_DEBUG 0x0001")]
        public const int SO_DEBUG = 0x0001;

        [NativeTypeName("#define SO_ACCEPTCONN 0x0002")]
        public const int SO_ACCEPTCONN = 0x0002;

        [NativeTypeName("#define SO_REUSEADDR 0x0004")]
        public const int SO_REUSEADDR = 0x0004;

        [NativeTypeName("#define SO_KEEPALIVE 0x0008")]
        public const int SO_KEEPALIVE = 0x0008;

        [NativeTypeName("#define SO_DONTROUTE 0x0010")]
        public const int SO_DONTROUTE = 0x0010;

        [NativeTypeName("#define SO_BROADCAST 0x0020")]
        public const int SO_BROADCAST = 0x0020;

        [NativeTypeName("#define SO_USELOOPBACK 0x0040")]
        public const int SO_USELOOPBACK = 0x0040;

        [NativeTypeName("#define SO_LINGER 0x0080")]
        public const int SO_LINGER = 0x0080;

        [NativeTypeName("#define SO_OOBINLINE 0x0100")]
        public const int SO_OOBINLINE = 0x0100;

        [NativeTypeName("#define SO_DONTLINGER (int)(~SO_LINGER)")]
        public const int SO_DONTLINGER = (int)(~0x0080);

        [NativeTypeName("#define SO_EXCLUSIVEADDRUSE ((int)(~SO_REUSEADDR))")]
        public const int SO_EXCLUSIVEADDRUSE = ((int)(~0x0004));

        [NativeTypeName("#define SO_SNDBUF 0x1001")]
        public const int SO_SNDBUF = 0x1001;

        [NativeTypeName("#define SO_RCVBUF 0x1002")]
        public const int SO_RCVBUF = 0x1002;

        [NativeTypeName("#define SO_SNDLOWAT 0x1003")]
        public const int SO_SNDLOWAT = 0x1003;

        [NativeTypeName("#define SO_RCVLOWAT 0x1004")]
        public const int SO_RCVLOWAT = 0x1004;

        [NativeTypeName("#define SO_SNDTIMEO 0x1005")]
        public const int SO_SNDTIMEO = 0x1005;

        [NativeTypeName("#define SO_RCVTIMEO 0x1006")]
        public const int SO_RCVTIMEO = 0x1006;

        [NativeTypeName("#define SO_ERROR 0x1007")]
        public const int SO_ERROR = 0x1007;

        [NativeTypeName("#define SO_TYPE 0x1008")]
        public const int SO_TYPE = 0x1008;

        [NativeTypeName("#define SO_BSP_STATE 0x1009")]
        public const int SO_BSP_STATE = 0x1009;

        [NativeTypeName("#define SO_GROUP_ID 0x2001")]
        public const int SO_GROUP_ID = 0x2001;

        [NativeTypeName("#define SO_GROUP_PRIORITY 0x2002")]
        public const int SO_GROUP_PRIORITY = 0x2002;

        [NativeTypeName("#define SO_MAX_MSG_SIZE 0x2003")]
        public const int SO_MAX_MSG_SIZE = 0x2003;

        [NativeTypeName("#define SO_CONDITIONAL_ACCEPT 0x3002")]
        public const int SO_CONDITIONAL_ACCEPT = 0x3002;

        [NativeTypeName("#define SO_PAUSE_ACCEPT 0x3003")]
        public const int SO_PAUSE_ACCEPT = 0x3003;

        [NativeTypeName("#define SO_COMPARTMENT_ID 0x3004")]
        public const int SO_COMPARTMENT_ID = 0x3004;

        [NativeTypeName("#define SO_RANDOMIZE_PORT 0x3005")]
        public const int SO_RANDOMIZE_PORT = 0x3005;

        [NativeTypeName("#define SO_PORT_SCALABILITY 0x3006")]
        public const int SO_PORT_SCALABILITY = 0x3006;

        [NativeTypeName("#define SO_REUSE_UNICASTPORT 0x3007")]
        public const int SO_REUSE_UNICASTPORT = 0x3007;

        [NativeTypeName("#define SO_REUSE_MULTICASTPORT 0x3008")]
        public const int SO_REUSE_MULTICASTPORT = 0x3008;

        [NativeTypeName("#define SO_ORIGINAL_DST 0x300F")]
        public const int SO_ORIGINAL_DST = 0x300F;

        [NativeTypeName("#define IP6T_SO_ORIGINAL_DST SO_ORIGINAL_DST")]
        public const int IP6T_SO_ORIGINAL_DST = 0x300F;

        [NativeTypeName("#define WSK_SO_BASE 0x4000")]
        public const int WSK_SO_BASE = 0x4000;

        [NativeTypeName("#define TCP_NODELAY 0x0001")]
        public const int TCP_NODELAY = 0x0001;

        [NativeTypeName("#define _SS_MAXSIZE 128")]
        public const int _SS_MAXSIZE = 128;

        [NativeTypeName("#define _SS_ALIGNSIZE (sizeof(__int64))")]
        public const uint _SS_ALIGNSIZE = (8);

        [NativeTypeName("#define _SS_PAD1SIZE (_SS_ALIGNSIZE - sizeof(USHORT))")]
        public const uint _SS_PAD1SIZE = ((8) - 2);

        [NativeTypeName("#define _SS_PAD2SIZE (_SS_MAXSIZE - (sizeof(USHORT) + _SS_PAD1SIZE + _SS_ALIGNSIZE))")]
        public const uint _SS_PAD2SIZE = (128 - (2 + ((8) - 2) + (8)));

        [NativeTypeName("#define IOC_UNIX 0x00000000")]
        public const int IOC_UNIX = 0x00000000;

        [NativeTypeName("#define IOC_WS2 0x08000000")]
        public const int IOC_WS2 = 0x08000000;

        [NativeTypeName("#define IOC_PROTOCOL 0x10000000")]
        public const int IOC_PROTOCOL = 0x10000000;

        [NativeTypeName("#define IOC_VENDOR 0x18000000")]
        public const int IOC_VENDOR = 0x18000000;

        [NativeTypeName("#define IOC_WSK (IOC_WS2|0x07000000)")]
        public const int IOC_WSK = (0x08000000 | 0x07000000);

        [NativeTypeName("#define SIO_ASSOCIATE_HANDLE _WSAIOW(IOC_WS2,1)")]
        public const uint SIO_ASSOCIATE_HANDLE = (0x80000000 | (0x08000000) | (1));

        [NativeTypeName("#define SIO_ENABLE_CIRCULAR_QUEUEING _WSAIO(IOC_WS2,2)")]
        public const int SIO_ENABLE_CIRCULAR_QUEUEING = (0x20000000 | (0x08000000) | (2));

        [NativeTypeName("#define SIO_FIND_ROUTE _WSAIOR(IOC_WS2,3)")]
        public const int SIO_FIND_ROUTE = (0x40000000 | (0x08000000) | (3));

        [NativeTypeName("#define SIO_FLUSH _WSAIO(IOC_WS2,4)")]
        public const int SIO_FLUSH = (0x20000000 | (0x08000000) | (4));

        [NativeTypeName("#define SIO_GET_BROADCAST_ADDRESS _WSAIOR(IOC_WS2,5)")]
        public const int SIO_GET_BROADCAST_ADDRESS = (0x40000000 | (0x08000000) | (5));

        [NativeTypeName("#define SIO_GET_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,6)")]
        public const uint SIO_GET_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (6));

        [NativeTypeName("#define SIO_GET_QOS _WSAIORW(IOC_WS2,7)")]
        public const uint SIO_GET_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (7));

        [NativeTypeName("#define SIO_GET_GROUP_QOS _WSAIORW(IOC_WS2,8)")]
        public const uint SIO_GET_GROUP_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (8));

        [NativeTypeName("#define SIO_MULTIPOINT_LOOPBACK _WSAIOW(IOC_WS2,9)")]
        public const uint SIO_MULTIPOINT_LOOPBACK = (0x80000000 | (0x08000000) | (9));

        [NativeTypeName("#define SIO_MULTICAST_SCOPE _WSAIOW(IOC_WS2,10)")]
        public const uint SIO_MULTICAST_SCOPE = (0x80000000 | (0x08000000) | (10));

        [NativeTypeName("#define SIO_SET_QOS _WSAIOW(IOC_WS2,11)")]
        public const uint SIO_SET_QOS = (0x80000000 | (0x08000000) | (11));

        [NativeTypeName("#define SIO_SET_GROUP_QOS _WSAIOW(IOC_WS2,12)")]
        public const uint SIO_SET_GROUP_QOS = (0x80000000 | (0x08000000) | (12));

        [NativeTypeName("#define SIO_TRANSLATE_HANDLE _WSAIORW(IOC_WS2,13)")]
        public const uint SIO_TRANSLATE_HANDLE = ((0x80000000 | 0x40000000) | (0x08000000) | (13));

        [NativeTypeName("#define SIO_ROUTING_INTERFACE_QUERY _WSAIORW(IOC_WS2,20)")]
        public const uint SIO_ROUTING_INTERFACE_QUERY = ((0x80000000 | 0x40000000) | (0x08000000) | (20));

        [NativeTypeName("#define SIO_ROUTING_INTERFACE_CHANGE _WSAIOW(IOC_WS2,21)")]
        public const uint SIO_ROUTING_INTERFACE_CHANGE = (0x80000000 | (0x08000000) | (21));

        [NativeTypeName("#define SIO_ADDRESS_LIST_QUERY _WSAIOR(IOC_WS2,22)")]
        public const int SIO_ADDRESS_LIST_QUERY = (0x40000000 | (0x08000000) | (22));

        [NativeTypeName("#define SIO_ADDRESS_LIST_CHANGE _WSAIO(IOC_WS2,23)")]
        public const int SIO_ADDRESS_LIST_CHANGE = (0x20000000 | (0x08000000) | (23));

        [NativeTypeName("#define SIO_QUERY_TARGET_PNP_HANDLE _WSAIOR(IOC_WS2,24)")]
        public const int SIO_QUERY_TARGET_PNP_HANDLE = (0x40000000 | (0x08000000) | (24));

        [NativeTypeName("#define SIO_QUERY_RSS_PROCESSOR_INFO _WSAIOR(IOC_WS2,37)")]
        public const int SIO_QUERY_RSS_PROCESSOR_INFO = (0x40000000 | (0x08000000) | (37));

        [NativeTypeName("#define SIO_ADDRESS_LIST_SORT _WSAIORW(IOC_WS2,25)")]
        public const uint SIO_ADDRESS_LIST_SORT = ((0x80000000 | 0x40000000) | (0x08000000) | (25));

        [NativeTypeName("#define SIO_RESERVED_1 _WSAIOW(IOC_WS2,26)")]
        public const uint SIO_RESERVED_1 = (0x80000000 | (0x08000000) | (26));

        [NativeTypeName("#define SIO_RESERVED_2 _WSAIOW(IOC_WS2,33)")]
        public const uint SIO_RESERVED_2 = (0x80000000 | (0x08000000) | (33));

        [NativeTypeName("#define SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,36)")]
        public const uint SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (36));

        [NativeTypeName("#define IPPROTO_IP 0")]
        public const int IPPROTO_IP = 0;

        [NativeTypeName("#define IPPORT_TCPMUX 1")]
        public const int IPPORT_TCPMUX = 1;

        [NativeTypeName("#define IPPORT_ECHO 7")]
        public const int IPPORT_ECHO = 7;

        [NativeTypeName("#define IPPORT_DISCARD 9")]
        public const int IPPORT_DISCARD = 9;

        [NativeTypeName("#define IPPORT_SYSTAT 11")]
        public const int IPPORT_SYSTAT = 11;

        [NativeTypeName("#define IPPORT_DAYTIME 13")]
        public const int IPPORT_DAYTIME = 13;

        [NativeTypeName("#define IPPORT_NETSTAT 15")]
        public const int IPPORT_NETSTAT = 15;

        [NativeTypeName("#define IPPORT_QOTD 17")]
        public const int IPPORT_QOTD = 17;

        [NativeTypeName("#define IPPORT_MSP 18")]
        public const int IPPORT_MSP = 18;

        [NativeTypeName("#define IPPORT_CHARGEN 19")]
        public const int IPPORT_CHARGEN = 19;

        [NativeTypeName("#define IPPORT_FTP_DATA 20")]
        public const int IPPORT_FTP_DATA = 20;

        [NativeTypeName("#define IPPORT_FTP 21")]
        public const int IPPORT_FTP = 21;

        [NativeTypeName("#define IPPORT_TELNET 23")]
        public const int IPPORT_TELNET = 23;

        [NativeTypeName("#define IPPORT_SMTP 25")]
        public const int IPPORT_SMTP = 25;

        [NativeTypeName("#define IPPORT_TIMESERVER 37")]
        public const int IPPORT_TIMESERVER = 37;

        [NativeTypeName("#define IPPORT_NAMESERVER 42")]
        public const int IPPORT_NAMESERVER = 42;

        [NativeTypeName("#define IPPORT_WHOIS 43")]
        public const int IPPORT_WHOIS = 43;

        [NativeTypeName("#define IPPORT_MTP 57")]
        public const int IPPORT_MTP = 57;

        [NativeTypeName("#define IPPORT_TFTP 69")]
        public const int IPPORT_TFTP = 69;

        [NativeTypeName("#define IPPORT_RJE 77")]
        public const int IPPORT_RJE = 77;

        [NativeTypeName("#define IPPORT_FINGER 79")]
        public const int IPPORT_FINGER = 79;

        [NativeTypeName("#define IPPORT_TTYLINK 87")]
        public const int IPPORT_TTYLINK = 87;

        [NativeTypeName("#define IPPORT_SUPDUP 95")]
        public const int IPPORT_SUPDUP = 95;

        [NativeTypeName("#define IPPORT_POP3 110")]
        public const int IPPORT_POP3 = 110;

        [NativeTypeName("#define IPPORT_NTP 123")]
        public const int IPPORT_NTP = 123;

        [NativeTypeName("#define IPPORT_EPMAP 135")]
        public const int IPPORT_EPMAP = 135;

        [NativeTypeName("#define IPPORT_NETBIOS_NS 137")]
        public const int IPPORT_NETBIOS_NS = 137;

        [NativeTypeName("#define IPPORT_NETBIOS_DGM 138")]
        public const int IPPORT_NETBIOS_DGM = 138;

        [NativeTypeName("#define IPPORT_NETBIOS_SSN 139")]
        public const int IPPORT_NETBIOS_SSN = 139;

        [NativeTypeName("#define IPPORT_IMAP 143")]
        public const int IPPORT_IMAP = 143;

        [NativeTypeName("#define IPPORT_SNMP 161")]
        public const int IPPORT_SNMP = 161;

        [NativeTypeName("#define IPPORT_SNMP_TRAP 162")]
        public const int IPPORT_SNMP_TRAP = 162;

        [NativeTypeName("#define IPPORT_IMAP3 220")]
        public const int IPPORT_IMAP3 = 220;

        [NativeTypeName("#define IPPORT_LDAP 389")]
        public const int IPPORT_LDAP = 389;

        [NativeTypeName("#define IPPORT_HTTPS 443")]
        public const int IPPORT_HTTPS = 443;

        [NativeTypeName("#define IPPORT_MICROSOFT_DS 445")]
        public const int IPPORT_MICROSOFT_DS = 445;

        [NativeTypeName("#define IPPORT_EXECSERVER 512")]
        public const int IPPORT_EXECSERVER = 512;

        [NativeTypeName("#define IPPORT_LOGINSERVER 513")]
        public const int IPPORT_LOGINSERVER = 513;

        [NativeTypeName("#define IPPORT_CMDSERVER 514")]
        public const int IPPORT_CMDSERVER = 514;

        [NativeTypeName("#define IPPORT_EFSSERVER 520")]
        public const int IPPORT_EFSSERVER = 520;

        [NativeTypeName("#define IPPORT_BIFFUDP 512")]
        public const int IPPORT_BIFFUDP = 512;

        [NativeTypeName("#define IPPORT_WHOSERVER 513")]
        public const int IPPORT_WHOSERVER = 513;

        [NativeTypeName("#define IPPORT_ROUTESERVER 520")]
        public const int IPPORT_ROUTESERVER = 520;

        [NativeTypeName("#define IPPORT_RESERVED 1024")]
        public const int IPPORT_RESERVED = 1024;

        [NativeTypeName("#define IPPORT_REGISTERED_MIN IPPORT_RESERVED")]
        public const int IPPORT_REGISTERED_MIN = 1024;

        [NativeTypeName("#define IPPORT_REGISTERED_MAX 0xbfff")]
        public const int IPPORT_REGISTERED_MAX = 0xbfff;

        [NativeTypeName("#define IPPORT_DYNAMIC_MIN 0xc000")]
        public const int IPPORT_DYNAMIC_MIN = 0xc000;

        [NativeTypeName("#define IPPORT_DYNAMIC_MAX 0xffff")]
        public const int IPPORT_DYNAMIC_MAX = 0xffff;

        [NativeTypeName("#define IN_CLASSA_NET 0xff000000")]
        public const uint IN_CLASSA_NET = 0xff000000;

        [NativeTypeName("#define IN_CLASSA_NSHIFT 24")]
        public const int IN_CLASSA_NSHIFT = 24;

        [NativeTypeName("#define IN_CLASSA_HOST 0x00ffffff")]
        public const int IN_CLASSA_HOST = 0x00ffffff;

        [NativeTypeName("#define IN_CLASSA_MAX 128")]
        public const int IN_CLASSA_MAX = 128;

        [NativeTypeName("#define IN_CLASSB_NET 0xffff0000")]
        public const uint IN_CLASSB_NET = 0xffff0000;

        [NativeTypeName("#define IN_CLASSB_NSHIFT 16")]
        public const int IN_CLASSB_NSHIFT = 16;

        [NativeTypeName("#define IN_CLASSB_HOST 0x0000ffff")]
        public const int IN_CLASSB_HOST = 0x0000ffff;

        [NativeTypeName("#define IN_CLASSB_MAX 65536")]
        public const int IN_CLASSB_MAX = 65536;

        [NativeTypeName("#define IN_CLASSC_NET 0xffffff00")]
        public const uint IN_CLASSC_NET = 0xffffff00;

        [NativeTypeName("#define IN_CLASSC_NSHIFT 8")]
        public const int IN_CLASSC_NSHIFT = 8;

        [NativeTypeName("#define IN_CLASSC_HOST 0x000000ff")]
        public const int IN_CLASSC_HOST = 0x000000ff;

        [NativeTypeName("#define IN_CLASSD_NET 0xf0000000")]
        public const uint IN_CLASSD_NET = 0xf0000000;

        [NativeTypeName("#define IN_CLASSD_NSHIFT 28")]
        public const int IN_CLASSD_NSHIFT = 28;

        [NativeTypeName("#define IN_CLASSD_HOST 0x0fffffff")]
        public const int IN_CLASSD_HOST = 0x0fffffff;

        [NativeTypeName("#define INADDR_ANY (ULONG)0x00000000")]
        public const uint INADDR_ANY = (uint)(0x00000000);

        [NativeTypeName("#define INADDR_LOOPBACK 0x7f000001")]
        public const int INADDR_LOOPBACK = 0x7f000001;

        [NativeTypeName("#define INADDR_BROADCAST (ULONG)0xffffffff")]
        public const uint INADDR_BROADCAST = (uint)(0xffffffff);

        [NativeTypeName("#define INADDR_NONE 0xffffffff")]
        public const uint INADDR_NONE = 0xffffffff;

        [NativeTypeName("#define IOCPARM_MASK 0x7f")]
        public const int IOCPARM_MASK = 0x7f;

        [NativeTypeName("#define IOC_VOID 0x20000000")]
        public const int IOC_VOID = 0x20000000;

        [NativeTypeName("#define IOC_OUT 0x40000000")]
        public const int IOC_OUT = 0x40000000;

        [NativeTypeName("#define IOC_IN 0x80000000")]
        public const uint IOC_IN = 0x80000000;

        [NativeTypeName("#define IOC_INOUT (IOC_IN|IOC_OUT)")]
        public const uint IOC_INOUT = (0x80000000 | 0x40000000);

        [NativeTypeName("#define MSG_TRUNC 0x0100")]
        public const int MSG_TRUNC = 0x0100;

        [NativeTypeName("#define MSG_CTRUNC 0x0200")]
        public const int MSG_CTRUNC = 0x0200;

        [NativeTypeName("#define MSG_BCAST 0x0400")]
        public const int MSG_BCAST = 0x0400;

        [NativeTypeName("#define MSG_MCAST 0x0800")]
        public const int MSG_MCAST = 0x0800;

        [NativeTypeName("#define MSG_ERRQUEUE 0x1000")]
        public const int MSG_ERRQUEUE = 0x1000;

        [NativeTypeName("#define AI_PASSIVE 0x00000001")]
        public const int AI_PASSIVE = 0x00000001;

        [NativeTypeName("#define AI_CANONNAME 0x00000002")]
        public const int AI_CANONNAME = 0x00000002;

        [NativeTypeName("#define AI_NUMERICHOST 0x00000004")]
        public const int AI_NUMERICHOST = 0x00000004;

        [NativeTypeName("#define AI_NUMERICSERV 0x00000008")]
        public const int AI_NUMERICSERV = 0x00000008;

        [NativeTypeName("#define AI_DNS_ONLY 0x00000010")]
        public const int AI_DNS_ONLY = 0x00000010;

        [NativeTypeName("#define AI_FORCE_CLEAR_TEXT 0x00000020")]
        public const int AI_FORCE_CLEAR_TEXT = 0x00000020;

        [NativeTypeName("#define AI_BYPASS_DNS_CACHE 0x00000040")]
        public const int AI_BYPASS_DNS_CACHE = 0x00000040;

        [NativeTypeName("#define AI_RETURN_TTL 0x00000080")]
        public const int AI_RETURN_TTL = 0x00000080;

        [NativeTypeName("#define AI_ALL 0x00000100")]
        public const int AI_ALL = 0x00000100;

        [NativeTypeName("#define AI_ADDRCONFIG 0x00000400")]
        public const int AI_ADDRCONFIG = 0x00000400;

        [NativeTypeName("#define AI_V4MAPPED 0x00000800")]
        public const int AI_V4MAPPED = 0x00000800;

        [NativeTypeName("#define AI_NON_AUTHORITATIVE 0x00004000")]
        public const int AI_NON_AUTHORITATIVE = 0x00004000;

        [NativeTypeName("#define AI_SECURE 0x00008000")]
        public const int AI_SECURE = 0x00008000;

        [NativeTypeName("#define AI_RETURN_PREFERRED_NAMES 0x00010000")]
        public const int AI_RETURN_PREFERRED_NAMES = 0x00010000;

        [NativeTypeName("#define AI_FQDN 0x00020000")]
        public const int AI_FQDN = 0x00020000;

        [NativeTypeName("#define AI_FILESERVER 0x00040000")]
        public const int AI_FILESERVER = 0x00040000;

        [NativeTypeName("#define AI_DISABLE_IDN_ENCODING 0x00080000")]
        public const int AI_DISABLE_IDN_ENCODING = 0x00080000;

        [NativeTypeName("#define AI_SECURE_WITH_FALLBACK 0x00100000")]
        public const int AI_SECURE_WITH_FALLBACK = 0x00100000;

        [NativeTypeName("#define AI_REQUIRE_SECURE 0x20000000")]
        public const int AI_REQUIRE_SECURE = 0x20000000;

        [NativeTypeName("#define AI_RESOLUTION_HANDLE 0x40000000")]
        public const int AI_RESOLUTION_HANDLE = 0x40000000;

        [NativeTypeName("#define AI_EXTENDED 0x80000000")]
        public const uint AI_EXTENDED = 0x80000000;

        [NativeTypeName("#define ADDRINFOEX_VERSION_2 2")]
        public const int ADDRINFOEX_VERSION_2 = 2;

        [NativeTypeName("#define ADDRINFOEX_VERSION_3 3")]
        public const int ADDRINFOEX_VERSION_3 = 3;

        [NativeTypeName("#define ADDRINFOEX_VERSION_4 4")]
        public const int ADDRINFOEX_VERSION_4 = 4;

        [NativeTypeName("#define ADDRINFOEX_VERSION_5 5")]
        public const int ADDRINFOEX_VERSION_5 = 5;

        [NativeTypeName("#define NS_ALL (0)")]
        public const int NS_ALL = (0);

        [NativeTypeName("#define NS_SAP (1)")]
        public const int NS_SAP = (1);

        [NativeTypeName("#define NS_NDS (2)")]
        public const int NS_NDS = (2);

        [NativeTypeName("#define NS_PEER_BROWSE (3)")]
        public const int NS_PEER_BROWSE = (3);

        [NativeTypeName("#define NS_SLP (5)")]
        public const int NS_SLP = (5);

        [NativeTypeName("#define NS_DHCP (6)")]
        public const int NS_DHCP = (6);

        [NativeTypeName("#define NS_TCPIP_LOCAL (10)")]
        public const int NS_TCPIP_LOCAL = (10);

        [NativeTypeName("#define NS_TCPIP_HOSTS (11)")]
        public const int NS_TCPIP_HOSTS = (11);

        [NativeTypeName("#define NS_DNS (12)")]
        public const int NS_DNS = (12);

        [NativeTypeName("#define NS_NETBT (13)")]
        public const int NS_NETBT = (13);

        [NativeTypeName("#define NS_WINS (14)")]
        public const int NS_WINS = (14);

        [NativeTypeName("#define NS_NLA (15)")]
        public const int NS_NLA = (15);

        [NativeTypeName("#define NS_BTH (16)")]
        public const int NS_BTH = (16);

        [NativeTypeName("#define NS_NBP (20)")]
        public const int NS_NBP = (20);

        [NativeTypeName("#define NS_MS (30)")]
        public const int NS_MS = (30);

        [NativeTypeName("#define NS_STDA (31)")]
        public const int NS_STDA = (31);

        [NativeTypeName("#define NS_NTDS (32)")]
        public const int NS_NTDS = (32);

        [NativeTypeName("#define NS_EMAIL (37)")]
        public const int NS_EMAIL = (37);

        [NativeTypeName("#define NS_PNRPNAME (38)")]
        public const int NS_PNRPNAME = (38);

        [NativeTypeName("#define NS_PNRPCLOUD (39)")]
        public const int NS_PNRPCLOUD = (39);

        [NativeTypeName("#define NS_X500 (40)")]
        public const int NS_X500 = (40);

        [NativeTypeName("#define NS_NIS (41)")]
        public const int NS_NIS = (41);

        [NativeTypeName("#define NS_NISPLUS (42)")]
        public const int NS_NISPLUS = (42);

        [NativeTypeName("#define NS_WRQ (50)")]
        public const int NS_WRQ = (50);

        [NativeTypeName("#define NS_NETDES (60)")]
        public const int NS_NETDES = (60);

        [NativeTypeName("#define NI_NOFQDN 0x01")]
        public const int NI_NOFQDN = 0x01;

        [NativeTypeName("#define NI_NUMERICHOST 0x02")]
        public const int NI_NUMERICHOST = 0x02;

        [NativeTypeName("#define NI_NAMEREQD 0x04")]
        public const int NI_NAMEREQD = 0x04;

        [NativeTypeName("#define NI_NUMERICSERV 0x08")]
        public const int NI_NUMERICSERV = 0x08;

        [NativeTypeName("#define NI_DGRAM 0x10")]
        public const int NI_DGRAM = 0x10;

        [NativeTypeName("#define NI_MAXHOST 1025")]
        public const int NI_MAXHOST = 1025;

        [NativeTypeName("#define NI_MAXSERV 32")]
        public const int NI_MAXSERV = 32;
    }
}
