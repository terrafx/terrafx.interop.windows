// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AnimationStopBehavior.xml' path='doc/member[@name="AnimationStopBehavior"]/*' />
public enum AnimationStopBehavior
{
    /// <include file='AnimationStopBehavior.xml' path='doc/member[@name="AnimationStopBehavior.AnimationStopBehavior_LeaveCurrentValue"]/*' />
    AnimationStopBehavior_LeaveCurrentValue = 0,

    /// <include file='AnimationStopBehavior.xml' path='doc/member[@name="AnimationStopBehavior.AnimationStopBehavior_SetToInitialValue"]/*' />
    AnimationStopBehavior_SetToInitialValue = 1,

    /// <include file='AnimationStopBehavior.xml' path='doc/member[@name="AnimationStopBehavior.AnimationStopBehavior_SetToFinalValue"]/*' />
    AnimationStopBehavior_SetToFinalValue = 2,
}
