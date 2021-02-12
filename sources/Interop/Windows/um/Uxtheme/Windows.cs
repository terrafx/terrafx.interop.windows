// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.BP_BUFFERFORMAT;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BeginPanningFeedback([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdatePanningFeedback([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int lTotalOverpanOffsetX, [NativeTypeName("LONG")] int lTotalOverpanOffsetY, [NativeTypeName("BOOL")] int fInInertia);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPanningFeedback([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fAnimateBack);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeAnimationProperty([NativeTypeName("HTHEME")] IntPtr hTheme, int iStoryboardId, int iTargetId, TA_PROPERTY eProperty, [NativeTypeName("void *")] void* pvProperty, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeAnimationTransform([NativeTypeName("HTHEME")] IntPtr hTheme, int iStoryboardId, int iTargetId, [NativeTypeName("DWORD")] uint dwTransformIndex, [NativeTypeName("TA_TRANSFORM *")] TA_TRANSFORM* pTransform, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeTimingFunction([NativeTypeName("HTHEME")] IntPtr hTheme, int iTimingFunctionId, [NativeTypeName("TA_TIMINGFUNCTION *")] TA_TIMINGFUNCTION* pTimingFunction, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HTHEME")]
        public static extern IntPtr OpenThemeData([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HTHEME")]
        public static extern IntPtr OpenThemeDataForDpi([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, [NativeTypeName("UINT")] uint dpi);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HTHEME")]
        public static extern IntPtr OpenThemeDataEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CloseThemeData([NativeTypeName("HTHEME")] IntPtr hTheme);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeBackground([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("LPCRECT")] RECT* pClipRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeBackgroundEx([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("const DTBGOPTS *")] DTBGOPTS* pOptions);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeText([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("DWORD")] uint dwTextFlags2, [NativeTypeName("LPCRECT")] RECT* pRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeBackgroundContentRect([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pContentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeBackgroundExtent([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pContentRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeBackgroundRegion([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("HRGN *")] IntPtr* pRegion);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemePartSize([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* prc, [NativeTypeName("enum THEMESIZE")] THEMESIZE eSize, [NativeTypeName("SIZE *")] SIZE* psz);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeTextExtent([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchCharCount, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeTextMetrics([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("TEXTMETRICW *")] TEXTMETRICW* ptm);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HitTestThemeBackground([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("HRGN")] IntPtr hrgn, POINT ptTest, [NativeTypeName("WORD *")] ushort* pwHitTestCode);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeEdge([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pDestRect, [NativeTypeName("UINT")] uint uEdge, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("LPRECT")] RECT* pContentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeIcon([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("HIMAGELIST")] IntPtr himl, int iImageIndex);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsThemePartDefined([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsThemeBackgroundPartiallyTransparent([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeColor([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("COLORREF *")] uint* pColor);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeMetric([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, int iPropId, [NativeTypeName("int *")] int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeString([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszBuff, int cchMaxBuffChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeBool([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("BOOL *")] int* pfVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeInt([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("int *")] int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeEnumValue([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("int *")] int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemePosition([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("POINT *")] POINT* pPoint);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeFont([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, int iPropId, [NativeTypeName("LOGFONTW *")] LOGFONTW* pFont);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeRect([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPRECT")] RECT* pRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeMargins([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPCRECT")] RECT* prc, [NativeTypeName("MARGINS *")] MARGINS* pMargins);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeIntList([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("INTLIST *")] INTLIST* pIntList);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemePropertyOrigin([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("enum PROPERTYORIGIN *")] PROPERTYORIGIN* pOrigin);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetWindowTheme([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeFilename([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxBuffChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetThemeSysColor([NativeTypeName("HTHEME")] IntPtr hTheme, int iColorId);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern IntPtr GetThemeSysColorBrush([NativeTypeName("HTHEME")] IntPtr hTheme, int iColorId);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThemeSysBool([NativeTypeName("HTHEME")] IntPtr hTheme, int iBoolId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern int GetThemeSysSize([NativeTypeName("HTHEME")] IntPtr hTheme, int iSizeId);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeSysFont([NativeTypeName("HTHEME")] IntPtr hTheme, int iFontId, [NativeTypeName("LOGFONTW *")] LOGFONTW* plf);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeSysString([NativeTypeName("HTHEME")] IntPtr hTheme, int iStringId, [NativeTypeName("LPWSTR")] ushort* pszStringBuff, int cchMaxStringChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeSysInt([NativeTypeName("HTHEME")] IntPtr hTheme, int iIntId, [NativeTypeName("int *")] int* piValue);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsThemeActive();

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsAppThemed();

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HTHEME")]
        public static extern IntPtr GetWindowTheme([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int EnableThemeDialogTexture([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsThemeDialogTextureEnabled([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThemeAppProperties();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern void SetThemeAppProperties([NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetCurrentThemeName([NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxNameChars, [NativeTypeName("LPWSTR")] ushort* pszColorBuff, int cchMaxColorChars, [NativeTypeName("LPWSTR")] ushort* pszSizeBuff, int cchMaxSizeChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeDocumentationProperty([NativeTypeName("LPCWSTR")] ushort* pszThemeName, [NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("LPWSTR")] ushort* pszValueBuff, int cchMaxValChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeParentBackground([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int EnableTheming([NativeTypeName("BOOL")] int fEnable);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeParentBackgroundEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetWindowThemeAttribute([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("enum WINDOWTHEMEATTRIBUTETYPE")] WINDOWTHEMEATTRIBUTETYPE eAttribute, [NativeTypeName("PVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DrawThemeTextEx([NativeTypeName("HTHEME")] IntPtr hTheme, [NativeTypeName("HDC")] IntPtr hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPRECT")] RECT* pRect, [NativeTypeName("const DTTOPTS *")] DTTOPTS* pOptions);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeBitmap([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("HBITMAP *")] IntPtr* phBitmap);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeStream([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("void **")] void** ppvStream, [NativeTypeName("DWORD *")] uint* pcbStream, [NativeTypeName("HINSTANCE")] IntPtr hInst);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int BufferedPaintInit();

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int BufferedPaintUnInit();

        [DllImport("uxtheme", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HPAINTBUFFER")]
        public static extern IntPtr BeginBufferedPaint([NativeTypeName("HDC")] IntPtr hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, [NativeTypeName("BP_PAINTPARAMS *")] BP_PAINTPARAMS* pPaintParams, [NativeTypeName("HDC *")] IntPtr* phdc);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int EndBufferedPaint([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint, [NativeTypeName("BOOL")] int fUpdateTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetBufferedPaintTargetRect([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint, [NativeTypeName("RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetBufferedPaintTargetDC([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern IntPtr GetBufferedPaintDC([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetBufferedPaintBits([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint, [NativeTypeName("RGBQUAD **")] RGBQUAD** ppbBuffer, [NativeTypeName("int *")] int* pcxRow);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int BufferedPaintClear([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int BufferedPaintSetAlpha([NativeTypeName("HPAINTBUFFER")] IntPtr hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc, [NativeTypeName("BYTE")] byte alpha);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int BufferedPaintStopAllAnimations([NativeTypeName("HWND")] IntPtr hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HANIMATIONBUFFER")]
        public static extern IntPtr BeginBufferedAnimation([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, [NativeTypeName("BP_PAINTPARAMS *")] BP_PAINTPARAMS* pPaintParams, [NativeTypeName("BP_ANIMATIONPARAMS *")] BP_ANIMATIONPARAMS* pAnimationParams, [NativeTypeName("HDC *")] IntPtr* phdcFrom, [NativeTypeName("HDC *")] IntPtr* phdcTo);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int EndBufferedAnimation([NativeTypeName("HANIMATIONBUFFER")] IntPtr hbpAnimation, [NativeTypeName("BOOL")] int fUpdateTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BufferedPaintRenderAnimation([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdcTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCompositionActive();

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThemeTransitionDuration([NativeTypeName("HTHEME")] IntPtr hTheme, int iPartId, int iStateIdFrom, int iStateIdTo, int iPropId, [NativeTypeName("DWORD *")] uint* pdwDuration);

        [NativeTypeName("#define MAX_THEMECOLOR 64")]
        public const int MAX_THEMECOLOR = 64;

        [NativeTypeName("#define MAX_THEMESIZE 64")]
        public const int MAX_THEMESIZE = 64;

        [NativeTypeName("#define OTD_FORCE_RECT_SIZING 0x00000001")]
        public const int OTD_FORCE_RECT_SIZING = 0x00000001;

        [NativeTypeName("#define OTD_NONCLIENT 0x00000002")]
        public const int OTD_NONCLIENT = 0x00000002;

        [NativeTypeName("#define OTD_VALIDBITS (OTD_FORCE_RECT_SIZING | \\\r\n                                 OTD_NONCLIENT)")]
        public const int OTD_VALIDBITS = (0x00000001 | 0x00000002);

        [NativeTypeName("#define DTBG_CLIPRECT 0x00000001")]
        public const int DTBG_CLIPRECT = 0x00000001;

        [NativeTypeName("#define DTBG_DRAWSOLID 0x00000002")]
        public const int DTBG_DRAWSOLID = 0x00000002;

        [NativeTypeName("#define DTBG_OMITBORDER 0x00000004")]
        public const int DTBG_OMITBORDER = 0x00000004;

        [NativeTypeName("#define DTBG_OMITCONTENT 0x00000008")]
        public const int DTBG_OMITCONTENT = 0x00000008;

        [NativeTypeName("#define DTBG_COMPUTINGREGION 0x00000010")]
        public const int DTBG_COMPUTINGREGION = 0x00000010;

        [NativeTypeName("#define DTBG_MIRRORDC 0x00000020")]
        public const int DTBG_MIRRORDC = 0x00000020;

        [NativeTypeName("#define DTBG_NOMIRROR 0x00000040")]
        public const int DTBG_NOMIRROR = 0x00000040;

        [NativeTypeName("#define DTBG_VALIDBITS (DTBG_CLIPRECT | \\\r\n                                 DTBG_DRAWSOLID | \\\r\n                                 DTBG_OMITBORDER | \\\r\n                                 DTBG_OMITCONTENT | \\\r\n                                 DTBG_COMPUTINGREGION | \\\r\n                                 DTBG_MIRRORDC | \\\r\n                                 DTBG_NOMIRROR)")]
        public const int DTBG_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040);

        [NativeTypeName("#define DTT_GRAYED 0x00000001")]
        public const int DTT_GRAYED = 0x00000001;

        [NativeTypeName("#define DTT_FLAGS2VALIDBITS (DTT_GRAYED)")]
        public const int DTT_FLAGS2VALIDBITS = (0x00000001);

        [NativeTypeName("#define HTTB_BACKGROUNDSEG 0x00000000")]
        public const int HTTB_BACKGROUNDSEG = 0x00000000;

        [NativeTypeName("#define HTTB_FIXEDBORDER 0x00000002")]
        public const int HTTB_FIXEDBORDER = 0x00000002;

        [NativeTypeName("#define HTTB_CAPTION 0x00000004")]
        public const int HTTB_CAPTION = 0x00000004;

        [NativeTypeName("#define HTTB_RESIZINGBORDER_LEFT 0x00000010")]
        public const int HTTB_RESIZINGBORDER_LEFT = 0x00000010;

        [NativeTypeName("#define HTTB_RESIZINGBORDER_TOP 0x00000020")]
        public const int HTTB_RESIZINGBORDER_TOP = 0x00000020;

        [NativeTypeName("#define HTTB_RESIZINGBORDER_RIGHT 0x00000040")]
        public const int HTTB_RESIZINGBORDER_RIGHT = 0x00000040;

        [NativeTypeName("#define HTTB_RESIZINGBORDER_BOTTOM 0x00000080")]
        public const int HTTB_RESIZINGBORDER_BOTTOM = 0x00000080;

        [NativeTypeName("#define HTTB_RESIZINGBORDER (HTTB_RESIZINGBORDER_LEFT | \\\r\n                                     HTTB_RESIZINGBORDER_TOP | \\\r\n                                     HTTB_RESIZINGBORDER_RIGHT | \\\r\n                                     HTTB_RESIZINGBORDER_BOTTOM)")]
        public const int HTTB_RESIZINGBORDER = (0x00000010 | 0x00000020 | 0x00000040 | 0x00000080);

        [NativeTypeName("#define HTTB_SIZINGTEMPLATE 0x00000100")]
        public const int HTTB_SIZINGTEMPLATE = 0x00000100;

        [NativeTypeName("#define HTTB_SYSTEMSIZINGMARGINS 0x00000200")]
        public const int HTTB_SYSTEMSIZINGMARGINS = 0x00000200;

        [NativeTypeName("#define MAX_INTLIST_COUNT 402")]
        public const int MAX_INTLIST_COUNT = 402;

        [NativeTypeName("#define ETDT_DISABLE 0x00000001")]
        public const int ETDT_DISABLE = 0x00000001;

        [NativeTypeName("#define ETDT_ENABLE 0x00000002")]
        public const int ETDT_ENABLE = 0x00000002;

        [NativeTypeName("#define ETDT_USETABTEXTURE 0x00000004")]
        public const int ETDT_USETABTEXTURE = 0x00000004;

        [NativeTypeName("#define ETDT_ENABLETAB (ETDT_ENABLE | \\\r\n                                     ETDT_USETABTEXTURE)")]
        public const int ETDT_ENABLETAB = (0x00000002 | 0x00000004);

        [NativeTypeName("#define ETDT_USEAEROWIZARDTABTEXTURE 0x00000008")]
        public const int ETDT_USEAEROWIZARDTABTEXTURE = 0x00000008;

        [NativeTypeName("#define ETDT_ENABLEAEROWIZARDTAB (ETDT_ENABLE | \\\r\n                                     ETDT_USEAEROWIZARDTABTEXTURE)")]
        public const int ETDT_ENABLEAEROWIZARDTAB = (0x00000002 | 0x00000008);

        [NativeTypeName("#define ETDT_VALIDBITS (ETDT_DISABLE | \\\r\n                                     ETDT_ENABLE | \\\r\n                                     ETDT_USETABTEXTURE | \\\r\n                                     ETDT_USEAEROWIZARDTABTEXTURE)")]
        public const int ETDT_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define STAP_ALLOW_NONCLIENT (1UL << 0)")]
        public const uint STAP_ALLOW_NONCLIENT = (1U << 0);

        [NativeTypeName("#define STAP_ALLOW_CONTROLS (1UL << 1)")]
        public const uint STAP_ALLOW_CONTROLS = (1U << 1);

        [NativeTypeName("#define STAP_ALLOW_WEBCONTENT (1UL << 2)")]
        public const uint STAP_ALLOW_WEBCONTENT = (1U << 2);

        [NativeTypeName("#define STAP_VALIDBITS (STAP_ALLOW_NONCLIENT | \\\r\n                                 STAP_ALLOW_CONTROLS | \\\r\n                                 STAP_ALLOW_WEBCONTENT)")]
        public const uint STAP_VALIDBITS = ((1U << 0) | (1U << 1) | (1U << 2));

        [NativeTypeName("#define SZ_THDOCPROP_DISPLAYNAME L\"DisplayName\"")]
        public const string SZ_THDOCPROP_DISPLAYNAME = "DisplayName";

        [NativeTypeName("#define SZ_THDOCPROP_CANONICALNAME L\"ThemeName\"")]
        public const string SZ_THDOCPROP_CANONICALNAME = "ThemeName";

        [NativeTypeName("#define SZ_THDOCPROP_TOOLTIP L\"ToolTip\"")]
        public const string SZ_THDOCPROP_TOOLTIP = "ToolTip";

        [NativeTypeName("#define SZ_THDOCPROP_AUTHOR L\"author\"")]
        public const string SZ_THDOCPROP_AUTHOR = "author";

        [NativeTypeName("#define GBF_DIRECT 0x00000001")]
        public const int GBF_DIRECT = 0x00000001;

        [NativeTypeName("#define GBF_COPY 0x00000002")]
        public const int GBF_COPY = 0x00000002;

        [NativeTypeName("#define GBF_VALIDBITS (GBF_DIRECT | \\\r\n                         GBF_COPY)")]
        public const int GBF_VALIDBITS = (0x00000001 | 0x00000002);

        [NativeTypeName("#define DTPB_WINDOWDC 0x00000001")]
        public const int DTPB_WINDOWDC = 0x00000001;

        [NativeTypeName("#define DTPB_USECTLCOLORSTATIC 0x00000002")]
        public const int DTPB_USECTLCOLORSTATIC = 0x00000002;

        [NativeTypeName("#define DTPB_USEERASEBKGND 0x00000004")]
        public const int DTPB_USEERASEBKGND = 0x00000004;

        [NativeTypeName("#define WTNCA_NODRAWCAPTION 0x00000001")]
        public const int WTNCA_NODRAWCAPTION = 0x00000001;

        [NativeTypeName("#define WTNCA_NODRAWICON 0x00000002")]
        public const int WTNCA_NODRAWICON = 0x00000002;

        [NativeTypeName("#define WTNCA_NOSYSMENU 0x00000004")]
        public const int WTNCA_NOSYSMENU = 0x00000004;

        [NativeTypeName("#define WTNCA_NOMIRRORHELP 0x00000008")]
        public const int WTNCA_NOMIRRORHELP = 0x00000008;

        [NativeTypeName("#define WTNCA_VALIDBITS (WTNCA_NODRAWCAPTION | \\\r\n                                   WTNCA_NODRAWICON | \\\r\n                                   WTNCA_NOSYSMENU | \\\r\n                                   WTNCA_NOMIRRORHELP)")]
        public const int WTNCA_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define DTT_TEXTCOLOR (1UL << 0)")]
        public const uint DTT_TEXTCOLOR = (1U << 0);

        [NativeTypeName("#define DTT_BORDERCOLOR (1UL << 1)")]
        public const uint DTT_BORDERCOLOR = (1U << 1);

        [NativeTypeName("#define DTT_SHADOWCOLOR (1UL << 2)")]
        public const uint DTT_SHADOWCOLOR = (1U << 2);

        [NativeTypeName("#define DTT_SHADOWTYPE (1UL << 3)")]
        public const uint DTT_SHADOWTYPE = (1U << 3);

        [NativeTypeName("#define DTT_SHADOWOFFSET (1UL << 4)")]
        public const uint DTT_SHADOWOFFSET = (1U << 4);

        [NativeTypeName("#define DTT_BORDERSIZE (1UL << 5)")]
        public const uint DTT_BORDERSIZE = (1U << 5);

        [NativeTypeName("#define DTT_FONTPROP (1UL << 6)")]
        public const uint DTT_FONTPROP = (1U << 6);

        [NativeTypeName("#define DTT_COLORPROP (1UL << 7)")]
        public const uint DTT_COLORPROP = (1U << 7);

        [NativeTypeName("#define DTT_STATEID (1UL << 8)")]
        public const uint DTT_STATEID = (1U << 8);

        [NativeTypeName("#define DTT_CALCRECT (1UL << 9)")]
        public const uint DTT_CALCRECT = (1U << 9);

        [NativeTypeName("#define DTT_APPLYOVERLAY (1UL << 10)")]
        public const uint DTT_APPLYOVERLAY = (1U << 10);

        [NativeTypeName("#define DTT_GLOWSIZE (1UL << 11)")]
        public const uint DTT_GLOWSIZE = (1U << 11);

        [NativeTypeName("#define DTT_CALLBACK (1UL << 12)")]
        public const uint DTT_CALLBACK = (1U << 12);

        [NativeTypeName("#define DTT_COMPOSITED (1UL << 13)")]
        public const uint DTT_COMPOSITED = (1U << 13);

        [NativeTypeName("#define DTT_VALIDBITS (DTT_TEXTCOLOR | \\\r\n                             DTT_BORDERCOLOR | \\\r\n                             DTT_SHADOWCOLOR | \\\r\n                             DTT_SHADOWTYPE | \\\r\n                             DTT_SHADOWOFFSET | \\\r\n                             DTT_BORDERSIZE | \\\r\n                             DTT_FONTPROP | \\\r\n                             DTT_COLORPROP | \\\r\n                             DTT_STATEID | \\\r\n                             DTT_CALCRECT | \\\r\n                             DTT_APPLYOVERLAY | \\\r\n                             DTT_GLOWSIZE | \\\r\n                             DTT_COMPOSITED)")]
        public const uint DTT_VALIDBITS = ((1U << 0) | (1U << 1) | (1U << 2) | (1U << 3) | (1U << 4) | (1U << 5) | (1U << 6) | (1U << 7) | (1U << 8) | (1U << 9) | (1U << 10) | (1U << 11) | (1U << 13));

        [NativeTypeName("#define BPBF_COMPOSITED BPBF_TOPDOWNDIB")]
        public const BP_BUFFERFORMAT BPBF_COMPOSITED = BPBF_TOPDOWNDIB;

        [NativeTypeName("#define BPPF_ERASE 0x0001")]
        public const int BPPF_ERASE = 0x0001;

        [NativeTypeName("#define BPPF_NOCLIP 0x0002")]
        public const int BPPF_NOCLIP = 0x0002;

        [NativeTypeName("#define BPPF_NONCLIENT 0x0004")]
        public const int BPPF_NONCLIENT = 0x0004;
    }
}
