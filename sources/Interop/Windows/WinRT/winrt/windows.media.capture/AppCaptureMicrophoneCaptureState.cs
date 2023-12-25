// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureMicrophoneCaptureState.xml' path='doc/member[@name="AppCaptureMicrophoneCaptureState"]/*' />
public enum AppCaptureMicrophoneCaptureState
{
    /// <include file='AppCaptureMicrophoneCaptureState.xml' path='doc/member[@name="AppCaptureMicrophoneCaptureState.AppCaptureMicrophoneCaptureState_Stopped"]/*' />
    AppCaptureMicrophoneCaptureState_Stopped = 0,

    /// <include file='AppCaptureMicrophoneCaptureState.xml' path='doc/member[@name="AppCaptureMicrophoneCaptureState.AppCaptureMicrophoneCaptureState_Started"]/*' />
    AppCaptureMicrophoneCaptureState_Started = 1,

    /// <include file='AppCaptureMicrophoneCaptureState.xml' path='doc/member[@name="AppCaptureMicrophoneCaptureState.AppCaptureMicrophoneCaptureState_Failed"]/*' />
    AppCaptureMicrophoneCaptureState_Failed = 2,
}
