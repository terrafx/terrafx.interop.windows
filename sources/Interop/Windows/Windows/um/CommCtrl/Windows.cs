// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitCommonControls"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void InitCommonControls();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitCommonControlsEx"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL InitCommonControlsEx([NativeTypeName("const INITCOMMONCONTROLSEX *")] INITCOMMONCONTROLSEX* picce);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Create"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Create(int cx, int cy, uint flags, int cInitial, int cGrow);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Destroy"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Destroy(HIMAGELIST himl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetImageCount"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_GetImageCount(HIMAGELIST himl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetImageCount"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetImageCount(HIMAGELIST himl, uint uNewCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Add"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_Add(HIMAGELIST himl, HBITMAP hbmImage, HBITMAP hbmMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_ReplaceIcon"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_ReplaceIcon(HIMAGELIST himl, int i, HICON hicon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetBkColor"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern COLORREF ImageList_SetBkColor(HIMAGELIST himl, COLORREF clrBk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetBkColor"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern COLORREF ImageList_GetBkColor(HIMAGELIST himl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetOverlayImage"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetOverlayImage(HIMAGELIST himl, int iImage, int iOverlay);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Draw"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Draw(HIMAGELIST himl, int i, HDC hdcDst, int x, int y, uint fStyle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Replace"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Replace(HIMAGELIST himl, int i, HBITMAP hbmImage, HBITMAP hbmMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_AddMasked"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_AddMasked(HIMAGELIST himl, HBITMAP hbmImage, COLORREF crMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DrawEx"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DrawEx(HIMAGELIST himl, int i, HDC hdcDst, int x, int y, int dx, int dy, COLORREF rgbBk, COLORREF rgbFg, uint fStyle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DrawIndirect"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DrawIndirect(IMAGELISTDRAWPARAMS* pimldp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Remove"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Remove(HIMAGELIST himl, int i);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetIcon"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HICON ImageList_GetIcon(HIMAGELIST himl, int i, uint flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_LoadImageA"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_LoadImageA(HINSTANCE hi, [NativeTypeName("LPCSTR")] sbyte* lpbmp, int cx, int cGrow, COLORREF crMask, uint uType, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_LoadImageW"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_LoadImageW(HINSTANCE hi, [NativeTypeName("LPCWSTR")] char* lpbmp, int cx, int cGrow, COLORREF crMask, uint uType, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Copy"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Copy(HIMAGELIST himlDst, int iDst, HIMAGELIST himlSrc, int iSrc, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_BeginDrag"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_BeginDrag(HIMAGELIST himlTrack, int iTrack, int dxHotspot, int dyHotspot);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_EndDrag"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void ImageList_EndDrag();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragEnter"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragEnter(HWND hwndLock, int x, int y);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragLeave"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragLeave(HWND hwndLock);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragMove"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragMove(int x, int y);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetDragCursorImage"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetDragCursorImage(HIMAGELIST himlDrag, int iDrag, int dxHotspot, int dyHotspot);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragShowNolock"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragShowNolock(BOOL fShow);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetDragImage"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_GetDragImage(POINT* ppt, POINT* pptHotspot);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Read"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Read([NativeTypeName("struct IStream *")] IStream* pstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Write"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Write(HIMAGELIST himl, [NativeTypeName("struct IStream *")] IStream* pstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_ReadEx"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT ImageList_ReadEx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_WriteEx"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT ImageList_WriteEx(HIMAGELIST himl, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetIconSize"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_GetIconSize(HIMAGELIST himl, int* cx, int* cy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetIconSize"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetIconSize(HIMAGELIST himl, int cx, int cy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetImageInfo"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_GetImageInfo(HIMAGELIST himl, int i, IMAGEINFO* pImageInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Merge"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Merge(HIMAGELIST himl1, int i1, HIMAGELIST himl2, int i2, int dx, int dy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Duplicate"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Duplicate(HIMAGELIST himl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIMAGELIST_QueryInterface"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT HIMAGELIST_QueryInterface(HIMAGELIST himl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IImageListToHIMAGELIST"]/*' />
    public static HIMAGELIST IImageListToHIMAGELIST([NativeTypeName("struct IImageList *")] IImageList* himl)
    {
        return (HIMAGELIST)(himl);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateToolbarEx"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateToolbarEx(HWND hwnd, [NativeTypeName("DWORD")] uint ws, uint wID, int nBitmaps, HINSTANCE hBMInst, [NativeTypeName("UINT_PTR")] nuint wBMID, [NativeTypeName("LPCTBBUTTON")] TBBUTTON* lpButtons, int iNumButtons, int dxButton, int dyButton, int dxBitmap, int dyBitmap, uint uStructSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMappedBitmap"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HBITMAP CreateMappedBitmap(HINSTANCE hInstance, [NativeTypeName("INT_PTR")] nint idBitmap, uint wFlags, [NativeTypeName("LPCOLORMAP")] COLORMAP* lpColorMap, int iNumMaps);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStatusTextA"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawStatusTextA(HDC hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* pszText, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStatusTextW"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawStatusTextW(HDC hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCWSTR")] char* pszText, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStatusWindowA"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateStatusWindowA([NativeTypeName("LONG")] int style, [NativeTypeName("LPCSTR")] sbyte* lpszText, HWND hwndParent, uint wID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStatusWindowW"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateStatusWindowW([NativeTypeName("LONG")] int style, [NativeTypeName("LPCWSTR")] char* lpszText, HWND hwndParent, uint wID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MenuHelp"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void MenuHelp(uint uMsg, WPARAM wParam, LPARAM lParam, HMENU hMainMenu, HINSTANCE hInst, HWND hwndStatus, uint* lpwIDs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowHideMenuCtl"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ShowHideMenuCtl(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint uFlags, [NativeTypeName("LPINT")] int* lpInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEffectiveClientRect"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void GetEffectiveClientRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("const INT *")] int* lpInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MakeDragList"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL MakeDragList(HWND hLB);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawInsert"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawInsert(HWND handParent, HWND hLB, int nItem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LBItemFromPt"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int LBItemFromPt(HWND hLB, POINT pt, BOOL bAutoScroll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUpDownControl"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HWND CreateUpDownControl([NativeTypeName("DWORD")] uint dwStyle, int x, int y, int cx, int cy, HWND hParent, int nID, HINSTANCE hInst, HWND hBuddy, int nUpper, int nLower, int nPos);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TaskDialogIndirect"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT TaskDialogIndirect([NativeTypeName("const TASKDIALOGCONFIG *")] TASKDIALOGCONFIG* pTaskConfig, int* pnButton, int* pnRadioButton, BOOL* pfVerificationFlagChecked);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TaskDialog"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT TaskDialog(HWND hwndOwner, HINSTANCE hInstance, [NativeTypeName("PCWSTR")] char* pszWindowTitle, [NativeTypeName("PCWSTR")] char* pszMainInstruction, [NativeTypeName("PCWSTR")] char* pszContent, [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")] int dwCommonButtons, [NativeTypeName("PCWSTR")] char* pszIcon, int* pnButton);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitMUILanguage"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void InitMUILanguage([NativeTypeName("LANGID")] ushort uiLang);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMUILanguage"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    [return: NativeTypeName("LANGID")]
    public static extern ushort GetMUILanguage();

    /// <include file='Windows.xml' path='doc/member[@name="Windows._TrackMouseEvent"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL _TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_EnableScrollBar"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_EnableScrollBar(HWND param0, int param1, uint param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_ShowScrollBar"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_ShowScrollBar(HWND param0, int code, BOOL param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollRange"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollRange(HWND param0, int code, [NativeTypeName("LPINT")] int* param2, [NativeTypeName("LPINT")] int* param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollInfo"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollInfo(HWND param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollPos"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_GetScrollPos(HWND param0, int code);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollProp"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollProp(HWND param0, int propIndex, [NativeTypeName("LPINT")] int* param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollPos"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollPos(HWND param0, int code, int pos, BOOL fRedraw);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollInfo"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollInfo(HWND param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* psi, BOOL fRedraw);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollRange"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollRange(HWND param0, int code, int min, int max, BOOL fRedraw);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollProp"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_SetScrollProp(HWND param0, uint index, [NativeTypeName("INT_PTR")] nint newValue, BOOL param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeFlatSB"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL InitializeFlatSB(HWND param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninitializeFlatSB"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT UninitializeFlatSB(HWND param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowSubclass"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL SetWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR")] nuint dwRefData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowSubclass"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL GetWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR *")] nuint* pdwRefData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveWindowSubclass"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL RemoveWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefSubclassProc"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern LRESULT DefSubclassProc(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconMetric"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT LoadIconMetric(HINSTANCE hinst, [NativeTypeName("PCWSTR")] char* pszName, int lims, HICON* phico);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconWithScaleDown"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT LoadIconWithScaleDown(HINSTANCE hinst, [NativeTypeName("PCWSTR")] char* pszName, int cx, int cy, HICON* phico);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawShadowText"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int DrawShadowText(HDC hdc, [NativeTypeName("LPCWSTR")] char* pszText, uint cch, RECT* prc, [NativeTypeName("DWORD")] uint dwFlags, COLORREF crText, COLORREF crShadow, int ixOffset, int iyOffset);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ODT_HEADER"]/*' />
    [NativeTypeName("#define ODT_HEADER 100")]
    public const int ODT_HEADER = 100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ODT_TAB"]/*' />
    [NativeTypeName("#define ODT_TAB 101")]
    public const int ODT_TAB = 101;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ODT_LISTVIEW"]/*' />
    [NativeTypeName("#define ODT_LISTVIEW 102")]
    public const int ODT_LISTVIEW = 102;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TV_FIRST"]/*' />
    [NativeTypeName("#define TV_FIRST 0x1100")]
    public const int TV_FIRST = 0x1100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ECM_FIRST"]/*' />
    [NativeTypeName("#define ECM_FIRST 0x1500")]
    public const int ECM_FIRST = 0x1500;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBM_FIRST"]/*' />
    [NativeTypeName("#define CBM_FIRST 0x1700")]
    public const int CBM_FIRST = 0x1700;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMCTL32_VERSION"]/*' />
    [NativeTypeName("#define COMCTL32_VERSION 6")]
    public const int COMCTL32_VERSION = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INFOTIPSIZE"]/*' />
    [NativeTypeName("#define INFOTIPSIZE 1024")]
    public const int INFOTIPSIZE = 1024;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_FIRST"]/*' />
    [NativeTypeName("#define TCN_FIRST (0U-550U)")]
    public const uint TCN_FIRST = unchecked(0U - 550U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_LAST"]/*' />
    [NativeTypeName("#define TCN_LAST (0U-580U)")]
    public const uint TCN_LAST = unchecked(0U - 580U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDN_FIRST"]/*' />
    [NativeTypeName("#define UDN_FIRST (0U-721U)")]
    public const uint UDN_FIRST = unchecked(0U - 721U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDN_LAST"]/*' />
    [NativeTypeName("#define UDN_LAST (0U-729U)")]
    public const uint UDN_LAST = unchecked(0U - 729U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_FIRST"]/*' />
    [NativeTypeName("#define MCN_FIRST (0U-746U)")]
    public const uint MCN_FIRST = unchecked(0U - 746U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_LAST"]/*' />
    [NativeTypeName("#define MCN_LAST (0U-752U)")]
    public const uint MCN_LAST = unchecked(0U - 752U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPN_FIRST"]/*' />
    [NativeTypeName("#define IPN_FIRST (0U-860U)")]
    public const uint IPN_FIRST = unchecked(0U - 860U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPN_LAST"]/*' />
    [NativeTypeName("#define IPN_LAST (0U-879U)")]
    public const uint IPN_LAST = unchecked(0U - 879U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBN_FIRST"]/*' />
    [NativeTypeName("#define SBN_FIRST (0U-880U)")]
    public const uint SBN_FIRST = unchecked(0U - 880U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBN_LAST"]/*' />
    [NativeTypeName("#define SBN_LAST (0U-899U)")]
    public const uint SBN_LAST = unchecked(0U - 899U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGN_FIRST"]/*' />
    [NativeTypeName("#define PGN_FIRST (0U-900U)")]
    public const uint PGN_FIRST = unchecked(0U - 900U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGN_LAST"]/*' />
    [NativeTypeName("#define PGN_LAST (0U-950U)")]
    public const uint PGN_LAST = unchecked(0U - 950U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMN_FIRST"]/*' />
    [NativeTypeName("#define WMN_FIRST (0U-1000U)")]
    public const uint WMN_FIRST = unchecked(0U - 1000U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMN_LAST"]/*' />
    [NativeTypeName("#define WMN_LAST (0U-1200U)")]
    public const uint WMN_LAST = unchecked(0U - 1200U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCN_FIRST"]/*' />
    [NativeTypeName("#define BCN_FIRST (0U-1250U)")]
    public const uint BCN_FIRST = unchecked(0U - 1250U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCN_LAST"]/*' />
    [NativeTypeName("#define BCN_LAST (0U-1350U)")]
    public const uint BCN_LAST = unchecked(0U - 1350U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRBN_FIRST"]/*' />
    [NativeTypeName("#define TRBN_FIRST (0U-1501U)")]
    public const uint TRBN_FIRST = unchecked(0U - 1501U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRBN_LAST"]/*' />
    [NativeTypeName("#define TRBN_LAST (0U-1519U)")]
    public const uint TRBN_LAST = unchecked(0U - 1519U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_DODEFAULT"]/*' />
    [NativeTypeName("#define CDRF_DODEFAULT 0x00000000")]
    public const int CDRF_DODEFAULT = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_NEWFONT"]/*' />
    [NativeTypeName("#define CDRF_NEWFONT 0x00000002")]
    public const int CDRF_NEWFONT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_SKIPDEFAULT"]/*' />
    [NativeTypeName("#define CDRF_SKIPDEFAULT 0x00000004")]
    public const int CDRF_SKIPDEFAULT = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_DOERASE"]/*' />
    [NativeTypeName("#define CDRF_DOERASE 0x00000008")]
    public const int CDRF_DOERASE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_SKIPPOSTPAINT"]/*' />
    [NativeTypeName("#define CDRF_SKIPPOSTPAINT 0x00000100")]
    public const int CDRF_SKIPPOSTPAINT = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_NOTIFYPOSTPAINT"]/*' />
    [NativeTypeName("#define CDRF_NOTIFYPOSTPAINT 0x00000010")]
    public const int CDRF_NOTIFYPOSTPAINT = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_NOTIFYITEMDRAW"]/*' />
    [NativeTypeName("#define CDRF_NOTIFYITEMDRAW 0x00000020")]
    public const int CDRF_NOTIFYITEMDRAW = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_NOTIFYSUBITEMDRAW"]/*' />
    [NativeTypeName("#define CDRF_NOTIFYSUBITEMDRAW 0x00000020")]
    public const int CDRF_NOTIFYSUBITEMDRAW = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDRF_NOTIFYPOSTERASE"]/*' />
    [NativeTypeName("#define CDRF_NOTIFYPOSTERASE 0x00000040")]
    public const int CDRF_NOTIFYPOSTERASE = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLR_NONE"]/*' />
    [NativeTypeName("#define CLR_NONE 0xFFFFFFFFL")]
    public const uint CLR_NONE = 0xFFFFFFFF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLR_DEFAULT"]/*' />
    [NativeTypeName("#define CLR_DEFAULT 0xFF000000L")]
    public const uint CLR_DEFAULT = 0xFF000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLR_HILIGHT"]/*' />
    [NativeTypeName("#define CLR_HILIGHT CLR_DEFAULT")]
    public const uint CLR_HILIGHT = 0xFF000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILS_NORMAL"]/*' />
    [NativeTypeName("#define ILS_NORMAL 0x00000000")]
    public const int ILS_NORMAL = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILS_GLOW"]/*' />
    [NativeTypeName("#define ILS_GLOW 0x00000001")]
    public const int ILS_GLOW = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILS_SHADOW"]/*' />
    [NativeTypeName("#define ILS_SHADOW 0x00000002")]
    public const int ILS_SHADOW = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILS_SATURATE"]/*' />
    [NativeTypeName("#define ILS_SATURATE 0x00000004")]
    public const int ILS_SATURATE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILS_ALPHA"]/*' />
    [NativeTypeName("#define ILS_ALPHA 0x00000008")]
    public const int ILS_ALPHA = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGT_NORMAL"]/*' />
    [NativeTypeName("#define ILGT_NORMAL 0x00000000")]
    public const int ILGT_NORMAL = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGT_ASYNC"]/*' />
    [NativeTypeName("#define ILGT_ASYNC 0x00000001")]
    public const int ILGT_ASYNC = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_LoadImage"]/*' />
    [NativeTypeName("#define ImageList_LoadImage ImageList_LoadImageW")]
    public static delegate*<HINSTANCE, char*, int, int, COLORREF, uint, uint, HIMAGELIST> ImageList_LoadImage => &ImageList_LoadImageW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCF_MOVE"]/*' />
    [NativeTypeName("#define ILCF_MOVE (0x00000000)")]
    public const int ILCF_MOVE = (0x00000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCF_SWAP"]/*' />
    [NativeTypeName("#define ILCF_SWAP (0x00000001)")]
    public const int ILCF_SWAP = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILP_NORMAL"]/*' />
    [NativeTypeName("#define ILP_NORMAL 0")]
    public const int ILP_NORMAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILP_DOWNLEVEL"]/*' />
    [NativeTypeName("#define ILP_DOWNLEVEL 1")]
    public const int ILP_DOWNLEVEL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDFT_ISSTRING"]/*' />
    [NativeTypeName("#define HDFT_ISSTRING 0x0000")]
    public const int HDFT_ISSTRING = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDFT_ISNUMBER"]/*' />
    [NativeTypeName("#define HDFT_ISNUMBER 0x0001")]
    public const int HDFT_ISNUMBER = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDFT_ISDATE"]/*' />
    [NativeTypeName("#define HDFT_ISDATE 0x0002")]
    public const int HDFT_ISDATE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDFT_HASNOVALUE"]/*' />
    [NativeTypeName("#define HDFT_HASNOVALUE 0x8000")]
    public const int HDFT_HASNOVALUE = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDIS_FOCUSED"]/*' />
    [NativeTypeName("#define HDIS_FOCUSED 0x00000001")]
    public const int HDIS_FOCUSED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDSIL_NORMAL"]/*' />
    [NativeTypeName("#define HDSIL_NORMAL 0")]
    public const int HDSIL_NORMAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HDSIL_STATE"]/*' />
    [NativeTypeName("#define HDSIL_STATE 1")]
    public const int HDSIL_STATE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLBARCLASSNAMEW"]/*' />
    [NativeTypeName("#define TOOLBARCLASSNAMEW L\"ToolbarWindow32\"")]
    public const string TOOLBARCLASSNAMEW = "ToolbarWindow32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLBARCLASSNAMEA"]/*' />
    [NativeTypeName("#define TOOLBARCLASSNAMEA \"ToolbarWindow32\"")]
    public static ReadOnlySpan<byte> TOOLBARCLASSNAMEA => "ToolbarWindow32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLBARCLASSNAME"]/*' />
    [NativeTypeName("#define TOOLBARCLASSNAME TOOLBARCLASSNAMEW")]
    public const string TOOLBARCLASSNAME = "ToolbarWindow32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMB_MASKED"]/*' />
    [NativeTypeName("#define CMB_MASKED 0x02")]
    public const int CMB_MASKED = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_CHECKED"]/*' />
    [NativeTypeName("#define TBSTATE_CHECKED 0x01")]
    public const int TBSTATE_CHECKED = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_PRESSED"]/*' />
    [NativeTypeName("#define TBSTATE_PRESSED 0x02")]
    public const int TBSTATE_PRESSED = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_ENABLED"]/*' />
    [NativeTypeName("#define TBSTATE_ENABLED 0x04")]
    public const int TBSTATE_ENABLED = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_HIDDEN"]/*' />
    [NativeTypeName("#define TBSTATE_HIDDEN 0x08")]
    public const int TBSTATE_HIDDEN = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_INDETERMINATE"]/*' />
    [NativeTypeName("#define TBSTATE_INDETERMINATE 0x10")]
    public const int TBSTATE_INDETERMINATE = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_WRAP"]/*' />
    [NativeTypeName("#define TBSTATE_WRAP 0x20")]
    public const int TBSTATE_WRAP = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_ELLIPSES"]/*' />
    [NativeTypeName("#define TBSTATE_ELLIPSES 0x40")]
    public const int TBSTATE_ELLIPSES = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBSTATE_MARKED"]/*' />
    [NativeTypeName("#define TBSTATE_MARKED 0x80")]
    public const int TBSTATE_MARKED = 0x80;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_NOEDGES"]/*' />
    [NativeTypeName("#define TBCDRF_NOEDGES 0x00010000")]
    public const int TBCDRF_NOEDGES = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_HILITEHOTTRACK"]/*' />
    [NativeTypeName("#define TBCDRF_HILITEHOTTRACK 0x00020000")]
    public const int TBCDRF_HILITEHOTTRACK = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_NOOFFSET"]/*' />
    [NativeTypeName("#define TBCDRF_NOOFFSET 0x00040000")]
    public const int TBCDRF_NOOFFSET = 0x00040000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_NOMARK"]/*' />
    [NativeTypeName("#define TBCDRF_NOMARK 0x00080000")]
    public const int TBCDRF_NOMARK = 0x00080000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_NOETCHEDEFFECT"]/*' />
    [NativeTypeName("#define TBCDRF_NOETCHEDEFFECT 0x00100000")]
    public const int TBCDRF_NOETCHEDEFFECT = 0x00100000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_BLENDICON"]/*' />
    [NativeTypeName("#define TBCDRF_BLENDICON 0x00200000")]
    public const int TBCDRF_BLENDICON = 0x00200000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_NOBACKGROUND"]/*' />
    [NativeTypeName("#define TBCDRF_NOBACKGROUND 0x00400000")]
    public const int TBCDRF_NOBACKGROUND = 0x00400000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCDRF_USECDCOLORS"]/*' />
    [NativeTypeName("#define TBCDRF_USECDCOLORS 0x00800000")]
    public const int TBCDRF_USECDCOLORS = 0x00800000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIST_BACK"]/*' />
    [NativeTypeName("#define HIST_BACK 0")]
    public const int HIST_BACK = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIST_FORWARD"]/*' />
    [NativeTypeName("#define HIST_FORWARD 1")]
    public const int HIST_FORWARD = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIST_FAVORITES"]/*' />
    [NativeTypeName("#define HIST_FAVORITES 2")]
    public const int HIST_FAVORITES = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIST_ADDTOFAVORITES"]/*' />
    [NativeTypeName("#define HIST_ADDTOFAVORITES 3")]
    public const int HIST_ADDTOFAVORITES = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIST_VIEWTREE"]/*' />
    [NativeTypeName("#define HIST_VIEWTREE 4")]
    public const int HIST_VIEWTREE = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBIMHT_AFTER"]/*' />
    [NativeTypeName("#define TBIMHT_AFTER 0x00000001")]
    public const int TBIMHT_AFTER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBIMHT_BACKGROUND"]/*' />
    [NativeTypeName("#define TBIMHT_BACKGROUND 0x00000002")]
    public const int TBIMHT_BACKGROUND = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBBF_LARGE"]/*' />
    [NativeTypeName("#define TBBF_LARGE 0x0001")]
    public const int TBBF_LARGE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBMF_PAD"]/*' />
    [NativeTypeName("#define TBMF_PAD 0x00000001")]
    public const int TBMF_PAD = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBMF_BARPAD"]/*' />
    [NativeTypeName("#define TBMF_BARPAD 0x00000002")]
    public const int TBMF_BARPAD = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBMF_BUTTONSPACING"]/*' />
    [NativeTypeName("#define TBMF_BUTTONSPACING 0x00000004")]
    public const int TBMF_BUTTONSPACING = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBNRF_HIDEHELP"]/*' />
    [NativeTypeName("#define TBNRF_HIDEHELP 0x00000001")]
    public const int TBNRF_HIDEHELP = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBNRF_ENDCUSTOMIZE"]/*' />
    [NativeTypeName("#define TBNRF_ENDCUSTOMIZE 0x00000002")]
    public const int TBNRF_ENDCUSTOMIZE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBNF_IMAGE"]/*' />
    [NativeTypeName("#define TBNF_IMAGE 0x00000001")]
    public const int TBNF_IMAGE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBNF_TEXT"]/*' />
    [NativeTypeName("#define TBNF_TEXT 0x00000002")]
    public const int TBNF_TEXT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBNF_DI_SETITEM"]/*' />
    [NativeTypeName("#define TBNF_DI_SETITEM 0x10000000")]
    public const int TBNF_DI_SETITEM = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBDDRET_DEFAULT"]/*' />
    [NativeTypeName("#define TBDDRET_DEFAULT 0")]
    public const int TBDDRET_DEFAULT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBDDRET_NODEFAULT"]/*' />
    [NativeTypeName("#define TBDDRET_NODEFAULT 1")]
    public const int TBDDRET_NODEFAULT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBDDRET_TREATPRESSED"]/*' />
    [NativeTypeName("#define TBDDRET_TREATPRESSED 2")]
    public const int TBDDRET_TREATPRESSED = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.REBARCLASSNAMEW"]/*' />
    [NativeTypeName("#define REBARCLASSNAMEW L\"ReBarWindow32\"")]
    public const string REBARCLASSNAMEW = "ReBarWindow32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.REBARCLASSNAMEA"]/*' />
    [NativeTypeName("#define REBARCLASSNAMEA \"ReBarWindow32\"")]
    public static ReadOnlySpan<byte> REBARCLASSNAMEA => "ReBarWindow32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.REBARCLASSNAME"]/*' />
    [NativeTypeName("#define REBARCLASSNAME REBARCLASSNAMEW")]
    public const string REBARCLASSNAME = "ReBarWindow32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBIM_IMAGELIST"]/*' />
    [NativeTypeName("#define RBIM_IMAGELIST 0x00000001")]
    public const int RBIM_IMAGELIST = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_TOOLTIPS"]/*' />
    [NativeTypeName("#define RBS_TOOLTIPS 0x00000100")]
    public const int RBS_TOOLTIPS = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_VARHEIGHT"]/*' />
    [NativeTypeName("#define RBS_VARHEIGHT 0x00000200")]
    public const int RBS_VARHEIGHT = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_BANDBORDERS"]/*' />
    [NativeTypeName("#define RBS_BANDBORDERS 0x00000400")]
    public const int RBS_BANDBORDERS = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_FIXEDORDER"]/*' />
    [NativeTypeName("#define RBS_FIXEDORDER 0x00000800")]
    public const int RBS_FIXEDORDER = 0x00000800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_REGISTERDROP"]/*' />
    [NativeTypeName("#define RBS_REGISTERDROP 0x00001000")]
    public const int RBS_REGISTERDROP = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_AUTOSIZE"]/*' />
    [NativeTypeName("#define RBS_AUTOSIZE 0x00002000")]
    public const int RBS_AUTOSIZE = 0x00002000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_VERTICALGRIPPER"]/*' />
    [NativeTypeName("#define RBS_VERTICALGRIPPER 0x00004000")]
    public const int RBS_VERTICALGRIPPER = 0x00004000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBS_DBLCLKTOGGLE"]/*' />
    [NativeTypeName("#define RBS_DBLCLKTOGGLE 0x00008000")]
    public const int RBS_DBLCLKTOGGLE = 0x00008000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBSTR_CHANGERECT"]/*' />
    [NativeTypeName("#define RBSTR_CHANGERECT 0x0001")]
    public const int RBSTR_CHANGERECT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBNM_ID"]/*' />
    [NativeTypeName("#define RBNM_ID 0x00000001")]
    public const int RBNM_ID = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBNM_STYLE"]/*' />
    [NativeTypeName("#define RBNM_STYLE 0x00000002")]
    public const int RBNM_STYLE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBNM_LPARAM"]/*' />
    [NativeTypeName("#define RBNM_LPARAM 0x00000004")]
    public const int RBNM_LPARAM = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBAB_AUTOSIZE"]/*' />
    [NativeTypeName("#define RBAB_AUTOSIZE 0x0001")]
    public const int RBAB_AUTOSIZE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBAB_ADDBAND"]/*' />
    [NativeTypeName("#define RBAB_ADDBAND 0x0002")]
    public const int RBAB_ADDBAND = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_NOWHERE"]/*' />
    [NativeTypeName("#define RBHT_NOWHERE 0x0001")]
    public const int RBHT_NOWHERE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_CAPTION"]/*' />
    [NativeTypeName("#define RBHT_CAPTION 0x0002")]
    public const int RBHT_CAPTION = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_CLIENT"]/*' />
    [NativeTypeName("#define RBHT_CLIENT 0x0003")]
    public const int RBHT_CLIENT = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_GRABBER"]/*' />
    [NativeTypeName("#define RBHT_GRABBER 0x0004")]
    public const int RBHT_GRABBER = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_CHEVRON"]/*' />
    [NativeTypeName("#define RBHT_CHEVRON 0x0008")]
    public const int RBHT_CHEVRON = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RBHT_SPLITTER"]/*' />
    [NativeTypeName("#define RBHT_SPLITTER 0x0010")]
    public const int RBHT_SPLITTER = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLTIPS_CLASSW"]/*' />
    [NativeTypeName("#define TOOLTIPS_CLASSW L\"tooltips_class32\"")]
    public const string TOOLTIPS_CLASSW = "tooltips_class32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLTIPS_CLASSA"]/*' />
    [NativeTypeName("#define TOOLTIPS_CLASSA \"tooltips_class32\"")]
    public static ReadOnlySpan<byte> TOOLTIPS_CLASSA => "tooltips_class32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOOLTIPS_CLASS"]/*' />
    [NativeTypeName("#define TOOLTIPS_CLASS TOOLTIPS_CLASSW")]
    public const string TOOLTIPS_CLASS = "tooltips_class32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_ALWAYSTIP"]/*' />
    [NativeTypeName("#define TTS_ALWAYSTIP 0x01")]
    public const int TTS_ALWAYSTIP = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_NOPREFIX"]/*' />
    [NativeTypeName("#define TTS_NOPREFIX 0x02")]
    public const int TTS_NOPREFIX = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_NOANIMATE"]/*' />
    [NativeTypeName("#define TTS_NOANIMATE 0x10")]
    public const int TTS_NOANIMATE = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_NOFADE"]/*' />
    [NativeTypeName("#define TTS_NOFADE 0x20")]
    public const int TTS_NOFADE = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_BALLOON"]/*' />
    [NativeTypeName("#define TTS_BALLOON 0x40")]
    public const int TTS_BALLOON = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_CLOSE"]/*' />
    [NativeTypeName("#define TTS_CLOSE 0x80")]
    public const int TTS_CLOSE = 0x80;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTS_USEVISUALSTYLE"]/*' />
    [NativeTypeName("#define TTS_USEVISUALSTYLE 0x100")]
    public const int TTS_USEVISUALSTYLE = 0x100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_IDISHWND"]/*' />
    [NativeTypeName("#define TTF_IDISHWND 0x0001")]
    public const int TTF_IDISHWND = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_CENTERTIP"]/*' />
    [NativeTypeName("#define TTF_CENTERTIP 0x0002")]
    public const int TTF_CENTERTIP = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_RTLREADING"]/*' />
    [NativeTypeName("#define TTF_RTLREADING 0x0004")]
    public const int TTF_RTLREADING = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_SUBCLASS"]/*' />
    [NativeTypeName("#define TTF_SUBCLASS 0x0010")]
    public const int TTF_SUBCLASS = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_TRACK"]/*' />
    [NativeTypeName("#define TTF_TRACK 0x0020")]
    public const int TTF_TRACK = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_ABSOLUTE"]/*' />
    [NativeTypeName("#define TTF_ABSOLUTE 0x0080")]
    public const int TTF_ABSOLUTE = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_TRANSPARENT"]/*' />
    [NativeTypeName("#define TTF_TRANSPARENT 0x0100")]
    public const int TTF_TRANSPARENT = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_PARSELINKS"]/*' />
    [NativeTypeName("#define TTF_PARSELINKS 0x1000")]
    public const int TTF_PARSELINKS = 0x1000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTF_DI_SETITEM"]/*' />
    [NativeTypeName("#define TTF_DI_SETITEM 0x8000")]
    public const int TTF_DI_SETITEM = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTDT_AUTOMATIC"]/*' />
    [NativeTypeName("#define TTDT_AUTOMATIC 0")]
    public const int TTDT_AUTOMATIC = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTDT_RESHOW"]/*' />
    [NativeTypeName("#define TTDT_RESHOW 1")]
    public const int TTDT_RESHOW = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTDT_AUTOPOP"]/*' />
    [NativeTypeName("#define TTDT_AUTOPOP 2")]
    public const int TTDT_AUTOPOP = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTDT_INITIAL"]/*' />
    [NativeTypeName("#define TTDT_INITIAL 3")]
    public const int TTDT_INITIAL = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_NONE"]/*' />
    [NativeTypeName("#define TTI_NONE 0")]
    public const int TTI_NONE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_INFO"]/*' />
    [NativeTypeName("#define TTI_INFO 1")]
    public const int TTI_INFO = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_WARNING"]/*' />
    [NativeTypeName("#define TTI_WARNING 2")]
    public const int TTI_WARNING = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_ERROR"]/*' />
    [NativeTypeName("#define TTI_ERROR 3")]
    public const int TTI_ERROR = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_INFO_LARGE"]/*' />
    [NativeTypeName("#define TTI_INFO_LARGE 4")]
    public const int TTI_INFO_LARGE = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_WARNING_LARGE"]/*' />
    [NativeTypeName("#define TTI_WARNING_LARGE 5")]
    public const int TTI_WARNING_LARGE = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TTI_ERROR_LARGE"]/*' />
    [NativeTypeName("#define TTI_ERROR_LARGE 6")]
    public const int TTI_ERROR_LARGE = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBARS_SIZEGRIP"]/*' />
    [NativeTypeName("#define SBARS_SIZEGRIP 0x0100")]
    public const int SBARS_SIZEGRIP = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBARS_TOOLTIPS"]/*' />
    [NativeTypeName("#define SBARS_TOOLTIPS 0x0800")]
    public const int SBARS_TOOLTIPS = 0x0800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_TOOLTIPS"]/*' />
    [NativeTypeName("#define SBT_TOOLTIPS 0x0800")]
    public const int SBT_TOOLTIPS = 0x0800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStatusWindow"]/*' />
    [NativeTypeName("#define CreateStatusWindow CreateStatusWindowW")]
    public static delegate*<int, char*, HWND, uint, HWND> CreateStatusWindow => &CreateStatusWindowW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStatusText"]/*' />
    [NativeTypeName("#define DrawStatusText DrawStatusTextW")]
    public static delegate*<HDC, RECT*, char*, uint, void> DrawStatusText => &DrawStatusTextW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STATUSCLASSNAMEW"]/*' />
    [NativeTypeName("#define STATUSCLASSNAMEW L\"msctls_statusbar32\"")]
    public const string STATUSCLASSNAMEW = "msctls_statusbar32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STATUSCLASSNAMEA"]/*' />
    [NativeTypeName("#define STATUSCLASSNAMEA \"msctls_statusbar32\"")]
    public static ReadOnlySpan<byte> STATUSCLASSNAMEA => "msctls_statusbar32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STATUSCLASSNAME"]/*' />
    [NativeTypeName("#define STATUSCLASSNAME STATUSCLASSNAMEW")]
    public const string STATUSCLASSNAME = "msctls_statusbar32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_OWNERDRAW"]/*' />
    [NativeTypeName("#define SBT_OWNERDRAW 0x1000")]
    public const int SBT_OWNERDRAW = 0x1000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_NOBORDERS"]/*' />
    [NativeTypeName("#define SBT_NOBORDERS 0x0100")]
    public const int SBT_NOBORDERS = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_POPOUT"]/*' />
    [NativeTypeName("#define SBT_POPOUT 0x0200")]
    public const int SBT_POPOUT = 0x0200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_RTLREADING"]/*' />
    [NativeTypeName("#define SBT_RTLREADING 0x0400")]
    public const int SBT_RTLREADING = 0x0400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBT_NOTABPARSING"]/*' />
    [NativeTypeName("#define SBT_NOTABPARSING 0x0800")]
    public const int SBT_NOTABPARSING = 0x0800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SBN_SIMPLEMODECHANGE"]/*' />
    [NativeTypeName("#define SBN_SIMPLEMODECHANGE (SBN_FIRST - 0)")]
    public const uint SBN_SIMPLEMODECHANGE = unchecked((0U - 880U) - 0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MINSYSCOMMAND"]/*' />
    [NativeTypeName("#define MINSYSCOMMAND SC_SIZE")]
    public const int MINSYSCOMMAND = 0xF000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRACKBAR_CLASSA"]/*' />
    [NativeTypeName("#define TRACKBAR_CLASSA \"msctls_trackbar32\"")]
    public static ReadOnlySpan<byte> TRACKBAR_CLASSA => "msctls_trackbar32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRACKBAR_CLASSW"]/*' />
    [NativeTypeName("#define TRACKBAR_CLASSW L\"msctls_trackbar32\"")]
    public const string TRACKBAR_CLASSW = "msctls_trackbar32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRACKBAR_CLASS"]/*' />
    [NativeTypeName("#define TRACKBAR_CLASS TRACKBAR_CLASSW")]
    public const string TRACKBAR_CLASS = "msctls_trackbar32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBTS_TOP"]/*' />
    [NativeTypeName("#define TBTS_TOP 0")]
    public const int TBTS_TOP = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBTS_LEFT"]/*' />
    [NativeTypeName("#define TBTS_LEFT 1")]
    public const int TBTS_LEFT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBTS_BOTTOM"]/*' />
    [NativeTypeName("#define TBTS_BOTTOM 2")]
    public const int TBTS_BOTTOM = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBTS_RIGHT"]/*' />
    [NativeTypeName("#define TBTS_RIGHT 3")]
    public const int TBTS_RIGHT = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCD_TICS"]/*' />
    [NativeTypeName("#define TBCD_TICS 0x0001")]
    public const int TBCD_TICS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCD_THUMB"]/*' />
    [NativeTypeName("#define TBCD_THUMB 0x0002")]
    public const int TBCD_THUMB = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TBCD_CHANNEL"]/*' />
    [NativeTypeName("#define TBCD_CHANNEL 0x0003")]
    public const int TBCD_CHANNEL = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRBN_THUMBPOSCHANGING"]/*' />
    [NativeTypeName("#define TRBN_THUMBPOSCHANGING (TRBN_FIRST-1)")]
    public const uint TRBN_THUMBPOSCHANGING = unchecked((0U - 1501U) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_BEGINDRAG"]/*' />
    [NativeTypeName("#define DL_BEGINDRAG (WM_USER+133)")]
    public const int DL_BEGINDRAG = (0x0400 + 133);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_DRAGGING"]/*' />
    [NativeTypeName("#define DL_DRAGGING (WM_USER+134)")]
    public const int DL_DRAGGING = (0x0400 + 134);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_DROPPED"]/*' />
    [NativeTypeName("#define DL_DROPPED (WM_USER+135)")]
    public const int DL_DROPPED = (0x0400 + 135);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_CANCELDRAG"]/*' />
    [NativeTypeName("#define DL_CANCELDRAG (WM_USER+136)")]
    public const int DL_CANCELDRAG = (0x0400 + 136);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_CURSORSET"]/*' />
    [NativeTypeName("#define DL_CURSORSET 0")]
    public const int DL_CURSORSET = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_STOPCURSOR"]/*' />
    [NativeTypeName("#define DL_STOPCURSOR 1")]
    public const int DL_STOPCURSOR = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_COPYCURSOR"]/*' />
    [NativeTypeName("#define DL_COPYCURSOR 2")]
    public const int DL_COPYCURSOR = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DL_MOVECURSOR"]/*' />
    [NativeTypeName("#define DL_MOVECURSOR 3")]
    public const int DL_MOVECURSOR = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRAGLISTMSGSTRING"]/*' />
    [NativeTypeName("#define DRAGLISTMSGSTRING TEXT(\"commctrl_DragListMsg\")")]
    public const string DRAGLISTMSGSTRING = "commctrl_DragListMsg";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDOWN_CLASSA"]/*' />
    [NativeTypeName("#define UPDOWN_CLASSA \"msctls_updown32\"")]
    public static ReadOnlySpan<byte> UPDOWN_CLASSA => "msctls_updown32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDOWN_CLASSW"]/*' />
    [NativeTypeName("#define UPDOWN_CLASSW L\"msctls_updown32\"")]
    public const string UPDOWN_CLASSW = "msctls_updown32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDOWN_CLASS"]/*' />
    [NativeTypeName("#define UPDOWN_CLASS UPDOWN_CLASSW")]
    public const string UPDOWN_CLASS = "msctls_updown32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UD_MAXVAL"]/*' />
    [NativeTypeName("#define UD_MAXVAL 0x7fff")]
    public const int UD_MAXVAL = 0x7fff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UD_MINVAL"]/*' />
    [NativeTypeName("#define UD_MINVAL (-UD_MAXVAL)")]
    public const int UD_MINVAL = (-0x7fff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_WRAP"]/*' />
    [NativeTypeName("#define UDS_WRAP 0x0001")]
    public const int UDS_WRAP = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_SETBUDDYINT"]/*' />
    [NativeTypeName("#define UDS_SETBUDDYINT 0x0002")]
    public const int UDS_SETBUDDYINT = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_ALIGNRIGHT"]/*' />
    [NativeTypeName("#define UDS_ALIGNRIGHT 0x0004")]
    public const int UDS_ALIGNRIGHT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_ALIGNLEFT"]/*' />
    [NativeTypeName("#define UDS_ALIGNLEFT 0x0008")]
    public const int UDS_ALIGNLEFT = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_AUTOBUDDY"]/*' />
    [NativeTypeName("#define UDS_AUTOBUDDY 0x0010")]
    public const int UDS_AUTOBUDDY = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_ARROWKEYS"]/*' />
    [NativeTypeName("#define UDS_ARROWKEYS 0x0020")]
    public const int UDS_ARROWKEYS = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_HORZ"]/*' />
    [NativeTypeName("#define UDS_HORZ 0x0040")]
    public const int UDS_HORZ = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_NOTHOUSANDS"]/*' />
    [NativeTypeName("#define UDS_NOTHOUSANDS 0x0080")]
    public const int UDS_NOTHOUSANDS = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDS_HOTTRACK"]/*' />
    [NativeTypeName("#define UDS_HOTTRACK 0x0100")]
    public const int UDS_HOTTRACK = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDN_DELTAPOS"]/*' />
    [NativeTypeName("#define UDN_DELTAPOS (UDN_FIRST - 1)")]
    public const uint UDN_DELTAPOS = unchecked((0U - 721U) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROGRESS_CLASSA"]/*' />
    [NativeTypeName("#define PROGRESS_CLASSA \"msctls_progress32\"")]
    public static ReadOnlySpan<byte> PROGRESS_CLASSA => "msctls_progress32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROGRESS_CLASSW"]/*' />
    [NativeTypeName("#define PROGRESS_CLASSW L\"msctls_progress32\"")]
    public const string PROGRESS_CLASSW = "msctls_progress32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROGRESS_CLASS"]/*' />
    [NativeTypeName("#define PROGRESS_CLASS PROGRESS_CLASSW")]
    public const string PROGRESS_CLASS = "msctls_progress32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBS_SMOOTH"]/*' />
    [NativeTypeName("#define PBS_SMOOTH 0x01")]
    public const int PBS_SMOOTH = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBS_VERTICAL"]/*' />
    [NativeTypeName("#define PBS_VERTICAL 0x04")]
    public const int PBS_VERTICAL = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBS_MARQUEE"]/*' />
    [NativeTypeName("#define PBS_MARQUEE 0x08")]
    public const int PBS_MARQUEE = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBS_SMOOTHREVERSE"]/*' />
    [NativeTypeName("#define PBS_SMOOTHREVERSE 0x10")]
    public const int PBS_SMOOTHREVERSE = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBST_NORMAL"]/*' />
    [NativeTypeName("#define PBST_NORMAL 0x0001")]
    public const int PBST_NORMAL = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBST_ERROR"]/*' />
    [NativeTypeName("#define PBST_ERROR 0x0002")]
    public const int PBST_ERROR = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PBST_PAUSED"]/*' />
    [NativeTypeName("#define PBST_PAUSED 0x0003")]
    public const int PBST_PAUSED = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEYF_SHIFT"]/*' />
    [NativeTypeName("#define HOTKEYF_SHIFT 0x01")]
    public const int HOTKEYF_SHIFT = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEYF_CONTROL"]/*' />
    [NativeTypeName("#define HOTKEYF_CONTROL 0x02")]
    public const int HOTKEYF_CONTROL = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEYF_ALT"]/*' />
    [NativeTypeName("#define HOTKEYF_ALT 0x04")]
    public const int HOTKEYF_ALT = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEYF_EXT"]/*' />
    [NativeTypeName("#define HOTKEYF_EXT 0x08")]
    public const int HOTKEYF_EXT = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_NONE"]/*' />
    [NativeTypeName("#define HKCOMB_NONE 0x0001")]
    public const int HKCOMB_NONE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_S"]/*' />
    [NativeTypeName("#define HKCOMB_S 0x0002")]
    public const int HKCOMB_S = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_C"]/*' />
    [NativeTypeName("#define HKCOMB_C 0x0004")]
    public const int HKCOMB_C = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_A"]/*' />
    [NativeTypeName("#define HKCOMB_A 0x0008")]
    public const int HKCOMB_A = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_SC"]/*' />
    [NativeTypeName("#define HKCOMB_SC 0x0010")]
    public const int HKCOMB_SC = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_SA"]/*' />
    [NativeTypeName("#define HKCOMB_SA 0x0020")]
    public const int HKCOMB_SA = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_CA"]/*' />
    [NativeTypeName("#define HKCOMB_CA 0x0040")]
    public const int HKCOMB_CA = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKCOMB_SCA"]/*' />
    [NativeTypeName("#define HKCOMB_SCA 0x0080")]
    public const int HKCOMB_SCA = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKM_SETHOTKEY"]/*' />
    [NativeTypeName("#define HKM_SETHOTKEY (WM_USER+1)")]
    public const int HKM_SETHOTKEY = (0x0400 + 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKM_GETHOTKEY"]/*' />
    [NativeTypeName("#define HKM_GETHOTKEY (WM_USER+2)")]
    public const int HKM_GETHOTKEY = (0x0400 + 2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HKM_SETRULES"]/*' />
    [NativeTypeName("#define HKM_SETRULES (WM_USER+3)")]
    public const int HKM_SETRULES = (0x0400 + 3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEY_CLASSA"]/*' />
    [NativeTypeName("#define HOTKEY_CLASSA \"msctls_hotkey32\"")]
    public static ReadOnlySpan<byte> HOTKEY_CLASSA => "msctls_hotkey32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEY_CLASSW"]/*' />
    [NativeTypeName("#define HOTKEY_CLASSW L\"msctls_hotkey32\"")]
    public const string HOTKEY_CLASSW = "msctls_hotkey32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOTKEY_CLASS"]/*' />
    [NativeTypeName("#define HOTKEY_CLASS HOTKEY_CLASSW")]
    public const string HOTKEY_CLASS = "msctls_hotkey32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INVALID_LINK_INDEX"]/*' />
    [NativeTypeName("#define INVALID_LINK_INDEX (-1)")]
    public const int INVALID_LINK_INDEX = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.L_MAX_URL_LENGTH"]/*' />
    [NativeTypeName("#define L_MAX_URL_LENGTH (2048 + 32 + sizeof(\"://\"))")]
    public const uint L_MAX_URL_LENGTH = (2048 + 32 + 4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_TRANSPARENT"]/*' />
    [NativeTypeName("#define LWS_TRANSPARENT 0x0001")]
    public const int LWS_TRANSPARENT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_IGNORERETURN"]/*' />
    [NativeTypeName("#define LWS_IGNORERETURN 0x0002")]
    public const int LWS_IGNORERETURN = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_NOPREFIX"]/*' />
    [NativeTypeName("#define LWS_NOPREFIX 0x0004")]
    public const int LWS_NOPREFIX = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_USEVISUALSTYLE"]/*' />
    [NativeTypeName("#define LWS_USEVISUALSTYLE 0x0008")]
    public const int LWS_USEVISUALSTYLE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_USECUSTOMTEXT"]/*' />
    [NativeTypeName("#define LWS_USECUSTOMTEXT 0x0010")]
    public const int LWS_USECUSTOMTEXT = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LWS_RIGHT"]/*' />
    [NativeTypeName("#define LWS_RIGHT 0x0020")]
    public const int LWS_RIGHT = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIF_ITEMINDEX"]/*' />
    [NativeTypeName("#define LIF_ITEMINDEX 0x00000001")]
    public const int LIF_ITEMINDEX = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIF_STATE"]/*' />
    [NativeTypeName("#define LIF_STATE 0x00000002")]
    public const int LIF_STATE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIF_ITEMID"]/*' />
    [NativeTypeName("#define LIF_ITEMID 0x00000004")]
    public const int LIF_ITEMID = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIF_URL"]/*' />
    [NativeTypeName("#define LIF_URL 0x00000008")]
    public const int LIF_URL = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIS_FOCUSED"]/*' />
    [NativeTypeName("#define LIS_FOCUSED 0x00000001")]
    public const int LIS_FOCUSED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIS_ENABLED"]/*' />
    [NativeTypeName("#define LIS_ENABLED 0x00000002")]
    public const int LIS_ENABLED = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIS_VISITED"]/*' />
    [NativeTypeName("#define LIS_VISITED 0x00000004")]
    public const int LIS_VISITED = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIS_HOTTRACK"]/*' />
    [NativeTypeName("#define LIS_HOTTRACK 0x00000008")]
    public const int LIS_HOTTRACK = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIS_DEFAULTCOLORS"]/*' />
    [NativeTypeName("#define LIS_DEFAULTCOLORS 0x00000010")]
    public const int LIS_DEFAULTCOLORS = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LM_HITTEST"]/*' />
    [NativeTypeName("#define LM_HITTEST (WM_USER+0x300)")]
    public const int LM_HITTEST = (0x0400 + 0x300);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LM_GETIDEALHEIGHT"]/*' />
    [NativeTypeName("#define LM_GETIDEALHEIGHT (WM_USER+0x301)")]
    public const int LM_GETIDEALHEIGHT = (0x0400 + 0x301);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LM_SETITEM"]/*' />
    [NativeTypeName("#define LM_SETITEM (WM_USER+0x302)")]
    public const int LM_SETITEM = (0x0400 + 0x302);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LM_GETITEM"]/*' />
    [NativeTypeName("#define LM_GETITEM (WM_USER+0x303)")]
    public const int LM_GETITEM = (0x0400 + 0x303);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LM_GETIDEALSIZE"]/*' />
    [NativeTypeName("#define LM_GETIDEALSIZE (LM_GETIDEALHEIGHT)")]
    public const int LM_GETIDEALSIZE = ((0x0400 + 0x301));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSIL_NORMAL"]/*' />
    [NativeTypeName("#define LVSIL_NORMAL 0")]
    public const int LVSIL_NORMAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSIL_SMALL"]/*' />
    [NativeTypeName("#define LVSIL_SMALL 1")]
    public const int LVSIL_SMALL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSIL_STATE"]/*' />
    [NativeTypeName("#define LVSIL_STATE 2")]
    public const int LVSIL_STATE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSIL_GROUPHEADER"]/*' />
    [NativeTypeName("#define LVSIL_GROUPHEADER 3")]
    public const int LVSIL_GROUPHEADER = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_FOCUSED"]/*' />
    [NativeTypeName("#define LVIS_FOCUSED 0x0001")]
    public const int LVIS_FOCUSED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_SELECTED"]/*' />
    [NativeTypeName("#define LVIS_SELECTED 0x0002")]
    public const int LVIS_SELECTED = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_CUT"]/*' />
    [NativeTypeName("#define LVIS_CUT 0x0004")]
    public const int LVIS_CUT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_DROPHILITED"]/*' />
    [NativeTypeName("#define LVIS_DROPHILITED 0x0008")]
    public const int LVIS_DROPHILITED = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_GLOW"]/*' />
    [NativeTypeName("#define LVIS_GLOW 0x0010")]
    public const int LVIS_GLOW = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_ACTIVATING"]/*' />
    [NativeTypeName("#define LVIS_ACTIVATING 0x0020")]
    public const int LVIS_ACTIVATING = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_OVERLAYMASK"]/*' />
    [NativeTypeName("#define LVIS_OVERLAYMASK 0x0F00")]
    public const int LVIS_OVERLAYMASK = 0x0F00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIS_STATEIMAGEMASK"]/*' />
    [NativeTypeName("#define LVIS_STATEIMAGEMASK 0xF000")]
    public const int LVIS_STATEIMAGEMASK = 0xF000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_INDENTCALLBACK"]/*' />
    [NativeTypeName("#define I_INDENTCALLBACK (-1)")]
    public const int I_INDENTCALLBACK = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_GROUPIDCALLBACK"]/*' />
    [NativeTypeName("#define I_GROUPIDCALLBACK (-1)")]
    public const int I_GROUPIDCALLBACK = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_GROUPIDNONE"]/*' />
    [NativeTypeName("#define I_GROUPIDNONE (-2)")]
    public const int I_GROUPIDNONE = (-2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LPSTR_TEXTCALLBACKW"]/*' />
    [NativeTypeName("#define LPSTR_TEXTCALLBACKW ((LPWSTR)-1L)")]
    public static char* LPSTR_TEXTCALLBACKW => unchecked((char*)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LPSTR_TEXTCALLBACKA"]/*' />
    [NativeTypeName("#define LPSTR_TEXTCALLBACKA ((LPSTR)-1L)")]
    public static sbyte* LPSTR_TEXTCALLBACKA => unchecked((sbyte*)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LPSTR_TEXTCALLBACK"]/*' />
    [NativeTypeName("#define LPSTR_TEXTCALLBACK LPSTR_TEXTCALLBACKW")]
    public static char* LPSTR_TEXTCALLBACK => unchecked((char*)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_IMAGECALLBACK"]/*' />
    [NativeTypeName("#define I_IMAGECALLBACK (-1)")]
    public const int I_IMAGECALLBACK = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_IMAGENONE"]/*' />
    [NativeTypeName("#define I_IMAGENONE (-2)")]
    public const int I_IMAGENONE = (-2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_COLUMNSCALLBACK"]/*' />
    [NativeTypeName("#define I_COLUMNSCALLBACK ((UINT)-1)")]
    public const uint I_COLUMNSCALLBACK = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_PARAM"]/*' />
    [NativeTypeName("#define LVFI_PARAM 0x0001")]
    public const int LVFI_PARAM = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_STRING"]/*' />
    [NativeTypeName("#define LVFI_STRING 0x0002")]
    public const int LVFI_STRING = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_SUBSTRING"]/*' />
    [NativeTypeName("#define LVFI_SUBSTRING 0x0004")]
    public const int LVFI_SUBSTRING = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_PARTIAL"]/*' />
    [NativeTypeName("#define LVFI_PARTIAL 0x0008")]
    public const int LVFI_PARTIAL = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_WRAP"]/*' />
    [NativeTypeName("#define LVFI_WRAP 0x0020")]
    public const int LVFI_WRAP = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFI_NEARESTXY"]/*' />
    [NativeTypeName("#define LVFI_NEARESTXY 0x0040")]
    public const int LVFI_NEARESTXY = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIR_BOUNDS"]/*' />
    [NativeTypeName("#define LVIR_BOUNDS 0")]
    public const int LVIR_BOUNDS = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIR_ICON"]/*' />
    [NativeTypeName("#define LVIR_ICON 1")]
    public const int LVIR_ICON = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIR_LABEL"]/*' />
    [NativeTypeName("#define LVIR_LABEL 2")]
    public const int LVIR_LABEL = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIR_SELECTBOUNDS"]/*' />
    [NativeTypeName("#define LVIR_SELECTBOUNDS 3")]
    public const int LVIR_SELECTBOUNDS = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVA_DEFAULT"]/*' />
    [NativeTypeName("#define LVA_DEFAULT 0x0000")]
    public const int LVA_DEFAULT = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVA_ALIGNLEFT"]/*' />
    [NativeTypeName("#define LVA_ALIGNLEFT 0x0001")]
    public const int LVA_ALIGNLEFT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVA_ALIGNTOP"]/*' />
    [NativeTypeName("#define LVA_ALIGNTOP 0x0002")]
    public const int LVA_ALIGNTOP = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVA_SNAPTOGRID"]/*' />
    [NativeTypeName("#define LVA_SNAPTOGRID 0x0005")]
    public const int LVA_SNAPTOGRID = 0x0005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_FMT"]/*' />
    [NativeTypeName("#define LVCF_FMT 0x0001")]
    public const int LVCF_FMT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_WIDTH"]/*' />
    [NativeTypeName("#define LVCF_WIDTH 0x0002")]
    public const int LVCF_WIDTH = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_TEXT"]/*' />
    [NativeTypeName("#define LVCF_TEXT 0x0004")]
    public const int LVCF_TEXT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_SUBITEM"]/*' />
    [NativeTypeName("#define LVCF_SUBITEM 0x0008")]
    public const int LVCF_SUBITEM = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_IMAGE"]/*' />
    [NativeTypeName("#define LVCF_IMAGE 0x0010")]
    public const int LVCF_IMAGE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_ORDER"]/*' />
    [NativeTypeName("#define LVCF_ORDER 0x0020")]
    public const int LVCF_ORDER = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_MINWIDTH"]/*' />
    [NativeTypeName("#define LVCF_MINWIDTH 0x0040")]
    public const int LVCF_MINWIDTH = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_DEFAULTWIDTH"]/*' />
    [NativeTypeName("#define LVCF_DEFAULTWIDTH 0x0080")]
    public const int LVCF_DEFAULTWIDTH = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCF_IDEALWIDTH"]/*' />
    [NativeTypeName("#define LVCF_IDEALWIDTH 0x0100")]
    public const int LVCF_IDEALWIDTH = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSCW_AUTOSIZE"]/*' />
    [NativeTypeName("#define LVSCW_AUTOSIZE -1")]
    public const int LVSCW_AUTOSIZE = -1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSCW_AUTOSIZE_USEHEADER"]/*' />
    [NativeTypeName("#define LVSCW_AUTOSIZE_USEHEADER -2")]
    public const int LVSCW_AUTOSIZE_USEHEADER = -2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSICF_NOINVALIDATEALL"]/*' />
    [NativeTypeName("#define LVSICF_NOINVALIDATEALL 0x00000001")]
    public const int LVSICF_NOINVALIDATEALL = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVSICF_NOSCROLL"]/*' />
    [NativeTypeName("#define LVSICF_NOSCROLL 0x00000002")]
    public const int LVSICF_NOSCROLL = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_MAX_WORKAREAS"]/*' />
    [NativeTypeName("#define LV_MAX_WORKAREAS 16")]
    public const int LV_MAX_WORKAREAS = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_ICON"]/*' />
    [NativeTypeName("#define LV_VIEW_ICON 0x0000")]
    public const int LV_VIEW_ICON = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_DETAILS"]/*' />
    [NativeTypeName("#define LV_VIEW_DETAILS 0x0001")]
    public const int LV_VIEW_DETAILS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_SMALLICON"]/*' />
    [NativeTypeName("#define LV_VIEW_SMALLICON 0x0002")]
    public const int LV_VIEW_SMALLICON = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_LIST"]/*' />
    [NativeTypeName("#define LV_VIEW_LIST 0x0003")]
    public const int LV_VIEW_LIST = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_TILE"]/*' />
    [NativeTypeName("#define LV_VIEW_TILE 0x0004")]
    public const int LV_VIEW_TILE = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LV_VIEW_MAX"]/*' />
    [NativeTypeName("#define LV_VIEW_MAX 0x0004")]
    public const int LV_VIEW_MAX = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_NORMAL"]/*' />
    [NativeTypeName("#define LVGS_NORMAL 0x00000000")]
    public const int LVGS_NORMAL = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_COLLAPSED"]/*' />
    [NativeTypeName("#define LVGS_COLLAPSED 0x00000001")]
    public const int LVGS_COLLAPSED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_HIDDEN"]/*' />
    [NativeTypeName("#define LVGS_HIDDEN 0x00000002")]
    public const int LVGS_HIDDEN = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_NOHEADER"]/*' />
    [NativeTypeName("#define LVGS_NOHEADER 0x00000004")]
    public const int LVGS_NOHEADER = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_COLLAPSIBLE"]/*' />
    [NativeTypeName("#define LVGS_COLLAPSIBLE 0x00000008")]
    public const int LVGS_COLLAPSIBLE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_FOCUSED"]/*' />
    [NativeTypeName("#define LVGS_FOCUSED 0x00000010")]
    public const int LVGS_FOCUSED = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_SELECTED"]/*' />
    [NativeTypeName("#define LVGS_SELECTED 0x00000020")]
    public const int LVGS_SELECTED = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_SUBSETED"]/*' />
    [NativeTypeName("#define LVGS_SUBSETED 0x00000040")]
    public const int LVGS_SUBSETED = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGS_SUBSETLINKFOCUSED"]/*' />
    [NativeTypeName("#define LVGS_SUBSETLINKFOCUSED 0x00000080")]
    public const int LVGS_SUBSETLINKFOCUSED = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_HEADER_LEFT"]/*' />
    [NativeTypeName("#define LVGA_HEADER_LEFT 0x00000001")]
    public const int LVGA_HEADER_LEFT = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_HEADER_CENTER"]/*' />
    [NativeTypeName("#define LVGA_HEADER_CENTER 0x00000002")]
    public const int LVGA_HEADER_CENTER = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_HEADER_RIGHT"]/*' />
    [NativeTypeName("#define LVGA_HEADER_RIGHT 0x00000004")]
    public const int LVGA_HEADER_RIGHT = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_FOOTER_LEFT"]/*' />
    [NativeTypeName("#define LVGA_FOOTER_LEFT 0x00000008")]
    public const int LVGA_FOOTER_LEFT = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_FOOTER_CENTER"]/*' />
    [NativeTypeName("#define LVGA_FOOTER_CENTER 0x00000010")]
    public const int LVGA_FOOTER_CENTER = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGA_FOOTER_RIGHT"]/*' />
    [NativeTypeName("#define LVGA_FOOTER_RIGHT 0x00000020")]
    public const int LVGA_FOOTER_RIGHT = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGGR_GROUP"]/*' />
    [NativeTypeName("#define LVGGR_GROUP 0")]
    public const int LVGGR_GROUP = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGGR_HEADER"]/*' />
    [NativeTypeName("#define LVGGR_HEADER 1")]
    public const int LVGGR_HEADER = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGGR_LABEL"]/*' />
    [NativeTypeName("#define LVGGR_LABEL 2")]
    public const int LVGGR_LABEL = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGGR_SUBSETLINK"]/*' />
    [NativeTypeName("#define LVGGR_SUBSETLINK 3")]
    public const int LVGGR_SUBSETLINK = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGMF_NONE"]/*' />
    [NativeTypeName("#define LVGMF_NONE 0x00000000")]
    public const int LVGMF_NONE = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGMF_BORDERSIZE"]/*' />
    [NativeTypeName("#define LVGMF_BORDERSIZE 0x00000001")]
    public const int LVGMF_BORDERSIZE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGMF_BORDERCOLOR"]/*' />
    [NativeTypeName("#define LVGMF_BORDERCOLOR 0x00000002")]
    public const int LVGMF_BORDERCOLOR = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGMF_TEXTCOLOR"]/*' />
    [NativeTypeName("#define LVGMF_TEXTCOLOR 0x00000004")]
    public const int LVGMF_TEXTCOLOR = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIF_AUTOSIZE"]/*' />
    [NativeTypeName("#define LVTVIF_AUTOSIZE 0x00000000")]
    public const int LVTVIF_AUTOSIZE = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIF_FIXEDWIDTH"]/*' />
    [NativeTypeName("#define LVTVIF_FIXEDWIDTH 0x00000001")]
    public const int LVTVIF_FIXEDWIDTH = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIF_FIXEDHEIGHT"]/*' />
    [NativeTypeName("#define LVTVIF_FIXEDHEIGHT 0x00000002")]
    public const int LVTVIF_FIXEDHEIGHT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIF_FIXEDSIZE"]/*' />
    [NativeTypeName("#define LVTVIF_FIXEDSIZE 0x00000003")]
    public const int LVTVIF_FIXEDSIZE = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIF_EXTENDED"]/*' />
    [NativeTypeName("#define LVTVIF_EXTENDED 0x00000004")]
    public const int LVTVIF_EXTENDED = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIM_TILESIZE"]/*' />
    [NativeTypeName("#define LVTVIM_TILESIZE 0x00000001")]
    public const int LVTVIM_TILESIZE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIM_COLUMNS"]/*' />
    [NativeTypeName("#define LVTVIM_COLUMNS 0x00000002")]
    public const int LVTVIM_COLUMNS = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVTVIM_LABELMARGIN"]/*' />
    [NativeTypeName("#define LVTVIM_LABELMARGIN 0x00000004")]
    public const int LVTVIM_LABELMARGIN = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVIM_AFTER"]/*' />
    [NativeTypeName("#define LVIM_AFTER 0x00000001")]
    public const int LVIM_AFTER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFF_ITEMCOUNT"]/*' />
    [NativeTypeName("#define LVFF_ITEMCOUNT 0x00000001")]
    public const int LVFF_ITEMCOUNT = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFIF_TEXT"]/*' />
    [NativeTypeName("#define LVFIF_TEXT 0x00000001")]
    public const int LVFIF_TEXT = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFIF_STATE"]/*' />
    [NativeTypeName("#define LVFIF_STATE 0x00000002")]
    public const int LVFIF_STATE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVFIS_FOCUSED"]/*' />
    [NativeTypeName("#define LVFIS_FOCUSED 0x0001")]
    public const int LVFIS_FOCUSED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVKF_ALT"]/*' />
    [NativeTypeName("#define LVKF_ALT 0x0001")]
    public const int LVKF_ALT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVKF_CONTROL"]/*' />
    [NativeTypeName("#define LVKF_CONTROL 0x0002")]
    public const int LVKF_CONTROL = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVKF_SHIFT"]/*' />
    [NativeTypeName("#define LVKF_SHIFT 0x0004")]
    public const int LVKF_SHIFT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCDI_ITEM"]/*' />
    [NativeTypeName("#define LVCDI_ITEM 0x00000000")]
    public const int LVCDI_ITEM = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCDI_GROUP"]/*' />
    [NativeTypeName("#define LVCDI_GROUP 0x00000001")]
    public const int LVCDI_GROUP = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCDI_ITEMSLIST"]/*' />
    [NativeTypeName("#define LVCDI_ITEMSLIST 0x00000002")]
    public const int LVCDI_ITEMSLIST = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCDRF_NOSELECT"]/*' />
    [NativeTypeName("#define LVCDRF_NOSELECT 0x00010000")]
    public const int LVCDRF_NOSELECT = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVCDRF_NOGROUPFRAME"]/*' />
    [NativeTypeName("#define LVCDRF_NOGROUPFRAME 0x00020000")]
    public const int LVCDRF_NOGROUPFRAME = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVGIT_UNFOLDED"]/*' />
    [NativeTypeName("#define LVGIT_UNFOLDED 0x0001")]
    public const int LVGIT_UNFOLDED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVNSCH_DEFAULT"]/*' />
    [NativeTypeName("#define LVNSCH_DEFAULT -1")]
    public const int LVNSCH_DEFAULT = -1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVNSCH_ERROR"]/*' />
    [NativeTypeName("#define LVNSCH_ERROR -2")]
    public const int LVNSCH_ERROR = -2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LVNSCH_IGNORE"]/*' />
    [NativeTypeName("#define LVNSCH_IGNORE -3")]
    public const int LVNSCH_IGNORE = -3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EMF_CENTERED"]/*' />
    [NativeTypeName("#define EMF_CENTERED 0x00000001")]
    public const int EMF_CENTERED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_CHILDRENCALLBACK"]/*' />
    [NativeTypeName("#define I_CHILDRENCALLBACK (-1)")]
    public const int I_CHILDRENCALLBACK = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.I_CHILDRENAUTO"]/*' />
    [NativeTypeName("#define I_CHILDRENAUTO (-2)")]
    public const int I_CHILDRENAUTO = (-2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVE_COLLAPSE"]/*' />
    [NativeTypeName("#define TVE_COLLAPSE 0x0001")]
    public const int TVE_COLLAPSE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVE_EXPAND"]/*' />
    [NativeTypeName("#define TVE_EXPAND 0x0002")]
    public const int TVE_EXPAND = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVE_TOGGLE"]/*' />
    [NativeTypeName("#define TVE_TOGGLE 0x0003")]
    public const int TVE_TOGGLE = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVE_EXPANDPARTIAL"]/*' />
    [NativeTypeName("#define TVE_EXPANDPARTIAL 0x4000")]
    public const int TVE_EXPANDPARTIAL = 0x4000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVE_COLLAPSERESET"]/*' />
    [NativeTypeName("#define TVE_COLLAPSERESET 0x8000")]
    public const int TVE_COLLAPSERESET = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVSIL_NORMAL"]/*' />
    [NativeTypeName("#define TVSIL_NORMAL 0")]
    public const int TVSIL_NORMAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVSIL_STATE"]/*' />
    [NativeTypeName("#define TVSIL_STATE 2")]
    public const int TVSIL_STATE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVSI_NOSINGLEEXPAND"]/*' />
    [NativeTypeName("#define TVSI_NOSINGLEEXPAND 0x8000")]
    public const int TVSI_NOSINGLEEXPAND = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVSBF_XBORDER"]/*' />
    [NativeTypeName("#define TVSBF_XBORDER 0x00000001")]
    public const int TVSBF_XBORDER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVSBF_YBORDER"]/*' />
    [NativeTypeName("#define TVSBF_YBORDER 0x00000002")]
    public const int TVSBF_YBORDER = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVC_UNKNOWN"]/*' />
    [NativeTypeName("#define TVC_UNKNOWN 0x0000")]
    public const int TVC_UNKNOWN = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVC_BYMOUSE"]/*' />
    [NativeTypeName("#define TVC_BYMOUSE 0x0001")]
    public const int TVC_BYMOUSE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVC_BYKEYBOARD"]/*' />
    [NativeTypeName("#define TVC_BYKEYBOARD 0x0002")]
    public const int TVC_BYKEYBOARD = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVNRET_DEFAULT"]/*' />
    [NativeTypeName("#define TVNRET_DEFAULT 0")]
    public const int TVNRET_DEFAULT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVNRET_SKIPOLD"]/*' />
    [NativeTypeName("#define TVNRET_SKIPOLD 1")]
    public const int TVNRET_SKIPOLD = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVNRET_SKIPNEW"]/*' />
    [NativeTypeName("#define TVNRET_SKIPNEW 2")]
    public const int TVNRET_SKIPNEW = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TVCDRF_NOIMAGES"]/*' />
    [NativeTypeName("#define TVCDRF_NOIMAGES 0x00010000")]
    public const int TVCDRF_NOIMAGES = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_TEXT"]/*' />
    [NativeTypeName("#define CBEIF_TEXT 0x00000001")]
    public const int CBEIF_TEXT = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_IMAGE"]/*' />
    [NativeTypeName("#define CBEIF_IMAGE 0x00000002")]
    public const int CBEIF_IMAGE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_SELECTEDIMAGE"]/*' />
    [NativeTypeName("#define CBEIF_SELECTEDIMAGE 0x00000004")]
    public const int CBEIF_SELECTEDIMAGE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_OVERLAY"]/*' />
    [NativeTypeName("#define CBEIF_OVERLAY 0x00000008")]
    public const int CBEIF_OVERLAY = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_INDENT"]/*' />
    [NativeTypeName("#define CBEIF_INDENT 0x00000010")]
    public const int CBEIF_INDENT = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_LPARAM"]/*' />
    [NativeTypeName("#define CBEIF_LPARAM 0x00000020")]
    public const int CBEIF_LPARAM = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEIF_DI_SETITEM"]/*' />
    [NativeTypeName("#define CBEIF_DI_SETITEM 0x10000000")]
    public const int CBEIF_DI_SETITEM = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_NOEDITIMAGE"]/*' />
    [NativeTypeName("#define CBES_EX_NOEDITIMAGE 0x00000001")]
    public const int CBES_EX_NOEDITIMAGE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_NOEDITIMAGEINDENT"]/*' />
    [NativeTypeName("#define CBES_EX_NOEDITIMAGEINDENT 0x00000002")]
    public const int CBES_EX_NOEDITIMAGEINDENT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_PATHWORDBREAKPROC"]/*' />
    [NativeTypeName("#define CBES_EX_PATHWORDBREAKPROC 0x00000004")]
    public const int CBES_EX_PATHWORDBREAKPROC = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_NOSIZELIMIT"]/*' />
    [NativeTypeName("#define CBES_EX_NOSIZELIMIT 0x00000008")]
    public const int CBES_EX_NOSIZELIMIT = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_CASESENSITIVE"]/*' />
    [NativeTypeName("#define CBES_EX_CASESENSITIVE 0x00000010")]
    public const int CBES_EX_CASESENSITIVE = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBES_EX_TEXTENDELLIPSIS"]/*' />
    [NativeTypeName("#define CBES_EX_TEXTENDELLIPSIS 0x00000020")]
    public const int CBES_EX_TEXTENDELLIPSIS = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBENF_KILLFOCUS"]/*' />
    [NativeTypeName("#define CBENF_KILLFOCUS 1")]
    public const int CBENF_KILLFOCUS = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBENF_RETURN"]/*' />
    [NativeTypeName("#define CBENF_RETURN 2")]
    public const int CBENF_RETURN = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBENF_ESCAPE"]/*' />
    [NativeTypeName("#define CBENF_ESCAPE 3")]
    public const int CBENF_ESCAPE = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBENF_DROPDOWN"]/*' />
    [NativeTypeName("#define CBENF_DROPDOWN 4")]
    public const int CBENF_DROPDOWN = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CBEMAXSTRLEN"]/*' />
    [NativeTypeName("#define CBEMAXSTRLEN 260")]
    public const int CBEMAXSTRLEN = 260;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIF_TEXT"]/*' />
    [NativeTypeName("#define TCIF_TEXT 0x0001")]
    public const int TCIF_TEXT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIF_IMAGE"]/*' />
    [NativeTypeName("#define TCIF_IMAGE 0x0002")]
    public const int TCIF_IMAGE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIF_RTLREADING"]/*' />
    [NativeTypeName("#define TCIF_RTLREADING 0x0004")]
    public const int TCIF_RTLREADING = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIF_PARAM"]/*' />
    [NativeTypeName("#define TCIF_PARAM 0x0008")]
    public const int TCIF_PARAM = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIF_STATE"]/*' />
    [NativeTypeName("#define TCIF_STATE 0x0010")]
    public const int TCIF_STATE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIS_BUTTONPRESSED"]/*' />
    [NativeTypeName("#define TCIS_BUTTONPRESSED 0x0001")]
    public const int TCIS_BUTTONPRESSED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCIS_HIGHLIGHTED"]/*' />
    [NativeTypeName("#define TCIS_HIGHLIGHTED 0x0002")]
    public const int TCIS_HIGHLIGHTED = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCHT_NOWHERE"]/*' />
    [NativeTypeName("#define TCHT_NOWHERE 0x0001")]
    public const int TCHT_NOWHERE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCHT_ONITEMICON"]/*' />
    [NativeTypeName("#define TCHT_ONITEMICON 0x0002")]
    public const int TCHT_ONITEMICON = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCHT_ONITEMLABEL"]/*' />
    [NativeTypeName("#define TCHT_ONITEMLABEL 0x0004")]
    public const int TCHT_ONITEMLABEL = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCHT_ONITEM"]/*' />
    [NativeTypeName("#define TCHT_ONITEM (TCHT_ONITEMICON | TCHT_ONITEMLABEL)")]
    public const int TCHT_ONITEM = (0x0002 | 0x0004);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_KEYDOWN"]/*' />
    [NativeTypeName("#define TCN_KEYDOWN (TCN_FIRST - 0)")]
    public const uint TCN_KEYDOWN = unchecked((0U - 550U) - 0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_SELCHANGE"]/*' />
    [NativeTypeName("#define TCN_SELCHANGE (TCN_FIRST - 1)")]
    public const uint TCN_SELCHANGE = unchecked((0U - 550U) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_SELCHANGING"]/*' />
    [NativeTypeName("#define TCN_SELCHANGING (TCN_FIRST - 2)")]
    public const uint TCN_SELCHANGING = unchecked((0U - 550U) - 2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_GETOBJECT"]/*' />
    [NativeTypeName("#define TCN_GETOBJECT (TCN_FIRST - 3)")]
    public const uint TCN_GETOBJECT = unchecked((0U - 550U) - 3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCN_FOCUSCHANGE"]/*' />
    [NativeTypeName("#define TCN_FOCUSCHANGE (TCN_FIRST - 4)")]
    public const uint TCN_FOCUSCHANGE = unchecked((0U - 550U) - 4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANIMATE_CLASSW"]/*' />
    [NativeTypeName("#define ANIMATE_CLASSW L\"SysAnimate32\"")]
    public const string ANIMATE_CLASSW = "SysAnimate32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANIMATE_CLASSA"]/*' />
    [NativeTypeName("#define ANIMATE_CLASSA \"SysAnimate32\"")]
    public static ReadOnlySpan<byte> ANIMATE_CLASSA => "SysAnimate32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANIMATE_CLASS"]/*' />
    [NativeTypeName("#define ANIMATE_CLASS ANIMATE_CLASSW")]
    public const string ANIMATE_CLASS = "SysAnimate32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACS_CENTER"]/*' />
    [NativeTypeName("#define ACS_CENTER 0x0001")]
    public const int ACS_CENTER = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACS_TRANSPARENT"]/*' />
    [NativeTypeName("#define ACS_TRANSPARENT 0x0002")]
    public const int ACS_TRANSPARENT = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACS_AUTOPLAY"]/*' />
    [NativeTypeName("#define ACS_AUTOPLAY 0x0004")]
    public const int ACS_AUTOPLAY = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACS_TIMER"]/*' />
    [NativeTypeName("#define ACS_TIMER 0x0008")]
    public const int ACS_TIMER = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACN_START"]/*' />
    [NativeTypeName("#define ACN_START 1")]
    public const int ACN_START = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACN_STOP"]/*' />
    [NativeTypeName("#define ACN_STOP 2")]
    public const int ACN_STOP = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MONTHCAL_CLASSW"]/*' />
    [NativeTypeName("#define MONTHCAL_CLASSW L\"SysMonthCal32\"")]
    public const string MONTHCAL_CLASSW = "SysMonthCal32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MONTHCAL_CLASSA"]/*' />
    [NativeTypeName("#define MONTHCAL_CLASSA \"SysMonthCal32\"")]
    public static ReadOnlySpan<byte> MONTHCAL_CLASSA => "SysMonthCal32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MONTHCAL_CLASS"]/*' />
    [NativeTypeName("#define MONTHCAL_CLASS MONTHCAL_CLASSW")]
    public const string MONTHCAL_CLASS = "SysMonthCal32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_BACKGROUND"]/*' />
    [NativeTypeName("#define MCSC_BACKGROUND 0")]
    public const int MCSC_BACKGROUND = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_TEXT"]/*' />
    [NativeTypeName("#define MCSC_TEXT 1")]
    public const int MCSC_TEXT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_TITLEBK"]/*' />
    [NativeTypeName("#define MCSC_TITLEBK 2")]
    public const int MCSC_TITLEBK = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_TITLETEXT"]/*' />
    [NativeTypeName("#define MCSC_TITLETEXT 3")]
    public const int MCSC_TITLETEXT = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_MONTHBK"]/*' />
    [NativeTypeName("#define MCSC_MONTHBK 4")]
    public const int MCSC_MONTHBK = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCSC_TRAILINGTEXT"]/*' />
    [NativeTypeName("#define MCSC_TRAILINGTEXT 5")]
    public const int MCSC_TRAILINGTEXT = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCMV_MONTH"]/*' />
    [NativeTypeName("#define MCMV_MONTH 0")]
    public const int MCMV_MONTH = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCMV_YEAR"]/*' />
    [NativeTypeName("#define MCMV_YEAR 1")]
    public const int MCMV_YEAR = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCMV_DECADE"]/*' />
    [NativeTypeName("#define MCMV_DECADE 2")]
    public const int MCMV_DECADE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCMV_CENTURY"]/*' />
    [NativeTypeName("#define MCMV_CENTURY 3")]
    public const int MCMV_CENTURY = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCMV_MAX"]/*' />
    [NativeTypeName("#define MCMV_MAX MCMV_CENTURY")]
    public const int MCMV_MAX = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDARCONTROL"]/*' />
    [NativeTypeName("#define MCGIP_CALENDARCONTROL 0")]
    public const int MCGIP_CALENDARCONTROL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_NEXT"]/*' />
    [NativeTypeName("#define MCGIP_NEXT 1")]
    public const int MCGIP_NEXT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_PREV"]/*' />
    [NativeTypeName("#define MCGIP_PREV 2")]
    public const int MCGIP_PREV = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_FOOTER"]/*' />
    [NativeTypeName("#define MCGIP_FOOTER 3")]
    public const int MCGIP_FOOTER = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDAR"]/*' />
    [NativeTypeName("#define MCGIP_CALENDAR 4")]
    public const int MCGIP_CALENDAR = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDARHEADER"]/*' />
    [NativeTypeName("#define MCGIP_CALENDARHEADER 5")]
    public const int MCGIP_CALENDARHEADER = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDARBODY"]/*' />
    [NativeTypeName("#define MCGIP_CALENDARBODY 6")]
    public const int MCGIP_CALENDARBODY = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDARROW"]/*' />
    [NativeTypeName("#define MCGIP_CALENDARROW 7")]
    public const int MCGIP_CALENDARROW = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIP_CALENDARCELL"]/*' />
    [NativeTypeName("#define MCGIP_CALENDARCELL 8")]
    public const int MCGIP_CALENDARCELL = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIF_DATE"]/*' />
    [NativeTypeName("#define MCGIF_DATE 0x00000001")]
    public const int MCGIF_DATE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIF_RECT"]/*' />
    [NativeTypeName("#define MCGIF_RECT 0x00000002")]
    public const int MCGIF_RECT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCGIF_NAME"]/*' />
    [NativeTypeName("#define MCGIF_NAME 0x00000004")]
    public const int MCGIF_NAME = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_SELCHANGE"]/*' />
    [NativeTypeName("#define MCN_SELCHANGE (MCN_FIRST - 3)")]
    public const uint MCN_SELCHANGE = unchecked((0U - 746U) - 3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_GETDAYSTATE"]/*' />
    [NativeTypeName("#define MCN_GETDAYSTATE (MCN_FIRST - 1)")]
    public const uint MCN_GETDAYSTATE = unchecked((0U - 746U) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_SELECT"]/*' />
    [NativeTypeName("#define MCN_SELECT (MCN_FIRST)")]
    public const uint MCN_SELECT = unchecked((0U - 746U));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCN_VIEWCHANGE"]/*' />
    [NativeTypeName("#define MCN_VIEWCHANGE (MCN_FIRST - 4)")]
    public const uint MCN_VIEWCHANGE = unchecked((0U - 746U) - 4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_DAYSTATE"]/*' />
    [NativeTypeName("#define MCS_DAYSTATE 0x0001")]
    public const int MCS_DAYSTATE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_MULTISELECT"]/*' />
    [NativeTypeName("#define MCS_MULTISELECT 0x0002")]
    public const int MCS_MULTISELECT = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_WEEKNUMBERS"]/*' />
    [NativeTypeName("#define MCS_WEEKNUMBERS 0x0004")]
    public const int MCS_WEEKNUMBERS = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_NOTODAYCIRCLE"]/*' />
    [NativeTypeName("#define MCS_NOTODAYCIRCLE 0x0008")]
    public const int MCS_NOTODAYCIRCLE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_NOTODAY"]/*' />
    [NativeTypeName("#define MCS_NOTODAY 0x0010")]
    public const int MCS_NOTODAY = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_NOTRAILINGDATES"]/*' />
    [NativeTypeName("#define MCS_NOTRAILINGDATES 0x0040")]
    public const int MCS_NOTRAILINGDATES = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_SHORTDAYSOFWEEK"]/*' />
    [NativeTypeName("#define MCS_SHORTDAYSOFWEEK 0x0080")]
    public const int MCS_SHORTDAYSOFWEEK = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCS_NOSELCHANGEONNAV"]/*' />
    [NativeTypeName("#define MCS_NOSELCHANGEONNAV 0x0100")]
    public const int MCS_NOSELCHANGEONNAV = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GMR_VISIBLE"]/*' />
    [NativeTypeName("#define GMR_VISIBLE 0")]
    public const int GMR_VISIBLE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GMR_DAYSTATE"]/*' />
    [NativeTypeName("#define GMR_DAYSTATE 1")]
    public const int GMR_DAYSTATE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATETIMEPICK_CLASSW"]/*' />
    [NativeTypeName("#define DATETIMEPICK_CLASSW L\"SysDateTimePick32\"")]
    public const string DATETIMEPICK_CLASSW = "SysDateTimePick32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATETIMEPICK_CLASSA"]/*' />
    [NativeTypeName("#define DATETIMEPICK_CLASSA \"SysDateTimePick32\"")]
    public static ReadOnlySpan<byte> DATETIMEPICK_CLASSA => "SysDateTimePick32"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DATETIMEPICK_CLASS"]/*' />
    [NativeTypeName("#define DATETIMEPICK_CLASS DATETIMEPICK_CLASSW")]
    public const string DATETIMEPICK_CLASS = "SysDateTimePick32";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_UPDOWN"]/*' />
    [NativeTypeName("#define DTS_UPDOWN 0x0001")]
    public const int DTS_UPDOWN = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_SHOWNONE"]/*' />
    [NativeTypeName("#define DTS_SHOWNONE 0x0002")]
    public const int DTS_SHOWNONE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_SHORTDATEFORMAT"]/*' />
    [NativeTypeName("#define DTS_SHORTDATEFORMAT 0x0000")]
    public const int DTS_SHORTDATEFORMAT = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_LONGDATEFORMAT"]/*' />
    [NativeTypeName("#define DTS_LONGDATEFORMAT 0x0004")]
    public const int DTS_LONGDATEFORMAT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_SHORTDATECENTURYFORMAT"]/*' />
    [NativeTypeName("#define DTS_SHORTDATECENTURYFORMAT 0x000C")]
    public const int DTS_SHORTDATECENTURYFORMAT = 0x000C;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_TIMEFORMAT"]/*' />
    [NativeTypeName("#define DTS_TIMEFORMAT 0x0009")]
    public const int DTS_TIMEFORMAT = 0x0009;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_APPCANPARSE"]/*' />
    [NativeTypeName("#define DTS_APPCANPARSE 0x0010")]
    public const int DTS_APPCANPARSE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DTS_RIGHTALIGN"]/*' />
    [NativeTypeName("#define DTS_RIGHTALIGN 0x0020")]
    public const int DTS_RIGHTALIGN = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GDTR_MIN"]/*' />
    [NativeTypeName("#define GDTR_MIN 0x0001")]
    public const int GDTR_MIN = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GDTR_MAX"]/*' />
    [NativeTypeName("#define GDTR_MAX 0x0002")]
    public const int GDTR_MAX = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GDT_ERROR"]/*' />
    [NativeTypeName("#define GDT_ERROR -1")]
    public const int GDT_ERROR = -1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GDT_VALID"]/*' />
    [NativeTypeName("#define GDT_VALID 0")]
    public const int GDT_VALID = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GDT_NONE"]/*' />
    [NativeTypeName("#define GDT_NONE 1")]
    public const int GDT_NONE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_CLEARADDRESS"]/*' />
    [NativeTypeName("#define IPM_CLEARADDRESS (WM_USER+100)")]
    public const int IPM_CLEARADDRESS = (0x0400 + 100);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_SETADDRESS"]/*' />
    [NativeTypeName("#define IPM_SETADDRESS (WM_USER+101)")]
    public const int IPM_SETADDRESS = (0x0400 + 101);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_GETADDRESS"]/*' />
    [NativeTypeName("#define IPM_GETADDRESS (WM_USER+102)")]
    public const int IPM_GETADDRESS = (0x0400 + 102);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_SETRANGE"]/*' />
    [NativeTypeName("#define IPM_SETRANGE (WM_USER+103)")]
    public const int IPM_SETRANGE = (0x0400 + 103);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_SETFOCUS"]/*' />
    [NativeTypeName("#define IPM_SETFOCUS (WM_USER+104)")]
    public const int IPM_SETFOCUS = (0x0400 + 104);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPM_ISBLANK"]/*' />
    [NativeTypeName("#define IPM_ISBLANK (WM_USER+105)")]
    public const int IPM_ISBLANK = (0x0400 + 105);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IPN_FIELDCHANGED"]/*' />
    [NativeTypeName("#define IPN_FIELDCHANGED (IPN_FIRST - 0)")]
    public const uint IPN_FIELDCHANGED = unchecked((0U - 860U) - 0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGS_VERT"]/*' />
    [NativeTypeName("#define PGS_VERT 0x00000000")]
    public const int PGS_VERT = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGS_HORZ"]/*' />
    [NativeTypeName("#define PGS_HORZ 0x00000001")]
    public const int PGS_HORZ = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGS_AUTOSCROLL"]/*' />
    [NativeTypeName("#define PGS_AUTOSCROLL 0x00000002")]
    public const int PGS_AUTOSCROLL = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGS_DRAGNDROP"]/*' />
    [NativeTypeName("#define PGS_DRAGNDROP 0x00000004")]
    public const int PGS_DRAGNDROP = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGB_TOPORLEFT"]/*' />
    [NativeTypeName("#define PGB_TOPORLEFT 0")]
    public const int PGB_TOPORLEFT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGB_BOTTOMORRIGHT"]/*' />
    [NativeTypeName("#define PGB_BOTTOMORRIGHT 1")]
    public const int PGB_BOTTOMORRIGHT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGN_SCROLL"]/*' />
    [NativeTypeName("#define PGN_SCROLL (PGN_FIRST-1)")]
    public const uint PGN_SCROLL = unchecked((0U - 900U) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGK_SHIFT"]/*' />
    [NativeTypeName("#define PGK_SHIFT 1")]
    public const int PGK_SHIFT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGK_CONTROL"]/*' />
    [NativeTypeName("#define PGK_CONTROL 2")]
    public const int PGK_CONTROL = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGK_MENU"]/*' />
    [NativeTypeName("#define PGK_MENU 4")]
    public const int PGK_MENU = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGN_CALCSIZE"]/*' />
    [NativeTypeName("#define PGN_CALCSIZE (PGN_FIRST-2)")]
    public const uint PGN_CALCSIZE = unchecked((0U - 900U) - 2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PGN_HOTITEMCHANGE"]/*' />
    [NativeTypeName("#define PGN_HOTITEMCHANGE (PGN_FIRST-3)")]
    public const uint PGN_HOTITEMCHANGE = unchecked((0U - 900U) - 3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_EDIT"]/*' />
    [NativeTypeName("#define NFS_EDIT 0x0001")]
    public const int NFS_EDIT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_STATIC"]/*' />
    [NativeTypeName("#define NFS_STATIC 0x0002")]
    public const int NFS_STATIC = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_LISTCOMBO"]/*' />
    [NativeTypeName("#define NFS_LISTCOMBO 0x0004")]
    public const int NFS_LISTCOMBO = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_BUTTON"]/*' />
    [NativeTypeName("#define NFS_BUTTON 0x0008")]
    public const int NFS_BUTTON = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_ALL"]/*' />
    [NativeTypeName("#define NFS_ALL 0x0010")]
    public const int NFS_ALL = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NFS_USEFONTASSOC"]/*' />
    [NativeTypeName("#define NFS_USEFONTASSOC 0x0020")]
    public const int NFS_USEFONTASSOC = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUTTON_IMAGELIST_ALIGN_LEFT"]/*' />
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_LEFT 0")]
    public const int BUTTON_IMAGELIST_ALIGN_LEFT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUTTON_IMAGELIST_ALIGN_RIGHT"]/*' />
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_RIGHT 1")]
    public const int BUTTON_IMAGELIST_ALIGN_RIGHT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUTTON_IMAGELIST_ALIGN_TOP"]/*' />
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_TOP 2")]
    public const int BUTTON_IMAGELIST_ALIGN_TOP = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUTTON_IMAGELIST_ALIGN_BOTTOM"]/*' />
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_BOTTOM 3")]
    public const int BUTTON_IMAGELIST_ALIGN_BOTTOM = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BUTTON_IMAGELIST_ALIGN_CENTER"]/*' />
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_CENTER 4")]
    public const int BUTTON_IMAGELIST_ALIGN_CENTER = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCN_HOTITEMCHANGE"]/*' />
    [NativeTypeName("#define BCN_HOTITEMCHANGE (BCN_FIRST + 0x0001)")]
    public const uint BCN_HOTITEMCHANGE = unchecked((0U - 1250U) + 0x0001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BST_HOT"]/*' />
    [NativeTypeName("#define BST_HOT 0x0200")]
    public const int BST_HOT = 0x0200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BST_DROPDOWNPUSHED"]/*' />
    [NativeTypeName("#define BST_DROPDOWNPUSHED 0x0400")]
    public const int BST_DROPDOWNPUSHED = 0x0400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSIF_GLYPH"]/*' />
    [NativeTypeName("#define BCSIF_GLYPH 0x0001")]
    public const int BCSIF_GLYPH = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSIF_IMAGE"]/*' />
    [NativeTypeName("#define BCSIF_IMAGE 0x0002")]
    public const int BCSIF_IMAGE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSIF_STYLE"]/*' />
    [NativeTypeName("#define BCSIF_STYLE 0x0004")]
    public const int BCSIF_STYLE = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSIF_SIZE"]/*' />
    [NativeTypeName("#define BCSIF_SIZE 0x0008")]
    public const int BCSIF_SIZE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSS_NOSPLIT"]/*' />
    [NativeTypeName("#define BCSS_NOSPLIT 0x0001")]
    public const int BCSS_NOSPLIT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSS_STRETCH"]/*' />
    [NativeTypeName("#define BCSS_STRETCH 0x0002")]
    public const int BCSS_STRETCH = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSS_ALIGNLEFT"]/*' />
    [NativeTypeName("#define BCSS_ALIGNLEFT 0x0004")]
    public const int BCSS_ALIGNLEFT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCSS_IMAGE"]/*' />
    [NativeTypeName("#define BCSS_IMAGE 0x0008")]
    public const int BCSS_IMAGE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BCN_DROPDOWN"]/*' />
    [NativeTypeName("#define BCN_DROPDOWN (BCN_FIRST + 0x0002)")]
    public const uint BCN_DROPDOWN = unchecked((0U - 1250U) + 0x0002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FSB_FLAT_MODE"]/*' />
    [NativeTypeName("#define FSB_FLAT_MODE 2")]
    public const int FSB_FLAT_MODE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FSB_ENCARTA_MODE"]/*' />
    [NativeTypeName("#define FSB_ENCARTA_MODE 1")]
    public const int FSB_ENCARTA_MODE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FSB_REGULAR_MODE"]/*' />
    [NativeTypeName("#define FSB_REGULAR_MODE 0")]
    public const int FSB_REGULAR_MODE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollPropPtr"]/*' />
    [NativeTypeName("#define FlatSB_SetScrollPropPtr FlatSB_SetScrollProp")]
    public static delegate*<HWND, uint, nint, BOOL, BOOL> FlatSB_SetScrollPropPtr => &FlatSB_SetScrollProp;
}
