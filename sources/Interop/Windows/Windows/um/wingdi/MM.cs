// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MM
{
    /// <include file='MM.xml' path='doc/member[@name="MM.MM_TEXT"]/*' />
    [NativeTypeName("#define MM_TEXT 1")]
    public const int MM_TEXT = 1;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_LOMETRIC"]/*' />
    [NativeTypeName("#define MM_LOMETRIC 2")]
    public const int MM_LOMETRIC = 2;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_HIMETRIC"]/*' />
    [NativeTypeName("#define MM_HIMETRIC 3")]
    public const int MM_HIMETRIC = 3;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_LOENGLISH"]/*' />
    [NativeTypeName("#define MM_LOENGLISH 4")]
    public const int MM_LOENGLISH = 4;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_HIENGLISH"]/*' />
    [NativeTypeName("#define MM_HIENGLISH 5")]
    public const int MM_HIENGLISH = 5;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_TWIPS"]/*' />
    [NativeTypeName("#define MM_TWIPS 6")]
    public const int MM_TWIPS = 6;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_ISOTROPIC"]/*' />
    [NativeTypeName("#define MM_ISOTROPIC 7")]
    public const int MM_ISOTROPIC = 7;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_ANISOTROPIC"]/*' />
    [NativeTypeName("#define MM_ANISOTROPIC 8")]
    public const int MM_ANISOTROPIC = 8;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIN"]/*' />
    [NativeTypeName("#define MM_MIN MM_TEXT")]
    public const int MM_MIN = 1;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MAX"]/*' />
    [NativeTypeName("#define MM_MAX MM_ANISOTROPIC")]
    public const int MM_MAX = 8;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MAX_FIXEDSCALE"]/*' />
    [NativeTypeName("#define MM_MAX_FIXEDSCALE MM_TWIPS")]
    public const int MM_MAX_FIXEDSCALE = 6;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MAX_NUMAXES"]/*' />
    [NativeTypeName("#define MM_MAX_NUMAXES 16")]
    public const int MM_MAX_NUMAXES = 16;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MAX_AXES_NAMELEN"]/*' />
    [NativeTypeName("#define MM_MAX_AXES_NAMELEN 16")]
    public const int MM_MAX_AXES_NAMELEN = 16;
}
