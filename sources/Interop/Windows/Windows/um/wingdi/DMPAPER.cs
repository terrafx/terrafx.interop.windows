// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DMPAPER
{
    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_FIRST"]/*' />
    [NativeTypeName("#define DMPAPER_FIRST DMPAPER_LETTER")]
    public const int DMPAPER_FIRST = 1;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER 1")]
    public const int DMPAPER_LETTER = 1;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTERSMALL"]/*' />
    [NativeTypeName("#define DMPAPER_LETTERSMALL 2")]
    public const int DMPAPER_LETTERSMALL = 2;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_TABLOID"]/*' />
    [NativeTypeName("#define DMPAPER_TABLOID 3")]
    public const int DMPAPER_TABLOID = 3;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LEDGER"]/*' />
    [NativeTypeName("#define DMPAPER_LEDGER 4")]
    public const int DMPAPER_LEDGER = 4;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LEGAL"]/*' />
    [NativeTypeName("#define DMPAPER_LEGAL 5")]
    public const int DMPAPER_LEGAL = 5;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_STATEMENT"]/*' />
    [NativeTypeName("#define DMPAPER_STATEMENT 6")]
    public const int DMPAPER_STATEMENT = 6;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_EXECUTIVE"]/*' />
    [NativeTypeName("#define DMPAPER_EXECUTIVE 7")]
    public const int DMPAPER_EXECUTIVE = 7;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A3"]/*' />
    [NativeTypeName("#define DMPAPER_A3 8")]
    public const int DMPAPER_A3 = 8;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4"]/*' />
    [NativeTypeName("#define DMPAPER_A4 9")]
    public const int DMPAPER_A4 = 9;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4SMALL"]/*' />
    [NativeTypeName("#define DMPAPER_A4SMALL 10")]
    public const int DMPAPER_A4SMALL = 10;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A5"]/*' />
    [NativeTypeName("#define DMPAPER_A5 11")]
    public const int DMPAPER_A5 = 11;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B4"]/*' />
    [NativeTypeName("#define DMPAPER_B4 12")]
    public const int DMPAPER_B4 = 12;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B5"]/*' />
    [NativeTypeName("#define DMPAPER_B5 13")]
    public const int DMPAPER_B5 = 13;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_FOLIO"]/*' />
    [NativeTypeName("#define DMPAPER_FOLIO 14")]
    public const int DMPAPER_FOLIO = 14;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_QUARTO"]/*' />
    [NativeTypeName("#define DMPAPER_QUARTO 15")]
    public const int DMPAPER_QUARTO = 15;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_10X14"]/*' />
    [NativeTypeName("#define DMPAPER_10X14 16")]
    public const int DMPAPER_10X14 = 16;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_11X17"]/*' />
    [NativeTypeName("#define DMPAPER_11X17 17")]
    public const int DMPAPER_11X17 = 17;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_NOTE"]/*' />
    [NativeTypeName("#define DMPAPER_NOTE 18")]
    public const int DMPAPER_NOTE = 18;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_9"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_9 19")]
    public const int DMPAPER_ENV_9 = 19;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_10"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_10 20")]
    public const int DMPAPER_ENV_10 = 20;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_11"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_11 21")]
    public const int DMPAPER_ENV_11 = 21;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_12"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_12 22")]
    public const int DMPAPER_ENV_12 = 22;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_14"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_14 23")]
    public const int DMPAPER_ENV_14 = 23;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_CSHEET"]/*' />
    [NativeTypeName("#define DMPAPER_CSHEET 24")]
    public const int DMPAPER_CSHEET = 24;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_DSHEET"]/*' />
    [NativeTypeName("#define DMPAPER_DSHEET 25")]
    public const int DMPAPER_DSHEET = 25;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ESHEET"]/*' />
    [NativeTypeName("#define DMPAPER_ESHEET 26")]
    public const int DMPAPER_ESHEET = 26;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_DL"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_DL 27")]
    public const int DMPAPER_ENV_DL = 27;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_C5"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_C5 28")]
    public const int DMPAPER_ENV_C5 = 28;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_C3"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_C3 29")]
    public const int DMPAPER_ENV_C3 = 29;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_C4"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_C4 30")]
    public const int DMPAPER_ENV_C4 = 30;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_C6"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_C6 31")]
    public const int DMPAPER_ENV_C6 = 31;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_C65"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_C65 32")]
    public const int DMPAPER_ENV_C65 = 32;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_B4"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_B4 33")]
    public const int DMPAPER_ENV_B4 = 33;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_B5"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_B5 34")]
    public const int DMPAPER_ENV_B5 = 34;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_B6"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_B6 35")]
    public const int DMPAPER_ENV_B6 = 35;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_ITALY"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_ITALY 36")]
    public const int DMPAPER_ENV_ITALY = 36;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_MONARCH"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_MONARCH 37")]
    public const int DMPAPER_ENV_MONARCH = 37;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_PERSONAL"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_PERSONAL 38")]
    public const int DMPAPER_ENV_PERSONAL = 38;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_FANFOLD_US"]/*' />
    [NativeTypeName("#define DMPAPER_FANFOLD_US 39")]
    public const int DMPAPER_FANFOLD_US = 39;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_FANFOLD_STD_GERMAN"]/*' />
    [NativeTypeName("#define DMPAPER_FANFOLD_STD_GERMAN 40")]
    public const int DMPAPER_FANFOLD_STD_GERMAN = 40;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_FANFOLD_LGL_GERMAN"]/*' />
    [NativeTypeName("#define DMPAPER_FANFOLD_LGL_GERMAN 41")]
    public const int DMPAPER_FANFOLD_LGL_GERMAN = 41;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ISO_B4"]/*' />
    [NativeTypeName("#define DMPAPER_ISO_B4 42")]
    public const int DMPAPER_ISO_B4 = 42;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JAPANESE_POSTCARD"]/*' />
    [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD 43")]
    public const int DMPAPER_JAPANESE_POSTCARD = 43;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_9X11"]/*' />
    [NativeTypeName("#define DMPAPER_9X11 44")]
    public const int DMPAPER_9X11 = 44;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_10X11"]/*' />
    [NativeTypeName("#define DMPAPER_10X11 45")]
    public const int DMPAPER_10X11 = 45;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_15X11"]/*' />
    [NativeTypeName("#define DMPAPER_15X11 46")]
    public const int DMPAPER_15X11 = 46;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_ENV_INVITE"]/*' />
    [NativeTypeName("#define DMPAPER_ENV_INVITE 47")]
    public const int DMPAPER_ENV_INVITE = 47;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_RESERVED_48"]/*' />
    [NativeTypeName("#define DMPAPER_RESERVED_48 48")]
    public const int DMPAPER_RESERVED_48 = 48;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_RESERVED_49"]/*' />
    [NativeTypeName("#define DMPAPER_RESERVED_49 49")]
    public const int DMPAPER_RESERVED_49 = 49;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER_EXTRA 50")]
    public const int DMPAPER_LETTER_EXTRA = 50;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LEGAL_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_LEGAL_EXTRA 51")]
    public const int DMPAPER_LEGAL_EXTRA = 51;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_TABLOID_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_TABLOID_EXTRA 52")]
    public const int DMPAPER_TABLOID_EXTRA = 52;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_A4_EXTRA 53")]
    public const int DMPAPER_A4_EXTRA = 53;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER_TRANSVERSE 54")]
    public const int DMPAPER_LETTER_TRANSVERSE = 54;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_A4_TRANSVERSE 55")]
    public const int DMPAPER_A4_TRANSVERSE = 55;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER_EXTRA_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER_EXTRA_TRANSVERSE 56")]
    public const int DMPAPER_LETTER_EXTRA_TRANSVERSE = 56;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A_PLUS"]/*' />
    [NativeTypeName("#define DMPAPER_A_PLUS 57")]
    public const int DMPAPER_A_PLUS = 57;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B_PLUS"]/*' />
    [NativeTypeName("#define DMPAPER_B_PLUS 58")]
    public const int DMPAPER_B_PLUS = 58;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER_PLUS"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER_PLUS 59")]
    public const int DMPAPER_LETTER_PLUS = 59;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4_PLUS"]/*' />
    [NativeTypeName("#define DMPAPER_A4_PLUS 60")]
    public const int DMPAPER_A4_PLUS = 60;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A5_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_A5_TRANSVERSE 61")]
    public const int DMPAPER_A5_TRANSVERSE = 61;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B5_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_B5_TRANSVERSE 62")]
    public const int DMPAPER_B5_TRANSVERSE = 62;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A3_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_A3_EXTRA 63")]
    public const int DMPAPER_A3_EXTRA = 63;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A5_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_A5_EXTRA 64")]
    public const int DMPAPER_A5_EXTRA = 64;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B5_EXTRA"]/*' />
    [NativeTypeName("#define DMPAPER_B5_EXTRA 65")]
    public const int DMPAPER_B5_EXTRA = 65;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A2"]/*' />
    [NativeTypeName("#define DMPAPER_A2 66")]
    public const int DMPAPER_A2 = 66;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A3_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_A3_TRANSVERSE 67")]
    public const int DMPAPER_A3_TRANSVERSE = 67;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A3_EXTRA_TRANSVERSE"]/*' />
    [NativeTypeName("#define DMPAPER_A3_EXTRA_TRANSVERSE 68")]
    public const int DMPAPER_A3_EXTRA_TRANSVERSE = 68;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_DBL_JAPANESE_POSTCARD"]/*' />
    [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD 69")]
    public const int DMPAPER_DBL_JAPANESE_POSTCARD = 69;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A6"]/*' />
    [NativeTypeName("#define DMPAPER_A6 70")]
    public const int DMPAPER_A6 = 70;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_KAKU2"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_KAKU2 71")]
    public const int DMPAPER_JENV_KAKU2 = 71;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_KAKU3"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_KAKU3 72")]
    public const int DMPAPER_JENV_KAKU3 = 72;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_CHOU3"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_CHOU3 73")]
    public const int DMPAPER_JENV_CHOU3 = 73;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_CHOU4"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_CHOU4 74")]
    public const int DMPAPER_JENV_CHOU4 = 74;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LETTER_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_LETTER_ROTATED 75")]
    public const int DMPAPER_LETTER_ROTATED = 75;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A3_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_A3_ROTATED 76")]
    public const int DMPAPER_A3_ROTATED = 76;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A4_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_A4_ROTATED 77")]
    public const int DMPAPER_A4_ROTATED = 77;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A5_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_A5_ROTATED 78")]
    public const int DMPAPER_A5_ROTATED = 78;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B4_JIS_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_B4_JIS_ROTATED 79")]
    public const int DMPAPER_B4_JIS_ROTATED = 79;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B5_JIS_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_B5_JIS_ROTATED 80")]
    public const int DMPAPER_B5_JIS_ROTATED = 80;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JAPANESE_POSTCARD_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD_ROTATED 81")]
    public const int DMPAPER_JAPANESE_POSTCARD_ROTATED = 81;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED 82")]
    public const int DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_A6_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_A6_ROTATED 83")]
    public const int DMPAPER_A6_ROTATED = 83;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_KAKU2_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_KAKU2_ROTATED 84")]
    public const int DMPAPER_JENV_KAKU2_ROTATED = 84;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_KAKU3_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_KAKU3_ROTATED 85")]
    public const int DMPAPER_JENV_KAKU3_ROTATED = 85;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_CHOU3_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_CHOU3_ROTATED 86")]
    public const int DMPAPER_JENV_CHOU3_ROTATED = 86;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_CHOU4_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_CHOU4_ROTATED 87")]
    public const int DMPAPER_JENV_CHOU4_ROTATED = 87;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B6_JIS"]/*' />
    [NativeTypeName("#define DMPAPER_B6_JIS 88")]
    public const int DMPAPER_B6_JIS = 88;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_B6_JIS_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_B6_JIS_ROTATED 89")]
    public const int DMPAPER_B6_JIS_ROTATED = 89;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_12X11"]/*' />
    [NativeTypeName("#define DMPAPER_12X11 90")]
    public const int DMPAPER_12X11 = 90;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_YOU4"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_YOU4 91")]
    public const int DMPAPER_JENV_YOU4 = 91;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_JENV_YOU4_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_JENV_YOU4_ROTATED 92")]
    public const int DMPAPER_JENV_YOU4_ROTATED = 92;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P16K"]/*' />
    [NativeTypeName("#define DMPAPER_P16K 93")]
    public const int DMPAPER_P16K = 93;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P32K"]/*' />
    [NativeTypeName("#define DMPAPER_P32K 94")]
    public const int DMPAPER_P32K = 94;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P32KBIG"]/*' />
    [NativeTypeName("#define DMPAPER_P32KBIG 95")]
    public const int DMPAPER_P32KBIG = 95;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_1"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_1 96")]
    public const int DMPAPER_PENV_1 = 96;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_2"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_2 97")]
    public const int DMPAPER_PENV_2 = 97;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_3"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_3 98")]
    public const int DMPAPER_PENV_3 = 98;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_4"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_4 99")]
    public const int DMPAPER_PENV_4 = 99;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_5"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_5 100")]
    public const int DMPAPER_PENV_5 = 100;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_6"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_6 101")]
    public const int DMPAPER_PENV_6 = 101;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_7"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_7 102")]
    public const int DMPAPER_PENV_7 = 102;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_8"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_8 103")]
    public const int DMPAPER_PENV_8 = 103;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_9"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_9 104")]
    public const int DMPAPER_PENV_9 = 104;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_10"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_10 105")]
    public const int DMPAPER_PENV_10 = 105;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P16K_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_P16K_ROTATED 106")]
    public const int DMPAPER_P16K_ROTATED = 106;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P32K_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_P32K_ROTATED 107")]
    public const int DMPAPER_P32K_ROTATED = 107;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_P32KBIG_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_P32KBIG_ROTATED 108")]
    public const int DMPAPER_P32KBIG_ROTATED = 108;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_1_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_1_ROTATED 109")]
    public const int DMPAPER_PENV_1_ROTATED = 109;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_2_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_2_ROTATED 110")]
    public const int DMPAPER_PENV_2_ROTATED = 110;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_3_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_3_ROTATED 111")]
    public const int DMPAPER_PENV_3_ROTATED = 111;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_4_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_4_ROTATED 112")]
    public const int DMPAPER_PENV_4_ROTATED = 112;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_5_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_5_ROTATED 113")]
    public const int DMPAPER_PENV_5_ROTATED = 113;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_6_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_6_ROTATED 114")]
    public const int DMPAPER_PENV_6_ROTATED = 114;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_7_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_7_ROTATED 115")]
    public const int DMPAPER_PENV_7_ROTATED = 115;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_8_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_8_ROTATED 116")]
    public const int DMPAPER_PENV_8_ROTATED = 116;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_9_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_9_ROTATED 117")]
    public const int DMPAPER_PENV_9_ROTATED = 117;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_PENV_10_ROTATED"]/*' />
    [NativeTypeName("#define DMPAPER_PENV_10_ROTATED 118")]
    public const int DMPAPER_PENV_10_ROTATED = 118;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_LAST"]/*' />
    [NativeTypeName("#define DMPAPER_LAST DMPAPER_PENV_10_ROTATED")]
    public const int DMPAPER_LAST = 118;

    /// <include file='DMPAPER.xml' path='doc/member[@name="DMPAPER.DMPAPER_USER"]/*' />
    [NativeTypeName("#define DMPAPER_USER 256")]
    public const int DMPAPER_USER = 256;
}
