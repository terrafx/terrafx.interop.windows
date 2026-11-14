// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IP
{
    /// <include file='IP.xml' path='doc/member[@name="IP.IP_EXPORT_INCLUDED"]/*' />
    [NativeTypeName("#define IP_EXPORT_INCLUDED 1")]
    public const int IP_EXPORT_INCLUDED = 1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_STATUS_BASE"]/*' />
    [NativeTypeName("#define IP_STATUS_BASE 11000")]
    public const int IP_STATUS_BASE = 11000;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_SUCCESS"]/*' />
    [NativeTypeName("#define IP_SUCCESS 0")]
    public const int IP_SUCCESS = 0;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BUF_TOO_SMALL"]/*' />
    [NativeTypeName("#define IP_BUF_TOO_SMALL (IP_STATUS_BASE + 1)")]
    public const int IP_BUF_TOO_SMALL = (11000 + 1);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_NET_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_NET_UNREACHABLE (IP_STATUS_BASE + 2)")]
    public const int IP_DEST_NET_UNREACHABLE = (11000 + 2);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_HOST_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_HOST_UNREACHABLE (IP_STATUS_BASE + 3)")]
    public const int IP_DEST_HOST_UNREACHABLE = (11000 + 3);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_PROT_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_PROT_UNREACHABLE (IP_STATUS_BASE + 4)")]
    public const int IP_DEST_PROT_UNREACHABLE = (11000 + 4);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_PORT_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_PORT_UNREACHABLE (IP_STATUS_BASE + 5)")]
    public const int IP_DEST_PORT_UNREACHABLE = (11000 + 5);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_NO_RESOURCES"]/*' />
    [NativeTypeName("#define IP_NO_RESOURCES (IP_STATUS_BASE + 6)")]
    public const int IP_NO_RESOURCES = (11000 + 6);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BAD_OPTION"]/*' />
    [NativeTypeName("#define IP_BAD_OPTION (IP_STATUS_BASE + 7)")]
    public const int IP_BAD_OPTION = (11000 + 7);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_HW_ERROR"]/*' />
    [NativeTypeName("#define IP_HW_ERROR (IP_STATUS_BASE + 8)")]
    public const int IP_HW_ERROR = (11000 + 8);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PACKET_TOO_BIG"]/*' />
    [NativeTypeName("#define IP_PACKET_TOO_BIG (IP_STATUS_BASE + 9)")]
    public const int IP_PACKET_TOO_BIG = (11000 + 9);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_REQ_TIMED_OUT"]/*' />
    [NativeTypeName("#define IP_REQ_TIMED_OUT (IP_STATUS_BASE + 10)")]
    public const int IP_REQ_TIMED_OUT = (11000 + 10);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BAD_REQ"]/*' />
    [NativeTypeName("#define IP_BAD_REQ (IP_STATUS_BASE + 11)")]
    public const int IP_BAD_REQ = (11000 + 11);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BAD_ROUTE"]/*' />
    [NativeTypeName("#define IP_BAD_ROUTE (IP_STATUS_BASE + 12)")]
    public const int IP_BAD_ROUTE = (11000 + 12);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TTL_EXPIRED_TRANSIT"]/*' />
    [NativeTypeName("#define IP_TTL_EXPIRED_TRANSIT (IP_STATUS_BASE + 13)")]
    public const int IP_TTL_EXPIRED_TRANSIT = (11000 + 13);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TTL_EXPIRED_REASSEM"]/*' />
    [NativeTypeName("#define IP_TTL_EXPIRED_REASSEM (IP_STATUS_BASE + 14)")]
    public const int IP_TTL_EXPIRED_REASSEM = (11000 + 14);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PARAM_PROBLEM"]/*' />
    [NativeTypeName("#define IP_PARAM_PROBLEM (IP_STATUS_BASE + 15)")]
    public const int IP_PARAM_PROBLEM = (11000 + 15);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_SOURCE_QUENCH"]/*' />
    [NativeTypeName("#define IP_SOURCE_QUENCH (IP_STATUS_BASE + 16)")]
    public const int IP_SOURCE_QUENCH = (11000 + 16);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPTION_TOO_BIG"]/*' />
    [NativeTypeName("#define IP_OPTION_TOO_BIG (IP_STATUS_BASE + 17)")]
    public const int IP_OPTION_TOO_BIG = (11000 + 17);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BAD_DESTINATION"]/*' />
    [NativeTypeName("#define IP_BAD_DESTINATION (IP_STATUS_BASE + 18)")]
    public const int IP_BAD_DESTINATION = (11000 + 18);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_NO_ROUTE"]/*' />
    [NativeTypeName("#define IP_DEST_NO_ROUTE (IP_STATUS_BASE + 2)")]
    public const int IP_DEST_NO_ROUTE = (11000 + 2);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_ADDR_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_ADDR_UNREACHABLE (IP_STATUS_BASE + 3)")]
    public const int IP_DEST_ADDR_UNREACHABLE = (11000 + 3);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_PROHIBITED"]/*' />
    [NativeTypeName("#define IP_DEST_PROHIBITED (IP_STATUS_BASE + 4)")]
    public const int IP_DEST_PROHIBITED = (11000 + 4);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_HOP_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define IP_HOP_LIMIT_EXCEEDED (IP_STATUS_BASE + 13)")]
    public const int IP_HOP_LIMIT_EXCEEDED = (11000 + 13);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_REASSEMBLY_TIME_EXCEEDED"]/*' />
    [NativeTypeName("#define IP_REASSEMBLY_TIME_EXCEEDED (IP_STATUS_BASE + 14)")]
    public const int IP_REASSEMBLY_TIME_EXCEEDED = (11000 + 14);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PARAMETER_PROBLEM"]/*' />
    [NativeTypeName("#define IP_PARAMETER_PROBLEM (IP_STATUS_BASE + 15)")]
    public const int IP_PARAMETER_PROBLEM = (11000 + 15);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_UNREACHABLE"]/*' />
    [NativeTypeName("#define IP_DEST_UNREACHABLE (IP_STATUS_BASE + 40)")]
    public const int IP_DEST_UNREACHABLE = (11000 + 40);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_TIME_EXCEEDED"]/*' />
    [NativeTypeName("#define IP_TIME_EXCEEDED (IP_STATUS_BASE + 41)")]
    public const int IP_TIME_EXCEEDED = (11000 + 41);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BAD_HEADER"]/*' />
    [NativeTypeName("#define IP_BAD_HEADER (IP_STATUS_BASE + 42)")]
    public const int IP_BAD_HEADER = (11000 + 42);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNRECOGNIZED_NEXT_HEADER"]/*' />
    [NativeTypeName("#define IP_UNRECOGNIZED_NEXT_HEADER (IP_STATUS_BASE + 43)")]
    public const int IP_UNRECOGNIZED_NEXT_HEADER = (11000 + 43);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ICMP_ERROR"]/*' />
    [NativeTypeName("#define IP_ICMP_ERROR (IP_STATUS_BASE + 44)")]
    public const int IP_ICMP_ERROR = (11000 + 44);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEST_SCOPE_MISMATCH"]/*' />
    [NativeTypeName("#define IP_DEST_SCOPE_MISMATCH (IP_STATUS_BASE + 45)")]
    public const int IP_DEST_SCOPE_MISMATCH = (11000 + 45);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADDR_DELETED"]/*' />
    [NativeTypeName("#define IP_ADDR_DELETED (IP_STATUS_BASE + 19)")]
    public const int IP_ADDR_DELETED = (11000 + 19);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_SPEC_MTU_CHANGE"]/*' />
    [NativeTypeName("#define IP_SPEC_MTU_CHANGE (IP_STATUS_BASE + 20)")]
    public const int IP_SPEC_MTU_CHANGE = (11000 + 20);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MTU_CHANGE"]/*' />
    [NativeTypeName("#define IP_MTU_CHANGE (IP_STATUS_BASE + 21)")]
    public const int IP_MTU_CHANGE = (11000 + 21);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNLOAD"]/*' />
    [NativeTypeName("#define IP_UNLOAD (IP_STATUS_BASE + 22)")]
    public const int IP_UNLOAD = (11000 + 22);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADDR_ADDED"]/*' />
    [NativeTypeName("#define IP_ADDR_ADDED (IP_STATUS_BASE + 23)")]
    public const int IP_ADDR_ADDED = (11000 + 23);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MEDIA_CONNECT"]/*' />
    [NativeTypeName("#define IP_MEDIA_CONNECT (IP_STATUS_BASE + 24)")]
    public const int IP_MEDIA_CONNECT = (11000 + 24);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_MEDIA_DISCONNECT"]/*' />
    [NativeTypeName("#define IP_MEDIA_DISCONNECT (IP_STATUS_BASE + 25)")]
    public const int IP_MEDIA_DISCONNECT = (11000 + 25);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_BIND_ADAPTER"]/*' />
    [NativeTypeName("#define IP_BIND_ADAPTER (IP_STATUS_BASE + 26)")]
    public const int IP_BIND_ADAPTER = (11000 + 26);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_UNBIND_ADAPTER"]/*' />
    [NativeTypeName("#define IP_UNBIND_ADAPTER (IP_STATUS_BASE + 27)")]
    public const int IP_UNBIND_ADAPTER = (11000 + 27);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DEVICE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define IP_DEVICE_DOES_NOT_EXIST (IP_STATUS_BASE + 28)")]
    public const int IP_DEVICE_DOES_NOT_EXIST = (11000 + 28);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DUPLICATE_ADDRESS"]/*' />
    [NativeTypeName("#define IP_DUPLICATE_ADDRESS (IP_STATUS_BASE + 29)")]
    public const int IP_DUPLICATE_ADDRESS = (11000 + 29);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_INTERFACE_METRIC_CHANGE"]/*' />
    [NativeTypeName("#define IP_INTERFACE_METRIC_CHANGE (IP_STATUS_BASE + 30)")]
    public const int IP_INTERFACE_METRIC_CHANGE = (11000 + 30);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_RECONFIG_SECFLTR"]/*' />
    [NativeTypeName("#define IP_RECONFIG_SECFLTR (IP_STATUS_BASE + 31)")]
    public const int IP_RECONFIG_SECFLTR = (11000 + 31);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_NEGOTIATING_IPSEC"]/*' />
    [NativeTypeName("#define IP_NEGOTIATING_IPSEC (IP_STATUS_BASE + 32)")]
    public const int IP_NEGOTIATING_IPSEC = (11000 + 32);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_INTERFACE_WOL_CAPABILITY_CHANGE"]/*' />
    [NativeTypeName("#define IP_INTERFACE_WOL_CAPABILITY_CHANGE (IP_STATUS_BASE + 33)")]
    public const int IP_INTERFACE_WOL_CAPABILITY_CHANGE = (11000 + 33);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_DUPLICATE_IPADD"]/*' />
    [NativeTypeName("#define IP_DUPLICATE_IPADD (IP_STATUS_BASE + 34)")]
    public const int IP_DUPLICATE_IPADD = (11000 + 34);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_GENERAL_FAILURE"]/*' />
    [NativeTypeName("#define IP_GENERAL_FAILURE (IP_STATUS_BASE + 50)")]
    public const int IP_GENERAL_FAILURE = (11000 + 50);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_PENDING"]/*' />
    [NativeTypeName("#define IP_PENDING (IP_STATUS_BASE + 255)")]
    public const int IP_PENDING = (11000 + 255);

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_FLAG_REVERSE"]/*' />
    [NativeTypeName("#define IP_FLAG_REVERSE 0x1")]
    public const int IP_FLAG_REVERSE = 0x1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_FLAG_DF"]/*' />
    [NativeTypeName("#define IP_FLAG_DF 0x2")]
    public const int IP_FLAG_DF = 0x2;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_EOL"]/*' />
    [NativeTypeName("#define IP_OPT_EOL 0")]
    public const int IP_OPT_EOL = 0;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_NOP"]/*' />
    [NativeTypeName("#define IP_OPT_NOP 1")]
    public const int IP_OPT_NOP = 1;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_SECURITY"]/*' />
    [NativeTypeName("#define IP_OPT_SECURITY 0x82")]
    public const int IP_OPT_SECURITY = 0x82;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_LSRR"]/*' />
    [NativeTypeName("#define IP_OPT_LSRR 0x83")]
    public const int IP_OPT_LSRR = 0x83;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_SSRR"]/*' />
    [NativeTypeName("#define IP_OPT_SSRR 0x89")]
    public const int IP_OPT_SSRR = 0x89;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_RR"]/*' />
    [NativeTypeName("#define IP_OPT_RR 0x7")]
    public const int IP_OPT_RR = 0x7;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_TS"]/*' />
    [NativeTypeName("#define IP_OPT_TS 0x44")]
    public const int IP_OPT_TS = 0x44;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_SID"]/*' />
    [NativeTypeName("#define IP_OPT_SID 0x88")]
    public const int IP_OPT_SID = 0x88;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_OPT_ROUTER_ALERT"]/*' />
    [NativeTypeName("#define IP_OPT_ROUTER_ALERT 0x94")]
    public const int IP_OPT_ROUTER_ALERT = 0x94;
}
