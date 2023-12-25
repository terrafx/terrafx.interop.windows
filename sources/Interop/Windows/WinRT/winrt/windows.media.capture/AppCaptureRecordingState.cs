// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureRecordingState.xml' path='doc/member[@name="AppCaptureRecordingState"]/*' />
public enum AppCaptureRecordingState
{
    /// <include file='AppCaptureRecordingState.xml' path='doc/member[@name="AppCaptureRecordingState.AppCaptureRecordingState_InProgress"]/*' />
    AppCaptureRecordingState_InProgress = 0,

    /// <include file='AppCaptureRecordingState.xml' path='doc/member[@name="AppCaptureRecordingState.AppCaptureRecordingState_Completed"]/*' />
    AppCaptureRecordingState_Completed = 1,

    /// <include file='AppCaptureRecordingState.xml' path='doc/member[@name="AppCaptureRecordingState.AppCaptureRecordingState_Failed"]/*' />
    AppCaptureRecordingState_Failed = 2,
}
