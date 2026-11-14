// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SORT
{
    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_DEFAULT"]/*' />
    [NativeTypeName("#define SORT_DEFAULT 0x0")]
    public const int SORT_DEFAULT = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_INVARIANT_MATH"]/*' />
    [NativeTypeName("#define SORT_INVARIANT_MATH 0x1")]
    public const int SORT_INVARIANT_MATH = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_JAPANESE_XJIS"]/*' />
    [NativeTypeName("#define SORT_JAPANESE_XJIS 0x0")]
    public const int SORT_JAPANESE_XJIS = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_JAPANESE_UNICODE"]/*' />
    [NativeTypeName("#define SORT_JAPANESE_UNICODE 0x1")]
    public const int SORT_JAPANESE_UNICODE = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_JAPANESE_RADICALSTROKE"]/*' />
    [NativeTypeName("#define SORT_JAPANESE_RADICALSTROKE 0x4")]
    public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_BIG5"]/*' />
    [NativeTypeName("#define SORT_CHINESE_BIG5 0x0")]
    public const int SORT_CHINESE_BIG5 = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_PRCP"]/*' />
    [NativeTypeName("#define SORT_CHINESE_PRCP 0x0")]
    public const int SORT_CHINESE_PRCP = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_UNICODE"]/*' />
    [NativeTypeName("#define SORT_CHINESE_UNICODE 0x1")]
    public const int SORT_CHINESE_UNICODE = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_PRC"]/*' />
    [NativeTypeName("#define SORT_CHINESE_PRC 0x2")]
    public const int SORT_CHINESE_PRC = 0x2;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_BOPOMOFO"]/*' />
    [NativeTypeName("#define SORT_CHINESE_BOPOMOFO 0x3")]
    public const int SORT_CHINESE_BOPOMOFO = 0x3;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_CHINESE_RADICALSTROKE"]/*' />
    [NativeTypeName("#define SORT_CHINESE_RADICALSTROKE 0x4")]
    public const int SORT_CHINESE_RADICALSTROKE = 0x4;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_KOREAN_KSC"]/*' />
    [NativeTypeName("#define SORT_KOREAN_KSC 0x0")]
    public const int SORT_KOREAN_KSC = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_KOREAN_UNICODE"]/*' />
    [NativeTypeName("#define SORT_KOREAN_UNICODE 0x1")]
    public const int SORT_KOREAN_UNICODE = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_GERMAN_PHONE_BOOK"]/*' />
    [NativeTypeName("#define SORT_GERMAN_PHONE_BOOK 0x1")]
    public const int SORT_GERMAN_PHONE_BOOK = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_HUNGARIAN_DEFAULT"]/*' />
    [NativeTypeName("#define SORT_HUNGARIAN_DEFAULT 0x0")]
    public const int SORT_HUNGARIAN_DEFAULT = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_HUNGARIAN_TECHNICAL"]/*' />
    [NativeTypeName("#define SORT_HUNGARIAN_TECHNICAL 0x1")]
    public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_GEORGIAN_TRADITIONAL"]/*' />
    [NativeTypeName("#define SORT_GEORGIAN_TRADITIONAL 0x0")]
    public const int SORT_GEORGIAN_TRADITIONAL = 0x0;

    /// <include file='SORT.xml' path='doc/member[@name="SORT.SORT_GEORGIAN_MODERN"]/*' />
    [NativeTypeName("#define SORT_GEORGIAN_MODERN 0x1")]
    public const int SORT_GEORGIAN_MODERN = 0x1;
}
