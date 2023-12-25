// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AnimationDirection.xml' path='doc/member[@name="AnimationDirection"]/*' />
public enum AnimationDirection
{
    /// <include file='AnimationDirection.xml' path='doc/member[@name="AnimationDirection.AnimationDirection_Normal"]/*' />
    AnimationDirection_Normal = 0,

    /// <include file='AnimationDirection.xml' path='doc/member[@name="AnimationDirection.AnimationDirection_Reverse"]/*' />
    AnimationDirection_Reverse = 1,

    /// <include file='AnimationDirection.xml' path='doc/member[@name="AnimationDirection.AnimationDirection_Alternate"]/*' />
    AnimationDirection_Alternate = 2,

    /// <include file='AnimationDirection.xml' path='doc/member[@name="AnimationDirection.AnimationDirection_AlternateReverse"]/*' />
    AnimationDirection_AlternateReverse = 3,
}
