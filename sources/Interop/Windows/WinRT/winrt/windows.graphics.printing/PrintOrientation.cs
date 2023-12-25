// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation"]/*' />
public enum PrintOrientation
{
    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_Default"]/*' />
    PrintOrientation_Default = 0,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_NotAvailable"]/*' />
    PrintOrientation_NotAvailable = 1,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_PrinterCustom"]/*' />
    PrintOrientation_PrinterCustom = 2,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_Portrait"]/*' />
    PrintOrientation_Portrait = 3,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_PortraitFlipped"]/*' />
    PrintOrientation_PortraitFlipped = 4,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_Landscape"]/*' />
    PrintOrientation_Landscape = 5,

    /// <include file='PrintOrientation.xml' path='doc/member[@name="PrintOrientation.PrintOrientation_LandscapeFlipped"]/*' />
    PrintOrientation_LandscapeFlipped = 6,
}
