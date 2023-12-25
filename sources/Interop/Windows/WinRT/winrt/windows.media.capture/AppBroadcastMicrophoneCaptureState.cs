// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastMicrophoneCaptureState.xml' path='doc/member[@name="AppBroadcastMicrophoneCaptureState"]/*' />
public enum AppBroadcastMicrophoneCaptureState
{
    /// <include file='AppBroadcastMicrophoneCaptureState.xml' path='doc/member[@name="AppBroadcastMicrophoneCaptureState.AppBroadcastMicrophoneCaptureState_Stopped"]/*' />
    AppBroadcastMicrophoneCaptureState_Stopped = 0,

    /// <include file='AppBroadcastMicrophoneCaptureState.xml' path='doc/member[@name="AppBroadcastMicrophoneCaptureState.AppBroadcastMicrophoneCaptureState_Started"]/*' />
    AppBroadcastMicrophoneCaptureState_Started = 1,

    /// <include file='AppBroadcastMicrophoneCaptureState.xml' path='doc/member[@name="AppBroadcastMicrophoneCaptureState.AppBroadcastMicrophoneCaptureState_Failed"]/*' />
    AppBroadcastMicrophoneCaptureState_Failed = 2,
}
