// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioPlaybackConnectionOpenResultStatus.xml' path='doc/member[@name="AudioPlaybackConnectionOpenResultStatus"]/*' />
public enum AudioPlaybackConnectionOpenResultStatus
{
    /// <include file='AudioPlaybackConnectionOpenResultStatus.xml' path='doc/member[@name="AudioPlaybackConnectionOpenResultStatus.AudioPlaybackConnectionOpenResultStatus_Success"]/*' />
    AudioPlaybackConnectionOpenResultStatus_Success = 0,

    /// <include file='AudioPlaybackConnectionOpenResultStatus.xml' path='doc/member[@name="AudioPlaybackConnectionOpenResultStatus.AudioPlaybackConnectionOpenResultStatus_RequestTimedOut"]/*' />
    AudioPlaybackConnectionOpenResultStatus_RequestTimedOut = 1,

    /// <include file='AudioPlaybackConnectionOpenResultStatus.xml' path='doc/member[@name="AudioPlaybackConnectionOpenResultStatus.AudioPlaybackConnectionOpenResultStatus_DeniedBySystem"]/*' />
    AudioPlaybackConnectionOpenResultStatus_DeniedBySystem = 2,

    /// <include file='AudioPlaybackConnectionOpenResultStatus.xml' path='doc/member[@name="AudioPlaybackConnectionOpenResultStatus.AudioPlaybackConnectionOpenResultStatus_UnknownFailure"]/*' />
    AudioPlaybackConnectionOpenResultStatus_UnknownFailure = 3,
}
