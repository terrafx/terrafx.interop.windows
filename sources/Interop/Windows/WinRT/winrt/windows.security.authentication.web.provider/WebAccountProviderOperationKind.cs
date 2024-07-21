// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind"]/*' />
public enum WebAccountProviderOperationKind
{
    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_RequestToken"]/*' />
    WebAccountProviderOperationKind_RequestToken = 0,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_GetTokenSilently"]/*' />
    WebAccountProviderOperationKind_GetTokenSilently = 1,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_AddAccount"]/*' />
    WebAccountProviderOperationKind_AddAccount = 2,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_ManageAccount"]/*' />
    WebAccountProviderOperationKind_ManageAccount = 3,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_DeleteAccount"]/*' />
    WebAccountProviderOperationKind_DeleteAccount = 4,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_RetrieveCookies"]/*' />
    WebAccountProviderOperationKind_RetrieveCookies = 5,

    /// <include file='WebAccountProviderOperationKind.xml' path='doc/member[@name="WebAccountProviderOperationKind.WebAccountProviderOperationKind_SignOutAccount"]/*' />
    WebAccountProviderOperationKind_SignOutAccount = 6,
}
