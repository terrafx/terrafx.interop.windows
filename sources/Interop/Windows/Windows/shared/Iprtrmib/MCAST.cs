// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MCAST
{
    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_MFE"]/*' />
    [NativeTypeName("#define MCAST_MFE (UDP_ROW            + 1)")]
    public const int MCAST_MFE = ((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_MFE_STATS"]/*' />
    [NativeTypeName("#define MCAST_MFE_STATS (MCAST_MFE          + 1)")]
    public const int MCAST_MFE_STATS = (((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_IF_ENTRY"]/*' />
    [NativeTypeName("#define MCAST_IF_ENTRY (PROXY_ARP          + 1)")]
    public const int MCAST_IF_ENTRY = (((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_GLOBAL"]/*' />
    [NativeTypeName("#define MCAST_GLOBAL (MCAST_IF_ENTRY     + 1)")]
    public const int MCAST_GLOBAL = ((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_BOUNDARY"]/*' />
    [NativeTypeName("#define MCAST_BOUNDARY (IF_STATUS          + 1)")]
    public const int MCAST_BOUNDARY = ((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_SCOPE"]/*' />
    [NativeTypeName("#define MCAST_SCOPE (MCAST_BOUNDARY     + 1)")]
    public const int MCAST_SCOPE = (((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

    /// <include file='MCAST.xml' path='doc/member[@name="MCAST.MCAST_MFE_STATS_EX"]/*' />
    [NativeTypeName("#define MCAST_MFE_STATS_EX (ROUTE_STATE        + 1)")]
    public const int MCAST_MFE_STATS_EX = (((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);
}
