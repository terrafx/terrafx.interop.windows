// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceCapabilitiesA"]/*' />
    [DllImport("winspool.drv", ExactSpelling = true)]
    public static extern int DeviceCapabilitiesA([NativeTypeName("LPCSTR")] sbyte* pDevice, [NativeTypeName("LPCSTR")] sbyte* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPSTR")] sbyte* pOutput, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pDevMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceCapabilitiesW"]/*' />
    [DllImport("winspool.drv", ExactSpelling = true)]
    public static extern int DeviceCapabilitiesW([NativeTypeName("LPCWSTR")] char* pDevice, [NativeTypeName("LPCWSTR")] char* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPWSTR")] char* pOutput, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pDevMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceCapabilities"]/*' />
    [NativeTypeName("#define DeviceCapabilities DeviceCapabilitiesW")]
    public static delegate*<char*, char*, ushort, char*, DEVMODEW*, int> DeviceCapabilities => &DeviceCapabilitiesW;

    public static HANDLE HGDI_ERROR => (HANDLE)(-1);

    public const int GDIREGISTERDDRAWPACKETVERSION = 0x1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKEROP4(uint fore, uint back) => ((back << 8) & 0xFF000000) | fore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetKValue(COLORREF cmyk) => unchecked((byte)cmyk.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetYValue(COLORREF cmyk) => unchecked((byte)(cmyk.Value >> 8));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetMValue(COLORREF cmyk) => unchecked((byte)(cmyk.Value >> 16));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetCValue(COLORREF cmyk) => unchecked((byte)(cmyk.Value >> 24));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF CMYK(byte c, byte m, byte y, byte k) => k | ((uint)y << 8) | (((uint)m) << 16) | (((uint)c) << 24);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static POINTS MAKEPOINTS(int l) => *(POINTS*)&l;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF RGB(byte r, byte g, byte b) => r | ((uint)g << 8) | (((uint)b) << 16);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF PALETTERGB(byte r, byte g, byte b) => 0x02000000 | RGB(r, g, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF PALETTEINDEX(ushort i) => 0x01000000 | (uint)i;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetRValue(COLORREF rgb) => unchecked((byte)rgb.Value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetGValue(COLORREF rgb) => unchecked((byte)(rgb.Value >> 8));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetBValue(COLORREF rgb) => unchecked((byte)(rgb.Value >> 16));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_WIDTHBYTES(uint bits) => unchecked(((bits + 31u) & ~31u) / 8u);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_DIBWIDTHBYTES(BITMAPINFOHEADER bi) => GDI_WIDTHBYTES(unchecked((uint)bi.biWidth * bi.biBitCount));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI__DIBSIZE(BITMAPINFOHEADER bi) => unchecked(GDI_DIBWIDTHBYTES(bi) * (uint)bi.biHeight);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_DIBSIZE(BITMAPINFOHEADER bi) => bi.biHeight < 0 ? unchecked(0u - GDI__DIBSIZE(bi)) : GDI__DIBSIZE(bi);
}
