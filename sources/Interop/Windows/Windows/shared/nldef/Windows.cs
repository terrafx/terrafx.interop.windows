// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.IP_PREFIX_ORIGIN;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NlpoOther"]/*' />
    [NativeTypeName("#define NlpoOther IpPrefixOriginOther")]
    public const IP_PREFIX_ORIGIN NlpoOther = IpPrefixOriginOther;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NlpoManual"]/*' />
    [NativeTypeName("#define NlpoManual IpPrefixOriginManual")]
    public const IP_PREFIX_ORIGIN NlpoManual = IpPrefixOriginManual;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NlpoWellKnown"]/*' />
    [NativeTypeName("#define NlpoWellKnown IpPrefixOriginWellKnown")]
    public const IP_PREFIX_ORIGIN NlpoWellKnown = IpPrefixOriginWellKnown;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NlpoDhcp"]/*' />
    [NativeTypeName("#define NlpoDhcp IpPrefixOriginDhcp")]
    public const IP_PREFIX_ORIGIN NlpoDhcp = IpPrefixOriginDhcp;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NlpoRouterAdvertisement"]/*' />
    [NativeTypeName("#define NlpoRouterAdvertisement IpPrefixOriginRouterAdvertisement")]
    public const IP_PREFIX_ORIGIN NlpoRouterAdvertisement = IpPrefixOriginRouterAdvertisement;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NL_MAX_METRIC_COMPONENT"]/*' />
    [NativeTypeName("#define NL_MAX_METRIC_COMPONENT ((((ULONG) 1) << 31) - 1)")]
    public const uint NL_MAX_METRIC_COMPONENT = ((((uint)(1)) << 31) - 1);
}
