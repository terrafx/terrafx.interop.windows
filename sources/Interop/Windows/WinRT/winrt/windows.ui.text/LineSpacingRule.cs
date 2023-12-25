// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule"]/*' />
public enum LineSpacingRule
{
    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Undefined"]/*' />
    LineSpacingRule_Undefined = 0,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Single"]/*' />
    LineSpacingRule_Single = 1,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_OneAndHalf"]/*' />
    LineSpacingRule_OneAndHalf = 2,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Double"]/*' />
    LineSpacingRule_Double = 3,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_AtLeast"]/*' />
    LineSpacingRule_AtLeast = 4,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Exactly"]/*' />
    LineSpacingRule_Exactly = 5,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Multiple"]/*' />
    LineSpacingRule_Multiple = 6,

    /// <include file='LineSpacingRule.xml' path='doc/member[@name="LineSpacingRule.LineSpacingRule_Percent"]/*' />
    LineSpacingRule_Percent = 7,
}
