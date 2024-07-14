// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastCameraCaptureState.xml' path='doc/member[@name="AppBroadcastCameraCaptureState"]/*' />
public enum AppBroadcastCameraCaptureState
{
    /// <include file='AppBroadcastCameraCaptureState.xml' path='doc/member[@name="AppBroadcastCameraCaptureState.AppBroadcastCameraCaptureState_Stopped"]/*' />
    AppBroadcastCameraCaptureState_Stopped = 0,

    /// <include file='AppBroadcastCameraCaptureState.xml' path='doc/member[@name="AppBroadcastCameraCaptureState.AppBroadcastCameraCaptureState_Started"]/*' />
    AppBroadcastCameraCaptureState_Started = 1,

    /// <include file='AppBroadcastCameraCaptureState.xml' path='doc/member[@name="AppBroadcastCameraCaptureState.AppBroadcastCameraCaptureState_Failed"]/*' />
    AppBroadcastCameraCaptureState_Failed = 2,
}
