// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState"]/*' />
public enum WwanNetworkRegistrationState
{
    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_None"]/*' />
    WwanNetworkRegistrationState_None = 0,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Deregistered"]/*' />
    WwanNetworkRegistrationState_Deregistered = 1,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Searching"]/*' />
    WwanNetworkRegistrationState_Searching = 2,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Home"]/*' />
    WwanNetworkRegistrationState_Home = 3,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Roaming"]/*' />
    WwanNetworkRegistrationState_Roaming = 4,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Partner"]/*' />
    WwanNetworkRegistrationState_Partner = 5,

    /// <include file='WwanNetworkRegistrationState.xml' path='doc/member[@name="WwanNetworkRegistrationState.WwanNetworkRegistrationState_Denied"]/*' />
    WwanNetworkRegistrationState_Denied = 6,
}
