// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality"]/*' />
public enum PrintQuality
{
    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Default"]/*' />
    PrintQuality_Default = 0,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_NotAvailable"]/*' />
    PrintQuality_NotAvailable = 1,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_PrinterCustom"]/*' />
    PrintQuality_PrinterCustom = 2,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Automatic"]/*' />
    PrintQuality_Automatic = 3,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Draft"]/*' />
    PrintQuality_Draft = 4,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Fax"]/*' />
    PrintQuality_Fax = 5,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_High"]/*' />
    PrintQuality_High = 6,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Normal"]/*' />
    PrintQuality_Normal = 7,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Photographic"]/*' />
    PrintQuality_Photographic = 8,

    /// <include file='PrintQuality.xml' path='doc/member[@name="PrintQuality.PrintQuality_Text"]/*' />
    PrintQuality_Text = 9,
}
