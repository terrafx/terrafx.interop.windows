// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaEffectClosedReason.xml' path='doc/member[@name="MediaEffectClosedReason"]/*' />
public enum MediaEffectClosedReason
{
    /// <include file='MediaEffectClosedReason.xml' path='doc/member[@name="MediaEffectClosedReason.MediaEffectClosedReason_Done"]/*' />
    MediaEffectClosedReason_Done = 0,

    /// <include file='MediaEffectClosedReason.xml' path='doc/member[@name="MediaEffectClosedReason.MediaEffectClosedReason_UnknownError"]/*' />
    MediaEffectClosedReason_UnknownError = 1,

    /// <include file='MediaEffectClosedReason.xml' path='doc/member[@name="MediaEffectClosedReason.MediaEffectClosedReason_UnsupportedEncodingFormat"]/*' />
    MediaEffectClosedReason_UnsupportedEncodingFormat = 2,

    /// <include file='MediaEffectClosedReason.xml' path='doc/member[@name="MediaEffectClosedReason.MediaEffectClosedReason_EffectCurrentlyUnloaded"]/*' />
    MediaEffectClosedReason_EffectCurrentlyUnloaded = 3,
}
