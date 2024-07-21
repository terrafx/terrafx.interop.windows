// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit"]/*' />
public enum TextRangeUnit
{
    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Character"]/*' />
    TextRangeUnit_Character = 0,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Word"]/*' />
    TextRangeUnit_Word = 1,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Sentence"]/*' />
    TextRangeUnit_Sentence = 2,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Paragraph"]/*' />
    TextRangeUnit_Paragraph = 3,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Line"]/*' />
    TextRangeUnit_Line = 4,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Story"]/*' />
    TextRangeUnit_Story = 5,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Screen"]/*' />
    TextRangeUnit_Screen = 6,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Section"]/*' />
    TextRangeUnit_Section = 7,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Window"]/*' />
    TextRangeUnit_Window = 8,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_CharacterFormat"]/*' />
    TextRangeUnit_CharacterFormat = 9,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_ParagraphFormat"]/*' />
    TextRangeUnit_ParagraphFormat = 10,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Object"]/*' />
    TextRangeUnit_Object = 11,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_HardParagraph"]/*' />
    TextRangeUnit_HardParagraph = 12,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Cluster"]/*' />
    TextRangeUnit_Cluster = 13,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Bold"]/*' />
    TextRangeUnit_Bold = 14,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Italic"]/*' />
    TextRangeUnit_Italic = 15,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Underline"]/*' />
    TextRangeUnit_Underline = 16,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Strikethrough"]/*' />
    TextRangeUnit_Strikethrough = 17,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_ProtectedText"]/*' />
    TextRangeUnit_ProtectedText = 18,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Link"]/*' />
    TextRangeUnit_Link = 19,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_SmallCaps"]/*' />
    TextRangeUnit_SmallCaps = 20,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_AllCaps"]/*' />
    TextRangeUnit_AllCaps = 21,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Hidden"]/*' />
    TextRangeUnit_Hidden = 22,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Outline"]/*' />
    TextRangeUnit_Outline = 23,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Shadow"]/*' />
    TextRangeUnit_Shadow = 24,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Imprint"]/*' />
    TextRangeUnit_Imprint = 25,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Disabled"]/*' />
    TextRangeUnit_Disabled = 26,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Revised"]/*' />
    TextRangeUnit_Revised = 27,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Subscript"]/*' />
    TextRangeUnit_Subscript = 28,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_Superscript"]/*' />
    TextRangeUnit_Superscript = 29,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_FontBound"]/*' />
    TextRangeUnit_FontBound = 30,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_LinkProtected"]/*' />
    TextRangeUnit_LinkProtected = 31,

    /// <include file='TextRangeUnit.xml' path='doc/member[@name="TextRangeUnit.TextRangeUnit_ContentLink"]/*' />
    TextRangeUnit_ContentLink = 32,
}
