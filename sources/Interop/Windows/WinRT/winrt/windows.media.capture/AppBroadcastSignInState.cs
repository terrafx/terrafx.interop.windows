// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState"]/*' />
public enum AppBroadcastSignInState
{
    /// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState.AppBroadcastSignInState_NotSignedIn"]/*' />
    AppBroadcastSignInState_NotSignedIn = 0,

    /// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState.AppBroadcastSignInState_MicrosoftSignInInProgress"]/*' />
    AppBroadcastSignInState_MicrosoftSignInInProgress = 1,

    /// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState.AppBroadcastSignInState_MicrosoftSignInComplete"]/*' />
    AppBroadcastSignInState_MicrosoftSignInComplete = 2,

    /// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState.AppBroadcastSignInState_OAuthSignInInProgress"]/*' />
    AppBroadcastSignInState_OAuthSignInInProgress = 3,

    /// <include file='AppBroadcastSignInState.xml' path='doc/member[@name="AppBroadcastSignInState.AppBroadcastSignInState_OAuthSignInComplete"]/*' />
    AppBroadcastSignInState_OAuthSignInComplete = 4,
}
