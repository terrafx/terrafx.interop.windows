// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters"]/*' />
[NativeTypeName("unsigned int")]
public enum CoreIndependentInputFilters : uint
{
    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_None"]/*' />
    CoreIndependentInputFilters_None = 0,

    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_MouseButton"]/*' />
    CoreIndependentInputFilters_MouseButton = 0x1,

    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_MouseWheel"]/*' />
    CoreIndependentInputFilters_MouseWheel = 0x2,

    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_MouseHover"]/*' />
    CoreIndependentInputFilters_MouseHover = 0x4,

    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_PenWithBarrel"]/*' />
    CoreIndependentInputFilters_PenWithBarrel = 0x8,

    /// <include file='CoreIndependentInputFilters.xml' path='doc/member[@name="CoreIndependentInputFilters.CoreIndependentInputFilters_PenInverted"]/*' />
    CoreIndependentInputFilters_PenInverted = 0x10,
}
