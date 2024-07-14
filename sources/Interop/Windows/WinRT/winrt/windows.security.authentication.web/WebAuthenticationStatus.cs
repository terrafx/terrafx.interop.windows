// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAuthenticationStatus.xml' path='doc/member[@name="WebAuthenticationStatus"]/*' />
public enum WebAuthenticationStatus
{
    /// <include file='WebAuthenticationStatus.xml' path='doc/member[@name="WebAuthenticationStatus.WebAuthenticationStatus_Success"]/*' />
    WebAuthenticationStatus_Success = 0,

    /// <include file='WebAuthenticationStatus.xml' path='doc/member[@name="WebAuthenticationStatus.WebAuthenticationStatus_UserCancel"]/*' />
    WebAuthenticationStatus_UserCancel = 1,

    /// <include file='WebAuthenticationStatus.xml' path='doc/member[@name="WebAuthenticationStatus.WebAuthenticationStatus_ErrorHttp"]/*' />
    WebAuthenticationStatus_ErrorHttp = 2,
}
