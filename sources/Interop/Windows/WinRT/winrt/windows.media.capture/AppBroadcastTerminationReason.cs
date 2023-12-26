// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason"]/*' />
public enum AppBroadcastTerminationReason
{
    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_NormalTermination"]/*' />
    AppBroadcastTerminationReason_NormalTermination = 0,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_LostConnectionToService"]/*' />
    AppBroadcastTerminationReason_LostConnectionToService = 1,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_NoNetworkConnectivity"]/*' />
    AppBroadcastTerminationReason_NoNetworkConnectivity = 2,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_ServiceAbort"]/*' />
    AppBroadcastTerminationReason_ServiceAbort = 3,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_ServiceError"]/*' />
    AppBroadcastTerminationReason_ServiceError = 4,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_ServiceUnavailable"]/*' />
    AppBroadcastTerminationReason_ServiceUnavailable = 5,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_InternalError"]/*' />
    AppBroadcastTerminationReason_InternalError = 6,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_UnsupportedFormat"]/*' />
    AppBroadcastTerminationReason_UnsupportedFormat = 7,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_BackgroundTaskTerminated"]/*' />
    AppBroadcastTerminationReason_BackgroundTaskTerminated = 8,

    /// <include file='AppBroadcastTerminationReason.xml' path='doc/member[@name="AppBroadcastTerminationReason.AppBroadcastTerminationReason_BackgroundTaskUnresponsive"]/*' />
    AppBroadcastTerminationReason_BackgroundTaskUnresponsive = 9,
}
