// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BF
{
    /// <include file='BF.xml' path='doc/member[@name="BF.BF_LEFT"]/*' />
    [NativeTypeName("#define BF_LEFT 0x0001")]
    public const int BF_LEFT = 0x0001;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_TOP"]/*' />
    [NativeTypeName("#define BF_TOP 0x0002")]
    public const int BF_TOP = 0x0002;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_RIGHT"]/*' />
    [NativeTypeName("#define BF_RIGHT 0x0004")]
    public const int BF_RIGHT = 0x0004;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_BOTTOM"]/*' />
    [NativeTypeName("#define BF_BOTTOM 0x0008")]
    public const int BF_BOTTOM = 0x0008;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_TOPLEFT"]/*' />
    [NativeTypeName("#define BF_TOPLEFT (BF_TOP | BF_LEFT)")]
    public const int BF_TOPLEFT = (0x0002 | 0x0001);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_TOPRIGHT"]/*' />
    [NativeTypeName("#define BF_TOPRIGHT (BF_TOP | BF_RIGHT)")]
    public const int BF_TOPRIGHT = (0x0002 | 0x0004);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_BOTTOMLEFT"]/*' />
    [NativeTypeName("#define BF_BOTTOMLEFT (BF_BOTTOM | BF_LEFT)")]
    public const int BF_BOTTOMLEFT = (0x0008 | 0x0001);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_BOTTOMRIGHT"]/*' />
    [NativeTypeName("#define BF_BOTTOMRIGHT (BF_BOTTOM | BF_RIGHT)")]
    public const int BF_BOTTOMRIGHT = (0x0008 | 0x0004);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_RECT"]/*' />
    [NativeTypeName("#define BF_RECT (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM)")]
    public const int BF_RECT = (0x0001 | 0x0002 | 0x0004 | 0x0008);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_DIAGONAL"]/*' />
    [NativeTypeName("#define BF_DIAGONAL 0x0010")]
    public const int BF_DIAGONAL = 0x0010;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_DIAGONAL_ENDTOPRIGHT"]/*' />
    [NativeTypeName("#define BF_DIAGONAL_ENDTOPRIGHT (BF_DIAGONAL | BF_TOP | BF_RIGHT)")]
    public const int BF_DIAGONAL_ENDTOPRIGHT = (0x0010 | 0x0002 | 0x0004);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_DIAGONAL_ENDTOPLEFT"]/*' />
    [NativeTypeName("#define BF_DIAGONAL_ENDTOPLEFT (BF_DIAGONAL | BF_TOP | BF_LEFT)")]
    public const int BF_DIAGONAL_ENDTOPLEFT = (0x0010 | 0x0002 | 0x0001);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_DIAGONAL_ENDBOTTOMLEFT"]/*' />
    [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMLEFT (BF_DIAGONAL | BF_BOTTOM | BF_LEFT)")]
    public const int BF_DIAGONAL_ENDBOTTOMLEFT = (0x0010 | 0x0008 | 0x0001);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_DIAGONAL_ENDBOTTOMRIGHT"]/*' />
    [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMRIGHT (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT)")]
    public const int BF_DIAGONAL_ENDBOTTOMRIGHT = (0x0010 | 0x0008 | 0x0004);

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_MIDDLE"]/*' />
    [NativeTypeName("#define BF_MIDDLE 0x0800")]
    public const int BF_MIDDLE = 0x0800;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_SOFT"]/*' />
    [NativeTypeName("#define BF_SOFT 0x1000")]
    public const int BF_SOFT = 0x1000;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_ADJUST"]/*' />
    [NativeTypeName("#define BF_ADJUST 0x2000")]
    public const int BF_ADJUST = 0x2000;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_FLAT"]/*' />
    [NativeTypeName("#define BF_FLAT 0x4000")]
    public const int BF_FLAT = 0x4000;

    /// <include file='BF.xml' path='doc/member[@name="BF.BF_MONO"]/*' />
    [NativeTypeName("#define BF_MONO 0x8000")]
    public const int BF_MONO = 0x8000;
}
