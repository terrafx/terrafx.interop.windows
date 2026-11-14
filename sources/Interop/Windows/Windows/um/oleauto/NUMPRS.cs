// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NUMPRS
{
    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_LEADING_WHITE"]/*' />
    [NativeTypeName("#define NUMPRS_LEADING_WHITE 0x0001")]
    public const int NUMPRS_LEADING_WHITE = 0x0001;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_TRAILING_WHITE"]/*' />
    [NativeTypeName("#define NUMPRS_TRAILING_WHITE 0x0002")]
    public const int NUMPRS_TRAILING_WHITE = 0x0002;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_LEADING_PLUS"]/*' />
    [NativeTypeName("#define NUMPRS_LEADING_PLUS 0x0004")]
    public const int NUMPRS_LEADING_PLUS = 0x0004;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_TRAILING_PLUS"]/*' />
    [NativeTypeName("#define NUMPRS_TRAILING_PLUS 0x0008")]
    public const int NUMPRS_TRAILING_PLUS = 0x0008;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_LEADING_MINUS"]/*' />
    [NativeTypeName("#define NUMPRS_LEADING_MINUS 0x0010")]
    public const int NUMPRS_LEADING_MINUS = 0x0010;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_TRAILING_MINUS"]/*' />
    [NativeTypeName("#define NUMPRS_TRAILING_MINUS 0x0020")]
    public const int NUMPRS_TRAILING_MINUS = 0x0020;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_HEX_OCT"]/*' />
    [NativeTypeName("#define NUMPRS_HEX_OCT 0x0040")]
    public const int NUMPRS_HEX_OCT = 0x0040;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_PARENS"]/*' />
    [NativeTypeName("#define NUMPRS_PARENS 0x0080")]
    public const int NUMPRS_PARENS = 0x0080;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_DECIMAL"]/*' />
    [NativeTypeName("#define NUMPRS_DECIMAL 0x0100")]
    public const int NUMPRS_DECIMAL = 0x0100;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_THOUSANDS"]/*' />
    [NativeTypeName("#define NUMPRS_THOUSANDS 0x0200")]
    public const int NUMPRS_THOUSANDS = 0x0200;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_CURRENCY"]/*' />
    [NativeTypeName("#define NUMPRS_CURRENCY 0x0400")]
    public const int NUMPRS_CURRENCY = 0x0400;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_EXPONENT"]/*' />
    [NativeTypeName("#define NUMPRS_EXPONENT 0x0800")]
    public const int NUMPRS_EXPONENT = 0x0800;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_USE_ALL"]/*' />
    [NativeTypeName("#define NUMPRS_USE_ALL 0x1000")]
    public const int NUMPRS_USE_ALL = 0x1000;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_STD"]/*' />
    [NativeTypeName("#define NUMPRS_STD 0x1FFF")]
    public const int NUMPRS_STD = 0x1FFF;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_NEG"]/*' />
    [NativeTypeName("#define NUMPRS_NEG 0x10000")]
    public const int NUMPRS_NEG = 0x10000;

    /// <include file='NUMPRS.xml' path='doc/member[@name="NUMPRS.NUMPRS_INEXACT"]/*' />
    [NativeTypeName("#define NUMPRS_INEXACT 0x20000")]
    public const int NUMPRS_INEXACT = 0x20000;
}
