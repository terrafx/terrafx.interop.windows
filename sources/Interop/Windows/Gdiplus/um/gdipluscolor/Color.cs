// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='Color.xml' path='doc/member[@name="Color"]/*' />
public partial struct Color
{
    /// <include file='Color.xml' path='doc/member[@name="Color.Argb"]/*' />
    [NativeTypeName("Gdiplus::ARGB")]
    public uint Argb;

    public Color()
    {
        Argb = (uint)(Black);
    }

    public Color(byte r, byte g, byte b)
    {
        Argb = MakeARGB(255, r, g, b);
    }

    public Color(byte a, byte r, byte g, byte b)
    {
        Argb = MakeARGB(a, r, g, b);
    }

    public Color([NativeTypeName("Gdiplus::ARGB")] uint argb)
    {
        Argb = argb;
    }

    public readonly byte GetAlpha()
    {
        return (byte)(Argb >> (int)((int)(AlphaShift)));
    }

    public readonly byte GetA()
    {
        return GetAlpha();
    }

    public readonly byte GetRed()
    {
        return (byte)(Argb >> (int)((int)(RedShift)));
    }

    public readonly byte GetR()
    {
        return GetRed();
    }

    public readonly byte GetGreen()
    {
        return (byte)(Argb >> (int)((int)(GreenShift)));
    }

    public readonly byte GetG()
    {
        return GetGreen();
    }

    public readonly byte GetBlue()
    {
        return (byte)(Argb >> (int)((int)(BlueShift)));
    }

    public readonly byte GetB()
    {
        return GetBlue();
    }

    [return: NativeTypeName("Gdiplus::ARGB")]
    public readonly uint GetValue()
    {
        return Argb;
    }

    public void SetValue([NativeTypeName("Gdiplus::ARGB")] uint argb)
    {
        Argb = argb;
    }

    public void SetFromCOLORREF(COLORREF rgb)
    {
        Argb = MakeARGB(255, (((byte)(((nuint)(rgb)) & 0xff))), (((byte)(((nuint)(unchecked(((ushort)(rgb)) >> 8))) & 0xff))), (((byte)(((nuint)((rgb) >> 16)) & 0xff))));
    }

    [return: NativeTypeName("Gdiplus::ARGB")]
    public static uint MakeARGB(byte a, byte r, byte g, byte b)
    {
        return (((uint)(b) << (int)((int)(BlueShift))) | ((uint)(g) << (int)((int)(GreenShift))) | ((uint)(r) << (int)((int)(RedShift))) | ((uint)(a) << (int)((int)(AlphaShift))));
    }

