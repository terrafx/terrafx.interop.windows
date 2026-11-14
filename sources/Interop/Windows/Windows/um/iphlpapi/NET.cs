// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NET
{
    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV4_ADDRESS"]/*' />
    [NativeTypeName("#define NET_STRING_IPV4_ADDRESS 0x00000001")]
    public const int NET_STRING_IPV4_ADDRESS = 0x00000001;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV4_SERVICE"]/*' />
    [NativeTypeName("#define NET_STRING_IPV4_SERVICE 0x00000002")]
    public const int NET_STRING_IPV4_SERVICE = 0x00000002;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV4_NETWORK"]/*' />
    [NativeTypeName("#define NET_STRING_IPV4_NETWORK 0x00000004")]
    public const int NET_STRING_IPV4_NETWORK = 0x00000004;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV6_ADDRESS"]/*' />
    [NativeTypeName("#define NET_STRING_IPV6_ADDRESS 0x00000008")]
    public const int NET_STRING_IPV6_ADDRESS = 0x00000008;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV6_ADDRESS_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_IPV6_ADDRESS_NO_SCOPE 0x00000010")]
    public const int NET_STRING_IPV6_ADDRESS_NO_SCOPE = 0x00000010;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV6_SERVICE"]/*' />
    [NativeTypeName("#define NET_STRING_IPV6_SERVICE 0x00000020")]
    public const int NET_STRING_IPV6_SERVICE = 0x00000020;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV6_SERVICE_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_IPV6_SERVICE_NO_SCOPE 0x00000040")]
    public const int NET_STRING_IPV6_SERVICE_NO_SCOPE = 0x00000040;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IPV6_NETWORK"]/*' />
    [NativeTypeName("#define NET_STRING_IPV6_NETWORK 0x00000080")]
    public const int NET_STRING_IPV6_NETWORK = 0x00000080;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_NAMED_ADDRESS"]/*' />
    [NativeTypeName("#define NET_STRING_NAMED_ADDRESS 0x00000100")]
    public const int NET_STRING_NAMED_ADDRESS = 0x00000100;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_NAMED_SERVICE"]/*' />
    [NativeTypeName("#define NET_STRING_NAMED_SERVICE 0x00000200")]
    public const int NET_STRING_NAMED_SERVICE = 0x00000200;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IP_ADDRESS"]/*' />
    [NativeTypeName("#define NET_STRING_IP_ADDRESS (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS)")]
    public const int NET_STRING_IP_ADDRESS = (0x00000001 | 0x00000008);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IP_ADDRESS_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_IP_ADDRESS_NO_SCOPE (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS_NO_SCOPE)")]
    public const int NET_STRING_IP_ADDRESS_NO_SCOPE = (0x00000001 | 0x00000010);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IP_SERVICE"]/*' />
    [NativeTypeName("#define NET_STRING_IP_SERVICE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE)")]
    public const int NET_STRING_IP_SERVICE = (0x00000002 | 0x00000020);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IP_SERVICE_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_IP_SERVICE_NO_SCOPE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE_NO_SCOPE)")]
    public const int NET_STRING_IP_SERVICE_NO_SCOPE = (0x00000002 | 0x00000040);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_IP_NETWORK"]/*' />
    [NativeTypeName("#define NET_STRING_IP_NETWORK (NET_STRING_IPV4_NETWORK   | \\\r\n                                           NET_STRING_IPV6_NETWORK)")]
    public const int NET_STRING_IP_NETWORK = (0x00000004 | 0x00000080);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_ANY_ADDRESS"]/*' />
    [NativeTypeName("#define NET_STRING_ANY_ADDRESS (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS)")]
    public const int NET_STRING_ANY_ADDRESS = (0x00000100 | (0x00000001 | 0x00000008));

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_ANY_ADDRESS_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_ANY_ADDRESS_NO_SCOPE (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS_NO_SCOPE)")]
    public const int NET_STRING_ANY_ADDRESS_NO_SCOPE = (0x00000100 | (0x00000001 | 0x00000010));

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_ANY_SERVICE"]/*' />
    [NativeTypeName("#define NET_STRING_ANY_SERVICE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE)")]
    public const int NET_STRING_ANY_SERVICE = (0x00000200 | (0x00000002 | 0x00000020));

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_STRING_ANY_SERVICE_NO_SCOPE"]/*' />
    [NativeTypeName("#define NET_STRING_ANY_SERVICE_NO_SCOPE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE_NO_SCOPE)")]
    public const int NET_STRING_ANY_SERVICE_NO_SCOPE = (0x00000200 | (0x00000002 | 0x00000040));
}
