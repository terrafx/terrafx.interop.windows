// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPRTRMGR_PID"]/*' />
    [NativeTypeName("#define IPRTRMGR_PID 10000")]
    public const int IPRTRMGR_PID = 10000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ICMP_STATS"]/*' />
    [NativeTypeName("#define ICMP_STATS (IP_NETROW          + 1)")]
    public const int ICMP_STATS = (((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_STATS"]/*' />
    [NativeTypeName("#define UDP_STATS (TCP_ROW            + 1)")]
    public const int UDP_STATS = (((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_TABLE"]/*' />
    [NativeTypeName("#define UDP_TABLE (UDP_STATS          + 1)")]
    public const int UDP_TABLE = ((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP_ROW"]/*' />
    [NativeTypeName("#define UDP_ROW (UDP_TABLE          + 1)")]
    public const int UDP_ROW = (((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BEST_IF"]/*' />
    [NativeTypeName("#define BEST_IF (MCAST_MFE_STATS    + 1)")]
    public const int BEST_IF = ((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BEST_ROUTE"]/*' />
    [NativeTypeName("#define BEST_ROUTE (BEST_IF            + 1)")]
    public const int BEST_ROUTE = (((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROXY_ARP"]/*' />
    [NativeTypeName("#define PROXY_ARP (BEST_ROUTE         + 1)")]
    public const int PROXY_ARP = ((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DEST_MATCHING"]/*' />
    [NativeTypeName("#define DEST_MATCHING (MCAST_SCOPE        + 1)")]
    public const int DEST_MATCHING = ((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DEST_LONGER"]/*' />
    [NativeTypeName("#define DEST_LONGER (DEST_MATCHING      + 1)")]
    public const int DEST_LONGER = (((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DEST_SHORTER"]/*' />
    [NativeTypeName("#define DEST_SHORTER (DEST_LONGER        + 1)")]
    public const int DEST_SHORTER = ((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROUTE_MATCHING"]/*' />
    [NativeTypeName("#define ROUTE_MATCHING (DEST_SHORTER       + 1)")]
    public const int ROUTE_MATCHING = (((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROUTE_LONGER"]/*' />
    [NativeTypeName("#define ROUTE_LONGER (ROUTE_MATCHING     + 1)")]
    public const int ROUTE_LONGER = ((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROUTE_SHORTER"]/*' />
    [NativeTypeName("#define ROUTE_SHORTER (ROUTE_LONGER       + 1)")]
    public const int ROUTE_SHORTER = (((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROUTE_STATE"]/*' />
    [NativeTypeName("#define ROUTE_STATE (ROUTE_SHORTER      + 1)")]
    public const int ROUTE_STATE = ((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IP6_STATS"]/*' />
    [NativeTypeName("#define IP6_STATS (MCAST_MFE_STATS_EX + 1)")]
    public const int IP6_STATS = ((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDP6_STATS"]/*' />
    [NativeTypeName("#define UDP6_STATS (IP6_STATS          + 1)")]
    public const int UDP6_STATS = (((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCP6_STATS"]/*' />
    [NativeTypeName("#define TCP6_STATS (UDP6_STATS         + 1)")]
    public const int TCP6_STATS = ((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NUMBER_OF_EXPORTED_VARIABLES"]/*' />
    [NativeTypeName("#define NUMBER_OF_EXPORTED_VARIABLES (TCP6_STATS + 1)")]
    public const int NUMBER_OF_EXPORTED_VARIABLES = (((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);
}
