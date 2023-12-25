// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory"]/*' />
public enum UnicodeGeneralCategory
{
    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_UppercaseLetter"]/*' />
    UnicodeGeneralCategory_UppercaseLetter = 0,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_LowercaseLetter"]/*' />
    UnicodeGeneralCategory_LowercaseLetter = 1,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_TitlecaseLetter"]/*' />
    UnicodeGeneralCategory_TitlecaseLetter = 2,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_ModifierLetter"]/*' />
    UnicodeGeneralCategory_ModifierLetter = 3,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_OtherLetter"]/*' />
    UnicodeGeneralCategory_OtherLetter = 4,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_NonspacingMark"]/*' />
    UnicodeGeneralCategory_NonspacingMark = 5,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_SpacingCombiningMark"]/*' />
    UnicodeGeneralCategory_SpacingCombiningMark = 6,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_EnclosingMark"]/*' />
    UnicodeGeneralCategory_EnclosingMark = 7,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_DecimalDigitNumber"]/*' />
    UnicodeGeneralCategory_DecimalDigitNumber = 8,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_LetterNumber"]/*' />
    UnicodeGeneralCategory_LetterNumber = 9,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_OtherNumber"]/*' />
    UnicodeGeneralCategory_OtherNumber = 10,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_SpaceSeparator"]/*' />
    UnicodeGeneralCategory_SpaceSeparator = 11,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_LineSeparator"]/*' />
    UnicodeGeneralCategory_LineSeparator = 12,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_ParagraphSeparator"]/*' />
    UnicodeGeneralCategory_ParagraphSeparator = 13,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_Control"]/*' />
    UnicodeGeneralCategory_Control = 14,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_Format"]/*' />
    UnicodeGeneralCategory_Format = 15,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_Surrogate"]/*' />
    UnicodeGeneralCategory_Surrogate = 16,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_PrivateUse"]/*' />
    UnicodeGeneralCategory_PrivateUse = 17,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_ConnectorPunctuation"]/*' />
    UnicodeGeneralCategory_ConnectorPunctuation = 18,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_DashPunctuation"]/*' />
    UnicodeGeneralCategory_DashPunctuation = 19,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_OpenPunctuation"]/*' />
    UnicodeGeneralCategory_OpenPunctuation = 20,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_ClosePunctuation"]/*' />
    UnicodeGeneralCategory_ClosePunctuation = 21,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_InitialQuotePunctuation"]/*' />
    UnicodeGeneralCategory_InitialQuotePunctuation = 22,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_FinalQuotePunctuation"]/*' />
    UnicodeGeneralCategory_FinalQuotePunctuation = 23,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_OtherPunctuation"]/*' />
    UnicodeGeneralCategory_OtherPunctuation = 24,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_MathSymbol"]/*' />
    UnicodeGeneralCategory_MathSymbol = 25,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_CurrencySymbol"]/*' />
    UnicodeGeneralCategory_CurrencySymbol = 26,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_ModifierSymbol"]/*' />
    UnicodeGeneralCategory_ModifierSymbol = 27,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_OtherSymbol"]/*' />
    UnicodeGeneralCategory_OtherSymbol = 28,

    /// <include file='UnicodeGeneralCategory.xml' path='doc/member[@name="UnicodeGeneralCategory.UnicodeGeneralCategory_NotAssigned"]/*' />
    UnicodeGeneralCategory_NotAssigned = 29,
}
