// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind"]/*' />
public enum WwanNetworkIPKind
{
    /// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind.WwanNetworkIPKind_None"]/*' />
    WwanNetworkIPKind_None = 0,

    /// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind.WwanNetworkIPKind_Ipv4"]/*' />
    WwanNetworkIPKind_Ipv4 = 1,

    /// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind.WwanNetworkIPKind_Ipv6"]/*' />
    WwanNetworkIPKind_Ipv6 = 2,

    /// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind.WwanNetworkIPKind_Ipv4v6"]/*' />
    WwanNetworkIPKind_Ipv4v6 = 3,

    /// <include file='WwanNetworkIPKind.xml' path='doc/member[@name="WwanNetworkIPKind.WwanNetworkIPKind_Ipv4v6v4Xlat"]/*' />
    WwanNetworkIPKind_Ipv4v6v4Xlat = 4,
}
