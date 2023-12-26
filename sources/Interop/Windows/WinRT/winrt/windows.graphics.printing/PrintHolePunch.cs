// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch"]/*' />
public enum PrintHolePunch
{
    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_Default"]/*' />
    PrintHolePunch_Default = 0,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_NotAvailable"]/*' />
    PrintHolePunch_NotAvailable = 1,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_PrinterCustom"]/*' />
    PrintHolePunch_PrinterCustom = 2,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_None"]/*' />
    PrintHolePunch_None = 3,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_LeftEdge"]/*' />
    PrintHolePunch_LeftEdge = 4,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_RightEdge"]/*' />
    PrintHolePunch_RightEdge = 5,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_TopEdge"]/*' />
    PrintHolePunch_TopEdge = 6,

    /// <include file='PrintHolePunch.xml' path='doc/member[@name="PrintHolePunch.PrintHolePunch_BottomEdge"]/*' />
    PrintHolePunch_BottomEdge = 7,
}
