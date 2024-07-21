// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState"]/*' />
public enum SpeechRecognizerState
{
    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_Idle"]/*' />
    SpeechRecognizerState_Idle = 0,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_Capturing"]/*' />
    SpeechRecognizerState_Capturing = 1,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_Processing"]/*' />
    SpeechRecognizerState_Processing = 2,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_SoundStarted"]/*' />
    SpeechRecognizerState_SoundStarted = 3,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_SoundEnded"]/*' />
    SpeechRecognizerState_SoundEnded = 4,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_SpeechDetected"]/*' />
    SpeechRecognizerState_SpeechDetected = 5,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SpeechRecognizerState_Paused"]/*' />
    SpeechRecognizerState_Paused = 6,
}
