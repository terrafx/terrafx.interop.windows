// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode"]/*' />
public enum PrintColorMode
{
    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_Default"]/*' />
    PrintColorMode_Default = 0,

    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_NotAvailable"]/*' />
    PrintColorMode_NotAvailable = 1,

    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_PrinterCustom"]/*' />
    PrintColorMode_PrinterCustom = 2,

    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_Color"]/*' />
    PrintColorMode_Color = 3,

    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_Grayscale"]/*' />
    PrintColorMode_Grayscale = 4,

    /// <include file='PrintColorMode.xml' path='doc/member[@name="PrintColorMode.PrintColorMode_Monochrome"]/*' />
    PrintColorMode_Monochrome = 5,
}
