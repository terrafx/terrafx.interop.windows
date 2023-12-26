// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError"]/*' />
public enum MediaPlayerError
{
    /// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError.MediaPlayerError_Unknown"]/*' />
    MediaPlayerError_Unknown = 0,

    /// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError.MediaPlayerError_Aborted"]/*' />
    MediaPlayerError_Aborted = 1,

    /// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError.MediaPlayerError_NetworkError"]/*' />
    MediaPlayerError_NetworkError = 2,

    /// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError.MediaPlayerError_DecodingError"]/*' />
    MediaPlayerError_DecodingError = 3,

    /// <include file='MediaPlayerError.xml' path='doc/member[@name="MediaPlayerError.MediaPlayerError_SourceNotSupported"]/*' />
    MediaPlayerError_SourceNotSupported = 4,
}
