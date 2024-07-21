// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus"]/*' />
public enum MediaPlaybackStatus
{
    /// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus.MediaPlaybackStatus_Closed"]/*' />
    MediaPlaybackStatus_Closed = 0,

    /// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus.MediaPlaybackStatus_Changing"]/*' />
    MediaPlaybackStatus_Changing = 1,

    /// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus.MediaPlaybackStatus_Stopped"]/*' />
    MediaPlaybackStatus_Stopped = 2,

    /// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus.MediaPlaybackStatus_Playing"]/*' />
    MediaPlaybackStatus_Playing = 3,

    /// <include file='MediaPlaybackStatus.xml' path='doc/member[@name="MediaPlaybackStatus.MediaPlaybackStatus_Paused"]/*' />
    MediaPlaybackStatus_Paused = 4,
}
