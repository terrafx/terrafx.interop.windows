// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_UNDEFINED"]/*' />
    [NativeTypeName("#define TKBL_UNDEFINED 0")]
    public const int TKBL_UNDEFINED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC"]/*' />
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC = 0x0404;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE"]/*' />
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE 0xF042")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE = 0xF042;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI"]/*' />
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI 0xF043")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI = 0xF043;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_OPT_JAPANESE_ABC"]/*' />
    [NativeTypeName("#define TKBL_OPT_JAPANESE_ABC 0x0411")]
    public const int TKBL_OPT_JAPANESE_ABC = 0x0411;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_OPT_KOREAN_HANGUL_2_BULSIK"]/*' />
    [NativeTypeName("#define TKBL_OPT_KOREAN_HANGUL_2_BULSIK 0x0412")]
    public const int TKBL_OPT_KOREAN_HANGUL_2_BULSIK = 0x0412;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN"]/*' />
    [NativeTypeName("#define TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN 0x0804")]
    public const int TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN = 0x0804;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC"]/*' />
    [NativeTypeName("#define TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
    public const int TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC = 0x0404;
}
