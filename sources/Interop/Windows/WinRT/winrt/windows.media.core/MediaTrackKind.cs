// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaTrackKind.xml' path='doc/member[@name="MediaTrackKind"]/*' />
public enum MediaTrackKind
{
    /// <include file='MediaTrackKind.xml' path='doc/member[@name="MediaTrackKind.MediaTrackKind_Audio"]/*' />
    MediaTrackKind_Audio = 0,

    /// <include file='MediaTrackKind.xml' path='doc/member[@name="MediaTrackKind.MediaTrackKind_Video"]/*' />
    MediaTrackKind_Video = 1,

    /// <include file='MediaTrackKind.xml' path='doc/member[@name="MediaTrackKind.MediaTrackKind_TimedMetadata"]/*' />
    MediaTrackKind_TimedMetadata = 2,
}
