// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState"]/*' />
public enum MediaPlaybackState
{
    /// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState.MediaPlaybackState_None"]/*' />
    MediaPlaybackState_None = 0,

    /// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState.MediaPlaybackState_Opening"]/*' />
    MediaPlaybackState_Opening = 1,

    /// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState.MediaPlaybackState_Buffering"]/*' />
    MediaPlaybackState_Buffering = 2,

    /// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState.MediaPlaybackState_Playing"]/*' />
    MediaPlaybackState_Playing = 3,

    /// <include file='MediaPlaybackState.xml' path='doc/member[@name="MediaPlaybackState.MediaPlaybackState_Paused"]/*' />
    MediaPlaybackState_Paused = 4,
}
