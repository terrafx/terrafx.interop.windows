// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DMDITHER
{
    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_NONE"]/*' />
    [NativeTypeName("#define DMDITHER_NONE 1")]
    public const int DMDITHER_NONE = 1;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_COARSE"]/*' />
    [NativeTypeName("#define DMDITHER_COARSE 2")]
    public const int DMDITHER_COARSE = 2;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_FINE"]/*' />
    [NativeTypeName("#define DMDITHER_FINE 3")]
    public const int DMDITHER_FINE = 3;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_LINEART"]/*' />
    [NativeTypeName("#define DMDITHER_LINEART 4")]
    public const int DMDITHER_LINEART = 4;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_ERRORDIFFUSION"]/*' />
    [NativeTypeName("#define DMDITHER_ERRORDIFFUSION 5")]
    public const int DMDITHER_ERRORDIFFUSION = 5;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_RESERVED6"]/*' />
    [NativeTypeName("#define DMDITHER_RESERVED6 6")]
    public const int DMDITHER_RESERVED6 = 6;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_RESERVED7"]/*' />
    [NativeTypeName("#define DMDITHER_RESERVED7 7")]
    public const int DMDITHER_RESERVED7 = 7;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_RESERVED8"]/*' />
    [NativeTypeName("#define DMDITHER_RESERVED8 8")]
    public const int DMDITHER_RESERVED8 = 8;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_RESERVED9"]/*' />
    [NativeTypeName("#define DMDITHER_RESERVED9 9")]
    public const int DMDITHER_RESERVED9 = 9;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_GRAYSCALE"]/*' />
    [NativeTypeName("#define DMDITHER_GRAYSCALE 10")]
    public const int DMDITHER_GRAYSCALE = 10;

    /// <include file='DMDITHER.xml' path='doc/member[@name="DMDITHER.DMDITHER_USER"]/*' />
    [NativeTypeName("#define DMDITHER_USER 256")]
    public const int DMDITHER_USER = 256;
}
