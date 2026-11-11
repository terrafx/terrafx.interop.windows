// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NET
{
    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_COMPARTMENT_ID_UNSPECIFIED"]/*' />
    [NativeTypeName("#define NET_IF_COMPARTMENT_ID_UNSPECIFIED (NET_IF_COMPARTMENT_ID)0")]
    public const uint NET_IF_COMPARTMENT_ID_UNSPECIFIED = (uint)(0);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_COMPARTMENT_ID_PRIMARY"]/*' />
    [NativeTypeName("#define NET_IF_COMPARTMENT_ID_PRIMARY (NET_IF_COMPARTMENT_ID)1")]
    public const uint NET_IF_COMPARTMENT_ID_PRIMARY = (uint)(1);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED 0x00000001")]
    public const int NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED = 0x00000001;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED"]/*' />
    [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED 0x00000002")]
    public const int NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED = 0x00000002;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OPER_STATUS_DORMANT_PAUSED"]/*' />
    [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_PAUSED 0x00000004")]
    public const int NET_IF_OPER_STATUS_DORMANT_PAUSED = 0x00000004;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OPER_STATUS_DORMANT_LOW_POWER"]/*' />
    [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_LOW_POWER 0x00000008")]
    public const int NET_IF_OPER_STATUS_DORMANT_LOW_POWER = 0x00000008;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED"]/*' />
    [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED (NET_IF_COMPARTMENT_SCOPE)0")]
    public const uint NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED = (uint)(0);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_COMPARTMENT_SCOPE_ALL"]/*' />
    [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_ALL ((NET_IF_COMPARTMENT_SCOPE)-1)")]
    public const uint NET_IF_COMPARTMENT_SCOPE_ALL = unchecked((uint)(-1));

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OID_IF_ALIAS"]/*' />
    [NativeTypeName("#define NET_IF_OID_IF_ALIAS 0x00000001")]
    public const int NET_IF_OID_IF_ALIAS = 0x00000001;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OID_COMPARTMENT_ID"]/*' />
    [NativeTypeName("#define NET_IF_OID_COMPARTMENT_ID 0x00000002")]
    public const int NET_IF_OID_COMPARTMENT_ID = 0x00000002;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OID_NETWORK_GUID"]/*' />
    [NativeTypeName("#define NET_IF_OID_NETWORK_GUID 0x00000003")]
    public const int NET_IF_OID_NETWORK_GUID = 0x00000003;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_OID_IF_ENTRY"]/*' />
    [NativeTypeName("#define NET_IF_OID_IF_ENTRY 0x00000004")]
    public const int NET_IF_OID_IF_ENTRY = 0x00000004;

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_SITEID_UNSPECIFIED"]/*' />
    [NativeTypeName("#define NET_SITEID_UNSPECIFIED (0)")]
    public const int NET_SITEID_UNSPECIFIED = (0);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_SITEID_MAXUSER"]/*' />
    [NativeTypeName("#define NET_SITEID_MAXUSER (0x07ffffff)")]
    public const int NET_SITEID_MAXUSER = (0x07ffffff);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_SITEID_MAXSYSTEM"]/*' />
    [NativeTypeName("#define NET_SITEID_MAXSYSTEM (0x0fffffff)")]
    public const int NET_SITEID_MAXSYSTEM = (0x0fffffff);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IFINDEX_UNSPECIFIED"]/*' />
    [NativeTypeName("#define NET_IFINDEX_UNSPECIFIED (NET_IFINDEX)(0)")]
    public const uint NET_IFINDEX_UNSPECIFIED = (uint)(0);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IFLUID_UNSPECIFIED"]/*' />
    [NativeTypeName("#define NET_IFLUID_UNSPECIFIED (0)")]
    public const int NET_IFLUID_UNSPECIFIED = (0);

    /// <include file='NET.xml' path='doc/member[@name="NET.NET_IF_LINK_SPEED_UNKNOWN"]/*' />
    [NativeTypeName("#define NET_IF_LINK_SPEED_UNKNOWN ((ULONG64)(-1))")]
    public const ulong NET_IF_LINK_SPEED_UNKNOWN = unchecked((ulong)(-1));
}
