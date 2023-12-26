// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState"]/*' />
public enum PhoneNetworkState
{
    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_Unknown"]/*' />
    PhoneNetworkState_Unknown = 0,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_NoSignal"]/*' />
    PhoneNetworkState_NoSignal = 1,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_Deregistered"]/*' />
    PhoneNetworkState_Deregistered = 2,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_Denied"]/*' />
    PhoneNetworkState_Denied = 3,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_Searching"]/*' />
    PhoneNetworkState_Searching = 4,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_Home"]/*' />
    PhoneNetworkState_Home = 5,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_RoamingInternational"]/*' />
    PhoneNetworkState_RoamingInternational = 6,

    /// <include file='PhoneNetworkState.xml' path='doc/member[@name="PhoneNetworkState.PhoneNetworkState_RoamingDomestic"]/*' />
    PhoneNetworkState_RoamingDomestic = 7,
}
