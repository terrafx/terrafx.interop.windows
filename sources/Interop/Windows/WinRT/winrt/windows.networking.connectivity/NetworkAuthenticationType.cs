// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType"]/*' />
public enum NetworkAuthenticationType
{
    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_None"]/*' />
    NetworkAuthenticationType_None = 0,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Unknown"]/*' />
    NetworkAuthenticationType_Unknown = 1,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Open80211"]/*' />
    NetworkAuthenticationType_Open80211 = 2,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_SharedKey80211"]/*' />
    NetworkAuthenticationType_SharedKey80211 = 3,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Wpa"]/*' />
    NetworkAuthenticationType_Wpa = 4,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_WpaPsk"]/*' />
    NetworkAuthenticationType_WpaPsk = 5,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_WpaNone"]/*' />
    NetworkAuthenticationType_WpaNone = 6,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Rsna"]/*' />
    NetworkAuthenticationType_Rsna = 7,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_RsnaPsk"]/*' />
    NetworkAuthenticationType_RsnaPsk = 8,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Ihv"]/*' />
    NetworkAuthenticationType_Ihv = 9,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Wpa3"]/*' />
    NetworkAuthenticationType_Wpa3 = 10,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Wpa3Enterprise192Bits"]/*' />
    NetworkAuthenticationType_Wpa3Enterprise192Bits = 10,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Wpa3Sae"]/*' />
    NetworkAuthenticationType_Wpa3Sae = 11,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Owe"]/*' />
    NetworkAuthenticationType_Owe = 12,

    /// <include file='NetworkAuthenticationType.xml' path='doc/member[@name="NetworkAuthenticationType.NetworkAuthenticationType_Wpa3Enterprise"]/*' />
    NetworkAuthenticationType_Wpa3Enterprise = 13,
}
