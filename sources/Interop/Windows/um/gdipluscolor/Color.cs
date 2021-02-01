// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Color
    {
        [NativeTypeName("Gdiplus::ARGB")]
        public uint Argb;

        public Color([NativeTypeName("BYTE")] byte r, [NativeTypeName("BYTE")] byte g, [NativeTypeName("BYTE")] byte b)
        {
            Argb = MakeARGB(255, r, g, b);
        }

        public Color([NativeTypeName("BYTE")] byte a, [NativeTypeName("BYTE")] byte r, [NativeTypeName("BYTE")] byte g, [NativeTypeName("BYTE")] byte b)
        {
            Argb = MakeARGB(a, r, g, b);
        }

        public Color([NativeTypeName("Gdiplus::ARGB")] uint argb)
        {
            Argb = argb;
        }

        [return: NativeTypeName("BYTE")]
        public byte GetAlpha()
        {
            return (byte)(Argb >> (int)(AlphaShift));
        }

        [return: NativeTypeName("BYTE")]
        public byte GetA()
        {
            return GetAlpha();
        }

        [return: NativeTypeName("BYTE")]
        public byte GetRed()
        {
            return (byte)(Argb >> (int)(RedShift));
        }

        [return: NativeTypeName("BYTE")]
        public byte GetR()
        {
            return GetRed();
        }

        [return: NativeTypeName("BYTE")]
        public byte GetGreen()
        {
            return (byte)(Argb >> (int)(GreenShift));
        }

        [return: NativeTypeName("BYTE")]
        public byte GetG()
        {
            return GetGreen();
        }

        [return: NativeTypeName("BYTE")]
        public byte GetBlue()
        {
            return (byte)(Argb >> (int)(BlueShift));
        }

        [return: NativeTypeName("BYTE")]
        public byte GetB()
        {
            return GetBlue();
        }

        [return: NativeTypeName("Gdiplus::ARGB")]
        public uint GetValue()
        {
            return Argb;
        }

        public void SetValue([NativeTypeName("Gdiplus::ARGB")] uint argb)
        {
            Argb = argb;
        }

        public void SetFromCOLORREF([NativeTypeName("COLORREF")] uint rgb)
        {
            Argb = MakeARGB(255, (((byte)(((nuint)(rgb)) & 0xff))), (((byte)(((nuint)(((ushort)(rgb)) >> 8)) & 0xff))), (((byte)(((nuint)((rgb) >> 16)) & 0xff))));
        }

        [return: NativeTypeName("COLORREF")]
        public uint ToCOLORREF()
        {
            return ((uint)((uint)((byte)(GetRed()) | ((ushort)((byte)(GetGreen())) << 8)) | (((uint)((byte)(GetBlue()))) << 16)));
        }

        [return: NativeTypeName("Gdiplus::ARGB")]
        public static uint MakeARGB([NativeTypeName("BYTE")] byte a, [NativeTypeName("BYTE")] byte r, [NativeTypeName("BYTE")] byte g, [NativeTypeName("BYTE")] byte b)
        {
            return (((uint)(b) << (int)(BlueShift)) | ((uint)(g) << (int)(GreenShift)) | ((uint)(r) << (int)(RedShift)) | ((uint)(a) << (int)(AlphaShift)));
        }

        public const int AliceBlue = unchecked((int)(0xFFF0F8FF));
        public const int AntiqueWhite = unchecked((int)(0xFFFAEBD7));
        public const int Aqua = unchecked((int)(0xFF00FFFF));
        public const int Aquamarine = unchecked((int)(0xFF7FFFD4));
        public const int Azure = unchecked((int)(0xFFF0FFFF));
        public const int Beige = unchecked((int)(0xFFF5F5DC));
        public const int Bisque = unchecked((int)(0xFFFFE4C4));
        public const int Black = unchecked((int)(0xFF000000));
        public const int BlanchedAlmond = unchecked((int)(0xFFFFEBCD));
        public const int Blue = unchecked((int)(0xFF0000FF));
        public const int BlueViolet = unchecked((int)(0xFF8A2BE2));
        public const int Brown = unchecked((int)(0xFFA52A2A));
        public const int BurlyWood = unchecked((int)(0xFFDEB887));
        public const int CadetBlue = unchecked((int)(0xFF5F9EA0));
        public const int Chartreuse = unchecked((int)(0xFF7FFF00));
        public const int Chocolate = unchecked((int)(0xFFD2691E));
        public const int Coral = unchecked((int)(0xFFFF7F50));
        public const int CornflowerBlue = unchecked((int)(0xFF6495ED));
        public const int Cornsilk = unchecked((int)(0xFFFFF8DC));
        public const int Crimson = unchecked((int)(0xFFDC143C));
        public const int Cyan = unchecked((int)(0xFF00FFFF));
        public const int DarkBlue = unchecked((int)(0xFF00008B));
        public const int DarkCyan = unchecked((int)(0xFF008B8B));
        public const int DarkGoldenrod = unchecked((int)(0xFFB8860B));
        public const int DarkGray = unchecked((int)(0xFFA9A9A9));
        public const int DarkGreen = unchecked((int)(0xFF006400));
        public const int DarkKhaki = unchecked((int)(0xFFBDB76B));
        public const int DarkMagenta = unchecked((int)(0xFF8B008B));
        public const int DarkOliveGreen = unchecked((int)(0xFF556B2F));
        public const int DarkOrange = unchecked((int)(0xFFFF8C00));
        public const int DarkOrchid = unchecked((int)(0xFF9932CC));
        public const int DarkRed = unchecked((int)(0xFF8B0000));
        public const int DarkSalmon = unchecked((int)(0xFFE9967A));
        public const int DarkSeaGreen = unchecked((int)(0xFF8FBC8B));
        public const int DarkSlateBlue = unchecked((int)(0xFF483D8B));
        public const int DarkSlateGray = unchecked((int)(0xFF2F4F4F));
        public const int DarkTurquoise = unchecked((int)(0xFF00CED1));
        public const int DarkViolet = unchecked((int)(0xFF9400D3));
        public const int DeepPink = unchecked((int)(0xFFFF1493));
        public const int DeepSkyBlue = unchecked((int)(0xFF00BFFF));
        public const int DimGray = unchecked((int)(0xFF696969));
        public const int DodgerBlue = unchecked((int)(0xFF1E90FF));
        public const int Firebrick = unchecked((int)(0xFFB22222));
        public const int FloralWhite = unchecked((int)(0xFFFFFAF0));
        public const int ForestGreen = unchecked((int)(0xFF228B22));
        public const int Fuchsia = unchecked((int)(0xFFFF00FF));
        public const int Gainsboro = unchecked((int)(0xFFDCDCDC));
        public const int GhostWhite = unchecked((int)(0xFFF8F8FF));
        public const int Gold = unchecked((int)(0xFFFFD700));
        public const int Goldenrod = unchecked((int)(0xFFDAA520));
        public const int Gray = unchecked((int)(0xFF808080));
        public const int Green = unchecked((int)(0xFF008000));
        public const int GreenYellow = unchecked((int)(0xFFADFF2F));
        public const int Honeydew = unchecked((int)(0xFFF0FFF0));
        public const int HotPink = unchecked((int)(0xFFFF69B4));
        public const int IndianRed = unchecked((int)(0xFFCD5C5C));
        public const int Indigo = unchecked((int)(0xFF4B0082));
        public const int Ivory = unchecked((int)(0xFFFFFFF0));
        public const int Khaki = unchecked((int)(0xFFF0E68C));
        public const int Lavender = unchecked((int)(0xFFE6E6FA));
        public const int LavenderBlush = unchecked((int)(0xFFFFF0F5));
        public const int LawnGreen = unchecked((int)(0xFF7CFC00));
        public const int LemonChiffon = unchecked((int)(0xFFFFFACD));
        public const int LightBlue = unchecked((int)(0xFFADD8E6));
        public const int LightCoral = unchecked((int)(0xFFF08080));
        public const int LightCyan = unchecked((int)(0xFFE0FFFF));
        public const int LightGoldenrodYellow = unchecked((int)(0xFFFAFAD2));
        public const int LightGray = unchecked((int)(0xFFD3D3D3));
        public const int LightGreen = unchecked((int)(0xFF90EE90));
        public const int LightPink = unchecked((int)(0xFFFFB6C1));
        public const int LightSalmon = unchecked((int)(0xFFFFA07A));
        public const int LightSeaGreen = unchecked((int)(0xFF20B2AA));
        public const int LightSkyBlue = unchecked((int)(0xFF87CEFA));
        public const int LightSlateGray = unchecked((int)(0xFF778899));
        public const int LightSteelBlue = unchecked((int)(0xFFB0C4DE));
        public const int LightYellow = unchecked((int)(0xFFFFFFE0));
        public const int Lime = unchecked((int)(0xFF00FF00));
        public const int LimeGreen = unchecked((int)(0xFF32CD32));
        public const int Linen = unchecked((int)(0xFFFAF0E6));
        public const int Magenta = unchecked((int)(0xFFFF00FF));
        public const int Maroon = unchecked((int)(0xFF800000));
        public const int MediumAquamarine = unchecked((int)(0xFF66CDAA));
        public const int MediumBlue = unchecked((int)(0xFF0000CD));
        public const int MediumOrchid = unchecked((int)(0xFFBA55D3));
        public const int MediumPurple = unchecked((int)(0xFF9370DB));
        public const int MediumSeaGreen = unchecked((int)(0xFF3CB371));
        public const int MediumSlateBlue = unchecked((int)(0xFF7B68EE));
        public const int MediumSpringGreen = unchecked((int)(0xFF00FA9A));
        public const int MediumTurquoise = unchecked((int)(0xFF48D1CC));
        public const int MediumVioletRed = unchecked((int)(0xFFC71585));
        public const int MidnightBlue = unchecked((int)(0xFF191970));
        public const int MintCream = unchecked((int)(0xFFF5FFFA));
        public const int MistyRose = unchecked((int)(0xFFFFE4E1));
        public const int Moccasin = unchecked((int)(0xFFFFE4B5));
        public const int NavajoWhite = unchecked((int)(0xFFFFDEAD));
        public const int Navy = unchecked((int)(0xFF000080));
        public const int OldLace = unchecked((int)(0xFFFDF5E6));
        public const int Olive = unchecked((int)(0xFF808000));
        public const int OliveDrab = unchecked((int)(0xFF6B8E23));
        public const int Orange = unchecked((int)(0xFFFFA500));
        public const int OrangeRed = unchecked((int)(0xFFFF4500));
        public const int Orchid = unchecked((int)(0xFFDA70D6));
        public const int PaleGoldenrod = unchecked((int)(0xFFEEE8AA));
        public const int PaleGreen = unchecked((int)(0xFF98FB98));
        public const int PaleTurquoise = unchecked((int)(0xFFAFEEEE));
        public const int PaleVioletRed = unchecked((int)(0xFFDB7093));
        public const int PapayaWhip = unchecked((int)(0xFFFFEFD5));
        public const int PeachPuff = unchecked((int)(0xFFFFDAB9));
        public const int Peru = unchecked((int)(0xFFCD853F));
        public const int Pink = unchecked((int)(0xFFFFC0CB));
        public const int Plum = unchecked((int)(0xFFDDA0DD));
        public const int PowderBlue = unchecked((int)(0xFFB0E0E6));
        public const int Purple = unchecked((int)(0xFF800080));
        public const int Red = unchecked((int)(0xFFFF0000));
        public const int RosyBrown = unchecked((int)(0xFFBC8F8F));
        public const int RoyalBlue = unchecked((int)(0xFF4169E1));
        public const int SaddleBrown = unchecked((int)(0xFF8B4513));
        public const int Salmon = unchecked((int)(0xFFFA8072));
        public const int SandyBrown = unchecked((int)(0xFFF4A460));
        public const int SeaGreen = unchecked((int)(0xFF2E8B57));
        public const int SeaShell = unchecked((int)(0xFFFFF5EE));
        public const int Sienna = unchecked((int)(0xFFA0522D));
        public const int Silver = unchecked((int)(0xFFC0C0C0));
        public const int SkyBlue = unchecked((int)(0xFF87CEEB));
        public const int SlateBlue = unchecked((int)(0xFF6A5ACD));
        public const int SlateGray = unchecked((int)(0xFF708090));
        public const int Snow = unchecked((int)(0xFFFFFAFA));
        public const int SpringGreen = unchecked((int)(0xFF00FF7F));
        public const int SteelBlue = unchecked((int)(0xFF4682B4));
        public const int Tan = unchecked((int)(0xFFD2B48C));
        public const int Teal = unchecked((int)(0xFF008080));
        public const int Thistle = unchecked((int)(0xFFD8BFD8));
        public const int Tomato = unchecked((int)(0xFFFF6347));
        public const int Transparent = 0x00FFFFFF;
        public const int Turquoise = unchecked((int)(0xFF40E0D0));
        public const int Violet = unchecked((int)(0xFFEE82EE));
        public const int Wheat = unchecked((int)(0xFFF5DEB3));
        public const int White = unchecked((int)(0xFFFFFFFF));
        public const int WhiteSmoke = unchecked((int)(0xFFF5F5F5));
        public const int Yellow = unchecked((int)(0xFFFFFF00));
        public const int YellowGreen = unchecked((int)(0xFF9ACD32));

        public const int AlphaShift = 24;
        public const int RedShift = 16;
        public const int GreenShift = 8;
        public const int BlueShift = 0;

        public const int AlphaMask = unchecked((int)(0xff000000));
        public const int RedMask = 0x00ff0000;
        public const int GreenMask = 0x0000ff00;
        public const int BlueMask = 0x000000ff;
    }
}
