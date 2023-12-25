// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AutoLoadedDisplayPropertyKind.xml' path='doc/member[@name="AutoLoadedDisplayPropertyKind"]/*' />
public enum AutoLoadedDisplayPropertyKind
{
    /// <include file='AutoLoadedDisplayPropertyKind.xml' path='doc/member[@name="AutoLoadedDisplayPropertyKind.AutoLoadedDisplayPropertyKind_None"]/*' />
    AutoLoadedDisplayPropertyKind_None = 0,

    /// <include file='AutoLoadedDisplayPropertyKind.xml' path='doc/member[@name="AutoLoadedDisplayPropertyKind.AutoLoadedDisplayPropertyKind_MusicOrVideo"]/*' />
    AutoLoadedDisplayPropertyKind_MusicOrVideo = 1,

    /// <include file='AutoLoadedDisplayPropertyKind.xml' path='doc/member[@name="AutoLoadedDisplayPropertyKind.AutoLoadedDisplayPropertyKind_Music"]/*' />
    AutoLoadedDisplayPropertyKind_Music = 2,

    /// <include file='AutoLoadedDisplayPropertyKind.xml' path='doc/member[@name="AutoLoadedDisplayPropertyKind.AutoLoadedDisplayPropertyKind_Video"]/*' />
    AutoLoadedDisplayPropertyKind_Video = 3,
}
