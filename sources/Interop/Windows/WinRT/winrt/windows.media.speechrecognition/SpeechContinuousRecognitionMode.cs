// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechContinuousRecognitionMode.xml' path='doc/member[@name="SpeechContinuousRecognitionMode"]/*' />
public enum SpeechContinuousRecognitionMode
{
    /// <include file='SpeechContinuousRecognitionMode.xml' path='doc/member[@name="SpeechContinuousRecognitionMode.SpeechContinuousRecognitionMode_Default"]/*' />
    SpeechContinuousRecognitionMode_Default = 0,

    /// <include file='SpeechContinuousRecognitionMode.xml' path='doc/member[@name="SpeechContinuousRecognitionMode.SpeechContinuousRecognitionMode_PauseOnRecognition"]/*' />
    SpeechContinuousRecognitionMode_PauseOnRecognition = 1,
}
