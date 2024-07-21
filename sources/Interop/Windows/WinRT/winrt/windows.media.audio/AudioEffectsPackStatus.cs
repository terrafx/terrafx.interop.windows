// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioEffectsPackStatus.xml' path='doc/member[@name="AudioEffectsPackStatus"]/*' />
public enum AudioEffectsPackStatus
{
    /// <include file='AudioEffectsPackStatus.xml' path='doc/member[@name="AudioEffectsPackStatus.AudioEffectsPackStatus_NotEnabled"]/*' />
    AudioEffectsPackStatus_NotEnabled = 0,

    /// <include file='AudioEffectsPackStatus.xml' path='doc/member[@name="AudioEffectsPackStatus.AudioEffectsPackStatus_Enabled"]/*' />
    AudioEffectsPackStatus_Enabled = 1,

    /// <include file='AudioEffectsPackStatus.xml' path='doc/member[@name="AudioEffectsPackStatus.AudioEffectsPackStatus_NotSupported"]/*' />
    AudioEffectsPackStatus_NotSupported = 2,
}
