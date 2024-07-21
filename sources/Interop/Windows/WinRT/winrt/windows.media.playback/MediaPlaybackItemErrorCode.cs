// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode"]/*' />
public enum MediaPlaybackItemErrorCode
{
    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_None"]/*' />
    MediaPlaybackItemErrorCode_None = 0,

    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_Aborted"]/*' />
    MediaPlaybackItemErrorCode_Aborted = 1,

    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_NetworkError"]/*' />
    MediaPlaybackItemErrorCode_NetworkError = 2,

    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_DecodeError"]/*' />
    MediaPlaybackItemErrorCode_DecodeError = 3,

    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_SourceNotSupportedError"]/*' />
    MediaPlaybackItemErrorCode_SourceNotSupportedError = 4,

    /// <include file='MediaPlaybackItemErrorCode.xml' path='doc/member[@name="MediaPlaybackItemErrorCode.MediaPlaybackItemErrorCode_EncryptionError"]/*' />
    MediaPlaybackItemErrorCode_EncryptionError = 5,
}
