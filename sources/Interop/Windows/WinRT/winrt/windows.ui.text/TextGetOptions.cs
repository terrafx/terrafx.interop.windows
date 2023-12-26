// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum TextGetOptions : uint
{
    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_None"]/*' />
    TextGetOptions_None = 0,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_AdjustCrlf"]/*' />
    TextGetOptions_AdjustCrlf = 0x1,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_UseCrlf"]/*' />
    TextGetOptions_UseCrlf = 0x2,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_UseObjectText"]/*' />
    TextGetOptions_UseObjectText = 0x4,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_AllowFinalEop"]/*' />
    TextGetOptions_AllowFinalEop = 0x8,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_NoHidden"]/*' />
    TextGetOptions_NoHidden = 0x20,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_IncludeNumbering"]/*' />
    TextGetOptions_IncludeNumbering = 0x40,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_FormatRtf"]/*' />
    TextGetOptions_FormatRtf = 0x2000,

    /// <include file='TextGetOptions.xml' path='doc/member[@name="TextGetOptions.TextGetOptions_UseLf"]/*' />
    TextGetOptions_UseLf = 0x1000000,
}
