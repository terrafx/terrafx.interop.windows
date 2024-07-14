// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioDecoderDegradationReason.xml' path='doc/member[@name="AudioDecoderDegradationReason"]/*' />
public enum AudioDecoderDegradationReason
{
    /// <include file='AudioDecoderDegradationReason.xml' path='doc/member[@name="AudioDecoderDegradationReason.AudioDecoderDegradationReason_None"]/*' />
    AudioDecoderDegradationReason_None = 0,

    /// <include file='AudioDecoderDegradationReason.xml' path='doc/member[@name="AudioDecoderDegradationReason.AudioDecoderDegradationReason_LicensingRequirement"]/*' />
    AudioDecoderDegradationReason_LicensingRequirement = 1,

    /// <include file='AudioDecoderDegradationReason.xml' path='doc/member[@name="AudioDecoderDegradationReason.AudioDecoderDegradationReason_SpatialAudioNotSupported"]/*' />
    AudioDecoderDegradationReason_SpatialAudioNotSupported = 2,
}
