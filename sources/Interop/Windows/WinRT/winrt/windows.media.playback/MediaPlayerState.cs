// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState"]/*' />
[Obsolete("Use MediaPlaybackState instead of MediaPlayerState.  For more info, see MSDN.")]
public enum MediaPlayerState
{
    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Closed"]/*' />
    MediaPlayerState_Closed = 0,

    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Opening"]/*' />
    MediaPlayerState_Opening = 1,

    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Buffering"]/*' />
    MediaPlayerState_Buffering = 2,

    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Playing"]/*' />
    MediaPlayerState_Playing = 3,

    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Paused"]/*' />
    MediaPlayerState_Paused = 4,

    /// <include file='MediaPlayerState.xml' path='doc/member[@name="MediaPlayerState.MediaPlayerState_Stopped"]/*' />
    MediaPlayerState_Stopped = 5,
}
