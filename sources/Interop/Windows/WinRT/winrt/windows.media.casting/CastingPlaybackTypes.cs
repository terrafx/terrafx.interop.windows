// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CastingPlaybackTypes.xml' path='doc/member[@name="CastingPlaybackTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum CastingPlaybackTypes : uint
{
    /// <include file='CastingPlaybackTypes.xml' path='doc/member[@name="CastingPlaybackTypes.CastingPlaybackTypes_None"]/*' />
    CastingPlaybackTypes_None = 0,

    /// <include file='CastingPlaybackTypes.xml' path='doc/member[@name="CastingPlaybackTypes.CastingPlaybackTypes_Audio"]/*' />
    CastingPlaybackTypes_Audio = 0x1,

    /// <include file='CastingPlaybackTypes.xml' path='doc/member[@name="CastingPlaybackTypes.CastingPlaybackTypes_Video"]/*' />
    CastingPlaybackTypes_Video = 0x2,

    /// <include file='CastingPlaybackTypes.xml' path='doc/member[@name="CastingPlaybackTypes.CastingPlaybackTypes_Picture"]/*' />
    CastingPlaybackTypes_Picture = 0x4,
}
