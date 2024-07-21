// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioEffectState.xml' path='doc/member[@name="AudioEffectState"]/*' />
public enum AudioEffectState
{
    /// <include file='AudioEffectState.xml' path='doc/member[@name="AudioEffectState.AudioEffectState_Off"]/*' />
    AudioEffectState_Off = 0,

    /// <include file='AudioEffectState.xml' path='doc/member[@name="AudioEffectState.AudioEffectState_On"]/*' />
    AudioEffectState_On = 1,
}
