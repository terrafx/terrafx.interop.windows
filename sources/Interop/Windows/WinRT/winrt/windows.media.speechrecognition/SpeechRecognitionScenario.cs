// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionScenario.xml' path='doc/member[@name="SpeechRecognitionScenario"]/*' />
public enum SpeechRecognitionScenario
{
    /// <include file='SpeechRecognitionScenario.xml' path='doc/member[@name="SpeechRecognitionScenario.SpeechRecognitionScenario_WebSearch"]/*' />
    SpeechRecognitionScenario_WebSearch = 0,

    /// <include file='SpeechRecognitionScenario.xml' path='doc/member[@name="SpeechRecognitionScenario.SpeechRecognitionScenario_Dictation"]/*' />
    SpeechRecognitionScenario_Dictation = 1,

    /// <include file='SpeechRecognitionScenario.xml' path='doc/member[@name="SpeechRecognitionScenario.SpeechRecognitionScenario_FormFilling"]/*' />
    SpeechRecognitionScenario_FormFilling = 2,
}
