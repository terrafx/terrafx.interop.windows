// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle"]/*' />
public enum MarkerStyle
{
    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Undefined"]/*' />
    MarkerStyle_Undefined = 0,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Parenthesis"]/*' />
    MarkerStyle_Parenthesis = 1,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Parentheses"]/*' />
    MarkerStyle_Parentheses = 2,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Period"]/*' />
    MarkerStyle_Period = 3,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Plain"]/*' />
    MarkerStyle_Plain = 4,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_Minus"]/*' />
    MarkerStyle_Minus = 5,

    /// <include file='MarkerStyle.xml' path='doc/member[@name="MarkerStyle.MarkerStyle_NoNumber"]/*' />
    MarkerStyle_NoNumber = 6,
}
