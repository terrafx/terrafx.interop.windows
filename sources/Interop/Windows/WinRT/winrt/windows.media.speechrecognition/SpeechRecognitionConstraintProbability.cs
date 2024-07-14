// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionConstraintProbability.xml' path='doc/member[@name="SpeechRecognitionConstraintProbability"]/*' />
public enum SpeechRecognitionConstraintProbability
{
    /// <include file='SpeechRecognitionConstraintProbability.xml' path='doc/member[@name="SpeechRecognitionConstraintProbability.SpeechRecognitionConstraintProbability_Default"]/*' />
    SpeechRecognitionConstraintProbability_Default = 0,

    /// <include file='SpeechRecognitionConstraintProbability.xml' path='doc/member[@name="SpeechRecognitionConstraintProbability.SpeechRecognitionConstraintProbability_Min"]/*' />
    SpeechRecognitionConstraintProbability_Min = 1,

    /// <include file='SpeechRecognitionConstraintProbability.xml' path='doc/member[@name="SpeechRecognitionConstraintProbability.SpeechRecognitionConstraintProbability_Max"]/*' />
    SpeechRecognitionConstraintProbability_Max = 2,
}
