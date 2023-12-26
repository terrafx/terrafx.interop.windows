// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering"]/*' />
public enum PrintBordering
{
    /// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering.PrintBordering_Default"]/*' />
    PrintBordering_Default = 0,

    /// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering.PrintBordering_NotAvailable"]/*' />
    PrintBordering_NotAvailable = 1,

    /// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering.PrintBordering_PrinterCustom"]/*' />
    PrintBordering_PrinterCustom = 2,

    /// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering.PrintBordering_Bordered"]/*' />
    PrintBordering_Bordered = 3,

    /// <include file='PrintBordering.xml' path='doc/member[@name="PrintBordering.PrintBordering_Borderless"]/*' />
    PrintBordering_Borderless = 4,
}
