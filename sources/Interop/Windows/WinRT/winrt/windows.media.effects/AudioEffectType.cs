// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType"]/*' />
public enum AudioEffectType
{
    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_Other"]/*' />
    AudioEffectType_Other = 0,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_AcousticEchoCancellation"]/*' />
    AudioEffectType_AcousticEchoCancellation = 1,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_NoiseSuppression"]/*' />
    AudioEffectType_NoiseSuppression = 2,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_AutomaticGainControl"]/*' />
    AudioEffectType_AutomaticGainControl = 3,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_BeamForming"]/*' />
    AudioEffectType_BeamForming = 4,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_ConstantToneRemoval"]/*' />
    AudioEffectType_ConstantToneRemoval = 5,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_Equalizer"]/*' />
    AudioEffectType_Equalizer = 6,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_LoudnessEqualizer"]/*' />
    AudioEffectType_LoudnessEqualizer = 7,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_BassBoost"]/*' />
    AudioEffectType_BassBoost = 8,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_VirtualSurround"]/*' />
    AudioEffectType_VirtualSurround = 9,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_VirtualHeadphones"]/*' />
    AudioEffectType_VirtualHeadphones = 10,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_SpeakerFill"]/*' />
    AudioEffectType_SpeakerFill = 11,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_RoomCorrection"]/*' />
    AudioEffectType_RoomCorrection = 12,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_BassManagement"]/*' />
    AudioEffectType_BassManagement = 13,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_EnvironmentalEffects"]/*' />
    AudioEffectType_EnvironmentalEffects = 14,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_SpeakerProtection"]/*' />
    AudioEffectType_SpeakerProtection = 15,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_SpeakerCompensation"]/*' />
    AudioEffectType_SpeakerCompensation = 16,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_DynamicRangeCompression"]/*' />
    AudioEffectType_DynamicRangeCompression = 17,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_FarFieldBeamForming"]/*' />
    AudioEffectType_FarFieldBeamForming = 18,

    /// <include file='AudioEffectType.xml' path='doc/member[@name="AudioEffectType.AudioEffectType_DeepNoiseSuppression"]/*' />
    AudioEffectType_DeepNoiseSuppression = 19,
}
