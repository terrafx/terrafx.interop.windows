// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState"]/*' />
public enum AppBroadcastPlugInState
{
    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_Unknown"]/*' />
    AppBroadcastPlugInState_Unknown = 0,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_Initialized"]/*' />
    AppBroadcastPlugInState_Initialized = 1,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_MicrosoftSignInRequired"]/*' />
    AppBroadcastPlugInState_MicrosoftSignInRequired = 2,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_OAuthSignInRequired"]/*' />
    AppBroadcastPlugInState_OAuthSignInRequired = 3,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_ProviderSignInRequired"]/*' />
    AppBroadcastPlugInState_ProviderSignInRequired = 4,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_InBandwidthTest"]/*' />
    AppBroadcastPlugInState_InBandwidthTest = 5,

    /// <include file='AppBroadcastPlugInState.xml' path='doc/member[@name="AppBroadcastPlugInState.AppBroadcastPlugInState_ReadyToBroadcast"]/*' />
    AppBroadcastPlugInState_ReadyToBroadcast = 6,
}
