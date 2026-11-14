// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WMSZ
{
    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_LEFT"]/*' />
    [NativeTypeName("#define WMSZ_LEFT 1")]
    public const int WMSZ_LEFT = 1;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_RIGHT"]/*' />
    [NativeTypeName("#define WMSZ_RIGHT 2")]
    public const int WMSZ_RIGHT = 2;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_TOP"]/*' />
    [NativeTypeName("#define WMSZ_TOP 3")]
    public const int WMSZ_TOP = 3;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_TOPLEFT"]/*' />
    [NativeTypeName("#define WMSZ_TOPLEFT 4")]
    public const int WMSZ_TOPLEFT = 4;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_TOPRIGHT"]/*' />
    [NativeTypeName("#define WMSZ_TOPRIGHT 5")]
    public const int WMSZ_TOPRIGHT = 5;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_BOTTOM"]/*' />
    [NativeTypeName("#define WMSZ_BOTTOM 6")]
    public const int WMSZ_BOTTOM = 6;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_BOTTOMLEFT"]/*' />
    [NativeTypeName("#define WMSZ_BOTTOMLEFT 7")]
    public const int WMSZ_BOTTOMLEFT = 7;

    /// <include file='WMSZ.xml' path='doc/member[@name="WMSZ.WMSZ_BOTTOMRIGHT"]/*' />
    [NativeTypeName("#define WMSZ_BOTTOMRIGHT 8")]
    public const int WMSZ_BOTTOMRIGHT = 8;
}
