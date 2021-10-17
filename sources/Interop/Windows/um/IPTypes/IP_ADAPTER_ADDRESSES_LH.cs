// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IP_ADAPTER_ADDRESSES_LH
    {
        [NativeTypeName("_IP_ADAPTER_ADDRESSES_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:287:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_LH *")]
        public IP_ADAPTER_ADDRESSES_LH* Next;

        [NativeTypeName("PCHAR")]
        public sbyte* AdapterName;

        [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_LH")]
        public IP_ADAPTER_UNICAST_ADDRESS_LH* FirstUnicastAddress;

        [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
        public IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;

        [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
        public IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;

        [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
        public IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;

        [NativeTypeName("PWCHAR")]
        public ushort* DnsSuffix;

        [NativeTypeName("PWCHAR")]
        public ushort* Description;

        [NativeTypeName("PWCHAR")]
        public ushort* FriendlyName;

        [NativeTypeName("BYTE [8]")]
        public fixed byte PhysicalAddress[8];

        [NativeTypeName("ULONG")]
        public uint PhysicalAddressLength;

        [NativeTypeName("_IP_ADAPTER_ADDRESSES_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:305:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("ULONG")]
        public uint Mtu;

        [NativeTypeName("IFTYPE")]
        public uint IfType;

        public IF_OPER_STATUS OperStatus;

        [NativeTypeName("IF_INDEX")]
        public uint Ipv6IfIndex;

        [NativeTypeName("ULONG [16]")]
        public fixed uint ZoneIndices[16];

        [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
        public IP_ADAPTER_PREFIX_XP* FirstPrefix;

        [NativeTypeName("ULONG64")]
        public ulong TransmitLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong ReceiveLinkSpeed;

        [NativeTypeName("PIP_ADAPTER_WINS_SERVER_ADDRESS_LH")]
        public IP_ADAPTER_WINS_SERVER_ADDRESS_LH* FirstWinsServerAddress;

        [NativeTypeName("PIP_ADAPTER_GATEWAY_ADDRESS_LH")]
        public IP_ADAPTER_GATEWAY_ADDRESS_LH* FirstGatewayAddress;

        [NativeTypeName("ULONG")]
        public uint Ipv4Metric;

        [NativeTypeName("ULONG")]
        public uint Ipv6Metric;

        [NativeTypeName("IF_LUID")]
        public NET_LUID_LH Luid;

        public SOCKET_ADDRESS Dhcpv4Server;

        [NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public uint CompartmentId;

        [NativeTypeName("NET_IF_NETWORK_GUID")]
        public Guid NetworkGuid;

        public NET_IF_CONNECTION_TYPE ConnectionType;

        public TUNNEL_TYPE TunnelType;

        public SOCKET_ADDRESS Dhcpv6Server;

        [NativeTypeName("BYTE [130]")]
        public fixed byte Dhcpv6ClientDuid[130];

        [NativeTypeName("ULONG")]
        public uint Dhcpv6ClientDuidLength;

        [NativeTypeName("ULONG")]
        public uint Dhcpv6Iaid;

        [NativeTypeName("PIP_ADAPTER_DNS_SUFFIX")]
        public IP_ADAPTER_DNS_SUFFIX* FirstDnsSuffix;

        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Alignment, 1));
            }
        }

        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.Length, 1));
            }
        }

        public ref uint IfIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.IfIndex, 1));
            }
        }

        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Flags, 1));
            }
        }

        public uint DdnsEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.DdnsEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.DdnsEnabled = value;
            }
        }

        public uint RegisterAdapterSuffix
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.RegisterAdapterSuffix;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.RegisterAdapterSuffix = value;
            }
        }

        public uint Dhcpv4Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.Dhcpv4Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Dhcpv4Enabled = value;
            }
        }

        public uint ReceiveOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.ReceiveOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.ReceiveOnly = value;
            }
        }

        public uint NoMulticast
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.NoMulticast;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.NoMulticast = value;
            }
        }

        public uint Ipv6OtherStatefulConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.Ipv6OtherStatefulConfig;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6OtherStatefulConfig = value;
            }
        }

        public uint NetbiosOverTcpipEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.NetbiosOverTcpipEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.NetbiosOverTcpipEnabled = value;
            }
        }

        public uint Ipv4Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.Ipv4Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv4Enabled = value;
            }
        }

        public uint Ipv6Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.Ipv6Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6Enabled = value;
            }
        }

        public uint Ipv6ManagedAddressConfigurationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("_IP_ADAPTER_ADDRESSES_LH::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:289:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("IF_INDEX")]
                public uint IfIndex;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("_IP_ADAPTER_ADDRESSES_LH::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:307:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("ULONG : 1")]
                public uint DdnsEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RegisterAdapterSuffix
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Dhcpv4Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint ReceiveOnly
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint NoMulticast
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6OtherStatefulConfig
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint NetbiosOverTcpipEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv4Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 8) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6ManagedAddressConfigurationSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return (_bitfield >> 9) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                    }
                }
            }
        }
    }
}
