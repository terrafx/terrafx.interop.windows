// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding"]/*' />
public enum PrintBinding
{
    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_Default"]/*' />
    PrintBinding_Default = 0,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_NotAvailable"]/*' />
    PrintBinding_NotAvailable = 1,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_PrinterCustom"]/*' />
    PrintBinding_PrinterCustom = 2,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_None"]/*' />
    PrintBinding_None = 3,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_Bale"]/*' />
    PrintBinding_Bale = 4,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_BindBottom"]/*' />
    PrintBinding_BindBottom = 5,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_BindLeft"]/*' />
    PrintBinding_BindLeft = 6,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_BindRight"]/*' />
    PrintBinding_BindRight = 7,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_BindTop"]/*' />
    PrintBinding_BindTop = 8,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_Booklet"]/*' />
    PrintBinding_Booklet = 9,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_EdgeStitchBottom"]/*' />
    PrintBinding_EdgeStitchBottom = 10,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_EdgeStitchLeft"]/*' />
    PrintBinding_EdgeStitchLeft = 11,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_EdgeStitchRight"]/*' />
    PrintBinding_EdgeStitchRight = 12,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_EdgeStitchTop"]/*' />
    PrintBinding_EdgeStitchTop = 13,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_Fold"]/*' />
    PrintBinding_Fold = 14,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_JogOffset"]/*' />
    PrintBinding_JogOffset = 15,

    /// <include file='PrintBinding.xml' path='doc/member[@name="PrintBinding.PrintBinding_Trim"]/*' />
    PrintBinding_Trim = 16,
}
