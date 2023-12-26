// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity"]/*' />
public enum RangeGravity
{
    /// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity.RangeGravity_UIBehavior"]/*' />
    RangeGravity_UIBehavior = 0,

    /// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity.RangeGravity_Backward"]/*' />
    RangeGravity_Backward = 1,

    /// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity.RangeGravity_Forward"]/*' />
    RangeGravity_Forward = 2,

    /// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity.RangeGravity_Inward"]/*' />
    RangeGravity_Inward = 3,

    /// <include file='RangeGravity.xml' path='doc/member[@name="RangeGravity.RangeGravity_Outward"]/*' />
    RangeGravity_Outward = 4,
}
