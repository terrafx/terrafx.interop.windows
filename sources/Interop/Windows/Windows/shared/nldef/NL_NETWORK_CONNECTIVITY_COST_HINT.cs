// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='NL_NETWORK_CONNECTIVITY_COST_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_COST_HINT"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum NL_NETWORK_CONNECTIVITY_COST_HINT
{
    /// <include file='NL_NETWORK_CONNECTIVITY_COST_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_COST_HINT.NetworkConnectivityCostHintUnknown"]/*' />
    NetworkConnectivityCostHintUnknown = 0,

    /// <include file='NL_NETWORK_CONNECTIVITY_COST_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_COST_HINT.NetworkConnectivityCostHintUnrestricted"]/*' />
    NetworkConnectivityCostHintUnrestricted,

    /// <include file='NL_NETWORK_CONNECTIVITY_COST_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_COST_HINT.NetworkConnectivityCostHintFixed"]/*' />
    NetworkConnectivityCostHintFixed,

    /// <include file='NL_NETWORK_CONNECTIVITY_COST_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_COST_HINT.NetworkConnectivityCostHintVariable"]/*' />
    NetworkConnectivityCostHintVariable,
}
