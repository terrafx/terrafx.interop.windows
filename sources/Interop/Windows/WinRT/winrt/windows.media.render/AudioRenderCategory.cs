// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.render.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory"]/*' />
public enum AudioRenderCategory
{
    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Other"]/*' />
    AudioRenderCategory_Other = 0,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_ForegroundOnlyMedia"]/*' />
    [Obsolete("ForegroundOnlyMedia is deprecated and might not work on all platforms. For more info, see MSDN.")]
    AudioRenderCategory_ForegroundOnlyMedia = 1,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_BackgroundCapableMedia"]/*' />
    [Obsolete("BackgroundCapableMedia is deprecated and might not work on all platforms. For more info, see MSDN.")]
    AudioRenderCategory_BackgroundCapableMedia = 2,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Communications"]/*' />
    AudioRenderCategory_Communications = 3,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Alerts"]/*' />
    AudioRenderCategory_Alerts = 4,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_SoundEffects"]/*' />
    AudioRenderCategory_SoundEffects = 5,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_GameEffects"]/*' />
    AudioRenderCategory_GameEffects = 6,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_GameMedia"]/*' />
    AudioRenderCategory_GameMedia = 7,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_GameChat"]/*' />
    AudioRenderCategory_GameChat = 8,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Speech"]/*' />
    AudioRenderCategory_Speech = 9,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Movie"]/*' />
    AudioRenderCategory_Movie = 10,

    /// <include file='AudioRenderCategory.xml' path='doc/member[@name="AudioRenderCategory.AudioRenderCategory_Media"]/*' />
    AudioRenderCategory_Media = 11,
}
