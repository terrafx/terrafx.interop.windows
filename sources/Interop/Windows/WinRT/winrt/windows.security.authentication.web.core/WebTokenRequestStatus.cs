// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus"]/*' />
public enum WebTokenRequestStatus
{
    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_Success"]/*' />
    WebTokenRequestStatus_Success = 0,

    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_UserCancel"]/*' />
    WebTokenRequestStatus_UserCancel = 1,

    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_AccountSwitch"]/*' />
    WebTokenRequestStatus_AccountSwitch = 2,

    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_UserInteractionRequired"]/*' />
    WebTokenRequestStatus_UserInteractionRequired = 3,

    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_AccountProviderNotAvailable"]/*' />
    WebTokenRequestStatus_AccountProviderNotAvailable = 4,

    /// <include file='WebTokenRequestStatus.xml' path='doc/member[@name="WebTokenRequestStatus.WebTokenRequestStatus_ProviderError"]/*' />
    WebTokenRequestStatus_ProviderError = 5,
}
