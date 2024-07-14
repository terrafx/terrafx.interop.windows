// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings"]/*' />
[NativeTypeName("unsigned int")]
public enum GestureSettings : uint
{
    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_None"]/*' />
    GestureSettings_None = 0,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_Tap"]/*' />
    GestureSettings_Tap = 0x1,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_DoubleTap"]/*' />
    GestureSettings_DoubleTap = 0x2,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_Hold"]/*' />
    GestureSettings_Hold = 0x4,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_HoldWithMouse"]/*' />
    GestureSettings_HoldWithMouse = 0x8,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_RightTap"]/*' />
    GestureSettings_RightTap = 0x10,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_Drag"]/*' />
    GestureSettings_Drag = 0x20,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationTranslateX"]/*' />
    GestureSettings_ManipulationTranslateX = 0x40,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationTranslateY"]/*' />
    GestureSettings_ManipulationTranslateY = 0x80,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationTranslateRailsX"]/*' />
    GestureSettings_ManipulationTranslateRailsX = 0x100,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationTranslateRailsY"]/*' />
    GestureSettings_ManipulationTranslateRailsY = 0x200,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationRotate"]/*' />
    GestureSettings_ManipulationRotate = 0x400,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationScale"]/*' />
    GestureSettings_ManipulationScale = 0x800,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationTranslateInertia"]/*' />
    GestureSettings_ManipulationTranslateInertia = 0x1000,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationRotateInertia"]/*' />
    GestureSettings_ManipulationRotateInertia = 0x2000,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationScaleInertia"]/*' />
    GestureSettings_ManipulationScaleInertia = 0x4000,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_CrossSlide"]/*' />
    GestureSettings_CrossSlide = 0x8000,

    /// <include file='GestureSettings.xml' path='doc/member[@name="GestureSettings.GestureSettings_ManipulationMultipleFingerPanning"]/*' />
    GestureSettings_ManipulationMultipleFingerPanning = 0x10000,
}
