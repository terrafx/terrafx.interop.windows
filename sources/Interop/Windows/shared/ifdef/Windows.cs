// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define NET_IF_COMPARTMENT_ID_UNSPECIFIED (NET_IF_COMPARTMENT_ID)0")]
        public const uint NET_IF_COMPARTMENT_ID_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IF_COMPARTMENT_ID_PRIMARY (NET_IF_COMPARTMENT_ID)1")]
        public const uint NET_IF_COMPARTMENT_ID_PRIMARY = (uint)(1);

        [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED 0x00000001")]
        public const int NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED = 0x00000001;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED 0x00000002")]
        public const int NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED = 0x00000002;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_PAUSED 0x00000004")]
        public const int NET_IF_OPER_STATUS_DORMANT_PAUSED = 0x00000004;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_LOW_POWER 0x00000008")]
        public const int NET_IF_OPER_STATUS_DORMANT_LOW_POWER = 0x00000008;

        [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED (NET_IF_COMPARTMENT_SCOPE)0")]
        public const uint NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_ALL ((NET_IF_COMPARTMENT_SCOPE)-1)")]
        public const uint NET_IF_COMPARTMENT_SCOPE_ALL = unchecked((uint)(-1));

        [NativeTypeName("#define NET_IF_OID_IF_ALIAS 0x00000001")]
        public const int NET_IF_OID_IF_ALIAS = 0x00000001;

        [NativeTypeName("#define NET_IF_OID_COMPARTMENT_ID 0x00000002")]
        public const int NET_IF_OID_COMPARTMENT_ID = 0x00000002;

        [NativeTypeName("#define NET_IF_OID_NETWORK_GUID 0x00000003")]
        public const int NET_IF_OID_NETWORK_GUID = 0x00000003;

        [NativeTypeName("#define NET_IF_OID_IF_ENTRY 0x00000004")]
        public const int NET_IF_OID_IF_ENTRY = 0x00000004;

        [NativeTypeName("#define NET_SITEID_UNSPECIFIED (0)")]
        public const int NET_SITEID_UNSPECIFIED = (0);

        [NativeTypeName("#define NET_SITEID_MAXUSER (0x07ffffff)")]
        public const int NET_SITEID_MAXUSER = (0x07ffffff);

        [NativeTypeName("#define NET_SITEID_MAXSYSTEM (0x0fffffff)")]
        public const int NET_SITEID_MAXSYSTEM = (0x0fffffff);

        [NativeTypeName("#define NET_IFINDEX_UNSPECIFIED (NET_IFINDEX)(0)")]
        public const uint NET_IFINDEX_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IFLUID_UNSPECIFIED (0)")]
        public const int NET_IFLUID_UNSPECIFIED = (0);

        [NativeTypeName("#define IFI_UNSPECIFIED NET_IFINDEX_UNSPECIFIED")]
        public const uint IFI_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NIIF_HARDWARE_INTERFACE 0x00000001")]
        public const int NIIF_HARDWARE_INTERFACE = 0x00000001;

        [NativeTypeName("#define NIIF_FILTER_INTERFACE 0x00000002")]
        public const int NIIF_FILTER_INTERFACE = 0x00000002;

        [NativeTypeName("#define NIIF_NDIS_RESERVED1 0x00000004")]
        public const int NIIF_NDIS_RESERVED1 = 0x00000004;

        [NativeTypeName("#define NIIF_NDIS_RESERVED2 0x00000008")]
        public const int NIIF_NDIS_RESERVED2 = 0x00000008;

        [NativeTypeName("#define NIIF_NDIS_RESERVED3 0x00000010")]
        public const int NIIF_NDIS_RESERVED3 = 0x00000010;

        [NativeTypeName("#define NIIF_NDIS_WDM_INTERFACE 0x00000020")]
        public const int NIIF_NDIS_WDM_INTERFACE = 0x00000020;

        [NativeTypeName("#define NIIF_NDIS_ENDPOINT_INTERFACE 0x00000040")]
        public const int NIIF_NDIS_ENDPOINT_INTERFACE = 0x00000040;

        [NativeTypeName("#define NIIF_NDIS_ISCSI_INTERFACE 0x00000080")]
        public const int NIIF_NDIS_ISCSI_INTERFACE = 0x00000080;

        [NativeTypeName("#define NIIF_NDIS_RESERVED4 0x00000100")]
        public const int NIIF_NDIS_RESERVED4 = 0x00000100;

        [NativeTypeName("#define NIIF_WAN_TUNNEL_TYPE_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_WAN_TUNNEL_TYPE_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NET_IF_LINK_SPEED_UNKNOWN ((ULONG64)(-1))")]
        public const ulong NET_IF_LINK_SPEED_UNKNOWN = unchecked((ulong)(-1));

        [NativeTypeName("#define NIIF_BUS_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_BUS_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NIIF_SLOT_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_SLOT_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NIIF_FUNCTION_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_FUNCTION_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define IF_MAX_STRING_SIZE 256")]
        public const int IF_MAX_STRING_SIZE = 256;

        [NativeTypeName("#define IF_MAX_PHYS_ADDRESS_LENGTH 32")]
        public const int IF_MAX_PHYS_ADDRESS_LENGTH = 32;
    }
}
