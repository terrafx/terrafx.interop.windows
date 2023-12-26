// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AnimationDelayBehavior.xml' path='doc/member[@name="AnimationDelayBehavior"]/*' />
public enum AnimationDelayBehavior
{
    /// <include file='AnimationDelayBehavior.xml' path='doc/member[@name="AnimationDelayBehavior.AnimationDelayBehavior_SetInitialValueAfterDelay"]/*' />
    AnimationDelayBehavior_SetInitialValueAfterDelay = 0,

    /// <include file='AnimationDelayBehavior.xml' path='doc/member[@name="AnimationDelayBehavior.AnimationDelayBehavior_SetInitialValueBeforeDelay"]/*' />
    AnimationDelayBehavior_SetInitialValueBeforeDelay = 1,
}
