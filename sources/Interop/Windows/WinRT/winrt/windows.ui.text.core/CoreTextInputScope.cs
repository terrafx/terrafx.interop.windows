// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope"]/*' />
public enum CoreTextInputScope
{
    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Default"]/*' />
    CoreTextInputScope_Default = 0,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Url"]/*' />
    CoreTextInputScope_Url = 1,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_FilePath"]/*' />
    CoreTextInputScope_FilePath = 2,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_FileName"]/*' />
    CoreTextInputScope_FileName = 3,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_EmailUserName"]/*' />
    CoreTextInputScope_EmailUserName = 4,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_EmailAddress"]/*' />
    CoreTextInputScope_EmailAddress = 5,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_UserName"]/*' />
    CoreTextInputScope_UserName = 6,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalFullName"]/*' />
    CoreTextInputScope_PersonalFullName = 7,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalNamePrefix"]/*' />
    CoreTextInputScope_PersonalNamePrefix = 8,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalGivenName"]/*' />
    CoreTextInputScope_PersonalGivenName = 9,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalMiddleName"]/*' />
    CoreTextInputScope_PersonalMiddleName = 10,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalSurname"]/*' />
    CoreTextInputScope_PersonalSurname = 11,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PersonalNameSuffix"]/*' />
    CoreTextInputScope_PersonalNameSuffix = 12,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Address"]/*' />
    CoreTextInputScope_Address = 13,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressPostalCode"]/*' />
    CoreTextInputScope_AddressPostalCode = 14,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressStreet"]/*' />
    CoreTextInputScope_AddressStreet = 15,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressStateOrProvince"]/*' />
    CoreTextInputScope_AddressStateOrProvince = 16,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressCity"]/*' />
    CoreTextInputScope_AddressCity = 17,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressCountryName"]/*' />
    CoreTextInputScope_AddressCountryName = 18,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AddressCountryShortName"]/*' />
    CoreTextInputScope_AddressCountryShortName = 19,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_CurrencyAmountAndSymbol"]/*' />
    CoreTextInputScope_CurrencyAmountAndSymbol = 20,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_CurrencyAmount"]/*' />
    CoreTextInputScope_CurrencyAmount = 21,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Date"]/*' />
    CoreTextInputScope_Date = 22,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_DateMonth"]/*' />
    CoreTextInputScope_DateMonth = 23,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_DateDay"]/*' />
    CoreTextInputScope_DateDay = 24,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_DateYear"]/*' />
    CoreTextInputScope_DateYear = 25,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_DateMonthName"]/*' />
    CoreTextInputScope_DateMonthName = 26,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_DateDayName"]/*' />
    CoreTextInputScope_DateDayName = 27,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Number"]/*' />
    CoreTextInputScope_Number = 29,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_SingleCharacter"]/*' />
    CoreTextInputScope_SingleCharacter = 30,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Password"]/*' />
    CoreTextInputScope_Password = 31,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TelephoneNumber"]/*' />
    CoreTextInputScope_TelephoneNumber = 32,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TelephoneCountryCode"]/*' />
    CoreTextInputScope_TelephoneCountryCode = 33,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TelephoneAreaCode"]/*' />
    CoreTextInputScope_TelephoneAreaCode = 34,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TelephoneLocalNumber"]/*' />
    CoreTextInputScope_TelephoneLocalNumber = 35,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Time"]/*' />
    CoreTextInputScope_Time = 36,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TimeHour"]/*' />
    CoreTextInputScope_TimeHour = 37,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_TimeMinuteOrSecond"]/*' />
    CoreTextInputScope_TimeMinuteOrSecond = 38,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_NumberFullWidth"]/*' />
    CoreTextInputScope_NumberFullWidth = 39,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AlphanumericHalfWidth"]/*' />
    CoreTextInputScope_AlphanumericHalfWidth = 40,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_AlphanumericFullWidth"]/*' />
    CoreTextInputScope_AlphanumericFullWidth = 41,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_CurrencyChinese"]/*' />
    CoreTextInputScope_CurrencyChinese = 42,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Bopomofo"]/*' />
    CoreTextInputScope_Bopomofo = 43,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Hiragana"]/*' />
    CoreTextInputScope_Hiragana = 44,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_KatakanaHalfWidth"]/*' />
    CoreTextInputScope_KatakanaHalfWidth = 45,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_KatakanaFullWidth"]/*' />
    CoreTextInputScope_KatakanaFullWidth = 46,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Hanja"]/*' />
    CoreTextInputScope_Hanja = 47,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_HangulHalfWidth"]/*' />
    CoreTextInputScope_HangulHalfWidth = 48,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_HangulFullWidth"]/*' />
    CoreTextInputScope_HangulFullWidth = 49,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Search"]/*' />
    CoreTextInputScope_Search = 50,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Formula"]/*' />
    CoreTextInputScope_Formula = 51,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_SearchIncremental"]/*' />
    CoreTextInputScope_SearchIncremental = 52,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_ChineseHalfWidth"]/*' />
    CoreTextInputScope_ChineseHalfWidth = 53,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_ChineseFullWidth"]/*' />
    CoreTextInputScope_ChineseFullWidth = 54,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_NativeScript"]/*' />
    CoreTextInputScope_NativeScript = 55,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Text"]/*' />
    CoreTextInputScope_Text = 57,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Chat"]/*' />
    CoreTextInputScope_Chat = 58,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_NameOrPhoneNumber"]/*' />
    CoreTextInputScope_NameOrPhoneNumber = 59,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_EmailUserNameOrAddress"]/*' />
    CoreTextInputScope_EmailUserNameOrAddress = 60,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Private"]/*' />
    CoreTextInputScope_Private = 61,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Maps"]/*' />
    CoreTextInputScope_Maps = 62,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PasswordNumeric"]/*' />
    CoreTextInputScope_PasswordNumeric = 63,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_FormulaNumber"]/*' />
    CoreTextInputScope_FormulaNumber = 67,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_ChatWithoutEmoji"]/*' />
    CoreTextInputScope_ChatWithoutEmoji = 68,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_Digits"]/*' />
    CoreTextInputScope_Digits = 28,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PinNumeric"]/*' />
    CoreTextInputScope_PinNumeric = 64,

    /// <include file='CoreTextInputScope.xml' path='doc/member[@name="CoreTextInputScope.CoreTextInputScope_PinAlphanumeric"]/*' />
    CoreTextInputScope_PinAlphanumeric = 65,
}
