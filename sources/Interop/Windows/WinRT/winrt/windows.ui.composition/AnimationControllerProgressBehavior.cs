// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AnimationControllerProgressBehavior.xml' path='doc/member[@name="AnimationControllerProgressBehavior"]/*' />
public enum AnimationControllerProgressBehavior
{
    /// <include file='AnimationControllerProgressBehavior.xml' path='doc/member[@name="AnimationControllerProgressBehavior.AnimationControllerProgressBehavior_Default"]/*' />
    AnimationControllerProgressBehavior_Default = 0,

    /// <include file='AnimationControllerProgressBehavior.xml' path='doc/member[@name="AnimationControllerProgressBehavior.AnimationControllerProgressBehavior_IncludesDelayTime"]/*' />
    AnimationControllerProgressBehavior_IncludesDelayTime = 1,
}
