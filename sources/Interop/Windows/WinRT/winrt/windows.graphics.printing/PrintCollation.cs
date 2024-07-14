// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation"]/*' />
public enum PrintCollation
{
    /// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation.PrintCollation_Default"]/*' />
    PrintCollation_Default = 0,

    /// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation.PrintCollation_NotAvailable"]/*' />
    PrintCollation_NotAvailable = 1,

    /// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation.PrintCollation_PrinterCustom"]/*' />
    PrintCollation_PrinterCustom = 2,

    /// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation.PrintCollation_Collated"]/*' />
    PrintCollation_Collated = 3,

    /// <include file='PrintCollation.xml' path='doc/member[@name="PrintCollation.PrintCollation_Uncollated"]/*' />
    PrintCollation_Uncollated = 4,
}
