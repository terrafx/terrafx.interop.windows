// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.BP_BUFFERFORMAT;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL BeginPanningFeedback(HWND hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL UpdatePanningFeedback(HWND hwnd, [NativeTypeName("LONG")] int lTotalOverpanOffsetX, [NativeTypeName("LONG")] int lTotalOverpanOffsetY, BOOL fInInertia);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL EndPanningFeedback(HWND hwnd, BOOL fAnimateBack);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeAnimationProperty(HTHEME hTheme, int iStoryboardId, int iTargetId, TA_PROPERTY eProperty, void* pvProperty, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeAnimationTransform(HTHEME hTheme, int iStoryboardId, int iTargetId, [NativeTypeName("DWORD")] uint dwTransformIndex, TA_TRANSFORM* pTransform, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeTimingFunction(HTHEME hTheme, int iTimingFunctionId, TA_TIMINGFUNCTION* pTimingFunction, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HTHEME OpenThemeData(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HTHEME OpenThemeDataForDpi(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, uint dpi);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HTHEME OpenThemeDataEx(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT CloseThemeData(HTHEME hTheme);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeBackground(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("LPCRECT")] RECT* pClipRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeBackgroundEx(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("const DTBGOPTS *")] DTBGOPTS* pOptions);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeText(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("DWORD")] uint dwTextFlags2, [NativeTypeName("LPCRECT")] RECT* pRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeBackgroundContentRect(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pContentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeBackgroundExtent(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pContentRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeBackgroundRegion(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, HRGN* pRegion);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemePartSize(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* prc, [NativeTypeName("enum THEMESIZE")] THEMESIZE eSize, SIZE* psz);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeTextExtent(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchCharCount, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeTextMetrics(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, TEXTMETRICW* ptm);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT HitTestThemeBackground(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCRECT")] RECT* pRect, HRGN hrgn, POINT ptTest, [NativeTypeName("WORD *")] ushort* pwHitTestCode);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeEdge(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pDestRect, uint uEdge, uint uFlags, [NativeTypeName("LPRECT")] RECT* pContentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeIcon(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, HIMAGELIST himl, int iImageIndex);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsThemePartDefined(HTHEME hTheme, int iPartId, int iStateId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsThemeBackgroundPartiallyTransparent(HTHEME hTheme, int iPartId, int iStateId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeColor(HTHEME hTheme, int iPartId, int iStateId, int iPropId, COLORREF* pColor);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeMetric(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeString(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszBuff, int cchMaxBuffChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeBool(HTHEME hTheme, int iPartId, int iStateId, int iPropId, BOOL* pfVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeInt(HTHEME hTheme, int iPartId, int iStateId, int iPropId, int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeEnumValue(HTHEME hTheme, int iPartId, int iStateId, int iPropId, int* piVal);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemePosition(HTHEME hTheme, int iPartId, int iStateId, int iPropId, POINT* pPoint);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeFont(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, LOGFONTW* pFont);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeRect(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPRECT")] RECT* pRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeMargins(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPCRECT")] RECT* prc, MARGINS* pMargins);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeIntList(HTHEME hTheme, int iPartId, int iStateId, int iPropId, INTLIST* pIntList);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemePropertyOrigin(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("enum PROPERTYORIGIN *")] PROPERTYORIGIN* pOrigin);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT SetWindowTheme(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeFilename(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxBuffChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern COLORREF GetThemeSysColor(HTHEME hTheme, int iColorId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HBRUSH GetThemeSysColorBrush(HTHEME hTheme, int iColorId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL GetThemeSysBool(HTHEME hTheme, int iBoolId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern int GetThemeSysSize(HTHEME hTheme, int iSizeId);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeSysFont(HTHEME hTheme, int iFontId, LOGFONTW* plf);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeSysString(HTHEME hTheme, int iStringId, [NativeTypeName("LPWSTR")] ushort* pszStringBuff, int cchMaxStringChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeSysInt(HTHEME hTheme, int iIntId, int* piValue);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsThemeActive();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsAppThemed();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HTHEME GetWindowTheme(HWND hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT EnableThemeDialogTexture(HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsThemeDialogTextureEnabled(HWND hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThemeAppProperties();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern void SetThemeAppProperties([NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetCurrentThemeName([NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxNameChars, [NativeTypeName("LPWSTR")] ushort* pszColorBuff, int cchMaxColorChars, [NativeTypeName("LPWSTR")] ushort* pszSizeBuff, int cchMaxSizeChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeDocumentationProperty([NativeTypeName("LPCWSTR")] ushort* pszThemeName, [NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("LPWSTR")] ushort* pszValueBuff, int cchMaxValChars);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeParentBackground(HWND hwnd, HDC hdc, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT EnableTheming(BOOL fEnable);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeParentBackgroundEx(HWND hwnd, HDC hdc, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT SetWindowThemeAttribute(HWND hwnd, [NativeTypeName("enum WINDOWTHEMEATTRIBUTETYPE")] WINDOWTHEMEATTRIBUTETYPE eAttribute, [NativeTypeName("PVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT DrawThemeTextEx(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPRECT")] RECT* pRect, [NativeTypeName("const DTTOPTS *")] DTTOPTS* pOptions);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeBitmap(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("ULONG")] uint dwFlags, HBITMAP* phBitmap);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeStream(HTHEME hTheme, int iPartId, int iStateId, int iPropId, void** ppvStream, [NativeTypeName("DWORD *")] uint* pcbStream, HINSTANCE hInst);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT BufferedPaintInit();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT BufferedPaintUnInit();

        [DllImport("uxtheme", ExactSpelling = true, SetLastError = true)]
        public static extern HPAINTBUFFER BeginBufferedPaint(HDC hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, BP_PAINTPARAMS* pPaintParams, HDC* phdc);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT EndBufferedPaint(HPAINTBUFFER hBufferedPaint, BOOL fUpdateTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetBufferedPaintTargetRect(HPAINTBUFFER hBufferedPaint, RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HDC GetBufferedPaintTargetDC(HPAINTBUFFER hBufferedPaint);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HDC GetBufferedPaintDC(HPAINTBUFFER hBufferedPaint);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetBufferedPaintBits(HPAINTBUFFER hBufferedPaint, RGBQUAD** ppbBuffer, int* pcxRow);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT BufferedPaintClear(HPAINTBUFFER hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT BufferedPaintSetAlpha(HPAINTBUFFER hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc, byte alpha);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT BufferedPaintStopAllAnimations(HWND hwnd);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HANIMATIONBUFFER BeginBufferedAnimation(HWND hwnd, HDC hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, BP_PAINTPARAMS* pPaintParams, BP_ANIMATIONPARAMS* pAnimationParams, HDC* phdcFrom, HDC* phdcTo);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT EndBufferedAnimation(HANIMATIONBUFFER hbpAnimation, BOOL fUpdateTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL BufferedPaintRenderAnimation(HWND hwnd, HDC hdcTarget);

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern BOOL IsCompositionActive();

        [DllImport("uxtheme", ExactSpelling = true)]
        public static extern HRESULT GetThemeTransitionDuration(HTHEME hTheme, int iPartId, int iStateIdFrom, int iStateIdTo, int iPropId, [NativeTypeName("DWORD *")] uint* pdwDuration);

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
