// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioGraphUnrecoverableError.xml' path='doc/member[@name="AudioGraphUnrecoverableError"]/*' />
public enum AudioGraphUnrecoverableError
{
    /// <include file='AudioGraphUnrecoverableError.xml' path='doc/member[@name="AudioGraphUnrecoverableError.AudioGraphUnrecoverableError_None"]/*' />
    AudioGraphUnrecoverableError_None = 0,

    /// <include file='AudioGraphUnrecoverableError.xml' path='doc/member[@name="AudioGraphUnrecoverableError.AudioGraphUnrecoverableError_AudioDeviceLost"]/*' />
    AudioGraphUnrecoverableError_AudioDeviceLost = 1,

    /// <include file='AudioGraphUnrecoverableError.xml' path='doc/member[@name="AudioGraphUnrecoverableError.AudioGraphUnrecoverableError_AudioSessionDisconnected"]/*' />
    AudioGraphUnrecoverableError_AudioSessionDisconnected = 2,

    /// <include file='AudioGraphUnrecoverableError.xml' path='doc/member[@name="AudioGraphUnrecoverableError.AudioGraphUnrecoverableError_UnknownFailure"]/*' />
    AudioGraphUnrecoverableError_UnknownFailure = 3,
}
