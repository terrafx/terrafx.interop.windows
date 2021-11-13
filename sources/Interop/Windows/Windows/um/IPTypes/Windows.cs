// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define MAX_ADAPTER_DESCRIPTION_LENGTH 128")]
        public const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;

        [NativeTypeName("#define MAX_ADAPTER_NAME_LENGTH 256")]
        public const int MAX_ADAPTER_NAME_LENGTH = 256;

        [NativeTypeName("#define MAX_ADAPTER_ADDRESS_LENGTH 8")]
        public const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

        [NativeTypeName("#define DEFAULT_MINIMUM_ENTITIES 32")]
        public const int DEFAULT_MINIMUM_ENTITIES = 32;

        [NativeTypeName("#define MAX_HOSTNAME_LEN 128")]
        public const int MAX_HOSTNAME_LEN = 128;

        [NativeTypeName("#define MAX_DOMAIN_NAME_LEN 128")]
        public const int MAX_DOMAIN_NAME_LEN = 128;

        [NativeTypeName("#define MAX_SCOPE_ID_LEN 256")]
        public const int MAX_SCOPE_ID_LEN = 256;

        [NativeTypeName("#define MAX_DHCPV6_DUID_LENGTH 130")]
        public const int MAX_DHCPV6_DUID_LENGTH = 130;

        [NativeTypeName("#define MAX_DNS_SUFFIX_STRING_LENGTH 256")]
        public const int MAX_DNS_SUFFIX_STRING_LENGTH = 256;

        [NativeTypeName("#define BROADCAST_NODETYPE 1")]
        public const int BROADCAST_NODETYPE = 1;

        [NativeTypeName("#define PEER_TO_PEER_NODETYPE 2")]
        public const int PEER_TO_PEER_NODETYPE = 2;

        [NativeTypeName("#define MIXED_NODETYPE 4")]
        public const int MIXED_NODETYPE = 4;

        [NativeTypeName("#define HYBRID_NODETYPE 8")]
        public const int HYBRID_NODETYPE = 8;

        [NativeTypeName("#define IP_ADAPTER_ADDRESS_DNS_ELIGIBLE 0x01")]
        public const int IP_ADAPTER_ADDRESS_DNS_ELIGIBLE = 0x01;

        [NativeTypeName("#define IP_ADAPTER_ADDRESS_TRANSIENT 0x02")]
        public const int IP_ADAPTER_ADDRESS_TRANSIENT = 0x02;

        [NativeTypeName("#define IP_ADAPTER_DDNS_ENABLED 0x00000001")]
        public const int IP_ADAPTER_DDNS_ENABLED = 0x00000001;

        [NativeTypeName("#define IP_ADAPTER_REGISTER_ADAPTER_SUFFIX 0x00000002")]
        public const int IP_ADAPTER_REGISTER_ADAPTER_SUFFIX = 0x00000002;

        [NativeTypeName("#define IP_ADAPTER_DHCP_ENABLED 0x00000004")]
        public const int IP_ADAPTER_DHCP_ENABLED = 0x00000004;

        [NativeTypeName("#define IP_ADAPTER_RECEIVE_ONLY 0x00000008")]
        public const int IP_ADAPTER_RECEIVE_ONLY = 0x00000008;

        [NativeTypeName("#define IP_ADAPTER_NO_MULTICAST 0x00000010")]
        public const int IP_ADAPTER_NO_MULTICAST = 0x00000010;

        [NativeTypeName("#define IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG 0x00000020")]
        public const int IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG = 0x00000020;

        [NativeTypeName("#define IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED 0x00000040")]
        public const int IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED = 0x00000040;

        [NativeTypeName("#define IP_ADAPTER_IPV4_ENABLED 0x00000080")]
        public const int IP_ADAPTER_IPV4_ENABLED = 0x00000080;

        [NativeTypeName("#define IP_ADAPTER_IPV6_ENABLED 0x00000100")]
        public const int IP_ADAPTER_IPV6_ENABLED = 0x00000100;

        [NativeTypeName("#define IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG 0x00000200")]
        public const int IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG = 0x00000200;

        [NativeTypeName("#define GAA_FLAG_SKIP_UNICAST 0x0001")]
        public const int GAA_FLAG_SKIP_UNICAST = 0x0001;

        [NativeTypeName("#define GAA_FLAG_SKIP_ANYCAST 0x0002")]
        public const int GAA_FLAG_SKIP_ANYCAST = 0x0002;

        [NativeTypeName("#define GAA_FLAG_SKIP_MULTICAST 0x0004")]
        public const int GAA_FLAG_SKIP_MULTICAST = 0x0004;

        [NativeTypeName("#define GAA_FLAG_SKIP_DNS_SERVER 0x0008")]
        public const int GAA_FLAG_SKIP_DNS_SERVER = 0x0008;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_PREFIX 0x0010")]
        public const int GAA_FLAG_INCLUDE_PREFIX = 0x0010;

        [NativeTypeName("#define GAA_FLAG_SKIP_FRIENDLY_NAME 0x0020")]
        public const int GAA_FLAG_SKIP_FRIENDLY_NAME = 0x0020;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_WINS_INFO 0x0040")]
        public const int GAA_FLAG_INCLUDE_WINS_INFO = 0x0040;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_GATEWAYS 0x0080")]
        public const int GAA_FLAG_INCLUDE_GATEWAYS = 0x0080;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_INTERFACES 0x0100")]
        public const int GAA_FLAG_INCLUDE_ALL_INTERFACES = 0x0100;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_COMPARTMENTS 0x0200")]
        public const int GAA_FLAG_INCLUDE_ALL_COMPARTMENTS = 0x0200;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER 0x0400")]
        public const int GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER = 0x0400;

        [NativeTypeName("#define GAA_FLAG_SKIP_DNS_INFO 0x0800")]
        public const int GAA_FLAG_SKIP_DNS_INFO = 0x0800;
    }
}
