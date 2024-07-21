// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextFontStyle.xml' path='doc/member[@name="TimedTextFontStyle"]/*' />
public enum TimedTextFontStyle
{
    /// <include file='TimedTextFontStyle.xml' path='doc/member[@name="TimedTextFontStyle.TimedTextFontStyle_Normal"]/*' />
    TimedTextFontStyle_Normal = 0,

    /// <include file='TimedTextFontStyle.xml' path='doc/member[@name="TimedTextFontStyle.TimedTextFontStyle_Oblique"]/*' />
    TimedTextFontStyle_Oblique = 1,

    /// <include file='TimedTextFontStyle.xml' path='doc/member[@name="TimedTextFontStyle.TimedTextFontStyle_Italic"]/*' />
    TimedTextFontStyle_Italic = 2,
}
