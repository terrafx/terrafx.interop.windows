// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LanguageLayoutDirection.xml' path='doc/member[@name="LanguageLayoutDirection"]/*' />
public enum LanguageLayoutDirection
{
    /// <include file='LanguageLayoutDirection.xml' path='doc/member[@name="LanguageLayoutDirection.LanguageLayoutDirection_Ltr"]/*' />
    LanguageLayoutDirection_Ltr = 0,

    /// <include file='LanguageLayoutDirection.xml' path='doc/member[@name="LanguageLayoutDirection.LanguageLayoutDirection_Rtl"]/*' />
    LanguageLayoutDirection_Rtl = 1,

    /// <include file='LanguageLayoutDirection.xml' path='doc/member[@name="LanguageLayoutDirection.LanguageLayoutDirection_TtbLtr"]/*' />
    LanguageLayoutDirection_TtbLtr = 2,

    /// <include file='LanguageLayoutDirection.xml' path='doc/member[@name="LanguageLayoutDirection.LanguageLayoutDirection_TtbRtl"]/*' />
    LanguageLayoutDirection_TtbRtl = 3,
}