    /// <include file='Color.xml' path='doc/member[@name="Color.AliceBlue"]/*' />
    public const uint AliceBlue = 0xFFF0F8FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.AntiqueWhite"]/*' />
    public const uint AntiqueWhite = 0xFFFAEBD7;
    /// <include file='Color.xml' path='doc/member[@name="Color.Aqua"]/*' />
    public const uint Aqua = 0xFF00FFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Aquamarine"]/*' />
    public const uint Aquamarine = 0xFF7FFFD4;
    /// <include file='Color.xml' path='doc/member[@name="Color.Azure"]/*' />
    public const uint Azure = 0xFFF0FFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Beige"]/*' />
    public const uint Beige = 0xFFF5F5DC;
    /// <include file='Color.xml' path='doc/member[@name="Color.Bisque"]/*' />
    public const uint Bisque = 0xFFFFE4C4;
    /// <include file='Color.xml' path='doc/member[@name="Color.Black"]/*' />
    public const uint Black = 0xFF000000;
    /// <include file='Color.xml' path='doc/member[@name="Color.BlanchedAlmond"]/*' />
    public const uint BlanchedAlmond = 0xFFFFEBCD;
    /// <include file='Color.xml' path='doc/member[@name="Color.Blue"]/*' />
    public const uint Blue = 0xFF0000FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.BlueViolet"]/*' />
    public const uint BlueViolet = 0xFF8A2BE2;
    /// <include file='Color.xml' path='doc/member[@name="Color.Brown"]/*' />
    public const uint Brown = 0xFFA52A2A;
    /// <include file='Color.xml' path='doc/member[@name="Color.BurlyWood"]/*' />
    public const uint BurlyWood = 0xFFDEB887;
    /// <include file='Color.xml' path='doc/member[@name="Color.CadetBlue"]/*' />
    public const uint CadetBlue = 0xFF5F9EA0;
    /// <include file='Color.xml' path='doc/member[@name="Color.Chartreuse"]/*' />
    public const uint Chartreuse = 0xFF7FFF00;
    /// <include file='Color.xml' path='doc/member[@name="Color.Chocolate"]/*' />
    public const uint Chocolate = 0xFFD2691E;
    /// <include file='Color.xml' path='doc/member[@name="Color.Coral"]/*' />
    public const uint Coral = 0xFFFF7F50;
    /// <include file='Color.xml' path='doc/member[@name="Color.CornflowerBlue"]/*' />
    public const uint CornflowerBlue = 0xFF6495ED;
    /// <include file='Color.xml' path='doc/member[@name="Color.Cornsilk"]/*' />
    public const uint Cornsilk = 0xFFFFF8DC;
    /// <include file='Color.xml' path='doc/member[@name="Color.Crimson"]/*' />
    public const uint Crimson = 0xFFDC143C;
    /// <include file='Color.xml' path='doc/member[@name="Color.Cyan"]/*' />
    public const uint Cyan = 0xFF00FFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkBlue"]/*' />
    public const uint DarkBlue = 0xFF00008B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkCyan"]/*' />
    public const uint DarkCyan = 0xFF008B8B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkGoldenrod"]/*' />
    public const uint DarkGoldenrod = 0xFFB8860B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkGray"]/*' />
    public const uint DarkGray = 0xFFA9A9A9;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkGreen"]/*' />
    public const uint DarkGreen = 0xFF006400;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkKhaki"]/*' />
    public const uint DarkKhaki = 0xFFBDB76B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkMagenta"]/*' />
    public const uint DarkMagenta = 0xFF8B008B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkOliveGreen"]/*' />
    public const uint DarkOliveGreen = 0xFF556B2F;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkOrange"]/*' />
    public const uint DarkOrange = 0xFFFF8C00;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkOrchid"]/*' />
    public const uint DarkOrchid = 0xFF9932CC;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkRed"]/*' />
    public const uint DarkRed = 0xFF8B0000;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkSalmon"]/*' />
    public const uint DarkSalmon = 0xFFE9967A;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkSeaGreen"]/*' />
    public const uint DarkSeaGreen = 0xFF8FBC8B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkSlateBlue"]/*' />
    public const uint DarkSlateBlue = 0xFF483D8B;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkSlateGray"]/*' />
    public const uint DarkSlateGray = 0xFF2F4F4F;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkTurquoise"]/*' />
    public const uint DarkTurquoise = 0xFF00CED1;
    /// <include file='Color.xml' path='doc/member[@name="Color.DarkViolet"]/*' />
    public const uint DarkViolet = 0xFF9400D3;
    /// <include file='Color.xml' path='doc/member[@name="Color.DeepPink"]/*' />
    public const uint DeepPink = 0xFFFF1493;
    /// <include file='Color.xml' path='doc/member[@name="Color.DeepSkyBlue"]/*' />
    public const uint DeepSkyBlue = 0xFF00BFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.DimGray"]/*' />
    public const uint DimGray = 0xFF696969;
    /// <include file='Color.xml' path='doc/member[@name="Color.DodgerBlue"]/*' />
    public const uint DodgerBlue = 0xFF1E90FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Firebrick"]/*' />
    public const uint Firebrick = 0xFFB22222;
    /// <include file='Color.xml' path='doc/member[@name="Color.FloralWhite"]/*' />
    public const uint FloralWhite = 0xFFFFFAF0;
    /// <include file='Color.xml' path='doc/member[@name="Color.ForestGreen"]/*' />
    public const uint ForestGreen = 0xFF228B22;
    /// <include file='Color.xml' path='doc/member[@name="Color.Fuchsia"]/*' />
    public const uint Fuchsia = 0xFFFF00FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Gainsboro"]/*' />
    public const uint Gainsboro = 0xFFDCDCDC;
    /// <include file='Color.xml' path='doc/member[@name="Color.GhostWhite"]/*' />
    public const uint GhostWhite = 0xFFF8F8FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Gold"]/*' />
    public const uint Gold = 0xFFFFD700;
    /// <include file='Color.xml' path='doc/member[@name="Color.Goldenrod"]/*' />
    public const uint Goldenrod = 0xFFDAA520;
    /// <include file='Color.xml' path='doc/member[@name="Color.Gray"]/*' />
    public const uint Gray = 0xFF808080;
    /// <include file='Color.xml' path='doc/member[@name="Color.Green"]/*' />
    public const uint Green = 0xFF008000;
    /// <include file='Color.xml' path='doc/member[@name="Color.GreenYellow"]/*' />
    public const uint GreenYellow = 0xFFADFF2F;
    /// <include file='Color.xml' path='doc/member[@name="Color.Honeydew"]/*' />
    public const uint Honeydew = 0xFFF0FFF0;
    /// <include file='Color.xml' path='doc/member[@name="Color.HotPink"]/*' />
    public const uint HotPink = 0xFFFF69B4;
    /// <include file='Color.xml' path='doc/member[@name="Color.IndianRed"]/*' />
    public const uint IndianRed = 0xFFCD5C5C;
    /// <include file='Color.xml' path='doc/member[@name="Color.Indigo"]/*' />
    public const uint Indigo = 0xFF4B0082;
    /// <include file='Color.xml' path='doc/member[@name="Color.Ivory"]/*' />
    public const uint Ivory = 0xFFFFFFF0;
    /// <include file='Color.xml' path='doc/member[@name="Color.Khaki"]/*' />
    public const uint Khaki = 0xFFF0E68C;
    /// <include file='Color.xml' path='doc/member[@name="Color.Lavender"]/*' />
    public const uint Lavender = 0xFFE6E6FA;
    /// <include file='Color.xml' path='doc/member[@name="Color.LavenderBlush"]/*' />
    public const uint LavenderBlush = 0xFFFFF0F5;
    /// <include file='Color.xml' path='doc/member[@name="Color.LawnGreen"]/*' />
    public const uint LawnGreen = 0xFF7CFC00;
    /// <include file='Color.xml' path='doc/member[@name="Color.LemonChiffon"]/*' />
    public const uint LemonChiffon = 0xFFFFFACD;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightBlue"]/*' />
    public const uint LightBlue = 0xFFADD8E6;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightCoral"]/*' />
    public const uint LightCoral = 0xFFF08080;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightCyan"]/*' />
    public const uint LightCyan = 0xFFE0FFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightGoldenrodYellow"]/*' />
    public const uint LightGoldenrodYellow = 0xFFFAFAD2;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightGray"]/*' />
    public const uint LightGray = 0xFFD3D3D3;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightGreen"]/*' />
    public const uint LightGreen = 0xFF90EE90;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightPink"]/*' />
    public const uint LightPink = 0xFFFFB6C1;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightSalmon"]/*' />
    public const uint LightSalmon = 0xFFFFA07A;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightSeaGreen"]/*' />
    public const uint LightSeaGreen = 0xFF20B2AA;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightSkyBlue"]/*' />
    public const uint LightSkyBlue = 0xFF87CEFA;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightSlateGray"]/*' />
    public const uint LightSlateGray = 0xFF778899;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightSteelBlue"]/*' />
    public const uint LightSteelBlue = 0xFFB0C4DE;
    /// <include file='Color.xml' path='doc/member[@name="Color.LightYellow"]/*' />
    public const uint LightYellow = 0xFFFFFFE0;
    /// <include file='Color.xml' path='doc/member[@name="Color.Lime"]/*' />
    public const uint Lime = 0xFF00FF00;
    /// <include file='Color.xml' path='doc/member[@name="Color.LimeGreen"]/*' />
    public const uint LimeGreen = 0xFF32CD32;
    /// <include file='Color.xml' path='doc/member[@name="Color.Linen"]/*' />
    public const uint Linen = 0xFFFAF0E6;
    /// <include file='Color.xml' path='doc/member[@name="Color.Magenta"]/*' />
    public const uint Magenta = 0xFFFF00FF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Maroon"]/*' />
    public const uint Maroon = 0xFF800000;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumAquamarine"]/*' />
    public const uint MediumAquamarine = 0xFF66CDAA;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumBlue"]/*' />
    public const uint MediumBlue = 0xFF0000CD;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumOrchid"]/*' />
    public const uint MediumOrchid = 0xFFBA55D3;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumPurple"]/*' />
    public const uint MediumPurple = 0xFF9370DB;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumSeaGreen"]/*' />
    public const uint MediumSeaGreen = 0xFF3CB371;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumSlateBlue"]/*' />
    public const uint MediumSlateBlue = 0xFF7B68EE;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumSpringGreen"]/*' />
    public const uint MediumSpringGreen = 0xFF00FA9A;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumTurquoise"]/*' />
    public const uint MediumTurquoise = 0xFF48D1CC;
    /// <include file='Color.xml' path='doc/member[@name="Color.MediumVioletRed"]/*' />
    public const uint MediumVioletRed = 0xFFC71585;
    /// <include file='Color.xml' path='doc/member[@name="Color.MidnightBlue"]/*' />
    public const uint MidnightBlue = 0xFF191970;
    /// <include file='Color.xml' path='doc/member[@name="Color.MintCream"]/*' />
    public const uint MintCream = 0xFFF5FFFA;
    /// <include file='Color.xml' path='doc/member[@name="Color.MistyRose"]/*' />
    public const uint MistyRose = 0xFFFFE4E1;
    /// <include file='Color.xml' path='doc/member[@name="Color.Moccasin"]/*' />
    public const uint Moccasin = 0xFFFFE4B5;
    /// <include file='Color.xml' path='doc/member[@name="Color.NavajoWhite"]/*' />
    public const uint NavajoWhite = 0xFFFFDEAD;
    /// <include file='Color.xml' path='doc/member[@name="Color.Navy"]/*' />
    public const uint Navy = 0xFF000080;
    /// <include file='Color.xml' path='doc/member[@name="Color.OldLace"]/*' />
    public const uint OldLace = 0xFFFDF5E6;
    /// <include file='Color.xml' path='doc/member[@name="Color.Olive"]/*' />
    public const uint Olive = 0xFF808000;
    /// <include file='Color.xml' path='doc/member[@name="Color.OliveDrab"]/*' />
    public const uint OliveDrab = 0xFF6B8E23;
    /// <include file='Color.xml' path='doc/member[@name="Color.Orange"]/*' />
    public const uint Orange = 0xFFFFA500;
    /// <include file='Color.xml' path='doc/member[@name="Color.OrangeRed"]/*' />
    public const uint OrangeRed = 0xFFFF4500;
    /// <include file='Color.xml' path='doc/member[@name="Color.Orchid"]/*' />
    public const uint Orchid = 0xFFDA70D6;
    /// <include file='Color.xml' path='doc/member[@name="Color.PaleGoldenrod"]/*' />
    public const uint PaleGoldenrod = 0xFFEEE8AA;
    /// <include file='Color.xml' path='doc/member[@name="Color.PaleGreen"]/*' />
    public const uint PaleGreen = 0xFF98FB98;
    /// <include file='Color.xml' path='doc/member[@name="Color.PaleTurquoise"]/*' />
    public const uint PaleTurquoise = 0xFFAFEEEE;
    /// <include file='Color.xml' path='doc/member[@name="Color.PaleVioletRed"]/*' />
    public const uint PaleVioletRed = 0xFFDB7093;
    /// <include file='Color.xml' path='doc/member[@name="Color.PapayaWhip"]/*' />
    public const uint PapayaWhip = 0xFFFFEFD5;
    /// <include file='Color.xml' path='doc/member[@name="Color.PeachPuff"]/*' />
    public const uint PeachPuff = 0xFFFFDAB9;
    /// <include file='Color.xml' path='doc/member[@name="Color.Peru"]/*' />
    public const uint Peru = 0xFFCD853F;
    /// <include file='Color.xml' path='doc/member[@name="Color.Pink"]/*' />
    public const uint Pink = 0xFFFFC0CB;
    /// <include file='Color.xml' path='doc/member[@name="Color.Plum"]/*' />
    public const uint Plum = 0xFFDDA0DD;
    /// <include file='Color.xml' path='doc/member[@name="Color.PowderBlue"]/*' />
    public const uint PowderBlue = 0xFFB0E0E6;
    /// <include file='Color.xml' path='doc/member[@name="Color.Purple"]/*' />
    public const uint Purple = 0xFF800080;
    /// <include file='Color.xml' path='doc/member[@name="Color.Red"]/*' />
    public const uint Red = 0xFFFF0000;
    /// <include file='Color.xml' path='doc/member[@name="Color.RosyBrown"]/*' />
    public const uint RosyBrown = 0xFFBC8F8F;
    /// <include file='Color.xml' path='doc/member[@name="Color.RoyalBlue"]/*' />
    public const uint RoyalBlue = 0xFF4169E1;
    /// <include file='Color.xml' path='doc/member[@name="Color.SaddleBrown"]/*' />
    public const uint SaddleBrown = 0xFF8B4513;
    /// <include file='Color.xml' path='doc/member[@name="Color.Salmon"]/*' />
    public const uint Salmon = 0xFFFA8072;
    /// <include file='Color.xml' path='doc/member[@name="Color.SandyBrown"]/*' />
    public const uint SandyBrown = 0xFFF4A460;
    /// <include file='Color.xml' path='doc/member[@name="Color.SeaGreen"]/*' />
    public const uint SeaGreen = 0xFF2E8B57;
    /// <include file='Color.xml' path='doc/member[@name="Color.SeaShell"]/*' />
    public const uint SeaShell = 0xFFFFF5EE;
    /// <include file='Color.xml' path='doc/member[@name="Color.Sienna"]/*' />
    public const uint Sienna = 0xFFA0522D;
    /// <include file='Color.xml' path='doc/member[@name="Color.Silver"]/*' />
    public const uint Silver = 0xFFC0C0C0;
    /// <include file='Color.xml' path='doc/member[@name="Color.SkyBlue"]/*' />
    public const uint SkyBlue = 0xFF87CEEB;
    /// <include file='Color.xml' path='doc/member[@name="Color.SlateBlue"]/*' />
    public const uint SlateBlue = 0xFF6A5ACD;
    /// <include file='Color.xml' path='doc/member[@name="Color.SlateGray"]/*' />
    public const uint SlateGray = 0xFF708090;
    /// <include file='Color.xml' path='doc/member[@name="Color.Snow"]/*' />
    public const uint Snow = 0xFFFFFAFA;
    /// <include file='Color.xml' path='doc/member[@name="Color.SpringGreen"]/*' />
    public const uint SpringGreen = 0xFF00FF7F;
    /// <include file='Color.xml' path='doc/member[@name="Color.SteelBlue"]/*' />
    public const uint SteelBlue = 0xFF4682B4;
    /// <include file='Color.xml' path='doc/member[@name="Color.Tan"]/*' />
    public const uint Tan = 0xFFD2B48C;
    /// <include file='Color.xml' path='doc/member[@name="Color.Teal"]/*' />
    public const uint Teal = 0xFF008080;
    /// <include file='Color.xml' path='doc/member[@name="Color.Thistle"]/*' />
    public const uint Thistle = 0xFFD8BFD8;
    /// <include file='Color.xml' path='doc/member[@name="Color.Tomato"]/*' />
    public const uint Tomato = 0xFFFF6347;
    /// <include file='Color.xml' path='doc/member[@name="Color.Transparent"]/*' />
    public const uint Transparent = 0x00FFFFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.Turquoise"]/*' />
    public const uint Turquoise = 0xFF40E0D0;
    /// <include file='Color.xml' path='doc/member[@name="Color.Violet"]/*' />
    public const uint Violet = 0xFFEE82EE;
    /// <include file='Color.xml' path='doc/member[@name="Color.Wheat"]/*' />
    public const uint Wheat = 0xFFF5DEB3;
    /// <include file='Color.xml' path='doc/member[@name="Color.White"]/*' />
    public const uint White = 0xFFFFFFFF;
    /// <include file='Color.xml' path='doc/member[@name="Color.WhiteSmoke"]/*' />
    public const uint WhiteSmoke = 0xFFF5F5F5;
    /// <include file='Color.xml' path='doc/member[@name="Color.Yellow"]/*' />
    public const uint Yellow = 0xFFFFFF00;
    /// <include file='Color.xml' path='doc/member[@name="Color.YellowGreen"]/*' />
    public const uint YellowGreen = 0xFF9ACD32;

    /// <include file='Color.xml' path='doc/member[@name="Color.AlphaShift"]/*' />
    public const int AlphaShift = 24;
    /// <include file='Color.xml' path='doc/member[@name="Color.RedShift"]/*' />
    public const int RedShift = 16;
    /// <include file='Color.xml' path='doc/member[@name="Color.GreenShift"]/*' />
    public const int GreenShift = 8;
    /// <include file='Color.xml' path='doc/member[@name="Color.BlueShift"]/*' />
    public const int BlueShift = 0;

    /// <include file='Color.xml' path='doc/member[@name="Color.AlphaMask"]/*' />
    public const uint AlphaMask = 0xff000000;
    /// <include file='Color.xml' path='doc/member[@name="Color.RedMask"]/*' />
    public const uint RedMask = 0x00ff0000;
    /// <include file='Color.xml' path='doc/member[@name="Color.GreenMask"]/*' />
    public const uint GreenMask = 0x0000ff00;
    /// <include file='Color.xml' path='doc/member[@name="Color.BlueMask"]/*' />
    public const uint BlueMask = 0x000000ff;
}
