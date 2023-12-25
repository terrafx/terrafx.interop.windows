// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackItemChangedReason.xml' path='doc/member[@name="MediaPlaybackItemChangedReason"]/*' />
public enum MediaPlaybackItemChangedReason
{
    /// <include file='MediaPlaybackItemChangedReason.xml' path='doc/member[@name="MediaPlaybackItemChangedReason.MediaPlaybackItemChangedReason_InitialItem"]/*' />
    MediaPlaybackItemChangedReason_InitialItem = 0,

    /// <include file='MediaPlaybackItemChangedReason.xml' path='doc/member[@name="MediaPlaybackItemChangedReason.MediaPlaybackItemChangedReason_EndOfStream"]/*' />
    MediaPlaybackItemChangedReason_EndOfStream = 1,

    /// <include file='MediaPlaybackItemChangedReason.xml' path='doc/member[@name="MediaPlaybackItemChangedReason.MediaPlaybackItemChangedReason_Error"]/*' />
    MediaPlaybackItemChangedReason_Error = 2,

    /// <include file='MediaPlaybackItemChangedReason.xml' path='doc/member[@name="MediaPlaybackItemChangedReason.MediaPlaybackItemChangedReason_AppRequested"]/*' />
    MediaPlaybackItemChangedReason_AppRequested = 3,
}
