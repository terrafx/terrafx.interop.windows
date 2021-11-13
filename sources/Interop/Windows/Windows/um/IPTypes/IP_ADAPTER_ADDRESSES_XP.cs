// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IP_ADAPTER_ADDRESSES_XP
    {
        [NativeTypeName("_IP_ADAPTER_ADDRESSES_XP::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:353:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_XP *")]
        public IP_ADAPTER_ADDRESSES_XP* Next;

        [NativeTypeName("PCHAR")]
        public sbyte* AdapterName;

        [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_XP")]
        public IP_ADAPTER_UNICAST_ADDRESS_XP* FirstUnicastAddress;

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

        [NativeTypeName("DWORD")]
        public uint PhysicalAddressLength;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Mtu;

        [NativeTypeName("DWORD")]
        public uint IfType;

        public IF_OPER_STATUS OperStatus;

        [NativeTypeName("DWORD")]
        public uint Ipv6IfIndex;

        [NativeTypeName("DWORD [16]")]
        public fixed uint ZoneIndices[16];

        [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
        public IP_ADAPTER_PREFIX_XP* FirstPrefix;

        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Alignment, 1));
            }
        }

        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Length, 1));
            }
        }

        public ref uint IfIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.IfIndex, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("_IP_ADAPTER_ADDRESSES_XP::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:355:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint IfIndex;
            }
        }
    }
}
