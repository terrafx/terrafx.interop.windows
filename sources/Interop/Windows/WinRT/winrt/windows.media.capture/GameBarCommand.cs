// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand"]/*' />
public enum GameBarCommand
{
    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_OpenGameBar"]/*' />
    GameBarCommand_OpenGameBar = 0,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_RecordHistoricalBuffer"]/*' />
    GameBarCommand_RecordHistoricalBuffer = 1,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ToggleStartStopRecord"]/*' />
    GameBarCommand_ToggleStartStopRecord = 2,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_StartRecord"]/*' />
    GameBarCommand_StartRecord = 3,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_StopRecord"]/*' />
    GameBarCommand_StopRecord = 4,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_TakeScreenshot"]/*' />
    GameBarCommand_TakeScreenshot = 5,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_StartBroadcast"]/*' />
    GameBarCommand_StartBroadcast = 6,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_StopBroadcast"]/*' />
    GameBarCommand_StopBroadcast = 7,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_PauseBroadcast"]/*' />
    GameBarCommand_PauseBroadcast = 8,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ResumeBroadcast"]/*' />
    GameBarCommand_ResumeBroadcast = 9,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ToggleStartStopBroadcast"]/*' />
    GameBarCommand_ToggleStartStopBroadcast = 10,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ToggleMicrophoneCapture"]/*' />
    GameBarCommand_ToggleMicrophoneCapture = 11,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ToggleCameraCapture"]/*' />
    GameBarCommand_ToggleCameraCapture = 12,

    /// <include file='GameBarCommand.xml' path='doc/member[@name="GameBarCommand.GameBarCommand_ToggleRecordingIndicator"]/*' />
    GameBarCommand_ToggleRecordingIndicator = 13,
}
