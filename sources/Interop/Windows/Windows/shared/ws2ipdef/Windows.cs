// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6_SET_ADDR_UNSPECIFIED"]/*' />
    public static void IN6_SET_ADDR_UNSPECIFIED([NativeTypeName("PIN6_ADDR")] IN6_ADDR* a)
    {
        NativeMemory.Fill(&a->u.Byte, (uint)(sizeof(IN6_ADDR)), 0);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6_SET_ADDR_LOOPBACK"]/*' />
    public static void IN6_SET_ADDR_LOOPBACK([NativeTypeName("PIN6_ADDR")] IN6_ADDR* a)
    {
        NativeMemory.Fill(&a->u.Byte, (uint)(sizeof(IN6_ADDR)), 0);
        a->u.Byte[15] = 1;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_SETANY"]/*' />
    public static void IN6ADDR_SETANY([NativeTypeName("PSOCKADDR_IN6")] SOCKADDR_IN6* a)
    {
        a->sin6_family = 23;
        a->sin6_port = 0;
        a->sin6_flowinfo = 0;
        IN6_SET_ADDR_UNSPECIFIED(&a->sin6_addr);
        a->Anonymous.sin6_scope_id = 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_SETLOOPBACK"]/*' />
    public static void IN6ADDR_SETLOOPBACK([NativeTypeName("PSOCKADDR_IN6")] SOCKADDR_IN6* a)
    {
        a->sin6_family = 23;
        a->sin6_port = 0;
        a->sin6_flowinfo = 0;
        IN6_SET_ADDR_LOOPBACK(&a->sin6_addr);
        a->Anonymous.sin6_scope_id = 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IFF_UP"]/*' />
    [NativeTypeName("#define IFF_UP 0x00000001")]
    public const int IFF_UP = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IFF_BROADCAST"]/*' />
    [NativeTypeName("#define IFF_BROADCAST 0x00000002")]
    public const int IFF_BROADCAST = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IFF_LOOPBACK"]/*' />
    [NativeTypeName("#define IFF_LOOPBACK 0x00000004")]
    public const int IFF_LOOPBACK = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IFF_POINTTOPOINT"]/*' />
    [NativeTypeName("#define IFF_POINTTOPOINT 0x00000008")]
    public const int IFF_POINTTOPOINT = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IFF_MULTICAST"]/*' />
    [NativeTypeName("#define IFF_MULTICAST 0x00000010")]
    public const int IFF_MULTICAST = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_LINKLOCALPREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_LINKLOCALPREFIX_LENGTH 64")]
    public const int IN6ADDR_LINKLOCALPREFIX_LENGTH = 64;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_MULTICASTPREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_MULTICASTPREFIX_LENGTH 8")]
    public const int IN6ADDR_MULTICASTPREFIX_LENGTH = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH 104")]
    public const int IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH = 104;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_V4MAPPEDPREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_V4MAPPEDPREFIX_LENGTH 96")]
    public const int IN6ADDR_V4MAPPEDPREFIX_LENGTH = 96;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_6TO4PREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_6TO4PREFIX_LENGTH 16")]
    public const int IN6ADDR_6TO4PREFIX_LENGTH = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IN6ADDR_TEREDOPREFIX_LENGTH"]/*' />
    [NativeTypeName("#define IN6ADDR_TEREDOPREFIX_LENGTH 32")]
    public const int IN6ADDR_TEREDOPREFIX_LENGTH = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIOCSIPMSFILTER"]/*' />
    [NativeTypeName("#define SIOCSIPMSFILTER SIO_SET_MULTICAST_FILTER")]
    public const uint SIOCSIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (125));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIOCGIPMSFILTER"]/*' />
    [NativeTypeName("#define SIOCGIPMSFILTER SIO_GET_MULTICAST_FILTER")]
    public const uint SIOCGIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (124 | 0x80000000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIOCSMSFILTER"]/*' />
    [NativeTypeName("#define SIOCSMSFILTER _IOW('t', 126, ULONG)")]
    public const uint SIOCSMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (126));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIOCGMSFILTER"]/*' />
    [NativeTypeName("#define SIOCGMSFILTER _IOW('t', 127 | IOC_IN, ULONG)")]
    public const uint SIOCGMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (127 | 0x80000000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INET6_ADDRSTRLEN"]/*' />
    [NativeTypeName("#define INET6_ADDRSTRLEN 65")]
    public const int INET6_ADDRSTRLEN = 65;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_SEND_MSG_SIZE"]/*' />
    [NativeTypeName("#define UDP_SEND_MSG_SIZE 2")]
    public const int UDP_SEND_MSG_SIZE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_RECV_MAX_COALESCED_SIZE"]/*' />
    [NativeTypeName("#define UDP_RECV_MAX_COALESCED_SIZE 3")]
    public const int UDP_RECV_MAX_COALESCED_SIZE = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_COALESCED_INFO"]/*' />
    [NativeTypeName("#define UDP_COALESCED_INFO 3")]
    public const int UDP_COALESCED_INFO = 3;
}
