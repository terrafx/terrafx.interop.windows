// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpeechRecognitionConstraintType.xml' path='doc/member[@name="SpeechRecognitionConstraintType"]/*' />
public enum SpeechRecognitionConstraintType
{
    /// <include file='SpeechRecognitionConstraintType.xml' path='doc/member[@name="SpeechRecognitionConstraintType.SpeechRecognitionConstraintType_Topic"]/*' />
    SpeechRecognitionConstraintType_Topic = 0,

    /// <include file='SpeechRecognitionConstraintType.xml' path='doc/member[@name="SpeechRecognitionConstraintType.SpeechRecognitionConstraintType_List"]/*' />
    SpeechRecognitionConstraintType_List = 1,

    /// <include file='SpeechRecognitionConstraintType.xml' path='doc/member[@name="SpeechRecognitionConstraintType.SpeechRecognitionConstraintType_Grammar"]/*' />
    SpeechRecognitionConstraintType_Grammar = 2,

    /// <include file='SpeechRecognitionConstraintType.xml' path='doc/member[@name="SpeechRecognitionConstraintType.SpeechRecognitionConstraintType_VoiceCommandDefinition"]/*' />
    SpeechRecognitionConstraintType_VoiceCommandDefinition = 3,
}
