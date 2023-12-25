// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackAutoRepeatMode.xml' path='doc/member[@name="MediaPlaybackAutoRepeatMode"]/*' />
public enum MediaPlaybackAutoRepeatMode
{
    /// <include file='MediaPlaybackAutoRepeatMode.xml' path='doc/member[@name="MediaPlaybackAutoRepeatMode.MediaPlaybackAutoRepeatMode_None"]/*' />
    MediaPlaybackAutoRepeatMode_None = 0,

    /// <include file='MediaPlaybackAutoRepeatMode.xml' path='doc/member[@name="MediaPlaybackAutoRepeatMode.MediaPlaybackAutoRepeatMode_Track"]/*' />
    MediaPlaybackAutoRepeatMode_Track = 1,

    /// <include file='MediaPlaybackAutoRepeatMode.xml' path='doc/member[@name="MediaPlaybackAutoRepeatMode.MediaPlaybackAutoRepeatMode_List"]/*' />
    MediaPlaybackAutoRepeatMode_List = 2,
}
