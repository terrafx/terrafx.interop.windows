// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioNodeEmitterSettings.xml' path='doc/member[@name="AudioNodeEmitterSettings"]/*' />
[NativeTypeName("unsigned int")]
public enum AudioNodeEmitterSettings : uint
{
    /// <include file='AudioNodeEmitterSettings.xml' path='doc/member[@name="AudioNodeEmitterSettings.AudioNodeEmitterSettings_None"]/*' />
    AudioNodeEmitterSettings_None = 0,

    /// <include file='AudioNodeEmitterSettings.xml' path='doc/member[@name="AudioNodeEmitterSettings.AudioNodeEmitterSettings_DisableDoppler"]/*' />
    AudioNodeEmitterSettings_DisableDoppler = 0x1,
}
