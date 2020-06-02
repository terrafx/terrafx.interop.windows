// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gdi32", EntryPoint = "AddFontResourceA", ExactSpelling = true)]
        public static extern int AddFontResourceA([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("gdi32", EntryPoint = "AddFontResourceW", ExactSpelling = true)]
        public static extern int AddFontResourceW([NativeTypeName("LPCWSTR")] ushort* param0);

        [DllImport("gdi32", EntryPoint = "AnimatePalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimatePalette([NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("UINT")] uint iStartIndex, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* ppe);

        [DllImport("gdi32", EntryPoint = "Arc", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Arc([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32", EntryPoint = "BitBlt", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BitBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int cx, int cy, [NativeTypeName("HDC")] IntPtr hdcSrc, int x1, int y1, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", EntryPoint = "CancelDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "Chord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Chord([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32", EntryPoint = "ChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
        public static extern int ChoosePixelFormat([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", EntryPoint = "CloseMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CloseMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "CombineRgn", ExactSpelling = true)]
        public static extern int CombineRgn([NativeTypeName("HRGN")] IntPtr hrgnDst, [NativeTypeName("HRGN")] IntPtr hrgnSrc1, [NativeTypeName("HRGN")] IntPtr hrgnSrc2, int iMode);

        [DllImport("gdi32", EntryPoint = "CopyMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileA([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("gdi32", EntryPoint = "CopyMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileW([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport("gdi32", EntryPoint = "CreateBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, [NativeTypeName("UINT")] uint nPlanes, [NativeTypeName("UINT")] uint nBitCount, [NativeTypeName("const void *")] void* lpBits);

        [DllImport("gdi32", EntryPoint = "CreateBitmapIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmapIndirect([NativeTypeName("const BITMAP *")] BITMAP* pbm);

        [DllImport("gdi32", EntryPoint = "CreateBrushIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateBrushIndirect([NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush);

        [DllImport("gdi32", EntryPoint = "CreateCompatibleBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateCompatibleBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport("gdi32", EntryPoint = "CreateDiscardableBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDiscardableBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport("gdi32", EntryPoint = "CreateCompatibleDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateCompatibleDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "CreateDCA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCA([NativeTypeName("LPCSTR")] sbyte* pwszDriver, [NativeTypeName("LPCSTR")] sbyte* pwszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport("gdi32", EntryPoint = "CreateDCW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCW([NativeTypeName("LPCWSTR")] ushort* pwszDriver, [NativeTypeName("LPCWSTR")] ushort* pwszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport("gdi32", EntryPoint = "CreateDIBitmap", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBitmap([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmih, [NativeTypeName("DWORD")] uint flInit, [NativeTypeName("const void *")] void* pjBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", EntryPoint = "CreateDIBPatternBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrush([NativeTypeName("HGLOBAL")] IntPtr h, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", EntryPoint = "CreateDIBPatternBrushPt", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrushPt([NativeTypeName("const void *")] void* lpPackedDIB, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", EntryPoint = "CreateEllipticRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32", EntryPoint = "CreateEllipticRgnIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "CreateFontIndirectA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectA([NativeTypeName("const LOGFONTA *")] LOGFONTA* lplf);

        [DllImport("gdi32", EntryPoint = "CreateFontIndirectW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectW([NativeTypeName("const LOGFONTW *")] LOGFONTW* lplf);

        [DllImport("gdi32", EntryPoint = "CreateFontA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCSTR")] sbyte* pszFaceName);

        [DllImport("gdi32", EntryPoint = "CreateFontW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCWSTR")] ushort* pszFaceName);

        [DllImport("gdi32", EntryPoint = "CreateHatchBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateHatchBrush(int iHatch, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "CreateICA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICA([NativeTypeName("LPCSTR")] sbyte* pszDriver, [NativeTypeName("LPCSTR")] sbyte* pszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport("gdi32", EntryPoint = "CreateICW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICW([NativeTypeName("LPCWSTR")] ushort* pszDriver, [NativeTypeName("LPCWSTR")] ushort* pszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport("gdi32", EntryPoint = "CreateMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileA([NativeTypeName("LPCSTR")] sbyte* pszFile);

        [DllImport("gdi32", EntryPoint = "CreateMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileW([NativeTypeName("LPCWSTR")] ushort* pszFile);

        [DllImport("gdi32", EntryPoint = "CreatePalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreatePalette([NativeTypeName("const LOGPALETTE *")] LOGPALETTE* plpal);

        [DllImport("gdi32", EntryPoint = "CreatePen", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePen(int iStyle, int cWidth, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "CreatePenIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePenIndirect([NativeTypeName("const LOGPEN *")] LOGPEN* plpen);

        [DllImport("gdi32", EntryPoint = "CreatePolyPolygonRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolyPolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, [NativeTypeName("const INT *")] int* pc, int cPoly, int iMode);

        [DllImport("gdi32", EntryPoint = "CreatePatternBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreatePatternBrush([NativeTypeName("HBITMAP")] IntPtr hbm);

        [DllImport("gdi32", EntryPoint = "CreateRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32", EntryPoint = "CreateRectRgnIndirect", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "CreateRoundRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

        [DllImport("gdi32", EntryPoint = "CreateScalableFontResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceA([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCSTR")] sbyte* lpszFont, [NativeTypeName("LPCSTR")] sbyte* lpszFile, [NativeTypeName("LPCSTR")] sbyte* lpszPath);

        [DllImport("gdi32", EntryPoint = "CreateScalableFontResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceW([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCWSTR")] ushort* lpszFont, [NativeTypeName("LPCWSTR")] ushort* lpszFile, [NativeTypeName("LPCWSTR")] ushort* lpszPath);

        [DllImport("gdi32", EntryPoint = "CreateSolidBrush", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateSolidBrush([NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "DeleteDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "DeleteMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMetaFile([NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", EntryPoint = "DeleteObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteObject([NativeTypeName("HGDIOBJ")] IntPtr ho);

        [DllImport("gdi32", EntryPoint = "DescribePixelFormat", ExactSpelling = true, SetLastError = true)]
        public static extern int DescribePixelFormat([NativeTypeName("HDC")] IntPtr hdc, int iPixelFormat, [NativeTypeName("UINT")] uint nBytes, [NativeTypeName("LPPIXELFORMATDESCRIPTOR")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", EntryPoint = "DeviceCapabilitiesA", ExactSpelling = true)]
        public static extern int DeviceCapabilitiesA([NativeTypeName("LPCSTR")] sbyte* pDevice, [NativeTypeName("LPCSTR")] sbyte* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPSTR")] sbyte* pOutput, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pDevMode);

        [DllImport("gdi32", EntryPoint = "DeviceCapabilitiesW", ExactSpelling = true)]
        public static extern int DeviceCapabilitiesW([NativeTypeName("LPCWSTR")] ushort* pDevice, [NativeTypeName("LPCWSTR")] ushort* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPWSTR")] ushort* pOutput, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pDevMode);

        [DllImport("gdi32", EntryPoint = "DrawEscape", ExactSpelling = true)]
        public static extern int DrawEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* lpIn);

        [DllImport("gdi32", EntryPoint = "Ellipse", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Ellipse([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", EntryPoint = "EnumFontFamiliesExA", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* stdcall<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "EnumFontFamiliesExW", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* stdcall<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "EnumFontFamiliesA", ExactSpelling = true)]
        public static extern int EnumFontFamiliesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* stdcall<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", EntryPoint = "EnumFontFamiliesW", ExactSpelling = true)]
        public static extern int EnumFontFamiliesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* stdcall<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", EntryPoint = "EnumFontsA", ExactSpelling = true)]
        public static extern int EnumFontsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* stdcall<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", EntryPoint = "EnumFontsW", ExactSpelling = true)]
        public static extern int EnumFontsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* stdcall<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", EntryPoint = "EnumObjects", ExactSpelling = true)]
        public static extern int EnumObjects([NativeTypeName("HDC")] IntPtr hdc, int nType, [NativeTypeName("GOBJENUMPROC")] delegate* stdcall<void*, nint, int> lpFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", EntryPoint = "EqualRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRgn([NativeTypeName("HRGN")] IntPtr hrgn1, [NativeTypeName("HRGN")] IntPtr hrgn2);

        [DllImport("gdi32", EntryPoint = "Escape", ExactSpelling = true)]
        public static extern int Escape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* pvIn, [NativeTypeName("LPVOID")] void* pvOut);

        [DllImport("gdi32", EntryPoint = "ExtEscape", ExactSpelling = true)]
        public static extern int ExtEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjInput, [NativeTypeName("LPCSTR")] sbyte* lpInData, int cjOutput, [NativeTypeName("LPSTR")] sbyte* lpOutData);

        [DllImport("gdi32", EntryPoint = "ExcludeClipRect", ExactSpelling = true)]
        public static extern int ExcludeClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", EntryPoint = "ExtCreateRegion", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr ExtCreateRegion([NativeTypeName("const XFORM *")] XFORM* lpx, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const RGNDATA *")] RGNDATA* lpData);

        [DllImport("gdi32", EntryPoint = "ExtFloodFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtFloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color, [NativeTypeName("UINT")] uint type);

        [DllImport("gdi32", EntryPoint = "FillRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("gdi32", EntryPoint = "FloodFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "FrameRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FrameRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr, int w, int h);

        [DllImport("gdi32", EntryPoint = "GetROP2", ExactSpelling = true)]
        public static extern int GetROP2([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetAspectRatioFilterEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAspectRatioFilterEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", EntryPoint = "GetBkColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetBkColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetDCBrushColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetDCPenColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCPenColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetBkMode", ExactSpelling = true)]
        public static extern int GetBkMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetBitmapBits", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LONG")] int cb, [NativeTypeName("LPVOID")] void* lpvBits);

        [DllImport("gdi32", EntryPoint = "GetBitmapDimensionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", EntryPoint = "GetBoundsRect", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("gdi32", EntryPoint = "GetBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "GetCharWidthA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharWidthW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharWidth32A", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharWidth32W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharWidthFloatA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharWidthFloatW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32", EntryPoint = "GetCharABCWidthsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport("gdi32", EntryPoint = "GetCharABCWidthsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport("gdi32", EntryPoint = "GetCharABCWidthsFloatA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport("gdi32", EntryPoint = "GetCharABCWidthsFloatW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport("gdi32", EntryPoint = "GetClipBox", ExactSpelling = true)]
        public static extern int GetClipBox([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "GetClipRgn", ExactSpelling = true)]
        public static extern int GetClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", EntryPoint = "GetMetaRgn", ExactSpelling = true)]
        public static extern int GetMetaRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", EntryPoint = "GetCurrentObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetCurrentObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint type);

        [DllImport("gdi32", EntryPoint = "GetCurrentPositionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentPositionEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "GetDeviceCaps", ExactSpelling = true)]
        public static extern int GetDeviceCaps([NativeTypeName("HDC")] IntPtr hdc, int index);

        [DllImport("gdi32", EntryPoint = "GetDIBits", ExactSpelling = true)]
        public static extern int GetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("LPVOID")] void* lpvBits, [NativeTypeName("LPBITMAPINFO")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint usage);

        [DllImport("gdi32", EntryPoint = "GetFontData", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontData([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint dwTable, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cjBuffer);

        [DllImport("gdi32", EntryPoint = "GetGlyphOutlineA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport("gdi32", EntryPoint = "GetGlyphOutlineW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport("gdi32", EntryPoint = "GetGraphicsMode", ExactSpelling = true)]
        public static extern int GetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetMapMode", ExactSpelling = true)]
        public static extern int GetMapMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetMetaFileBitsEx", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMetaFileBitsEx([NativeTypeName("HMETAFILE")] IntPtr hMF, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("LPVOID")] void* lpData);

        [DllImport("gdi32", EntryPoint = "GetMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32", EntryPoint = "GetMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("gdi32", EntryPoint = "GetNearestColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetNearestColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "GetNearestPaletteIndex", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetNearestPaletteIndex([NativeTypeName("HPALETTE")] IntPtr h, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "GetObjectType", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetObjectType([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", EntryPoint = "GetOutlineTextMetricsA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICA")] OUTLINETEXTMETRICA* potm);

        [DllImport("gdi32", EntryPoint = "GetOutlineTextMetricsW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICW")] OUTLINETEXTMETRICW* potm);

        [DllImport("gdi32", EntryPoint = "GetPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", EntryPoint = "GetPixel", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", EntryPoint = "GetPixelFormat", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPixelFormat([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetPolyFillMode", ExactSpelling = true)]
        public static extern int GetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetRasterizerCaps", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRasterizerCaps([NativeTypeName("LPRASTERIZER_STATUS")] RASTERIZER_STATUS* lpraststat, [NativeTypeName("UINT")] uint cjBytes);

        [DllImport("gdi32", EntryPoint = "GetRandomRgn", ExactSpelling = true)]
        public static extern int GetRandomRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("INT")] int i);

        [DllImport("gdi32", EntryPoint = "GetRegionData", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetRegionData([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("LPRGNDATA")] RGNDATA* lpRgnData);

        [DllImport("gdi32", EntryPoint = "GetRgnBox", ExactSpelling = true)]
        public static extern int GetRgnBox([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("gdi32", EntryPoint = "GetStockObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetStockObject(int i);

        [DllImport("gdi32", EntryPoint = "GetStretchBltMode", ExactSpelling = true)]
        public static extern int GetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetSystemPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteEntries([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", EntryPoint = "GetSystemPaletteUse", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetTextCharacterExtra", ExactSpelling = true)]
        public static extern int GetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetTextAlign", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTextAlign([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetTextColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetTextColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetTextExtentPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "GetTextExtentPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "GetTextExtentPoint32A", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32", EntryPoint = "GetTextExtentPoint32W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32", EntryPoint = "GetTextExtentExPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", EntryPoint = "GetTextExtentExPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", EntryPoint = "GetTextCharset", ExactSpelling = true)]
        public static extern int GetTextCharset([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetTextCharsetInfo", ExactSpelling = true)]
        public static extern int GetTextCharsetInfo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPFONTSIGNATURE")] FONTSIGNATURE* lpSig, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "TranslateCharsetInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateCharsetInfo([NativeTypeName("DWORD *")] uint* lpSrc, [NativeTypeName("LPCHARSETINFO")] CHARSETINFO* lpCs, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "GetFontLanguageInfo", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontLanguageInfo([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetCharacterPlacementA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSA")] GCP_RESULTSA* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "GetCharacterPlacementW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSW")] GCP_RESULTSW* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", EntryPoint = "GetFontUnicodeRanges", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontUnicodeRanges([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPGLYPHSET")] GLYPHSET* lpgs);

        [DllImport("gdi32", EntryPoint = "GetGlyphIndices", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndices([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32", EntryPoint = "GetGlyphIndicesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32", EntryPoint = "GetTextExtentPointI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* pgiIn, int cgi, [NativeTypeName("LPSIZE")] SIZE* psize);

        [DllImport("gdi32", EntryPoint = "GetTextExtentExPointI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* lpwszString, int cwchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", EntryPoint = "GetCharWidthI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPINT")] int* piWidths);

        [DllImport("gdi32", EntryPoint = "GetCharABCWidthsI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPABC")] ABC* pabc);

        [DllImport("gdi32", EntryPoint = "AddFontResourceExA", ExactSpelling = true)]
        public static extern int AddFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32", EntryPoint = "AddFontResourceExW", ExactSpelling = true)]
        public static extern int AddFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32", EntryPoint = "RemoveFontResourceExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32", EntryPoint = "RemoveFontResourceExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32", EntryPoint = "AddFontMemResourceEx", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr AddFontMemResourceEx([NativeTypeName("PVOID")] void* pFileView, [NativeTypeName("DWORD")] uint cjSize, [NativeTypeName("PVOID")] void* pvResrved, [NativeTypeName("DWORD *")] uint* pNumFonts);

        [DllImport("gdi32", EntryPoint = "RemoveFontMemResourceEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontMemResourceEx([NativeTypeName("HANDLE")] IntPtr h);

        [DllImport("gdi32", EntryPoint = "CreateFontIndirectExA", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExA([NativeTypeName("const ENUMLOGFONTEXDVA *")] ENUMLOGFONTEXDVA* param0);

        [DllImport("gdi32", EntryPoint = "CreateFontIndirectExW", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExW([NativeTypeName("const ENUMLOGFONTEXDVW *")] ENUMLOGFONTEXDVW* param0);

        [DllImport("gdi32", EntryPoint = "GetViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", EntryPoint = "GetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32", EntryPoint = "GetWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", EntryPoint = "GetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32", EntryPoint = "IntersectClipRect", ExactSpelling = true)]
        public static extern int IntersectClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", EntryPoint = "InvertRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", EntryPoint = "LineDDA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineDDA(int xStart, int yStart, int xEnd, int yEnd, [NativeTypeName("LINEDDAPROC")] delegate* stdcall<int, int, nint, void> lpProc, [NativeTypeName("LPARAM")] nint data);

        [DllImport("gdi32", EntryPoint = "LineTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineTo([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", EntryPoint = "MaskBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MaskBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int width, int height, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", EntryPoint = "PlgBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlgBlt([NativeTypeName("HDC")] IntPtr hdcDest, [NativeTypeName("const POINT *")] POINT* lpPoint, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int width, int height, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask);

        [DllImport("gdi32", EntryPoint = "OffsetClipRgn", ExactSpelling = true)]
        public static extern int OffsetClipRgn([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", EntryPoint = "OffsetRgn", ExactSpelling = true)]
        public static extern int OffsetRgn([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport("gdi32", EntryPoint = "PatBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PatBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int w, int h, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", EntryPoint = "Pie", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Pie([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32", EntryPoint = "PlayMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", EntryPoint = "PaintRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", EntryPoint = "PolyPolygon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const INT *")] int* asz, int csz);

        [DllImport("gdi32", EntryPoint = "PtInRegion", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRegion([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport("gdi32", EntryPoint = "PtVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtVisible([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", EntryPoint = "RectInRegion", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectInRegion([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "RectVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectVisible([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "Rectangle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Rectangle([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", EntryPoint = "RestoreDC", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RestoreDC([NativeTypeName("HDC")] IntPtr hdc, int nSavedDC);

        [DllImport("gdi32", EntryPoint = "ResetDCA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEA *")] DEVMODEA* lpdm);

        [DllImport("gdi32", EntryPoint = "ResetDCW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEW *")] DEVMODEW* lpdm);

        [DllImport("gdi32", EntryPoint = "RealizePalette", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealizePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "RemoveFontResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32", EntryPoint = "RemoveFontResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("gdi32", EntryPoint = "RoundRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RoundRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);

        [DllImport("gdi32", EntryPoint = "ResizePalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResizePalette([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint n);

        [DllImport("gdi32", EntryPoint = "SaveDC", ExactSpelling = true)]
        public static extern int SaveDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "SelectClipRgn", ExactSpelling = true)]
        public static extern int SelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", EntryPoint = "ExtSelectClipRgn", ExactSpelling = true)]
        public static extern int ExtSelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, int mode);

        [DllImport("gdi32", EntryPoint = "SetMetaRgn", ExactSpelling = true)]
        public static extern int SetMetaRgn([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "SelectObject", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr SelectObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", EntryPoint = "SelectPalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr SelectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("BOOL")] int bForceBkgd);

        [DllImport("gdi32", EntryPoint = "SetBkColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetBkColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetDCBrushColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetDCPenColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCPenColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetBkMode", ExactSpelling = true)]
        public static extern int SetBkMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", EntryPoint = "SetBitmapBits", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const void *")] void* pvBits);

        [DllImport("gdi32", EntryPoint = "SetBoundsRect", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("gdi32", EntryPoint = "SetDIBits", ExactSpelling = true)]
        public static extern int SetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport("gdi32", EntryPoint = "SetDIBitsToDevice", ExactSpelling = true)]
        public static extern int SetDIBitsToDevice([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, [NativeTypeName("DWORD")] uint w, [NativeTypeName("DWORD")] uint h, int xSrc, int ySrc, [NativeTypeName("UINT")] uint StartScan, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpvBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport("gdi32", EntryPoint = "SetMapperFlags", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetMapperFlags([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint flags);

        [DllImport("gdi32", EntryPoint = "SetGraphicsMode", ExactSpelling = true)]
        public static extern int SetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport("gdi32", EntryPoint = "SetMapMode", ExactSpelling = true)]
        public static extern int SetMapMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport("gdi32", EntryPoint = "SetLayout", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetLayout([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint l);

        [DllImport("gdi32", EntryPoint = "GetLayout", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLayout([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "SetMetaFileBitsEx", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr SetMetaFileBitsEx([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32", EntryPoint = "SetPaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", EntryPoint = "SetPixel", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetPixelV", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelV([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetPixelFormat", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelFormat([NativeTypeName("HDC")] IntPtr hdc, int format, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", EntryPoint = "SetPolyFillMode", ExactSpelling = true)]
        public static extern int SetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", EntryPoint = "StretchBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StretchBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", EntryPoint = "SetRectRgn", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectRgn([NativeTypeName("HRGN")] IntPtr hrgn, int left, int top, int right, int bottom);

        [DllImport("gdi32", EntryPoint = "StretchDIBits", ExactSpelling = true)]
        public static extern int StretchDIBits([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint iUsage, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", EntryPoint = "SetROP2", ExactSpelling = true)]
        public static extern int SetROP2([NativeTypeName("HDC")] IntPtr hdc, int rop2);

        [DllImport("gdi32", EntryPoint = "SetStretchBltMode", ExactSpelling = true)]
        public static extern int SetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", EntryPoint = "SetSystemPaletteUse", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint use);

        [DllImport("gdi32", EntryPoint = "SetTextCharacterExtra", ExactSpelling = true)]
        public static extern int SetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc, int extra);

        [DllImport("gdi32", EntryPoint = "SetTextColor", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetTextColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", EntryPoint = "SetTextAlign", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetTextAlign([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint align);

        [DllImport("gdi32", EntryPoint = "SetTextJustification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTextJustification([NativeTypeName("HDC")] IntPtr hdc, int extra, int count);

        [DllImport("gdi32", EntryPoint = "UpdateColors", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateColors([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("msimg32", EntryPoint = "AlphaBlend", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport("msimg32", EntryPoint = "TransparentBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport("msimg32", EntryPoint = "GradientFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nMesh, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32", EntryPoint = "GdiAlphaBlend", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiAlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport("gdi32", EntryPoint = "GdiTransparentBlt", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiTransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport("gdi32", EntryPoint = "GdiGradientFill", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiGradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nCount, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32", EntryPoint = "PlayMetaFileRecord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* lpHandleTable, [NativeTypeName("LPMETARECORD")] METARECORD* lpMR, [NativeTypeName("UINT")] uint noObjs);

        [DllImport("gdi32", EntryPoint = "EnumMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf, [NativeTypeName("MFENUMPROC")] delegate* stdcall<IntPtr, HANDLETABLE*, METARECORD*, int, nint, int> proc, [NativeTypeName("LPARAM")] nint param3);

        [DllImport("gdi32", EntryPoint = "CloseEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CloseEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "CopyEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileA([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32", EntryPoint = "CopyEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileW([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("gdi32", EntryPoint = "CreateEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* lpDesc);

        [DllImport("gdi32", EntryPoint = "CreateEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* lpDesc);

        [DllImport("gdi32", EntryPoint = "DeleteEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteEnhMetaFile([NativeTypeName("HENHMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", EntryPoint = "EnumEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("ENHMFENUMPROC")] delegate* stdcall<IntPtr, HANDLETABLE*, ENHMETARECORD*, int, nint, int> proc, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileA", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileW", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hEMF, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPBYTE")] byte* lpData);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileDescriptionA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionA([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPSTR")] sbyte* lpDescription);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileDescriptionW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionW([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPWSTR")] ushort* lpDescription);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFileHeader", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileHeader([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPENHMETAHEADER")] ENHMETAHEADER* lpEnhMetaHeader);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFilePaletteEntries", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePaletteEntries([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nNumEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* lpPaletteEntries);

        [DllImport("gdi32", EntryPoint = "GetEnhMetaFilePixelFormat", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePixelFormat([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", EntryPoint = "GetWinMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWinMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, [NativeTypeName("INT")] int iMapMode, [NativeTypeName("HDC")] IntPtr hdcRef);

        [DllImport("gdi32", EntryPoint = "PlayEnhMetaFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", EntryPoint = "PlayEnhMetaFileRecord", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* pht, [NativeTypeName("const ENHMETARECORD *")] ENHMETARECORD* pmr, [NativeTypeName("UINT")] uint cht);

        [DllImport("gdi32", EntryPoint = "SetEnhMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetEnhMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* pb);

        [DllImport("gdi32", EntryPoint = "SetWinMetaFileBits", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetWinMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpMeta16Data, [NativeTypeName("HDC")] IntPtr hdcRef, [NativeTypeName("const METAFILEPICT *")] METAFILEPICT* lpMFP);

        [DllImport("gdi32", EntryPoint = "GdiComment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiComment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32", EntryPoint = "GetTextMetricsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICA")] TEXTMETRICA* lptm);

        [DllImport("gdi32", EntryPoint = "GetTextMetricsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICW")] TEXTMETRICW* lptm);

        [DllImport("gdi32", EntryPoint = "AngleArc", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AngleArc([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("DWORD")] uint r, [NativeTypeName("FLOAT")] float StartAngle, [NativeTypeName("FLOAT")] float SweepAngle);

        [DllImport("gdi32", EntryPoint = "PolyPolyline", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const DWORD *")] uint* asz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("gdi32", EntryPoint = "GetWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPXFORM")] XFORM* lpxf);

        [DllImport("gdi32", EntryPoint = "SetWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf);

        [DllImport("gdi32", EntryPoint = "ModifyWorldTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf, [NativeTypeName("DWORD")] uint mode);

        [DllImport("gdi32", EntryPoint = "CombineTransform", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CombineTransform([NativeTypeName("LPXFORM")] XFORM* lpxfOut, [NativeTypeName("const XFORM *")] XFORM* lpxf1, [NativeTypeName("const XFORM *")] XFORM* lpxf2);

        [DllImport("gdi32", EntryPoint = "CreateDIBSection", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBSection([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint usage, [NativeTypeName("void **")] void** ppvBits, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("DWORD")] uint offset);

        [DllImport("gdi32", EntryPoint = "GetDIBColorTable", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("RGBQUAD *")] RGBQUAD* prgbq);

        [DllImport("gdi32", EntryPoint = "SetDIBColorTable", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const RGBQUAD *")] RGBQUAD* prgbq);

        [DllImport("gdi32", EntryPoint = "SetColorAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const COLORADJUSTMENT *")] COLORADJUSTMENT* lpca);

        [DllImport("gdi32", EntryPoint = "GetColorAdjustment", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCOLORADJUSTMENT")] COLORADJUSTMENT* lpca);

        [DllImport("gdi32", EntryPoint = "CreateHalftonePalette", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreateHalftonePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "StartDocA", ExactSpelling = true)]
        public static extern int StartDocA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOA *")] DOCINFOA* lpdi);

        [DllImport("gdi32", EntryPoint = "StartDocW", ExactSpelling = true)]
        public static extern int StartDocW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOW *")] DOCINFOW* lpdi);

        [DllImport("gdi32", EntryPoint = "EndDoc", ExactSpelling = true)]
        public static extern int EndDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "StartPage", ExactSpelling = true)]
        public static extern int StartPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "EndPage", ExactSpelling = true)]
        public static extern int EndPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "AbortDoc", ExactSpelling = true)]
        public static extern int AbortDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "SetAbortProc", ExactSpelling = true)]
        public static extern int SetAbortProc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ABORTPROC")] delegate* stdcall<IntPtr, int, int> proc);

        [DllImport("gdi32", EntryPoint = "AbortPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AbortPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "ArcTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ArcTo([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32", EntryPoint = "BeginPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BeginPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "CloseFigure", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseFigure([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "EndPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "FillPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "FlattenPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlattenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetPath", ExactSpelling = true)]
        public static extern int GetPath([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* apt, [NativeTypeName("LPBYTE")] byte* aj, int cpt);

        [DllImport("gdi32", EntryPoint = "PathToRegion", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr PathToRegion([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "PolyDraw", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyDraw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const BYTE *")] byte* aj, int cpt);

        [DllImport("gdi32", EntryPoint = "SelectClipPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SelectClipPath([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", EntryPoint = "SetArcDirection", ExactSpelling = true)]
        public static extern int SetArcDirection([NativeTypeName("HDC")] IntPtr hdc, int dir);

        [DllImport("gdi32", EntryPoint = "SetMiterLimit", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("FLOAT")] float limit, [NativeTypeName("PFLOAT")] float* old);

        [DllImport("gdi32", EntryPoint = "StrokeAndFillPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokeAndFillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "StrokePath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokePath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "WidenPath", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WidenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "ExtCreatePen", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr ExtCreatePen([NativeTypeName("DWORD")] uint iPenStyle, [NativeTypeName("DWORD")] uint cWidth, [NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush, [NativeTypeName("DWORD")] uint cStyle, [NativeTypeName("const DWORD *")] uint* pstyle);

        [DllImport("gdi32", EntryPoint = "GetMiterLimit", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PFLOAT")] float* plimit);

        [DllImport("gdi32", EntryPoint = "GetArcDirection", ExactSpelling = true)]
        public static extern int GetArcDirection([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetObjectA", ExactSpelling = true)]
        public static extern int GetObjectA([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32", EntryPoint = "GetObjectW", ExactSpelling = true)]
        public static extern int GetObjectW([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32", EntryPoint = "MoveToEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveToEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "TextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int c);

        [DllImport("gdi32", EntryPoint = "TextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int c);

        [DllImport("gdi32", EntryPoint = "ExtTextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32", EntryPoint = "ExtTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32", EntryPoint = "PolyTextOutA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTA *")] POLYTEXTA* ppt, int nstrings);

        [DllImport("gdi32", EntryPoint = "PolyTextOutW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTW *")] POLYTEXTW* ppt, int nstrings);

        [DllImport("gdi32", EntryPoint = "CreatePolygonRgn", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, int cPoint, int iMode);

        [DllImport("gdi32", EntryPoint = "DPtoLP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DPtoLP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32", EntryPoint = "LPtoDP", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LPtoDP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32", EntryPoint = "Polygon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32", EntryPoint = "Polyline", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32", EntryPoint = "PolyBezier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezier([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", EntryPoint = "PolyBezierTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezierTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", EntryPoint = "PolylineTo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolylineTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", EntryPoint = "SetViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "SetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "SetWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "SetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "OffsetViewportOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "OffsetWindowOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "ScaleViewportExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int dx, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "ScaleWindowExtEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int xd, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "SetBitmapDimensionEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbm, int w, int h, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", EntryPoint = "SetBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "GetTextFaceA", ExactSpelling = true)]
        public static extern int GetTextFaceA([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPSTR")] sbyte* lpName);

        [DllImport("gdi32", EntryPoint = "GetTextFaceW", ExactSpelling = true)]
        public static extern int GetTextFaceW([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPWSTR")] ushort* lpName);

        [DllImport("gdi32", EntryPoint = "GetKerningPairsA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport("gdi32", EntryPoint = "GetKerningPairsW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport("gdi32", EntryPoint = "GetDCOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDCOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", EntryPoint = "FixBrushOrgEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FixBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* ptl);

        [DllImport("gdi32", EntryPoint = "UnrealizeObject", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnrealizeObject([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", EntryPoint = "GdiFlush", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiFlush();

        [DllImport("gdi32", EntryPoint = "GdiSetBatchLimit", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiSetBatchLimit([NativeTypeName("DWORD")] uint dw);

        [DllImport("gdi32", EntryPoint = "GdiGetBatchLimit", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiGetBatchLimit();

        [DllImport("gdi32", EntryPoint = "SetICMMode", ExactSpelling = true)]
        public static extern int SetICMMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", EntryPoint = "CheckColorsInGamut", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckColorsInGamut([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRGBTRIPLE")] RGBTRIPLE* lpRGBTriple, [NativeTypeName("LPVOID")] void* dlpBuffer, [NativeTypeName("DWORD")] uint nCount);

        [DllImport("gdi32", EntryPoint = "GetColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr GetColorSpace([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", EntryPoint = "GetLogColorSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceA([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32", EntryPoint = "GetLogColorSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceW([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32", EntryPoint = "CreateColorSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lplcs);

        [DllImport("gdi32", EntryPoint = "CreateColorSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lplcs);

        [DllImport("gdi32", EntryPoint = "SetColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr SetColorSpace([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport("gdi32", EntryPoint = "DeleteColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteColorSpace([NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport("gdi32", EntryPoint = "GetICMProfileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPSTR")] sbyte* pszFilename);

        [DllImport("gdi32", EntryPoint = "GetICMProfileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPWSTR")] ushort* pszFilename);

        [DllImport("gdi32", EntryPoint = "SetICMProfileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSTR")] sbyte* lpFileName);

        [DllImport("gdi32", EntryPoint = "SetICMProfileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpFileName);

        [DllImport("gdi32", EntryPoint = "GetDeviceGammaRamp", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32", EntryPoint = "SetDeviceGammaRamp", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32", EntryPoint = "ColorMatchToTarget", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorMatchToTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HDC")] IntPtr hdcTarget, [NativeTypeName("DWORD")] uint action);

        [DllImport("gdi32", EntryPoint = "EnumICMProfilesA", ExactSpelling = true)]
        public static extern int EnumICMProfilesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCA")] delegate* stdcall<sbyte*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32", EntryPoint = "EnumICMProfilesW", ExactSpelling = true)]
        public static extern int EnumICMProfilesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCW")] delegate* stdcall<ushort*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32", EntryPoint = "UpdateICMRegKeyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyA([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPSTR")] sbyte* lpszCMID, [NativeTypeName("LPSTR")] sbyte* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport("gdi32", EntryPoint = "UpdateICMRegKeyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyW([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPWSTR")] ushort* lpszCMID, [NativeTypeName("LPWSTR")] ushort* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport("gdi32", EntryPoint = "ColorCorrectPalette", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorCorrectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("DWORD")] uint deFirst, [NativeTypeName("DWORD")] uint num);

        [DllImport("opengl32", EntryPoint = "wglCopyContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglCopyContext([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1, [NativeTypeName("UINT")] uint param2);

        [DllImport("opengl32", EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateContext([NativeTypeName("HDC")] IntPtr param0);

        [DllImport("opengl32", EntryPoint = "wglCreateLayerContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateLayerContext([NativeTypeName("HDC")] IntPtr param0, int param1);

        [DllImport("opengl32", EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDeleteContext([NativeTypeName("HGLRC")] IntPtr param0);

        [DllImport("opengl32", EntryPoint = "wglGetCurrentContext", ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglGetCurrentContext();

        [DllImport("opengl32", EntryPoint = "wglGetCurrentDC", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr wglGetCurrentDC();

        [DllImport("opengl32", EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PROC")]
        public static extern delegate* stdcall<int> wglGetProcAddress([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("opengl32", EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglMakeCurrent([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport("opengl32", EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglShareLists([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport("gdi32", EntryPoint = "wglUseFontBitmapsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("gdi32", EntryPoint = "wglUseFontBitmapsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("gdi32", EntryPoint = "SwapBuffers", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapBuffers([NativeTypeName("HDC")] IntPtr param0);

        [DllImport("gdi32", EntryPoint = "wglUseFontOutlinesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport("gdi32", EntryPoint = "wglUseFontOutlinesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport("opengl32", EntryPoint = "wglDescribeLayerPlane", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDescribeLayerPlane([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, [NativeTypeName("UINT")] uint param3, [NativeTypeName("LPLAYERPLANEDESCRIPTOR")] LAYERPLANEDESCRIPTOR* param4);

        [DllImport("opengl32", EntryPoint = "wglSetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
        public static extern int wglSetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("const COLORREF *")] uint* param4);

        [DllImport("opengl32", EntryPoint = "wglGetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
        public static extern int wglGetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("COLORREF *")] uint* param4);

        [DllImport("opengl32", EntryPoint = "wglRealizeLayerPalette", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglRealizeLayerPalette([NativeTypeName("HDC")] IntPtr param0, int param1, [NativeTypeName("BOOL")] int param2);

        [DllImport("opengl32", EntryPoint = "wglSwapLayerBuffers", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglSwapLayerBuffers([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("UINT")] uint param1);

        [DllImport("gdi32", EntryPoint = "wglSwapMultipleBuffers", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint wglSwapMultipleBuffers([NativeTypeName("UINT")] uint param0, [NativeTypeName("const WGLSWAP *")] WGLSWAP* param1);
    }
}
