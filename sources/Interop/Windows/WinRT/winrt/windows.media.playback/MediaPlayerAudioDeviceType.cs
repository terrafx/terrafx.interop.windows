// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlayerAudioDeviceType.xml' path='doc/member[@name="MediaPlayerAudioDeviceType"]/*' />
public enum MediaPlayerAudioDeviceType
{
    /// <include file='MediaPlayerAudioDeviceType.xml' path='doc/member[@name="MediaPlayerAudioDeviceType.MediaPlayerAudioDeviceType_Console"]/*' />
    MediaPlayerAudioDeviceType_Console = 0,

    /// <include file='MediaPlayerAudioDeviceType.xml' path='doc/member[@name="MediaPlayerAudioDeviceType.MediaPlayerAudioDeviceType_Multimedia"]/*' />
    MediaPlayerAudioDeviceType_Multimedia = 1,

    /// <include file='MediaPlayerAudioDeviceType.xml' path='doc/member[@name="MediaPlayerAudioDeviceType.MediaPlayerAudioDeviceType_Communications"]/*' />
    MediaPlayerAudioDeviceType_Communications = 2,
}
