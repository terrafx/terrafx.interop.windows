// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IPV6
{
    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_ADDRESS_BITS"]/*' />
    [NativeTypeName("#define IPV6_ADDRESS_BITS RTL_BITS_OF(IN6_ADDR)")]
    public const uint IPV6_ADDRESS_BITS = (16 * 8);

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_HOPOPTS"]/*' />
    [NativeTypeName("#define IPV6_HOPOPTS 1")]
    public const int IPV6_HOPOPTS = 1;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_HDRINCL"]/*' />
    [NativeTypeName("#define IPV6_HDRINCL 2")]
    public const int IPV6_HDRINCL = 2;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_UNICAST_HOPS"]/*' />
    [NativeTypeName("#define IPV6_UNICAST_HOPS 4")]
    public const int IPV6_UNICAST_HOPS = 4;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_MULTICAST_IF"]/*' />
    [NativeTypeName("#define IPV6_MULTICAST_IF 9")]
    public const int IPV6_MULTICAST_IF = 9;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_MULTICAST_HOPS"]/*' />
    [NativeTypeName("#define IPV6_MULTICAST_HOPS 10")]
    public const int IPV6_MULTICAST_HOPS = 10;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_MULTICAST_LOOP"]/*' />
    [NativeTypeName("#define IPV6_MULTICAST_LOOP 11")]
    public const int IPV6_MULTICAST_LOOP = 11;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_ADD_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IPV6_ADD_MEMBERSHIP 12")]
    public const int IPV6_ADD_MEMBERSHIP = 12;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_JOIN_GROUP"]/*' />
    [NativeTypeName("#define IPV6_JOIN_GROUP IPV6_ADD_MEMBERSHIP")]
    public const int IPV6_JOIN_GROUP = 12;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_DROP_MEMBERSHIP"]/*' />
    [NativeTypeName("#define IPV6_DROP_MEMBERSHIP 13")]
    public const int IPV6_DROP_MEMBERSHIP = 13;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_LEAVE_GROUP"]/*' />
    [NativeTypeName("#define IPV6_LEAVE_GROUP IPV6_DROP_MEMBERSHIP")]
    public const int IPV6_LEAVE_GROUP = 13;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_DONTFRAG"]/*' />
    [NativeTypeName("#define IPV6_DONTFRAG 14")]
    public const int IPV6_DONTFRAG = 14;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_PKTINFO"]/*' />
    [NativeTypeName("#define IPV6_PKTINFO 19")]
    public const int IPV6_PKTINFO = 19;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_HOPLIMIT"]/*' />
    [NativeTypeName("#define IPV6_HOPLIMIT 21")]
    public const int IPV6_HOPLIMIT = 21;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_PROTECTION_LEVEL"]/*' />
    [NativeTypeName("#define IPV6_PROTECTION_LEVEL 23")]
    public const int IPV6_PROTECTION_LEVEL = 23;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVIF"]/*' />
    [NativeTypeName("#define IPV6_RECVIF 24")]
    public const int IPV6_RECVIF = 24;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVDSTADDR"]/*' />
    [NativeTypeName("#define IPV6_RECVDSTADDR 25")]
    public const int IPV6_RECVDSTADDR = 25;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_CHECKSUM"]/*' />
    [NativeTypeName("#define IPV6_CHECKSUM 26")]
    public const int IPV6_CHECKSUM = 26;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_V6ONLY"]/*' />
    [NativeTypeName("#define IPV6_V6ONLY 27")]
    public const int IPV6_V6ONLY = 27;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_IFLIST"]/*' />
    [NativeTypeName("#define IPV6_IFLIST 28")]
    public const int IPV6_IFLIST = 28;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_ADD_IFLIST"]/*' />
    [NativeTypeName("#define IPV6_ADD_IFLIST 29")]
    public const int IPV6_ADD_IFLIST = 29;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_DEL_IFLIST"]/*' />
    [NativeTypeName("#define IPV6_DEL_IFLIST 30")]
    public const int IPV6_DEL_IFLIST = 30;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_UNICAST_IF"]/*' />
    [NativeTypeName("#define IPV6_UNICAST_IF 31")]
    public const int IPV6_UNICAST_IF = 31;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RTHDR"]/*' />
    [NativeTypeName("#define IPV6_RTHDR 32")]
    public const int IPV6_RTHDR = 32;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_GET_IFLIST"]/*' />
    [NativeTypeName("#define IPV6_GET_IFLIST 33")]
    public const int IPV6_GET_IFLIST = 33;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVRTHDR"]/*' />
    [NativeTypeName("#define IPV6_RECVRTHDR 38")]
    public const int IPV6_RECVRTHDR = 38;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_TCLASS"]/*' />
    [NativeTypeName("#define IPV6_TCLASS 39")]
    public const int IPV6_TCLASS = 39;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVTCLASS"]/*' />
    [NativeTypeName("#define IPV6_RECVTCLASS 40")]
    public const int IPV6_RECVTCLASS = 40;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_ECN"]/*' />
    [NativeTypeName("#define IPV6_ECN 50")]
    public const int IPV6_ECN = 50;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVECN"]/*' />
    [NativeTypeName("#define IPV6_RECVECN 50")]
    public const int IPV6_RECVECN = 50;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_PKTINFO_EX"]/*' />
    [NativeTypeName("#define IPV6_PKTINFO_EX 51")]
    public const int IPV6_PKTINFO_EX = 51;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_WFP_REDIRECT_RECORDS"]/*' />
    [NativeTypeName("#define IPV6_WFP_REDIRECT_RECORDS 60")]
    public const int IPV6_WFP_REDIRECT_RECORDS = 60;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_WFP_REDIRECT_CONTEXT"]/*' />
    [NativeTypeName("#define IPV6_WFP_REDIRECT_CONTEXT 70")]
    public const int IPV6_WFP_REDIRECT_CONTEXT = 70;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_MTU_DISCOVER"]/*' />
    [NativeTypeName("#define IPV6_MTU_DISCOVER 71")]
    public const int IPV6_MTU_DISCOVER = 71;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_MTU"]/*' />
    [NativeTypeName("#define IPV6_MTU 72")]
    public const int IPV6_MTU = 72;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_NRT_INTERFACE"]/*' />
    [NativeTypeName("#define IPV6_NRT_INTERFACE 74")]
    public const int IPV6_NRT_INTERFACE = 74;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_RECVERR"]/*' />
    [NativeTypeName("#define IPV6_RECVERR 75")]
    public const int IPV6_RECVERR = 75;

    /// <include file='IPV6.xml' path='doc/member[@name="IPV6.IPV6_USER_MTU"]/*' />
    [NativeTypeName("#define IPV6_USER_MTU 76")]
    public const int IPV6_USER_MTU = 76;
}
