// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastExitBroadcastModeReason.xml' path='doc/member[@name="AppBroadcastExitBroadcastModeReason"]/*' />
public enum AppBroadcastExitBroadcastModeReason
{
    /// <include file='AppBroadcastExitBroadcastModeReason.xml' path='doc/member[@name="AppBroadcastExitBroadcastModeReason.AppBroadcastExitBroadcastModeReason_NormalExit"]/*' />
    AppBroadcastExitBroadcastModeReason_NormalExit = 0,

    /// <include file='AppBroadcastExitBroadcastModeReason.xml' path='doc/member[@name="AppBroadcastExitBroadcastModeReason.AppBroadcastExitBroadcastModeReason_UserCanceled"]/*' />
    AppBroadcastExitBroadcastModeReason_UserCanceled = 1,

    /// <include file='AppBroadcastExitBroadcastModeReason.xml' path='doc/member[@name="AppBroadcastExitBroadcastModeReason.AppBroadcastExitBroadcastModeReason_AuthorizationFail"]/*' />
    AppBroadcastExitBroadcastModeReason_AuthorizationFail = 2,

    /// <include file='AppBroadcastExitBroadcastModeReason.xml' path='doc/member[@name="AppBroadcastExitBroadcastModeReason.AppBroadcastExitBroadcastModeReason_ForegroundAppActivated"]/*' />
    AppBroadcastExitBroadcastModeReason_ForegroundAppActivated = 3,
}
