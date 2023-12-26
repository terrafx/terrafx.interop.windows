// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FailedMediaStreamKind.xml' path='doc/member[@name="FailedMediaStreamKind"]/*' />
public enum FailedMediaStreamKind
{
    /// <include file='FailedMediaStreamKind.xml' path='doc/member[@name="FailedMediaStreamKind.FailedMediaStreamKind_Unknown"]/*' />
    FailedMediaStreamKind_Unknown = 0,

    /// <include file='FailedMediaStreamKind.xml' path='doc/member[@name="FailedMediaStreamKind.FailedMediaStreamKind_Audio"]/*' />
    FailedMediaStreamKind_Audio = 1,

    /// <include file='FailedMediaStreamKind.xml' path='doc/member[@name="FailedMediaStreamKind.FailedMediaStreamKind_Video"]/*' />
    FailedMediaStreamKind_Video = 2,
}
