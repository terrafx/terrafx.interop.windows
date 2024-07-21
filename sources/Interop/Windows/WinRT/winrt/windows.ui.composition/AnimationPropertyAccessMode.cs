// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AnimationPropertyAccessMode.xml' path='doc/member[@name="AnimationPropertyAccessMode"]/*' />
public enum AnimationPropertyAccessMode
{
    /// <include file='AnimationPropertyAccessMode.xml' path='doc/member[@name="AnimationPropertyAccessMode.AnimationPropertyAccessMode_None"]/*' />
    AnimationPropertyAccessMode_None = 0,

    /// <include file='AnimationPropertyAccessMode.xml' path='doc/member[@name="AnimationPropertyAccessMode.AnimationPropertyAccessMode_ReadOnly"]/*' />
    AnimationPropertyAccessMode_ReadOnly = 1,

    /// <include file='AnimationPropertyAccessMode.xml' path='doc/member[@name="AnimationPropertyAccessMode.AnimationPropertyAccessMode_WriteOnly"]/*' />
    AnimationPropertyAccessMode_WriteOnly = 2,

    /// <include file='AnimationPropertyAccessMode.xml' path='doc/member[@name="AnimationPropertyAccessMode.AnimationPropertyAccessMode_ReadWrite"]/*' />
    AnimationPropertyAccessMode_ReadWrite = 3,
}
