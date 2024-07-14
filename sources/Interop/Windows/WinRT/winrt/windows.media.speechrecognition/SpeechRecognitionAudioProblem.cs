// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem"]/*' />
public enum SpeechRecognitionAudioProblem
{
    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_None"]/*' />
    SpeechRecognitionAudioProblem_None = 0,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_TooNoisy"]/*' />
    SpeechRecognitionAudioProblem_TooNoisy = 1,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_NoSignal"]/*' />
    SpeechRecognitionAudioProblem_NoSignal = 2,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_TooLoud"]/*' />
    SpeechRecognitionAudioProblem_TooLoud = 3,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_TooQuiet"]/*' />
    SpeechRecognitionAudioProblem_TooQuiet = 4,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_TooFast"]/*' />
    SpeechRecognitionAudioProblem_TooFast = 5,

    /// <include file='SpeechRecognitionAudioProblem.xml' path='doc/member[@name="SpeechRecognitionAudioProblem.SpeechRecognitionAudioProblem_TooSlow"]/*' />
    SpeechRecognitionAudioProblem_TooSlow = 6,
}
