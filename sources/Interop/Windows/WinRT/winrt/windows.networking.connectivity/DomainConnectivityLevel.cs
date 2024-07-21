// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DomainConnectivityLevel.xml' path='doc/member[@name="DomainConnectivityLevel"]/*' />
public enum DomainConnectivityLevel
{
    /// <include file='DomainConnectivityLevel.xml' path='doc/member[@name="DomainConnectivityLevel.DomainConnectivityLevel_None"]/*' />
    DomainConnectivityLevel_None = 0,

    /// <include file='DomainConnectivityLevel.xml' path='doc/member[@name="DomainConnectivityLevel.DomainConnectivityLevel_Unauthenticated"]/*' />
    DomainConnectivityLevel_Unauthenticated = 1,

    /// <include file='DomainConnectivityLevel.xml' path='doc/member[@name="DomainConnectivityLevel.DomainConnectivityLevel_Authenticated"]/*' />
    DomainConnectivityLevel_Authenticated = 2,
}
