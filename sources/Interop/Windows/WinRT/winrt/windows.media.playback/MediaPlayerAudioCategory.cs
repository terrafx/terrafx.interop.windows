// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory"]/*' />
public enum MediaPlayerAudioCategory
{
    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Other"]/*' />
    MediaPlayerAudioCategory_Other = 0,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Communications"]/*' />
    MediaPlayerAudioCategory_Communications = 3,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Alerts"]/*' />
    MediaPlayerAudioCategory_Alerts = 4,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_SoundEffects"]/*' />
    MediaPlayerAudioCategory_SoundEffects = 5,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_GameEffects"]/*' />
    MediaPlayerAudioCategory_GameEffects = 6,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_GameMedia"]/*' />
    MediaPlayerAudioCategory_GameMedia = 7,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_GameChat"]/*' />
    MediaPlayerAudioCategory_GameChat = 8,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Speech"]/*' />
    MediaPlayerAudioCategory_Speech = 9,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Movie"]/*' />
    MediaPlayerAudioCategory_Movie = 10,

    /// <include file='MediaPlayerAudioCategory.xml' path='doc/member[@name="MediaPlayerAudioCategory.MediaPlayerAudioCategory_Media"]/*' />
    MediaPlayerAudioCategory_Media = 11,
}
