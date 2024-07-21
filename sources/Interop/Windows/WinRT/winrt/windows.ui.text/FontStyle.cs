// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FontStyle.xml' path='doc/member[@name="FontStyle"]/*' />
public enum FontStyle
{
    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyle_Normal"]/*' />
    FontStyle_Normal = 0,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyle_Oblique"]/*' />
    FontStyle_Oblique = 1,

    /// <include file='FontStyle.xml' path='doc/member[@name="FontStyle.FontStyle_Italic"]/*' />
    FontStyle_Italic = 2,
}
