// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IP
{
    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPTIONS"]/*' />
    [NativeTypeName("#define IP_OPTIONS 1")]
    public const int IP_OPTIONS = 1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_HDRINCL"]/*' />
    [NativeTypeName("#define IP_HDRINCL 2")]
    public const int IP_HDRINCL = 2;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TOS"]/*' />
    [NativeTypeName("#define IP_TOS 3")]
    public const int IP_TOS = 3;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TTL"]/*' />
    [NativeTypeName("#define IP_TTL 4")]
    public const int IP_TTL = 4;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MULTICAST_IF"]/*' />
    [NativeTypeName("#define IP_MULTICAST_IF 9")]
    public const int IP_MULTICAST_IF = 9;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MULTICAST_TTL"]/*' />
    [NativeTypeName("#define IP_MULTICAST_TTL 10")]
    public const int IP_MULTICAST_TTL = 10;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MULTICAST_LOOP"]/*' />
    [NativeTypeName("#define IP_MULTICAST_LOOP 11")]
    public const int IP_MULTICAST_LOOP = 11;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADD_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IP_ADD_MEMBERSHIP 12")]
    public const int IP_ADD_MEMBERSHIP = 12;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DROP_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IP_DROP_MEMBERSHIP 13")]
    public const int IP_DROP_MEMBERSHIP = 13;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DONTFRAGMENT"]/*' />
    [NativeTypeName("#define IP_DONTFRAGMENT 14")]
    public const int IP_DONTFRAGMENT = 14;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADD_SOURCE_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IP_ADD_SOURCE_MEMBERSHIP 15")]
    public const int IP_ADD_SOURCE_MEMBERSHIP = 15;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DROP_SOURCE_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IP_DROP_SOURCE_MEMBERSHIP 16")]
    public const int IP_DROP_SOURCE_MEMBERSHIP = 16;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BLOCK_SOURCE"]/*' />
    [NativeTypeName("#define IP_BLOCK_SOURCE 17")]
    public const int IP_BLOCK_SOURCE = 17;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNBLOCK_SOURCE"]/*' />
    [NativeTypeName("#define IP_UNBLOCK_SOURCE 18")]
    public const int IP_UNBLOCK_SOURCE = 18;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PKTINFO"]/*' />
    [NativeTypeName("#define IP_PKTINFO 19")]
    public const int IP_PKTINFO = 19;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_HOPLIMIT"]/*' />
    [NativeTypeName("#define IP_HOPLIMIT 21")]
    public const int IP_HOPLIMIT = 21;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVTTL"]/*' />
    [NativeTypeName("#define IP_RECVTTL 21")]
    public const int IP_RECVTTL = 21;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECEIVE_BROADCAST"]/*' />
    [NativeTypeName("#define IP_RECEIVE_BROADCAST 22")]
    public const int IP_RECEIVE_BROADCAST = 22;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVIF"]/*' />
    [NativeTypeName("#define IP_RECVIF 24")]
    public const int IP_RECVIF = 24;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVDSTADDR"]/*' />
    [NativeTypeName("#define IP_RECVDSTADDR 25")]
    public const int IP_RECVDSTADDR = 25;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_IFLIST"]/*' />
    [NativeTypeName("#define IP_IFLIST 28")]
    public const int IP_IFLIST = 28;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADD_IFLIST"]/*' />
    [NativeTypeName("#define IP_ADD_IFLIST 29")]
    public const int IP_ADD_IFLIST = 29;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEL_IFLIST"]/*' />
    [NativeTypeName("#define IP_DEL_IFLIST 30")]
    public const int IP_DEL_IFLIST = 30;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNICAST_IF"]/*' />
    [NativeTypeName("#define IP_UNICAST_IF 31")]
    public const int IP_UNICAST_IF = 31;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RTHDR"]/*' />
    [NativeTypeName("#define IP_RTHDR 32")]
    public const int IP_RTHDR = 32;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_GET_IFLIST"]/*' />
    [NativeTypeName("#define IP_GET_IFLIST 33")]
    public const int IP_GET_IFLIST = 33;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVRTHDR"]/*' />
    [NativeTypeName("#define IP_RECVRTHDR 38")]
    public const int IP_RECVRTHDR = 38;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TCLASS"]/*' />
    [NativeTypeName("#define IP_TCLASS 39")]
    public const int IP_TCLASS = 39;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVTCLASS"]/*' />
    [NativeTypeName("#define IP_RECVTCLASS 40")]
    public const int IP_RECVTCLASS = 40;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVTOS"]/*' />
    [NativeTypeName("#define IP_RECVTOS 40")]
    public const int IP_RECVTOS = 40;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ORIGINAL_ARRIVAL_IF"]/*' />
    [NativeTypeName("#define IP_ORIGINAL_ARRIVAL_IF 47")]
    public const int IP_ORIGINAL_ARRIVAL_IF = 47;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ECN"]/*' />
    [NativeTypeName("#define IP_ECN 50")]
    public const int IP_ECN = 50;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVECN"]/*' />
    [NativeTypeName("#define IP_RECVECN 50")]
    public const int IP_RECVECN = 50;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PKTINFO_EX"]/*' />
    [NativeTypeName("#define IP_PKTINFO_EX 51")]
    public const int IP_PKTINFO_EX = 51;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_WFP_REDIRECT_RECORDS"]/*' />
    [NativeTypeName("#define IP_WFP_REDIRECT_RECORDS 60")]
    public const int IP_WFP_REDIRECT_RECORDS = 60;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_WFP_REDIRECT_CONTEXT"]/*' />
    [NativeTypeName("#define IP_WFP_REDIRECT_CONTEXT 70")]
    public const int IP_WFP_REDIRECT_CONTEXT = 70;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MTU_DISCOVER"]/*' />
    [NativeTypeName("#define IP_MTU_DISCOVER 71")]
    public const int IP_MTU_DISCOVER = 71;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MTU"]/*' />
    [NativeTypeName("#define IP_MTU 73")]
    public const int IP_MTU = 73;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_NRT_INTERFACE"]/*' />
    [NativeTypeName("#define IP_NRT_INTERFACE 74")]
    public const int IP_NRT_INTERFACE = 74;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECVERR"]/*' />
    [NativeTypeName("#define IP_RECVERR 75")]
    public const int IP_RECVERR = 75;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_USER_MTU"]/*' />
    [NativeTypeName("#define IP_USER_MTU 76")]
    public const int IP_USER_MTU = 76;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNSPECIFIED_TYPE_OF_SERVICE"]/*' />
    [NativeTypeName("#define IP_UNSPECIFIED_TYPE_OF_SERVICE -1")]
    public const int IP_UNSPECIFIED_TYPE_OF_SERVICE = -1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNSPECIFIED_HOP_LIMIT"]/*' />
    [NativeTypeName("#define IP_UNSPECIFIED_HOP_LIMIT -1")]
    public const int IP_UNSPECIFIED_HOP_LIMIT = -1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PROTECTION_LEVEL"]/*' />
    [NativeTypeName("#define IP_PROTECTION_LEVEL IPV6_PROTECTION_LEVEL")]
    public const int IP_PROTECTION_LEVEL = 23;
}
