// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason"]/*' />
public enum MediaPlaybackSessionVideoConstrictionReason
{
    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_None"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_None = 0,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_VirtualMachine"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_VirtualMachine = 1,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_UnsupportedDisplayAdapter"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_UnsupportedDisplayAdapter = 2,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_UnsignedDriver"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_UnsignedDriver = 3,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_FrameServerEnabled"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_FrameServerEnabled = 4,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_OutputProtectionFailed"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_OutputProtectionFailed = 5,

    /// <include file='MediaPlaybackSessionVideoConstrictionReason.xml' path='doc/member[@name="MediaPlaybackSessionVideoConstrictionReason.MediaPlaybackSessionVideoConstrictionReason_Unknown"]/*' />
    MediaPlaybackSessionVideoConstrictionReason_Unknown = 6,
}
