// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NetworkConnectivityLevel.xml' path='doc/member[@name="NetworkConnectivityLevel"]/*' />
public enum NetworkConnectivityLevel
{
    /// <include file='NetworkConnectivityLevel.xml' path='doc/member[@name="NetworkConnectivityLevel.NetworkConnectivityLevel_None"]/*' />
    NetworkConnectivityLevel_None = 0,

    /// <include file='NetworkConnectivityLevel.xml' path='doc/member[@name="NetworkConnectivityLevel.NetworkConnectivityLevel_LocalAccess"]/*' />
    NetworkConnectivityLevel_LocalAccess = 1,

    /// <include file='NetworkConnectivityLevel.xml' path='doc/member[@name="NetworkConnectivityLevel.NetworkConnectivityLevel_ConstrainedInternetAccess"]/*' />
    NetworkConnectivityLevel_ConstrainedInternetAccess = 2,

    /// <include file='NetworkConnectivityLevel.xml' path='doc/member[@name="NetworkConnectivityLevel.NetworkConnectivityLevel_InternetAccess"]/*' />
    NetworkConnectivityLevel_InternetAccess = 3,
}
