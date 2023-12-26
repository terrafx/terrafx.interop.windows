// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult"]/*' />
public enum AppBroadcastSignInResult
{
    /// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult.AppBroadcastSignInResult_Success"]/*' />
    AppBroadcastSignInResult_Success = 0,

    /// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult.AppBroadcastSignInResult_AuthenticationFailed"]/*' />
    AppBroadcastSignInResult_AuthenticationFailed = 1,

    /// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult.AppBroadcastSignInResult_Unauthorized"]/*' />
    AppBroadcastSignInResult_Unauthorized = 2,

    /// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult.AppBroadcastSignInResult_ServiceUnavailable"]/*' />
    AppBroadcastSignInResult_ServiceUnavailable = 3,

    /// <include file='AppBroadcastSignInResult.xml' path='doc/member[@name="AppBroadcastSignInResult.AppBroadcastSignInResult_Unknown"]/*' />
    AppBroadcastSignInResult_Unknown = 4,
}
