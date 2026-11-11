// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IP
{
    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_ADDRESS_DNS_ELIGIBLE"]/*' />
    [NativeTypeName("#define IP_ADAPTER_ADDRESS_DNS_ELIGIBLE 0x01")]
    public const int IP_ADAPTER_ADDRESS_DNS_ELIGIBLE = 0x01;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_ADDRESS_TRANSIENT"]/*' />
    [NativeTypeName("#define IP_ADAPTER_ADDRESS_TRANSIENT 0x02")]
    public const int IP_ADAPTER_ADDRESS_TRANSIENT = 0x02;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_DDNS_ENABLED"]/*' />
    [NativeTypeName("#define IP_ADAPTER_DDNS_ENABLED 0x00000001")]
    public const int IP_ADAPTER_DDNS_ENABLED = 0x00000001;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_REGISTER_ADAPTER_SUFFIX"]/*' />
    [NativeTypeName("#define IP_ADAPTER_REGISTER_ADAPTER_SUFFIX 0x00000002")]
    public const int IP_ADAPTER_REGISTER_ADAPTER_SUFFIX = 0x00000002;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_DHCP_ENABLED"]/*' />
    [NativeTypeName("#define IP_ADAPTER_DHCP_ENABLED 0x00000004")]
    public const int IP_ADAPTER_DHCP_ENABLED = 0x00000004;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_RECEIVE_ONLY"]/*' />
    [NativeTypeName("#define IP_ADAPTER_RECEIVE_ONLY 0x00000008")]
    public const int IP_ADAPTER_RECEIVE_ONLY = 0x00000008;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_NO_MULTICAST"]/*' />
    [NativeTypeName("#define IP_ADAPTER_NO_MULTICAST 0x00000010")]
    public const int IP_ADAPTER_NO_MULTICAST = 0x00000010;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG"]/*' />
    [NativeTypeName("#define IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG 0x00000020")]
    public const int IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG = 0x00000020;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED"]/*' />
    [NativeTypeName("#define IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED 0x00000040")]
    public const int IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED = 0x00000040;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_IPV4_ENABLED"]/*' />
    [NativeTypeName("#define IP_ADAPTER_IPV4_ENABLED 0x00000080")]
    public const int IP_ADAPTER_IPV4_ENABLED = 0x00000080;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_IPV6_ENABLED"]/*' />
    [NativeTypeName("#define IP_ADAPTER_IPV6_ENABLED 0x00000100")]
    public const int IP_ADAPTER_IPV6_ENABLED = 0x00000100;

    /// <include file='IP.xml' path='doc/member[@name="IP.IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG"]/*' />
    [NativeTypeName("#define IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG 0x00000200")]
    public const int IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG = 0x00000200;
}
