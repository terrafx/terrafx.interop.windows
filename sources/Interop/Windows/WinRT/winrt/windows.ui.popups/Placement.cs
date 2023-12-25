// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Placement.xml' path='doc/member[@name="Placement"]/*' />
public enum Placement
{
    /// <include file='Placement.xml' path='doc/member[@name="Placement.Placement_Default"]/*' />
    Placement_Default = 0,

    /// <include file='Placement.xml' path='doc/member[@name="Placement.Placement_Above"]/*' />
    Placement_Above = 1,

    /// <include file='Placement.xml' path='doc/member[@name="Placement.Placement_Below"]/*' />
    Placement_Below = 2,

    /// <include file='Placement.xml' path='doc/member[@name="Placement.Placement_Left"]/*' />
    Placement_Left = 3,

    /// <include file='Placement.xml' path='doc/member[@name="Placement.Placement_Right"]/*' />
    Placement_Right = 4,
}
