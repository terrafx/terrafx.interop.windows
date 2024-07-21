// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackType.xml' path='doc/member[@name="MediaPlaybackType"]/*' />
public enum MediaPlaybackType
{
    /// <include file='MediaPlaybackType.xml' path='doc/member[@name="MediaPlaybackType.MediaPlaybackType_Unknown"]/*' />
    MediaPlaybackType_Unknown = 0,

    /// <include file='MediaPlaybackType.xml' path='doc/member[@name="MediaPlaybackType.MediaPlaybackType_Music"]/*' />
    MediaPlaybackType_Music = 1,

    /// <include file='MediaPlaybackType.xml' path='doc/member[@name="MediaPlaybackType.MediaPlaybackType_Video"]/*' />
    MediaPlaybackType_Video = 2,

    /// <include file='MediaPlaybackType.xml' path='doc/member[@name="MediaPlaybackType.MediaPlaybackType_Image"]/*' />
    MediaPlaybackType_Image = 3,
}
