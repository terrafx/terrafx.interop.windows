// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum TextSetOptions : uint
{
    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_None"]/*' />
    TextSetOptions_None = 0,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_UnicodeBidi"]/*' />
    TextSetOptions_UnicodeBidi = 0x1,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_Unlink"]/*' />
    TextSetOptions_Unlink = 0x8,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_Unhide"]/*' />
    TextSetOptions_Unhide = 0x10,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_CheckTextLimit"]/*' />
    TextSetOptions_CheckTextLimit = 0x20,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_FormatRtf"]/*' />
    TextSetOptions_FormatRtf = 0x2000,

    /// <include file='TextSetOptions.xml' path='doc/member[@name="TextSetOptions.TextSetOptions_ApplyRtfDocumentDefaults"]/*' />
    TextSetOptions_ApplyRtfDocumentDefaults = 0x4000,
}
