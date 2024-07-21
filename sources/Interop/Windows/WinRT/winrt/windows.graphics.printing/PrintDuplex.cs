// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex"]/*' />
public enum PrintDuplex
{
    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_Default"]/*' />
    PrintDuplex_Default = 0,

    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_NotAvailable"]/*' />
    PrintDuplex_NotAvailable = 1,

    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_PrinterCustom"]/*' />
    PrintDuplex_PrinterCustom = 2,

    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_OneSided"]/*' />
    PrintDuplex_OneSided = 3,

    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_TwoSidedShortEdge"]/*' />
    PrintDuplex_TwoSidedShortEdge = 4,

    /// <include file='PrintDuplex.xml' path='doc/member[@name="PrintDuplex.PrintDuplex_TwoSidedLongEdge"]/*' />
    PrintDuplex_TwoSidedLongEdge = 5,
}
