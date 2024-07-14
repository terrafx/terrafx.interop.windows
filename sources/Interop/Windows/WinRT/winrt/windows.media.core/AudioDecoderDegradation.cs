// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioDecoderDegradation.xml' path='doc/member[@name="AudioDecoderDegradation"]/*' />
public enum AudioDecoderDegradation
{
    /// <include file='AudioDecoderDegradation.xml' path='doc/member[@name="AudioDecoderDegradation.AudioDecoderDegradation_None"]/*' />
    AudioDecoderDegradation_None = 0,

    /// <include file='AudioDecoderDegradation.xml' path='doc/member[@name="AudioDecoderDegradation.AudioDecoderDegradation_DownmixTo2Channels"]/*' />
    AudioDecoderDegradation_DownmixTo2Channels = 1,

    /// <include file='AudioDecoderDegradation.xml' path='doc/member[@name="AudioDecoderDegradation.AudioDecoderDegradation_DownmixTo6Channels"]/*' />
    AudioDecoderDegradation_DownmixTo6Channels = 2,

    /// <include file='AudioDecoderDegradation.xml' path='doc/member[@name="AudioDecoderDegradation.AudioDecoderDegradation_DownmixTo8Channels"]/*' />
    AudioDecoderDegradation_DownmixTo8Channels = 3,
}
