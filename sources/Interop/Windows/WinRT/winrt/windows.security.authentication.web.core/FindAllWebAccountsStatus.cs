// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FindAllWebAccountsStatus.xml' path='doc/member[@name="FindAllWebAccountsStatus"]/*' />
public enum FindAllWebAccountsStatus
{
    /// <include file='FindAllWebAccountsStatus.xml' path='doc/member[@name="FindAllWebAccountsStatus.FindAllWebAccountsStatus_Success"]/*' />
    FindAllWebAccountsStatus_Success = 0,

    /// <include file='FindAllWebAccountsStatus.xml' path='doc/member[@name="FindAllWebAccountsStatus.FindAllWebAccountsStatus_NotAllowedByProvider"]/*' />
    FindAllWebAccountsStatus_NotAllowedByProvider = 1,

    /// <include file='FindAllWebAccountsStatus.xml' path='doc/member[@name="FindAllWebAccountsStatus.FindAllWebAccountsStatus_NotSupportedByProvider"]/*' />
    FindAllWebAccountsStatus_NotSupportedByProvider = 2,

    /// <include file='FindAllWebAccountsStatus.xml' path='doc/member[@name="FindAllWebAccountsStatus.FindAllWebAccountsStatus_ProviderError"]/*' />
    FindAllWebAccountsStatus_ProviderError = 3,
}
