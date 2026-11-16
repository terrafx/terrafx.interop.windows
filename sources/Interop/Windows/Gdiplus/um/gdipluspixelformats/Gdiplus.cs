// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsIndexedPixelFormat"]/*' />
    public static BOOL IsIndexedPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00010000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsAlphaPixelFormat"]/*' />
    public static BOOL IsAlphaPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00040000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsExtendedPixelFormat"]/*' />
    public static BOOL IsExtendedPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00100000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsCanonicalPixelFormat"]/*' />
    public static BOOL IsCanonicalPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00200000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ALPHA_SHIFT"]/*' />
    [NativeTypeName("#define ALPHA_SHIFT 24")]
    public const int ALPHA_SHIFT = 24;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.RED_SHIFT"]/*' />
    [NativeTypeName("#define RED_SHIFT 16")]
    public const int RED_SHIFT = 16;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GREEN_SHIFT"]/*' />
    [NativeTypeName("#define GREEN_SHIFT 8")]
    public const int GREEN_SHIFT = 8;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.BLUE_SHIFT"]/*' />
    [NativeTypeName("#define BLUE_SHIFT 0")]
    public const int BLUE_SHIFT = 0;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatIndexed"]/*' />
    [NativeTypeName("#define PixelFormatIndexed 0x00010000")]
    public const int PixelFormatIndexed = 0x00010000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatGDI"]/*' />
    [NativeTypeName("#define PixelFormatGDI 0x00020000")]
    public const int PixelFormatGDI = 0x00020000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatAlpha"]/*' />
    [NativeTypeName("#define PixelFormatAlpha 0x00040000")]
    public const int PixelFormatAlpha = 0x00040000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatPAlpha"]/*' />
    [NativeTypeName("#define PixelFormatPAlpha 0x00080000")]
    public const int PixelFormatPAlpha = 0x00080000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatExtended"]/*' />
    [NativeTypeName("#define PixelFormatExtended 0x00100000")]
    public const int PixelFormatExtended = 0x00100000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatCanonical"]/*' />
    [NativeTypeName("#define PixelFormatCanonical 0x00200000")]
    public const int PixelFormatCanonical = 0x00200000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatUndefined"]/*' />
    [NativeTypeName("#define PixelFormatUndefined 0")]
    public const int PixelFormatUndefined = 0;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatDontCare"]/*' />
    [NativeTypeName("#define PixelFormatDontCare 0")]
    public const int PixelFormatDontCare = 0;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat1bppIndexed"]/*' />
    [NativeTypeName("#define PixelFormat1bppIndexed (1 | ( 1 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat1bppIndexed = (1 | (1 << 8) | 0x00010000 | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat4bppIndexed"]/*' />
    [NativeTypeName("#define PixelFormat4bppIndexed (2 | ( 4 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat4bppIndexed = (2 | (4 << 8) | 0x00010000 | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat8bppIndexed"]/*' />
    [NativeTypeName("#define PixelFormat8bppIndexed (3 | ( 8 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat8bppIndexed = (3 | (8 << 8) | 0x00010000 | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat16bppGrayScale"]/*' />
    [NativeTypeName("#define PixelFormat16bppGrayScale (4 | (16 << 8) | PixelFormatExtended)")]
    public const int PixelFormat16bppGrayScale = (4 | (16 << 8) | 0x00100000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat16bppRGB555"]/*' />
    [NativeTypeName("#define PixelFormat16bppRGB555 (5 | (16 << 8) | PixelFormatGDI)")]
    public const int PixelFormat16bppRGB555 = (5 | (16 << 8) | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat16bppRGB565"]/*' />
    [NativeTypeName("#define PixelFormat16bppRGB565 (6 | (16 << 8) | PixelFormatGDI)")]
    public const int PixelFormat16bppRGB565 = (6 | (16 << 8) | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat16bppARGB1555"]/*' />
    [NativeTypeName("#define PixelFormat16bppARGB1555 (7 | (16 << 8) | PixelFormatAlpha | PixelFormatGDI)")]
    public const int PixelFormat16bppARGB1555 = (7 | (16 << 8) | 0x00040000 | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat24bppRGB"]/*' />
    [NativeTypeName("#define PixelFormat24bppRGB (8 | (24 << 8) | PixelFormatGDI)")]
    public const int PixelFormat24bppRGB = (8 | (24 << 8) | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat32bppRGB"]/*' />
    [NativeTypeName("#define PixelFormat32bppRGB (9 | (32 << 8) | PixelFormatGDI)")]
    public const int PixelFormat32bppRGB = (9 | (32 << 8) | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat32bppARGB"]/*' />
    [NativeTypeName("#define PixelFormat32bppARGB (10 | (32 << 8) | PixelFormatAlpha | PixelFormatGDI | PixelFormatCanonical)")]
    public const int PixelFormat32bppARGB = (10 | (32 << 8) | 0x00040000 | 0x00020000 | 0x00200000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat32bppPARGB"]/*' />
    [NativeTypeName("#define PixelFormat32bppPARGB (11 | (32 << 8) | PixelFormatAlpha | PixelFormatPAlpha | PixelFormatGDI)")]
    public const int PixelFormat32bppPARGB = (11 | (32 << 8) | 0x00040000 | 0x00080000 | 0x00020000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat48bppRGB"]/*' />
    [NativeTypeName("#define PixelFormat48bppRGB (12 | (48 << 8) | PixelFormatExtended)")]
    public const int PixelFormat48bppRGB = (12 | (48 << 8) | 0x00100000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat64bppARGB"]/*' />
    [NativeTypeName("#define PixelFormat64bppARGB (13 | (64 << 8) | PixelFormatAlpha  | PixelFormatCanonical | PixelFormatExtended)")]
    public const int PixelFormat64bppARGB = (13 | (64 << 8) | 0x00040000 | 0x00200000 | 0x00100000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat64bppPARGB"]/*' />
    [NativeTypeName("#define PixelFormat64bppPARGB (14 | (64 << 8) | PixelFormatAlpha  | PixelFormatPAlpha | PixelFormatExtended)")]
    public const int PixelFormat64bppPARGB = (14 | (64 << 8) | 0x00040000 | 0x00080000 | 0x00100000);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormat32bppCMYK"]/*' />
    [NativeTypeName("#define PixelFormat32bppCMYK (15 | (32 << 8))")]
    public const int PixelFormat32bppCMYK = (15 | (32 << 8));

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.PixelFormatMax"]/*' />
    [NativeTypeName("#define PixelFormatMax 16")]
    public const int PixelFormatMax = 16;
}
