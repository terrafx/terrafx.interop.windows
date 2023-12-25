// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus"]/*' />
public enum SpeechRecognitionResultStatus
{
    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_Success"]/*' />
    SpeechRecognitionResultStatus_Success = 0,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_TopicLanguageNotSupported"]/*' />
    SpeechRecognitionResultStatus_TopicLanguageNotSupported = 1,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_GrammarLanguageMismatch"]/*' />
    SpeechRecognitionResultStatus_GrammarLanguageMismatch = 2,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_GrammarCompilationFailure"]/*' />
    SpeechRecognitionResultStatus_GrammarCompilationFailure = 3,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_AudioQualityFailure"]/*' />
    SpeechRecognitionResultStatus_AudioQualityFailure = 4,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_UserCanceled"]/*' />
    SpeechRecognitionResultStatus_UserCanceled = 5,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_Unknown"]/*' />
    SpeechRecognitionResultStatus_Unknown = 6,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_TimeoutExceeded"]/*' />
    SpeechRecognitionResultStatus_TimeoutExceeded = 7,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_PauseLimitExceeded"]/*' />
    SpeechRecognitionResultStatus_PauseLimitExceeded = 8,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_NetworkFailure"]/*' />
    SpeechRecognitionResultStatus_NetworkFailure = 9,

    /// <include file='SpeechRecognitionResultStatus.xml' path='doc/member[@name="SpeechRecognitionResultStatus.SpeechRecognitionResultStatus_MicrophoneUnavailable"]/*' />
    SpeechRecognitionResultStatus_MicrophoneUnavailable = 10,
}
