// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioNodeEmitterShapeKind.xml' path='doc/member[@name="AudioNodeEmitterShapeKind"]/*' />
public enum AudioNodeEmitterShapeKind
{
    /// <include file='AudioNodeEmitterShapeKind.xml' path='doc/member[@name="AudioNodeEmitterShapeKind.AudioNodeEmitterShapeKind_Omnidirectional"]/*' />
    AudioNodeEmitterShapeKind_Omnidirectional = 0,

    /// <include file='AudioNodeEmitterShapeKind.xml' path='doc/member[@name="AudioNodeEmitterShapeKind.AudioNodeEmitterShapeKind_Cone"]/*' />
    AudioNodeEmitterShapeKind_Cone = 1,
}
