// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PC
{
    /// <include file='PC.xml' path='doc/member[@name="PC.PC_RESERVED"]/*' />
    [NativeTypeName("#define PC_RESERVED 0x01")]
    public const int PC_RESERVED = 0x01;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_EXPLICIT"]/*' />
    [NativeTypeName("#define PC_EXPLICIT 0x02")]
    public const int PC_EXPLICIT = 0x02;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_NOCOLLAPSE"]/*' />
    [NativeTypeName("#define PC_NOCOLLAPSE 0x04")]
    public const int PC_NOCOLLAPSE = 0x04;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_NONE"]/*' />
    [NativeTypeName("#define PC_NONE 0")]
    public const int PC_NONE = 0;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_POLYGON"]/*' />
    [NativeTypeName("#define PC_POLYGON 1")]
    public const int PC_POLYGON = 1;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_RECTANGLE"]/*' />
    [NativeTypeName("#define PC_RECTANGLE 2")]
    public const int PC_RECTANGLE = 2;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_WINDPOLYGON"]/*' />
    [NativeTypeName("#define PC_WINDPOLYGON 4")]
    public const int PC_WINDPOLYGON = 4;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_TRAPEZOID"]/*' />
    [NativeTypeName("#define PC_TRAPEZOID 4")]
    public const int PC_TRAPEZOID = 4;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_SCANLINE"]/*' />
    [NativeTypeName("#define PC_SCANLINE 8")]
    public const int PC_SCANLINE = 8;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_WIDE"]/*' />
    [NativeTypeName("#define PC_WIDE 16")]
    public const int PC_WIDE = 16;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_STYLED"]/*' />
    [NativeTypeName("#define PC_STYLED 32")]
    public const int PC_STYLED = 32;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_WIDESTYLED"]/*' />
    [NativeTypeName("#define PC_WIDESTYLED 64")]
    public const int PC_WIDESTYLED = 64;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_INTERIORS"]/*' />
    [NativeTypeName("#define PC_INTERIORS 128")]
    public const int PC_INTERIORS = 128;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_POLYPOLYGON"]/*' />
    [NativeTypeName("#define PC_POLYPOLYGON 256")]
    public const int PC_POLYPOLYGON = 256;

    /// <include file='PC.xml' path='doc/member[@name="PC.PC_PATHS"]/*' />
    [NativeTypeName("#define PC_PATHS 512")]
    public const int PC_PATHS = 512;
}
