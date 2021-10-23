// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int AddFontResourceA([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int AddFontResourceW([NativeTypeName("LPCWSTR")] ushort* param0);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimatePalette([NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("UINT")] uint iStartIndex, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* ppe);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Arc([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BitBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int cx, int cy, [NativeTypeName("HDC")] IntPtr hdcSrc, int x1, int y1, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Chord([NativeTypeName("HDC")] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        public static extern int ChoosePixelFormat([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CloseMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int CombineRgn([NativeTypeName("HRGN")] IntPtr hrgnDst, [NativeTypeName("HRGN")] IntPtr hrgnSrc1, [NativeTypeName("HRGN")] IntPtr hrgnSrc2, int iMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileA([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr CopyMetaFileW([NativeTypeName("HMETAFILE")] IntPtr param0, [NativeTypeName("LPCWSTR")] ushort* param1);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, [NativeTypeName("UINT")] uint nPlanes, [NativeTypeName("UINT")] uint nBitCount, [NativeTypeName("const void *")] void* lpBits);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateBitmapIndirect([NativeTypeName("const BITMAP *")] BITMAP* pbm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateBrushIndirect([NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateCompatibleBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDiscardableBitmap([NativeTypeName("HDC")] IntPtr hdc, int cx, int cy);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateCompatibleDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCA([NativeTypeName("LPCSTR")] sbyte* pwszDriver, [NativeTypeName("LPCSTR")] sbyte* pwszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateDCW([NativeTypeName("LPCWSTR")] ushort* pwszDriver, [NativeTypeName("LPCWSTR")] ushort* pwszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBitmap([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmih, [NativeTypeName("DWORD")] uint flInit, [NativeTypeName("const void *")] void* pjBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrush([NativeTypeName("HGLOBAL")] IntPtr h, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateDIBPatternBrushPt([NativeTypeName("const void *")] void* lpPackedDIB, [NativeTypeName("UINT")] uint iUsage);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateEllipticRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectA([NativeTypeName("const LOGFONTA *")] LOGFONTA* lplf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectW([NativeTypeName("const LOGFONTW *")] LOGFONTW* lplf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCSTR")] sbyte* pszFaceName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCWSTR")] ushort* pszFaceName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateHatchBrush(int iHatch, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICA([NativeTypeName("LPCSTR")] sbyte* pszDriver, [NativeTypeName("LPCSTR")] sbyte* pszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateICW([NativeTypeName("LPCWSTR")] ushort* pszDriver, [NativeTypeName("LPCWSTR")] ushort* pszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileA([NativeTypeName("LPCSTR")] sbyte* pszFile);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateMetaFileW([NativeTypeName("LPCWSTR")] ushort* pszFile);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreatePalette([NativeTypeName("const LOGPALETTE *")] LOGPALETTE* plpal);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePen(int iStyle, int cWidth, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr CreatePenIndirect([NativeTypeName("const LOGPEN *")] LOGPEN* plpen);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolyPolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, [NativeTypeName("const INT *")] int* pc, int cPoly, int iMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreatePatternBrush([NativeTypeName("HBITMAP")] IntPtr hbm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRectRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceA([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCSTR")] sbyte* lpszFont, [NativeTypeName("LPCSTR")] sbyte* lpszFile, [NativeTypeName("LPCSTR")] sbyte* lpszPath);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceW([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCWSTR")] ushort* lpszFont, [NativeTypeName("LPCWSTR")] ushort* lpszFile, [NativeTypeName("LPCWSTR")] ushort* lpszPath);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr CreateSolidBrush([NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMetaFile([NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteObject([NativeTypeName("HGDIOBJ")] IntPtr ho);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        public static extern int DescribePixelFormat([NativeTypeName("HDC")] IntPtr hdc, int iPixelFormat, [NativeTypeName("UINT")] uint nBytes, [NativeTypeName("LPPIXELFORMATDESCRIPTOR")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int DrawEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* lpIn);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Ellipse([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontFamiliesExW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontFamiliesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontFamiliesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumFontsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumObjects([NativeTypeName("HDC")] IntPtr hdc, int nType, [NativeTypeName("GOBJENUMPROC")] delegate* unmanaged<void*, nint, int> lpFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRgn([NativeTypeName("HRGN")] IntPtr hrgn1, [NativeTypeName("HRGN")] IntPtr hrgn2);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int Escape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* pvIn, [NativeTypeName("LPVOID")] void* pvOut);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int ExtEscape([NativeTypeName("HDC")] IntPtr hdc, int iEscape, int cjInput, [NativeTypeName("LPCSTR")] sbyte* lpInData, int cjOutput, [NativeTypeName("LPSTR")] sbyte* lpOutData);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int ExcludeClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr ExtCreateRegion([NativeTypeName("const XFORM *")] XFORM* lpx, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const RGNDATA *")] RGNDATA* lpData);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtFloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color, [NativeTypeName("UINT")] uint type);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FloodFill([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FrameRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("HBRUSH")] IntPtr hbr, int w, int h);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetROP2([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAspectRatioFilterEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetBkColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCPenColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetBkMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LONG")] int cb, [NativeTypeName("LPVOID")] void* lpvBits);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbit, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint wFirst, [NativeTypeName("UINT")] uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iFirst, [NativeTypeName("UINT")] uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetClipBox([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetMetaRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetCurrentObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint type);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentPositionEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetDeviceCaps([NativeTypeName("HDC")] IntPtr hdc, int index);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("LPVOID")] void* lpvBits, [NativeTypeName("LPBITMAPINFO")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint usage);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontData([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint dwTable, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cjBuffer);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint uChar, [NativeTypeName("UINT")] uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetMapMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetMetaFileBitsEx([NativeTypeName("HMETAFILE")] IntPtr hMF, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("LPVOID")] void* lpData);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr GetMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetNearestColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetNearestPaletteIndex([NativeTypeName("HPALETTE")] IntPtr h, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetObjectType([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICA")] OUTLINETEXTMETRICA* potm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetOutlineTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICW")] OUTLINETEXTMETRICW* potm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetPixelFormat([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRasterizerCaps([NativeTypeName("LPRASTERIZER_STATUS")] RASTERIZER_STATUS* lpraststat, [NativeTypeName("UINT")] uint cjBytes);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetRandomRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("INT")] int i);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetRegionData([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("LPRGNDATA")] RGNDATA* lpRgnData);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetRgnBox([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr GetStockObject(int i);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteEntries([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTextAlign([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetTextColor([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32A([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32W([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetTextCharset([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetTextCharsetInfo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPFONTSIGNATURE")] FONTSIGNATURE* lpSig, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateCharsetInfo([NativeTypeName("DWORD *")] uint* lpSrc, [NativeTypeName("LPCHARSETINFO")] CHARSETINFO* lpCs, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontLanguageInfo([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSA")] GCP_RESULTSA* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSW")] GCP_RESULTSW* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontUnicodeRanges([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPGLYPHSET")] GLYPHSET* lpgs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* pgiIn, int cgi, [NativeTypeName("LPSIZE")] SIZE* psize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWORD")] ushort* lpwszString, int cwchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPINT")] int* piWidths);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsI([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint giFirst, [NativeTypeName("UINT")] uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPABC")] ABC* pabc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int AddFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int AddFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr AddFontMemResourceEx([NativeTypeName("PVOID")] void* pFileView, [NativeTypeName("DWORD")] uint cjSize, [NativeTypeName("PVOID")] void* pvResrved, [NativeTypeName("DWORD *")] uint* pNumFonts);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontMemResourceEx([NativeTypeName("HANDLE")] IntPtr h);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExA([NativeTypeName("const ENUMLOGFONTEXDVA *")] ENUMLOGFONTEXDVA* param0);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern IntPtr CreateFontIndirectExW([NativeTypeName("const ENUMLOGFONTEXDVW *")] ENUMLOGFONTEXDVW* param0);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int IntersectClipRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineDDA(int xStart, int yStart, int xEnd, int yEnd, [NativeTypeName("LINEDDAPROC")] delegate* unmanaged<int, int, nint, void> lpProc, [NativeTypeName("LPARAM")] nint data);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineTo([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MaskBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int width, int height, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlgBlt([NativeTypeName("HDC")] IntPtr hdcDest, [NativeTypeName("const POINT *")] POINT* lpPoint, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int width, int height, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int xMask, int yMask);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int OffsetClipRgn([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int OffsetRgn([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PatBlt([NativeTypeName("HDC")] IntPtr hdc, int x, int y, int w, int h, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Pie([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const INT *")] int* asz, int csz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRegion([NativeTypeName("HRGN")] IntPtr hrgn, int x, int y);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtVisible([NativeTypeName("HDC")] IntPtr hdc, int x, int y);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectInRegion([NativeTypeName("HRGN")] IntPtr hrgn, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectVisible([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Rectangle([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RestoreDC([NativeTypeName("HDC")] IntPtr hdc, int nSavedDC);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEA *")] DEVMODEA* lpdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr ResetDCW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DEVMODEW *")] DEVMODEW* lpdm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint RealizePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RoundRect([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResizePalette([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint n);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SaveDC([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int ExtSelectClipRgn([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HRGN")] IntPtr hrgn, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetMetaRgn([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern IntPtr SelectObject([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr SelectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("BOOL")] int bForceBkgd);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetBkColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCBrushColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCPenColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetBkMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetBitmapBits([NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const void *")] void* pvBits);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetBoundsRect([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("UINT")] uint flags);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetDIBits([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HBITMAP")] IntPtr hbm, [NativeTypeName("UINT")] uint start, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetDIBitsToDevice([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, [NativeTypeName("DWORD")] uint w, [NativeTypeName("DWORD")] uint h, int xSrc, int ySrc, [NativeTypeName("UINT")] uint StartScan, [NativeTypeName("UINT")] uint cLines, [NativeTypeName("const void *")] void* lpvBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint ColorUse);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetMapperFlags([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint flags);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetGraphicsMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetMapMode([NativeTypeName("HDC")] IntPtr hdc, int iMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetLayout([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint l);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLayout([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern IntPtr SetMetaFileBitsEx([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetPaletteEntries([NativeTypeName("HPALETTE")] IntPtr hpal, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalEntries);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetPixel([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelV([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelFormat([NativeTypeName("HDC")] IntPtr hdc, int format, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetPolyFillMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StretchBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectRgn([NativeTypeName("HRGN")] IntPtr hrgn, int left, int top, int right, int bottom);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int StretchDIBits([NativeTypeName("HDC")] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, [NativeTypeName("UINT")] uint iUsage, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetROP2([NativeTypeName("HDC")] IntPtr hdc, int rop2);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetStretchBltMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetSystemPaletteUse([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint use);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetTextCharacterExtra([NativeTypeName("HDC")] IntPtr hdc, int extra);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetTextColor([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetTextAlign([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint align);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTextJustification([NativeTypeName("HDC")] IntPtr hdc, int extra, int count);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateColors([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("msimg32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport("msimg32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport("msimg32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nMesh, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiAlphaBlend([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiTransparentBlt([NativeTypeName("HDC")] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("UINT")] uint crTransparent);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiGradientFill([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nCount, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* lpHandleTable, [NativeTypeName("LPMETARECORD")] METARECORD* lpMR, [NativeTypeName("UINT")] uint noObjs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HMETAFILE")] IntPtr hmf, [NativeTypeName("MFENUMPROC")] delegate* unmanaged<IntPtr, HANDLETABLE*, METARECORD*, int, nint, int> proc, [NativeTypeName("LPARAM")] nint param3);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CloseEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileA([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr CopyEnhMetaFileW([NativeTypeName("HENHMETAFILE")] IntPtr hEnh, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCSTR")] sbyte* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* lpDesc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr CreateEnhMetaFileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* lpDesc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteEnhMetaFile([NativeTypeName("HENHMETAFILE")] IntPtr hmf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("ENHMFENUMPROC")] delegate* unmanaged<IntPtr, HANDLETABLE*, ENHMETARECORD*, int, nint, int> proc, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr GetEnhMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hEMF, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPBYTE")] byte* lpData);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionA([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPSTR")] sbyte* lpDescription);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileDescriptionW([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cchBuffer, [NativeTypeName("LPWSTR")] ushort* lpDescription);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFileHeader([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("LPENHMETAHEADER")] ENHMETAHEADER* lpEnhMetaHeader);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePaletteEntries([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint nNumEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* lpPaletteEntries);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetEnhMetaFilePixelFormat([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbBuffer, PIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetWinMetaFileBits([NativeTypeName("HENHMETAFILE")] IntPtr hemf, [NativeTypeName("UINT")] uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, [NativeTypeName("INT")] int iMapMode, [NativeTypeName("HDC")] IntPtr hdcRef);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFile([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HENHMETAFILE")] IntPtr hmf, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFileRecord([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* pht, [NativeTypeName("const ENHMETARECORD *")] ENHMETARECORD* pmr, [NativeTypeName("UINT")] uint cht);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetEnhMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* pb);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern IntPtr SetWinMetaFileBits([NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpMeta16Data, [NativeTypeName("HDC")] IntPtr hdcRef, [NativeTypeName("const METAFILEPICT *")] METAFILEPICT* lpMFP);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiComment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint nSize, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICA")] TEXTMETRICA* lptm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPTEXTMETRICW")] TEXTMETRICW* lptm);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AngleArc([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("DWORD")] uint r, [NativeTypeName("FLOAT")] float StartAngle, [NativeTypeName("FLOAT")] float SweepAngle);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const DWORD *")] uint* asz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPXFORM")] XFORM* lpxf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyWorldTransform([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf, [NativeTypeName("DWORD")] uint mode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CombineTransform([NativeTypeName("LPXFORM")] XFORM* lpxfOut, [NativeTypeName("const XFORM *")] XFORM* lpxf1, [NativeTypeName("const XFORM *")] XFORM* lpxf2);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateDIBSection([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, [NativeTypeName("UINT")] uint usage, void** ppvBits, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("DWORD")] uint offset);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, RGBQUAD* prgbq);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetDIBColorTable([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT")] uint iStart, [NativeTypeName("UINT")] uint cEntries, [NativeTypeName("const RGBQUAD *")] RGBQUAD* prgbq);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const COLORADJUSTMENT *")] COLORADJUSTMENT* lpca);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetColorAdjustment([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCOLORADJUSTMENT")] COLORADJUSTMENT* lpca);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr CreateHalftonePalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int StartDocA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOA *")] DOCINFOA* lpdi);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int StartDocW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const DOCINFOW *")] DOCINFOW* lpdi);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EndDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int StartPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EndPage([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int AbortDoc([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetAbortProc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ABORTPROC")] delegate* unmanaged<IntPtr, int, int> proc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AbortPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ArcTo([NativeTypeName("HDC")] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BeginPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseFigure([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlattenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetPath([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* apt, [NativeTypeName("LPBYTE")] byte* aj, int cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr PathToRegion([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyDraw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const BYTE *")] byte* aj, int cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SelectClipPath([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetArcDirection([NativeTypeName("HDC")] IntPtr hdc, int dir);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("FLOAT")] float limit, [NativeTypeName("PFLOAT")] float* old);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokeAndFillPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokePath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WidenPath([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern IntPtr ExtCreatePen([NativeTypeName("DWORD")] uint iPenStyle, [NativeTypeName("DWORD")] uint cWidth, [NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush, [NativeTypeName("DWORD")] uint cStyle, [NativeTypeName("const DWORD *")] uint* pstyle);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMiterLimit([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("PFLOAT")] float* plimit);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetArcDirection([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetObjectA([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetObjectW([NativeTypeName("HANDLE")] IntPtr h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveToEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int c);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int c);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutA([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutW([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("UINT")] uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("UINT")] uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTA *")] POLYTEXTA* ppt, int nstrings);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POLYTEXTW *")] POLYTEXTW* ppt, int nstrings);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern IntPtr CreatePolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, int cPoint, int iMode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DPtoLP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LPtoDP([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polygon([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polyline([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezier([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezierTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolylineTo([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetViewportOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetWindowOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleViewportExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int dx, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleWindowExtEx([NativeTypeName("HDC")] IntPtr hdc, int xn, int xd, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBitmapDimensionEx([NativeTypeName("HBITMAP")] IntPtr hbm, int w, int h, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetTextFaceA([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPSTR")] sbyte* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int GetTextFaceW([NativeTypeName("HDC")] IntPtr hdc, int c, [NativeTypeName("LPWSTR")] ushort* lpName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDCOrgEx([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FixBrushOrgEx([NativeTypeName("HDC")] IntPtr hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* ptl);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnrealizeObject([NativeTypeName("HGDIOBJ")] IntPtr h);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiFlush();

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiSetBatchLimit([NativeTypeName("DWORD")] uint dw);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiGetBatchLimit();

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int SetICMMode([NativeTypeName("HDC")] IntPtr hdc, int mode);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckColorsInGamut([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRGBTRIPLE")] RGBTRIPLE* lpRGBTriple, [NativeTypeName("LPVOID")] void* dlpBuffer, [NativeTypeName("DWORD")] uint nCount);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr GetColorSpace([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceA([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceW([NativeTypeName("HCOLORSPACE")] IntPtr hColorSpace, [NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lplcs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr CreateColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lplcs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern IntPtr SetColorSpace([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteColorSpace([NativeTypeName("HCOLORSPACE")] IntPtr hcs);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPSTR")] sbyte* pszFilename);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPWSTR")] ushort* pszFilename);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPSTR")] sbyte* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPWSTR")] ushort* lpFileName);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDeviceGammaRamp([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorMatchToTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HDC")] IntPtr hdcTarget, [NativeTypeName("DWORD")] uint action);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumICMProfilesA([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCA")] delegate* unmanaged<sbyte*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32", ExactSpelling = true)]
        public static extern int EnumICMProfilesW([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("ICMENUMPROCW")] delegate* unmanaged<ushort*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyA([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPSTR")] sbyte* lpszCMID, [NativeTypeName("LPSTR")] sbyte* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyW([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPWSTR")] ushort* lpszCMID, [NativeTypeName("LPWSTR")] ushort* lpszFileName, [NativeTypeName("UINT")] uint command);

        [DllImport("gdi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorCorrectPalette([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("HPALETTE")] IntPtr hPal, [NativeTypeName("DWORD")] uint deFirst, [NativeTypeName("DWORD")] uint num);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglCopyContext([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1, [NativeTypeName("UINT")] uint param2);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateContext([NativeTypeName("HDC")] IntPtr param0);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglCreateLayerContext([NativeTypeName("HDC")] IntPtr param0, int param1);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDeleteContext([NativeTypeName("HGLRC")] IntPtr param0);

        [DllImport("opengl32", ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern IntPtr wglGetCurrentContext();

        [DllImport("opengl32", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr wglGetCurrentDC();

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PROC")]
        public static extern IntPtr wglGetProcAddress([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglMakeCurrent([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglShareLists([NativeTypeName("HGLRC")] IntPtr param0, [NativeTypeName("HGLRC")] IntPtr param1);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("gdi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapBuffers([NativeTypeName("HDC")] IntPtr param0);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesA([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesW([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("FLOAT")] float param4, [NativeTypeName("FLOAT")] float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);

        [DllImport("opengl32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDescribeLayerPlane([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, [NativeTypeName("UINT")] uint param3, [NativeTypeName("LPLAYERPLANEDESCRIPTOR")] LAYERPLANEDESCRIPTOR* param4);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        public static extern int wglSetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("const COLORREF *")] uint* param4);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        public static extern int wglGetLayerPaletteEntries([NativeTypeName("HDC")] IntPtr param0, int param1, int param2, int param3, [NativeTypeName("COLORREF *")] uint* param4);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglRealizeLayerPalette([NativeTypeName("HDC")] IntPtr param0, int param1, [NativeTypeName("BOOL")] int param2);

        [DllImport("opengl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglSwapLayerBuffers([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("UINT")] uint param1);

        [DllImport("opengl32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint wglSwapMultipleBuffers([NativeTypeName("UINT")] uint param0, [NativeTypeName("const WGLSWAP *")] WGLSWAP* param1);

        [NativeTypeName("#define R2_BLACK 1")]
        public const int R2_BLACK = 1;

        [NativeTypeName("#define R2_NOTMERGEPEN 2")]
        public const int R2_NOTMERGEPEN = 2;

        [NativeTypeName("#define R2_MASKNOTPEN 3")]
        public const int R2_MASKNOTPEN = 3;

        [NativeTypeName("#define R2_NOTCOPYPEN 4")]
        public const int R2_NOTCOPYPEN = 4;

        [NativeTypeName("#define R2_MASKPENNOT 5")]
        public const int R2_MASKPENNOT = 5;

        [NativeTypeName("#define R2_NOT 6")]
        public const int R2_NOT = 6;

        [NativeTypeName("#define R2_XORPEN 7")]
        public const int R2_XORPEN = 7;

        [NativeTypeName("#define R2_NOTMASKPEN 8")]
        public const int R2_NOTMASKPEN = 8;

        [NativeTypeName("#define R2_MASKPEN 9")]
        public const int R2_MASKPEN = 9;

        [NativeTypeName("#define R2_NOTXORPEN 10")]
        public const int R2_NOTXORPEN = 10;

        [NativeTypeName("#define R2_NOP 11")]
        public const int R2_NOP = 11;

        [NativeTypeName("#define R2_MERGENOTPEN 12")]
        public const int R2_MERGENOTPEN = 12;

        [NativeTypeName("#define R2_COPYPEN 13")]
        public const int R2_COPYPEN = 13;

        [NativeTypeName("#define R2_MERGEPENNOT 14")]
        public const int R2_MERGEPENNOT = 14;

        [NativeTypeName("#define R2_MERGEPEN 15")]
        public const int R2_MERGEPEN = 15;

        [NativeTypeName("#define R2_WHITE 16")]
        public const int R2_WHITE = 16;

        [NativeTypeName("#define R2_LAST 16")]
        public const int R2_LAST = 16;

        [NativeTypeName("#define SRCCOPY (DWORD)0x00CC0020")]
        public const uint SRCCOPY = (uint)(0x00CC0020);

        [NativeTypeName("#define SRCPAINT (DWORD)0x00EE0086")]
        public const uint SRCPAINT = (uint)(0x00EE0086);

        [NativeTypeName("#define SRCAND (DWORD)0x008800C6")]
        public const uint SRCAND = (uint)(0x008800C6);

        [NativeTypeName("#define SRCINVERT (DWORD)0x00660046")]
        public const uint SRCINVERT = (uint)(0x00660046);

        [NativeTypeName("#define SRCERASE (DWORD)0x00440328")]
        public const uint SRCERASE = (uint)(0x00440328);

        [NativeTypeName("#define NOTSRCCOPY (DWORD)0x00330008")]
        public const uint NOTSRCCOPY = (uint)(0x00330008);

        [NativeTypeName("#define NOTSRCERASE (DWORD)0x001100A6")]
        public const uint NOTSRCERASE = (uint)(0x001100A6);

        [NativeTypeName("#define MERGECOPY (DWORD)0x00C000CA")]
        public const uint MERGECOPY = (uint)(0x00C000CA);

        [NativeTypeName("#define MERGEPAINT (DWORD)0x00BB0226")]
        public const uint MERGEPAINT = (uint)(0x00BB0226);

        [NativeTypeName("#define PATCOPY (DWORD)0x00F00021")]
        public const uint PATCOPY = (uint)(0x00F00021);

        [NativeTypeName("#define PATPAINT (DWORD)0x00FB0A09")]
        public const uint PATPAINT = (uint)(0x00FB0A09);

        [NativeTypeName("#define PATINVERT (DWORD)0x005A0049")]
        public const uint PATINVERT = (uint)(0x005A0049);

        [NativeTypeName("#define DSTINVERT (DWORD)0x00550009")]
        public const uint DSTINVERT = (uint)(0x00550009);

        [NativeTypeName("#define BLACKNESS (DWORD)0x00000042")]
        public const uint BLACKNESS = (uint)(0x00000042);

        [NativeTypeName("#define WHITENESS (DWORD)0x00FF0062")]
        public const uint WHITENESS = (uint)(0x00FF0062);

        [NativeTypeName("#define NOMIRRORBITMAP (DWORD)0x80000000")]
        public const uint NOMIRRORBITMAP = (uint)(0x80000000);

        [NativeTypeName("#define CAPTUREBLT (DWORD)0x40000000")]
        public const uint CAPTUREBLT = (uint)(0x40000000);

        [NativeTypeName("#define GDI_ERROR (0xFFFFFFFFL)")]
        public const uint GDI_ERROR = (0xFFFFFFFF);

        [NativeTypeName("#define ERROR 0")]
        public const int ERROR = 0;

        [NativeTypeName("#define NULLREGION 1")]
        public const int NULLREGION = 1;

        [NativeTypeName("#define SIMPLEREGION 2")]
        public const int SIMPLEREGION = 2;

        [NativeTypeName("#define COMPLEXREGION 3")]
        public const int COMPLEXREGION = 3;

        [NativeTypeName("#define RGN_ERROR ERROR")]
        public const int RGN_ERROR = 0;

        [NativeTypeName("#define RGN_AND 1")]
        public const int RGN_AND = 1;

        [NativeTypeName("#define RGN_OR 2")]
        public const int RGN_OR = 2;

        [NativeTypeName("#define RGN_XOR 3")]
        public const int RGN_XOR = 3;

        [NativeTypeName("#define RGN_DIFF 4")]
        public const int RGN_DIFF = 4;

        [NativeTypeName("#define RGN_COPY 5")]
        public const int RGN_COPY = 5;

        [NativeTypeName("#define RGN_MIN RGN_AND")]
        public const int RGN_MIN = 1;

        [NativeTypeName("#define RGN_MAX RGN_COPY")]
        public const int RGN_MAX = 5;

        [NativeTypeName("#define BLACKONWHITE 1")]
        public const int BLACKONWHITE = 1;

        [NativeTypeName("#define WHITEONBLACK 2")]
        public const int WHITEONBLACK = 2;

        [NativeTypeName("#define COLORONCOLOR 3")]
        public const int COLORONCOLOR = 3;

        [NativeTypeName("#define HALFTONE 4")]
        public const int HALFTONE = 4;

        [NativeTypeName("#define MAXSTRETCHBLTMODE 4")]
        public const int MAXSTRETCHBLTMODE = 4;

        [NativeTypeName("#define STRETCH_ANDSCANS BLACKONWHITE")]
        public const int STRETCH_ANDSCANS = 1;

        [NativeTypeName("#define STRETCH_ORSCANS WHITEONBLACK")]
        public const int STRETCH_ORSCANS = 2;

        [NativeTypeName("#define STRETCH_DELETESCANS COLORONCOLOR")]
        public const int STRETCH_DELETESCANS = 3;

        [NativeTypeName("#define STRETCH_HALFTONE HALFTONE")]
        public const int STRETCH_HALFTONE = 4;

        [NativeTypeName("#define ALTERNATE 1")]
        public const int ALTERNATE = 1;

        [NativeTypeName("#define WINDING 2")]
        public const int WINDING = 2;

        [NativeTypeName("#define POLYFILL_LAST 2")]
        public const int POLYFILL_LAST = 2;

        [NativeTypeName("#define LAYOUT_RTL 0x00000001")]
        public const int LAYOUT_RTL = 0x00000001;

        [NativeTypeName("#define LAYOUT_BTT 0x00000002")]
        public const int LAYOUT_BTT = 0x00000002;

        [NativeTypeName("#define LAYOUT_VBH 0x00000004")]
        public const int LAYOUT_VBH = 0x00000004;

        [NativeTypeName("#define LAYOUT_ORIENTATIONMASK (LAYOUT_RTL | LAYOUT_BTT | LAYOUT_VBH)")]
        public const int LAYOUT_ORIENTATIONMASK = (0x00000001 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define LAYOUT_BITMAPORIENTATIONPRESERVED 0x00000008")]
        public const int LAYOUT_BITMAPORIENTATIONPRESERVED = 0x00000008;

        [NativeTypeName("#define TA_NOUPDATECP 0")]
        public const int TA_NOUPDATECP = 0;

        [NativeTypeName("#define TA_UPDATECP 1")]
        public const int TA_UPDATECP = 1;

        [NativeTypeName("#define TA_LEFT 0")]
        public const int TA_LEFT = 0;

        [NativeTypeName("#define TA_RIGHT 2")]
        public const int TA_RIGHT = 2;

        [NativeTypeName("#define TA_CENTER 6")]
        public const int TA_CENTER = 6;

        [NativeTypeName("#define TA_TOP 0")]
        public const int TA_TOP = 0;

        [NativeTypeName("#define TA_BOTTOM 8")]
        public const int TA_BOTTOM = 8;

        [NativeTypeName("#define TA_BASELINE 24")]
        public const int TA_BASELINE = 24;

        [NativeTypeName("#define TA_RTLREADING 256")]
        public const int TA_RTLREADING = 256;

        [NativeTypeName("#define TA_MASK (TA_BASELINE+TA_CENTER+TA_UPDATECP+TA_RTLREADING)")]
        public const int TA_MASK = (24 + 6 + 1 + 256);

        [NativeTypeName("#define VTA_BASELINE TA_BASELINE")]
        public const int VTA_BASELINE = 24;

        [NativeTypeName("#define VTA_LEFT TA_BOTTOM")]
        public const int VTA_LEFT = 8;

        [NativeTypeName("#define VTA_RIGHT TA_TOP")]
        public const int VTA_RIGHT = 0;

        [NativeTypeName("#define VTA_CENTER TA_CENTER")]
        public const int VTA_CENTER = 6;

        [NativeTypeName("#define VTA_BOTTOM TA_RIGHT")]
        public const int VTA_BOTTOM = 2;

        [NativeTypeName("#define VTA_TOP TA_LEFT")]
        public const int VTA_TOP = 0;

        [NativeTypeName("#define ETO_OPAQUE 0x0002")]
        public const int ETO_OPAQUE = 0x0002;

        [NativeTypeName("#define ETO_CLIPPED 0x0004")]
        public const int ETO_CLIPPED = 0x0004;

        [NativeTypeName("#define ETO_GLYPH_INDEX 0x0010")]
        public const int ETO_GLYPH_INDEX = 0x0010;

        [NativeTypeName("#define ETO_RTLREADING 0x0080")]
        public const int ETO_RTLREADING = 0x0080;

        [NativeTypeName("#define ETO_NUMERICSLOCAL 0x0400")]
        public const int ETO_NUMERICSLOCAL = 0x0400;

        [NativeTypeName("#define ETO_NUMERICSLATIN 0x0800")]
        public const int ETO_NUMERICSLATIN = 0x0800;

        [NativeTypeName("#define ETO_IGNORELANGUAGE 0x1000")]
        public const int ETO_IGNORELANGUAGE = 0x1000;

        [NativeTypeName("#define ETO_PDY 0x2000")]
        public const int ETO_PDY = 0x2000;

        [NativeTypeName("#define ETO_REVERSE_INDEX_MAP 0x10000")]
        public const int ETO_REVERSE_INDEX_MAP = 0x10000;

        [NativeTypeName("#define ASPECT_FILTERING 0x0001")]
        public const int ASPECT_FILTERING = 0x0001;

        [NativeTypeName("#define DCB_RESET 0x0001")]
        public const int DCB_RESET = 0x0001;

        [NativeTypeName("#define DCB_ACCUMULATE 0x0002")]
        public const int DCB_ACCUMULATE = 0x0002;

        [NativeTypeName("#define DCB_DIRTY DCB_ACCUMULATE")]
        public const int DCB_DIRTY = 0x0002;

        [NativeTypeName("#define DCB_SET (DCB_RESET | DCB_ACCUMULATE)")]
        public const int DCB_SET = (0x0001 | 0x0002);

        [NativeTypeName("#define DCB_ENABLE 0x0004")]
        public const int DCB_ENABLE = 0x0004;

        [NativeTypeName("#define DCB_DISABLE 0x0008")]
        public const int DCB_DISABLE = 0x0008;

        [NativeTypeName("#define META_SETBKCOLOR 0x0201")]
        public const int META_SETBKCOLOR = 0x0201;

        [NativeTypeName("#define META_SETBKMODE 0x0102")]
        public const int META_SETBKMODE = 0x0102;

        [NativeTypeName("#define META_SETMAPMODE 0x0103")]
        public const int META_SETMAPMODE = 0x0103;

        [NativeTypeName("#define META_SETROP2 0x0104")]
        public const int META_SETROP2 = 0x0104;

        [NativeTypeName("#define META_SETRELABS 0x0105")]
        public const int META_SETRELABS = 0x0105;

        [NativeTypeName("#define META_SETPOLYFILLMODE 0x0106")]
        public const int META_SETPOLYFILLMODE = 0x0106;

        [NativeTypeName("#define META_SETSTRETCHBLTMODE 0x0107")]
        public const int META_SETSTRETCHBLTMODE = 0x0107;

        [NativeTypeName("#define META_SETTEXTCHAREXTRA 0x0108")]
        public const int META_SETTEXTCHAREXTRA = 0x0108;

        [NativeTypeName("#define META_SETTEXTCOLOR 0x0209")]
        public const int META_SETTEXTCOLOR = 0x0209;

        [NativeTypeName("#define META_SETTEXTJUSTIFICATION 0x020A")]
        public const int META_SETTEXTJUSTIFICATION = 0x020A;

        [NativeTypeName("#define META_SETWINDOWORG 0x020B")]
        public const int META_SETWINDOWORG = 0x020B;

        [NativeTypeName("#define META_SETWINDOWEXT 0x020C")]
        public const int META_SETWINDOWEXT = 0x020C;

        [NativeTypeName("#define META_SETVIEWPORTORG 0x020D")]
        public const int META_SETVIEWPORTORG = 0x020D;

        [NativeTypeName("#define META_SETVIEWPORTEXT 0x020E")]
        public const int META_SETVIEWPORTEXT = 0x020E;

        [NativeTypeName("#define META_OFFSETWINDOWORG 0x020F")]
        public const int META_OFFSETWINDOWORG = 0x020F;

        [NativeTypeName("#define META_SCALEWINDOWEXT 0x0410")]
        public const int META_SCALEWINDOWEXT = 0x0410;

        [NativeTypeName("#define META_OFFSETVIEWPORTORG 0x0211")]
        public const int META_OFFSETVIEWPORTORG = 0x0211;

        [NativeTypeName("#define META_SCALEVIEWPORTEXT 0x0412")]
        public const int META_SCALEVIEWPORTEXT = 0x0412;

        [NativeTypeName("#define META_LINETO 0x0213")]
        public const int META_LINETO = 0x0213;

        [NativeTypeName("#define META_MOVETO 0x0214")]
        public const int META_MOVETO = 0x0214;

        [NativeTypeName("#define META_EXCLUDECLIPRECT 0x0415")]
        public const int META_EXCLUDECLIPRECT = 0x0415;

        [NativeTypeName("#define META_INTERSECTCLIPRECT 0x0416")]
        public const int META_INTERSECTCLIPRECT = 0x0416;

        [NativeTypeName("#define META_ARC 0x0817")]
        public const int META_ARC = 0x0817;

        [NativeTypeName("#define META_ELLIPSE 0x0418")]
        public const int META_ELLIPSE = 0x0418;

        [NativeTypeName("#define META_FLOODFILL 0x0419")]
        public const int META_FLOODFILL = 0x0419;

        [NativeTypeName("#define META_PIE 0x081A")]
        public const int META_PIE = 0x081A;

        [NativeTypeName("#define META_RECTANGLE 0x041B")]
        public const int META_RECTANGLE = 0x041B;

        [NativeTypeName("#define META_ROUNDRECT 0x061C")]
        public const int META_ROUNDRECT = 0x061C;

        [NativeTypeName("#define META_PATBLT 0x061D")]
        public const int META_PATBLT = 0x061D;

        [NativeTypeName("#define META_SAVEDC 0x001E")]
        public const int META_SAVEDC = 0x001E;

        [NativeTypeName("#define META_SETPIXEL 0x041F")]
        public const int META_SETPIXEL = 0x041F;

        [NativeTypeName("#define META_OFFSETCLIPRGN 0x0220")]
        public const int META_OFFSETCLIPRGN = 0x0220;

        [NativeTypeName("#define META_TEXTOUT 0x0521")]
        public const int META_TEXTOUT = 0x0521;

        [NativeTypeName("#define META_BITBLT 0x0922")]
        public const int META_BITBLT = 0x0922;

        [NativeTypeName("#define META_STRETCHBLT 0x0B23")]
        public const int META_STRETCHBLT = 0x0B23;

        [NativeTypeName("#define META_POLYGON 0x0324")]
        public const int META_POLYGON = 0x0324;

        [NativeTypeName("#define META_POLYLINE 0x0325")]
        public const int META_POLYLINE = 0x0325;

        [NativeTypeName("#define META_ESCAPE 0x0626")]
        public const int META_ESCAPE = 0x0626;

        [NativeTypeName("#define META_RESTOREDC 0x0127")]
        public const int META_RESTOREDC = 0x0127;

        [NativeTypeName("#define META_FILLREGION 0x0228")]
        public const int META_FILLREGION = 0x0228;

        [NativeTypeName("#define META_FRAMEREGION 0x0429")]
        public const int META_FRAMEREGION = 0x0429;

        [NativeTypeName("#define META_INVERTREGION 0x012A")]
        public const int META_INVERTREGION = 0x012A;

        [NativeTypeName("#define META_PAINTREGION 0x012B")]
        public const int META_PAINTREGION = 0x012B;

        [NativeTypeName("#define META_SELECTCLIPREGION 0x012C")]
        public const int META_SELECTCLIPREGION = 0x012C;

        [NativeTypeName("#define META_SELECTOBJECT 0x012D")]
        public const int META_SELECTOBJECT = 0x012D;

        [NativeTypeName("#define META_SETTEXTALIGN 0x012E")]
        public const int META_SETTEXTALIGN = 0x012E;

        [NativeTypeName("#define META_CHORD 0x0830")]
        public const int META_CHORD = 0x0830;

        [NativeTypeName("#define META_SETMAPPERFLAGS 0x0231")]
        public const int META_SETMAPPERFLAGS = 0x0231;

        [NativeTypeName("#define META_EXTTEXTOUT 0x0a32")]
        public const int META_EXTTEXTOUT = 0x0a32;

        [NativeTypeName("#define META_SETDIBTODEV 0x0d33")]
        public const int META_SETDIBTODEV = 0x0d33;

        [NativeTypeName("#define META_SELECTPALETTE 0x0234")]
        public const int META_SELECTPALETTE = 0x0234;

        [NativeTypeName("#define META_REALIZEPALETTE 0x0035")]
        public const int META_REALIZEPALETTE = 0x0035;

        [NativeTypeName("#define META_ANIMATEPALETTE 0x0436")]
        public const int META_ANIMATEPALETTE = 0x0436;

        [NativeTypeName("#define META_SETPALENTRIES 0x0037")]
        public const int META_SETPALENTRIES = 0x0037;

        [NativeTypeName("#define META_POLYPOLYGON 0x0538")]
        public const int META_POLYPOLYGON = 0x0538;

        [NativeTypeName("#define META_RESIZEPALETTE 0x0139")]
        public const int META_RESIZEPALETTE = 0x0139;

        [NativeTypeName("#define META_DIBBITBLT 0x0940")]
        public const int META_DIBBITBLT = 0x0940;

        [NativeTypeName("#define META_DIBSTRETCHBLT 0x0b41")]
        public const int META_DIBSTRETCHBLT = 0x0b41;

        [NativeTypeName("#define META_DIBCREATEPATTERNBRUSH 0x0142")]
        public const int META_DIBCREATEPATTERNBRUSH = 0x0142;

        [NativeTypeName("#define META_STRETCHDIB 0x0f43")]
        public const int META_STRETCHDIB = 0x0f43;

        [NativeTypeName("#define META_EXTFLOODFILL 0x0548")]
        public const int META_EXTFLOODFILL = 0x0548;

        [NativeTypeName("#define META_SETLAYOUT 0x0149")]
        public const int META_SETLAYOUT = 0x0149;

        [NativeTypeName("#define META_DELETEOBJECT 0x01f0")]
        public const int META_DELETEOBJECT = 0x01f0;

        [NativeTypeName("#define META_CREATEPALETTE 0x00f7")]
        public const int META_CREATEPALETTE = 0x00f7;

        [NativeTypeName("#define META_CREATEPATTERNBRUSH 0x01F9")]
        public const int META_CREATEPATTERNBRUSH = 0x01F9;

        [NativeTypeName("#define META_CREATEPENINDIRECT 0x02FA")]
        public const int META_CREATEPENINDIRECT = 0x02FA;

        [NativeTypeName("#define META_CREATEFONTINDIRECT 0x02FB")]
        public const int META_CREATEFONTINDIRECT = 0x02FB;

        [NativeTypeName("#define META_CREATEBRUSHINDIRECT 0x02FC")]
        public const int META_CREATEBRUSHINDIRECT = 0x02FC;

        [NativeTypeName("#define META_CREATEREGION 0x06FF")]
        public const int META_CREATEREGION = 0x06FF;

        [NativeTypeName("#define NEWFRAME 1")]
        public const int NEWFRAME = 1;

        [NativeTypeName("#define ABORTDOC 2")]
        public const int ABORTDOC = 2;

        [NativeTypeName("#define NEXTBAND 3")]
        public const int NEXTBAND = 3;

        [NativeTypeName("#define SETCOLORTABLE 4")]
        public const int SETCOLORTABLE = 4;

        [NativeTypeName("#define GETCOLORTABLE 5")]
        public const int GETCOLORTABLE = 5;

        [NativeTypeName("#define FLUSHOUTPUT 6")]
        public const int FLUSHOUTPUT = 6;

        [NativeTypeName("#define DRAFTMODE 7")]
        public const int DRAFTMODE = 7;

        [NativeTypeName("#define QUERYESCSUPPORT 8")]
        public const int QUERYESCSUPPORT = 8;

        [NativeTypeName("#define SETABORTPROC 9")]
        public const int SETABORTPROC = 9;

        [NativeTypeName("#define STARTDOC 10")]
        public const int STARTDOC = 10;

        [NativeTypeName("#define ENDDOC 11")]
        public const int ENDDOC = 11;

        [NativeTypeName("#define GETPHYSPAGESIZE 12")]
        public const int GETPHYSPAGESIZE = 12;

        [NativeTypeName("#define GETPRINTINGOFFSET 13")]
        public const int GETPRINTINGOFFSET = 13;

        [NativeTypeName("#define GETSCALINGFACTOR 14")]
        public const int GETSCALINGFACTOR = 14;

        [NativeTypeName("#define MFCOMMENT 15")]
        public const int MFCOMMENT = 15;

        [NativeTypeName("#define GETPENWIDTH 16")]
        public const int GETPENWIDTH = 16;

        [NativeTypeName("#define SETCOPYCOUNT 17")]
        public const int SETCOPYCOUNT = 17;

        [NativeTypeName("#define SELECTPAPERSOURCE 18")]
        public const int SELECTPAPERSOURCE = 18;

        [NativeTypeName("#define DEVICEDATA 19")]
        public const int DEVICEDATA = 19;

        [NativeTypeName("#define PASSTHROUGH 19")]
        public const int PASSTHROUGH = 19;

        [NativeTypeName("#define GETTECHNOLGY 20")]
        public const int GETTECHNOLGY = 20;

        [NativeTypeName("#define GETTECHNOLOGY 20")]
        public const int GETTECHNOLOGY = 20;

        [NativeTypeName("#define SETLINECAP 21")]
        public const int SETLINECAP = 21;

        [NativeTypeName("#define SETLINEJOIN 22")]
        public const int SETLINEJOIN = 22;

        [NativeTypeName("#define SETMITERLIMIT 23")]
        public const int SETMITERLIMIT = 23;

        [NativeTypeName("#define BANDINFO 24")]
        public const int BANDINFO = 24;

        [NativeTypeName("#define DRAWPATTERNRECT 25")]
        public const int DRAWPATTERNRECT = 25;

        [NativeTypeName("#define GETVECTORPENSIZE 26")]
        public const int GETVECTORPENSIZE = 26;

        [NativeTypeName("#define GETVECTORBRUSHSIZE 27")]
        public const int GETVECTORBRUSHSIZE = 27;

        [NativeTypeName("#define ENABLEDUPLEX 28")]
        public const int ENABLEDUPLEX = 28;

        [NativeTypeName("#define GETSETPAPERBINS 29")]
        public const int GETSETPAPERBINS = 29;

        [NativeTypeName("#define GETSETPRINTORIENT 30")]
        public const int GETSETPRINTORIENT = 30;

        [NativeTypeName("#define ENUMPAPERBINS 31")]
        public const int ENUMPAPERBINS = 31;

        [NativeTypeName("#define SETDIBSCALING 32")]
        public const int SETDIBSCALING = 32;

        [NativeTypeName("#define EPSPRINTING 33")]
        public const int EPSPRINTING = 33;

        [NativeTypeName("#define ENUMPAPERMETRICS 34")]
        public const int ENUMPAPERMETRICS = 34;

        [NativeTypeName("#define GETSETPAPERMETRICS 35")]
        public const int GETSETPAPERMETRICS = 35;

        [NativeTypeName("#define POSTSCRIPT_DATA 37")]
        public const int POSTSCRIPT_DATA = 37;

        [NativeTypeName("#define POSTSCRIPT_IGNORE 38")]
        public const int POSTSCRIPT_IGNORE = 38;

        [NativeTypeName("#define MOUSETRAILS 39")]
        public const int MOUSETRAILS = 39;

        [NativeTypeName("#define GETDEVICEUNITS 42")]
        public const int GETDEVICEUNITS = 42;

        [NativeTypeName("#define GETEXTENDEDTEXTMETRICS 256")]
        public const int GETEXTENDEDTEXTMETRICS = 256;

        [NativeTypeName("#define GETEXTENTTABLE 257")]
        public const int GETEXTENTTABLE = 257;

        [NativeTypeName("#define GETPAIRKERNTABLE 258")]
        public const int GETPAIRKERNTABLE = 258;

        [NativeTypeName("#define GETTRACKKERNTABLE 259")]
        public const int GETTRACKKERNTABLE = 259;

        [NativeTypeName("#define EXTTEXTOUT 512")]
        public const int EXTTEXTOUT = 512;

        [NativeTypeName("#define GETFACENAME 513")]
        public const int GETFACENAME = 513;

        [NativeTypeName("#define DOWNLOADFACE 514")]
        public const int DOWNLOADFACE = 514;

        [NativeTypeName("#define ENABLERELATIVEWIDTHS 768")]
        public const int ENABLERELATIVEWIDTHS = 768;

        [NativeTypeName("#define ENABLEPAIRKERNING 769")]
        public const int ENABLEPAIRKERNING = 769;

        [NativeTypeName("#define SETKERNTRACK 770")]
        public const int SETKERNTRACK = 770;

        [NativeTypeName("#define SETALLJUSTVALUES 771")]
        public const int SETALLJUSTVALUES = 771;

        [NativeTypeName("#define SETCHARSET 772")]
        public const int SETCHARSET = 772;

        [NativeTypeName("#define STRETCHBLT 2048")]
        public const int STRETCHBLT = 2048;

        [NativeTypeName("#define METAFILE_DRIVER 2049")]
        public const int METAFILE_DRIVER = 2049;

        [NativeTypeName("#define GETSETSCREENPARAMS 3072")]
        public const int GETSETSCREENPARAMS = 3072;

        [NativeTypeName("#define QUERYDIBSUPPORT 3073")]
        public const int QUERYDIBSUPPORT = 3073;

        [NativeTypeName("#define BEGIN_PATH 4096")]
        public const int BEGIN_PATH = 4096;

        [NativeTypeName("#define CLIP_TO_PATH 4097")]
        public const int CLIP_TO_PATH = 4097;

        [NativeTypeName("#define END_PATH 4098")]
        public const int END_PATH = 4098;

        [NativeTypeName("#define EXT_DEVICE_CAPS 4099")]
        public const int EXT_DEVICE_CAPS = 4099;

        [NativeTypeName("#define RESTORE_CTM 4100")]
        public const int RESTORE_CTM = 4100;

        [NativeTypeName("#define SAVE_CTM 4101")]
        public const int SAVE_CTM = 4101;

        [NativeTypeName("#define SET_ARC_DIRECTION 4102")]
        public const int SET_ARC_DIRECTION = 4102;

        [NativeTypeName("#define SET_BACKGROUND_COLOR 4103")]
        public const int SET_BACKGROUND_COLOR = 4103;

        [NativeTypeName("#define SET_POLY_MODE 4104")]
        public const int SET_POLY_MODE = 4104;

        [NativeTypeName("#define SET_SCREEN_ANGLE 4105")]
        public const int SET_SCREEN_ANGLE = 4105;

        [NativeTypeName("#define SET_SPREAD 4106")]
        public const int SET_SPREAD = 4106;

        [NativeTypeName("#define TRANSFORM_CTM 4107")]
        public const int TRANSFORM_CTM = 4107;

        [NativeTypeName("#define SET_CLIP_BOX 4108")]
        public const int SET_CLIP_BOX = 4108;

        [NativeTypeName("#define SET_BOUNDS 4109")]
        public const int SET_BOUNDS = 4109;

        [NativeTypeName("#define SET_MIRROR_MODE 4110")]
        public const int SET_MIRROR_MODE = 4110;

        [NativeTypeName("#define OPENCHANNEL 4110")]
        public const int OPENCHANNEL = 4110;

        [NativeTypeName("#define DOWNLOADHEADER 4111")]
        public const int DOWNLOADHEADER = 4111;

        [NativeTypeName("#define CLOSECHANNEL 4112")]
        public const int CLOSECHANNEL = 4112;

        [NativeTypeName("#define POSTSCRIPT_PASSTHROUGH 4115")]
        public const int POSTSCRIPT_PASSTHROUGH = 4115;

        [NativeTypeName("#define ENCAPSULATED_POSTSCRIPT 4116")]
        public const int ENCAPSULATED_POSTSCRIPT = 4116;

        [NativeTypeName("#define POSTSCRIPT_IDENTIFY 4117")]
        public const int POSTSCRIPT_IDENTIFY = 4117;

        [NativeTypeName("#define POSTSCRIPT_INJECTION 4118")]
        public const int POSTSCRIPT_INJECTION = 4118;

        [NativeTypeName("#define CHECKJPEGFORMAT 4119")]
        public const int CHECKJPEGFORMAT = 4119;

        [NativeTypeName("#define CHECKPNGFORMAT 4120")]
        public const int CHECKPNGFORMAT = 4120;

        [NativeTypeName("#define GET_PS_FEATURESETTING 4121")]
        public const int GET_PS_FEATURESETTING = 4121;

        [NativeTypeName("#define GDIPLUS_TS_QUERYVER 4122")]
        public const int GDIPLUS_TS_QUERYVER = 4122;

        [NativeTypeName("#define GDIPLUS_TS_RECORD 4123")]
        public const int GDIPLUS_TS_RECORD = 4123;

        [NativeTypeName("#define MILCORE_TS_QUERYVER_RESULT_FALSE 0x0")]
        public const int MILCORE_TS_QUERYVER_RESULT_FALSE = 0x0;

        [NativeTypeName("#define MILCORE_TS_QUERYVER_RESULT_TRUE 0x7FFFFFFF")]
        public const int MILCORE_TS_QUERYVER_RESULT_TRUE = 0x7FFFFFFF;

        [NativeTypeName("#define SPCLPASSTHROUGH2 4568")]
        public const int SPCLPASSTHROUGH2 = 4568;

        [NativeTypeName("#define PSIDENT_GDICENTRIC 0")]
        public const int PSIDENT_GDICENTRIC = 0;

        [NativeTypeName("#define PSIDENT_PSCENTRIC 1")]
        public const int PSIDENT_PSCENTRIC = 1;

        [NativeTypeName("#define PSINJECT_BEGINSTREAM 1")]
        public const int PSINJECT_BEGINSTREAM = 1;

        [NativeTypeName("#define PSINJECT_PSADOBE 2")]
        public const int PSINJECT_PSADOBE = 2;

        [NativeTypeName("#define PSINJECT_PAGESATEND 3")]
        public const int PSINJECT_PAGESATEND = 3;

        [NativeTypeName("#define PSINJECT_PAGES 4")]
        public const int PSINJECT_PAGES = 4;

        [NativeTypeName("#define PSINJECT_DOCNEEDEDRES 5")]
        public const int PSINJECT_DOCNEEDEDRES = 5;

        [NativeTypeName("#define PSINJECT_DOCSUPPLIEDRES 6")]
        public const int PSINJECT_DOCSUPPLIEDRES = 6;

        [NativeTypeName("#define PSINJECT_PAGEORDER 7")]
        public const int PSINJECT_PAGEORDER = 7;

        [NativeTypeName("#define PSINJECT_ORIENTATION 8")]
        public const int PSINJECT_ORIENTATION = 8;

        [NativeTypeName("#define PSINJECT_BOUNDINGBOX 9")]
        public const int PSINJECT_BOUNDINGBOX = 9;

        [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORS 10")]
        public const int PSINJECT_DOCUMENTPROCESSCOLORS = 10;

        [NativeTypeName("#define PSINJECT_COMMENTS 11")]
        public const int PSINJECT_COMMENTS = 11;

        [NativeTypeName("#define PSINJECT_BEGINDEFAULTS 12")]
        public const int PSINJECT_BEGINDEFAULTS = 12;

        [NativeTypeName("#define PSINJECT_ENDDEFAULTS 13")]
        public const int PSINJECT_ENDDEFAULTS = 13;

        [NativeTypeName("#define PSINJECT_BEGINPROLOG 14")]
        public const int PSINJECT_BEGINPROLOG = 14;

        [NativeTypeName("#define PSINJECT_ENDPROLOG 15")]
        public const int PSINJECT_ENDPROLOG = 15;

        [NativeTypeName("#define PSINJECT_BEGINSETUP 16")]
        public const int PSINJECT_BEGINSETUP = 16;

        [NativeTypeName("#define PSINJECT_ENDSETUP 17")]
        public const int PSINJECT_ENDSETUP = 17;

        [NativeTypeName("#define PSINJECT_TRAILER 18")]
        public const int PSINJECT_TRAILER = 18;

        [NativeTypeName("#define PSINJECT_EOF 19")]
        public const int PSINJECT_EOF = 19;

        [NativeTypeName("#define PSINJECT_ENDSTREAM 20")]
        public const int PSINJECT_ENDSTREAM = 20;

        [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORSATEND 21")]
        public const int PSINJECT_DOCUMENTPROCESSCOLORSATEND = 21;

        [NativeTypeName("#define PSINJECT_PAGENUMBER 100")]
        public const int PSINJECT_PAGENUMBER = 100;

        [NativeTypeName("#define PSINJECT_BEGINPAGESETUP 101")]
        public const int PSINJECT_BEGINPAGESETUP = 101;

        [NativeTypeName("#define PSINJECT_ENDPAGESETUP 102")]
        public const int PSINJECT_ENDPAGESETUP = 102;

        [NativeTypeName("#define PSINJECT_PAGETRAILER 103")]
        public const int PSINJECT_PAGETRAILER = 103;

        [NativeTypeName("#define PSINJECT_PLATECOLOR 104")]
        public const int PSINJECT_PLATECOLOR = 104;

        [NativeTypeName("#define PSINJECT_SHOWPAGE 105")]
        public const int PSINJECT_SHOWPAGE = 105;

        [NativeTypeName("#define PSINJECT_PAGEBBOX 106")]
        public const int PSINJECT_PAGEBBOX = 106;

        [NativeTypeName("#define PSINJECT_ENDPAGECOMMENTS 107")]
        public const int PSINJECT_ENDPAGECOMMENTS = 107;

        [NativeTypeName("#define PSINJECT_VMSAVE 200")]
        public const int PSINJECT_VMSAVE = 200;

        [NativeTypeName("#define PSINJECT_VMRESTORE 201")]
        public const int PSINJECT_VMRESTORE = 201;

        [NativeTypeName("#define PSINJECT_DLFONT 0xdddddddd")]
        public const uint PSINJECT_DLFONT = 0xdddddddd;

        [NativeTypeName("#define FEATURESETTING_NUP 0")]
        public const int FEATURESETTING_NUP = 0;

        [NativeTypeName("#define FEATURESETTING_OUTPUT 1")]
        public const int FEATURESETTING_OUTPUT = 1;

        [NativeTypeName("#define FEATURESETTING_PSLEVEL 2")]
        public const int FEATURESETTING_PSLEVEL = 2;

        [NativeTypeName("#define FEATURESETTING_CUSTPAPER 3")]
        public const int FEATURESETTING_CUSTPAPER = 3;

        [NativeTypeName("#define FEATURESETTING_MIRROR 4")]
        public const int FEATURESETTING_MIRROR = 4;

        [NativeTypeName("#define FEATURESETTING_NEGATIVE 5")]
        public const int FEATURESETTING_NEGATIVE = 5;

        [NativeTypeName("#define FEATURESETTING_PROTOCOL 6")]
        public const int FEATURESETTING_PROTOCOL = 6;

        [NativeTypeName("#define FEATURESETTING_PRIVATE_BEGIN 0x1000")]
        public const int FEATURESETTING_PRIVATE_BEGIN = 0x1000;

        [NativeTypeName("#define FEATURESETTING_PRIVATE_END 0x1FFF")]
        public const int FEATURESETTING_PRIVATE_END = 0x1FFF;

        [NativeTypeName("#define PSPROTOCOL_ASCII 0")]
        public const int PSPROTOCOL_ASCII = 0;

        [NativeTypeName("#define PSPROTOCOL_BCP 1")]
        public const int PSPROTOCOL_BCP = 1;

        [NativeTypeName("#define PSPROTOCOL_TBCP 2")]
        public const int PSPROTOCOL_TBCP = 2;

        [NativeTypeName("#define PSPROTOCOL_BINARY 3")]
        public const int PSPROTOCOL_BINARY = 3;

        [NativeTypeName("#define QDI_SETDIBITS 1")]
        public const int QDI_SETDIBITS = 1;

        [NativeTypeName("#define QDI_GETDIBITS 2")]
        public const int QDI_GETDIBITS = 2;

        [NativeTypeName("#define QDI_DIBTOSCREEN 4")]
        public const int QDI_DIBTOSCREEN = 4;

        [NativeTypeName("#define QDI_STRETCHDIB 8")]
        public const int QDI_STRETCHDIB = 8;

        [NativeTypeName("#define SP_NOTREPORTED 0x4000")]
        public const int SP_NOTREPORTED = 0x4000;

        [NativeTypeName("#define SP_ERROR (-1)")]
        public const int SP_ERROR = (-1);

        [NativeTypeName("#define SP_APPABORT (-2)")]
        public const int SP_APPABORT = (-2);

        [NativeTypeName("#define SP_USERABORT (-3)")]
        public const int SP_USERABORT = (-3);

        [NativeTypeName("#define SP_OUTOFDISK (-4)")]
        public const int SP_OUTOFDISK = (-4);

        [NativeTypeName("#define SP_OUTOFMEMORY (-5)")]
        public const int SP_OUTOFMEMORY = (-5);

        [NativeTypeName("#define PR_JOBSTATUS 0x0000")]
        public const int PR_JOBSTATUS = 0x0000;

        [NativeTypeName("#define OBJ_PEN 1")]
        public const int OBJ_PEN = 1;

        [NativeTypeName("#define OBJ_BRUSH 2")]
        public const int OBJ_BRUSH = 2;

        [NativeTypeName("#define OBJ_DC 3")]
        public const int OBJ_DC = 3;

        [NativeTypeName("#define OBJ_METADC 4")]
        public const int OBJ_METADC = 4;

        [NativeTypeName("#define OBJ_PAL 5")]
        public const int OBJ_PAL = 5;

        [NativeTypeName("#define OBJ_FONT 6")]
        public const int OBJ_FONT = 6;

        [NativeTypeName("#define OBJ_BITMAP 7")]
        public const int OBJ_BITMAP = 7;

        [NativeTypeName("#define OBJ_REGION 8")]
        public const int OBJ_REGION = 8;

        [NativeTypeName("#define OBJ_METAFILE 9")]
        public const int OBJ_METAFILE = 9;

        [NativeTypeName("#define OBJ_MEMDC 10")]
        public const int OBJ_MEMDC = 10;

        [NativeTypeName("#define OBJ_EXTPEN 11")]
        public const int OBJ_EXTPEN = 11;

        [NativeTypeName("#define OBJ_ENHMETADC 12")]
        public const int OBJ_ENHMETADC = 12;

        [NativeTypeName("#define OBJ_ENHMETAFILE 13")]
        public const int OBJ_ENHMETAFILE = 13;

        [NativeTypeName("#define OBJ_COLORSPACE 14")]
        public const int OBJ_COLORSPACE = 14;

        [NativeTypeName("#define GDI_OBJ_LAST OBJ_COLORSPACE")]
        public const int GDI_OBJ_LAST = 14;

        [NativeTypeName("#define MWT_IDENTITY 1")]
        public const int MWT_IDENTITY = 1;

        [NativeTypeName("#define MWT_LEFTMULTIPLY 2")]
        public const int MWT_LEFTMULTIPLY = 2;

        [NativeTypeName("#define MWT_RIGHTMULTIPLY 3")]
        public const int MWT_RIGHTMULTIPLY = 3;

        [NativeTypeName("#define MWT_MIN MWT_IDENTITY")]
        public const int MWT_MIN = 1;

        [NativeTypeName("#define MWT_MAX MWT_RIGHTMULTIPLY")]
        public const int MWT_MAX = 3;

        [NativeTypeName("#define CS_ENABLE 0x00000001L")]
        public const int CS_ENABLE = 0x00000001;

        [NativeTypeName("#define CS_DISABLE 0x00000002L")]
        public const int CS_DISABLE = 0x00000002;

        [NativeTypeName("#define CS_DELETE_TRANSFORM 0x00000003L")]
        public const int CS_DELETE_TRANSFORM = 0x00000003;

        [NativeTypeName("#define LCS_SIGNATURE 'PSOC'")]
        public const int LCS_SIGNATURE = 0x50534F43;

        [NativeTypeName("#define LCS_sRGB 'sRGB'")]
        public const int LCS_sRGB = 0x73524742;

        [NativeTypeName("#define LCS_WINDOWS_COLOR_SPACE 'Win '")]
        public const int LCS_WINDOWS_COLOR_SPACE = 0x57696E20;

        [NativeTypeName("#define LCS_CALIBRATED_RGB 0x00000000L")]
        public const int LCS_CALIBRATED_RGB = 0x00000000;

        [NativeTypeName("#define LCS_GM_BUSINESS 0x00000001L")]
        public const int LCS_GM_BUSINESS = 0x00000001;

        [NativeTypeName("#define LCS_GM_GRAPHICS 0x00000002L")]
        public const int LCS_GM_GRAPHICS = 0x00000002;

        [NativeTypeName("#define LCS_GM_IMAGES 0x00000004L")]
        public const int LCS_GM_IMAGES = 0x00000004;

        [NativeTypeName("#define LCS_GM_ABS_COLORIMETRIC 0x00000008L")]
        public const int LCS_GM_ABS_COLORIMETRIC = 0x00000008;

        [NativeTypeName("#define CM_OUT_OF_GAMUT 255")]
        public const int CM_OUT_OF_GAMUT = 255;

        [NativeTypeName("#define CM_IN_GAMUT 0")]
        public const int CM_IN_GAMUT = 0;

        [NativeTypeName("#define ICM_ADDPROFILE 1")]
        public const int ICM_ADDPROFILE = 1;

        [NativeTypeName("#define ICM_DELETEPROFILE 2")]
        public const int ICM_DELETEPROFILE = 2;

        [NativeTypeName("#define ICM_QUERYPROFILE 3")]
        public const int ICM_QUERYPROFILE = 3;

        [NativeTypeName("#define ICM_SETDEFAULTPROFILE 4")]
        public const int ICM_SETDEFAULTPROFILE = 4;

        [NativeTypeName("#define ICM_REGISTERICMATCHER 5")]
        public const int ICM_REGISTERICMATCHER = 5;

        [NativeTypeName("#define ICM_UNREGISTERICMATCHER 6")]
        public const int ICM_UNREGISTERICMATCHER = 6;

        [NativeTypeName("#define ICM_QUERYMATCH 7")]
        public const int ICM_QUERYMATCH = 7;

        [NativeTypeName("#define PROFILE_LINKED 'LINK'")]
        public const int PROFILE_LINKED = 0x4C494E4B;

        [NativeTypeName("#define PROFILE_EMBEDDED 'MBED'")]
        public const int PROFILE_EMBEDDED = 0x4D424544;

        [NativeTypeName("#define BI_RGB 0L")]
        public const int BI_RGB = 0;

        [NativeTypeName("#define BI_RLE8 1L")]
        public const int BI_RLE8 = 1;

        [NativeTypeName("#define BI_RLE4 2L")]
        public const int BI_RLE4 = 2;

        [NativeTypeName("#define BI_BITFIELDS 3L")]
        public const int BI_BITFIELDS = 3;

        [NativeTypeName("#define BI_JPEG 4L")]
        public const int BI_JPEG = 4;

        [NativeTypeName("#define BI_PNG 5L")]
        public const int BI_PNG = 5;

        [NativeTypeName("#define TCI_SRCCHARSET 1")]
        public const int TCI_SRCCHARSET = 1;

        [NativeTypeName("#define TCI_SRCCODEPAGE 2")]
        public const int TCI_SRCCODEPAGE = 2;

        [NativeTypeName("#define TCI_SRCFONTSIG 3")]
        public const int TCI_SRCFONTSIG = 3;

        [NativeTypeName("#define TCI_SRCLOCALE 0x1000")]
        public const int TCI_SRCLOCALE = 0x1000;

        [NativeTypeName("#define TMPF_FIXED_PITCH 0x01")]
        public const int TMPF_FIXED_PITCH = 0x01;

        [NativeTypeName("#define TMPF_VECTOR 0x02")]
        public const int TMPF_VECTOR = 0x02;

        [NativeTypeName("#define TMPF_DEVICE 0x08")]
        public const int TMPF_DEVICE = 0x08;

        [NativeTypeName("#define TMPF_TRUETYPE 0x04")]
        public const int TMPF_TRUETYPE = 0x04;

        [NativeTypeName("#define NTM_REGULAR 0x00000040L")]
        public const int NTM_REGULAR = 0x00000040;

        [NativeTypeName("#define NTM_BOLD 0x00000020L")]
        public const int NTM_BOLD = 0x00000020;

        [NativeTypeName("#define NTM_ITALIC 0x00000001L")]
        public const int NTM_ITALIC = 0x00000001;

        [NativeTypeName("#define NTM_NONNEGATIVE_AC 0x00010000")]
        public const int NTM_NONNEGATIVE_AC = 0x00010000;

        [NativeTypeName("#define NTM_PS_OPENTYPE 0x00020000")]
        public const int NTM_PS_OPENTYPE = 0x00020000;

        [NativeTypeName("#define NTM_TT_OPENTYPE 0x00040000")]
        public const int NTM_TT_OPENTYPE = 0x00040000;

        [NativeTypeName("#define NTM_MULTIPLEMASTER 0x00080000")]
        public const int NTM_MULTIPLEMASTER = 0x00080000;

        [NativeTypeName("#define NTM_TYPE1 0x00100000")]
        public const int NTM_TYPE1 = 0x00100000;

        [NativeTypeName("#define NTM_DSIG 0x00200000")]
        public const int NTM_DSIG = 0x00200000;

        [NativeTypeName("#define LF_FACESIZE 32")]
        public const int LF_FACESIZE = 32;

        [NativeTypeName("#define LF_FULLFACESIZE 64")]
        public const int LF_FULLFACESIZE = 64;

        [NativeTypeName("#define OUT_DEFAULT_PRECIS 0")]
        public const int OUT_DEFAULT_PRECIS = 0;

        [NativeTypeName("#define OUT_STRING_PRECIS 1")]
        public const int OUT_STRING_PRECIS = 1;

        [NativeTypeName("#define OUT_CHARACTER_PRECIS 2")]
        public const int OUT_CHARACTER_PRECIS = 2;

        [NativeTypeName("#define OUT_STROKE_PRECIS 3")]
        public const int OUT_STROKE_PRECIS = 3;

        [NativeTypeName("#define OUT_TT_PRECIS 4")]
        public const int OUT_TT_PRECIS = 4;

        [NativeTypeName("#define OUT_DEVICE_PRECIS 5")]
        public const int OUT_DEVICE_PRECIS = 5;

        [NativeTypeName("#define OUT_RASTER_PRECIS 6")]
        public const int OUT_RASTER_PRECIS = 6;

        [NativeTypeName("#define OUT_TT_ONLY_PRECIS 7")]
        public const int OUT_TT_ONLY_PRECIS = 7;

        [NativeTypeName("#define OUT_OUTLINE_PRECIS 8")]
        public const int OUT_OUTLINE_PRECIS = 8;

        [NativeTypeName("#define OUT_SCREEN_OUTLINE_PRECIS 9")]
        public const int OUT_SCREEN_OUTLINE_PRECIS = 9;

        [NativeTypeName("#define OUT_PS_ONLY_PRECIS 10")]
        public const int OUT_PS_ONLY_PRECIS = 10;

        [NativeTypeName("#define CLIP_DEFAULT_PRECIS 0")]
        public const int CLIP_DEFAULT_PRECIS = 0;

        [NativeTypeName("#define CLIP_CHARACTER_PRECIS 1")]
        public const int CLIP_CHARACTER_PRECIS = 1;

        [NativeTypeName("#define CLIP_STROKE_PRECIS 2")]
        public const int CLIP_STROKE_PRECIS = 2;

        [NativeTypeName("#define CLIP_MASK 0xf")]
        public const int CLIP_MASK = 0xf;

        [NativeTypeName("#define CLIP_LH_ANGLES (1<<4)")]
        public const int CLIP_LH_ANGLES = (1 << 4);

        [NativeTypeName("#define CLIP_TT_ALWAYS (2<<4)")]
        public const int CLIP_TT_ALWAYS = (2 << 4);

        [NativeTypeName("#define CLIP_DFA_DISABLE (4<<4)")]
        public const int CLIP_DFA_DISABLE = (4 << 4);

        [NativeTypeName("#define CLIP_EMBEDDED (8<<4)")]
        public const int CLIP_EMBEDDED = (8 << 4);

        [NativeTypeName("#define DEFAULT_QUALITY 0")]
        public const int DEFAULT_QUALITY = 0;

        [NativeTypeName("#define DRAFT_QUALITY 1")]
        public const int DRAFT_QUALITY = 1;

        [NativeTypeName("#define PROOF_QUALITY 2")]
        public const int PROOF_QUALITY = 2;

        [NativeTypeName("#define NONANTIALIASED_QUALITY 3")]
        public const int NONANTIALIASED_QUALITY = 3;

        [NativeTypeName("#define ANTIALIASED_QUALITY 4")]
        public const int ANTIALIASED_QUALITY = 4;

        [NativeTypeName("#define CLEARTYPE_QUALITY 5")]
        public const int CLEARTYPE_QUALITY = 5;

        [NativeTypeName("#define CLEARTYPE_NATURAL_QUALITY 6")]
        public const int CLEARTYPE_NATURAL_QUALITY = 6;

        [NativeTypeName("#define DEFAULT_PITCH 0")]
        public const int DEFAULT_PITCH = 0;

        [NativeTypeName("#define FIXED_PITCH 1")]
        public const int FIXED_PITCH = 1;

        [NativeTypeName("#define VARIABLE_PITCH 2")]
        public const int VARIABLE_PITCH = 2;

        [NativeTypeName("#define MONO_FONT 8")]
        public const int MONO_FONT = 8;

        [NativeTypeName("#define ANSI_CHARSET 0")]
        public const int ANSI_CHARSET = 0;

        [NativeTypeName("#define DEFAULT_CHARSET 1")]
        public const int DEFAULT_CHARSET = 1;

        [NativeTypeName("#define SYMBOL_CHARSET 2")]
        public const int SYMBOL_CHARSET = 2;

        [NativeTypeName("#define SHIFTJIS_CHARSET 128")]
        public const int SHIFTJIS_CHARSET = 128;

        [NativeTypeName("#define HANGEUL_CHARSET 129")]
        public const int HANGEUL_CHARSET = 129;

        [NativeTypeName("#define HANGUL_CHARSET 129")]
        public const int HANGUL_CHARSET = 129;

        [NativeTypeName("#define GB2312_CHARSET 134")]
        public const int GB2312_CHARSET = 134;

        [NativeTypeName("#define CHINESEBIG5_CHARSET 136")]
        public const int CHINESEBIG5_CHARSET = 136;

        [NativeTypeName("#define OEM_CHARSET 255")]
        public const int OEM_CHARSET = 255;

        [NativeTypeName("#define JOHAB_CHARSET 130")]
        public const int JOHAB_CHARSET = 130;

        [NativeTypeName("#define HEBREW_CHARSET 177")]
        public const int HEBREW_CHARSET = 177;

        [NativeTypeName("#define ARABIC_CHARSET 178")]
        public const int ARABIC_CHARSET = 178;

        [NativeTypeName("#define GREEK_CHARSET 161")]
        public const int GREEK_CHARSET = 161;

        [NativeTypeName("#define TURKISH_CHARSET 162")]
        public const int TURKISH_CHARSET = 162;

        [NativeTypeName("#define VIETNAMESE_CHARSET 163")]
        public const int VIETNAMESE_CHARSET = 163;

        [NativeTypeName("#define THAI_CHARSET 222")]
        public const int THAI_CHARSET = 222;

        [NativeTypeName("#define EASTEUROPE_CHARSET 238")]
        public const int EASTEUROPE_CHARSET = 238;

        [NativeTypeName("#define RUSSIAN_CHARSET 204")]
        public const int RUSSIAN_CHARSET = 204;

        [NativeTypeName("#define MAC_CHARSET 77")]
        public const int MAC_CHARSET = 77;

        [NativeTypeName("#define BALTIC_CHARSET 186")]
        public const int BALTIC_CHARSET = 186;

        [NativeTypeName("#define FS_LATIN1 0x00000001L")]
        public const int FS_LATIN1 = 0x00000001;

        [NativeTypeName("#define FS_LATIN2 0x00000002L")]
        public const int FS_LATIN2 = 0x00000002;

        [NativeTypeName("#define FS_CYRILLIC 0x00000004L")]
        public const int FS_CYRILLIC = 0x00000004;

        [NativeTypeName("#define FS_GREEK 0x00000008L")]
        public const int FS_GREEK = 0x00000008;

        [NativeTypeName("#define FS_TURKISH 0x00000010L")]
        public const int FS_TURKISH = 0x00000010;

        [NativeTypeName("#define FS_HEBREW 0x00000020L")]
        public const int FS_HEBREW = 0x00000020;

        [NativeTypeName("#define FS_ARABIC 0x00000040L")]
        public const int FS_ARABIC = 0x00000040;

        [NativeTypeName("#define FS_BALTIC 0x00000080L")]
        public const int FS_BALTIC = 0x00000080;

        [NativeTypeName("#define FS_VIETNAMESE 0x00000100L")]
        public const int FS_VIETNAMESE = 0x00000100;

        [NativeTypeName("#define FS_THAI 0x00010000L")]
        public const int FS_THAI = 0x00010000;

        [NativeTypeName("#define FS_JISJAPAN 0x00020000L")]
        public const int FS_JISJAPAN = 0x00020000;

        [NativeTypeName("#define FS_CHINESESIMP 0x00040000L")]
        public const int FS_CHINESESIMP = 0x00040000;

        [NativeTypeName("#define FS_WANSUNG 0x00080000L")]
        public const int FS_WANSUNG = 0x00080000;

        [NativeTypeName("#define FS_CHINESETRAD 0x00100000L")]
        public const int FS_CHINESETRAD = 0x00100000;

        [NativeTypeName("#define FS_JOHAB 0x00200000L")]
        public const int FS_JOHAB = 0x00200000;

        [NativeTypeName("#define FS_SYMBOL 0x80000000L")]
        public const uint FS_SYMBOL = 0x80000000;

        [NativeTypeName("#define FF_DONTCARE (0<<4)")]
        public const int FF_DONTCARE = (0 << 4);

        [NativeTypeName("#define FF_ROMAN (1<<4)")]
        public const int FF_ROMAN = (1 << 4);

        [NativeTypeName("#define FF_SWISS (2<<4)")]
        public const int FF_SWISS = (2 << 4);

        [NativeTypeName("#define FF_MODERN (3<<4)")]
        public const int FF_MODERN = (3 << 4);

        [NativeTypeName("#define FF_SCRIPT (4<<4)")]
        public const int FF_SCRIPT = (4 << 4);

        [NativeTypeName("#define FF_DECORATIVE (5<<4)")]
        public const int FF_DECORATIVE = (5 << 4);

        [NativeTypeName("#define FW_DONTCARE 0")]
        public const int FW_DONTCARE = 0;

        [NativeTypeName("#define FW_THIN 100")]
        public const int FW_THIN = 100;

        [NativeTypeName("#define FW_EXTRALIGHT 200")]
        public const int FW_EXTRALIGHT = 200;

        [NativeTypeName("#define FW_LIGHT 300")]
        public const int FW_LIGHT = 300;

        [NativeTypeName("#define FW_NORMAL 400")]
        public const int FW_NORMAL = 400;

        [NativeTypeName("#define FW_MEDIUM 500")]
        public const int FW_MEDIUM = 500;

        [NativeTypeName("#define FW_SEMIBOLD 600")]
        public const int FW_SEMIBOLD = 600;

        [NativeTypeName("#define FW_BOLD 700")]
        public const int FW_BOLD = 700;

        [NativeTypeName("#define FW_EXTRABOLD 800")]
        public const int FW_EXTRABOLD = 800;

        [NativeTypeName("#define FW_HEAVY 900")]
        public const int FW_HEAVY = 900;

        [NativeTypeName("#define FW_ULTRALIGHT FW_EXTRALIGHT")]
        public const int FW_ULTRALIGHT = 200;

        [NativeTypeName("#define FW_REGULAR FW_NORMAL")]
        public const int FW_REGULAR = 400;

        [NativeTypeName("#define FW_DEMIBOLD FW_SEMIBOLD")]
        public const int FW_DEMIBOLD = 600;

        [NativeTypeName("#define FW_ULTRABOLD FW_EXTRABOLD")]
        public const int FW_ULTRABOLD = 800;

        [NativeTypeName("#define FW_BLACK FW_HEAVY")]
        public const int FW_BLACK = 900;

        [NativeTypeName("#define PANOSE_COUNT 10")]
        public const int PANOSE_COUNT = 10;

        [NativeTypeName("#define PAN_FAMILYTYPE_INDEX 0")]
        public const int PAN_FAMILYTYPE_INDEX = 0;

        [NativeTypeName("#define PAN_SERIFSTYLE_INDEX 1")]
        public const int PAN_SERIFSTYLE_INDEX = 1;

        [NativeTypeName("#define PAN_WEIGHT_INDEX 2")]
        public const int PAN_WEIGHT_INDEX = 2;

        [NativeTypeName("#define PAN_PROPORTION_INDEX 3")]
        public const int PAN_PROPORTION_INDEX = 3;

        [NativeTypeName("#define PAN_CONTRAST_INDEX 4")]
        public const int PAN_CONTRAST_INDEX = 4;

        [NativeTypeName("#define PAN_STROKEVARIATION_INDEX 5")]
        public const int PAN_STROKEVARIATION_INDEX = 5;

        [NativeTypeName("#define PAN_ARMSTYLE_INDEX 6")]
        public const int PAN_ARMSTYLE_INDEX = 6;

        [NativeTypeName("#define PAN_LETTERFORM_INDEX 7")]
        public const int PAN_LETTERFORM_INDEX = 7;

        [NativeTypeName("#define PAN_MIDLINE_INDEX 8")]
        public const int PAN_MIDLINE_INDEX = 8;

        [NativeTypeName("#define PAN_XHEIGHT_INDEX 9")]
        public const int PAN_XHEIGHT_INDEX = 9;

        [NativeTypeName("#define PAN_CULTURE_LATIN 0")]
        public const int PAN_CULTURE_LATIN = 0;

        [NativeTypeName("#define PAN_ANY 0")]
        public const int PAN_ANY = 0;

        [NativeTypeName("#define PAN_NO_FIT 1")]
        public const int PAN_NO_FIT = 1;

        [NativeTypeName("#define PAN_FAMILY_TEXT_DISPLAY 2")]
        public const int PAN_FAMILY_TEXT_DISPLAY = 2;

        [NativeTypeName("#define PAN_FAMILY_SCRIPT 3")]
        public const int PAN_FAMILY_SCRIPT = 3;

        [NativeTypeName("#define PAN_FAMILY_DECORATIVE 4")]
        public const int PAN_FAMILY_DECORATIVE = 4;

        [NativeTypeName("#define PAN_FAMILY_PICTORIAL 5")]
        public const int PAN_FAMILY_PICTORIAL = 5;

        [NativeTypeName("#define PAN_SERIF_COVE 2")]
        public const int PAN_SERIF_COVE = 2;

        [NativeTypeName("#define PAN_SERIF_OBTUSE_COVE 3")]
        public const int PAN_SERIF_OBTUSE_COVE = 3;

        [NativeTypeName("#define PAN_SERIF_SQUARE_COVE 4")]
        public const int PAN_SERIF_SQUARE_COVE = 4;

        [NativeTypeName("#define PAN_SERIF_OBTUSE_SQUARE_COVE 5")]
        public const int PAN_SERIF_OBTUSE_SQUARE_COVE = 5;

        [NativeTypeName("#define PAN_SERIF_SQUARE 6")]
        public const int PAN_SERIF_SQUARE = 6;

        [NativeTypeName("#define PAN_SERIF_THIN 7")]
        public const int PAN_SERIF_THIN = 7;

        [NativeTypeName("#define PAN_SERIF_BONE 8")]
        public const int PAN_SERIF_BONE = 8;

        [NativeTypeName("#define PAN_SERIF_EXAGGERATED 9")]
        public const int PAN_SERIF_EXAGGERATED = 9;

        [NativeTypeName("#define PAN_SERIF_TRIANGLE 10")]
        public const int PAN_SERIF_TRIANGLE = 10;

        [NativeTypeName("#define PAN_SERIF_NORMAL_SANS 11")]
        public const int PAN_SERIF_NORMAL_SANS = 11;

        [NativeTypeName("#define PAN_SERIF_OBTUSE_SANS 12")]
        public const int PAN_SERIF_OBTUSE_SANS = 12;

        [NativeTypeName("#define PAN_SERIF_PERP_SANS 13")]
        public const int PAN_SERIF_PERP_SANS = 13;

        [NativeTypeName("#define PAN_SERIF_FLARED 14")]
        public const int PAN_SERIF_FLARED = 14;

        [NativeTypeName("#define PAN_SERIF_ROUNDED 15")]
        public const int PAN_SERIF_ROUNDED = 15;

        [NativeTypeName("#define PAN_WEIGHT_VERY_LIGHT 2")]
        public const int PAN_WEIGHT_VERY_LIGHT = 2;

        [NativeTypeName("#define PAN_WEIGHT_LIGHT 3")]
        public const int PAN_WEIGHT_LIGHT = 3;

        [NativeTypeName("#define PAN_WEIGHT_THIN 4")]
        public const int PAN_WEIGHT_THIN = 4;

        [NativeTypeName("#define PAN_WEIGHT_BOOK 5")]
        public const int PAN_WEIGHT_BOOK = 5;

        [NativeTypeName("#define PAN_WEIGHT_MEDIUM 6")]
        public const int PAN_WEIGHT_MEDIUM = 6;

        [NativeTypeName("#define PAN_WEIGHT_DEMI 7")]
        public const int PAN_WEIGHT_DEMI = 7;

        [NativeTypeName("#define PAN_WEIGHT_BOLD 8")]
        public const int PAN_WEIGHT_BOLD = 8;

        [NativeTypeName("#define PAN_WEIGHT_HEAVY 9")]
        public const int PAN_WEIGHT_HEAVY = 9;

        [NativeTypeName("#define PAN_WEIGHT_BLACK 10")]
        public const int PAN_WEIGHT_BLACK = 10;

        [NativeTypeName("#define PAN_WEIGHT_NORD 11")]
        public const int PAN_WEIGHT_NORD = 11;

        [NativeTypeName("#define PAN_PROP_OLD_STYLE 2")]
        public const int PAN_PROP_OLD_STYLE = 2;

        [NativeTypeName("#define PAN_PROP_MODERN 3")]
        public const int PAN_PROP_MODERN = 3;

        [NativeTypeName("#define PAN_PROP_EVEN_WIDTH 4")]
        public const int PAN_PROP_EVEN_WIDTH = 4;

        [NativeTypeName("#define PAN_PROP_EXPANDED 5")]
        public const int PAN_PROP_EXPANDED = 5;

        [NativeTypeName("#define PAN_PROP_CONDENSED 6")]
        public const int PAN_PROP_CONDENSED = 6;

        [NativeTypeName("#define PAN_PROP_VERY_EXPANDED 7")]
        public const int PAN_PROP_VERY_EXPANDED = 7;

        [NativeTypeName("#define PAN_PROP_VERY_CONDENSED 8")]
        public const int PAN_PROP_VERY_CONDENSED = 8;

        [NativeTypeName("#define PAN_PROP_MONOSPACED 9")]
        public const int PAN_PROP_MONOSPACED = 9;

        [NativeTypeName("#define PAN_CONTRAST_NONE 2")]
        public const int PAN_CONTRAST_NONE = 2;

        [NativeTypeName("#define PAN_CONTRAST_VERY_LOW 3")]
        public const int PAN_CONTRAST_VERY_LOW = 3;

        [NativeTypeName("#define PAN_CONTRAST_LOW 4")]
        public const int PAN_CONTRAST_LOW = 4;

        [NativeTypeName("#define PAN_CONTRAST_MEDIUM_LOW 5")]
        public const int PAN_CONTRAST_MEDIUM_LOW = 5;

        [NativeTypeName("#define PAN_CONTRAST_MEDIUM 6")]
        public const int PAN_CONTRAST_MEDIUM = 6;

        [NativeTypeName("#define PAN_CONTRAST_MEDIUM_HIGH 7")]
        public const int PAN_CONTRAST_MEDIUM_HIGH = 7;

        [NativeTypeName("#define PAN_CONTRAST_HIGH 8")]
        public const int PAN_CONTRAST_HIGH = 8;

        [NativeTypeName("#define PAN_CONTRAST_VERY_HIGH 9")]
        public const int PAN_CONTRAST_VERY_HIGH = 9;

        [NativeTypeName("#define PAN_STROKE_GRADUAL_DIAG 2")]
        public const int PAN_STROKE_GRADUAL_DIAG = 2;

        [NativeTypeName("#define PAN_STROKE_GRADUAL_TRAN 3")]
        public const int PAN_STROKE_GRADUAL_TRAN = 3;

        [NativeTypeName("#define PAN_STROKE_GRADUAL_VERT 4")]
        public const int PAN_STROKE_GRADUAL_VERT = 4;

        [NativeTypeName("#define PAN_STROKE_GRADUAL_HORZ 5")]
        public const int PAN_STROKE_GRADUAL_HORZ = 5;

        [NativeTypeName("#define PAN_STROKE_RAPID_VERT 6")]
        public const int PAN_STROKE_RAPID_VERT = 6;

        [NativeTypeName("#define PAN_STROKE_RAPID_HORZ 7")]
        public const int PAN_STROKE_RAPID_HORZ = 7;

        [NativeTypeName("#define PAN_STROKE_INSTANT_VERT 8")]
        public const int PAN_STROKE_INSTANT_VERT = 8;

        [NativeTypeName("#define PAN_STRAIGHT_ARMS_HORZ 2")]
        public const int PAN_STRAIGHT_ARMS_HORZ = 2;

        [NativeTypeName("#define PAN_STRAIGHT_ARMS_WEDGE 3")]
        public const int PAN_STRAIGHT_ARMS_WEDGE = 3;

        [NativeTypeName("#define PAN_STRAIGHT_ARMS_VERT 4")]
        public const int PAN_STRAIGHT_ARMS_VERT = 4;

        [NativeTypeName("#define PAN_STRAIGHT_ARMS_SINGLE_SERIF 5")]
        public const int PAN_STRAIGHT_ARMS_SINGLE_SERIF = 5;

        [NativeTypeName("#define PAN_STRAIGHT_ARMS_DOUBLE_SERIF 6")]
        public const int PAN_STRAIGHT_ARMS_DOUBLE_SERIF = 6;

        [NativeTypeName("#define PAN_BENT_ARMS_HORZ 7")]
        public const int PAN_BENT_ARMS_HORZ = 7;

        [NativeTypeName("#define PAN_BENT_ARMS_WEDGE 8")]
        public const int PAN_BENT_ARMS_WEDGE = 8;

        [NativeTypeName("#define PAN_BENT_ARMS_VERT 9")]
        public const int PAN_BENT_ARMS_VERT = 9;

        [NativeTypeName("#define PAN_BENT_ARMS_SINGLE_SERIF 10")]
        public const int PAN_BENT_ARMS_SINGLE_SERIF = 10;

        [NativeTypeName("#define PAN_BENT_ARMS_DOUBLE_SERIF 11")]
        public const int PAN_BENT_ARMS_DOUBLE_SERIF = 11;

        [NativeTypeName("#define PAN_LETT_NORMAL_CONTACT 2")]
        public const int PAN_LETT_NORMAL_CONTACT = 2;

        [NativeTypeName("#define PAN_LETT_NORMAL_WEIGHTED 3")]
        public const int PAN_LETT_NORMAL_WEIGHTED = 3;

        [NativeTypeName("#define PAN_LETT_NORMAL_BOXED 4")]
        public const int PAN_LETT_NORMAL_BOXED = 4;

        [NativeTypeName("#define PAN_LETT_NORMAL_FLATTENED 5")]
        public const int PAN_LETT_NORMAL_FLATTENED = 5;

        [NativeTypeName("#define PAN_LETT_NORMAL_ROUNDED 6")]
        public const int PAN_LETT_NORMAL_ROUNDED = 6;

        [NativeTypeName("#define PAN_LETT_NORMAL_OFF_CENTER 7")]
        public const int PAN_LETT_NORMAL_OFF_CENTER = 7;

        [NativeTypeName("#define PAN_LETT_NORMAL_SQUARE 8")]
        public const int PAN_LETT_NORMAL_SQUARE = 8;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_CONTACT 9")]
        public const int PAN_LETT_OBLIQUE_CONTACT = 9;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_WEIGHTED 10")]
        public const int PAN_LETT_OBLIQUE_WEIGHTED = 10;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_BOXED 11")]
        public const int PAN_LETT_OBLIQUE_BOXED = 11;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_FLATTENED 12")]
        public const int PAN_LETT_OBLIQUE_FLATTENED = 12;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_ROUNDED 13")]
        public const int PAN_LETT_OBLIQUE_ROUNDED = 13;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_OFF_CENTER 14")]
        public const int PAN_LETT_OBLIQUE_OFF_CENTER = 14;

        [NativeTypeName("#define PAN_LETT_OBLIQUE_SQUARE 15")]
        public const int PAN_LETT_OBLIQUE_SQUARE = 15;

        [NativeTypeName("#define PAN_MIDLINE_STANDARD_TRIMMED 2")]
        public const int PAN_MIDLINE_STANDARD_TRIMMED = 2;

        [NativeTypeName("#define PAN_MIDLINE_STANDARD_POINTED 3")]
        public const int PAN_MIDLINE_STANDARD_POINTED = 3;

        [NativeTypeName("#define PAN_MIDLINE_STANDARD_SERIFED 4")]
        public const int PAN_MIDLINE_STANDARD_SERIFED = 4;

        [NativeTypeName("#define PAN_MIDLINE_HIGH_TRIMMED 5")]
        public const int PAN_MIDLINE_HIGH_TRIMMED = 5;

        [NativeTypeName("#define PAN_MIDLINE_HIGH_POINTED 6")]
        public const int PAN_MIDLINE_HIGH_POINTED = 6;

        [NativeTypeName("#define PAN_MIDLINE_HIGH_SERIFED 7")]
        public const int PAN_MIDLINE_HIGH_SERIFED = 7;

        [NativeTypeName("#define PAN_MIDLINE_CONSTANT_TRIMMED 8")]
        public const int PAN_MIDLINE_CONSTANT_TRIMMED = 8;

        [NativeTypeName("#define PAN_MIDLINE_CONSTANT_POINTED 9")]
        public const int PAN_MIDLINE_CONSTANT_POINTED = 9;

        [NativeTypeName("#define PAN_MIDLINE_CONSTANT_SERIFED 10")]
        public const int PAN_MIDLINE_CONSTANT_SERIFED = 10;

        [NativeTypeName("#define PAN_MIDLINE_LOW_TRIMMED 11")]
        public const int PAN_MIDLINE_LOW_TRIMMED = 11;

        [NativeTypeName("#define PAN_MIDLINE_LOW_POINTED 12")]
        public const int PAN_MIDLINE_LOW_POINTED = 12;

        [NativeTypeName("#define PAN_MIDLINE_LOW_SERIFED 13")]
        public const int PAN_MIDLINE_LOW_SERIFED = 13;

        [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_SMALL 2")]
        public const int PAN_XHEIGHT_CONSTANT_SMALL = 2;

        [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_STD 3")]
        public const int PAN_XHEIGHT_CONSTANT_STD = 3;

        [NativeTypeName("#define PAN_XHEIGHT_CONSTANT_LARGE 4")]
        public const int PAN_XHEIGHT_CONSTANT_LARGE = 4;

        [NativeTypeName("#define PAN_XHEIGHT_DUCKING_SMALL 5")]
        public const int PAN_XHEIGHT_DUCKING_SMALL = 5;

        [NativeTypeName("#define PAN_XHEIGHT_DUCKING_STD 6")]
        public const int PAN_XHEIGHT_DUCKING_STD = 6;

        [NativeTypeName("#define PAN_XHEIGHT_DUCKING_LARGE 7")]
        public const int PAN_XHEIGHT_DUCKING_LARGE = 7;

        [NativeTypeName("#define ELF_VENDOR_SIZE 4")]
        public const int ELF_VENDOR_SIZE = 4;

        [NativeTypeName("#define ELF_VERSION 0")]
        public const int ELF_VERSION = 0;

        [NativeTypeName("#define ELF_CULTURE_LATIN 0")]
        public const int ELF_CULTURE_LATIN = 0;

        [NativeTypeName("#define RASTER_FONTTYPE 0x0001")]
        public const int RASTER_FONTTYPE = 0x0001;

        [NativeTypeName("#define DEVICE_FONTTYPE 0x0002")]
        public const int DEVICE_FONTTYPE = 0x0002;

        [NativeTypeName("#define TRUETYPE_FONTTYPE 0x0004")]
        public const int TRUETYPE_FONTTYPE = 0x0004;

        [NativeTypeName("#define PC_RESERVED 0x01")]
        public const int PC_RESERVED = 0x01;

        [NativeTypeName("#define PC_EXPLICIT 0x02")]
        public const int PC_EXPLICIT = 0x02;

        [NativeTypeName("#define PC_NOCOLLAPSE 0x04")]
        public const int PC_NOCOLLAPSE = 0x04;

        [NativeTypeName("#define TRANSPARENT 1")]
        public const int TRANSPARENT = 1;

        [NativeTypeName("#define OPAQUE 2")]
        public const int OPAQUE = 2;

        [NativeTypeName("#define BKMODE_LAST 2")]
        public const int BKMODE_LAST = 2;

        [NativeTypeName("#define GM_COMPATIBLE 1")]
        public const int GM_COMPATIBLE = 1;

        [NativeTypeName("#define GM_ADVANCED 2")]
        public const int GM_ADVANCED = 2;

        [NativeTypeName("#define GM_LAST 2")]
        public const int GM_LAST = 2;

        [NativeTypeName("#define PT_CLOSEFIGURE 0x01")]
        public const int PT_CLOSEFIGURE = 0x01;

        [NativeTypeName("#define PT_LINETO 0x02")]
        public const int PT_LINETO = 0x02;

        [NativeTypeName("#define PT_BEZIERTO 0x04")]
        public const int PT_BEZIERTO = 0x04;

        [NativeTypeName("#define PT_MOVETO 0x06")]
        public const int PT_MOVETO = 0x06;

        [NativeTypeName("#define MM_TEXT 1")]
        public const int MM_TEXT = 1;

        [NativeTypeName("#define MM_LOMETRIC 2")]
        public const int MM_LOMETRIC = 2;

        [NativeTypeName("#define MM_HIMETRIC 3")]
        public const int MM_HIMETRIC = 3;

        [NativeTypeName("#define MM_LOENGLISH 4")]
        public const int MM_LOENGLISH = 4;

        [NativeTypeName("#define MM_HIENGLISH 5")]
        public const int MM_HIENGLISH = 5;

        [NativeTypeName("#define MM_TWIPS 6")]
        public const int MM_TWIPS = 6;

        [NativeTypeName("#define MM_ISOTROPIC 7")]
        public const int MM_ISOTROPIC = 7;

        [NativeTypeName("#define MM_ANISOTROPIC 8")]
        public const int MM_ANISOTROPIC = 8;

        [NativeTypeName("#define MM_MIN MM_TEXT")]
        public const int MM_MIN = 1;

        [NativeTypeName("#define MM_MAX MM_ANISOTROPIC")]
        public const int MM_MAX = 8;

        [NativeTypeName("#define MM_MAX_FIXEDSCALE MM_TWIPS")]
        public const int MM_MAX_FIXEDSCALE = 6;

        [NativeTypeName("#define ABSOLUTE 1")]
        public const int ABSOLUTE = 1;

        [NativeTypeName("#define RELATIVE 2")]
        public const int RELATIVE = 2;

        [NativeTypeName("#define WHITE_BRUSH 0")]
        public const int WHITE_BRUSH = 0;

        [NativeTypeName("#define LTGRAY_BRUSH 1")]
        public const int LTGRAY_BRUSH = 1;

        [NativeTypeName("#define GRAY_BRUSH 2")]
        public const int GRAY_BRUSH = 2;

        [NativeTypeName("#define DKGRAY_BRUSH 3")]
        public const int DKGRAY_BRUSH = 3;

        [NativeTypeName("#define BLACK_BRUSH 4")]
        public const int BLACK_BRUSH = 4;

        [NativeTypeName("#define NULL_BRUSH 5")]
        public const int NULL_BRUSH = 5;

        [NativeTypeName("#define HOLLOW_BRUSH NULL_BRUSH")]
        public const int HOLLOW_BRUSH = 5;

        [NativeTypeName("#define WHITE_PEN 6")]
        public const int WHITE_PEN = 6;

        [NativeTypeName("#define BLACK_PEN 7")]
        public const int BLACK_PEN = 7;

        [NativeTypeName("#define NULL_PEN 8")]
        public const int NULL_PEN = 8;

        [NativeTypeName("#define OEM_FIXED_FONT 10")]
        public const int OEM_FIXED_FONT = 10;

        [NativeTypeName("#define ANSI_FIXED_FONT 11")]
        public const int ANSI_FIXED_FONT = 11;

        [NativeTypeName("#define ANSI_VAR_FONT 12")]
        public const int ANSI_VAR_FONT = 12;

        [NativeTypeName("#define SYSTEM_FONT 13")]
        public const int SYSTEM_FONT = 13;

        [NativeTypeName("#define DEVICE_DEFAULT_FONT 14")]
        public const int DEVICE_DEFAULT_FONT = 14;

        [NativeTypeName("#define DEFAULT_PALETTE 15")]
        public const int DEFAULT_PALETTE = 15;

        [NativeTypeName("#define SYSTEM_FIXED_FONT 16")]
        public const int SYSTEM_FIXED_FONT = 16;

        [NativeTypeName("#define DEFAULT_GUI_FONT 17")]
        public const int DEFAULT_GUI_FONT = 17;

        [NativeTypeName("#define DC_BRUSH 18")]
        public const int DC_BRUSH = 18;

        [NativeTypeName("#define DC_PEN 19")]
        public const int DC_PEN = 19;

        [NativeTypeName("#define STOCK_LAST 19")]
        public const int STOCK_LAST = 19;

        [NativeTypeName("#define CLR_INVALID 0xFFFFFFFF")]
        public const uint CLR_INVALID = 0xFFFFFFFF;

        [NativeTypeName("#define BS_SOLID 0")]
        public const int BS_SOLID = 0;

        [NativeTypeName("#define BS_NULL 1")]
        public const int BS_NULL = 1;

        [NativeTypeName("#define BS_HOLLOW BS_NULL")]
        public const int BS_HOLLOW = 1;

        [NativeTypeName("#define BS_HATCHED 2")]
        public const int BS_HATCHED = 2;

        [NativeTypeName("#define BS_PATTERN 3")]
        public const int BS_PATTERN = 3;

        [NativeTypeName("#define BS_INDEXED 4")]
        public const int BS_INDEXED = 4;

        [NativeTypeName("#define BS_DIBPATTERN 5")]
        public const int BS_DIBPATTERN = 5;

        [NativeTypeName("#define BS_DIBPATTERNPT 6")]
        public const int BS_DIBPATTERNPT = 6;

        [NativeTypeName("#define BS_PATTERN8X8 7")]
        public const int BS_PATTERN8X8 = 7;

        [NativeTypeName("#define BS_DIBPATTERN8X8 8")]
        public const int BS_DIBPATTERN8X8 = 8;

        [NativeTypeName("#define BS_MONOPATTERN 9")]
        public const int BS_MONOPATTERN = 9;

        [NativeTypeName("#define HS_HORIZONTAL 0")]
        public const int HS_HORIZONTAL = 0;

        [NativeTypeName("#define HS_VERTICAL 1")]
        public const int HS_VERTICAL = 1;

        [NativeTypeName("#define HS_FDIAGONAL 2")]
        public const int HS_FDIAGONAL = 2;

        [NativeTypeName("#define HS_BDIAGONAL 3")]
        public const int HS_BDIAGONAL = 3;

        [NativeTypeName("#define HS_CROSS 4")]
        public const int HS_CROSS = 4;

        [NativeTypeName("#define HS_DIAGCROSS 5")]
        public const int HS_DIAGCROSS = 5;

        [NativeTypeName("#define HS_API_MAX 12")]
        public const int HS_API_MAX = 12;

        [NativeTypeName("#define PS_SOLID 0")]
        public const int PS_SOLID = 0;

        [NativeTypeName("#define PS_DASH 1")]
        public const int PS_DASH = 1;

        [NativeTypeName("#define PS_DOT 2")]
        public const int PS_DOT = 2;

        [NativeTypeName("#define PS_DASHDOT 3")]
        public const int PS_DASHDOT = 3;

        [NativeTypeName("#define PS_DASHDOTDOT 4")]
        public const int PS_DASHDOTDOT = 4;

        [NativeTypeName("#define PS_NULL 5")]
        public const int PS_NULL = 5;

        [NativeTypeName("#define PS_INSIDEFRAME 6")]
        public const int PS_INSIDEFRAME = 6;

        [NativeTypeName("#define PS_USERSTYLE 7")]
        public const int PS_USERSTYLE = 7;

        [NativeTypeName("#define PS_ALTERNATE 8")]
        public const int PS_ALTERNATE = 8;

        [NativeTypeName("#define PS_STYLE_MASK 0x0000000F")]
        public const int PS_STYLE_MASK = 0x0000000F;

        [NativeTypeName("#define PS_ENDCAP_ROUND 0x00000000")]
        public const int PS_ENDCAP_ROUND = 0x00000000;

        [NativeTypeName("#define PS_ENDCAP_SQUARE 0x00000100")]
        public const int PS_ENDCAP_SQUARE = 0x00000100;

        [NativeTypeName("#define PS_ENDCAP_FLAT 0x00000200")]
        public const int PS_ENDCAP_FLAT = 0x00000200;

        [NativeTypeName("#define PS_ENDCAP_MASK 0x00000F00")]
        public const int PS_ENDCAP_MASK = 0x00000F00;

        [NativeTypeName("#define PS_JOIN_ROUND 0x00000000")]
        public const int PS_JOIN_ROUND = 0x00000000;

        [NativeTypeName("#define PS_JOIN_BEVEL 0x00001000")]
        public const int PS_JOIN_BEVEL = 0x00001000;

        [NativeTypeName("#define PS_JOIN_MITER 0x00002000")]
        public const int PS_JOIN_MITER = 0x00002000;

        [NativeTypeName("#define PS_JOIN_MASK 0x0000F000")]
        public const int PS_JOIN_MASK = 0x0000F000;

        [NativeTypeName("#define PS_COSMETIC 0x00000000")]
        public const int PS_COSMETIC = 0x00000000;

        [NativeTypeName("#define PS_GEOMETRIC 0x00010000")]
        public const int PS_GEOMETRIC = 0x00010000;

        [NativeTypeName("#define PS_TYPE_MASK 0x000F0000")]
        public const int PS_TYPE_MASK = 0x000F0000;

        [NativeTypeName("#define AD_COUNTERCLOCKWISE 1")]
        public const int AD_COUNTERCLOCKWISE = 1;

        [NativeTypeName("#define AD_CLOCKWISE 2")]
        public const int AD_CLOCKWISE = 2;

        [NativeTypeName("#define DRIVERVERSION 0")]
        public const int DRIVERVERSION = 0;

        [NativeTypeName("#define TECHNOLOGY 2")]
        public const int TECHNOLOGY = 2;

        [NativeTypeName("#define HORZSIZE 4")]
        public const int HORZSIZE = 4;

        [NativeTypeName("#define VERTSIZE 6")]
        public const int VERTSIZE = 6;

        [NativeTypeName("#define HORZRES 8")]
        public const int HORZRES = 8;

        [NativeTypeName("#define VERTRES 10")]
        public const int VERTRES = 10;

        [NativeTypeName("#define BITSPIXEL 12")]
        public const int BITSPIXEL = 12;

        [NativeTypeName("#define PLANES 14")]
        public const int PLANES = 14;

        [NativeTypeName("#define NUMBRUSHES 16")]
        public const int NUMBRUSHES = 16;

        [NativeTypeName("#define NUMPENS 18")]
        public const int NUMPENS = 18;

        [NativeTypeName("#define NUMMARKERS 20")]
        public const int NUMMARKERS = 20;

        [NativeTypeName("#define NUMFONTS 22")]
        public const int NUMFONTS = 22;

        [NativeTypeName("#define NUMCOLORS 24")]
        public const int NUMCOLORS = 24;

        [NativeTypeName("#define PDEVICESIZE 26")]
        public const int PDEVICESIZE = 26;

        [NativeTypeName("#define CURVECAPS 28")]
        public const int CURVECAPS = 28;

        [NativeTypeName("#define LINECAPS 30")]
        public const int LINECAPS = 30;

        [NativeTypeName("#define POLYGONALCAPS 32")]
        public const int POLYGONALCAPS = 32;

        [NativeTypeName("#define TEXTCAPS 34")]
        public const int TEXTCAPS = 34;

        [NativeTypeName("#define CLIPCAPS 36")]
        public const int CLIPCAPS = 36;

        [NativeTypeName("#define RASTERCAPS 38")]
        public const int RASTERCAPS = 38;

        [NativeTypeName("#define ASPECTX 40")]
        public const int ASPECTX = 40;

        [NativeTypeName("#define ASPECTY 42")]
        public const int ASPECTY = 42;

        [NativeTypeName("#define ASPECTXY 44")]
        public const int ASPECTXY = 44;

        [NativeTypeName("#define LOGPIXELSX 88")]
        public const int LOGPIXELSX = 88;

        [NativeTypeName("#define LOGPIXELSY 90")]
        public const int LOGPIXELSY = 90;

        [NativeTypeName("#define SIZEPALETTE 104")]
        public const int SIZEPALETTE = 104;

        [NativeTypeName("#define NUMRESERVED 106")]
        public const int NUMRESERVED = 106;

        [NativeTypeName("#define COLORRES 108")]
        public const int COLORRES = 108;

        [NativeTypeName("#define PHYSICALWIDTH 110")]
        public const int PHYSICALWIDTH = 110;

        [NativeTypeName("#define PHYSICALHEIGHT 111")]
        public const int PHYSICALHEIGHT = 111;

        [NativeTypeName("#define PHYSICALOFFSETX 112")]
        public const int PHYSICALOFFSETX = 112;

        [NativeTypeName("#define PHYSICALOFFSETY 113")]
        public const int PHYSICALOFFSETY = 113;

        [NativeTypeName("#define SCALINGFACTORX 114")]
        public const int SCALINGFACTORX = 114;

        [NativeTypeName("#define SCALINGFACTORY 115")]
        public const int SCALINGFACTORY = 115;

        [NativeTypeName("#define VREFRESH 116")]
        public const int VREFRESH = 116;

        [NativeTypeName("#define DESKTOPVERTRES 117")]
        public const int DESKTOPVERTRES = 117;

        [NativeTypeName("#define DESKTOPHORZRES 118")]
        public const int DESKTOPHORZRES = 118;

        [NativeTypeName("#define BLTALIGNMENT 119")]
        public const int BLTALIGNMENT = 119;

        [NativeTypeName("#define SHADEBLENDCAPS 120")]
        public const int SHADEBLENDCAPS = 120;

        [NativeTypeName("#define COLORMGMTCAPS 121")]
        public const int COLORMGMTCAPS = 121;

        [NativeTypeName("#define DT_PLOTTER 0")]
        public const int DT_PLOTTER = 0;

        [NativeTypeName("#define DT_RASDISPLAY 1")]
        public const int DT_RASDISPLAY = 1;

        [NativeTypeName("#define DT_RASPRINTER 2")]
        public const int DT_RASPRINTER = 2;

        [NativeTypeName("#define DT_RASCAMERA 3")]
        public const int DT_RASCAMERA = 3;

        [NativeTypeName("#define DT_CHARSTREAM 4")]
        public const int DT_CHARSTREAM = 4;

        [NativeTypeName("#define DT_METAFILE 5")]
        public const int DT_METAFILE = 5;

        [NativeTypeName("#define DT_DISPFILE 6")]
        public const int DT_DISPFILE = 6;

        [NativeTypeName("#define CC_NONE 0")]
        public const int CC_NONE = 0;

        [NativeTypeName("#define CC_CIRCLES 1")]
        public const int CC_CIRCLES = 1;

        [NativeTypeName("#define CC_PIE 2")]
        public const int CC_PIE = 2;

        [NativeTypeName("#define CC_CHORD 4")]
        public const int CC_CHORD = 4;

        [NativeTypeName("#define CC_ELLIPSES 8")]
        public const int CC_ELLIPSES = 8;

        [NativeTypeName("#define CC_WIDE 16")]
        public const int CC_WIDE = 16;

        [NativeTypeName("#define CC_STYLED 32")]
        public const int CC_STYLED = 32;

        [NativeTypeName("#define CC_WIDESTYLED 64")]
        public const int CC_WIDESTYLED = 64;

        [NativeTypeName("#define CC_INTERIORS 128")]
        public const int CC_INTERIORS = 128;

        [NativeTypeName("#define CC_ROUNDRECT 256")]
        public const int CC_ROUNDRECT = 256;

        [NativeTypeName("#define LC_NONE 0")]
        public const int LC_NONE = 0;

        [NativeTypeName("#define LC_POLYLINE 2")]
        public const int LC_POLYLINE = 2;

        [NativeTypeName("#define LC_MARKER 4")]
        public const int LC_MARKER = 4;

        [NativeTypeName("#define LC_POLYMARKER 8")]
        public const int LC_POLYMARKER = 8;

        [NativeTypeName("#define LC_WIDE 16")]
        public const int LC_WIDE = 16;

        [NativeTypeName("#define LC_STYLED 32")]
        public const int LC_STYLED = 32;

        [NativeTypeName("#define LC_WIDESTYLED 64")]
        public const int LC_WIDESTYLED = 64;

        [NativeTypeName("#define LC_INTERIORS 128")]
        public const int LC_INTERIORS = 128;

        [NativeTypeName("#define PC_NONE 0")]
        public const int PC_NONE = 0;

        [NativeTypeName("#define PC_POLYGON 1")]
        public const int PC_POLYGON = 1;

        [NativeTypeName("#define PC_RECTANGLE 2")]
        public const int PC_RECTANGLE = 2;

        [NativeTypeName("#define PC_WINDPOLYGON 4")]
        public const int PC_WINDPOLYGON = 4;

        [NativeTypeName("#define PC_TRAPEZOID 4")]
        public const int PC_TRAPEZOID = 4;

        [NativeTypeName("#define PC_SCANLINE 8")]
        public const int PC_SCANLINE = 8;

        [NativeTypeName("#define PC_WIDE 16")]
        public const int PC_WIDE = 16;

        [NativeTypeName("#define PC_STYLED 32")]
        public const int PC_STYLED = 32;

        [NativeTypeName("#define PC_WIDESTYLED 64")]
        public const int PC_WIDESTYLED = 64;

        [NativeTypeName("#define PC_INTERIORS 128")]
        public const int PC_INTERIORS = 128;

        [NativeTypeName("#define PC_POLYPOLYGON 256")]
        public const int PC_POLYPOLYGON = 256;

        [NativeTypeName("#define PC_PATHS 512")]
        public const int PC_PATHS = 512;

        [NativeTypeName("#define CP_NONE 0")]
        public const int CP_NONE = 0;

        [NativeTypeName("#define CP_RECTANGLE 1")]
        public const int CP_RECTANGLE = 1;

        [NativeTypeName("#define CP_REGION 2")]
        public const int CP_REGION = 2;

        [NativeTypeName("#define TC_OP_CHARACTER 0x00000001")]
        public const int TC_OP_CHARACTER = 0x00000001;

        [NativeTypeName("#define TC_OP_STROKE 0x00000002")]
        public const int TC_OP_STROKE = 0x00000002;

        [NativeTypeName("#define TC_CP_STROKE 0x00000004")]
        public const int TC_CP_STROKE = 0x00000004;

        [NativeTypeName("#define TC_CR_90 0x00000008")]
        public const int TC_CR_90 = 0x00000008;

        [NativeTypeName("#define TC_CR_ANY 0x00000010")]
        public const int TC_CR_ANY = 0x00000010;

        [NativeTypeName("#define TC_SF_X_YINDEP 0x00000020")]
        public const int TC_SF_X_YINDEP = 0x00000020;

        [NativeTypeName("#define TC_SA_DOUBLE 0x00000040")]
        public const int TC_SA_DOUBLE = 0x00000040;

        [NativeTypeName("#define TC_SA_INTEGER 0x00000080")]
        public const int TC_SA_INTEGER = 0x00000080;

        [NativeTypeName("#define TC_SA_CONTIN 0x00000100")]
        public const int TC_SA_CONTIN = 0x00000100;

        [NativeTypeName("#define TC_EA_DOUBLE 0x00000200")]
        public const int TC_EA_DOUBLE = 0x00000200;

        [NativeTypeName("#define TC_IA_ABLE 0x00000400")]
        public const int TC_IA_ABLE = 0x00000400;

        [NativeTypeName("#define TC_UA_ABLE 0x00000800")]
        public const int TC_UA_ABLE = 0x00000800;

        [NativeTypeName("#define TC_SO_ABLE 0x00001000")]
        public const int TC_SO_ABLE = 0x00001000;

        [NativeTypeName("#define TC_RA_ABLE 0x00002000")]
        public const int TC_RA_ABLE = 0x00002000;

        [NativeTypeName("#define TC_VA_ABLE 0x00004000")]
        public const int TC_VA_ABLE = 0x00004000;

        [NativeTypeName("#define TC_RESERVED 0x00008000")]
        public const int TC_RESERVED = 0x00008000;

        [NativeTypeName("#define TC_SCROLLBLT 0x00010000")]
        public const int TC_SCROLLBLT = 0x00010000;

        [NativeTypeName("#define RC_BITBLT 1")]
        public const int RC_BITBLT = 1;

        [NativeTypeName("#define RC_BANDING 2")]
        public const int RC_BANDING = 2;

        [NativeTypeName("#define RC_SCALING 4")]
        public const int RC_SCALING = 4;

        [NativeTypeName("#define RC_BITMAP64 8")]
        public const int RC_BITMAP64 = 8;

        [NativeTypeName("#define RC_GDI20_OUTPUT 0x0010")]
        public const int RC_GDI20_OUTPUT = 0x0010;

        [NativeTypeName("#define RC_GDI20_STATE 0x0020")]
        public const int RC_GDI20_STATE = 0x0020;

        [NativeTypeName("#define RC_SAVEBITMAP 0x0040")]
        public const int RC_SAVEBITMAP = 0x0040;

        [NativeTypeName("#define RC_DI_BITMAP 0x0080")]
        public const int RC_DI_BITMAP = 0x0080;

        [NativeTypeName("#define RC_PALETTE 0x0100")]
        public const int RC_PALETTE = 0x0100;

        [NativeTypeName("#define RC_DIBTODEV 0x0200")]
        public const int RC_DIBTODEV = 0x0200;

        [NativeTypeName("#define RC_BIGFONT 0x0400")]
        public const int RC_BIGFONT = 0x0400;

        [NativeTypeName("#define RC_STRETCHBLT 0x0800")]
        public const int RC_STRETCHBLT = 0x0800;

        [NativeTypeName("#define RC_FLOODFILL 0x1000")]
        public const int RC_FLOODFILL = 0x1000;

        [NativeTypeName("#define RC_STRETCHDIB 0x2000")]
        public const int RC_STRETCHDIB = 0x2000;

        [NativeTypeName("#define RC_OP_DX_OUTPUT 0x4000")]
        public const int RC_OP_DX_OUTPUT = 0x4000;

        [NativeTypeName("#define RC_DEVBITS 0x8000")]
        public const int RC_DEVBITS = 0x8000;

        [NativeTypeName("#define SB_NONE 0x00000000")]
        public const int SB_NONE = 0x00000000;

        [NativeTypeName("#define SB_CONST_ALPHA 0x00000001")]
        public const int SB_CONST_ALPHA = 0x00000001;

        [NativeTypeName("#define SB_PIXEL_ALPHA 0x00000002")]
        public const int SB_PIXEL_ALPHA = 0x00000002;

        [NativeTypeName("#define SB_PREMULT_ALPHA 0x00000004")]
        public const int SB_PREMULT_ALPHA = 0x00000004;

        [NativeTypeName("#define SB_GRAD_RECT 0x00000010")]
        public const int SB_GRAD_RECT = 0x00000010;

        [NativeTypeName("#define SB_GRAD_TRI 0x00000020")]
        public const int SB_GRAD_TRI = 0x00000020;

        [NativeTypeName("#define CM_NONE 0x00000000")]
        public const int CM_NONE = 0x00000000;

        [NativeTypeName("#define CM_DEVICE_ICM 0x00000001")]
        public const int CM_DEVICE_ICM = 0x00000001;

        [NativeTypeName("#define CM_GAMMA_RAMP 0x00000002")]
        public const int CM_GAMMA_RAMP = 0x00000002;

        [NativeTypeName("#define CM_CMYK_COLOR 0x00000004")]
        public const int CM_CMYK_COLOR = 0x00000004;

        [NativeTypeName("#define DIB_RGB_COLORS 0")]
        public const int DIB_RGB_COLORS = 0;

        [NativeTypeName("#define DIB_PAL_COLORS 1")]
        public const int DIB_PAL_COLORS = 1;

        [NativeTypeName("#define SYSPAL_ERROR 0")]
        public const int SYSPAL_ERROR = 0;

        [NativeTypeName("#define SYSPAL_STATIC 1")]
        public const int SYSPAL_STATIC = 1;

        [NativeTypeName("#define SYSPAL_NOSTATIC 2")]
        public const int SYSPAL_NOSTATIC = 2;

        [NativeTypeName("#define SYSPAL_NOSTATIC256 3")]
        public const int SYSPAL_NOSTATIC256 = 3;

        [NativeTypeName("#define CBM_INIT 0x04L")]
        public const int CBM_INIT = 0x04;

        [NativeTypeName("#define FLOODFILLBORDER 0")]
        public const int FLOODFILLBORDER = 0;

        [NativeTypeName("#define FLOODFILLSURFACE 1")]
        public const int FLOODFILLSURFACE = 1;

        [NativeTypeName("#define CCHDEVICENAME 32")]
        public const int CCHDEVICENAME = 32;

        [NativeTypeName("#define CCHFORMNAME 32")]
        public const int CCHFORMNAME = 32;

        [NativeTypeName("#define DM_SPECVERSION 0x0401")]
        public const int DM_SPECVERSION = 0x0401;

        [NativeTypeName("#define DM_ORIENTATION 0x00000001L")]
        public const int DM_ORIENTATION = 0x00000001;

        [NativeTypeName("#define DM_PAPERSIZE 0x00000002L")]
        public const int DM_PAPERSIZE = 0x00000002;

        [NativeTypeName("#define DM_PAPERLENGTH 0x00000004L")]
        public const int DM_PAPERLENGTH = 0x00000004;

        [NativeTypeName("#define DM_PAPERWIDTH 0x00000008L")]
        public const int DM_PAPERWIDTH = 0x00000008;

        [NativeTypeName("#define DM_SCALE 0x00000010L")]
        public const int DM_SCALE = 0x00000010;

        [NativeTypeName("#define DM_POSITION 0x00000020L")]
        public const int DM_POSITION = 0x00000020;

        [NativeTypeName("#define DM_NUP 0x00000040L")]
        public const int DM_NUP = 0x00000040;

        [NativeTypeName("#define DM_DISPLAYORIENTATION 0x00000080L")]
        public const int DM_DISPLAYORIENTATION = 0x00000080;

        [NativeTypeName("#define DM_COPIES 0x00000100L")]
        public const int DM_COPIES = 0x00000100;

        [NativeTypeName("#define DM_DEFAULTSOURCE 0x00000200L")]
        public const int DM_DEFAULTSOURCE = 0x00000200;

        [NativeTypeName("#define DM_PRINTQUALITY 0x00000400L")]
        public const int DM_PRINTQUALITY = 0x00000400;

        [NativeTypeName("#define DM_COLOR 0x00000800L")]
        public const int DM_COLOR = 0x00000800;

        [NativeTypeName("#define DM_DUPLEX 0x00001000L")]
        public const int DM_DUPLEX = 0x00001000;

        [NativeTypeName("#define DM_YRESOLUTION 0x00002000L")]
        public const int DM_YRESOLUTION = 0x00002000;

        [NativeTypeName("#define DM_TTOPTION 0x00004000L")]
        public const int DM_TTOPTION = 0x00004000;

        [NativeTypeName("#define DM_COLLATE 0x00008000L")]
        public const int DM_COLLATE = 0x00008000;

        [NativeTypeName("#define DM_FORMNAME 0x00010000L")]
        public const int DM_FORMNAME = 0x00010000;

        [NativeTypeName("#define DM_LOGPIXELS 0x00020000L")]
        public const int DM_LOGPIXELS = 0x00020000;

        [NativeTypeName("#define DM_BITSPERPEL 0x00040000L")]
        public const int DM_BITSPERPEL = 0x00040000;

        [NativeTypeName("#define DM_PELSWIDTH 0x00080000L")]
        public const int DM_PELSWIDTH = 0x00080000;

        [NativeTypeName("#define DM_PELSHEIGHT 0x00100000L")]
        public const int DM_PELSHEIGHT = 0x00100000;

        [NativeTypeName("#define DM_DISPLAYFLAGS 0x00200000L")]
        public const int DM_DISPLAYFLAGS = 0x00200000;

        [NativeTypeName("#define DM_DISPLAYFREQUENCY 0x00400000L")]
        public const int DM_DISPLAYFREQUENCY = 0x00400000;

        [NativeTypeName("#define DM_ICMMETHOD 0x00800000L")]
        public const int DM_ICMMETHOD = 0x00800000;

        [NativeTypeName("#define DM_ICMINTENT 0x01000000L")]
        public const int DM_ICMINTENT = 0x01000000;

        [NativeTypeName("#define DM_MEDIATYPE 0x02000000L")]
        public const int DM_MEDIATYPE = 0x02000000;

        [NativeTypeName("#define DM_DITHERTYPE 0x04000000L")]
        public const int DM_DITHERTYPE = 0x04000000;

        [NativeTypeName("#define DM_PANNINGWIDTH 0x08000000L")]
        public const int DM_PANNINGWIDTH = 0x08000000;

        [NativeTypeName("#define DM_PANNINGHEIGHT 0x10000000L")]
        public const int DM_PANNINGHEIGHT = 0x10000000;

        [NativeTypeName("#define DM_DISPLAYFIXEDOUTPUT 0x20000000L")]
        public const int DM_DISPLAYFIXEDOUTPUT = 0x20000000;

        [NativeTypeName("#define DMORIENT_PORTRAIT 1")]
        public const int DMORIENT_PORTRAIT = 1;

        [NativeTypeName("#define DMORIENT_LANDSCAPE 2")]
        public const int DMORIENT_LANDSCAPE = 2;

        [NativeTypeName("#define DMPAPER_FIRST DMPAPER_LETTER")]
        public const int DMPAPER_FIRST = 1;

        [NativeTypeName("#define DMPAPER_LETTER 1")]
        public const int DMPAPER_LETTER = 1;

        [NativeTypeName("#define DMPAPER_LETTERSMALL 2")]
        public const int DMPAPER_LETTERSMALL = 2;

        [NativeTypeName("#define DMPAPER_TABLOID 3")]
        public const int DMPAPER_TABLOID = 3;

        [NativeTypeName("#define DMPAPER_LEDGER 4")]
        public const int DMPAPER_LEDGER = 4;

        [NativeTypeName("#define DMPAPER_LEGAL 5")]
        public const int DMPAPER_LEGAL = 5;

        [NativeTypeName("#define DMPAPER_STATEMENT 6")]
        public const int DMPAPER_STATEMENT = 6;

        [NativeTypeName("#define DMPAPER_EXECUTIVE 7")]
        public const int DMPAPER_EXECUTIVE = 7;

        [NativeTypeName("#define DMPAPER_A3 8")]
        public const int DMPAPER_A3 = 8;

        [NativeTypeName("#define DMPAPER_A4 9")]
        public const int DMPAPER_A4 = 9;

        [NativeTypeName("#define DMPAPER_A4SMALL 10")]
        public const int DMPAPER_A4SMALL = 10;

        [NativeTypeName("#define DMPAPER_A5 11")]
        public const int DMPAPER_A5 = 11;

        [NativeTypeName("#define DMPAPER_B4 12")]
        public const int DMPAPER_B4 = 12;

        [NativeTypeName("#define DMPAPER_B5 13")]
        public const int DMPAPER_B5 = 13;

        [NativeTypeName("#define DMPAPER_FOLIO 14")]
        public const int DMPAPER_FOLIO = 14;

        [NativeTypeName("#define DMPAPER_QUARTO 15")]
        public const int DMPAPER_QUARTO = 15;

        [NativeTypeName("#define DMPAPER_10X14 16")]
        public const int DMPAPER_10X14 = 16;

        [NativeTypeName("#define DMPAPER_11X17 17")]
        public const int DMPAPER_11X17 = 17;

        [NativeTypeName("#define DMPAPER_NOTE 18")]
        public const int DMPAPER_NOTE = 18;

        [NativeTypeName("#define DMPAPER_ENV_9 19")]
        public const int DMPAPER_ENV_9 = 19;

        [NativeTypeName("#define DMPAPER_ENV_10 20")]
        public const int DMPAPER_ENV_10 = 20;

        [NativeTypeName("#define DMPAPER_ENV_11 21")]
        public const int DMPAPER_ENV_11 = 21;

        [NativeTypeName("#define DMPAPER_ENV_12 22")]
        public const int DMPAPER_ENV_12 = 22;

        [NativeTypeName("#define DMPAPER_ENV_14 23")]
        public const int DMPAPER_ENV_14 = 23;

        [NativeTypeName("#define DMPAPER_CSHEET 24")]
        public const int DMPAPER_CSHEET = 24;

        [NativeTypeName("#define DMPAPER_DSHEET 25")]
        public const int DMPAPER_DSHEET = 25;

        [NativeTypeName("#define DMPAPER_ESHEET 26")]
        public const int DMPAPER_ESHEET = 26;

        [NativeTypeName("#define DMPAPER_ENV_DL 27")]
        public const int DMPAPER_ENV_DL = 27;

        [NativeTypeName("#define DMPAPER_ENV_C5 28")]
        public const int DMPAPER_ENV_C5 = 28;

        [NativeTypeName("#define DMPAPER_ENV_C3 29")]
        public const int DMPAPER_ENV_C3 = 29;

        [NativeTypeName("#define DMPAPER_ENV_C4 30")]
        public const int DMPAPER_ENV_C4 = 30;

        [NativeTypeName("#define DMPAPER_ENV_C6 31")]
        public const int DMPAPER_ENV_C6 = 31;

        [NativeTypeName("#define DMPAPER_ENV_C65 32")]
        public const int DMPAPER_ENV_C65 = 32;

        [NativeTypeName("#define DMPAPER_ENV_B4 33")]
        public const int DMPAPER_ENV_B4 = 33;

        [NativeTypeName("#define DMPAPER_ENV_B5 34")]
        public const int DMPAPER_ENV_B5 = 34;

        [NativeTypeName("#define DMPAPER_ENV_B6 35")]
        public const int DMPAPER_ENV_B6 = 35;

        [NativeTypeName("#define DMPAPER_ENV_ITALY 36")]
        public const int DMPAPER_ENV_ITALY = 36;

        [NativeTypeName("#define DMPAPER_ENV_MONARCH 37")]
        public const int DMPAPER_ENV_MONARCH = 37;

        [NativeTypeName("#define DMPAPER_ENV_PERSONAL 38")]
        public const int DMPAPER_ENV_PERSONAL = 38;

        [NativeTypeName("#define DMPAPER_FANFOLD_US 39")]
        public const int DMPAPER_FANFOLD_US = 39;

        [NativeTypeName("#define DMPAPER_FANFOLD_STD_GERMAN 40")]
        public const int DMPAPER_FANFOLD_STD_GERMAN = 40;

        [NativeTypeName("#define DMPAPER_FANFOLD_LGL_GERMAN 41")]
        public const int DMPAPER_FANFOLD_LGL_GERMAN = 41;

        [NativeTypeName("#define DMPAPER_ISO_B4 42")]
        public const int DMPAPER_ISO_B4 = 42;

        [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD 43")]
        public const int DMPAPER_JAPANESE_POSTCARD = 43;

        [NativeTypeName("#define DMPAPER_9X11 44")]
        public const int DMPAPER_9X11 = 44;

        [NativeTypeName("#define DMPAPER_10X11 45")]
        public const int DMPAPER_10X11 = 45;

        [NativeTypeName("#define DMPAPER_15X11 46")]
        public const int DMPAPER_15X11 = 46;

        [NativeTypeName("#define DMPAPER_ENV_INVITE 47")]
        public const int DMPAPER_ENV_INVITE = 47;

        [NativeTypeName("#define DMPAPER_RESERVED_48 48")]
        public const int DMPAPER_RESERVED_48 = 48;

        [NativeTypeName("#define DMPAPER_RESERVED_49 49")]
        public const int DMPAPER_RESERVED_49 = 49;

        [NativeTypeName("#define DMPAPER_LETTER_EXTRA 50")]
        public const int DMPAPER_LETTER_EXTRA = 50;

        [NativeTypeName("#define DMPAPER_LEGAL_EXTRA 51")]
        public const int DMPAPER_LEGAL_EXTRA = 51;

        [NativeTypeName("#define DMPAPER_TABLOID_EXTRA 52")]
        public const int DMPAPER_TABLOID_EXTRA = 52;

        [NativeTypeName("#define DMPAPER_A4_EXTRA 53")]
        public const int DMPAPER_A4_EXTRA = 53;

        [NativeTypeName("#define DMPAPER_LETTER_TRANSVERSE 54")]
        public const int DMPAPER_LETTER_TRANSVERSE = 54;

        [NativeTypeName("#define DMPAPER_A4_TRANSVERSE 55")]
        public const int DMPAPER_A4_TRANSVERSE = 55;

        [NativeTypeName("#define DMPAPER_LETTER_EXTRA_TRANSVERSE 56")]
        public const int DMPAPER_LETTER_EXTRA_TRANSVERSE = 56;

        [NativeTypeName("#define DMPAPER_A_PLUS 57")]
        public const int DMPAPER_A_PLUS = 57;

        [NativeTypeName("#define DMPAPER_B_PLUS 58")]
        public const int DMPAPER_B_PLUS = 58;

        [NativeTypeName("#define DMPAPER_LETTER_PLUS 59")]
        public const int DMPAPER_LETTER_PLUS = 59;

        [NativeTypeName("#define DMPAPER_A4_PLUS 60")]
        public const int DMPAPER_A4_PLUS = 60;

        [NativeTypeName("#define DMPAPER_A5_TRANSVERSE 61")]
        public const int DMPAPER_A5_TRANSVERSE = 61;

        [NativeTypeName("#define DMPAPER_B5_TRANSVERSE 62")]
        public const int DMPAPER_B5_TRANSVERSE = 62;

        [NativeTypeName("#define DMPAPER_A3_EXTRA 63")]
        public const int DMPAPER_A3_EXTRA = 63;

        [NativeTypeName("#define DMPAPER_A5_EXTRA 64")]
        public const int DMPAPER_A5_EXTRA = 64;

        [NativeTypeName("#define DMPAPER_B5_EXTRA 65")]
        public const int DMPAPER_B5_EXTRA = 65;

        [NativeTypeName("#define DMPAPER_A2 66")]
        public const int DMPAPER_A2 = 66;

        [NativeTypeName("#define DMPAPER_A3_TRANSVERSE 67")]
        public const int DMPAPER_A3_TRANSVERSE = 67;

        [NativeTypeName("#define DMPAPER_A3_EXTRA_TRANSVERSE 68")]
        public const int DMPAPER_A3_EXTRA_TRANSVERSE = 68;

        [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD 69")]
        public const int DMPAPER_DBL_JAPANESE_POSTCARD = 69;

        [NativeTypeName("#define DMPAPER_A6 70")]
        public const int DMPAPER_A6 = 70;

        [NativeTypeName("#define DMPAPER_JENV_KAKU2 71")]
        public const int DMPAPER_JENV_KAKU2 = 71;

        [NativeTypeName("#define DMPAPER_JENV_KAKU3 72")]
        public const int DMPAPER_JENV_KAKU3 = 72;

        [NativeTypeName("#define DMPAPER_JENV_CHOU3 73")]
        public const int DMPAPER_JENV_CHOU3 = 73;

        [NativeTypeName("#define DMPAPER_JENV_CHOU4 74")]
        public const int DMPAPER_JENV_CHOU4 = 74;

        [NativeTypeName("#define DMPAPER_LETTER_ROTATED 75")]
        public const int DMPAPER_LETTER_ROTATED = 75;

        [NativeTypeName("#define DMPAPER_A3_ROTATED 76")]
        public const int DMPAPER_A3_ROTATED = 76;

        [NativeTypeName("#define DMPAPER_A4_ROTATED 77")]
        public const int DMPAPER_A4_ROTATED = 77;

        [NativeTypeName("#define DMPAPER_A5_ROTATED 78")]
        public const int DMPAPER_A5_ROTATED = 78;

        [NativeTypeName("#define DMPAPER_B4_JIS_ROTATED 79")]
        public const int DMPAPER_B4_JIS_ROTATED = 79;

        [NativeTypeName("#define DMPAPER_B5_JIS_ROTATED 80")]
        public const int DMPAPER_B5_JIS_ROTATED = 80;

        [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD_ROTATED 81")]
        public const int DMPAPER_JAPANESE_POSTCARD_ROTATED = 81;

        [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED 82")]
        public const int DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82;

        [NativeTypeName("#define DMPAPER_A6_ROTATED 83")]
        public const int DMPAPER_A6_ROTATED = 83;

        [NativeTypeName("#define DMPAPER_JENV_KAKU2_ROTATED 84")]
        public const int DMPAPER_JENV_KAKU2_ROTATED = 84;

        [NativeTypeName("#define DMPAPER_JENV_KAKU3_ROTATED 85")]
        public const int DMPAPER_JENV_KAKU3_ROTATED = 85;

        [NativeTypeName("#define DMPAPER_JENV_CHOU3_ROTATED 86")]
        public const int DMPAPER_JENV_CHOU3_ROTATED = 86;

        [NativeTypeName("#define DMPAPER_JENV_CHOU4_ROTATED 87")]
        public const int DMPAPER_JENV_CHOU4_ROTATED = 87;

        [NativeTypeName("#define DMPAPER_B6_JIS 88")]
        public const int DMPAPER_B6_JIS = 88;

        [NativeTypeName("#define DMPAPER_B6_JIS_ROTATED 89")]
        public const int DMPAPER_B6_JIS_ROTATED = 89;

        [NativeTypeName("#define DMPAPER_12X11 90")]
        public const int DMPAPER_12X11 = 90;

        [NativeTypeName("#define DMPAPER_JENV_YOU4 91")]
        public const int DMPAPER_JENV_YOU4 = 91;

        [NativeTypeName("#define DMPAPER_JENV_YOU4_ROTATED 92")]
        public const int DMPAPER_JENV_YOU4_ROTATED = 92;

        [NativeTypeName("#define DMPAPER_P16K 93")]
        public const int DMPAPER_P16K = 93;

        [NativeTypeName("#define DMPAPER_P32K 94")]
        public const int DMPAPER_P32K = 94;

        [NativeTypeName("#define DMPAPER_P32KBIG 95")]
        public const int DMPAPER_P32KBIG = 95;

        [NativeTypeName("#define DMPAPER_PENV_1 96")]
        public const int DMPAPER_PENV_1 = 96;

        [NativeTypeName("#define DMPAPER_PENV_2 97")]
        public const int DMPAPER_PENV_2 = 97;

        [NativeTypeName("#define DMPAPER_PENV_3 98")]
        public const int DMPAPER_PENV_3 = 98;

        [NativeTypeName("#define DMPAPER_PENV_4 99")]
        public const int DMPAPER_PENV_4 = 99;

        [NativeTypeName("#define DMPAPER_PENV_5 100")]
        public const int DMPAPER_PENV_5 = 100;

        [NativeTypeName("#define DMPAPER_PENV_6 101")]
        public const int DMPAPER_PENV_6 = 101;

        [NativeTypeName("#define DMPAPER_PENV_7 102")]
        public const int DMPAPER_PENV_7 = 102;

        [NativeTypeName("#define DMPAPER_PENV_8 103")]
        public const int DMPAPER_PENV_8 = 103;

        [NativeTypeName("#define DMPAPER_PENV_9 104")]
        public const int DMPAPER_PENV_9 = 104;

        [NativeTypeName("#define DMPAPER_PENV_10 105")]
        public const int DMPAPER_PENV_10 = 105;

        [NativeTypeName("#define DMPAPER_P16K_ROTATED 106")]
        public const int DMPAPER_P16K_ROTATED = 106;

        [NativeTypeName("#define DMPAPER_P32K_ROTATED 107")]
        public const int DMPAPER_P32K_ROTATED = 107;

        [NativeTypeName("#define DMPAPER_P32KBIG_ROTATED 108")]
        public const int DMPAPER_P32KBIG_ROTATED = 108;

        [NativeTypeName("#define DMPAPER_PENV_1_ROTATED 109")]
        public const int DMPAPER_PENV_1_ROTATED = 109;

        [NativeTypeName("#define DMPAPER_PENV_2_ROTATED 110")]
        public const int DMPAPER_PENV_2_ROTATED = 110;

        [NativeTypeName("#define DMPAPER_PENV_3_ROTATED 111")]
        public const int DMPAPER_PENV_3_ROTATED = 111;

        [NativeTypeName("#define DMPAPER_PENV_4_ROTATED 112")]
        public const int DMPAPER_PENV_4_ROTATED = 112;

        [NativeTypeName("#define DMPAPER_PENV_5_ROTATED 113")]
        public const int DMPAPER_PENV_5_ROTATED = 113;

        [NativeTypeName("#define DMPAPER_PENV_6_ROTATED 114")]
        public const int DMPAPER_PENV_6_ROTATED = 114;

        [NativeTypeName("#define DMPAPER_PENV_7_ROTATED 115")]
        public const int DMPAPER_PENV_7_ROTATED = 115;

        [NativeTypeName("#define DMPAPER_PENV_8_ROTATED 116")]
        public const int DMPAPER_PENV_8_ROTATED = 116;

        [NativeTypeName("#define DMPAPER_PENV_9_ROTATED 117")]
        public const int DMPAPER_PENV_9_ROTATED = 117;

        [NativeTypeName("#define DMPAPER_PENV_10_ROTATED 118")]
        public const int DMPAPER_PENV_10_ROTATED = 118;

        [NativeTypeName("#define DMPAPER_LAST DMPAPER_PENV_10_ROTATED")]
        public const int DMPAPER_LAST = 118;

        [NativeTypeName("#define DMPAPER_USER 256")]
        public const int DMPAPER_USER = 256;

        [NativeTypeName("#define DMBIN_FIRST DMBIN_UPPER")]
        public const int DMBIN_FIRST = 1;

        [NativeTypeName("#define DMBIN_UPPER 1")]
        public const int DMBIN_UPPER = 1;

        [NativeTypeName("#define DMBIN_ONLYONE 1")]
        public const int DMBIN_ONLYONE = 1;

        [NativeTypeName("#define DMBIN_LOWER 2")]
        public const int DMBIN_LOWER = 2;

        [NativeTypeName("#define DMBIN_MIDDLE 3")]
        public const int DMBIN_MIDDLE = 3;

        [NativeTypeName("#define DMBIN_MANUAL 4")]
        public const int DMBIN_MANUAL = 4;

        [NativeTypeName("#define DMBIN_ENVELOPE 5")]
        public const int DMBIN_ENVELOPE = 5;

        [NativeTypeName("#define DMBIN_ENVMANUAL 6")]
        public const int DMBIN_ENVMANUAL = 6;

        [NativeTypeName("#define DMBIN_AUTO 7")]
        public const int DMBIN_AUTO = 7;

        [NativeTypeName("#define DMBIN_TRACTOR 8")]
        public const int DMBIN_TRACTOR = 8;

        [NativeTypeName("#define DMBIN_SMALLFMT 9")]
        public const int DMBIN_SMALLFMT = 9;

        [NativeTypeName("#define DMBIN_LARGEFMT 10")]
        public const int DMBIN_LARGEFMT = 10;

        [NativeTypeName("#define DMBIN_LARGECAPACITY 11")]
        public const int DMBIN_LARGECAPACITY = 11;

        [NativeTypeName("#define DMBIN_CASSETTE 14")]
        public const int DMBIN_CASSETTE = 14;

        [NativeTypeName("#define DMBIN_FORMSOURCE 15")]
        public const int DMBIN_FORMSOURCE = 15;

        [NativeTypeName("#define DMBIN_LAST DMBIN_FORMSOURCE")]
        public const int DMBIN_LAST = 15;

        [NativeTypeName("#define DMBIN_USER 256")]
        public const int DMBIN_USER = 256;

        [NativeTypeName("#define DMRES_DRAFT (-1)")]
        public const int DMRES_DRAFT = (-1);

        [NativeTypeName("#define DMRES_LOW (-2)")]
        public const int DMRES_LOW = (-2);

        [NativeTypeName("#define DMRES_MEDIUM (-3)")]
        public const int DMRES_MEDIUM = (-3);

        [NativeTypeName("#define DMRES_HIGH (-4)")]
        public const int DMRES_HIGH = (-4);

        [NativeTypeName("#define DMCOLOR_MONOCHROME 1")]
        public const int DMCOLOR_MONOCHROME = 1;

        [NativeTypeName("#define DMCOLOR_COLOR 2")]
        public const int DMCOLOR_COLOR = 2;

        [NativeTypeName("#define DMDUP_SIMPLEX 1")]
        public const int DMDUP_SIMPLEX = 1;

        [NativeTypeName("#define DMDUP_VERTICAL 2")]
        public const int DMDUP_VERTICAL = 2;

        [NativeTypeName("#define DMDUP_HORIZONTAL 3")]
        public const int DMDUP_HORIZONTAL = 3;

        [NativeTypeName("#define DMTT_BITMAP 1")]
        public const int DMTT_BITMAP = 1;

        [NativeTypeName("#define DMTT_DOWNLOAD 2")]
        public const int DMTT_DOWNLOAD = 2;

        [NativeTypeName("#define DMTT_SUBDEV 3")]
        public const int DMTT_SUBDEV = 3;

        [NativeTypeName("#define DMTT_DOWNLOAD_OUTLINE 4")]
        public const int DMTT_DOWNLOAD_OUTLINE = 4;

        [NativeTypeName("#define DMCOLLATE_FALSE 0")]
        public const int DMCOLLATE_FALSE = 0;

        [NativeTypeName("#define DMCOLLATE_TRUE 1")]
        public const int DMCOLLATE_TRUE = 1;

        [NativeTypeName("#define DMDO_DEFAULT 0")]
        public const int DMDO_DEFAULT = 0;

        [NativeTypeName("#define DMDO_90 1")]
        public const int DMDO_90 = 1;

        [NativeTypeName("#define DMDO_180 2")]
        public const int DMDO_180 = 2;

        [NativeTypeName("#define DMDO_270 3")]
        public const int DMDO_270 = 3;

        [NativeTypeName("#define DMDFO_DEFAULT 0")]
        public const int DMDFO_DEFAULT = 0;

        [NativeTypeName("#define DMDFO_STRETCH 1")]
        public const int DMDFO_STRETCH = 1;

        [NativeTypeName("#define DMDFO_CENTER 2")]
        public const int DMDFO_CENTER = 2;

        [NativeTypeName("#define DM_INTERLACED 0x00000002")]
        public const int DM_INTERLACED = 0x00000002;

        [NativeTypeName("#define DMDISPLAYFLAGS_TEXTMODE 0x00000004")]
        public const int DMDISPLAYFLAGS_TEXTMODE = 0x00000004;

        [NativeTypeName("#define DMNUP_SYSTEM 1")]
        public const int DMNUP_SYSTEM = 1;

        [NativeTypeName("#define DMNUP_ONEUP 2")]
        public const int DMNUP_ONEUP = 2;

        [NativeTypeName("#define DMICMMETHOD_NONE 1")]
        public const int DMICMMETHOD_NONE = 1;

        [NativeTypeName("#define DMICMMETHOD_SYSTEM 2")]
        public const int DMICMMETHOD_SYSTEM = 2;

        [NativeTypeName("#define DMICMMETHOD_DRIVER 3")]
        public const int DMICMMETHOD_DRIVER = 3;

        [NativeTypeName("#define DMICMMETHOD_DEVICE 4")]
        public const int DMICMMETHOD_DEVICE = 4;

        [NativeTypeName("#define DMICMMETHOD_USER 256")]
        public const int DMICMMETHOD_USER = 256;

        [NativeTypeName("#define DMICM_SATURATE 1")]
        public const int DMICM_SATURATE = 1;

        [NativeTypeName("#define DMICM_CONTRAST 2")]
        public const int DMICM_CONTRAST = 2;

        [NativeTypeName("#define DMICM_COLORIMETRIC 3")]
        public const int DMICM_COLORIMETRIC = 3;

        [NativeTypeName("#define DMICM_ABS_COLORIMETRIC 4")]
        public const int DMICM_ABS_COLORIMETRIC = 4;

        [NativeTypeName("#define DMICM_USER 256")]
        public const int DMICM_USER = 256;

        [NativeTypeName("#define DMMEDIA_STANDARD 1")]
        public const int DMMEDIA_STANDARD = 1;

        [NativeTypeName("#define DMMEDIA_TRANSPARENCY 2")]
        public const int DMMEDIA_TRANSPARENCY = 2;

        [NativeTypeName("#define DMMEDIA_GLOSSY 3")]
        public const int DMMEDIA_GLOSSY = 3;

        [NativeTypeName("#define DMMEDIA_USER 256")]
        public const int DMMEDIA_USER = 256;

        [NativeTypeName("#define DMDITHER_NONE 1")]
        public const int DMDITHER_NONE = 1;

        [NativeTypeName("#define DMDITHER_COARSE 2")]
        public const int DMDITHER_COARSE = 2;

        [NativeTypeName("#define DMDITHER_FINE 3")]
        public const int DMDITHER_FINE = 3;

        [NativeTypeName("#define DMDITHER_LINEART 4")]
        public const int DMDITHER_LINEART = 4;

        [NativeTypeName("#define DMDITHER_ERRORDIFFUSION 5")]
        public const int DMDITHER_ERRORDIFFUSION = 5;

        [NativeTypeName("#define DMDITHER_RESERVED6 6")]
        public const int DMDITHER_RESERVED6 = 6;

        [NativeTypeName("#define DMDITHER_RESERVED7 7")]
        public const int DMDITHER_RESERVED7 = 7;

        [NativeTypeName("#define DMDITHER_RESERVED8 8")]
        public const int DMDITHER_RESERVED8 = 8;

        [NativeTypeName("#define DMDITHER_RESERVED9 9")]
        public const int DMDITHER_RESERVED9 = 9;

        [NativeTypeName("#define DMDITHER_GRAYSCALE 10")]
        public const int DMDITHER_GRAYSCALE = 10;

        [NativeTypeName("#define DMDITHER_USER 256")]
        public const int DMDITHER_USER = 256;

        [NativeTypeName("#define DISPLAY_DEVICE_ATTACHED_TO_DESKTOP 0x00000001")]
        public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 0x00000001;

        [NativeTypeName("#define DISPLAY_DEVICE_MULTI_DRIVER 0x00000002")]
        public const int DISPLAY_DEVICE_MULTI_DRIVER = 0x00000002;

        [NativeTypeName("#define DISPLAY_DEVICE_PRIMARY_DEVICE 0x00000004")]
        public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 0x00000004;

        [NativeTypeName("#define DISPLAY_DEVICE_MIRRORING_DRIVER 0x00000008")]
        public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 0x00000008;

        [NativeTypeName("#define DISPLAY_DEVICE_VGA_COMPATIBLE 0x00000010")]
        public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 0x00000010;

        [NativeTypeName("#define DISPLAY_DEVICE_REMOVABLE 0x00000020")]
        public const int DISPLAY_DEVICE_REMOVABLE = 0x00000020;

        [NativeTypeName("#define DISPLAY_DEVICE_ACC_DRIVER 0x00000040")]
        public const int DISPLAY_DEVICE_ACC_DRIVER = 0x00000040;

        [NativeTypeName("#define DISPLAY_DEVICE_MODESPRUNED 0x08000000")]
        public const int DISPLAY_DEVICE_MODESPRUNED = 0x08000000;

        [NativeTypeName("#define DISPLAY_DEVICE_RDPUDD 0x01000000")]
        public const int DISPLAY_DEVICE_RDPUDD = 0x01000000;

        [NativeTypeName("#define DISPLAY_DEVICE_REMOTE 0x04000000")]
        public const int DISPLAY_DEVICE_REMOTE = 0x04000000;

        [NativeTypeName("#define DISPLAY_DEVICE_DISCONNECT 0x02000000")]
        public const int DISPLAY_DEVICE_DISCONNECT = 0x02000000;

        [NativeTypeName("#define DISPLAY_DEVICE_TS_COMPATIBLE 0x00200000")]
        public const int DISPLAY_DEVICE_TS_COMPATIBLE = 0x00200000;

        [NativeTypeName("#define DISPLAY_DEVICE_UNSAFE_MODES_ON 0x00080000")]
        public const int DISPLAY_DEVICE_UNSAFE_MODES_ON = 0x00080000;

        [NativeTypeName("#define DISPLAY_DEVICE_ACTIVE 0x00000001")]
        public const int DISPLAY_DEVICE_ACTIVE = 0x00000001;

        [NativeTypeName("#define DISPLAY_DEVICE_ATTACHED 0x00000002")]
        public const int DISPLAY_DEVICE_ATTACHED = 0x00000002;

        [NativeTypeName("#define DISPLAYCONFIG_MAXPATH 1024")]
        public const int DISPLAYCONFIG_MAXPATH = 1024;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_MODE_IDX_INVALID 0xffffffff")]
        public const uint DISPLAYCONFIG_PATH_MODE_IDX_INVALID = 0xffffffff;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID 0xffff")]
        public const int DISPLAYCONFIG_PATH_TARGET_MODE_IDX_INVALID = 0xffff;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID 0xffff")]
        public const int DISPLAYCONFIG_PATH_DESKTOP_IMAGE_IDX_INVALID = 0xffff;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID 0xffff")]
        public const int DISPLAYCONFIG_PATH_SOURCE_MODE_IDX_INVALID = 0xffff;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID 0xffff")]
        public const int DISPLAYCONFIG_PATH_CLONE_GROUP_INVALID = 0xffff;

        [NativeTypeName("#define DISPLAYCONFIG_SOURCE_IN_USE 0x00000001")]
        public const int DISPLAYCONFIG_SOURCE_IN_USE = 0x00000001;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_IN_USE 0x00000001")]
        public const int DISPLAYCONFIG_TARGET_IN_USE = 0x00000001;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCIBLE 0x00000002")]
        public const int DISPLAYCONFIG_TARGET_FORCIBLE = 0x00000002;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT 0x00000004")]
        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT = 0x00000004;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH 0x00000008")]
        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH = 0x00000008;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM 0x00000010")]
        public const int DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM = 0x00000010;

        [NativeTypeName("#define DISPLAYCONFIG_TARGET_IS_HMD 0x00000020")]
        public const int DISPLAYCONFIG_TARGET_IS_HMD = 0x00000020;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_ACTIVE 0x00000001")]
        public const int DISPLAYCONFIG_PATH_ACTIVE = 0x00000001;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_PREFERRED_UNSCALED 0x00000004")]
        public const int DISPLAYCONFIG_PATH_PREFERRED_UNSCALED = 0x00000004;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE 0x00000008")]
        public const int DISPLAYCONFIG_PATH_SUPPORT_VIRTUAL_MODE = 0x00000008;

        [NativeTypeName("#define DISPLAYCONFIG_PATH_VALID_FLAGS 0x0000000D")]
        public const int DISPLAYCONFIG_PATH_VALID_FLAGS = 0x0000000D;

        [NativeTypeName("#define QDC_ALL_PATHS 0x00000001")]
        public const int QDC_ALL_PATHS = 0x00000001;

        [NativeTypeName("#define QDC_ONLY_ACTIVE_PATHS 0x00000002")]
        public const int QDC_ONLY_ACTIVE_PATHS = 0x00000002;

        [NativeTypeName("#define QDC_DATABASE_CURRENT 0x00000004")]
        public const int QDC_DATABASE_CURRENT = 0x00000004;

        [NativeTypeName("#define QDC_VIRTUAL_MODE_AWARE 0x00000010")]
        public const int QDC_VIRTUAL_MODE_AWARE = 0x00000010;

        [NativeTypeName("#define QDC_INCLUDE_HMD 0x00000020")]
        public const int QDC_INCLUDE_HMD = 0x00000020;

        [NativeTypeName("#define SDC_TOPOLOGY_INTERNAL 0x00000001")]
        public const int SDC_TOPOLOGY_INTERNAL = 0x00000001;

        [NativeTypeName("#define SDC_TOPOLOGY_CLONE 0x00000002")]
        public const int SDC_TOPOLOGY_CLONE = 0x00000002;

        [NativeTypeName("#define SDC_TOPOLOGY_EXTEND 0x00000004")]
        public const int SDC_TOPOLOGY_EXTEND = 0x00000004;

        [NativeTypeName("#define SDC_TOPOLOGY_EXTERNAL 0x00000008")]
        public const int SDC_TOPOLOGY_EXTERNAL = 0x00000008;

        [NativeTypeName("#define SDC_TOPOLOGY_SUPPLIED 0x00000010")]
        public const int SDC_TOPOLOGY_SUPPLIED = 0x00000010;

        [NativeTypeName("#define SDC_USE_DATABASE_CURRENT (SDC_TOPOLOGY_INTERNAL | SDC_TOPOLOGY_CLONE | SDC_TOPOLOGY_EXTEND | SDC_TOPOLOGY_EXTERNAL)")]
        public const int SDC_USE_DATABASE_CURRENT = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define SDC_USE_SUPPLIED_DISPLAY_CONFIG 0x00000020")]
        public const int SDC_USE_SUPPLIED_DISPLAY_CONFIG = 0x00000020;

        [NativeTypeName("#define SDC_VALIDATE 0x00000040")]
        public const int SDC_VALIDATE = 0x00000040;

        [NativeTypeName("#define SDC_APPLY 0x00000080")]
        public const int SDC_APPLY = 0x00000080;

        [NativeTypeName("#define SDC_NO_OPTIMIZATION 0x00000100")]
        public const int SDC_NO_OPTIMIZATION = 0x00000100;

        [NativeTypeName("#define SDC_SAVE_TO_DATABASE 0x00000200")]
        public const int SDC_SAVE_TO_DATABASE = 0x00000200;

        [NativeTypeName("#define SDC_ALLOW_CHANGES 0x00000400")]
        public const int SDC_ALLOW_CHANGES = 0x00000400;

        [NativeTypeName("#define SDC_PATH_PERSIST_IF_REQUIRED 0x00000800")]
        public const int SDC_PATH_PERSIST_IF_REQUIRED = 0x00000800;

        [NativeTypeName("#define SDC_FORCE_MODE_ENUMERATION 0x00001000")]
        public const int SDC_FORCE_MODE_ENUMERATION = 0x00001000;

        [NativeTypeName("#define SDC_ALLOW_PATH_ORDER_CHANGES 0x00002000")]
        public const int SDC_ALLOW_PATH_ORDER_CHANGES = 0x00002000;

        [NativeTypeName("#define SDC_VIRTUAL_MODE_AWARE 0x00008000")]
        public const int SDC_VIRTUAL_MODE_AWARE = 0x00008000;

        [NativeTypeName("#define RDH_RECTANGLES 1")]
        public const int RDH_RECTANGLES = 1;

        [NativeTypeName("#define SYSRGN 4")]
        public const int SYSRGN = 4;

        [NativeTypeName("#define GGO_METRICS 0")]
        public const int GGO_METRICS = 0;

        [NativeTypeName("#define GGO_BITMAP 1")]
        public const int GGO_BITMAP = 1;

        [NativeTypeName("#define GGO_NATIVE 2")]
        public const int GGO_NATIVE = 2;

        [NativeTypeName("#define GGO_BEZIER 3")]
        public const int GGO_BEZIER = 3;

        [NativeTypeName("#define GGO_GRAY2_BITMAP 4")]
        public const int GGO_GRAY2_BITMAP = 4;

        [NativeTypeName("#define GGO_GRAY4_BITMAP 5")]
        public const int GGO_GRAY4_BITMAP = 5;

        [NativeTypeName("#define GGO_GRAY8_BITMAP 6")]
        public const int GGO_GRAY8_BITMAP = 6;

        [NativeTypeName("#define GGO_GLYPH_INDEX 0x0080")]
        public const int GGO_GLYPH_INDEX = 0x0080;

        [NativeTypeName("#define GGO_UNHINTED 0x0100")]
        public const int GGO_UNHINTED = 0x0100;

        [NativeTypeName("#define TT_POLYGON_TYPE 24")]
        public const int TT_POLYGON_TYPE = 24;

        [NativeTypeName("#define TT_PRIM_LINE 1")]
        public const int TT_PRIM_LINE = 1;

        [NativeTypeName("#define TT_PRIM_QSPLINE 2")]
        public const int TT_PRIM_QSPLINE = 2;

        [NativeTypeName("#define TT_PRIM_CSPLINE 3")]
        public const int TT_PRIM_CSPLINE = 3;

        [NativeTypeName("#define GCP_DBCS 0x0001")]
        public const int GCP_DBCS = 0x0001;

        [NativeTypeName("#define GCP_REORDER 0x0002")]
        public const int GCP_REORDER = 0x0002;

        [NativeTypeName("#define GCP_USEKERNING 0x0008")]
        public const int GCP_USEKERNING = 0x0008;

        [NativeTypeName("#define GCP_GLYPHSHAPE 0x0010")]
        public const int GCP_GLYPHSHAPE = 0x0010;

        [NativeTypeName("#define GCP_LIGATE 0x0020")]
        public const int GCP_LIGATE = 0x0020;

        [NativeTypeName("#define GCP_DIACRITIC 0x0100")]
        public const int GCP_DIACRITIC = 0x0100;

        [NativeTypeName("#define GCP_KASHIDA 0x0400")]
        public const int GCP_KASHIDA = 0x0400;

        [NativeTypeName("#define GCP_ERROR 0x8000")]
        public const int GCP_ERROR = 0x8000;

        [NativeTypeName("#define FLI_MASK 0x103B")]
        public const int FLI_MASK = 0x103B;

        [NativeTypeName("#define GCP_JUSTIFY 0x00010000L")]
        public const int GCP_JUSTIFY = 0x00010000;

        [NativeTypeName("#define FLI_GLYPHS 0x00040000L")]
        public const int FLI_GLYPHS = 0x00040000;

        [NativeTypeName("#define GCP_CLASSIN 0x00080000L")]
        public const int GCP_CLASSIN = 0x00080000;

        [NativeTypeName("#define GCP_MAXEXTENT 0x00100000L")]
        public const int GCP_MAXEXTENT = 0x00100000;

        [NativeTypeName("#define GCP_JUSTIFYIN 0x00200000L")]
        public const int GCP_JUSTIFYIN = 0x00200000;

        [NativeTypeName("#define GCP_DISPLAYZWG 0x00400000L")]
        public const int GCP_DISPLAYZWG = 0x00400000;

        [NativeTypeName("#define GCP_SYMSWAPOFF 0x00800000L")]
        public const int GCP_SYMSWAPOFF = 0x00800000;

        [NativeTypeName("#define GCP_NUMERICOVERRIDE 0x01000000L")]
        public const int GCP_NUMERICOVERRIDE = 0x01000000;

        [NativeTypeName("#define GCP_NEUTRALOVERRIDE 0x02000000L")]
        public const int GCP_NEUTRALOVERRIDE = 0x02000000;

        [NativeTypeName("#define GCP_NUMERICSLATIN 0x04000000L")]
        public const int GCP_NUMERICSLATIN = 0x04000000;

        [NativeTypeName("#define GCP_NUMERICSLOCAL 0x08000000L")]
        public const int GCP_NUMERICSLOCAL = 0x08000000;

        [NativeTypeName("#define GCPCLASS_LATIN 1")]
        public const int GCPCLASS_LATIN = 1;

        [NativeTypeName("#define GCPCLASS_HEBREW 2")]
        public const int GCPCLASS_HEBREW = 2;

        [NativeTypeName("#define GCPCLASS_ARABIC 2")]
        public const int GCPCLASS_ARABIC = 2;

        [NativeTypeName("#define GCPCLASS_NEUTRAL 3")]
        public const int GCPCLASS_NEUTRAL = 3;

        [NativeTypeName("#define GCPCLASS_LOCALNUMBER 4")]
        public const int GCPCLASS_LOCALNUMBER = 4;

        [NativeTypeName("#define GCPCLASS_LATINNUMBER 5")]
        public const int GCPCLASS_LATINNUMBER = 5;

        [NativeTypeName("#define GCPCLASS_LATINNUMERICTERMINATOR 6")]
        public const int GCPCLASS_LATINNUMERICTERMINATOR = 6;

        [NativeTypeName("#define GCPCLASS_LATINNUMERICSEPARATOR 7")]
        public const int GCPCLASS_LATINNUMERICSEPARATOR = 7;

        [NativeTypeName("#define GCPCLASS_NUMERICSEPARATOR 8")]
        public const int GCPCLASS_NUMERICSEPARATOR = 8;

        [NativeTypeName("#define GCPCLASS_PREBOUNDLTR 0x80")]
        public const int GCPCLASS_PREBOUNDLTR = 0x80;

        [NativeTypeName("#define GCPCLASS_PREBOUNDRTL 0x40")]
        public const int GCPCLASS_PREBOUNDRTL = 0x40;

        [NativeTypeName("#define GCPCLASS_POSTBOUNDLTR 0x20")]
        public const int GCPCLASS_POSTBOUNDLTR = 0x20;

        [NativeTypeName("#define GCPCLASS_POSTBOUNDRTL 0x10")]
        public const int GCPCLASS_POSTBOUNDRTL = 0x10;

        [NativeTypeName("#define GCPGLYPH_LINKBEFORE 0x8000")]
        public const int GCPGLYPH_LINKBEFORE = 0x8000;

        [NativeTypeName("#define GCPGLYPH_LINKAFTER 0x4000")]
        public const int GCPGLYPH_LINKAFTER = 0x4000;

        [NativeTypeName("#define TT_AVAILABLE 0x0001")]
        public const int TT_AVAILABLE = 0x0001;

        [NativeTypeName("#define TT_ENABLED 0x0002")]
        public const int TT_ENABLED = 0x0002;

        [NativeTypeName("#define PFD_TYPE_RGBA 0")]
        public const int PFD_TYPE_RGBA = 0;

        [NativeTypeName("#define PFD_TYPE_COLORINDEX 1")]
        public const int PFD_TYPE_COLORINDEX = 1;

        [NativeTypeName("#define PFD_MAIN_PLANE 0")]
        public const int PFD_MAIN_PLANE = 0;

        [NativeTypeName("#define PFD_OVERLAY_PLANE 1")]
        public const int PFD_OVERLAY_PLANE = 1;

        [NativeTypeName("#define PFD_UNDERLAY_PLANE (-1)")]
        public const int PFD_UNDERLAY_PLANE = (-1);

        [NativeTypeName("#define PFD_DOUBLEBUFFER 0x00000001")]
        public const int PFD_DOUBLEBUFFER = 0x00000001;

        [NativeTypeName("#define PFD_STEREO 0x00000002")]
        public const int PFD_STEREO = 0x00000002;

        [NativeTypeName("#define PFD_DRAW_TO_WINDOW 0x00000004")]
        public const int PFD_DRAW_TO_WINDOW = 0x00000004;

        [NativeTypeName("#define PFD_DRAW_TO_BITMAP 0x00000008")]
        public const int PFD_DRAW_TO_BITMAP = 0x00000008;

        [NativeTypeName("#define PFD_SUPPORT_GDI 0x00000010")]
        public const int PFD_SUPPORT_GDI = 0x00000010;

        [NativeTypeName("#define PFD_SUPPORT_OPENGL 0x00000020")]
        public const int PFD_SUPPORT_OPENGL = 0x00000020;

        [NativeTypeName("#define PFD_GENERIC_FORMAT 0x00000040")]
        public const int PFD_GENERIC_FORMAT = 0x00000040;

        [NativeTypeName("#define PFD_NEED_PALETTE 0x00000080")]
        public const int PFD_NEED_PALETTE = 0x00000080;

        [NativeTypeName("#define PFD_NEED_SYSTEM_PALETTE 0x00000100")]
        public const int PFD_NEED_SYSTEM_PALETTE = 0x00000100;

        [NativeTypeName("#define PFD_SWAP_EXCHANGE 0x00000200")]
        public const int PFD_SWAP_EXCHANGE = 0x00000200;

        [NativeTypeName("#define PFD_SWAP_COPY 0x00000400")]
        public const int PFD_SWAP_COPY = 0x00000400;

        [NativeTypeName("#define PFD_SWAP_LAYER_BUFFERS 0x00000800")]
        public const int PFD_SWAP_LAYER_BUFFERS = 0x00000800;

        [NativeTypeName("#define PFD_GENERIC_ACCELERATED 0x00001000")]
        public const int PFD_GENERIC_ACCELERATED = 0x00001000;

        [NativeTypeName("#define PFD_SUPPORT_DIRECTDRAW 0x00002000")]
        public const int PFD_SUPPORT_DIRECTDRAW = 0x00002000;

        [NativeTypeName("#define PFD_DIRECT3D_ACCELERATED 0x00004000")]
        public const int PFD_DIRECT3D_ACCELERATED = 0x00004000;

        [NativeTypeName("#define PFD_SUPPORT_COMPOSITION 0x00008000")]
        public const int PFD_SUPPORT_COMPOSITION = 0x00008000;

        [NativeTypeName("#define PFD_DEPTH_DONTCARE 0x20000000")]
        public const int PFD_DEPTH_DONTCARE = 0x20000000;

        [NativeTypeName("#define PFD_DOUBLEBUFFER_DONTCARE 0x40000000")]
        public const int PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;

        [NativeTypeName("#define PFD_STEREO_DONTCARE 0x80000000")]
        public const uint PFD_STEREO_DONTCARE = 0x80000000;

        [NativeTypeName("#define AddFontResource AddFontResourceW")]
        public static delegate*<ushort*, int> AddFontResource => &AddFontResourceW;

        [NativeTypeName("#define CopyMetaFile CopyMetaFileW")]
        public static delegate*<IntPtr, ushort*, IntPtr> CopyMetaFile => &CopyMetaFileW;

        [NativeTypeName("#define CreateDC CreateDCW")]
        public static delegate*<ushort*, ushort*, ushort*, DEVMODEW*, IntPtr> CreateDC => &CreateDCW;

        [NativeTypeName("#define CreateFontIndirect CreateFontIndirectW")]
        public static delegate*<LOGFONTW*, IntPtr> CreateFontIndirect => &CreateFontIndirectW;

        [NativeTypeName("#define CreateFont CreateFontW")]
        public static delegate*<int, int, int, int, int, uint, uint, uint, uint, uint, uint, uint, uint, ushort*, IntPtr> CreateFont => &CreateFontW;

        [NativeTypeName("#define CreateIC CreateICW")]
        public static delegate*<ushort*, ushort*, ushort*, DEVMODEW*, IntPtr> CreateIC => &CreateICW;

        [NativeTypeName("#define CreateMetaFile CreateMetaFileW")]
        public static delegate*<ushort*, IntPtr> CreateMetaFile => &CreateMetaFileW;

        [NativeTypeName("#define CreateScalableFontResource CreateScalableFontResourceW")]
        public static delegate*<uint, ushort*, ushort*, ushort*, int> CreateScalableFontResource => &CreateScalableFontResourceW;

        [NativeTypeName("#define DM_UPDATE 1")]
        public const int DM_UPDATE = 1;

        [NativeTypeName("#define DM_COPY 2")]
        public const int DM_COPY = 2;

        [NativeTypeName("#define DM_PROMPT 4")]
        public const int DM_PROMPT = 4;

        [NativeTypeName("#define DM_MODIFY 8")]
        public const int DM_MODIFY = 8;

        [NativeTypeName("#define DM_IN_BUFFER DM_MODIFY")]
        public const int DM_IN_BUFFER = 8;

        [NativeTypeName("#define DM_IN_PROMPT DM_PROMPT")]
        public const int DM_IN_PROMPT = 4;

        [NativeTypeName("#define DM_OUT_BUFFER DM_COPY")]
        public const int DM_OUT_BUFFER = 2;

        [NativeTypeName("#define DM_OUT_DEFAULT DM_UPDATE")]
        public const int DM_OUT_DEFAULT = 1;

        [NativeTypeName("#define DC_FIELDS 1")]
        public const int DC_FIELDS = 1;

        [NativeTypeName("#define DC_PAPERS 2")]
        public const int DC_PAPERS = 2;

        [NativeTypeName("#define DC_PAPERSIZE 3")]
        public const int DC_PAPERSIZE = 3;

        [NativeTypeName("#define DC_MINEXTENT 4")]
        public const int DC_MINEXTENT = 4;

        [NativeTypeName("#define DC_MAXEXTENT 5")]
        public const int DC_MAXEXTENT = 5;

        [NativeTypeName("#define DC_BINS 6")]
        public const int DC_BINS = 6;

        [NativeTypeName("#define DC_DUPLEX 7")]
        public const int DC_DUPLEX = 7;

        [NativeTypeName("#define DC_SIZE 8")]
        public const int DC_SIZE = 8;

        [NativeTypeName("#define DC_EXTRA 9")]
        public const int DC_EXTRA = 9;

        [NativeTypeName("#define DC_VERSION 10")]
        public const int DC_VERSION = 10;

        [NativeTypeName("#define DC_DRIVER 11")]
        public const int DC_DRIVER = 11;

        [NativeTypeName("#define DC_BINNAMES 12")]
        public const int DC_BINNAMES = 12;

        [NativeTypeName("#define DC_ENUMRESOLUTIONS 13")]
        public const int DC_ENUMRESOLUTIONS = 13;

        [NativeTypeName("#define DC_FILEDEPENDENCIES 14")]
        public const int DC_FILEDEPENDENCIES = 14;

        [NativeTypeName("#define DC_TRUETYPE 15")]
        public const int DC_TRUETYPE = 15;

        [NativeTypeName("#define DC_PAPERNAMES 16")]
        public const int DC_PAPERNAMES = 16;

        [NativeTypeName("#define DC_ORIENTATION 17")]
        public const int DC_ORIENTATION = 17;

        [NativeTypeName("#define DC_COPIES 18")]
        public const int DC_COPIES = 18;

        [NativeTypeName("#define DC_BINADJUST 19")]
        public const int DC_BINADJUST = 19;

        [NativeTypeName("#define DC_EMF_COMPLIANT 20")]
        public const int DC_EMF_COMPLIANT = 20;

        [NativeTypeName("#define DC_DATATYPE_PRODUCED 21")]
        public const int DC_DATATYPE_PRODUCED = 21;

        [NativeTypeName("#define DC_COLLATE 22")]
        public const int DC_COLLATE = 22;

        [NativeTypeName("#define DC_MANUFACTURER 23")]
        public const int DC_MANUFACTURER = 23;

        [NativeTypeName("#define DC_MODEL 24")]
        public const int DC_MODEL = 24;

        [NativeTypeName("#define DC_PERSONALITY 25")]
        public const int DC_PERSONALITY = 25;

        [NativeTypeName("#define DC_PRINTRATE 26")]
        public const int DC_PRINTRATE = 26;

        [NativeTypeName("#define DC_PRINTRATEUNIT 27")]
        public const int DC_PRINTRATEUNIT = 27;

        [NativeTypeName("#define PRINTRATEUNIT_PPM 1")]
        public const int PRINTRATEUNIT_PPM = 1;

        [NativeTypeName("#define PRINTRATEUNIT_CPS 2")]
        public const int PRINTRATEUNIT_CPS = 2;

        [NativeTypeName("#define PRINTRATEUNIT_LPM 3")]
        public const int PRINTRATEUNIT_LPM = 3;

        [NativeTypeName("#define PRINTRATEUNIT_IPM 4")]
        public const int PRINTRATEUNIT_IPM = 4;

        [NativeTypeName("#define DC_PRINTERMEM 28")]
        public const int DC_PRINTERMEM = 28;

        [NativeTypeName("#define DC_MEDIAREADY 29")]
        public const int DC_MEDIAREADY = 29;

        [NativeTypeName("#define DC_STAPLE 30")]
        public const int DC_STAPLE = 30;

        [NativeTypeName("#define DC_PRINTRATEPPM 31")]
        public const int DC_PRINTRATEPPM = 31;

        [NativeTypeName("#define DC_COLORDEVICE 32")]
        public const int DC_COLORDEVICE = 32;

        [NativeTypeName("#define DC_NUP 33")]
        public const int DC_NUP = 33;

        [NativeTypeName("#define DC_MEDIATYPENAMES 34")]
        public const int DC_MEDIATYPENAMES = 34;

        [NativeTypeName("#define DC_MEDIATYPES 35")]
        public const int DC_MEDIATYPES = 35;

        [NativeTypeName("#define DCTT_BITMAP 0x0000001L")]
        public const int DCTT_BITMAP = 0x0000001;

        [NativeTypeName("#define DCTT_DOWNLOAD 0x0000002L")]
        public const int DCTT_DOWNLOAD = 0x0000002;

        [NativeTypeName("#define DCTT_SUBDEV 0x0000004L")]
        public const int DCTT_SUBDEV = 0x0000004;

        [NativeTypeName("#define DCTT_DOWNLOAD_OUTLINE 0x0000008L")]
        public const int DCTT_DOWNLOAD_OUTLINE = 0x0000008;

        [NativeTypeName("#define DCBA_FACEUPNONE 0x0000")]
        public const int DCBA_FACEUPNONE = 0x0000;

        [NativeTypeName("#define DCBA_FACEUPCENTER 0x0001")]
        public const int DCBA_FACEUPCENTER = 0x0001;

        [NativeTypeName("#define DCBA_FACEUPLEFT 0x0002")]
        public const int DCBA_FACEUPLEFT = 0x0002;

        [NativeTypeName("#define DCBA_FACEUPRIGHT 0x0003")]
        public const int DCBA_FACEUPRIGHT = 0x0003;

        [NativeTypeName("#define DCBA_FACEDOWNNONE 0x0100")]
        public const int DCBA_FACEDOWNNONE = 0x0100;

        [NativeTypeName("#define DCBA_FACEDOWNCENTER 0x0101")]
        public const int DCBA_FACEDOWNCENTER = 0x0101;

        [NativeTypeName("#define DCBA_FACEDOWNLEFT 0x0102")]
        public const int DCBA_FACEDOWNLEFT = 0x0102;

        [NativeTypeName("#define DCBA_FACEDOWNRIGHT 0x0103")]
        public const int DCBA_FACEDOWNRIGHT = 0x0103;

        [NativeTypeName("#define EnumFontFamiliesEx EnumFontFamiliesExW")]
        public static delegate*<IntPtr, LOGFONTW*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int>, nint, uint, int> EnumFontFamiliesEx => &EnumFontFamiliesExW;

        [NativeTypeName("#define EnumFontFamilies EnumFontFamiliesW")]
        public static delegate*<IntPtr, ushort*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int>, nint, int> EnumFontFamilies => &EnumFontFamiliesW;

        [NativeTypeName("#define EnumFonts EnumFontsW")]
        public static delegate*<IntPtr, ushort*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, nint, int>, nint, int> EnumFonts => &EnumFontsW;

        [NativeTypeName("#define GetCharWidth GetCharWidthW")]
        public static delegate*<IntPtr, uint, uint, int*, int> GetCharWidth => &GetCharWidthW;

        [NativeTypeName("#define GetCharWidth32 GetCharWidth32W")]
        public static delegate*<IntPtr, uint, uint, int*, int> GetCharWidth32 => &GetCharWidth32W;

        [NativeTypeName("#define GetCharWidthFloat GetCharWidthFloatW")]
        public static delegate*<IntPtr, uint, uint, float*, int> GetCharWidthFloat => &GetCharWidthFloatW;

        [NativeTypeName("#define GetCharABCWidths GetCharABCWidthsW")]
        public static delegate*<IntPtr, uint, uint, ABC*, int> GetCharABCWidths => &GetCharABCWidthsW;

        [NativeTypeName("#define GetCharABCWidthsFloat GetCharABCWidthsFloatW")]
        public static delegate*<IntPtr, uint, uint, ABCFLOAT*, int> GetCharABCWidthsFloat => &GetCharABCWidthsFloatW;

        [NativeTypeName("#define GetGlyphOutline GetGlyphOutlineW")]
        public static delegate*<IntPtr, uint, uint, GLYPHMETRICS*, uint, void*, MAT2*, uint> GetGlyphOutline => &GetGlyphOutlineW;

        [NativeTypeName("#define GetMetaFile GetMetaFileW")]
        public static delegate*<ushort*, IntPtr> GetMetaFile => &GetMetaFileW;

        [NativeTypeName("#define GetOutlineTextMetrics GetOutlineTextMetricsW")]
        public static delegate*<IntPtr, uint, OUTLINETEXTMETRICW*, uint> GetOutlineTextMetrics => &GetOutlineTextMetricsW;

        [NativeTypeName("#define GetTextExtentPoint GetTextExtentPointW")]
        public static delegate*<IntPtr, ushort*, int, SIZE*, int> GetTextExtentPoint => &GetTextExtentPointW;

        [NativeTypeName("#define GetTextExtentPoint32 GetTextExtentPoint32W")]
        public static delegate*<IntPtr, ushort*, int, SIZE*, int> GetTextExtentPoint32 => &GetTextExtentPoint32W;

        [NativeTypeName("#define GetTextExtentExPoint GetTextExtentExPointW")]
        public static delegate*<IntPtr, ushort*, int, int, int*, int*, SIZE*, int> GetTextExtentExPoint => &GetTextExtentExPointW;

        [NativeTypeName("#define GetCharacterPlacement GetCharacterPlacementW")]
        public static delegate*<IntPtr, ushort*, int, int, GCP_RESULTSW*, uint, uint> GetCharacterPlacement => &GetCharacterPlacementW;

        [NativeTypeName("#define GS_8BIT_INDICES 0x00000001")]
        public const int GS_8BIT_INDICES = 0x00000001;

        [NativeTypeName("#define GGI_MARK_NONEXISTING_GLYPHS 0X0001")]
        public const int GGI_MARK_NONEXISTING_GLYPHS = 0X0001;

        [NativeTypeName("#define GetGlyphIndices GetGlyphIndicesW")]
        public static delegate*<IntPtr, ushort*, int, ushort*, uint, uint> GetGlyphIndices => &GetGlyphIndicesW;

        [NativeTypeName("#define STAMP_DESIGNVECTOR (0x8000000 + 'd' + ('v' << 8))")]
        public const int STAMP_DESIGNVECTOR = (0x8000000 + 'd' + ('v' << 8));

        [NativeTypeName("#define STAMP_AXESLIST (0x8000000 + 'a' + ('l' << 8))")]
        public const int STAMP_AXESLIST = (0x8000000 + 'a' + ('l' << 8));

        [NativeTypeName("#define STAMP_TRUETYPE_VARIATION (0x8000000 + 't' + ('v' << 8))")]
        public const int STAMP_TRUETYPE_VARIATION = (0x8000000 + 't' + ('v' << 8));

        [NativeTypeName("#define STAMP_CFF2 (0x8000000 + 'c' + ('v' << 8))")]
        public const int STAMP_CFF2 = (0x8000000 + 'c' + ('v' << 8));

        [NativeTypeName("#define MM_MAX_NUMAXES 16")]
        public const int MM_MAX_NUMAXES = 16;

        [NativeTypeName("#define AddFontResourceEx AddFontResourceExW")]
        public static delegate*<ushort*, uint, void*, int> AddFontResourceEx => &AddFontResourceExW;

        [NativeTypeName("#define RemoveFontResourceEx RemoveFontResourceExW")]
        public static delegate*<ushort*, uint, void*, int> RemoveFontResourceEx => &RemoveFontResourceExW;

        [NativeTypeName("#define FR_PRIVATE 0x10")]
        public const int FR_PRIVATE = 0x10;

        [NativeTypeName("#define FR_NOT_ENUM 0x20")]
        public const int FR_NOT_ENUM = 0x20;

        [NativeTypeName("#define MM_MAX_AXES_NAMELEN 16")]
        public const int MM_MAX_AXES_NAMELEN = 16;

        [NativeTypeName("#define CreateFontIndirectEx CreateFontIndirectExW")]
        public static delegate*<ENUMLOGFONTEXDVW*, IntPtr> CreateFontIndirectEx => &CreateFontIndirectExW;

        [NativeTypeName("#define ResetDC ResetDCW")]
        public static delegate*<IntPtr, DEVMODEW*, IntPtr> ResetDC => &ResetDCW;

        [NativeTypeName("#define RemoveFontResource RemoveFontResourceW")]
        public static delegate*<ushort*, int> RemoveFontResource => &RemoveFontResourceW;

        [NativeTypeName("#define AC_SRC_OVER 0x00")]
        public const int AC_SRC_OVER = 0x00;

        [NativeTypeName("#define AC_SRC_ALPHA 0x01")]
        public const int AC_SRC_ALPHA = 0x01;

        [NativeTypeName("#define GRADIENT_FILL_RECT_H 0x00000000")]
        public const int GRADIENT_FILL_RECT_H = 0x00000000;

        [NativeTypeName("#define GRADIENT_FILL_RECT_V 0x00000001")]
        public const int GRADIENT_FILL_RECT_V = 0x00000001;

        [NativeTypeName("#define GRADIENT_FILL_TRIANGLE 0x00000002")]
        public const int GRADIENT_FILL_TRIANGLE = 0x00000002;

        [NativeTypeName("#define GRADIENT_FILL_OP_FLAG 0x000000ff")]
        public const int GRADIENT_FILL_OP_FLAG = 0x000000ff;

        [NativeTypeName("#define CopyEnhMetaFile CopyEnhMetaFileW")]
        public static delegate*<IntPtr, ushort*, IntPtr> CopyEnhMetaFile => &CopyEnhMetaFileW;

        [NativeTypeName("#define CreateEnhMetaFile CreateEnhMetaFileW")]
        public static delegate*<IntPtr, ushort*, RECT*, ushort*, IntPtr> CreateEnhMetaFile => &CreateEnhMetaFileW;

        [NativeTypeName("#define GetEnhMetaFile GetEnhMetaFileW")]
        public static delegate*<ushort*, IntPtr> GetEnhMetaFile => &GetEnhMetaFileW;

        [NativeTypeName("#define GetEnhMetaFileDescription GetEnhMetaFileDescriptionW")]
        public static delegate*<IntPtr, uint, ushort*, uint> GetEnhMetaFileDescription => &GetEnhMetaFileDescriptionW;

        [NativeTypeName("#define GetTextMetrics GetTextMetricsW")]
        public static delegate*<IntPtr, TEXTMETRICW*, int> GetTextMetrics => &GetTextMetricsW;

        [NativeTypeName("#define CA_NEGATIVE 0x0001")]
        public const int CA_NEGATIVE = 0x0001;

        [NativeTypeName("#define CA_LOG_FILTER 0x0002")]
        public const int CA_LOG_FILTER = 0x0002;

        [NativeTypeName("#define ILLUMINANT_DEVICE_DEFAULT 0")]
        public const int ILLUMINANT_DEVICE_DEFAULT = 0;

        [NativeTypeName("#define ILLUMINANT_A 1")]
        public const int ILLUMINANT_A = 1;

        [NativeTypeName("#define ILLUMINANT_B 2")]
        public const int ILLUMINANT_B = 2;

        [NativeTypeName("#define ILLUMINANT_C 3")]
        public const int ILLUMINANT_C = 3;

        [NativeTypeName("#define ILLUMINANT_D50 4")]
        public const int ILLUMINANT_D50 = 4;

        [NativeTypeName("#define ILLUMINANT_D55 5")]
        public const int ILLUMINANT_D55 = 5;

        [NativeTypeName("#define ILLUMINANT_D65 6")]
        public const int ILLUMINANT_D65 = 6;

        [NativeTypeName("#define ILLUMINANT_D75 7")]
        public const int ILLUMINANT_D75 = 7;

        [NativeTypeName("#define ILLUMINANT_F2 8")]
        public const int ILLUMINANT_F2 = 8;

        [NativeTypeName("#define ILLUMINANT_MAX_INDEX ILLUMINANT_F2")]
        public const int ILLUMINANT_MAX_INDEX = 8;

        [NativeTypeName("#define ILLUMINANT_TUNGSTEN ILLUMINANT_A")]
        public const int ILLUMINANT_TUNGSTEN = 1;

        [NativeTypeName("#define ILLUMINANT_DAYLIGHT ILLUMINANT_C")]
        public const int ILLUMINANT_DAYLIGHT = 3;

        [NativeTypeName("#define ILLUMINANT_FLUORESCENT ILLUMINANT_F2")]
        public const int ILLUMINANT_FLUORESCENT = 8;

        [NativeTypeName("#define ILLUMINANT_NTSC ILLUMINANT_C")]
        public const int ILLUMINANT_NTSC = 3;

        [NativeTypeName("#define RGB_GAMMA_MIN (WORD)02500")]
        public const ushort RGB_GAMMA_MIN = (ushort)(02500);

        [NativeTypeName("#define RGB_GAMMA_MAX (WORD)65000")]
        public const ushort RGB_GAMMA_MAX = (ushort)(65000);

        [NativeTypeName("#define REFERENCE_WHITE_MIN (WORD)6000")]
        public const ushort REFERENCE_WHITE_MIN = (ushort)(6000);

        [NativeTypeName("#define REFERENCE_WHITE_MAX (WORD)10000")]
        public const ushort REFERENCE_WHITE_MAX = (ushort)(10000);

        [NativeTypeName("#define REFERENCE_BLACK_MIN (WORD)0")]
        public const ushort REFERENCE_BLACK_MIN = (ushort)(0);

        [NativeTypeName("#define REFERENCE_BLACK_MAX (WORD)4000")]
        public const ushort REFERENCE_BLACK_MAX = (ushort)(4000);

        [NativeTypeName("#define COLOR_ADJ_MIN (SHORT)-100")]
        public const short COLOR_ADJ_MIN = (short)(-100);

        [NativeTypeName("#define COLOR_ADJ_MAX (SHORT)100")]
        public const short COLOR_ADJ_MAX = (short)(100);

        [NativeTypeName("#define DI_APPBANDING 0x00000001")]
        public const int DI_APPBANDING = 0x00000001;

        [NativeTypeName("#define DI_ROPS_READ_DESTINATION 0x00000002")]
        public const int DI_ROPS_READ_DESTINATION = 0x00000002;

        [NativeTypeName("#define StartDoc StartDocW")]
        public static delegate*<IntPtr, DOCINFOW*, int> StartDoc => &StartDocW;

        [NativeTypeName("#define GetObject GetObjectW")]
        public static delegate*<IntPtr, int, void*, int> GetObject => &GetObjectW;

        [NativeTypeName("#define TextOut TextOutW")]
        public static delegate*<IntPtr, int, int, ushort*, int, int> TextOut => &TextOutW;

        [NativeTypeName("#define ExtTextOut ExtTextOutW")]
        public static delegate*<IntPtr, int, int, uint, RECT*, ushort*, uint, int*, int> ExtTextOut => &ExtTextOutW;

        [NativeTypeName("#define PolyTextOut PolyTextOutW")]
        public static delegate*<IntPtr, POLYTEXTW*, int, int> PolyTextOut => &PolyTextOutW;

        [NativeTypeName("#define GetTextFace GetTextFaceW")]
        public static delegate*<IntPtr, int, ushort*, int> GetTextFace => &GetTextFaceW;

        [NativeTypeName("#define FONTMAPPER_MAX 10")]
        public const int FONTMAPPER_MAX = 10;

        [NativeTypeName("#define GetKerningPairs GetKerningPairsW")]
        public static delegate*<IntPtr, uint, KERNINGPAIR*, uint> GetKerningPairs => &GetKerningPairsW;

        [NativeTypeName("#define ICM_OFF 1")]
        public const int ICM_OFF = 1;

        [NativeTypeName("#define ICM_ON 2")]
        public const int ICM_ON = 2;

        [NativeTypeName("#define ICM_QUERY 3")]
        public const int ICM_QUERY = 3;

        [NativeTypeName("#define ICM_DONE_OUTSIDEDC 4")]
        public const int ICM_DONE_OUTSIDEDC = 4;

        [NativeTypeName("#define GetLogColorSpace GetLogColorSpaceW")]
        public static delegate*<IntPtr, LOGCOLORSPACEW*, uint, int> GetLogColorSpace => &GetLogColorSpaceW;

        [NativeTypeName("#define CreateColorSpace CreateColorSpaceW")]
        public static delegate*<LOGCOLORSPACEW*, IntPtr> CreateColorSpace => &CreateColorSpaceW;

        [NativeTypeName("#define GetICMProfile GetICMProfileW")]
        public static delegate*<IntPtr, uint*, ushort*, int> GetICMProfile => &GetICMProfileW;

        [NativeTypeName("#define SetICMProfile SetICMProfileW")]
        public static delegate*<IntPtr, ushort*, int> SetICMProfile => &SetICMProfileW;

        [NativeTypeName("#define EnumICMProfiles EnumICMProfilesW")]
        public static delegate*<IntPtr, delegate* unmanaged<ushort*, nint, int>, nint, int> EnumICMProfiles => &EnumICMProfilesW;

        [NativeTypeName("#define UpdateICMRegKey UpdateICMRegKeyW")]
        public static delegate*<uint, ushort*, ushort*, uint, int> UpdateICMRegKey => &UpdateICMRegKeyW;

        [NativeTypeName("#define ENHMETA_SIGNATURE 0x464D4520")]
        public const int ENHMETA_SIGNATURE = 0x464D4520;

        [NativeTypeName("#define ENHMETA_STOCK_OBJECT 0x80000000")]
        public const uint ENHMETA_STOCK_OBJECT = 0x80000000;

        [NativeTypeName("#define EMR_HEADER 1")]
        public const int EMR_HEADER = 1;

        [NativeTypeName("#define EMR_POLYBEZIER 2")]
        public const int EMR_POLYBEZIER = 2;

        [NativeTypeName("#define EMR_POLYGON 3")]
        public const int EMR_POLYGON = 3;

        [NativeTypeName("#define EMR_POLYLINE 4")]
        public const int EMR_POLYLINE = 4;

        [NativeTypeName("#define EMR_POLYBEZIERTO 5")]
        public const int EMR_POLYBEZIERTO = 5;

        [NativeTypeName("#define EMR_POLYLINETO 6")]
        public const int EMR_POLYLINETO = 6;

        [NativeTypeName("#define EMR_POLYPOLYLINE 7")]
        public const int EMR_POLYPOLYLINE = 7;

        [NativeTypeName("#define EMR_POLYPOLYGON 8")]
        public const int EMR_POLYPOLYGON = 8;

        [NativeTypeName("#define EMR_SETWINDOWEXTEX 9")]
        public const int EMR_SETWINDOWEXTEX = 9;

        [NativeTypeName("#define EMR_SETWINDOWORGEX 10")]
        public const int EMR_SETWINDOWORGEX = 10;

        [NativeTypeName("#define EMR_SETVIEWPORTEXTEX 11")]
        public const int EMR_SETVIEWPORTEXTEX = 11;

        [NativeTypeName("#define EMR_SETVIEWPORTORGEX 12")]
        public const int EMR_SETVIEWPORTORGEX = 12;

        [NativeTypeName("#define EMR_SETBRUSHORGEX 13")]
        public const int EMR_SETBRUSHORGEX = 13;

        [NativeTypeName("#define EMR_EOF 14")]
        public const int EMR_EOF = 14;

        [NativeTypeName("#define EMR_SETPIXELV 15")]
        public const int EMR_SETPIXELV = 15;

        [NativeTypeName("#define EMR_SETMAPPERFLAGS 16")]
        public const int EMR_SETMAPPERFLAGS = 16;

        [NativeTypeName("#define EMR_SETMAPMODE 17")]
        public const int EMR_SETMAPMODE = 17;

        [NativeTypeName("#define EMR_SETBKMODE 18")]
        public const int EMR_SETBKMODE = 18;

        [NativeTypeName("#define EMR_SETPOLYFILLMODE 19")]
        public const int EMR_SETPOLYFILLMODE = 19;

        [NativeTypeName("#define EMR_SETROP2 20")]
        public const int EMR_SETROP2 = 20;

        [NativeTypeName("#define EMR_SETSTRETCHBLTMODE 21")]
        public const int EMR_SETSTRETCHBLTMODE = 21;

        [NativeTypeName("#define EMR_SETTEXTALIGN 22")]
        public const int EMR_SETTEXTALIGN = 22;

        [NativeTypeName("#define EMR_SETCOLORADJUSTMENT 23")]
        public const int EMR_SETCOLORADJUSTMENT = 23;

        [NativeTypeName("#define EMR_SETTEXTCOLOR 24")]
        public const int EMR_SETTEXTCOLOR = 24;

        [NativeTypeName("#define EMR_SETBKCOLOR 25")]
        public const int EMR_SETBKCOLOR = 25;

        [NativeTypeName("#define EMR_OFFSETCLIPRGN 26")]
        public const int EMR_OFFSETCLIPRGN = 26;

        [NativeTypeName("#define EMR_MOVETOEX 27")]
        public const int EMR_MOVETOEX = 27;

        [NativeTypeName("#define EMR_SETMETARGN 28")]
        public const int EMR_SETMETARGN = 28;

        [NativeTypeName("#define EMR_EXCLUDECLIPRECT 29")]
        public const int EMR_EXCLUDECLIPRECT = 29;

        [NativeTypeName("#define EMR_INTERSECTCLIPRECT 30")]
        public const int EMR_INTERSECTCLIPRECT = 30;

        [NativeTypeName("#define EMR_SCALEVIEWPORTEXTEX 31")]
        public const int EMR_SCALEVIEWPORTEXTEX = 31;

        [NativeTypeName("#define EMR_SCALEWINDOWEXTEX 32")]
        public const int EMR_SCALEWINDOWEXTEX = 32;

        [NativeTypeName("#define EMR_SAVEDC 33")]
        public const int EMR_SAVEDC = 33;

        [NativeTypeName("#define EMR_RESTOREDC 34")]
        public const int EMR_RESTOREDC = 34;

        [NativeTypeName("#define EMR_SETWORLDTRANSFORM 35")]
        public const int EMR_SETWORLDTRANSFORM = 35;

        [NativeTypeName("#define EMR_MODIFYWORLDTRANSFORM 36")]
        public const int EMR_MODIFYWORLDTRANSFORM = 36;

        [NativeTypeName("#define EMR_SELECTOBJECT 37")]
        public const int EMR_SELECTOBJECT = 37;

        [NativeTypeName("#define EMR_CREATEPEN 38")]
        public const int EMR_CREATEPEN = 38;

        [NativeTypeName("#define EMR_CREATEBRUSHINDIRECT 39")]
        public const int EMR_CREATEBRUSHINDIRECT = 39;

        [NativeTypeName("#define EMR_DELETEOBJECT 40")]
        public const int EMR_DELETEOBJECT = 40;

        [NativeTypeName("#define EMR_ANGLEARC 41")]
        public const int EMR_ANGLEARC = 41;

        [NativeTypeName("#define EMR_ELLIPSE 42")]
        public const int EMR_ELLIPSE = 42;

        [NativeTypeName("#define EMR_RECTANGLE 43")]
        public const int EMR_RECTANGLE = 43;

        [NativeTypeName("#define EMR_ROUNDRECT 44")]
        public const int EMR_ROUNDRECT = 44;

        [NativeTypeName("#define EMR_ARC 45")]
        public const int EMR_ARC = 45;

        [NativeTypeName("#define EMR_CHORD 46")]
        public const int EMR_CHORD = 46;

        [NativeTypeName("#define EMR_PIE 47")]
        public const int EMR_PIE = 47;

        [NativeTypeName("#define EMR_SELECTPALETTE 48")]
        public const int EMR_SELECTPALETTE = 48;

        [NativeTypeName("#define EMR_CREATEPALETTE 49")]
        public const int EMR_CREATEPALETTE = 49;

        [NativeTypeName("#define EMR_SETPALETTEENTRIES 50")]
        public const int EMR_SETPALETTEENTRIES = 50;

        [NativeTypeName("#define EMR_RESIZEPALETTE 51")]
        public const int EMR_RESIZEPALETTE = 51;

        [NativeTypeName("#define EMR_REALIZEPALETTE 52")]
        public const int EMR_REALIZEPALETTE = 52;

        [NativeTypeName("#define EMR_EXTFLOODFILL 53")]
        public const int EMR_EXTFLOODFILL = 53;

        [NativeTypeName("#define EMR_LINETO 54")]
        public const int EMR_LINETO = 54;

        [NativeTypeName("#define EMR_ARCTO 55")]
        public const int EMR_ARCTO = 55;

        [NativeTypeName("#define EMR_POLYDRAW 56")]
        public const int EMR_POLYDRAW = 56;

        [NativeTypeName("#define EMR_SETARCDIRECTION 57")]
        public const int EMR_SETARCDIRECTION = 57;

        [NativeTypeName("#define EMR_SETMITERLIMIT 58")]
        public const int EMR_SETMITERLIMIT = 58;

        [NativeTypeName("#define EMR_BEGINPATH 59")]
        public const int EMR_BEGINPATH = 59;

        [NativeTypeName("#define EMR_ENDPATH 60")]
        public const int EMR_ENDPATH = 60;

        [NativeTypeName("#define EMR_CLOSEFIGURE 61")]
        public const int EMR_CLOSEFIGURE = 61;

        [NativeTypeName("#define EMR_FILLPATH 62")]
        public const int EMR_FILLPATH = 62;

        [NativeTypeName("#define EMR_STROKEANDFILLPATH 63")]
        public const int EMR_STROKEANDFILLPATH = 63;

        [NativeTypeName("#define EMR_STROKEPATH 64")]
        public const int EMR_STROKEPATH = 64;

        [NativeTypeName("#define EMR_FLATTENPATH 65")]
        public const int EMR_FLATTENPATH = 65;

        [NativeTypeName("#define EMR_WIDENPATH 66")]
        public const int EMR_WIDENPATH = 66;

        [NativeTypeName("#define EMR_SELECTCLIPPATH 67")]
        public const int EMR_SELECTCLIPPATH = 67;

        [NativeTypeName("#define EMR_ABORTPATH 68")]
        public const int EMR_ABORTPATH = 68;

        [NativeTypeName("#define EMR_GDICOMMENT 70")]
        public const int EMR_GDICOMMENT = 70;

        [NativeTypeName("#define EMR_FILLRGN 71")]
        public const int EMR_FILLRGN = 71;

        [NativeTypeName("#define EMR_FRAMERGN 72")]
        public const int EMR_FRAMERGN = 72;

        [NativeTypeName("#define EMR_INVERTRGN 73")]
        public const int EMR_INVERTRGN = 73;

        [NativeTypeName("#define EMR_PAINTRGN 74")]
        public const int EMR_PAINTRGN = 74;

        [NativeTypeName("#define EMR_EXTSELECTCLIPRGN 75")]
        public const int EMR_EXTSELECTCLIPRGN = 75;

        [NativeTypeName("#define EMR_BITBLT 76")]
        public const int EMR_BITBLT = 76;

        [NativeTypeName("#define EMR_STRETCHBLT 77")]
        public const int EMR_STRETCHBLT = 77;

        [NativeTypeName("#define EMR_MASKBLT 78")]
        public const int EMR_MASKBLT = 78;

        [NativeTypeName("#define EMR_PLGBLT 79")]
        public const int EMR_PLGBLT = 79;

        [NativeTypeName("#define EMR_SETDIBITSTODEVICE 80")]
        public const int EMR_SETDIBITSTODEVICE = 80;

        [NativeTypeName("#define EMR_STRETCHDIBITS 81")]
        public const int EMR_STRETCHDIBITS = 81;

        [NativeTypeName("#define EMR_EXTCREATEFONTINDIRECTW 82")]
        public const int EMR_EXTCREATEFONTINDIRECTW = 82;

        [NativeTypeName("#define EMR_EXTTEXTOUTA 83")]
        public const int EMR_EXTTEXTOUTA = 83;

        [NativeTypeName("#define EMR_EXTTEXTOUTW 84")]
        public const int EMR_EXTTEXTOUTW = 84;

        [NativeTypeName("#define EMR_POLYBEZIER16 85")]
        public const int EMR_POLYBEZIER16 = 85;

        [NativeTypeName("#define EMR_POLYGON16 86")]
        public const int EMR_POLYGON16 = 86;

        [NativeTypeName("#define EMR_POLYLINE16 87")]
        public const int EMR_POLYLINE16 = 87;

        [NativeTypeName("#define EMR_POLYBEZIERTO16 88")]
        public const int EMR_POLYBEZIERTO16 = 88;

        [NativeTypeName("#define EMR_POLYLINETO16 89")]
        public const int EMR_POLYLINETO16 = 89;

        [NativeTypeName("#define EMR_POLYPOLYLINE16 90")]
        public const int EMR_POLYPOLYLINE16 = 90;

        [NativeTypeName("#define EMR_POLYPOLYGON16 91")]
        public const int EMR_POLYPOLYGON16 = 91;

        [NativeTypeName("#define EMR_POLYDRAW16 92")]
        public const int EMR_POLYDRAW16 = 92;

        [NativeTypeName("#define EMR_CREATEMONOBRUSH 93")]
        public const int EMR_CREATEMONOBRUSH = 93;

        [NativeTypeName("#define EMR_CREATEDIBPATTERNBRUSHPT 94")]
        public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;

        [NativeTypeName("#define EMR_EXTCREATEPEN 95")]
        public const int EMR_EXTCREATEPEN = 95;

        [NativeTypeName("#define EMR_POLYTEXTOUTA 96")]
        public const int EMR_POLYTEXTOUTA = 96;

        [NativeTypeName("#define EMR_POLYTEXTOUTW 97")]
        public const int EMR_POLYTEXTOUTW = 97;

        [NativeTypeName("#define EMR_SETICMMODE 98")]
        public const int EMR_SETICMMODE = 98;

        [NativeTypeName("#define EMR_CREATECOLORSPACE 99")]
        public const int EMR_CREATECOLORSPACE = 99;

        [NativeTypeName("#define EMR_SETCOLORSPACE 100")]
        public const int EMR_SETCOLORSPACE = 100;

        [NativeTypeName("#define EMR_DELETECOLORSPACE 101")]
        public const int EMR_DELETECOLORSPACE = 101;

        [NativeTypeName("#define EMR_GLSRECORD 102")]
        public const int EMR_GLSRECORD = 102;

        [NativeTypeName("#define EMR_GLSBOUNDEDRECORD 103")]
        public const int EMR_GLSBOUNDEDRECORD = 103;

        [NativeTypeName("#define EMR_PIXELFORMAT 104")]
        public const int EMR_PIXELFORMAT = 104;

        [NativeTypeName("#define EMR_RESERVED_105 105")]
        public const int EMR_RESERVED_105 = 105;

        [NativeTypeName("#define EMR_RESERVED_106 106")]
        public const int EMR_RESERVED_106 = 106;

        [NativeTypeName("#define EMR_RESERVED_107 107")]
        public const int EMR_RESERVED_107 = 107;

        [NativeTypeName("#define EMR_RESERVED_108 108")]
        public const int EMR_RESERVED_108 = 108;

        [NativeTypeName("#define EMR_RESERVED_109 109")]
        public const int EMR_RESERVED_109 = 109;

        [NativeTypeName("#define EMR_RESERVED_110 110")]
        public const int EMR_RESERVED_110 = 110;

        [NativeTypeName("#define EMR_COLORCORRECTPALETTE 111")]
        public const int EMR_COLORCORRECTPALETTE = 111;

        [NativeTypeName("#define EMR_SETICMPROFILEA 112")]
        public const int EMR_SETICMPROFILEA = 112;

        [NativeTypeName("#define EMR_SETICMPROFILEW 113")]
        public const int EMR_SETICMPROFILEW = 113;

        [NativeTypeName("#define EMR_ALPHABLEND 114")]
        public const int EMR_ALPHABLEND = 114;

        [NativeTypeName("#define EMR_SETLAYOUT 115")]
        public const int EMR_SETLAYOUT = 115;

        [NativeTypeName("#define EMR_TRANSPARENTBLT 116")]
        public const int EMR_TRANSPARENTBLT = 116;

        [NativeTypeName("#define EMR_RESERVED_117 117")]
        public const int EMR_RESERVED_117 = 117;

        [NativeTypeName("#define EMR_GRADIENTFILL 118")]
        public const int EMR_GRADIENTFILL = 118;

        [NativeTypeName("#define EMR_RESERVED_119 119")]
        public const int EMR_RESERVED_119 = 119;

        [NativeTypeName("#define EMR_RESERVED_120 120")]
        public const int EMR_RESERVED_120 = 120;

        [NativeTypeName("#define EMR_COLORMATCHTOTARGETW 121")]
        public const int EMR_COLORMATCHTOTARGETW = 121;

        [NativeTypeName("#define EMR_CREATECOLORSPACEW 122")]
        public const int EMR_CREATECOLORSPACEW = 122;

        [NativeTypeName("#define EMR_MIN 1")]
        public const int EMR_MIN = 1;

        [NativeTypeName("#define EMR_MAX 122")]
        public const int EMR_MAX = 122;

        [NativeTypeName("#define SETICMPROFILE_EMBEDED 0x00000001")]
        public const int SETICMPROFILE_EMBEDED = 0x00000001;

        [NativeTypeName("#define CREATECOLORSPACE_EMBEDED 0x00000001")]
        public const int CREATECOLORSPACE_EMBEDED = 0x00000001;

        [NativeTypeName("#define COLORMATCHTOTARGET_EMBEDED 0x00000001")]
        public const int COLORMATCHTOTARGET_EMBEDED = 0x00000001;

        [NativeTypeName("#define GDICOMMENT_IDENTIFIER 0x43494447")]
        public const int GDICOMMENT_IDENTIFIER = 0x43494447;

        [NativeTypeName("#define GDICOMMENT_WINDOWS_METAFILE 0x80000001")]
        public const uint GDICOMMENT_WINDOWS_METAFILE = 0x80000001;

        [NativeTypeName("#define GDICOMMENT_BEGINGROUP 0x00000002")]
        public const int GDICOMMENT_BEGINGROUP = 0x00000002;

        [NativeTypeName("#define GDICOMMENT_ENDGROUP 0x00000003")]
        public const int GDICOMMENT_ENDGROUP = 0x00000003;

        [NativeTypeName("#define GDICOMMENT_MULTIFORMATS 0x40000004")]
        public const int GDICOMMENT_MULTIFORMATS = 0x40000004;

        [NativeTypeName("#define EPS_SIGNATURE 0x46535045")]
        public const int EPS_SIGNATURE = 0x46535045;

        [NativeTypeName("#define GDICOMMENT_UNICODE_STRING 0x00000040")]
        public const int GDICOMMENT_UNICODE_STRING = 0x00000040;

        [NativeTypeName("#define GDICOMMENT_UNICODE_END 0x00000080")]
        public const int GDICOMMENT_UNICODE_END = 0x00000080;

        [NativeTypeName("#define wglUseFontBitmaps wglUseFontBitmapsW")]
        public static delegate*<IntPtr, uint, uint, uint, int> wglUseFontBitmaps => &wglUseFontBitmapsW;

        [NativeTypeName("#define WGL_FONT_LINES 0")]
        public const int WGL_FONT_LINES = 0;

        [NativeTypeName("#define WGL_FONT_POLYGONS 1")]
        public const int WGL_FONT_POLYGONS = 1;

        [NativeTypeName("#define wglUseFontOutlines wglUseFontOutlinesW")]
        public static delegate*<IntPtr, uint, uint, uint, float, float, int, GLYPHMETRICSFLOAT*, int> wglUseFontOutlines => &wglUseFontOutlinesW;

        [NativeTypeName("#define LPD_DOUBLEBUFFER 0x00000001")]
        public const int LPD_DOUBLEBUFFER = 0x00000001;

        [NativeTypeName("#define LPD_STEREO 0x00000002")]
        public const int LPD_STEREO = 0x00000002;

        [NativeTypeName("#define LPD_SUPPORT_GDI 0x00000010")]
        public const int LPD_SUPPORT_GDI = 0x00000010;

        [NativeTypeName("#define LPD_SUPPORT_OPENGL 0x00000020")]
        public const int LPD_SUPPORT_OPENGL = 0x00000020;

        [NativeTypeName("#define LPD_SHARE_DEPTH 0x00000040")]
        public const int LPD_SHARE_DEPTH = 0x00000040;

        [NativeTypeName("#define LPD_SHARE_STENCIL 0x00000080")]
        public const int LPD_SHARE_STENCIL = 0x00000080;

        [NativeTypeName("#define LPD_SHARE_ACCUM 0x00000100")]
        public const int LPD_SHARE_ACCUM = 0x00000100;

        [NativeTypeName("#define LPD_SWAP_EXCHANGE 0x00000200")]
        public const int LPD_SWAP_EXCHANGE = 0x00000200;

        [NativeTypeName("#define LPD_SWAP_COPY 0x00000400")]
        public const int LPD_SWAP_COPY = 0x00000400;

        [NativeTypeName("#define LPD_TRANSPARENT 0x00001000")]
        public const int LPD_TRANSPARENT = 0x00001000;

        [NativeTypeName("#define LPD_TYPE_RGBA 0")]
        public const int LPD_TYPE_RGBA = 0;

        [NativeTypeName("#define LPD_TYPE_COLORINDEX 1")]
        public const int LPD_TYPE_COLORINDEX = 1;

        [NativeTypeName("#define WGL_SWAP_MAIN_PLANE 0x00000001")]
        public const int WGL_SWAP_MAIN_PLANE = 0x00000001;

        [NativeTypeName("#define WGL_SWAP_OVERLAY1 0x00000002")]
        public const int WGL_SWAP_OVERLAY1 = 0x00000002;

        [NativeTypeName("#define WGL_SWAP_OVERLAY2 0x00000004")]
        public const int WGL_SWAP_OVERLAY2 = 0x00000004;

        [NativeTypeName("#define WGL_SWAP_OVERLAY3 0x00000008")]
        public const int WGL_SWAP_OVERLAY3 = 0x00000008;

        [NativeTypeName("#define WGL_SWAP_OVERLAY4 0x00000010")]
        public const int WGL_SWAP_OVERLAY4 = 0x00000010;

        [NativeTypeName("#define WGL_SWAP_OVERLAY5 0x00000020")]
        public const int WGL_SWAP_OVERLAY5 = 0x00000020;

        [NativeTypeName("#define WGL_SWAP_OVERLAY6 0x00000040")]
        public const int WGL_SWAP_OVERLAY6 = 0x00000040;

        [NativeTypeName("#define WGL_SWAP_OVERLAY7 0x00000080")]
        public const int WGL_SWAP_OVERLAY7 = 0x00000080;

        [NativeTypeName("#define WGL_SWAP_OVERLAY8 0x00000100")]
        public const int WGL_SWAP_OVERLAY8 = 0x00000100;

        [NativeTypeName("#define WGL_SWAP_OVERLAY9 0x00000200")]
        public const int WGL_SWAP_OVERLAY9 = 0x00000200;

        [NativeTypeName("#define WGL_SWAP_OVERLAY10 0x00000400")]
        public const int WGL_SWAP_OVERLAY10 = 0x00000400;

        [NativeTypeName("#define WGL_SWAP_OVERLAY11 0x00000800")]
        public const int WGL_SWAP_OVERLAY11 = 0x00000800;

        [NativeTypeName("#define WGL_SWAP_OVERLAY12 0x00001000")]
        public const int WGL_SWAP_OVERLAY12 = 0x00001000;

        [NativeTypeName("#define WGL_SWAP_OVERLAY13 0x00002000")]
        public const int WGL_SWAP_OVERLAY13 = 0x00002000;

        [NativeTypeName("#define WGL_SWAP_OVERLAY14 0x00004000")]
        public const int WGL_SWAP_OVERLAY14 = 0x00004000;

        [NativeTypeName("#define WGL_SWAP_OVERLAY15 0x00008000")]
        public const int WGL_SWAP_OVERLAY15 = 0x00008000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY1 0x00010000")]
        public const int WGL_SWAP_UNDERLAY1 = 0x00010000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY2 0x00020000")]
        public const int WGL_SWAP_UNDERLAY2 = 0x00020000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY3 0x00040000")]
        public const int WGL_SWAP_UNDERLAY3 = 0x00040000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY4 0x00080000")]
        public const int WGL_SWAP_UNDERLAY4 = 0x00080000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY5 0x00100000")]
        public const int WGL_SWAP_UNDERLAY5 = 0x00100000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY6 0x00200000")]
        public const int WGL_SWAP_UNDERLAY6 = 0x00200000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY7 0x00400000")]
        public const int WGL_SWAP_UNDERLAY7 = 0x00400000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY8 0x00800000")]
        public const int WGL_SWAP_UNDERLAY8 = 0x00800000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY9 0x01000000")]
        public const int WGL_SWAP_UNDERLAY9 = 0x01000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY10 0x02000000")]
        public const int WGL_SWAP_UNDERLAY10 = 0x02000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY11 0x04000000")]
        public const int WGL_SWAP_UNDERLAY11 = 0x04000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY12 0x08000000")]
        public const int WGL_SWAP_UNDERLAY12 = 0x08000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY13 0x10000000")]
        public const int WGL_SWAP_UNDERLAY13 = 0x10000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY14 0x20000000")]
        public const int WGL_SWAP_UNDERLAY14 = 0x20000000;

        [NativeTypeName("#define WGL_SWAP_UNDERLAY15 0x40000000")]
        public const int WGL_SWAP_UNDERLAY15 = 0x40000000;

        [NativeTypeName("#define WGL_SWAPMULTIPLE_MAX 16")]
        public const int WGL_SWAPMULTIPLE_MAX = 16;
    }
}
