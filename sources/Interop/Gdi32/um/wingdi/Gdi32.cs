// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Gdi32
    {
        private const string LibraryPath = "Gdi32";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddFontResourceA", ExactSpelling = true)]
        public static extern int AddFontResourceA([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddFontResourceW", ExactSpelling = true)]
        public static extern int AddFontResourceW([NativeTypeName("LPCWSTR")] ushort* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AnimatePalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimatePalette([NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("UINT")] uint iStartIndex, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* ppe);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Arc", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Arc([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BitBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BitBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int cx, int cy, [NativeTypeName("HDC")] IntPtr hdcSrc, int x1, int y1, [NativeTypeName("DWORD")] uint rop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CancelDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Chord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Chord([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ChoosePixelFormat", ExactSpelling = true)]
        public static extern int ChoosePixelFormat([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CloseMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CombineRgn", ExactSpelling = true)]
        public static extern int CombineRgn([NativeTypeName("HRGN")] IntPtr hrgnDst, [NativeTypeName("HRGN")] IntPtr hrgnSrc1, [NativeTypeName("HRGN")] IntPtr hrgnSrc2, int iMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileA([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileW([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, [NativeTypeName("UINT")] uint nPlanes, [NativeTypeName("UINT")] uint nBitCount, [NativeTypeName("const void *")] void* lpBits);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateBitmapIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmapIndirect([NativeTypeName("const BITMAP *")] BITMAP* pbm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateBrushIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateBrushIndirect([NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateCompatibleBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateCompatibleBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDiscardableBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDiscardableBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateCompatibleDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateCompatibleDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDCA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCA([NativeTypeName("LPCSTR")] sbyte* pwszDriver, [NativeTypeName("LPCSTR")] sbyte* pwszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDCW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCW([NativeTypeName("LPCWSTR")] ushort* pwszDriver, [NativeTypeName("LPCWSTR")] ushort* pwszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDIBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBitmap([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmih, [NativeTypeName("DWORD")] uint flInit, [NativeTypeName("const void *")] void* pjBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint iUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDIBPatternBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrush([NativeTypeName("HGLOBAL")] IntPtr h, [NativeTypeName("UINT")] uint iUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDIBPatternBrushPt", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrushPt([NativeTypeName("const void *")] void* lpPackedDIB, [NativeTypeName("UINT")] uint iUsage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateEllipticRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateEllipticRgnIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontIndirectA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectA([NativeTypeName("const LOGFONTA *")] LOGFONTA* lplf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontIndirectW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectW([NativeTypeName("const LOGFONTW *")] LOGFONTW* lplf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCSTR")] sbyte* pszFaceName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCWSTR")] ushort* pszFaceName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateHatchBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateHatchBrush(int iHatch, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateICA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICA([NativeTypeName("LPCSTR")] sbyte* pszDriver, [NativeTypeName("LPCSTR")] sbyte* pszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateICW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICW([NativeTypeName("LPCWSTR")] ushort* pszDriver, [NativeTypeName("LPCWSTR")] ushort* pszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileA([NativeTypeName("LPCSTR")] sbyte* pszFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileW([NativeTypeName("LPCWSTR")] ushort* pszFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreatePalette([NativeTypeName("const LOGPALETTE *")] LOGPALETTE* plpal);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePen", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePen(int iStyle, int cWidth, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePenIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePenIndirect([NativeTypeName("const LOGPEN *")] LOGPEN* plpen);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePolyPolygonRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolyPolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, [NativeTypeName("const INT *")] int* pc, int cPoly, int iMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePatternBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreatePatternBrush([NativeTypeName("HBITMAP")] IntPtr hbm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateRectRgnIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateRoundRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateScalableFontResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceA([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCSTR")] sbyte* lpszFont, [NativeTypeName("LPCSTR")] sbyte* lpszFile, [NativeTypeName("LPCSTR")] sbyte* lpszPath);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateScalableFontResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceW([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCWSTR")] ushort* lpszFont, [NativeTypeName("LPCWSTR")] ushort* lpszFile, [NativeTypeName("LPCWSTR")] ushort* lpszPath);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateSolidBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateSolidBrush([NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMetaFile([NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteObject([NativeTypeName("HGDIOBJ")] IntPtr ho);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DescribePixelFormat", ExactSpelling = true)]
        public static extern int DescribePixelFormat([NativeTypeName("HDC")] IntPtr hdc, int iPixelFormat, [NativeTypeName("UINT")] uint nBytes, [NativeTypeName("LPPIXELFORMATDESCRIPTOR")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeviceCapabilitiesA", ExactSpelling = true)]
        public static extern int DeviceCapabilitiesA([NativeTypeName("LPCSTR")] sbyte* pDevice, [NativeTypeName("LPCSTR")] sbyte* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPSTR")] sbyte* pOutput, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pDevMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeviceCapabilitiesW", ExactSpelling = true)]
        public static extern int DeviceCapabilitiesW([NativeTypeName("LPCWSTR")] ushort* pDevice, [NativeTypeName("LPCWSTR")] ushort* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPWSTR")] ushort* pOutput, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pDevMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DrawEscape", ExactSpelling = true)]
        public static extern int DrawEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* lpIn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Ellipse", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Ellipse([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontFamiliesExA", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lpLogfont, [NativeTypeName("FONTENUMPROCA")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontFamiliesExW", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lpLogfont, [NativeTypeName("FONTENUMPROCW")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontFamiliesA", ExactSpelling = true)]
        public static extern int EnumFontFamiliesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontFamiliesW", ExactSpelling = true)]
        public static extern int EnumFontFamiliesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontsA", ExactSpelling = true)]
        public static extern int EnumFontsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumFontsW", ExactSpelling = true)]
        public static extern int EnumFontsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumObjects", ExactSpelling = true)]
        public static extern int EnumObjects([NativeTypeName("HDC")] IntPtr hdc, int nType, [NativeTypeName("GOBJENUMPROC")] IntPtr lpFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EqualRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRgn([NativeTypeName("HRGN")] IntPtr hrgn1, [NativeTypeName("HRGN")] IntPtr hrgn2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Escape", ExactSpelling = true)]
        public static extern int Escape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* pvIn, [NativeTypeName("LPVOID")] void* pvOut);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtEscape", ExactSpelling = true)]
        public static extern int ExtEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjInput, [NativeTypeName("LPCSTR")] sbyte* lpInData, int cjOutput, [NativeTypeName("LPSTR")] sbyte* lpOutData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExcludeClipRect", ExactSpelling = true)]
        public static extern int ExcludeClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtCreateRegion", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr ExtCreateRegion([NativeTypeName("const XFORM *")] XFORM* lpx, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const RGNDATA *")] RGNDATA* lpData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtFloodFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtFloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color, [NativeTypeName("UINT")] uint type);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FillRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FloodFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FrameRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FrameRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr, int w, int h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetROP2", ExactSpelling = true)]
        public static extern int GetROP2([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetAspectRatioFilterEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAspectRatioFilterEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBkColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetBkColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDCBrushColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDCPenColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCPenColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBkMode", ExactSpelling = true)]
        public static extern int GetBkMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBitmapBits", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LONG")] int cb, [NativeTypeName("LPVOID")] void* lpvBits);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBitmapDimensionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBoundsRect", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidthA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidthW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidth32A", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidth32W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidthFloatA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidthFloatW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharABCWidthsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharABCWidthsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharABCWidthsFloatA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharABCWidthsFloatW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipBox", ExactSpelling = true)]
        public static extern int GetClipBox([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClipRgn", ExactSpelling = true)]
        public static extern int GetClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMetaRgn", ExactSpelling = true)]
        public static extern int GetMetaRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetCurrentObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint type);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentPositionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentPositionEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDeviceCaps", ExactSpelling = true)]
        public static extern int GetDeviceCaps([NativeTypeName("HDC")] IntPtr hdc, int index);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDIBits", ExactSpelling = true)]
        public static extern int GetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("LPVOID")] void* lpvBits, [NativeTypeName("LPBITMAPINFO")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint usage);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFontData", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontData([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint dwTable, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cjBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGlyphOutlineA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGlyphOutlineW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGraphicsMode", ExactSpelling = true)]
        public static extern int GetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMapMode", ExactSpelling = true)]
        public static extern int GetMapMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMetaFileBitsEx", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMetaFileBitsEx([NativeTypeName("HMETAFILE")] IntPtr hMF, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("LPVOID")] void* lpData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetNearestColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetNearestColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetNearestPaletteIndex", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetNearestPaletteIndex([NativeTypeName("HPALETTE")] IntPtr h, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetObjectType", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetObjectType([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOutlineTextMetricsA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICA")] OUTLINETEXTMETRICA* potm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetOutlineTextMetricsW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICW")] OUTLINETEXTMETRICW* potm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPixel", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPixelFormat", ExactSpelling = true)]
        public static extern int GetPixelFormat([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPolyFillMode", ExactSpelling = true)]
        public static extern int GetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRasterizerCaps", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRasterizerCaps([NativeTypeName("LPRASTERIZER_STATUS")] RASTERIZER_STATUS* lpraststat, [NativeTypeName("UINT")] uint cjBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRandomRgn", ExactSpelling = true)]
        public static extern int GetRandomRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("INT")] int i);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRegionData", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetRegionData([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("LPRGNDATA")] RGNDATA* lpRgnData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetRgnBox", ExactSpelling = true)]
        public static extern int GetRgnBox([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetStockObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetStockObject(int i);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetStretchBltMode", ExactSpelling = true)]
        public static extern int GetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteEntries([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemPaletteUse", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextCharacterExtra", ExactSpelling = true)]
        public static extern int GetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextAlign", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTextAlign([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetTextColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentPoint32A", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentPoint32W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentExPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentExPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextCharset", ExactSpelling = true)]
        public static extern int GetTextCharset([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextCharsetInfo", ExactSpelling = true)]
        public static extern int GetTextCharsetInfo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPFONTSIGNATURE")] FONTSIGNATURE* lpSig, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TranslateCharsetInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateCharsetInfo([NativeTypeName("DWORD *")] uint* lpSrc, [NativeTypeName("LPCHARSETINFO")] CHARSETINFO* lpCs, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFontLanguageInfo", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontLanguageInfo([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharacterPlacementA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSA")] GCP_RESULTSA* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharacterPlacementW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSW")] GCP_RESULTSW* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFontUnicodeRanges", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontUnicodeRanges([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPGLYPHSET")] GLYPHSET* lpgs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGlyphIndicesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetGlyphIndicesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentPointI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* pgiIn, int cgi, [NativeTypeName("LPSIZE")] SIZE* psize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextExtentExPointI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* lpwszString, int cwchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharWidthI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPINT")] int* piWidths);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCharABCWidthsI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPABC")] ABC* pabc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddFontResourceExA", ExactSpelling = true)]
        public static extern int AddFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddFontResourceExW", ExactSpelling = true)]
        public static extern int AddFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveFontResourceExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveFontResourceExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AddFontMemResourceEx", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr AddFontMemResourceEx([NativeTypeName("PVOID")] void* pFileView, [NativeTypeName("DWORD")] uint cjSize, [NativeTypeName("PVOID")] void* pvResrved, [NativeTypeName("DWORD *")] uint* pNumFonts);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveFontMemResourceEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontMemResourceEx([NativeTypeName("HANDLE")] IntPtr h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontIndirectExA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExA([NativeTypeName("const ENUMLOGFONTEXDVA *")] ENUMLOGFONTEXDVA* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFontIndirectExW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExW([NativeTypeName("const ENUMLOGFONTEXDVW *")] ENUMLOGFONTEXDVW* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IntersectClipRect", ExactSpelling = true)]
        public static extern int IntersectClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InvertRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LineDDA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineDDA(int xStart, int yStart, int xEnd, int yEnd, [NativeTypeName("LINEDDAPROC")] IntPtr lpProc, [NativeTypeName("LPARAM")] nint data);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LineTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineTo([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MaskBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MaskBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int width, int height, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask, [NativeTypeName("DWORD")] uint rop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PlgBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlgBlt([NativeTypeName("HDC")] IntPtr hdcDest, [NativeTypeName("const POINT *")] POINT* lpPoint, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int width, int height, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OffsetClipRgn", ExactSpelling = true)]
        public static extern int OffsetClipRgn([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OffsetRgn", ExactSpelling = true)]
        public static extern int OffsetRgn([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PatBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PatBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int w, int h, [NativeTypeName("DWORD")] uint rop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Pie", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Pie([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PlayMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PaintRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyPolygon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const INT *")] int* asz, int csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PtInRegion", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRegion([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PtVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtVisible([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RectInRegion", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectInRegion([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RectVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectVisible([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Rectangle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Rectangle([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RestoreDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RestoreDC([NativeTypeName("HDC")] IntPtr hdc, int nSavedDC);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ResetDCA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEA *")] DEVMODEA* lpdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ResetDCW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEW *")] DEVMODEW* lpdm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RealizePalette", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealizePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveFontResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveFontResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RoundRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RoundRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ResizePalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResizePalette([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint n);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SaveDC", ExactSpelling = true)]
        public static extern int SaveDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SelectClipRgn", ExactSpelling = true)]
        public static extern int SelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtSelectClipRgn", ExactSpelling = true)]
        public static extern int ExtSelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMetaRgn", ExactSpelling = true)]
        public static extern int SetMetaRgn([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SelectObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr SelectObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SelectPalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr SelectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("BOOL")] int bForceBkgd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBkColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetBkColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDCBrushColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDCPenColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCPenColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBkMode", ExactSpelling = true)]
        public static extern int SetBkMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBitmapBits", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const void *")] void* pvBits);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBoundsRect", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDIBits", ExactSpelling = true)]
        public static extern int SetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDIBitsToDevice", ExactSpelling = true)]
        public static extern int SetDIBitsToDevice([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, [NativeTypeName("DWORD")] uint w, [NativeTypeName("DWORD")] uint h, int xSrc, int ySrc, [NativeTypeName("UINT")] uint StartScan, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpvBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMapperFlags", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetMapperFlags([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetGraphicsMode", ExactSpelling = true)]
        public static extern int SetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMapMode", ExactSpelling = true)]
        public static extern int SetMapMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetLayout", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetLayout([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint l);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLayout", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLayout([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMetaFileBitsEx", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr SetMetaFileBitsEx([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalEntries);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPixel", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPixelV", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelV([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPixelFormat", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelFormat([NativeTypeName("HDC")] IntPtr hdc, int format, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPolyFillMode", ExactSpelling = true)]
        public static extern int SetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StretchBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StretchBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, [NativeTypeName("DWORD")] uint rop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectRgn([NativeTypeName("HRGN")] IntPtr hrgn, int left, int top, int right, int bottom);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StretchDIBits", ExactSpelling = true)]
        public static extern int StretchDIBits([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint iUsage, [NativeTypeName("DWORD")] uint rop);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetROP2", ExactSpelling = true)]
        public static extern int SetROP2([NativeTypeName("HDC")] IntPtr hdc, int rop2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetStretchBltMode", ExactSpelling = true)]
        public static extern int SetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetSystemPaletteUse", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint use);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetTextCharacterExtra", ExactSpelling = true)]
        public static extern int SetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc, int extra);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetTextColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetTextColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetTextAlign", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetTextAlign([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint align);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetTextJustification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTextJustification([NativeTypeName("HDC")] IntPtr hdc, int extra, int count);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateColors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateColors([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiRegisterDdraw", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiRegisterDdraw([NativeTypeName("PGDIREGISTERDDRAWPACKET")] GDIREGISTERDDRAWPACKET* pPacket, [NativeTypeName("GDIMARSHALLOC *")] IntPtr* ppfnGdiAlloc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiMarshalSize", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GdiMarshalSize();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiMarshal", ExactSpelling = true)]
        public static extern void GdiMarshal([NativeTypeName("DWORD")] uint dwProcessIdTo, [NativeTypeName("HGDIOBJ")] IntPtr hGdiObj, [NativeTypeName("PVOID")] void* pData, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiUnmarshal", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GdiUnmarshal([NativeTypeName("PVOID")] void* pData, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AlphaBlend", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TransparentBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GradientFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nMesh, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiAlphaBlend", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiAlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiTransparentBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiTransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiGradientFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiGradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nCount, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PlayMetaFileRecord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* lpHandleTable, [NativeTypeName("LPMETARECORD")] METARECORD* lpMR, [NativeTypeName("UINT")] uint noObjs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf, [NativeTypeName("MFENUMPROC")] IntPtr proc, [NativeTypeName("LPARAM")] nint param3);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CloseEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileA([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CopyEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileW([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* lpDesc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* lpDesc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteEnhMetaFile([NativeTypeName("HENHMETAFILE")] IntPtr hmf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("ENHMFENUMPROC")] IntPtr proc, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hEMF, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPBYTE")] byte* lpData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileDescriptionA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionA([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPSTR")] sbyte* lpDescription);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileDescriptionW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionW([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPWSTR")] ushort* lpDescription);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFileHeader", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileHeader([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPENHMETAHEADER")] ENHMETAHEADER* lpEnhMetaHeader);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFilePaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePaletteEntries([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nNumEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* lpPaletteEntries);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetEnhMetaFilePixelFormat", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePixelFormat([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWinMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWinMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, [NativeTypeName("INT")] int iMapMode, [NativeTypeName("HDC")] IntPtr hdcRef);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PlayEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PlayEnhMetaFileRecord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* pht, [NativeTypeName("const ENHMETARECORD *")] ENHMETARECORD* pmr, [NativeTypeName("UINT")] uint cht);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetEnhMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetEnhMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* pb);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWinMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetWinMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpMeta16Data, [NativeTypeName("HDC")] IntPtr hdcRef, [NativeTypeName("const METAFILEPICT *")] METAFILEPICT* lpMFP);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiComment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiComment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextMetricsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICA")] TEXTMETRICA* lptm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextMetricsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICW")] TEXTMETRICW* lptm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AngleArc", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AngleArc([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("DWORD")] uint r, [NativeTypeName("FLOAT")] float StartAngle, [NativeTypeName("FLOAT")] float SweepAngle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyPolyline", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const DWORD *")] uint* asz, [NativeTypeName("DWORD")] uint csz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPXFORM")] XFORM* lpxf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ModifyWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf, [NativeTypeName("DWORD")] uint mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CombineTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CombineTransform([NativeTypeName("LPXFORM")] XFORM* lpxfOut, [NativeTypeName("const XFORM *")] XFORM* lpxf1, [NativeTypeName("const XFORM *")] XFORM* lpxf2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDIBSection", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBSection([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint usage, [NativeTypeName("void **")] void** ppvBits, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("DWORD")] uint offset);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDIBColorTable", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("RGBQUAD *")] RGBQUAD* prgbq);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDIBColorTable", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const RGBQUAD *")] RGBQUAD* prgbq);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetColorAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const COLORADJUSTMENT *")] COLORADJUSTMENT* lpca);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetColorAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCOLORADJUSTMENT")] COLORADJUSTMENT* lpca);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateHalftonePalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreateHalftonePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StartDocA", ExactSpelling = true)]
        public static extern int StartDocA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOA *")] DOCINFOA* lpdi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StartDocW", ExactSpelling = true)]
        public static extern int StartDocW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOW *")] DOCINFOW* lpdi);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndDoc", ExactSpelling = true)]
        public static extern int EndDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StartPage", ExactSpelling = true)]
        public static extern int StartPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndPage", ExactSpelling = true)]
        public static extern int EndPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AbortDoc", ExactSpelling = true)]
        public static extern int AbortDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetAbortProc", ExactSpelling = true)]
        public static extern int SetAbortProc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ABORTPROC")] IntPtr proc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AbortPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AbortPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ArcTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ArcTo([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "BeginPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BeginPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseFigure", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseFigure([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EndPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FillPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlattenPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlattenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPath", ExactSpelling = true)]
        public static extern int GetPath([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* apt, [NativeTypeName("LPBYTE")] byte* aj, int cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PathToRegion", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr PathToRegion([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyDraw", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyDraw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const BYTE *")] byte* aj, int cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SelectClipPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SelectClipPath([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetArcDirection", ExactSpelling = true)]
        public static extern int SetArcDirection([NativeTypeName("HDC")] IntPtr hdc, int dir);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetMiterLimit", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("FLOAT")] float limit, [NativeTypeName("PFLOAT")] float* old);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StrokeAndFillPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokeAndFillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StrokePath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokePath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WidenPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WidenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtCreatePen", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr ExtCreatePen([NativeTypeName("DWORD")] uint iPenStyle, [NativeTypeName("DWORD")] uint cWidth, [NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush, [NativeTypeName("DWORD")] uint cStyle, [NativeTypeName("const DWORD *")] uint* pstyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetMiterLimit", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PFLOAT")] float* plimit);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetArcDirection", ExactSpelling = true)]
        public static extern int GetArcDirection([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetObjectA", ExactSpelling = true)]
        public static extern int GetObjectA([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetObjectW", ExactSpelling = true)]
        public static extern int GetObjectW([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "MoveToEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveToEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int c);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int c);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtTextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExtTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyTextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTA *")] POLYTEXTA* ppt, int nstrings);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTW *")] POLYTEXTW* ppt, int nstrings);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreatePolygonRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, int cPoint, int iMode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DPtoLP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DPtoLP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LPtoDP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LPtoDP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Polygon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "Polyline", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyBezier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezier([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolyBezierTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezierTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PolylineTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolylineTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OffsetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OffsetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScaleViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int dx, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ScaleWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int xd, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBitmapDimensionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbm, int w, int h, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextFaceA", ExactSpelling = true)]
        public static extern int GetTextFaceA([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPSTR")] sbyte* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTextFaceW", ExactSpelling = true)]
        public static extern int GetTextFaceW([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPWSTR")] ushort* lpName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKerningPairsA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetKerningPairsW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDCOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDCOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FixBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FixBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* ptl);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnrealizeObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnrealizeObject([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiFlush", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiFlush();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiSetBatchLimit", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiSetBatchLimit([NativeTypeName("DWORD")] uint dw);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GdiGetBatchLimit", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiGetBatchLimit();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetICMMode", ExactSpelling = true)]
        public static extern int SetICMMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CheckColorsInGamut", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckColorsInGamut([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRGBTRIPLE")] RGBTRIPLE* lpRGBTriple, [NativeTypeName("LPVOID")] void* dlpBuffer, [NativeTypeName("DWORD")] uint nCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr GetColorSpace([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogColorSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceA([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogColorSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceW([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateColorSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lplcs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateColorSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lplcs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr SetColorSpace([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteColorSpace([NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetICMProfileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPSTR")] sbyte* pszFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetICMProfileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPWSTR")] ushort* pszFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetICMProfileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSTR")] sbyte* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetICMProfileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDeviceGammaRamp", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetDeviceGammaRamp", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ColorMatchToTarget", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorMatchToTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HDC")] IntPtr hdcTarget, [NativeTypeName("DWORD")] uint action);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumICMProfilesA", ExactSpelling = true)]
        public static extern int EnumICMProfilesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCA")] IntPtr proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnumICMProfilesW", ExactSpelling = true)]
        public static extern int EnumICMProfilesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCW")] IntPtr proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateICMRegKeyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyA([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPSTR")] sbyte* lpszCMID, [NativeTypeName("LPSTR")] sbyte* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateICMRegKeyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyW([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPWSTR")] ushort* lpszCMID, [NativeTypeName("LPWSTR")] ushort* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ColorCorrectPalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorCorrectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("DWORD")] uint deFirst, [NativeTypeName("DWORD")] uint num);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglCopyContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglCopyContext([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1, [NativeTypeName("UINT")] uint param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglCreateContext", ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateContext([NativeTypeName("HDC")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglCreateLayerContext", ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateLayerContext([NativeTypeName("HDC")] IntPtr param0, int param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglDeleteContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDeleteContext([NativeTypeName("HGLRC")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglGetCurrentContext", ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglGetCurrentContext();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglGetCurrentDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr wglGetCurrentDC();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglGetProcAddress", ExactSpelling = true)]
        [return: NativeTypeName("PROC")]
        public static extern IntPtr wglGetProcAddress([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglMakeCurrent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglMakeCurrent([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglShareLists", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglShareLists([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglUseFontBitmapsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglUseFontBitmapsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SwapBuffers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapBuffers([NativeTypeName("HDC")] IntPtr param0);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglUseFontOutlinesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglUseFontOutlinesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglDescribeLayerPlane", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDescribeLayerPlane([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, [NativeTypeName("UINT")] uint param3, [NativeTypeName("LPLAYERPLANEDESCRIPTOR")] LAYERPLANEDESCRIPTOR* param4);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglSetLayerPaletteEntries", ExactSpelling = true)]
        public static extern int wglSetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("const COLORREF *")] uint* param4);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglGetLayerPaletteEntries", ExactSpelling = true)]
        public static extern int wglGetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("COLORREF *")] uint* param4);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglRealizeLayerPalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglRealizeLayerPalette([NativeTypeName("HDC")] IntPtr param0, int param1, [NativeTypeName("BOOL")] int param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglSwapLayerBuffers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglSwapLayerBuffers([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("UINT")] uint param1);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "wglSwapMultipleBuffers", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint wglSwapMultipleBuffers([NativeTypeName("UINT")] uint param0, [NativeTypeName("const WGLSWAP *")] WGLSWAP* param1);
    }
}
