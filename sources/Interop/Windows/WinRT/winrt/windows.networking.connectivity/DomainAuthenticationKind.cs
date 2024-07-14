// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DomainAuthenticationKind.xml' path='doc/member[@name="DomainAuthenticationKind"]/*' />
public enum DomainAuthenticationKind
{
    /// <include file='DomainAuthenticationKind.xml' path='doc/member[@name="DomainAuthenticationKind.DomainAuthenticationKind_None"]/*' />
    DomainAuthenticationKind_None = 0,

    /// <include file='DomainAuthenticationKind.xml' path='doc/member[@name="DomainAuthenticationKind.DomainAuthenticationKind_Ldap"]/*' />
    DomainAuthenticationKind_Ldap = 1,

    /// <include file='DomainAuthenticationKind.xml' path='doc/member[@name="DomainAuthenticationKind.DomainAuthenticationKind_Tls"]/*' />
    DomainAuthenticationKind_Tls = 2,
}
