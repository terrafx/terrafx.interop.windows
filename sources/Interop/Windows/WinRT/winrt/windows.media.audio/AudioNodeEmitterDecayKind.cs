// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioNodeEmitterDecayKind.xml' path='doc/member[@name="AudioNodeEmitterDecayKind"]/*' />
public enum AudioNodeEmitterDecayKind
{
    /// <include file='AudioNodeEmitterDecayKind.xml' path='doc/member[@name="AudioNodeEmitterDecayKind.AudioNodeEmitterDecayKind_Natural"]/*' />
    AudioNodeEmitterDecayKind_Natural = 0,

    /// <include file='AudioNodeEmitterDecayKind.xml' path='doc/member[@name="AudioNodeEmitterDecayKind.AudioNodeEmitterDecayKind_Custom"]/*' />
    AudioNodeEmitterDecayKind_Custom = 1,
}
