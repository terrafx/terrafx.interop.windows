// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextScript.xml' path='doc/member[@name="TextScript"]/*' />
public enum TextScript
{
    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Undefined"]/*' />
    TextScript_Undefined = 0,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Ansi"]/*' />
    TextScript_Ansi = 1,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_EastEurope"]/*' />
    TextScript_EastEurope = 2,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Cyrillic"]/*' />
    TextScript_Cyrillic = 3,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Greek"]/*' />
    TextScript_Greek = 4,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Turkish"]/*' />
    TextScript_Turkish = 5,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Hebrew"]/*' />
    TextScript_Hebrew = 6,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Arabic"]/*' />
    TextScript_Arabic = 7,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Baltic"]/*' />
    TextScript_Baltic = 8,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Vietnamese"]/*' />
    TextScript_Vietnamese = 9,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Default"]/*' />
    TextScript_Default = 10,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Symbol"]/*' />
    TextScript_Symbol = 11,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Thai"]/*' />
    TextScript_Thai = 12,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_ShiftJis"]/*' />
    TextScript_ShiftJis = 13,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_GB2312"]/*' />
    TextScript_GB2312 = 14,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Hangul"]/*' />
    TextScript_Hangul = 15,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Big5"]/*' />
    TextScript_Big5 = 16,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_PC437"]/*' />
    TextScript_PC437 = 17,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Oem"]/*' />
    TextScript_Oem = 18,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Mac"]/*' />
    TextScript_Mac = 19,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Armenian"]/*' />
    TextScript_Armenian = 20,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Syriac"]/*' />
    TextScript_Syriac = 21,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Thaana"]/*' />
    TextScript_Thaana = 22,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Devanagari"]/*' />
    TextScript_Devanagari = 23,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Bengali"]/*' />
    TextScript_Bengali = 24,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Gurmukhi"]/*' />
    TextScript_Gurmukhi = 25,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Gujarati"]/*' />
    TextScript_Gujarati = 26,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Oriya"]/*' />
    TextScript_Oriya = 27,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Tamil"]/*' />
    TextScript_Tamil = 28,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Telugu"]/*' />
    TextScript_Telugu = 29,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Kannada"]/*' />
    TextScript_Kannada = 30,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Malayalam"]/*' />
    TextScript_Malayalam = 31,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Sinhala"]/*' />
    TextScript_Sinhala = 32,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Lao"]/*' />
    TextScript_Lao = 33,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Tibetan"]/*' />
    TextScript_Tibetan = 34,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Myanmar"]/*' />
    TextScript_Myanmar = 35,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Georgian"]/*' />
    TextScript_Georgian = 36,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Jamo"]/*' />
    TextScript_Jamo = 37,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Ethiopic"]/*' />
    TextScript_Ethiopic = 38,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Cherokee"]/*' />
    TextScript_Cherokee = 39,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Aboriginal"]/*' />
    TextScript_Aboriginal = 40,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Ogham"]/*' />
    TextScript_Ogham = 41,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Runic"]/*' />
    TextScript_Runic = 42,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Khmer"]/*' />
    TextScript_Khmer = 43,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Mongolian"]/*' />
    TextScript_Mongolian = 44,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Braille"]/*' />
    TextScript_Braille = 45,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Yi"]/*' />
    TextScript_Yi = 46,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Limbu"]/*' />
    TextScript_Limbu = 47,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_TaiLe"]/*' />
    TextScript_TaiLe = 48,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_NewTaiLue"]/*' />
    TextScript_NewTaiLue = 49,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_SylotiNagri"]/*' />
    TextScript_SylotiNagri = 50,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Kharoshthi"]/*' />
    TextScript_Kharoshthi = 51,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Kayahli"]/*' />
    TextScript_Kayahli = 52,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_UnicodeSymbol"]/*' />
    TextScript_UnicodeSymbol = 53,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Emoji"]/*' />
    TextScript_Emoji = 54,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Glagolitic"]/*' />
    TextScript_Glagolitic = 55,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Lisu"]/*' />
    TextScript_Lisu = 56,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Vai"]/*' />
    TextScript_Vai = 57,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_NKo"]/*' />
    TextScript_NKo = 58,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Osmanya"]/*' />
    TextScript_Osmanya = 59,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_PhagsPa"]/*' />
    TextScript_PhagsPa = 60,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Gothic"]/*' />
    TextScript_Gothic = 61,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Deseret"]/*' />
    TextScript_Deseret = 62,

    /// <include file='TextScript.xml' path='doc/member[@name="TextScript.TextScript_Tifinagh"]/*' />
    TextScript_Tifinagh = 63,
}
