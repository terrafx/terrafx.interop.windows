// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NET_ADDRESS_INFO.xml' path='doc/member[@name="NET_ADDRESS_INFO"]/*' />
public partial struct NET_ADDRESS_INFO
{
    /// <include file='NET_ADDRESS_INFO.xml' path='doc/member[@name="NET_ADDRESS_INFO.Format"]/*' />
    public NET_ADDRESS_FORMAT Format;

    /// <include file='NET_ADDRESS_INFO.xml' path='doc/member[@name="NET_ADDRESS_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_iphlpapi_L1416_C4")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NamedAddress"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._NamedAddress_e__Struct NamedAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NamedAddress;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ipv4Address"]/*' />
    [UnscopedRef]
    public ref SOCKADDR_IN Ipv4Address
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Ipv4Address;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ipv6Address"]/*' />
    [UnscopedRef]
    public ref SOCKADDR_IN6 Ipv6Address
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Ipv6Address;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IpAddress"]/*' />
    [UnscopedRef]
    public ref SOCKADDR IpAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.IpAddress;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NamedAddress"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_iphlpapi_L1418_C7")]
        public _NamedAddress_e__Struct NamedAddress;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ipv4Address"]/*' />
        [FieldOffset(0)]
        public SOCKADDR_IN Ipv4Address;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ipv6Address"]/*' />
        [FieldOffset(0)]
        public SOCKADDR_IN6 Ipv6Address;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IpAddress"]/*' />
        [FieldOffset(0)]
        public SOCKADDR IpAddress;

        /// <include file='_NamedAddress_e__Struct.xml' path='doc/member[@name="_NamedAddress_e__Struct"]/*' />
        public partial struct _NamedAddress_e__Struct
        {
            /// <include file='_NamedAddress_e__Struct.xml' path='doc/member[@name="_NamedAddress_e__Struct.Address"]/*' />
            [NativeTypeName("WCHAR[256]")]
            public _Address_e__FixedBuffer Address;

            /// <include file='_NamedAddress_e__Struct.xml' path='doc/member[@name="_NamedAddress_e__Struct.Port"]/*' />
            [NativeTypeName("WCHAR[6]")]
            public _Port_e__FixedBuffer Port;

            /// <include file='_Address_e__FixedBuffer.xml' path='doc/member[@name="_Address_e__FixedBuffer"]/*' />
            [InlineArray(256)]
            [Obsolete("Possible string represented as a fixed-sized buffer.")]
            public partial struct _Address_e__FixedBuffer
            {
                public char e0;
            }

            /// <include file='_Port_e__FixedBuffer.xml' path='doc/member[@name="_Port_e__FixedBuffer"]/*' />
            [InlineArray(6)]
            [Obsolete("Possible string represented as a fixed-sized buffer.")]
            public partial struct _Port_e__FixedBuffer
            {
                public char e0;
            }
        }
    }
}
