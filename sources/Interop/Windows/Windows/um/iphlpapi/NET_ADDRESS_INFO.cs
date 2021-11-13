// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct NET_ADDRESS_INFO
    {
        public NET_ADDRESS_FORMAT Format;

        [NativeTypeName("NET_ADDRESS_INFO_::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/iphlpapi.h:1288:4)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._NamedAddress_e__Struct NamedAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NamedAddress, 1));
            }
        }

        public ref SOCKADDR_IN Ipv4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Ipv4Address, 1));
            }
        }

        public ref SOCKADDR_IN6 Ipv6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Ipv6Address, 1));
            }
        }

        public ref SOCKADDR IpAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IpAddress, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/iphlpapi.h:1290:7)")]
            public _NamedAddress_e__Struct NamedAddress;

            [FieldOffset(0)]
            public SOCKADDR_IN Ipv4Address;

            [FieldOffset(0)]
            public SOCKADDR_IN6 Ipv6Address;

            [FieldOffset(0)]
            public SOCKADDR IpAddress;

            public unsafe partial struct _NamedAddress_e__Struct
            {
                [NativeTypeName("WCHAR [256]")]
                public fixed ushort Address[256];

                [NativeTypeName("WCHAR [6]")]
                public fixed ushort Port[6];
            }
        }
    }
}
