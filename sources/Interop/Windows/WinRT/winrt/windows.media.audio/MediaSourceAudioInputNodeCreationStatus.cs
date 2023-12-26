// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaSourceAudioInputNodeCreationStatus.xml' path='doc/member[@name="MediaSourceAudioInputNodeCreationStatus"]/*' />
public enum MediaSourceAudioInputNodeCreationStatus
{
    /// <include file='MediaSourceAudioInputNodeCreationStatus.xml' path='doc/member[@name="MediaSourceAudioInputNodeCreationStatus.MediaSourceAudioInputNodeCreationStatus_Success"]/*' />
    MediaSourceAudioInputNodeCreationStatus_Success = 0,

    /// <include file='MediaSourceAudioInputNodeCreationStatus.xml' path='doc/member[@name="MediaSourceAudioInputNodeCreationStatus.MediaSourceAudioInputNodeCreationStatus_FormatNotSupported"]/*' />
    MediaSourceAudioInputNodeCreationStatus_FormatNotSupported = 1,

    /// <include file='MediaSourceAudioInputNodeCreationStatus.xml' path='doc/member[@name="MediaSourceAudioInputNodeCreationStatus.MediaSourceAudioInputNodeCreationStatus_NetworkError"]/*' />
    MediaSourceAudioInputNodeCreationStatus_NetworkError = 2,

    /// <include file='MediaSourceAudioInputNodeCreationStatus.xml' path='doc/member[@name="MediaSourceAudioInputNodeCreationStatus.MediaSourceAudioInputNodeCreationStatus_UnknownFailure"]/*' />
    MediaSourceAudioInputNodeCreationStatus_UnknownFailure = 3,
}
