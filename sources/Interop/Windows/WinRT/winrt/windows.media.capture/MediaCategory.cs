// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory"]/*' />
public enum MediaCategory
{
    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_Other"]/*' />
    MediaCategory_Other = 0,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_Communications"]/*' />
    MediaCategory_Communications = 1,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_Media"]/*' />
    MediaCategory_Media = 2,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_GameChat"]/*' />
    MediaCategory_GameChat = 3,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_Speech"]/*' />
    MediaCategory_Speech = 4,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_FarFieldSpeech"]/*' />
    MediaCategory_FarFieldSpeech = 5,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_UniformSpeech"]/*' />
    MediaCategory_UniformSpeech = 6,

    /// <include file='MediaCategory.xml' path='doc/member[@name="MediaCategory.MediaCategory_VoiceTyping"]/*' />
    MediaCategory_VoiceTyping = 7,
}
