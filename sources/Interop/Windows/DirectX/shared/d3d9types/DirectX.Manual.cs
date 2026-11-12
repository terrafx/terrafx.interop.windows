// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using static TerraFX.Interop.DirectX.D3DDECLTYPE;

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    public static uint D3DCOLOR_ARGB(uint a, uint r, uint g, uint b)
        => ((a & 0xFF) << 24) | ((r & 0xFF) << 16) | ((g & 0xFF) << 8) | (b & 0xFF);

    public static uint D3DCOLOR_RGBA(uint r, uint g, uint b, uint a)
        => D3DCOLOR_ARGB(a, r, g, b);

    public static uint D3DCOLOR_XRGB(uint r, uint g, uint b)
        => D3DCOLOR_ARGB(0xFF, r, g, b);

    public static uint D3DCOLOR_XYUV(uint y, uint u, uint v)
        => D3DCOLOR_ARGB(0xFF, y, u, v);

    public static uint D3DCOLOR_AYUV(uint a, uint y, uint u, uint v)
        => D3DCOLOR_ARGB(a, y, u, v);

    public static uint D3DCOLOR_COLORVALUE(float r, float g, float b, float a)
        => D3DCOLOR_RGBA(unchecked((uint)(r * 255.0f)), unchecked((uint)(g * 255.0f)), unchecked((uint)(b * 255.0f)), unchecked((uint)(a * 255.0f)));

    public static D3DVERTEXELEMENT9 D3DDECL_END()
        => new()
        {
            Stream = 0xFF,
            Offset = 0,
            Type = (byte)(D3DDECLTYPE_UNUSED),
            Method = 0,
            Usage = 0,
            UsageIndex = 0,
        };
}
