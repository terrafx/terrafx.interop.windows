// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void InitCommonControls();

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL InitCommonControlsEx([NativeTypeName("const INITCOMMONCONTROLSEX *")] INITCOMMONCONTROLSEX* picce);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_Create(int cx, int cy, [NativeTypeName("UINT")] uint flags, int cInitial, int cGrow);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Destroy([NativeTypeName("HIMAGELIST")] IntPtr himl);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int ImageList_GetImageCount([NativeTypeName("HIMAGELIST")] IntPtr himl);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_SetImageCount([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("UINT")] uint uNewCount);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int ImageList_Add([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int ImageList_ReplaceIcon([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, [NativeTypeName("HICON")] IntPtr hicon);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint ImageList_SetBkColor([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("COLORREF")] uint clrBk);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint ImageList_GetBkColor([NativeTypeName("HIMAGELIST")] IntPtr himl);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_SetOverlayImage([NativeTypeName("HIMAGELIST")] IntPtr himl, int iImage, int iOverlay);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Draw([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, [NativeTypeName("HDC")] IntPtr hdcDst, int x, int y, [NativeTypeName("UINT")] uint fStyle);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Replace([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int ImageList_AddMasked([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("COLORREF")] uint crMask);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DrawEx([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, [NativeTypeName("HDC")] IntPtr hdcDst, int x, int y, int dx, int dy, [NativeTypeName("COLORREF")] uint rgbBk, [NativeTypeName("COLORREF")] uint rgbFg, [NativeTypeName("UINT")] uint fStyle);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DrawIndirect(IMAGELISTDRAWPARAMS* pimldp);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Remove([NativeTypeName("HIMAGELIST")] IntPtr himl, int i);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern IntPtr ImageList_GetIcon([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, [NativeTypeName("UINT")] uint flags);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_LoadImageA([NativeTypeName("HINSTANCE")] IntPtr hi, [NativeTypeName("LPCSTR")] sbyte* lpbmp, int cx, int cGrow, [NativeTypeName("COLORREF")] uint crMask, [NativeTypeName("UINT")] uint uType, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_LoadImageW([NativeTypeName("HINSTANCE")] IntPtr hi, [NativeTypeName("LPCWSTR")] ushort* lpbmp, int cx, int cGrow, [NativeTypeName("COLORREF")] uint crMask, [NativeTypeName("UINT")] uint uType, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Copy([NativeTypeName("HIMAGELIST")] IntPtr himlDst, int iDst, [NativeTypeName("HIMAGELIST")] IntPtr himlSrc, int iSrc, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_BeginDrag([NativeTypeName("HIMAGELIST")] IntPtr himlTrack, int iTrack, int dxHotspot, int dyHotspot);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void ImageList_EndDrag();

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DragEnter([NativeTypeName("HWND")] IntPtr hwndLock, int x, int y);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DragLeave([NativeTypeName("HWND")] IntPtr hwndLock);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DragMove(int x, int y);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_SetDragCursorImage([NativeTypeName("HIMAGELIST")] IntPtr himlDrag, int iDrag, int dxHotspot, int dyHotspot);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_DragShowNolock(BOOL fShow);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_GetDragImage(POINT* ppt, POINT* pptHotspot);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_Read([NativeTypeName("struct IStream *")] IStream* pstm);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_Write([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("struct IStream *")] IStream* pstm);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ImageList_ReadEx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppv);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ImageList_WriteEx([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_GetIconSize([NativeTypeName("HIMAGELIST")] IntPtr himl, int* cx, int* cy);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_SetIconSize([NativeTypeName("HIMAGELIST")] IntPtr himl, int cx, int cy);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ImageList_GetImageInfo([NativeTypeName("HIMAGELIST")] IntPtr himl, int i, IMAGEINFO* pImageInfo);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_Merge([NativeTypeName("HIMAGELIST")] IntPtr himl1, int i1, [NativeTypeName("HIMAGELIST")] IntPtr himl2, int i2, int dx, int dy);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HIMAGELIST")]
        public static extern IntPtr ImageList_Duplicate([NativeTypeName("HIMAGELIST")] IntPtr himl);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HIMAGELIST_QueryInterface([NativeTypeName("HIMAGELIST")] IntPtr himl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [return: NativeTypeName("HIMAGELIST")]
        public static IntPtr IImageListToHIMAGELIST([NativeTypeName("struct IImageList *")] IImageList* himl)
        {
            return (nint)(himl);
        }

        [DllImport("comctl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateToolbarEx([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint ws, [NativeTypeName("UINT")] uint wID, int nBitmaps, [NativeTypeName("HINSTANCE")] IntPtr hBMInst, [NativeTypeName("UINT_PTR")] nuint wBMID, [NativeTypeName("LPCTBBUTTON")] void* lpButtons, int iNumButtons, int dxButton, int dyButton, int dxBitmap, int dyBitmap, [NativeTypeName("UINT")] uint uStructSize);

        [DllImport("comctl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern IntPtr CreateMappedBitmap([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("INT_PTR")] nint idBitmap, [NativeTypeName("UINT")] uint wFlags, [NativeTypeName("LPCOLORMAP")] COLORMAP* lpColorMap, int iNumMaps);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void DrawStatusTextA([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* pszText, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void DrawStatusTextW([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("comctl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateStatusWindowA([NativeTypeName("LONG")] int style, [NativeTypeName("LPCSTR")] sbyte* lpszText, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wID);

        [DllImport("comctl32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateStatusWindowW([NativeTypeName("LONG")] int style, [NativeTypeName("LPCWSTR")] ushort* lpszText, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("UINT")] uint wID);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void MenuHelp([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("HMENU")] IntPtr hMainMenu, [NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("HWND")] IntPtr hwndStatus, [NativeTypeName("UINT *")] uint* lpwIDs);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL ShowHideMenuCtl([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT_PTR")] nuint uFlags, [NativeTypeName("LPINT")] int* lpInfo);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void GetEffectiveClientRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("const INT *")] int* lpInfo);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL MakeDragList([NativeTypeName("HWND")] IntPtr hLB);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void DrawInsert([NativeTypeName("HWND")] IntPtr handParent, [NativeTypeName("HWND")] IntPtr hLB, int nItem);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int LBItemFromPt([NativeTypeName("HWND")] IntPtr hLB, POINT pt, BOOL bAutoScroll);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateUpDownControl([NativeTypeName("DWORD")] uint dwStyle, int x, int y, int cx, int cy, [NativeTypeName("HWND")] IntPtr hParent, int nID, [NativeTypeName("HINSTANCE")] IntPtr hInst, [NativeTypeName("HWND")] IntPtr hBuddy, int nUpper, int nLower, int nPos);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TaskDialogIndirect([NativeTypeName("const TASKDIALOGCONFIG *")] TASKDIALOGCONFIG* pTaskConfig, int* pnButton, int* pnRadioButton, BOOL* pfVerificationFlagChecked);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TaskDialog([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("PCWSTR")] ushort* pszWindowTitle, [NativeTypeName("PCWSTR")] ushort* pszMainInstruction, [NativeTypeName("PCWSTR")] ushort* pszContent, [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")] int dwCommonButtons, [NativeTypeName("PCWSTR")] ushort* pszIcon, int* pnButton);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern void InitMUILanguage([NativeTypeName("LANGID")] ushort uiLang);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("LANGID")]
        public static extern ushort GetMUILanguage();

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL _TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_EnableScrollBar([NativeTypeName("HWND")] IntPtr param0, int param1, [NativeTypeName("UINT")] uint param2);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_ShowScrollBar([NativeTypeName("HWND")] IntPtr param0, int code, BOOL param2);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_GetScrollRange([NativeTypeName("HWND")] IntPtr param0, int code, [NativeTypeName("LPINT")] int* param2, [NativeTypeName("LPINT")] int* param3);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_GetScrollInfo([NativeTypeName("HWND")] IntPtr param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* param2);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int FlatSB_GetScrollPos([NativeTypeName("HWND")] IntPtr param0, int code);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_GetScrollProp([NativeTypeName("HWND")] IntPtr param0, int propIndex, [NativeTypeName("LPINT")] int* param2);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int FlatSB_SetScrollPos([NativeTypeName("HWND")] IntPtr param0, int code, int pos, BOOL fRedraw);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int FlatSB_SetScrollInfo([NativeTypeName("HWND")] IntPtr param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* psi, BOOL fRedraw);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int FlatSB_SetScrollRange([NativeTypeName("HWND")] IntPtr param0, int code, int min, int max, BOOL fRedraw);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL FlatSB_SetScrollProp([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("UINT")] uint index, [NativeTypeName("INT_PTR")] nint newValue, BOOL param3);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL InitializeFlatSB([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UninitializeFlatSB([NativeTypeName("HWND")] IntPtr param0);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL SetWindowSubclass([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nuint, nuint, nint> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR")] nuint dwRefData);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL GetWindowSubclass([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nuint, nuint, nint> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR *")] nuint* pdwRefData);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL RemoveWindowSubclass([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nuint, nuint, nint> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefSubclassProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int LoadIconMetric([NativeTypeName("HINSTANCE")] IntPtr hinst, [NativeTypeName("PCWSTR")] ushort* pszName, int lims, [NativeTypeName("HICON *")] IntPtr* phico);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int LoadIconWithScaleDown([NativeTypeName("HINSTANCE")] IntPtr hinst, [NativeTypeName("PCWSTR")] ushort* pszName, int cx, int cy, [NativeTypeName("HICON *")] IntPtr* phico);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern int DrawShadowText([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint cch, RECT* prc, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("COLORREF")] uint crText, [NativeTypeName("COLORREF")] uint crShadow, int ixOffset, int iyOffset);

        [NativeTypeName("#define ICC_LISTVIEW_CLASSES 0x00000001")]
        public const int ICC_LISTVIEW_CLASSES = 0x00000001;

        [NativeTypeName("#define ICC_TREEVIEW_CLASSES 0x00000002")]
        public const int ICC_TREEVIEW_CLASSES = 0x00000002;

        [NativeTypeName("#define ICC_BAR_CLASSES 0x00000004")]
        public const int ICC_BAR_CLASSES = 0x00000004;

        [NativeTypeName("#define ICC_TAB_CLASSES 0x00000008")]
        public const int ICC_TAB_CLASSES = 0x00000008;

        [NativeTypeName("#define ICC_UPDOWN_CLASS 0x00000010")]
        public const int ICC_UPDOWN_CLASS = 0x00000010;

        [NativeTypeName("#define ICC_PROGRESS_CLASS 0x00000020")]
        public const int ICC_PROGRESS_CLASS = 0x00000020;

        [NativeTypeName("#define ICC_HOTKEY_CLASS 0x00000040")]
        public const int ICC_HOTKEY_CLASS = 0x00000040;

        [NativeTypeName("#define ICC_ANIMATE_CLASS 0x00000080")]
        public const int ICC_ANIMATE_CLASS = 0x00000080;

        [NativeTypeName("#define ICC_WIN95_CLASSES 0x000000FF")]
        public const int ICC_WIN95_CLASSES = 0x000000FF;

        [NativeTypeName("#define ICC_DATE_CLASSES 0x00000100")]
        public const int ICC_DATE_CLASSES = 0x00000100;

        [NativeTypeName("#define ICC_USEREX_CLASSES 0x00000200")]
        public const int ICC_USEREX_CLASSES = 0x00000200;

        [NativeTypeName("#define ICC_COOL_CLASSES 0x00000400")]
        public const int ICC_COOL_CLASSES = 0x00000400;

        [NativeTypeName("#define ICC_INTERNET_CLASSES 0x00000800")]
        public const int ICC_INTERNET_CLASSES = 0x00000800;

        [NativeTypeName("#define ICC_PAGESCROLLER_CLASS 0x00001000")]
        public const int ICC_PAGESCROLLER_CLASS = 0x00001000;

        [NativeTypeName("#define ICC_NATIVEFNTCTL_CLASS 0x00002000")]
        public const int ICC_NATIVEFNTCTL_CLASS = 0x00002000;

        [NativeTypeName("#define ICC_STANDARD_CLASSES 0x00004000")]
        public const int ICC_STANDARD_CLASSES = 0x00004000;

        [NativeTypeName("#define ICC_LINK_CLASS 0x00008000")]
        public const int ICC_LINK_CLASS = 0x00008000;

        [NativeTypeName("#define ODT_HEADER 100")]
        public const int ODT_HEADER = 100;

        [NativeTypeName("#define ODT_TAB 101")]
        public const int ODT_TAB = 101;

        [NativeTypeName("#define ODT_LISTVIEW 102")]
        public const int ODT_LISTVIEW = 102;

        [NativeTypeName("#define LVM_FIRST 0x1000")]
        public const int LVM_FIRST = 0x1000;

        [NativeTypeName("#define TV_FIRST 0x1100")]
        public const int TV_FIRST = 0x1100;

        [NativeTypeName("#define HDM_FIRST 0x1200")]
        public const int HDM_FIRST = 0x1200;

        [NativeTypeName("#define TCM_FIRST 0x1300")]
        public const int TCM_FIRST = 0x1300;

        [NativeTypeName("#define PGM_FIRST 0x1400")]
        public const int PGM_FIRST = 0x1400;

        [NativeTypeName("#define ECM_FIRST 0x1500")]
        public const int ECM_FIRST = 0x1500;

        [NativeTypeName("#define BCM_FIRST 0x1600")]
        public const int BCM_FIRST = 0x1600;

        [NativeTypeName("#define CBM_FIRST 0x1700")]
        public const int CBM_FIRST = 0x1700;

        [NativeTypeName("#define CCM_FIRST 0x2000")]
        public const int CCM_FIRST = 0x2000;

        [NativeTypeName("#define CCM_LAST (CCM_FIRST + 0x200)")]
        public const int CCM_LAST = (0x2000 + 0x200);

        [NativeTypeName("#define CCM_SETBKCOLOR (CCM_FIRST + 1)")]
        public const int CCM_SETBKCOLOR = (0x2000 + 1);

        [NativeTypeName("#define CCM_SETCOLORSCHEME (CCM_FIRST + 2)")]
        public const int CCM_SETCOLORSCHEME = (0x2000 + 2);

        [NativeTypeName("#define CCM_GETCOLORSCHEME (CCM_FIRST + 3)")]
        public const int CCM_GETCOLORSCHEME = (0x2000 + 3);

        [NativeTypeName("#define CCM_GETDROPTARGET (CCM_FIRST + 4)")]
        public const int CCM_GETDROPTARGET = (0x2000 + 4);

        [NativeTypeName("#define CCM_SETUNICODEFORMAT (CCM_FIRST + 5)")]
        public const int CCM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define CCM_GETUNICODEFORMAT (CCM_FIRST + 6)")]
        public const int CCM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define COMCTL32_VERSION 6")]
        public const int COMCTL32_VERSION = 6;

        [NativeTypeName("#define CCM_SETVERSION (CCM_FIRST + 0x7)")]
        public const int CCM_SETVERSION = (0x2000 + 0x7);

        [NativeTypeName("#define CCM_GETVERSION (CCM_FIRST + 0x8)")]
        public const int CCM_GETVERSION = (0x2000 + 0x8);

        [NativeTypeName("#define CCM_SETNOTIFYWINDOW (CCM_FIRST + 0x9)")]
        public const int CCM_SETNOTIFYWINDOW = (0x2000 + 0x9);

        [NativeTypeName("#define CCM_SETWINDOWTHEME (CCM_FIRST + 0xb)")]
        public const int CCM_SETWINDOWTHEME = (0x2000 + 0xb);

        [NativeTypeName("#define CCM_DPISCALE (CCM_FIRST + 0xc)")]
        public const int CCM_DPISCALE = (0x2000 + 0xc);

        [NativeTypeName("#define INFOTIPSIZE 1024")]
        public const int INFOTIPSIZE = 1024;

        [NativeTypeName("#define NM_OUTOFMEMORY (NM_FIRST-1)")]
        public const uint NM_OUTOFMEMORY = unchecked((0U - 0U) - 1);

        [NativeTypeName("#define NM_CLICK (NM_FIRST-2)")]
        public const uint NM_CLICK = unchecked((0U - 0U) - 2);

        [NativeTypeName("#define NM_DBLCLK (NM_FIRST-3)")]
        public const uint NM_DBLCLK = unchecked((0U - 0U) - 3);

        [NativeTypeName("#define NM_RETURN (NM_FIRST-4)")]
        public const uint NM_RETURN = unchecked((0U - 0U) - 4);

        [NativeTypeName("#define NM_RCLICK (NM_FIRST-5)")]
        public const uint NM_RCLICK = unchecked((0U - 0U) - 5);

        [NativeTypeName("#define NM_RDBLCLK (NM_FIRST-6)")]
        public const uint NM_RDBLCLK = unchecked((0U - 0U) - 6);

        [NativeTypeName("#define NM_SETFOCUS (NM_FIRST-7)")]
        public const uint NM_SETFOCUS = unchecked((0U - 0U) - 7);

        [NativeTypeName("#define NM_KILLFOCUS (NM_FIRST-8)")]
        public const uint NM_KILLFOCUS = unchecked((0U - 0U) - 8);

        [NativeTypeName("#define NM_CUSTOMDRAW (NM_FIRST-12)")]
        public const uint NM_CUSTOMDRAW = unchecked((0U - 0U) - 12);

        [NativeTypeName("#define NM_HOVER (NM_FIRST-13)")]
        public const uint NM_HOVER = unchecked((0U - 0U) - 13);

        [NativeTypeName("#define NM_NCHITTEST (NM_FIRST-14)")]
        public const uint NM_NCHITTEST = unchecked((0U - 0U) - 14);

        [NativeTypeName("#define NM_KEYDOWN (NM_FIRST-15)")]
        public const uint NM_KEYDOWN = unchecked((0U - 0U) - 15);

        [NativeTypeName("#define NM_RELEASEDCAPTURE (NM_FIRST-16)")]
        public const uint NM_RELEASEDCAPTURE = unchecked((0U - 0U) - 16);

        [NativeTypeName("#define NM_SETCURSOR (NM_FIRST-17)")]
        public const uint NM_SETCURSOR = unchecked((0U - 0U) - 17);

        [NativeTypeName("#define NM_CHAR (NM_FIRST-18)")]
        public const uint NM_CHAR = unchecked((0U - 0U) - 18);

        [NativeTypeName("#define NM_TOOLTIPSCREATED (NM_FIRST-19)")]
        public const uint NM_TOOLTIPSCREATED = unchecked((0U - 0U) - 19);

        [NativeTypeName("#define NM_LDOWN (NM_FIRST-20)")]
        public const uint NM_LDOWN = unchecked((0U - 0U) - 20);

        [NativeTypeName("#define NM_RDOWN (NM_FIRST-21)")]
        public const uint NM_RDOWN = unchecked((0U - 0U) - 21);

        [NativeTypeName("#define NM_THEMECHANGED (NM_FIRST-22)")]
        public const uint NM_THEMECHANGED = unchecked((0U - 0U) - 22);

        [NativeTypeName("#define NM_FONTCHANGED (NM_FIRST-23)")]
        public const uint NM_FONTCHANGED = unchecked((0U - 0U) - 23);

        [NativeTypeName("#define NM_CUSTOMTEXT (NM_FIRST-24)")]
        public const uint NM_CUSTOMTEXT = unchecked((0U - 0U) - 24);

        [NativeTypeName("#define NM_TVSTATEIMAGECHANGING (NM_FIRST-24)")]
        public const uint NM_TVSTATEIMAGECHANGING = unchecked((0U - 0U) - 24);

        [NativeTypeName("#define NM_FIRST (0U-  0U)")]
        public const uint NM_FIRST = (0U - 0U);

        [NativeTypeName("#define NM_LAST (0U- 99U)")]
        public const uint NM_LAST = unchecked(0U - 99U);

        [NativeTypeName("#define LVN_FIRST (0U-100U)")]
        public const uint LVN_FIRST = unchecked(0U - 100U);

        [NativeTypeName("#define LVN_LAST (0U-199U)")]
        public const uint LVN_LAST = unchecked(0U - 199U);

        [NativeTypeName("#define HDN_FIRST (0U-300U)")]
        public const uint HDN_FIRST = unchecked(0U - 300U);

        [NativeTypeName("#define HDN_LAST (0U-399U)")]
        public const uint HDN_LAST = unchecked(0U - 399U);

        [NativeTypeName("#define TVN_FIRST (0U-400U)")]
        public const uint TVN_FIRST = unchecked(0U - 400U);

        [NativeTypeName("#define TVN_LAST (0U-499U)")]
        public const uint TVN_LAST = unchecked(0U - 499U);

        [NativeTypeName("#define TTN_FIRST (0U-520U)")]
        public const uint TTN_FIRST = unchecked(0U - 520U);

        [NativeTypeName("#define TTN_LAST (0U-549U)")]
        public const uint TTN_LAST = unchecked(0U - 549U);

        [NativeTypeName("#define TCN_FIRST (0U-550U)")]
        public const uint TCN_FIRST = unchecked(0U - 550U);

        [NativeTypeName("#define TCN_LAST (0U-580U)")]
        public const uint TCN_LAST = unchecked(0U - 580U);

        [NativeTypeName("#define CDN_FIRST (0U-601U)")]
        public const uint CDN_FIRST = unchecked(0U - 601U);

        [NativeTypeName("#define CDN_LAST (0U-699U)")]
        public const uint CDN_LAST = unchecked(0U - 699U);

        [NativeTypeName("#define TBN_FIRST (0U-700U)")]
        public const uint TBN_FIRST = unchecked(0U - 700U);

        [NativeTypeName("#define TBN_LAST (0U-720U)")]
        public const uint TBN_LAST = unchecked(0U - 720U);

        [NativeTypeName("#define UDN_FIRST (0U-721U)")]
        public const uint UDN_FIRST = unchecked(0U - 721U);

        [NativeTypeName("#define UDN_LAST (0U-729U)")]
        public const uint UDN_LAST = unchecked(0U - 729U);

        [NativeTypeName("#define DTN_FIRST (0U-740U)")]
        public const uint DTN_FIRST = unchecked(0U - 740U);

        [NativeTypeName("#define DTN_LAST (0U-745U)")]
        public const uint DTN_LAST = unchecked(0U - 745U);

        [NativeTypeName("#define MCN_FIRST (0U-746U)")]
        public const uint MCN_FIRST = unchecked(0U - 746U);

        [NativeTypeName("#define MCN_LAST (0U-752U)")]
        public const uint MCN_LAST = unchecked(0U - 752U);

        [NativeTypeName("#define DTN_FIRST2 (0U-753U)")]
        public const uint DTN_FIRST2 = unchecked(0U - 753U);

        [NativeTypeName("#define DTN_LAST2 (0U-799U)")]
        public const uint DTN_LAST2 = unchecked(0U - 799U);

        [NativeTypeName("#define CBEN_FIRST (0U-800U)")]
        public const uint CBEN_FIRST = unchecked(0U - 800U);

        [NativeTypeName("#define CBEN_LAST (0U-830U)")]
        public const uint CBEN_LAST = unchecked(0U - 830U);

        [NativeTypeName("#define RBN_FIRST (0U-831U)")]
        public const uint RBN_FIRST = unchecked(0U - 831U);

        [NativeTypeName("#define RBN_LAST (0U-859U)")]
        public const uint RBN_LAST = unchecked(0U - 859U);

        [NativeTypeName("#define IPN_FIRST (0U-860U)")]
        public const uint IPN_FIRST = unchecked(0U - 860U);

        [NativeTypeName("#define IPN_LAST (0U-879U)")]
        public const uint IPN_LAST = unchecked(0U - 879U);

        [NativeTypeName("#define SBN_FIRST (0U-880U)")]
        public const uint SBN_FIRST = unchecked(0U - 880U);

        [NativeTypeName("#define SBN_LAST (0U-899U)")]
        public const uint SBN_LAST = unchecked(0U - 899U);

        [NativeTypeName("#define PGN_FIRST (0U-900U)")]
        public const uint PGN_FIRST = unchecked(0U - 900U);

        [NativeTypeName("#define PGN_LAST (0U-950U)")]
        public const uint PGN_LAST = unchecked(0U - 950U);

        [NativeTypeName("#define WMN_FIRST (0U-1000U)")]
        public const uint WMN_FIRST = unchecked(0U - 1000U);

        [NativeTypeName("#define WMN_LAST (0U-1200U)")]
        public const uint WMN_LAST = unchecked(0U - 1200U);

        [NativeTypeName("#define BCN_FIRST (0U-1250U)")]
        public const uint BCN_FIRST = unchecked(0U - 1250U);

        [NativeTypeName("#define BCN_LAST (0U-1350U)")]
        public const uint BCN_LAST = unchecked(0U - 1350U);

        [NativeTypeName("#define TRBN_FIRST (0U-1501U)")]
        public const uint TRBN_FIRST = unchecked(0U - 1501U);

        [NativeTypeName("#define TRBN_LAST (0U-1519U)")]
        public const uint TRBN_LAST = unchecked(0U - 1519U);

        [NativeTypeName("#define EN_FIRST (0U-1520U)")]
        public const uint EN_FIRST = unchecked(0U - 1520U);

        [NativeTypeName("#define EN_LAST (0U-1540U)")]
        public const uint EN_LAST = unchecked(0U - 1540U);

        [NativeTypeName("#define MSGF_COMMCTRL_BEGINDRAG 0x4200")]
        public const int MSGF_COMMCTRL_BEGINDRAG = 0x4200;

        [NativeTypeName("#define MSGF_COMMCTRL_SIZEHEADER 0x4201")]
        public const int MSGF_COMMCTRL_SIZEHEADER = 0x4201;

        [NativeTypeName("#define MSGF_COMMCTRL_DRAGSELECT 0x4202")]
        public const int MSGF_COMMCTRL_DRAGSELECT = 0x4202;

        [NativeTypeName("#define MSGF_COMMCTRL_TOOLBARCUST 0x4203")]
        public const int MSGF_COMMCTRL_TOOLBARCUST = 0x4203;

        [NativeTypeName("#define CDRF_DODEFAULT 0x00000000")]
        public const int CDRF_DODEFAULT = 0x00000000;

        [NativeTypeName("#define CDRF_NEWFONT 0x00000002")]
        public const int CDRF_NEWFONT = 0x00000002;

        [NativeTypeName("#define CDRF_SKIPDEFAULT 0x00000004")]
        public const int CDRF_SKIPDEFAULT = 0x00000004;

        [NativeTypeName("#define CDRF_DOERASE 0x00000008")]
        public const int CDRF_DOERASE = 0x00000008;

        [NativeTypeName("#define CDRF_SKIPPOSTPAINT 0x00000100")]
        public const int CDRF_SKIPPOSTPAINT = 0x00000100;

        [NativeTypeName("#define CDRF_NOTIFYPOSTPAINT 0x00000010")]
        public const int CDRF_NOTIFYPOSTPAINT = 0x00000010;

        [NativeTypeName("#define CDRF_NOTIFYITEMDRAW 0x00000020")]
        public const int CDRF_NOTIFYITEMDRAW = 0x00000020;

        [NativeTypeName("#define CDRF_NOTIFYSUBITEMDRAW 0x00000020")]
        public const int CDRF_NOTIFYSUBITEMDRAW = 0x00000020;

        [NativeTypeName("#define CDRF_NOTIFYPOSTERASE 0x00000040")]
        public const int CDRF_NOTIFYPOSTERASE = 0x00000040;

        [NativeTypeName("#define CDDS_PREPAINT 0x00000001")]
        public const int CDDS_PREPAINT = 0x00000001;

        [NativeTypeName("#define CDDS_POSTPAINT 0x00000002")]
        public const int CDDS_POSTPAINT = 0x00000002;

        [NativeTypeName("#define CDDS_PREERASE 0x00000003")]
        public const int CDDS_PREERASE = 0x00000003;

        [NativeTypeName("#define CDDS_POSTERASE 0x00000004")]
        public const int CDDS_POSTERASE = 0x00000004;

        [NativeTypeName("#define CDDS_ITEM 0x00010000")]
        public const int CDDS_ITEM = 0x00010000;

        [NativeTypeName("#define CDDS_ITEMPREPAINT (CDDS_ITEM | CDDS_PREPAINT)")]
        public const int CDDS_ITEMPREPAINT = (0x00010000 | 0x00000001);

        [NativeTypeName("#define CDDS_ITEMPOSTPAINT (CDDS_ITEM | CDDS_POSTPAINT)")]
        public const int CDDS_ITEMPOSTPAINT = (0x00010000 | 0x00000002);

        [NativeTypeName("#define CDDS_ITEMPREERASE (CDDS_ITEM | CDDS_PREERASE)")]
        public const int CDDS_ITEMPREERASE = (0x00010000 | 0x00000003);

        [NativeTypeName("#define CDDS_ITEMPOSTERASE (CDDS_ITEM | CDDS_POSTERASE)")]
        public const int CDDS_ITEMPOSTERASE = (0x00010000 | 0x00000004);

        [NativeTypeName("#define CDDS_SUBITEM 0x00020000")]
        public const int CDDS_SUBITEM = 0x00020000;

        [NativeTypeName("#define CDIS_SELECTED 0x0001")]
        public const int CDIS_SELECTED = 0x0001;

        [NativeTypeName("#define CDIS_GRAYED 0x0002")]
        public const int CDIS_GRAYED = 0x0002;

        [NativeTypeName("#define CDIS_DISABLED 0x0004")]
        public const int CDIS_DISABLED = 0x0004;

        [NativeTypeName("#define CDIS_CHECKED 0x0008")]
        public const int CDIS_CHECKED = 0x0008;

        [NativeTypeName("#define CDIS_FOCUS 0x0010")]
        public const int CDIS_FOCUS = 0x0010;

        [NativeTypeName("#define CDIS_DEFAULT 0x0020")]
        public const int CDIS_DEFAULT = 0x0020;

        [NativeTypeName("#define CDIS_HOT 0x0040")]
        public const int CDIS_HOT = 0x0040;

        [NativeTypeName("#define CDIS_MARKED 0x0080")]
        public const int CDIS_MARKED = 0x0080;

        [NativeTypeName("#define CDIS_INDETERMINATE 0x0100")]
        public const int CDIS_INDETERMINATE = 0x0100;

        [NativeTypeName("#define CDIS_SHOWKEYBOARDCUES 0x0200")]
        public const int CDIS_SHOWKEYBOARDCUES = 0x0200;

        [NativeTypeName("#define CDIS_NEARHOT 0x0400")]
        public const int CDIS_NEARHOT = 0x0400;

        [NativeTypeName("#define CDIS_OTHERSIDEHOT 0x0800")]
        public const int CDIS_OTHERSIDEHOT = 0x0800;

        [NativeTypeName("#define CDIS_DROPHILITED 0x1000")]
        public const int CDIS_DROPHILITED = 0x1000;

        [NativeTypeName("#define NM_GETCUSTOMSPLITRECT (BCN_FIRST + 0x0003)")]
        public const uint NM_GETCUSTOMSPLITRECT = unchecked((0U - 1250U) + 0x0003);

        [NativeTypeName("#define CLR_NONE 0xFFFFFFFFL")]
        public const uint CLR_NONE = 0xFFFFFFFF;

        [NativeTypeName("#define CLR_DEFAULT 0xFF000000L")]
        public const uint CLR_DEFAULT = 0xFF000000;

        [NativeTypeName("#define ILC_MASK 0x00000001")]
        public const int ILC_MASK = 0x00000001;

        [NativeTypeName("#define ILC_COLOR 0x00000000")]
        public const int ILC_COLOR = 0x00000000;

        [NativeTypeName("#define ILC_COLORDDB 0x000000FE")]
        public const int ILC_COLORDDB = 0x000000FE;

        [NativeTypeName("#define ILC_COLOR4 0x00000004")]
        public const int ILC_COLOR4 = 0x00000004;

        [NativeTypeName("#define ILC_COLOR8 0x00000008")]
        public const int ILC_COLOR8 = 0x00000008;

        [NativeTypeName("#define ILC_COLOR16 0x00000010")]
        public const int ILC_COLOR16 = 0x00000010;

        [NativeTypeName("#define ILC_COLOR24 0x00000018")]
        public const int ILC_COLOR24 = 0x00000018;

        [NativeTypeName("#define ILC_COLOR32 0x00000020")]
        public const int ILC_COLOR32 = 0x00000020;

        [NativeTypeName("#define ILC_PALETTE 0x00000800")]
        public const int ILC_PALETTE = 0x00000800;

        [NativeTypeName("#define ILC_MIRROR 0x00002000")]
        public const int ILC_MIRROR = 0x00002000;

        [NativeTypeName("#define ILC_PERITEMMIRROR 0x00008000")]
        public const int ILC_PERITEMMIRROR = 0x00008000;

        [NativeTypeName("#define ILC_ORIGINALSIZE 0x00010000")]
        public const int ILC_ORIGINALSIZE = 0x00010000;

        [NativeTypeName("#define ILC_HIGHQUALITYSCALE 0x00020000")]
        public const int ILC_HIGHQUALITYSCALE = 0x00020000;

        [NativeTypeName("#define ILD_NORMAL 0x00000000")]
        public const int ILD_NORMAL = 0x00000000;

        [NativeTypeName("#define ILD_TRANSPARENT 0x00000001")]
        public const int ILD_TRANSPARENT = 0x00000001;

        [NativeTypeName("#define ILD_MASK 0x00000010")]
        public const int ILD_MASK = 0x00000010;

        [NativeTypeName("#define ILD_IMAGE 0x00000020")]
        public const int ILD_IMAGE = 0x00000020;

        [NativeTypeName("#define ILD_ROP 0x00000040")]
        public const int ILD_ROP = 0x00000040;

        [NativeTypeName("#define ILD_BLEND25 0x00000002")]
        public const int ILD_BLEND25 = 0x00000002;

        [NativeTypeName("#define ILD_BLEND50 0x00000004")]
        public const int ILD_BLEND50 = 0x00000004;

        [NativeTypeName("#define ILD_OVERLAYMASK 0x00000F00")]
        public const int ILD_OVERLAYMASK = 0x00000F00;

        [NativeTypeName("#define ILD_PRESERVEALPHA 0x00001000")]
        public const int ILD_PRESERVEALPHA = 0x00001000;

        [NativeTypeName("#define ILD_SCALE 0x00002000")]
        public const int ILD_SCALE = 0x00002000;

        [NativeTypeName("#define ILD_DPISCALE 0x00004000")]
        public const int ILD_DPISCALE = 0x00004000;

        [NativeTypeName("#define ILD_ASYNC 0x00008000")]
        public const int ILD_ASYNC = 0x00008000;

        [NativeTypeName("#define ILD_SELECTED ILD_BLEND50")]
        public const int ILD_SELECTED = 0x00000004;

        [NativeTypeName("#define ILD_FOCUS ILD_BLEND25")]
        public const int ILD_FOCUS = 0x00000002;

        [NativeTypeName("#define ILD_BLEND ILD_BLEND50")]
        public const int ILD_BLEND = 0x00000004;

        [NativeTypeName("#define CLR_HILIGHT CLR_DEFAULT")]
        public const uint CLR_HILIGHT = 0xFF000000;

        [NativeTypeName("#define ILS_NORMAL 0x00000000")]
        public const int ILS_NORMAL = 0x00000000;

        [NativeTypeName("#define ILS_GLOW 0x00000001")]
        public const int ILS_GLOW = 0x00000001;

        [NativeTypeName("#define ILS_SHADOW 0x00000002")]
        public const int ILS_SHADOW = 0x00000002;

        [NativeTypeName("#define ILS_SATURATE 0x00000004")]
        public const int ILS_SATURATE = 0x00000004;

        [NativeTypeName("#define ILS_ALPHA 0x00000008")]
        public const int ILS_ALPHA = 0x00000008;

        [NativeTypeName("#define ILGT_NORMAL 0x00000000")]
        public const int ILGT_NORMAL = 0x00000000;

        [NativeTypeName("#define ILGT_ASYNC 0x00000001")]
        public const int ILGT_ASYNC = 0x00000001;

        [NativeTypeName("#define HBITMAP_CALLBACK ((HBITMAP)-1)")]
        public static IntPtr HBITMAP_CALLBACK => ((nint)(-1));

        [NativeTypeName("#define ImageList_LoadImage ImageList_LoadImageW")]
        public static delegate*<IntPtr, ushort*, int, int, uint, uint, uint, IntPtr> ImageList_LoadImage => &ImageList_LoadImageW;

        [NativeTypeName("#define ILCF_MOVE (0x00000000)")]
        public const int ILCF_MOVE = (0x00000000);

        [NativeTypeName("#define ILCF_SWAP (0x00000001)")]
        public const int ILCF_SWAP = (0x00000001);

        [NativeTypeName("#define ILP_NORMAL 0")]
        public const int ILP_NORMAL = 0;

        [NativeTypeName("#define ILP_DOWNLEVEL 1")]
        public const int ILP_DOWNLEVEL = 1;

        [NativeTypeName("#define WC_HEADERA \"SysHeader32\"")]
        public static ReadOnlySpan<byte> WC_HEADERA => new byte[] { 0x53, 0x79, 0x73, 0x48, 0x65, 0x61, 0x64, 0x65, 0x72, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_HEADERW L\"SysHeader32\"")]
        public const string WC_HEADERW = "SysHeader32";

        [NativeTypeName("#define WC_HEADER WC_HEADERW")]
        public const string WC_HEADER = "SysHeader32";

        [NativeTypeName("#define HDS_HORZ 0x0000")]
        public const int HDS_HORZ = 0x0000;

        [NativeTypeName("#define HDS_BUTTONS 0x0002")]
        public const int HDS_BUTTONS = 0x0002;

        [NativeTypeName("#define HDS_HOTTRACK 0x0004")]
        public const int HDS_HOTTRACK = 0x0004;

        [NativeTypeName("#define HDS_HIDDEN 0x0008")]
        public const int HDS_HIDDEN = 0x0008;

        [NativeTypeName("#define HDS_DRAGDROP 0x0040")]
        public const int HDS_DRAGDROP = 0x0040;

        [NativeTypeName("#define HDS_FULLDRAG 0x0080")]
        public const int HDS_FULLDRAG = 0x0080;

        [NativeTypeName("#define HDS_FILTERBAR 0x0100")]
        public const int HDS_FILTERBAR = 0x0100;

        [NativeTypeName("#define HDS_FLAT 0x0200")]
        public const int HDS_FLAT = 0x0200;

        [NativeTypeName("#define HDS_CHECKBOXES 0x0400")]
        public const int HDS_CHECKBOXES = 0x0400;

        [NativeTypeName("#define HDS_NOSIZING 0x0800")]
        public const int HDS_NOSIZING = 0x0800;

        [NativeTypeName("#define HDS_OVERFLOW 0x1000")]
        public const int HDS_OVERFLOW = 0x1000;

        [NativeTypeName("#define HDFT_ISSTRING 0x0000")]
        public const int HDFT_ISSTRING = 0x0000;

        [NativeTypeName("#define HDFT_ISNUMBER 0x0001")]
        public const int HDFT_ISNUMBER = 0x0001;

        [NativeTypeName("#define HDFT_ISDATE 0x0002")]
        public const int HDFT_ISDATE = 0x0002;

        [NativeTypeName("#define HDFT_HASNOVALUE 0x8000")]
        public const int HDFT_HASNOVALUE = 0x8000;

        [NativeTypeName("#define HDI_WIDTH 0x0001")]
        public const int HDI_WIDTH = 0x0001;

        [NativeTypeName("#define HDI_HEIGHT HDI_WIDTH")]
        public const int HDI_HEIGHT = 0x0001;

        [NativeTypeName("#define HDI_TEXT 0x0002")]
        public const int HDI_TEXT = 0x0002;

        [NativeTypeName("#define HDI_FORMAT 0x0004")]
        public const int HDI_FORMAT = 0x0004;

        [NativeTypeName("#define HDI_LPARAM 0x0008")]
        public const int HDI_LPARAM = 0x0008;

        [NativeTypeName("#define HDI_BITMAP 0x0010")]
        public const int HDI_BITMAP = 0x0010;

        [NativeTypeName("#define HDI_IMAGE 0x0020")]
        public const int HDI_IMAGE = 0x0020;

        [NativeTypeName("#define HDI_DI_SETITEM 0x0040")]
        public const int HDI_DI_SETITEM = 0x0040;

        [NativeTypeName("#define HDI_ORDER 0x0080")]
        public const int HDI_ORDER = 0x0080;

        [NativeTypeName("#define HDI_FILTER 0x0100")]
        public const int HDI_FILTER = 0x0100;

        [NativeTypeName("#define HDI_STATE 0x0200")]
        public const int HDI_STATE = 0x0200;

        [NativeTypeName("#define HDF_LEFT 0x0000")]
        public const int HDF_LEFT = 0x0000;

        [NativeTypeName("#define HDF_RIGHT 0x0001")]
        public const int HDF_RIGHT = 0x0001;

        [NativeTypeName("#define HDF_CENTER 0x0002")]
        public const int HDF_CENTER = 0x0002;

        [NativeTypeName("#define HDF_JUSTIFYMASK 0x0003")]
        public const int HDF_JUSTIFYMASK = 0x0003;

        [NativeTypeName("#define HDF_RTLREADING 0x0004")]
        public const int HDF_RTLREADING = 0x0004;

        [NativeTypeName("#define HDF_BITMAP 0x2000")]
        public const int HDF_BITMAP = 0x2000;

        [NativeTypeName("#define HDF_STRING 0x4000")]
        public const int HDF_STRING = 0x4000;

        [NativeTypeName("#define HDF_OWNERDRAW 0x8000")]
        public const int HDF_OWNERDRAW = 0x8000;

        [NativeTypeName("#define HDF_IMAGE 0x0800")]
        public const int HDF_IMAGE = 0x0800;

        [NativeTypeName("#define HDF_BITMAP_ON_RIGHT 0x1000")]
        public const int HDF_BITMAP_ON_RIGHT = 0x1000;

        [NativeTypeName("#define HDF_SORTUP 0x0400")]
        public const int HDF_SORTUP = 0x0400;

        [NativeTypeName("#define HDF_SORTDOWN 0x0200")]
        public const int HDF_SORTDOWN = 0x0200;

        [NativeTypeName("#define HDF_CHECKBOX 0x0040")]
        public const int HDF_CHECKBOX = 0x0040;

        [NativeTypeName("#define HDF_CHECKED 0x0080")]
        public const int HDF_CHECKED = 0x0080;

        [NativeTypeName("#define HDF_FIXEDWIDTH 0x0100")]
        public const int HDF_FIXEDWIDTH = 0x0100;

        [NativeTypeName("#define HDF_SPLITBUTTON 0x1000000")]
        public const int HDF_SPLITBUTTON = 0x1000000;

        [NativeTypeName("#define HDIS_FOCUSED 0x00000001")]
        public const int HDIS_FOCUSED = 0x00000001;

        [NativeTypeName("#define HDM_GETITEMCOUNT (HDM_FIRST + 0)")]
        public const int HDM_GETITEMCOUNT = (0x1200 + 0);

        [NativeTypeName("#define HDM_INSERTITEMA (HDM_FIRST + 1)")]
        public const int HDM_INSERTITEMA = (0x1200 + 1);

        [NativeTypeName("#define HDM_INSERTITEMW (HDM_FIRST + 10)")]
        public const int HDM_INSERTITEMW = (0x1200 + 10);

        [NativeTypeName("#define HDM_INSERTITEM HDM_INSERTITEMW")]
        public const int HDM_INSERTITEM = (0x1200 + 10);

        [NativeTypeName("#define HDM_DELETEITEM (HDM_FIRST + 2)")]
        public const int HDM_DELETEITEM = (0x1200 + 2);

        [NativeTypeName("#define HDM_GETITEMA (HDM_FIRST + 3)")]
        public const int HDM_GETITEMA = (0x1200 + 3);

        [NativeTypeName("#define HDM_GETITEMW (HDM_FIRST + 11)")]
        public const int HDM_GETITEMW = (0x1200 + 11);

        [NativeTypeName("#define HDM_GETITEM HDM_GETITEMW")]
        public const int HDM_GETITEM = (0x1200 + 11);

        [NativeTypeName("#define HDM_SETITEMA (HDM_FIRST + 4)")]
        public const int HDM_SETITEMA = (0x1200 + 4);

        [NativeTypeName("#define HDM_SETITEMW (HDM_FIRST + 12)")]
        public const int HDM_SETITEMW = (0x1200 + 12);

        [NativeTypeName("#define HDM_SETITEM HDM_SETITEMW")]
        public const int HDM_SETITEM = (0x1200 + 12);

        [NativeTypeName("#define HDM_LAYOUT (HDM_FIRST + 5)")]
        public const int HDM_LAYOUT = (0x1200 + 5);

        [NativeTypeName("#define HHT_NOWHERE 0x0001")]
        public const int HHT_NOWHERE = 0x0001;

        [NativeTypeName("#define HHT_ONHEADER 0x0002")]
        public const int HHT_ONHEADER = 0x0002;

        [NativeTypeName("#define HHT_ONDIVIDER 0x0004")]
        public const int HHT_ONDIVIDER = 0x0004;

        [NativeTypeName("#define HHT_ONDIVOPEN 0x0008")]
        public const int HHT_ONDIVOPEN = 0x0008;

        [NativeTypeName("#define HHT_ONFILTER 0x0010")]
        public const int HHT_ONFILTER = 0x0010;

        [NativeTypeName("#define HHT_ONFILTERBUTTON 0x0020")]
        public const int HHT_ONFILTERBUTTON = 0x0020;

        [NativeTypeName("#define HHT_ABOVE 0x0100")]
        public const int HHT_ABOVE = 0x0100;

        [NativeTypeName("#define HHT_BELOW 0x0200")]
        public const int HHT_BELOW = 0x0200;

        [NativeTypeName("#define HHT_TORIGHT 0x0400")]
        public const int HHT_TORIGHT = 0x0400;

        [NativeTypeName("#define HHT_TOLEFT 0x0800")]
        public const int HHT_TOLEFT = 0x0800;

        [NativeTypeName("#define HHT_ONITEMSTATEICON 0x1000")]
        public const int HHT_ONITEMSTATEICON = 0x1000;

        [NativeTypeName("#define HHT_ONDROPDOWN 0x2000")]
        public const int HHT_ONDROPDOWN = 0x2000;

        [NativeTypeName("#define HHT_ONOVERFLOW 0x4000")]
        public const int HHT_ONOVERFLOW = 0x4000;

        [NativeTypeName("#define HDSIL_NORMAL 0")]
        public const int HDSIL_NORMAL = 0;

        [NativeTypeName("#define HDSIL_STATE 1")]
        public const int HDSIL_STATE = 1;

        [NativeTypeName("#define HDM_HITTEST (HDM_FIRST + 6)")]
        public const int HDM_HITTEST = (0x1200 + 6);

        [NativeTypeName("#define HDM_GETITEMRECT (HDM_FIRST + 7)")]
        public const int HDM_GETITEMRECT = (0x1200 + 7);

        [NativeTypeName("#define HDM_SETIMAGELIST (HDM_FIRST + 8)")]
        public const int HDM_SETIMAGELIST = (0x1200 + 8);

        [NativeTypeName("#define HDM_GETIMAGELIST (HDM_FIRST + 9)")]
        public const int HDM_GETIMAGELIST = (0x1200 + 9);

        [NativeTypeName("#define HDM_ORDERTOINDEX (HDM_FIRST + 15)")]
        public const int HDM_ORDERTOINDEX = (0x1200 + 15);

        [NativeTypeName("#define HDM_CREATEDRAGIMAGE (HDM_FIRST + 16)")]
        public const int HDM_CREATEDRAGIMAGE = (0x1200 + 16);

        [NativeTypeName("#define HDM_GETORDERARRAY (HDM_FIRST + 17)")]
        public const int HDM_GETORDERARRAY = (0x1200 + 17);

        [NativeTypeName("#define HDM_SETORDERARRAY (HDM_FIRST + 18)")]
        public const int HDM_SETORDERARRAY = (0x1200 + 18);

        [NativeTypeName("#define HDM_SETHOTDIVIDER (HDM_FIRST + 19)")]
        public const int HDM_SETHOTDIVIDER = (0x1200 + 19);

        [NativeTypeName("#define HDM_SETBITMAPMARGIN (HDM_FIRST + 20)")]
        public const int HDM_SETBITMAPMARGIN = (0x1200 + 20);

        [NativeTypeName("#define HDM_GETBITMAPMARGIN (HDM_FIRST + 21)")]
        public const int HDM_GETBITMAPMARGIN = (0x1200 + 21);

        [NativeTypeName("#define HDM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int HDM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define HDM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int HDM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define HDM_SETFILTERCHANGETIMEOUT (HDM_FIRST+22)")]
        public const int HDM_SETFILTERCHANGETIMEOUT = (0x1200 + 22);

        [NativeTypeName("#define HDM_EDITFILTER (HDM_FIRST+23)")]
        public const int HDM_EDITFILTER = (0x1200 + 23);

        [NativeTypeName("#define HDM_CLEARFILTER (HDM_FIRST+24)")]
        public const int HDM_CLEARFILTER = (0x1200 + 24);

        [NativeTypeName("#define HDM_GETITEMDROPDOWNRECT (HDM_FIRST+25)")]
        public const int HDM_GETITEMDROPDOWNRECT = (0x1200 + 25);

        [NativeTypeName("#define HDM_GETOVERFLOWRECT (HDM_FIRST+26)")]
        public const int HDM_GETOVERFLOWRECT = (0x1200 + 26);

        [NativeTypeName("#define HDM_GETFOCUSEDITEM (HDM_FIRST+27)")]
        public const int HDM_GETFOCUSEDITEM = (0x1200 + 27);

        [NativeTypeName("#define HDM_SETFOCUSEDITEM (HDM_FIRST+28)")]
        public const int HDM_SETFOCUSEDITEM = (0x1200 + 28);

        [NativeTypeName("#define HDN_ITEMCHANGINGA (HDN_FIRST-0)")]
        public const uint HDN_ITEMCHANGINGA = unchecked((0U - 300U) - 0);

        [NativeTypeName("#define HDN_ITEMCHANGINGW (HDN_FIRST-20)")]
        public const uint HDN_ITEMCHANGINGW = unchecked((0U - 300U) - 20);

        [NativeTypeName("#define HDN_ITEMCHANGEDA (HDN_FIRST-1)")]
        public const uint HDN_ITEMCHANGEDA = unchecked((0U - 300U) - 1);

        [NativeTypeName("#define HDN_ITEMCHANGEDW (HDN_FIRST-21)")]
        public const uint HDN_ITEMCHANGEDW = unchecked((0U - 300U) - 21);

        [NativeTypeName("#define HDN_ITEMCLICKA (HDN_FIRST-2)")]
        public const uint HDN_ITEMCLICKA = unchecked((0U - 300U) - 2);

        [NativeTypeName("#define HDN_ITEMCLICKW (HDN_FIRST-22)")]
        public const uint HDN_ITEMCLICKW = unchecked((0U - 300U) - 22);

        [NativeTypeName("#define HDN_ITEMDBLCLICKA (HDN_FIRST-3)")]
        public const uint HDN_ITEMDBLCLICKA = unchecked((0U - 300U) - 3);

        [NativeTypeName("#define HDN_ITEMDBLCLICKW (HDN_FIRST-23)")]
        public const uint HDN_ITEMDBLCLICKW = unchecked((0U - 300U) - 23);

        [NativeTypeName("#define HDN_DIVIDERDBLCLICKA (HDN_FIRST-5)")]
        public const uint HDN_DIVIDERDBLCLICKA = unchecked((0U - 300U) - 5);

        [NativeTypeName("#define HDN_DIVIDERDBLCLICKW (HDN_FIRST-25)")]
        public const uint HDN_DIVIDERDBLCLICKW = unchecked((0U - 300U) - 25);

        [NativeTypeName("#define HDN_BEGINTRACKA (HDN_FIRST-6)")]
        public const uint HDN_BEGINTRACKA = unchecked((0U - 300U) - 6);

        [NativeTypeName("#define HDN_BEGINTRACKW (HDN_FIRST-26)")]
        public const uint HDN_BEGINTRACKW = unchecked((0U - 300U) - 26);

        [NativeTypeName("#define HDN_ENDTRACKA (HDN_FIRST-7)")]
        public const uint HDN_ENDTRACKA = unchecked((0U - 300U) - 7);

        [NativeTypeName("#define HDN_ENDTRACKW (HDN_FIRST-27)")]
        public const uint HDN_ENDTRACKW = unchecked((0U - 300U) - 27);

        [NativeTypeName("#define HDN_TRACKA (HDN_FIRST-8)")]
        public const uint HDN_TRACKA = unchecked((0U - 300U) - 8);

        [NativeTypeName("#define HDN_TRACKW (HDN_FIRST-28)")]
        public const uint HDN_TRACKW = unchecked((0U - 300U) - 28);

        [NativeTypeName("#define HDN_GETDISPINFOA (HDN_FIRST-9)")]
        public const uint HDN_GETDISPINFOA = unchecked((0U - 300U) - 9);

        [NativeTypeName("#define HDN_GETDISPINFOW (HDN_FIRST-29)")]
        public const uint HDN_GETDISPINFOW = unchecked((0U - 300U) - 29);

        [NativeTypeName("#define HDN_BEGINDRAG (HDN_FIRST-10)")]
        public const uint HDN_BEGINDRAG = unchecked((0U - 300U) - 10);

        [NativeTypeName("#define HDN_ENDDRAG (HDN_FIRST-11)")]
        public const uint HDN_ENDDRAG = unchecked((0U - 300U) - 11);

        [NativeTypeName("#define HDN_FILTERCHANGE (HDN_FIRST-12)")]
        public const uint HDN_FILTERCHANGE = unchecked((0U - 300U) - 12);

        [NativeTypeName("#define HDN_FILTERBTNCLICK (HDN_FIRST-13)")]
        public const uint HDN_FILTERBTNCLICK = unchecked((0U - 300U) - 13);

        [NativeTypeName("#define HDN_BEGINFILTEREDIT (HDN_FIRST-14)")]
        public const uint HDN_BEGINFILTEREDIT = unchecked((0U - 300U) - 14);

        [NativeTypeName("#define HDN_ENDFILTEREDIT (HDN_FIRST-15)")]
        public const uint HDN_ENDFILTEREDIT = unchecked((0U - 300U) - 15);

        [NativeTypeName("#define HDN_ITEMSTATEICONCLICK (HDN_FIRST-16)")]
        public const uint HDN_ITEMSTATEICONCLICK = unchecked((0U - 300U) - 16);

        [NativeTypeName("#define HDN_ITEMKEYDOWN (HDN_FIRST-17)")]
        public const uint HDN_ITEMKEYDOWN = unchecked((0U - 300U) - 17);

        [NativeTypeName("#define HDN_DROPDOWN (HDN_FIRST-18)")]
        public const uint HDN_DROPDOWN = unchecked((0U - 300U) - 18);

        [NativeTypeName("#define HDN_OVERFLOWCLICK (HDN_FIRST-19)")]
        public const uint HDN_OVERFLOWCLICK = unchecked((0U - 300U) - 19);

        [NativeTypeName("#define HDN_ITEMCHANGING HDN_ITEMCHANGINGW")]
        public const uint HDN_ITEMCHANGING = unchecked((0U - 300U) - 20);

        [NativeTypeName("#define HDN_ITEMCHANGED HDN_ITEMCHANGEDW")]
        public const uint HDN_ITEMCHANGED = unchecked((0U - 300U) - 21);

        [NativeTypeName("#define HDN_ITEMCLICK HDN_ITEMCLICKW")]
        public const uint HDN_ITEMCLICK = unchecked((0U - 300U) - 22);

        [NativeTypeName("#define HDN_ITEMDBLCLICK HDN_ITEMDBLCLICKW")]
        public const uint HDN_ITEMDBLCLICK = unchecked((0U - 300U) - 23);

        [NativeTypeName("#define HDN_DIVIDERDBLCLICK HDN_DIVIDERDBLCLICKW")]
        public const uint HDN_DIVIDERDBLCLICK = unchecked((0U - 300U) - 25);

        [NativeTypeName("#define HDN_BEGINTRACK HDN_BEGINTRACKW")]
        public const uint HDN_BEGINTRACK = unchecked((0U - 300U) - 26);

        [NativeTypeName("#define HDN_ENDTRACK HDN_ENDTRACKW")]
        public const uint HDN_ENDTRACK = unchecked((0U - 300U) - 27);

        [NativeTypeName("#define HDN_TRACK HDN_TRACKW")]
        public const uint HDN_TRACK = unchecked((0U - 300U) - 28);

        [NativeTypeName("#define HDN_GETDISPINFO HDN_GETDISPINFOW")]
        public const uint HDN_GETDISPINFO = unchecked((0U - 300U) - 29);

        [NativeTypeName("#define TOOLBARCLASSNAMEW L\"ToolbarWindow32\"")]
        public const string TOOLBARCLASSNAMEW = "ToolbarWindow32";

        [NativeTypeName("#define TOOLBARCLASSNAMEA \"ToolbarWindow32\"")]
        public static ReadOnlySpan<byte> TOOLBARCLASSNAMEA => new byte[] { 0x54, 0x6F, 0x6F, 0x6C, 0x62, 0x61, 0x72, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define TOOLBARCLASSNAME TOOLBARCLASSNAMEW")]
        public const string TOOLBARCLASSNAME = "ToolbarWindow32";

        [NativeTypeName("#define CMB_MASKED 0x02")]
        public const int CMB_MASKED = 0x02;

        [NativeTypeName("#define TBSTATE_CHECKED 0x01")]
        public const int TBSTATE_CHECKED = 0x01;

        [NativeTypeName("#define TBSTATE_PRESSED 0x02")]
        public const int TBSTATE_PRESSED = 0x02;

        [NativeTypeName("#define TBSTATE_ENABLED 0x04")]
        public const int TBSTATE_ENABLED = 0x04;

        [NativeTypeName("#define TBSTATE_HIDDEN 0x08")]
        public const int TBSTATE_HIDDEN = 0x08;

        [NativeTypeName("#define TBSTATE_INDETERMINATE 0x10")]
        public const int TBSTATE_INDETERMINATE = 0x10;

        [NativeTypeName("#define TBSTATE_WRAP 0x20")]
        public const int TBSTATE_WRAP = 0x20;

        [NativeTypeName("#define TBSTATE_ELLIPSES 0x40")]
        public const int TBSTATE_ELLIPSES = 0x40;

        [NativeTypeName("#define TBSTATE_MARKED 0x80")]
        public const int TBSTATE_MARKED = 0x80;

        [NativeTypeName("#define TBSTYLE_BUTTON 0x0000")]
        public const int TBSTYLE_BUTTON = 0x0000;

        [NativeTypeName("#define TBSTYLE_SEP 0x0001")]
        public const int TBSTYLE_SEP = 0x0001;

        [NativeTypeName("#define TBSTYLE_CHECK 0x0002")]
        public const int TBSTYLE_CHECK = 0x0002;

        [NativeTypeName("#define TBSTYLE_GROUP 0x0004")]
        public const int TBSTYLE_GROUP = 0x0004;

        [NativeTypeName("#define TBSTYLE_CHECKGROUP (TBSTYLE_GROUP | TBSTYLE_CHECK)")]
        public const int TBSTYLE_CHECKGROUP = (0x0004 | 0x0002);

        [NativeTypeName("#define TBSTYLE_DROPDOWN 0x0008")]
        public const int TBSTYLE_DROPDOWN = 0x0008;

        [NativeTypeName("#define TBSTYLE_AUTOSIZE 0x0010")]
        public const int TBSTYLE_AUTOSIZE = 0x0010;

        [NativeTypeName("#define TBSTYLE_NOPREFIX 0x0020")]
        public const int TBSTYLE_NOPREFIX = 0x0020;

        [NativeTypeName("#define TBSTYLE_TOOLTIPS 0x0100")]
        public const int TBSTYLE_TOOLTIPS = 0x0100;

        [NativeTypeName("#define TBSTYLE_WRAPABLE 0x0200")]
        public const int TBSTYLE_WRAPABLE = 0x0200;

        [NativeTypeName("#define TBSTYLE_ALTDRAG 0x0400")]
        public const int TBSTYLE_ALTDRAG = 0x0400;

        [NativeTypeName("#define TBSTYLE_FLAT 0x0800")]
        public const int TBSTYLE_FLAT = 0x0800;

        [NativeTypeName("#define TBSTYLE_LIST 0x1000")]
        public const int TBSTYLE_LIST = 0x1000;

        [NativeTypeName("#define TBSTYLE_CUSTOMERASE 0x2000")]
        public const int TBSTYLE_CUSTOMERASE = 0x2000;

        [NativeTypeName("#define TBSTYLE_REGISTERDROP 0x4000")]
        public const int TBSTYLE_REGISTERDROP = 0x4000;

        [NativeTypeName("#define TBSTYLE_TRANSPARENT 0x8000")]
        public const int TBSTYLE_TRANSPARENT = 0x8000;

        [NativeTypeName("#define TBSTYLE_EX_DRAWDDARROWS 0x00000001")]
        public const int TBSTYLE_EX_DRAWDDARROWS = 0x00000001;

        [NativeTypeName("#define BTNS_BUTTON TBSTYLE_BUTTON")]
        public const int BTNS_BUTTON = 0x0000;

        [NativeTypeName("#define BTNS_SEP TBSTYLE_SEP")]
        public const int BTNS_SEP = 0x0001;

        [NativeTypeName("#define BTNS_CHECK TBSTYLE_CHECK")]
        public const int BTNS_CHECK = 0x0002;

        [NativeTypeName("#define BTNS_GROUP TBSTYLE_GROUP")]
        public const int BTNS_GROUP = 0x0004;

        [NativeTypeName("#define BTNS_CHECKGROUP TBSTYLE_CHECKGROUP")]
        public const int BTNS_CHECKGROUP = (0x0004 | 0x0002);

        [NativeTypeName("#define BTNS_DROPDOWN TBSTYLE_DROPDOWN")]
        public const int BTNS_DROPDOWN = 0x0008;

        [NativeTypeName("#define BTNS_AUTOSIZE TBSTYLE_AUTOSIZE")]
        public const int BTNS_AUTOSIZE = 0x0010;

        [NativeTypeName("#define BTNS_NOPREFIX TBSTYLE_NOPREFIX")]
        public const int BTNS_NOPREFIX = 0x0020;

        [NativeTypeName("#define BTNS_SHOWTEXT 0x0040")]
        public const int BTNS_SHOWTEXT = 0x0040;

        [NativeTypeName("#define BTNS_WHOLEDROPDOWN 0x0080")]
        public const int BTNS_WHOLEDROPDOWN = 0x0080;

        [NativeTypeName("#define TBSTYLE_EX_MIXEDBUTTONS 0x00000008")]
        public const int TBSTYLE_EX_MIXEDBUTTONS = 0x00000008;

        [NativeTypeName("#define TBSTYLE_EX_HIDECLIPPEDBUTTONS 0x00000010")]
        public const int TBSTYLE_EX_HIDECLIPPEDBUTTONS = 0x00000010;

        [NativeTypeName("#define TBSTYLE_EX_MULTICOLUMN 0x00000002")]
        public const int TBSTYLE_EX_MULTICOLUMN = 0x00000002;

        [NativeTypeName("#define TBSTYLE_EX_VERTICAL 0x00000004")]
        public const int TBSTYLE_EX_VERTICAL = 0x00000004;

        [NativeTypeName("#define TBSTYLE_EX_DOUBLEBUFFER 0x00000080")]
        public const int TBSTYLE_EX_DOUBLEBUFFER = 0x00000080;

        [NativeTypeName("#define TBCDRF_NOEDGES 0x00010000")]
        public const int TBCDRF_NOEDGES = 0x00010000;

        [NativeTypeName("#define TBCDRF_HILITEHOTTRACK 0x00020000")]
        public const int TBCDRF_HILITEHOTTRACK = 0x00020000;

        [NativeTypeName("#define TBCDRF_NOOFFSET 0x00040000")]
        public const int TBCDRF_NOOFFSET = 0x00040000;

        [NativeTypeName("#define TBCDRF_NOMARK 0x00080000")]
        public const int TBCDRF_NOMARK = 0x00080000;

        [NativeTypeName("#define TBCDRF_NOETCHEDEFFECT 0x00100000")]
        public const int TBCDRF_NOETCHEDEFFECT = 0x00100000;

        [NativeTypeName("#define TBCDRF_BLENDICON 0x00200000")]
        public const int TBCDRF_BLENDICON = 0x00200000;

        [NativeTypeName("#define TBCDRF_NOBACKGROUND 0x00400000")]
        public const int TBCDRF_NOBACKGROUND = 0x00400000;

        [NativeTypeName("#define TBCDRF_USECDCOLORS 0x00800000")]
        public const int TBCDRF_USECDCOLORS = 0x00800000;

        [NativeTypeName("#define TB_ENABLEBUTTON (WM_USER + 1)")]
        public const int TB_ENABLEBUTTON = (0x0400 + 1);

        [NativeTypeName("#define TB_CHECKBUTTON (WM_USER + 2)")]
        public const int TB_CHECKBUTTON = (0x0400 + 2);

        [NativeTypeName("#define TB_PRESSBUTTON (WM_USER + 3)")]
        public const int TB_PRESSBUTTON = (0x0400 + 3);

        [NativeTypeName("#define TB_HIDEBUTTON (WM_USER + 4)")]
        public const int TB_HIDEBUTTON = (0x0400 + 4);

        [NativeTypeName("#define TB_INDETERMINATE (WM_USER + 5)")]
        public const int TB_INDETERMINATE = (0x0400 + 5);

        [NativeTypeName("#define TB_MARKBUTTON (WM_USER + 6)")]
        public const int TB_MARKBUTTON = (0x0400 + 6);

        [NativeTypeName("#define TB_ISBUTTONENABLED (WM_USER + 9)")]
        public const int TB_ISBUTTONENABLED = (0x0400 + 9);

        [NativeTypeName("#define TB_ISBUTTONCHECKED (WM_USER + 10)")]
        public const int TB_ISBUTTONCHECKED = (0x0400 + 10);

        [NativeTypeName("#define TB_ISBUTTONPRESSED (WM_USER + 11)")]
        public const int TB_ISBUTTONPRESSED = (0x0400 + 11);

        [NativeTypeName("#define TB_ISBUTTONHIDDEN (WM_USER + 12)")]
        public const int TB_ISBUTTONHIDDEN = (0x0400 + 12);

        [NativeTypeName("#define TB_ISBUTTONINDETERMINATE (WM_USER + 13)")]
        public const int TB_ISBUTTONINDETERMINATE = (0x0400 + 13);

        [NativeTypeName("#define TB_ISBUTTONHIGHLIGHTED (WM_USER + 14)")]
        public const int TB_ISBUTTONHIGHLIGHTED = (0x0400 + 14);

        [NativeTypeName("#define TB_SETSTATE (WM_USER + 17)")]
        public const int TB_SETSTATE = (0x0400 + 17);

        [NativeTypeName("#define TB_GETSTATE (WM_USER + 18)")]
        public const int TB_GETSTATE = (0x0400 + 18);

        [NativeTypeName("#define TB_ADDBITMAP (WM_USER + 19)")]
        public const int TB_ADDBITMAP = (0x0400 + 19);

        [NativeTypeName("#define HINST_COMMCTRL ((HINSTANCE)-1)")]
        public static IntPtr HINST_COMMCTRL => ((nint)(-1));

        [NativeTypeName("#define IDB_STD_SMALL_COLOR 0")]
        public const int IDB_STD_SMALL_COLOR = 0;

        [NativeTypeName("#define IDB_STD_LARGE_COLOR 1")]
        public const int IDB_STD_LARGE_COLOR = 1;

        [NativeTypeName("#define IDB_VIEW_SMALL_COLOR 4")]
        public const int IDB_VIEW_SMALL_COLOR = 4;

        [NativeTypeName("#define IDB_VIEW_LARGE_COLOR 5")]
        public const int IDB_VIEW_LARGE_COLOR = 5;

        [NativeTypeName("#define IDB_HIST_SMALL_COLOR 8")]
        public const int IDB_HIST_SMALL_COLOR = 8;

        [NativeTypeName("#define IDB_HIST_LARGE_COLOR 9")]
        public const int IDB_HIST_LARGE_COLOR = 9;

        [NativeTypeName("#define IDB_HIST_NORMAL 12")]
        public const int IDB_HIST_NORMAL = 12;

        [NativeTypeName("#define IDB_HIST_HOT 13")]
        public const int IDB_HIST_HOT = 13;

        [NativeTypeName("#define IDB_HIST_DISABLED 14")]
        public const int IDB_HIST_DISABLED = 14;

        [NativeTypeName("#define IDB_HIST_PRESSED 15")]
        public const int IDB_HIST_PRESSED = 15;

        [NativeTypeName("#define STD_CUT 0")]
        public const int STD_CUT = 0;

        [NativeTypeName("#define STD_COPY 1")]
        public const int STD_COPY = 1;

        [NativeTypeName("#define STD_PASTE 2")]
        public const int STD_PASTE = 2;

        [NativeTypeName("#define STD_UNDO 3")]
        public const int STD_UNDO = 3;

        [NativeTypeName("#define STD_REDOW 4")]
        public const int STD_REDOW = 4;

        [NativeTypeName("#define STD_DELETE 5")]
        public const int STD_DELETE = 5;

        [NativeTypeName("#define STD_FILENEW 6")]
        public const int STD_FILENEW = 6;

        [NativeTypeName("#define STD_FILEOPEN 7")]
        public const int STD_FILEOPEN = 7;

        [NativeTypeName("#define STD_FILESAVE 8")]
        public const int STD_FILESAVE = 8;

        [NativeTypeName("#define STD_PRINTPRE 9")]
        public const int STD_PRINTPRE = 9;

        [NativeTypeName("#define STD_PROPERTIES 10")]
        public const int STD_PROPERTIES = 10;

        [NativeTypeName("#define STD_HELP 11")]
        public const int STD_HELP = 11;

        [NativeTypeName("#define STD_FIND 12")]
        public const int STD_FIND = 12;

        [NativeTypeName("#define STD_REPLACE 13")]
        public const int STD_REPLACE = 13;

        [NativeTypeName("#define STD_PRINT 14")]
        public const int STD_PRINT = 14;

        [NativeTypeName("#define VIEW_LARGEICONS 0")]
        public const int VIEW_LARGEICONS = 0;

        [NativeTypeName("#define VIEW_SMALLICONS 1")]
        public const int VIEW_SMALLICONS = 1;

        [NativeTypeName("#define VIEW_LIST 2")]
        public const int VIEW_LIST = 2;

        [NativeTypeName("#define VIEW_DETAILS 3")]
        public const int VIEW_DETAILS = 3;

        [NativeTypeName("#define VIEW_SORTNAME 4")]
        public const int VIEW_SORTNAME = 4;

        [NativeTypeName("#define VIEW_SORTSIZE 5")]
        public const int VIEW_SORTSIZE = 5;

        [NativeTypeName("#define VIEW_SORTDATE 6")]
        public const int VIEW_SORTDATE = 6;

        [NativeTypeName("#define VIEW_SORTTYPE 7")]
        public const int VIEW_SORTTYPE = 7;

        [NativeTypeName("#define VIEW_PARENTFOLDER 8")]
        public const int VIEW_PARENTFOLDER = 8;

        [NativeTypeName("#define VIEW_NETCONNECT 9")]
        public const int VIEW_NETCONNECT = 9;

        [NativeTypeName("#define VIEW_NETDISCONNECT 10")]
        public const int VIEW_NETDISCONNECT = 10;

        [NativeTypeName("#define VIEW_NEWFOLDER 11")]
        public const int VIEW_NEWFOLDER = 11;

        [NativeTypeName("#define VIEW_VIEWMENU 12")]
        public const int VIEW_VIEWMENU = 12;

        [NativeTypeName("#define HIST_BACK 0")]
        public const int HIST_BACK = 0;

        [NativeTypeName("#define HIST_FORWARD 1")]
        public const int HIST_FORWARD = 1;

        [NativeTypeName("#define HIST_FAVORITES 2")]
        public const int HIST_FAVORITES = 2;

        [NativeTypeName("#define HIST_ADDTOFAVORITES 3")]
        public const int HIST_ADDTOFAVORITES = 3;

        [NativeTypeName("#define HIST_VIEWTREE 4")]
        public const int HIST_VIEWTREE = 4;

        [NativeTypeName("#define TB_ADDBUTTONSA (WM_USER + 20)")]
        public const int TB_ADDBUTTONSA = (0x0400 + 20);

        [NativeTypeName("#define TB_INSERTBUTTONA (WM_USER + 21)")]
        public const int TB_INSERTBUTTONA = (0x0400 + 21);

        [NativeTypeName("#define TB_DELETEBUTTON (WM_USER + 22)")]
        public const int TB_DELETEBUTTON = (0x0400 + 22);

        [NativeTypeName("#define TB_GETBUTTON (WM_USER + 23)")]
        public const int TB_GETBUTTON = (0x0400 + 23);

        [NativeTypeName("#define TB_BUTTONCOUNT (WM_USER + 24)")]
        public const int TB_BUTTONCOUNT = (0x0400 + 24);

        [NativeTypeName("#define TB_COMMANDTOINDEX (WM_USER + 25)")]
        public const int TB_COMMANDTOINDEX = (0x0400 + 25);

        [NativeTypeName("#define TB_SAVERESTOREA (WM_USER + 26)")]
        public const int TB_SAVERESTOREA = (0x0400 + 26);

        [NativeTypeName("#define TB_SAVERESTOREW (WM_USER + 76)")]
        public const int TB_SAVERESTOREW = (0x0400 + 76);

        [NativeTypeName("#define TB_CUSTOMIZE (WM_USER + 27)")]
        public const int TB_CUSTOMIZE = (0x0400 + 27);

        [NativeTypeName("#define TB_ADDSTRINGA (WM_USER + 28)")]
        public const int TB_ADDSTRINGA = (0x0400 + 28);

        [NativeTypeName("#define TB_ADDSTRINGW (WM_USER + 77)")]
        public const int TB_ADDSTRINGW = (0x0400 + 77);

        [NativeTypeName("#define TB_GETITEMRECT (WM_USER + 29)")]
        public const int TB_GETITEMRECT = (0x0400 + 29);

        [NativeTypeName("#define TB_BUTTONSTRUCTSIZE (WM_USER + 30)")]
        public const int TB_BUTTONSTRUCTSIZE = (0x0400 + 30);

        [NativeTypeName("#define TB_SETBUTTONSIZE (WM_USER + 31)")]
        public const int TB_SETBUTTONSIZE = (0x0400 + 31);

        [NativeTypeName("#define TB_SETBITMAPSIZE (WM_USER + 32)")]
        public const int TB_SETBITMAPSIZE = (0x0400 + 32);

        [NativeTypeName("#define TB_AUTOSIZE (WM_USER + 33)")]
        public const int TB_AUTOSIZE = (0x0400 + 33);

        [NativeTypeName("#define TB_GETTOOLTIPS (WM_USER + 35)")]
        public const int TB_GETTOOLTIPS = (0x0400 + 35);

        [NativeTypeName("#define TB_SETTOOLTIPS (WM_USER + 36)")]
        public const int TB_SETTOOLTIPS = (0x0400 + 36);

        [NativeTypeName("#define TB_SETPARENT (WM_USER + 37)")]
        public const int TB_SETPARENT = (0x0400 + 37);

        [NativeTypeName("#define TB_SETROWS (WM_USER + 39)")]
        public const int TB_SETROWS = (0x0400 + 39);

        [NativeTypeName("#define TB_GETROWS (WM_USER + 40)")]
        public const int TB_GETROWS = (0x0400 + 40);

        [NativeTypeName("#define TB_SETCMDID (WM_USER + 42)")]
        public const int TB_SETCMDID = (0x0400 + 42);

        [NativeTypeName("#define TB_CHANGEBITMAP (WM_USER + 43)")]
        public const int TB_CHANGEBITMAP = (0x0400 + 43);

        [NativeTypeName("#define TB_GETBITMAP (WM_USER + 44)")]
        public const int TB_GETBITMAP = (0x0400 + 44);

        [NativeTypeName("#define TB_GETBUTTONTEXTA (WM_USER + 45)")]
        public const int TB_GETBUTTONTEXTA = (0x0400 + 45);

        [NativeTypeName("#define TB_GETBUTTONTEXTW (WM_USER + 75)")]
        public const int TB_GETBUTTONTEXTW = (0x0400 + 75);

        [NativeTypeName("#define TB_REPLACEBITMAP (WM_USER + 46)")]
        public const int TB_REPLACEBITMAP = (0x0400 + 46);

        [NativeTypeName("#define TB_SETINDENT (WM_USER + 47)")]
        public const int TB_SETINDENT = (0x0400 + 47);

        [NativeTypeName("#define TB_SETIMAGELIST (WM_USER + 48)")]
        public const int TB_SETIMAGELIST = (0x0400 + 48);

        [NativeTypeName("#define TB_GETIMAGELIST (WM_USER + 49)")]
        public const int TB_GETIMAGELIST = (0x0400 + 49);

        [NativeTypeName("#define TB_LOADIMAGES (WM_USER + 50)")]
        public const int TB_LOADIMAGES = (0x0400 + 50);

        [NativeTypeName("#define TB_GETRECT (WM_USER + 51)")]
        public const int TB_GETRECT = (0x0400 + 51);

        [NativeTypeName("#define TB_SETHOTIMAGELIST (WM_USER + 52)")]
        public const int TB_SETHOTIMAGELIST = (0x0400 + 52);

        [NativeTypeName("#define TB_GETHOTIMAGELIST (WM_USER + 53)")]
        public const int TB_GETHOTIMAGELIST = (0x0400 + 53);

        [NativeTypeName("#define TB_SETDISABLEDIMAGELIST (WM_USER + 54)")]
        public const int TB_SETDISABLEDIMAGELIST = (0x0400 + 54);

        [NativeTypeName("#define TB_GETDISABLEDIMAGELIST (WM_USER + 55)")]
        public const int TB_GETDISABLEDIMAGELIST = (0x0400 + 55);

        [NativeTypeName("#define TB_SETSTYLE (WM_USER + 56)")]
        public const int TB_SETSTYLE = (0x0400 + 56);

        [NativeTypeName("#define TB_GETSTYLE (WM_USER + 57)")]
        public const int TB_GETSTYLE = (0x0400 + 57);

        [NativeTypeName("#define TB_GETBUTTONSIZE (WM_USER + 58)")]
        public const int TB_GETBUTTONSIZE = (0x0400 + 58);

        [NativeTypeName("#define TB_SETBUTTONWIDTH (WM_USER + 59)")]
        public const int TB_SETBUTTONWIDTH = (0x0400 + 59);

        [NativeTypeName("#define TB_SETMAXTEXTROWS (WM_USER + 60)")]
        public const int TB_SETMAXTEXTROWS = (0x0400 + 60);

        [NativeTypeName("#define TB_GETTEXTROWS (WM_USER + 61)")]
        public const int TB_GETTEXTROWS = (0x0400 + 61);

        [NativeTypeName("#define TB_GETBUTTONTEXT TB_GETBUTTONTEXTW")]
        public const int TB_GETBUTTONTEXT = (0x0400 + 75);

        [NativeTypeName("#define TB_SAVERESTORE TB_SAVERESTOREW")]
        public const int TB_SAVERESTORE = (0x0400 + 76);

        [NativeTypeName("#define TB_ADDSTRING TB_ADDSTRINGW")]
        public const int TB_ADDSTRING = (0x0400 + 77);

        [NativeTypeName("#define TB_GETOBJECT (WM_USER + 62)")]
        public const int TB_GETOBJECT = (0x0400 + 62);

        [NativeTypeName("#define TB_GETHOTITEM (WM_USER + 71)")]
        public const int TB_GETHOTITEM = (0x0400 + 71);

        [NativeTypeName("#define TB_SETHOTITEM (WM_USER + 72)")]
        public const int TB_SETHOTITEM = (0x0400 + 72);

        [NativeTypeName("#define TB_SETANCHORHIGHLIGHT (WM_USER + 73)")]
        public const int TB_SETANCHORHIGHLIGHT = (0x0400 + 73);

        [NativeTypeName("#define TB_GETANCHORHIGHLIGHT (WM_USER + 74)")]
        public const int TB_GETANCHORHIGHLIGHT = (0x0400 + 74);

        [NativeTypeName("#define TB_MAPACCELERATORA (WM_USER + 78)")]
        public const int TB_MAPACCELERATORA = (0x0400 + 78);

        [NativeTypeName("#define TBIMHT_AFTER 0x00000001")]
        public const int TBIMHT_AFTER = 0x00000001;

        [NativeTypeName("#define TBIMHT_BACKGROUND 0x00000002")]
        public const int TBIMHT_BACKGROUND = 0x00000002;

        [NativeTypeName("#define TB_GETINSERTMARK (WM_USER + 79)")]
        public const int TB_GETINSERTMARK = (0x0400 + 79);

        [NativeTypeName("#define TB_SETINSERTMARK (WM_USER + 80)")]
        public const int TB_SETINSERTMARK = (0x0400 + 80);

        [NativeTypeName("#define TB_INSERTMARKHITTEST (WM_USER + 81)")]
        public const int TB_INSERTMARKHITTEST = (0x0400 + 81);

        [NativeTypeName("#define TB_MOVEBUTTON (WM_USER + 82)")]
        public const int TB_MOVEBUTTON = (0x0400 + 82);

        [NativeTypeName("#define TB_GETMAXSIZE (WM_USER + 83)")]
        public const int TB_GETMAXSIZE = (0x0400 + 83);

        [NativeTypeName("#define TB_SETEXTENDEDSTYLE (WM_USER + 84)")]
        public const int TB_SETEXTENDEDSTYLE = (0x0400 + 84);

        [NativeTypeName("#define TB_GETEXTENDEDSTYLE (WM_USER + 85)")]
        public const int TB_GETEXTENDEDSTYLE = (0x0400 + 85);

        [NativeTypeName("#define TB_GETPADDING (WM_USER + 86)")]
        public const int TB_GETPADDING = (0x0400 + 86);

        [NativeTypeName("#define TB_SETPADDING (WM_USER + 87)")]
        public const int TB_SETPADDING = (0x0400 + 87);

        [NativeTypeName("#define TB_SETINSERTMARKCOLOR (WM_USER + 88)")]
        public const int TB_SETINSERTMARKCOLOR = (0x0400 + 88);

        [NativeTypeName("#define TB_GETINSERTMARKCOLOR (WM_USER + 89)")]
        public const int TB_GETINSERTMARKCOLOR = (0x0400 + 89);

        [NativeTypeName("#define TB_SETCOLORSCHEME CCM_SETCOLORSCHEME")]
        public const int TB_SETCOLORSCHEME = (0x2000 + 2);

        [NativeTypeName("#define TB_GETCOLORSCHEME CCM_GETCOLORSCHEME")]
        public const int TB_GETCOLORSCHEME = (0x2000 + 3);

        [NativeTypeName("#define TB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int TB_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define TB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int TB_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define TB_MAPACCELERATORW (WM_USER + 90)")]
        public const int TB_MAPACCELERATORW = (0x0400 + 90);

        [NativeTypeName("#define TB_MAPACCELERATOR TB_MAPACCELERATORW")]
        public const int TB_MAPACCELERATOR = (0x0400 + 90);

        [NativeTypeName("#define TBBF_LARGE 0x0001")]
        public const int TBBF_LARGE = 0x0001;

        [NativeTypeName("#define TB_GETBITMAPFLAGS (WM_USER + 41)")]
        public const int TB_GETBITMAPFLAGS = (0x0400 + 41);

        [NativeTypeName("#define TBIF_IMAGE 0x00000001")]
        public const int TBIF_IMAGE = 0x00000001;

        [NativeTypeName("#define TBIF_TEXT 0x00000002")]
        public const int TBIF_TEXT = 0x00000002;

        [NativeTypeName("#define TBIF_STATE 0x00000004")]
        public const int TBIF_STATE = 0x00000004;

        [NativeTypeName("#define TBIF_STYLE 0x00000008")]
        public const int TBIF_STYLE = 0x00000008;

        [NativeTypeName("#define TBIF_LPARAM 0x00000010")]
        public const int TBIF_LPARAM = 0x00000010;

        [NativeTypeName("#define TBIF_COMMAND 0x00000020")]
        public const int TBIF_COMMAND = 0x00000020;

        [NativeTypeName("#define TBIF_SIZE 0x00000040")]
        public const int TBIF_SIZE = 0x00000040;

        [NativeTypeName("#define TBIF_BYINDEX 0x80000000")]
        public const uint TBIF_BYINDEX = 0x80000000;

        [NativeTypeName("#define TB_GETBUTTONINFOW (WM_USER + 63)")]
        public const int TB_GETBUTTONINFOW = (0x0400 + 63);

        [NativeTypeName("#define TB_SETBUTTONINFOW (WM_USER + 64)")]
        public const int TB_SETBUTTONINFOW = (0x0400 + 64);

        [NativeTypeName("#define TB_GETBUTTONINFOA (WM_USER + 65)")]
        public const int TB_GETBUTTONINFOA = (0x0400 + 65);

        [NativeTypeName("#define TB_SETBUTTONINFOA (WM_USER + 66)")]
        public const int TB_SETBUTTONINFOA = (0x0400 + 66);

        [NativeTypeName("#define TB_GETBUTTONINFO TB_GETBUTTONINFOW")]
        public const int TB_GETBUTTONINFO = (0x0400 + 63);

        [NativeTypeName("#define TB_SETBUTTONINFO TB_SETBUTTONINFOW")]
        public const int TB_SETBUTTONINFO = (0x0400 + 64);

        [NativeTypeName("#define TB_INSERTBUTTONW (WM_USER + 67)")]
        public const int TB_INSERTBUTTONW = (0x0400 + 67);

        [NativeTypeName("#define TB_ADDBUTTONSW (WM_USER + 68)")]
        public const int TB_ADDBUTTONSW = (0x0400 + 68);

        [NativeTypeName("#define TB_HITTEST (WM_USER + 69)")]
        public const int TB_HITTEST = (0x0400 + 69);

        [NativeTypeName("#define TB_INSERTBUTTON TB_INSERTBUTTONW")]
        public const int TB_INSERTBUTTON = (0x0400 + 67);

        [NativeTypeName("#define TB_ADDBUTTONS TB_ADDBUTTONSW")]
        public const int TB_ADDBUTTONS = (0x0400 + 68);

        [NativeTypeName("#define TB_SETDRAWTEXTFLAGS (WM_USER + 70)")]
        public const int TB_SETDRAWTEXTFLAGS = (0x0400 + 70);

        [NativeTypeName("#define TB_GETSTRINGW (WM_USER + 91)")]
        public const int TB_GETSTRINGW = (0x0400 + 91);

        [NativeTypeName("#define TB_GETSTRINGA (WM_USER + 92)")]
        public const int TB_GETSTRINGA = (0x0400 + 92);

        [NativeTypeName("#define TB_GETSTRING TB_GETSTRINGW")]
        public const int TB_GETSTRING = (0x0400 + 91);

        [NativeTypeName("#define TB_SETBOUNDINGSIZE (WM_USER + 93)")]
        public const int TB_SETBOUNDINGSIZE = (0x0400 + 93);

        [NativeTypeName("#define TB_SETHOTITEM2 (WM_USER + 94)")]
        public const int TB_SETHOTITEM2 = (0x0400 + 94);

        [NativeTypeName("#define TB_HASACCELERATOR (WM_USER + 95)")]
        public const int TB_HASACCELERATOR = (0x0400 + 95);

        [NativeTypeName("#define TB_SETLISTGAP (WM_USER + 96)")]
        public const int TB_SETLISTGAP = (0x0400 + 96);

        [NativeTypeName("#define TB_GETIMAGELISTCOUNT (WM_USER + 98)")]
        public const int TB_GETIMAGELISTCOUNT = (0x0400 + 98);

        [NativeTypeName("#define TB_GETIDEALSIZE (WM_USER + 99)")]
        public const int TB_GETIDEALSIZE = (0x0400 + 99);

        [NativeTypeName("#define TBMF_PAD 0x00000001")]
        public const int TBMF_PAD = 0x00000001;

        [NativeTypeName("#define TBMF_BARPAD 0x00000002")]
        public const int TBMF_BARPAD = 0x00000002;

        [NativeTypeName("#define TBMF_BUTTONSPACING 0x00000004")]
        public const int TBMF_BUTTONSPACING = 0x00000004;

        [NativeTypeName("#define TB_GETMETRICS (WM_USER + 101)")]
        public const int TB_GETMETRICS = (0x0400 + 101);

        [NativeTypeName("#define TB_SETMETRICS (WM_USER + 102)")]
        public const int TB_SETMETRICS = (0x0400 + 102);

        [NativeTypeName("#define TB_GETITEMDROPDOWNRECT (WM_USER + 103)")]
        public const int TB_GETITEMDROPDOWNRECT = (0x0400 + 103);

        [NativeTypeName("#define TB_SETPRESSEDIMAGELIST (WM_USER + 104)")]
        public const int TB_SETPRESSEDIMAGELIST = (0x0400 + 104);

        [NativeTypeName("#define TB_GETPRESSEDIMAGELIST (WM_USER + 105)")]
        public const int TB_GETPRESSEDIMAGELIST = (0x0400 + 105);

        [NativeTypeName("#define TB_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
        public const int TB_SETWINDOWTHEME = (0x2000 + 0xb);

        [NativeTypeName("#define TBN_GETBUTTONINFOA (TBN_FIRST-0)")]
        public const uint TBN_GETBUTTONINFOA = unchecked((0U - 700U) - 0);

        [NativeTypeName("#define TBN_BEGINDRAG (TBN_FIRST-1)")]
        public const uint TBN_BEGINDRAG = unchecked((0U - 700U) - 1);

        [NativeTypeName("#define TBN_ENDDRAG (TBN_FIRST-2)")]
        public const uint TBN_ENDDRAG = unchecked((0U - 700U) - 2);

        [NativeTypeName("#define TBN_BEGINADJUST (TBN_FIRST-3)")]
        public const uint TBN_BEGINADJUST = unchecked((0U - 700U) - 3);

        [NativeTypeName("#define TBN_ENDADJUST (TBN_FIRST-4)")]
        public const uint TBN_ENDADJUST = unchecked((0U - 700U) - 4);

        [NativeTypeName("#define TBN_RESET (TBN_FIRST-5)")]
        public const uint TBN_RESET = unchecked((0U - 700U) - 5);

        [NativeTypeName("#define TBN_QUERYINSERT (TBN_FIRST-6)")]
        public const uint TBN_QUERYINSERT = unchecked((0U - 700U) - 6);

        [NativeTypeName("#define TBN_QUERYDELETE (TBN_FIRST-7)")]
        public const uint TBN_QUERYDELETE = unchecked((0U - 700U) - 7);

        [NativeTypeName("#define TBN_TOOLBARCHANGE (TBN_FIRST-8)")]
        public const uint TBN_TOOLBARCHANGE = unchecked((0U - 700U) - 8);

        [NativeTypeName("#define TBN_CUSTHELP (TBN_FIRST-9)")]
        public const uint TBN_CUSTHELP = unchecked((0U - 700U) - 9);

        [NativeTypeName("#define TBN_DROPDOWN (TBN_FIRST - 10)")]
        public const uint TBN_DROPDOWN = unchecked((0U - 700U) - 10);

        [NativeTypeName("#define TBN_GETOBJECT (TBN_FIRST - 12)")]
        public const uint TBN_GETOBJECT = unchecked((0U - 700U) - 12);

        [NativeTypeName("#define HICF_OTHER 0x00000000")]
        public const int HICF_OTHER = 0x00000000;

        [NativeTypeName("#define HICF_MOUSE 0x00000001")]
        public const int HICF_MOUSE = 0x00000001;

        [NativeTypeName("#define HICF_ARROWKEYS 0x00000002")]
        public const int HICF_ARROWKEYS = 0x00000002;

        [NativeTypeName("#define HICF_ACCELERATOR 0x00000004")]
        public const int HICF_ACCELERATOR = 0x00000004;

        [NativeTypeName("#define HICF_DUPACCEL 0x00000008")]
        public const int HICF_DUPACCEL = 0x00000008;

        [NativeTypeName("#define HICF_ENTERING 0x00000010")]
        public const int HICF_ENTERING = 0x00000010;

        [NativeTypeName("#define HICF_LEAVING 0x00000020")]
        public const int HICF_LEAVING = 0x00000020;

        [NativeTypeName("#define HICF_RESELECT 0x00000040")]
        public const int HICF_RESELECT = 0x00000040;

        [NativeTypeName("#define HICF_LMOUSE 0x00000080")]
        public const int HICF_LMOUSE = 0x00000080;

        [NativeTypeName("#define HICF_TOGGLEDROPDOWN 0x00000100")]
        public const int HICF_TOGGLEDROPDOWN = 0x00000100;

        [NativeTypeName("#define TBN_HOTITEMCHANGE (TBN_FIRST - 13)")]
        public const uint TBN_HOTITEMCHANGE = unchecked((0U - 700U) - 13);

        [NativeTypeName("#define TBN_DRAGOUT (TBN_FIRST - 14)")]
        public const uint TBN_DRAGOUT = unchecked((0U - 700U) - 14);

        [NativeTypeName("#define TBN_DELETINGBUTTON (TBN_FIRST - 15)")]
        public const uint TBN_DELETINGBUTTON = unchecked((0U - 700U) - 15);

        [NativeTypeName("#define TBN_GETDISPINFOA (TBN_FIRST - 16)")]
        public const uint TBN_GETDISPINFOA = unchecked((0U - 700U) - 16);

        [NativeTypeName("#define TBN_GETDISPINFOW (TBN_FIRST - 17)")]
        public const uint TBN_GETDISPINFOW = unchecked((0U - 700U) - 17);

        [NativeTypeName("#define TBN_GETINFOTIPA (TBN_FIRST - 18)")]
        public const uint TBN_GETINFOTIPA = unchecked((0U - 700U) - 18);

        [NativeTypeName("#define TBN_GETINFOTIPW (TBN_FIRST - 19)")]
        public const uint TBN_GETINFOTIPW = unchecked((0U - 700U) - 19);

        [NativeTypeName("#define TBN_GETBUTTONINFOW (TBN_FIRST - 20)")]
        public const uint TBN_GETBUTTONINFOW = unchecked((0U - 700U) - 20);

        [NativeTypeName("#define TBN_RESTORE (TBN_FIRST - 21)")]
        public const uint TBN_RESTORE = unchecked((0U - 700U) - 21);

        [NativeTypeName("#define TBN_SAVE (TBN_FIRST - 22)")]
        public const uint TBN_SAVE = unchecked((0U - 700U) - 22);

        [NativeTypeName("#define TBN_INITCUSTOMIZE (TBN_FIRST - 23)")]
        public const uint TBN_INITCUSTOMIZE = unchecked((0U - 700U) - 23);

        [NativeTypeName("#define TBNRF_HIDEHELP 0x00000001")]
        public const int TBNRF_HIDEHELP = 0x00000001;

        [NativeTypeName("#define TBNRF_ENDCUSTOMIZE 0x00000002")]
        public const int TBNRF_ENDCUSTOMIZE = 0x00000002;

        [NativeTypeName("#define TBN_WRAPHOTITEM (TBN_FIRST - 24)")]
        public const uint TBN_WRAPHOTITEM = unchecked((0U - 700U) - 24);

        [NativeTypeName("#define TBN_DUPACCELERATOR (TBN_FIRST - 25)")]
        public const uint TBN_DUPACCELERATOR = unchecked((0U - 700U) - 25);

        [NativeTypeName("#define TBN_WRAPACCELERATOR (TBN_FIRST - 26)")]
        public const uint TBN_WRAPACCELERATOR = unchecked((0U - 700U) - 26);

        [NativeTypeName("#define TBN_DRAGOVER (TBN_FIRST - 27)")]
        public const uint TBN_DRAGOVER = unchecked((0U - 700U) - 27);

        [NativeTypeName("#define TBN_MAPACCELERATOR (TBN_FIRST - 28)")]
        public const uint TBN_MAPACCELERATOR = unchecked((0U - 700U) - 28);

        [NativeTypeName("#define TBN_GETINFOTIP TBN_GETINFOTIPW")]
        public const uint TBN_GETINFOTIP = unchecked((0U - 700U) - 19);

        [NativeTypeName("#define TBNF_IMAGE 0x00000001")]
        public const int TBNF_IMAGE = 0x00000001;

        [NativeTypeName("#define TBNF_TEXT 0x00000002")]
        public const int TBNF_TEXT = 0x00000002;

        [NativeTypeName("#define TBNF_DI_SETITEM 0x10000000")]
        public const int TBNF_DI_SETITEM = 0x10000000;

        [NativeTypeName("#define TBN_GETDISPINFO TBN_GETDISPINFOW")]
        public const uint TBN_GETDISPINFO = unchecked((0U - 700U) - 17);

        [NativeTypeName("#define TBDDRET_DEFAULT 0")]
        public const int TBDDRET_DEFAULT = 0;

        [NativeTypeName("#define TBDDRET_NODEFAULT 1")]
        public const int TBDDRET_NODEFAULT = 1;

        [NativeTypeName("#define TBDDRET_TREATPRESSED 2")]
        public const int TBDDRET_TREATPRESSED = 2;

        [NativeTypeName("#define TBN_GETBUTTONINFO TBN_GETBUTTONINFOW")]
        public const uint TBN_GETBUTTONINFO = unchecked((0U - 700U) - 20);

        [NativeTypeName("#define REBARCLASSNAMEW L\"ReBarWindow32\"")]
        public const string REBARCLASSNAMEW = "ReBarWindow32";

        [NativeTypeName("#define REBARCLASSNAMEA \"ReBarWindow32\"")]
        public static ReadOnlySpan<byte> REBARCLASSNAMEA => new byte[] { 0x52, 0x65, 0x42, 0x61, 0x72, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define REBARCLASSNAME REBARCLASSNAMEW")]
        public const string REBARCLASSNAME = "ReBarWindow32";

        [NativeTypeName("#define RBIM_IMAGELIST 0x00000001")]
        public const int RBIM_IMAGELIST = 0x00000001;

        [NativeTypeName("#define RBS_TOOLTIPS 0x00000100")]
        public const int RBS_TOOLTIPS = 0x00000100;

        [NativeTypeName("#define RBS_VARHEIGHT 0x00000200")]
        public const int RBS_VARHEIGHT = 0x00000200;

        [NativeTypeName("#define RBS_BANDBORDERS 0x00000400")]
        public const int RBS_BANDBORDERS = 0x00000400;

        [NativeTypeName("#define RBS_FIXEDORDER 0x00000800")]
        public const int RBS_FIXEDORDER = 0x00000800;

        [NativeTypeName("#define RBS_REGISTERDROP 0x00001000")]
        public const int RBS_REGISTERDROP = 0x00001000;

        [NativeTypeName("#define RBS_AUTOSIZE 0x00002000")]
        public const int RBS_AUTOSIZE = 0x00002000;

        [NativeTypeName("#define RBS_VERTICALGRIPPER 0x00004000")]
        public const int RBS_VERTICALGRIPPER = 0x00004000;

        [NativeTypeName("#define RBS_DBLCLKTOGGLE 0x00008000")]
        public const int RBS_DBLCLKTOGGLE = 0x00008000;

        [NativeTypeName("#define RBBS_BREAK 0x00000001")]
        public const int RBBS_BREAK = 0x00000001;

        [NativeTypeName("#define RBBS_FIXEDSIZE 0x00000002")]
        public const int RBBS_FIXEDSIZE = 0x00000002;

        [NativeTypeName("#define RBBS_CHILDEDGE 0x00000004")]
        public const int RBBS_CHILDEDGE = 0x00000004;

        [NativeTypeName("#define RBBS_HIDDEN 0x00000008")]
        public const int RBBS_HIDDEN = 0x00000008;

        [NativeTypeName("#define RBBS_NOVERT 0x00000010")]
        public const int RBBS_NOVERT = 0x00000010;

        [NativeTypeName("#define RBBS_FIXEDBMP 0x00000020")]
        public const int RBBS_FIXEDBMP = 0x00000020;

        [NativeTypeName("#define RBBS_VARIABLEHEIGHT 0x00000040")]
        public const int RBBS_VARIABLEHEIGHT = 0x00000040;

        [NativeTypeName("#define RBBS_GRIPPERALWAYS 0x00000080")]
        public const int RBBS_GRIPPERALWAYS = 0x00000080;

        [NativeTypeName("#define RBBS_NOGRIPPER 0x00000100")]
        public const int RBBS_NOGRIPPER = 0x00000100;

        [NativeTypeName("#define RBBS_USECHEVRON 0x00000200")]
        public const int RBBS_USECHEVRON = 0x00000200;

        [NativeTypeName("#define RBBS_HIDETITLE 0x00000400")]
        public const int RBBS_HIDETITLE = 0x00000400;

        [NativeTypeName("#define RBBS_TOPALIGN 0x00000800")]
        public const int RBBS_TOPALIGN = 0x00000800;

        [NativeTypeName("#define RBBIM_STYLE 0x00000001")]
        public const int RBBIM_STYLE = 0x00000001;

        [NativeTypeName("#define RBBIM_COLORS 0x00000002")]
        public const int RBBIM_COLORS = 0x00000002;

        [NativeTypeName("#define RBBIM_TEXT 0x00000004")]
        public const int RBBIM_TEXT = 0x00000004;

        [NativeTypeName("#define RBBIM_IMAGE 0x00000008")]
        public const int RBBIM_IMAGE = 0x00000008;

        [NativeTypeName("#define RBBIM_CHILD 0x00000010")]
        public const int RBBIM_CHILD = 0x00000010;

        [NativeTypeName("#define RBBIM_CHILDSIZE 0x00000020")]
        public const int RBBIM_CHILDSIZE = 0x00000020;

        [NativeTypeName("#define RBBIM_SIZE 0x00000040")]
        public const int RBBIM_SIZE = 0x00000040;

        [NativeTypeName("#define RBBIM_BACKGROUND 0x00000080")]
        public const int RBBIM_BACKGROUND = 0x00000080;

        [NativeTypeName("#define RBBIM_ID 0x00000100")]
        public const int RBBIM_ID = 0x00000100;

        [NativeTypeName("#define RBBIM_IDEALSIZE 0x00000200")]
        public const int RBBIM_IDEALSIZE = 0x00000200;

        [NativeTypeName("#define RBBIM_LPARAM 0x00000400")]
        public const int RBBIM_LPARAM = 0x00000400;

        [NativeTypeName("#define RBBIM_HEADERSIZE 0x00000800")]
        public const int RBBIM_HEADERSIZE = 0x00000800;

        [NativeTypeName("#define RBBIM_CHEVRONLOCATION 0x00001000")]
        public const int RBBIM_CHEVRONLOCATION = 0x00001000;

        [NativeTypeName("#define RBBIM_CHEVRONSTATE 0x00002000")]
        public const int RBBIM_CHEVRONSTATE = 0x00002000;

        [NativeTypeName("#define RB_INSERTBANDA (WM_USER +  1)")]
        public const int RB_INSERTBANDA = (0x0400 + 1);

        [NativeTypeName("#define RB_DELETEBAND (WM_USER +  2)")]
        public const int RB_DELETEBAND = (0x0400 + 2);

        [NativeTypeName("#define RB_GETBARINFO (WM_USER +  3)")]
        public const int RB_GETBARINFO = (0x0400 + 3);

        [NativeTypeName("#define RB_SETBARINFO (WM_USER +  4)")]
        public const int RB_SETBARINFO = (0x0400 + 4);

        [NativeTypeName("#define RB_SETBANDINFOA (WM_USER +  6)")]
        public const int RB_SETBANDINFOA = (0x0400 + 6);

        [NativeTypeName("#define RB_SETPARENT (WM_USER +  7)")]
        public const int RB_SETPARENT = (0x0400 + 7);

        [NativeTypeName("#define RB_HITTEST (WM_USER +  8)")]
        public const int RB_HITTEST = (0x0400 + 8);

        [NativeTypeName("#define RB_GETRECT (WM_USER +  9)")]
        public const int RB_GETRECT = (0x0400 + 9);

        [NativeTypeName("#define RB_INSERTBANDW (WM_USER +  10)")]
        public const int RB_INSERTBANDW = (0x0400 + 10);

        [NativeTypeName("#define RB_SETBANDINFOW (WM_USER +  11)")]
        public const int RB_SETBANDINFOW = (0x0400 + 11);

        [NativeTypeName("#define RB_GETBANDCOUNT (WM_USER +  12)")]
        public const int RB_GETBANDCOUNT = (0x0400 + 12);

        [NativeTypeName("#define RB_GETROWCOUNT (WM_USER +  13)")]
        public const int RB_GETROWCOUNT = (0x0400 + 13);

        [NativeTypeName("#define RB_GETROWHEIGHT (WM_USER +  14)")]
        public const int RB_GETROWHEIGHT = (0x0400 + 14);

        [NativeTypeName("#define RB_IDTOINDEX (WM_USER +  16)")]
        public const int RB_IDTOINDEX = (0x0400 + 16);

        [NativeTypeName("#define RB_GETTOOLTIPS (WM_USER +  17)")]
        public const int RB_GETTOOLTIPS = (0x0400 + 17);

        [NativeTypeName("#define RB_SETTOOLTIPS (WM_USER +  18)")]
        public const int RB_SETTOOLTIPS = (0x0400 + 18);

        [NativeTypeName("#define RB_SETBKCOLOR (WM_USER +  19)")]
        public const int RB_SETBKCOLOR = (0x0400 + 19);

        [NativeTypeName("#define RB_GETBKCOLOR (WM_USER +  20)")]
        public const int RB_GETBKCOLOR = (0x0400 + 20);

        [NativeTypeName("#define RB_SETTEXTCOLOR (WM_USER +  21)")]
        public const int RB_SETTEXTCOLOR = (0x0400 + 21);

        [NativeTypeName("#define RB_GETTEXTCOLOR (WM_USER +  22)")]
        public const int RB_GETTEXTCOLOR = (0x0400 + 22);

        [NativeTypeName("#define RBSTR_CHANGERECT 0x0001")]
        public const int RBSTR_CHANGERECT = 0x0001;

        [NativeTypeName("#define RB_SIZETORECT (WM_USER +  23)")]
        public const int RB_SIZETORECT = (0x0400 + 23);

        [NativeTypeName("#define RB_SETCOLORSCHEME CCM_SETCOLORSCHEME")]
        public const int RB_SETCOLORSCHEME = (0x2000 + 2);

        [NativeTypeName("#define RB_GETCOLORSCHEME CCM_GETCOLORSCHEME")]
        public const int RB_GETCOLORSCHEME = (0x2000 + 3);

        [NativeTypeName("#define RB_INSERTBAND RB_INSERTBANDW")]
        public const int RB_INSERTBAND = (0x0400 + 10);

        [NativeTypeName("#define RB_SETBANDINFO RB_SETBANDINFOW")]
        public const int RB_SETBANDINFO = (0x0400 + 11);

        [NativeTypeName("#define RB_BEGINDRAG (WM_USER + 24)")]
        public const int RB_BEGINDRAG = (0x0400 + 24);

        [NativeTypeName("#define RB_ENDDRAG (WM_USER + 25)")]
        public const int RB_ENDDRAG = (0x0400 + 25);

        [NativeTypeName("#define RB_DRAGMOVE (WM_USER + 26)")]
        public const int RB_DRAGMOVE = (0x0400 + 26);

        [NativeTypeName("#define RB_GETBARHEIGHT (WM_USER + 27)")]
        public const int RB_GETBARHEIGHT = (0x0400 + 27);

        [NativeTypeName("#define RB_GETBANDINFOW (WM_USER + 28)")]
        public const int RB_GETBANDINFOW = (0x0400 + 28);

        [NativeTypeName("#define RB_GETBANDINFOA (WM_USER + 29)")]
        public const int RB_GETBANDINFOA = (0x0400 + 29);

        [NativeTypeName("#define RB_GETBANDINFO RB_GETBANDINFOW")]
        public const int RB_GETBANDINFO = (0x0400 + 28);

        [NativeTypeName("#define RB_MINIMIZEBAND (WM_USER + 30)")]
        public const int RB_MINIMIZEBAND = (0x0400 + 30);

        [NativeTypeName("#define RB_MAXIMIZEBAND (WM_USER + 31)")]
        public const int RB_MAXIMIZEBAND = (0x0400 + 31);

        [NativeTypeName("#define RB_GETDROPTARGET (CCM_GETDROPTARGET)")]
        public const int RB_GETDROPTARGET = ((0x2000 + 4));

        [NativeTypeName("#define RB_GETBANDBORDERS (WM_USER + 34)")]
        public const int RB_GETBANDBORDERS = (0x0400 + 34);

        [NativeTypeName("#define RB_SHOWBAND (WM_USER + 35)")]
        public const int RB_SHOWBAND = (0x0400 + 35);

        [NativeTypeName("#define RB_SETPALETTE (WM_USER + 37)")]
        public const int RB_SETPALETTE = (0x0400 + 37);

        [NativeTypeName("#define RB_GETPALETTE (WM_USER + 38)")]
        public const int RB_GETPALETTE = (0x0400 + 38);

        [NativeTypeName("#define RB_MOVEBAND (WM_USER + 39)")]
        public const int RB_MOVEBAND = (0x0400 + 39);

        [NativeTypeName("#define RB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int RB_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define RB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int RB_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define RB_GETBANDMARGINS (WM_USER + 40)")]
        public const int RB_GETBANDMARGINS = (0x0400 + 40);

        [NativeTypeName("#define RB_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
        public const int RB_SETWINDOWTHEME = (0x2000 + 0xb);

        [NativeTypeName("#define RB_SETEXTENDEDSTYLE (WM_USER + 41)")]
        public const int RB_SETEXTENDEDSTYLE = (0x0400 + 41);

        [NativeTypeName("#define RB_GETEXTENDEDSTYLE (WM_USER + 42)")]
        public const int RB_GETEXTENDEDSTYLE = (0x0400 + 42);

        [NativeTypeName("#define RB_PUSHCHEVRON (WM_USER + 43)")]
        public const int RB_PUSHCHEVRON = (0x0400 + 43);

        [NativeTypeName("#define RB_SETBANDWIDTH (WM_USER + 44)")]
        public const int RB_SETBANDWIDTH = (0x0400 + 44);

        [NativeTypeName("#define RBN_HEIGHTCHANGE (RBN_FIRST - 0)")]
        public const uint RBN_HEIGHTCHANGE = unchecked((0U - 831U) - 0);

        [NativeTypeName("#define RBN_GETOBJECT (RBN_FIRST - 1)")]
        public const uint RBN_GETOBJECT = unchecked((0U - 831U) - 1);

        [NativeTypeName("#define RBN_LAYOUTCHANGED (RBN_FIRST - 2)")]
        public const uint RBN_LAYOUTCHANGED = unchecked((0U - 831U) - 2);

        [NativeTypeName("#define RBN_AUTOSIZE (RBN_FIRST - 3)")]
        public const uint RBN_AUTOSIZE = unchecked((0U - 831U) - 3);

        [NativeTypeName("#define RBN_BEGINDRAG (RBN_FIRST - 4)")]
        public const uint RBN_BEGINDRAG = unchecked((0U - 831U) - 4);

        [NativeTypeName("#define RBN_ENDDRAG (RBN_FIRST - 5)")]
        public const uint RBN_ENDDRAG = unchecked((0U - 831U) - 5);

        [NativeTypeName("#define RBN_DELETINGBAND (RBN_FIRST - 6)")]
        public const uint RBN_DELETINGBAND = unchecked((0U - 831U) - 6);

        [NativeTypeName("#define RBN_DELETEDBAND (RBN_FIRST - 7)")]
        public const uint RBN_DELETEDBAND = unchecked((0U - 831U) - 7);

        [NativeTypeName("#define RBN_CHILDSIZE (RBN_FIRST - 8)")]
        public const uint RBN_CHILDSIZE = unchecked((0U - 831U) - 8);

        [NativeTypeName("#define RBN_CHEVRONPUSHED (RBN_FIRST - 10)")]
        public const uint RBN_CHEVRONPUSHED = unchecked((0U - 831U) - 10);

        [NativeTypeName("#define RBN_SPLITTERDRAG (RBN_FIRST - 11)")]
        public const uint RBN_SPLITTERDRAG = unchecked((0U - 831U) - 11);

        [NativeTypeName("#define RBN_MINMAX (RBN_FIRST - 21)")]
        public const uint RBN_MINMAX = unchecked((0U - 831U) - 21);

        [NativeTypeName("#define RBN_AUTOBREAK (RBN_FIRST - 22)")]
        public const uint RBN_AUTOBREAK = unchecked((0U - 831U) - 22);

        [NativeTypeName("#define RBNM_ID 0x00000001")]
        public const int RBNM_ID = 0x00000001;

        [NativeTypeName("#define RBNM_STYLE 0x00000002")]
        public const int RBNM_STYLE = 0x00000002;

        [NativeTypeName("#define RBNM_LPARAM 0x00000004")]
        public const int RBNM_LPARAM = 0x00000004;

        [NativeTypeName("#define RBAB_AUTOSIZE 0x0001")]
        public const int RBAB_AUTOSIZE = 0x0001;

        [NativeTypeName("#define RBAB_ADDBAND 0x0002")]
        public const int RBAB_ADDBAND = 0x0002;

        [NativeTypeName("#define RBHT_NOWHERE 0x0001")]
        public const int RBHT_NOWHERE = 0x0001;

        [NativeTypeName("#define RBHT_CAPTION 0x0002")]
        public const int RBHT_CAPTION = 0x0002;

        [NativeTypeName("#define RBHT_CLIENT 0x0003")]
        public const int RBHT_CLIENT = 0x0003;

        [NativeTypeName("#define RBHT_GRABBER 0x0004")]
        public const int RBHT_GRABBER = 0x0004;

        [NativeTypeName("#define RBHT_CHEVRON 0x0008")]
        public const int RBHT_CHEVRON = 0x0008;

        [NativeTypeName("#define RBHT_SPLITTER 0x0010")]
        public const int RBHT_SPLITTER = 0x0010;

        [NativeTypeName("#define TOOLTIPS_CLASSW L\"tooltips_class32\"")]
        public const string TOOLTIPS_CLASSW = "tooltips_class32";

        [NativeTypeName("#define TOOLTIPS_CLASSA \"tooltips_class32\"")]
        public static ReadOnlySpan<byte> TOOLTIPS_CLASSA => new byte[] { 0x74, 0x6F, 0x6F, 0x6C, 0x74, 0x69, 0x70, 0x73, 0x5F, 0x63, 0x6C, 0x61, 0x73, 0x73, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define TOOLTIPS_CLASS TOOLTIPS_CLASSW")]
        public const string TOOLTIPS_CLASS = "tooltips_class32";

        [NativeTypeName("#define TTS_ALWAYSTIP 0x01")]
        public const int TTS_ALWAYSTIP = 0x01;

        [NativeTypeName("#define TTS_NOPREFIX 0x02")]
        public const int TTS_NOPREFIX = 0x02;

        [NativeTypeName("#define TTS_NOANIMATE 0x10")]
        public const int TTS_NOANIMATE = 0x10;

        [NativeTypeName("#define TTS_NOFADE 0x20")]
        public const int TTS_NOFADE = 0x20;

        [NativeTypeName("#define TTS_BALLOON 0x40")]
        public const int TTS_BALLOON = 0x40;

        [NativeTypeName("#define TTS_CLOSE 0x80")]
        public const int TTS_CLOSE = 0x80;

        [NativeTypeName("#define TTS_USEVISUALSTYLE 0x100")]
        public const int TTS_USEVISUALSTYLE = 0x100;

        [NativeTypeName("#define TTF_IDISHWND 0x0001")]
        public const int TTF_IDISHWND = 0x0001;

        [NativeTypeName("#define TTF_CENTERTIP 0x0002")]
        public const int TTF_CENTERTIP = 0x0002;

        [NativeTypeName("#define TTF_RTLREADING 0x0004")]
        public const int TTF_RTLREADING = 0x0004;

        [NativeTypeName("#define TTF_SUBCLASS 0x0010")]
        public const int TTF_SUBCLASS = 0x0010;

        [NativeTypeName("#define TTF_TRACK 0x0020")]
        public const int TTF_TRACK = 0x0020;

        [NativeTypeName("#define TTF_ABSOLUTE 0x0080")]
        public const int TTF_ABSOLUTE = 0x0080;

        [NativeTypeName("#define TTF_TRANSPARENT 0x0100")]
        public const int TTF_TRANSPARENT = 0x0100;

        [NativeTypeName("#define TTF_PARSELINKS 0x1000")]
        public const int TTF_PARSELINKS = 0x1000;

        [NativeTypeName("#define TTF_DI_SETITEM 0x8000")]
        public const int TTF_DI_SETITEM = 0x8000;

        [NativeTypeName("#define TTDT_AUTOMATIC 0")]
        public const int TTDT_AUTOMATIC = 0;

        [NativeTypeName("#define TTDT_RESHOW 1")]
        public const int TTDT_RESHOW = 1;

        [NativeTypeName("#define TTDT_AUTOPOP 2")]
        public const int TTDT_AUTOPOP = 2;

        [NativeTypeName("#define TTDT_INITIAL 3")]
        public const int TTDT_INITIAL = 3;

        [NativeTypeName("#define TTI_NONE 0")]
        public const int TTI_NONE = 0;

        [NativeTypeName("#define TTI_INFO 1")]
        public const int TTI_INFO = 1;

        [NativeTypeName("#define TTI_WARNING 2")]
        public const int TTI_WARNING = 2;

        [NativeTypeName("#define TTI_ERROR 3")]
        public const int TTI_ERROR = 3;

        [NativeTypeName("#define TTI_INFO_LARGE 4")]
        public const int TTI_INFO_LARGE = 4;

        [NativeTypeName("#define TTI_WARNING_LARGE 5")]
        public const int TTI_WARNING_LARGE = 5;

        [NativeTypeName("#define TTI_ERROR_LARGE 6")]
        public const int TTI_ERROR_LARGE = 6;

        [NativeTypeName("#define TTM_ACTIVATE (WM_USER + 1)")]
        public const int TTM_ACTIVATE = (0x0400 + 1);

        [NativeTypeName("#define TTM_SETDELAYTIME (WM_USER + 3)")]
        public const int TTM_SETDELAYTIME = (0x0400 + 3);

        [NativeTypeName("#define TTM_ADDTOOLA (WM_USER + 4)")]
        public const int TTM_ADDTOOLA = (0x0400 + 4);

        [NativeTypeName("#define TTM_ADDTOOLW (WM_USER + 50)")]
        public const int TTM_ADDTOOLW = (0x0400 + 50);

        [NativeTypeName("#define TTM_DELTOOLA (WM_USER + 5)")]
        public const int TTM_DELTOOLA = (0x0400 + 5);

        [NativeTypeName("#define TTM_DELTOOLW (WM_USER + 51)")]
        public const int TTM_DELTOOLW = (0x0400 + 51);

        [NativeTypeName("#define TTM_NEWTOOLRECTA (WM_USER + 6)")]
        public const int TTM_NEWTOOLRECTA = (0x0400 + 6);

        [NativeTypeName("#define TTM_NEWTOOLRECTW (WM_USER + 52)")]
        public const int TTM_NEWTOOLRECTW = (0x0400 + 52);

        [NativeTypeName("#define TTM_RELAYEVENT (WM_USER + 7)")]
        public const int TTM_RELAYEVENT = (0x0400 + 7);

        [NativeTypeName("#define TTM_GETTOOLINFOA (WM_USER + 8)")]
        public const int TTM_GETTOOLINFOA = (0x0400 + 8);

        [NativeTypeName("#define TTM_GETTOOLINFOW (WM_USER + 53)")]
        public const int TTM_GETTOOLINFOW = (0x0400 + 53);

        [NativeTypeName("#define TTM_SETTOOLINFOA (WM_USER + 9)")]
        public const int TTM_SETTOOLINFOA = (0x0400 + 9);

        [NativeTypeName("#define TTM_SETTOOLINFOW (WM_USER + 54)")]
        public const int TTM_SETTOOLINFOW = (0x0400 + 54);

        [NativeTypeName("#define TTM_HITTESTA (WM_USER +10)")]
        public const int TTM_HITTESTA = (0x0400 + 10);

        [NativeTypeName("#define TTM_HITTESTW (WM_USER +55)")]
        public const int TTM_HITTESTW = (0x0400 + 55);

        [NativeTypeName("#define TTM_GETTEXTA (WM_USER +11)")]
        public const int TTM_GETTEXTA = (0x0400 + 11);

        [NativeTypeName("#define TTM_GETTEXTW (WM_USER +56)")]
        public const int TTM_GETTEXTW = (0x0400 + 56);

        [NativeTypeName("#define TTM_UPDATETIPTEXTA (WM_USER +12)")]
        public const int TTM_UPDATETIPTEXTA = (0x0400 + 12);

        [NativeTypeName("#define TTM_UPDATETIPTEXTW (WM_USER +57)")]
        public const int TTM_UPDATETIPTEXTW = (0x0400 + 57);

        [NativeTypeName("#define TTM_GETTOOLCOUNT (WM_USER +13)")]
        public const int TTM_GETTOOLCOUNT = (0x0400 + 13);

        [NativeTypeName("#define TTM_ENUMTOOLSA (WM_USER +14)")]
        public const int TTM_ENUMTOOLSA = (0x0400 + 14);

        [NativeTypeName("#define TTM_ENUMTOOLSW (WM_USER +58)")]
        public const int TTM_ENUMTOOLSW = (0x0400 + 58);

        [NativeTypeName("#define TTM_GETCURRENTTOOLA (WM_USER + 15)")]
        public const int TTM_GETCURRENTTOOLA = (0x0400 + 15);

        [NativeTypeName("#define TTM_GETCURRENTTOOLW (WM_USER + 59)")]
        public const int TTM_GETCURRENTTOOLW = (0x0400 + 59);

        [NativeTypeName("#define TTM_WINDOWFROMPOINT (WM_USER + 16)")]
        public const int TTM_WINDOWFROMPOINT = (0x0400 + 16);

        [NativeTypeName("#define TTM_TRACKACTIVATE (WM_USER + 17)")]
        public const int TTM_TRACKACTIVATE = (0x0400 + 17);

        [NativeTypeName("#define TTM_TRACKPOSITION (WM_USER + 18)")]
        public const int TTM_TRACKPOSITION = (0x0400 + 18);

        [NativeTypeName("#define TTM_SETTIPBKCOLOR (WM_USER + 19)")]
        public const int TTM_SETTIPBKCOLOR = (0x0400 + 19);

        [NativeTypeName("#define TTM_SETTIPTEXTCOLOR (WM_USER + 20)")]
        public const int TTM_SETTIPTEXTCOLOR = (0x0400 + 20);

        [NativeTypeName("#define TTM_GETDELAYTIME (WM_USER + 21)")]
        public const int TTM_GETDELAYTIME = (0x0400 + 21);

        [NativeTypeName("#define TTM_GETTIPBKCOLOR (WM_USER + 22)")]
        public const int TTM_GETTIPBKCOLOR = (0x0400 + 22);

        [NativeTypeName("#define TTM_GETTIPTEXTCOLOR (WM_USER + 23)")]
        public const int TTM_GETTIPTEXTCOLOR = (0x0400 + 23);

        [NativeTypeName("#define TTM_SETMAXTIPWIDTH (WM_USER + 24)")]
        public const int TTM_SETMAXTIPWIDTH = (0x0400 + 24);

        [NativeTypeName("#define TTM_GETMAXTIPWIDTH (WM_USER + 25)")]
        public const int TTM_GETMAXTIPWIDTH = (0x0400 + 25);

        [NativeTypeName("#define TTM_SETMARGIN (WM_USER + 26)")]
        public const int TTM_SETMARGIN = (0x0400 + 26);

        [NativeTypeName("#define TTM_GETMARGIN (WM_USER + 27)")]
        public const int TTM_GETMARGIN = (0x0400 + 27);

        [NativeTypeName("#define TTM_POP (WM_USER + 28)")]
        public const int TTM_POP = (0x0400 + 28);

        [NativeTypeName("#define TTM_UPDATE (WM_USER + 29)")]
        public const int TTM_UPDATE = (0x0400 + 29);

        [NativeTypeName("#define TTM_GETBUBBLESIZE (WM_USER + 30)")]
        public const int TTM_GETBUBBLESIZE = (0x0400 + 30);

        [NativeTypeName("#define TTM_ADJUSTRECT (WM_USER + 31)")]
        public const int TTM_ADJUSTRECT = (0x0400 + 31);

        [NativeTypeName("#define TTM_SETTITLEA (WM_USER + 32)")]
        public const int TTM_SETTITLEA = (0x0400 + 32);

        [NativeTypeName("#define TTM_SETTITLEW (WM_USER + 33)")]
        public const int TTM_SETTITLEW = (0x0400 + 33);

        [NativeTypeName("#define TTM_POPUP (WM_USER + 34)")]
        public const int TTM_POPUP = (0x0400 + 34);

        [NativeTypeName("#define TTM_GETTITLE (WM_USER + 35)")]
        public const int TTM_GETTITLE = (0x0400 + 35);

        [NativeTypeName("#define TTM_ADDTOOL TTM_ADDTOOLW")]
        public const int TTM_ADDTOOL = (0x0400 + 50);

        [NativeTypeName("#define TTM_DELTOOL TTM_DELTOOLW")]
        public const int TTM_DELTOOL = (0x0400 + 51);

        [NativeTypeName("#define TTM_NEWTOOLRECT TTM_NEWTOOLRECTW")]
        public const int TTM_NEWTOOLRECT = (0x0400 + 52);

        [NativeTypeName("#define TTM_GETTOOLINFO TTM_GETTOOLINFOW")]
        public const int TTM_GETTOOLINFO = (0x0400 + 53);

        [NativeTypeName("#define TTM_SETTOOLINFO TTM_SETTOOLINFOW")]
        public const int TTM_SETTOOLINFO = (0x0400 + 54);

        [NativeTypeName("#define TTM_HITTEST TTM_HITTESTW")]
        public const int TTM_HITTEST = (0x0400 + 55);

        [NativeTypeName("#define TTM_GETTEXT TTM_GETTEXTW")]
        public const int TTM_GETTEXT = (0x0400 + 56);

        [NativeTypeName("#define TTM_UPDATETIPTEXT TTM_UPDATETIPTEXTW")]
        public const int TTM_UPDATETIPTEXT = (0x0400 + 57);

        [NativeTypeName("#define TTM_ENUMTOOLS TTM_ENUMTOOLSW")]
        public const int TTM_ENUMTOOLS = (0x0400 + 58);

        [NativeTypeName("#define TTM_GETCURRENTTOOL TTM_GETCURRENTTOOLW")]
        public const int TTM_GETCURRENTTOOL = (0x0400 + 59);

        [NativeTypeName("#define TTM_SETTITLE TTM_SETTITLEW")]
        public const int TTM_SETTITLE = (0x0400 + 33);

        [NativeTypeName("#define TTM_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
        public const int TTM_SETWINDOWTHEME = (0x2000 + 0xb);

        [NativeTypeName("#define TTN_GETDISPINFOA (TTN_FIRST - 0)")]
        public const uint TTN_GETDISPINFOA = unchecked((0U - 520U) - 0);

        [NativeTypeName("#define TTN_GETDISPINFOW (TTN_FIRST - 10)")]
        public const uint TTN_GETDISPINFOW = unchecked((0U - 520U) - 10);

        [NativeTypeName("#define TTN_SHOW (TTN_FIRST - 1)")]
        public const uint TTN_SHOW = unchecked((0U - 520U) - 1);

        [NativeTypeName("#define TTN_POP (TTN_FIRST - 2)")]
        public const uint TTN_POP = unchecked((0U - 520U) - 2);

        [NativeTypeName("#define TTN_LINKCLICK (TTN_FIRST - 3)")]
        public const uint TTN_LINKCLICK = unchecked((0U - 520U) - 3);

        [NativeTypeName("#define TTN_GETDISPINFO TTN_GETDISPINFOW")]
        public const uint TTN_GETDISPINFO = unchecked((0U - 520U) - 10);

        [NativeTypeName("#define TTN_NEEDTEXT TTN_GETDISPINFO")]
        public const uint TTN_NEEDTEXT = unchecked((0U - 520U) - 10);

        [NativeTypeName("#define TTN_NEEDTEXTA TTN_GETDISPINFOA")]
        public const uint TTN_NEEDTEXTA = unchecked((0U - 520U) - 0);

        [NativeTypeName("#define TTN_NEEDTEXTW TTN_GETDISPINFOW")]
        public const uint TTN_NEEDTEXTW = unchecked((0U - 520U) - 10);

        [NativeTypeName("#define SBARS_SIZEGRIP 0x0100")]
        public const int SBARS_SIZEGRIP = 0x0100;

        [NativeTypeName("#define SBARS_TOOLTIPS 0x0800")]
        public const int SBARS_TOOLTIPS = 0x0800;

        [NativeTypeName("#define SBT_TOOLTIPS 0x0800")]
        public const int SBT_TOOLTIPS = 0x0800;

        [NativeTypeName("#define CreateStatusWindow CreateStatusWindowW")]
        public static delegate*<int, ushort*, IntPtr, uint, IntPtr> CreateStatusWindow => &CreateStatusWindowW;

        [NativeTypeName("#define DrawStatusText DrawStatusTextW")]
        public static delegate*<IntPtr, RECT*, ushort*, uint, void> DrawStatusText => &DrawStatusTextW;

        [NativeTypeName("#define STATUSCLASSNAMEW L\"msctls_statusbar32\"")]
        public const string STATUSCLASSNAMEW = "msctls_statusbar32";

        [NativeTypeName("#define STATUSCLASSNAMEA \"msctls_statusbar32\"")]
        public static ReadOnlySpan<byte> STATUSCLASSNAMEA => new byte[] { 0x6D, 0x73, 0x63, 0x74, 0x6C, 0x73, 0x5F, 0x73, 0x74, 0x61, 0x74, 0x75, 0x73, 0x62, 0x61, 0x72, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define STATUSCLASSNAME STATUSCLASSNAMEW")]
        public const string STATUSCLASSNAME = "msctls_statusbar32";

        [NativeTypeName("#define SB_SETTEXTA (WM_USER+1)")]
        public const int SB_SETTEXTA = (0x0400 + 1);

        [NativeTypeName("#define SB_SETTEXTW (WM_USER+11)")]
        public const int SB_SETTEXTW = (0x0400 + 11);

        [NativeTypeName("#define SB_GETTEXTA (WM_USER+2)")]
        public const int SB_GETTEXTA = (0x0400 + 2);

        [NativeTypeName("#define SB_GETTEXTW (WM_USER+13)")]
        public const int SB_GETTEXTW = (0x0400 + 13);

        [NativeTypeName("#define SB_GETTEXTLENGTHA (WM_USER+3)")]
        public const int SB_GETTEXTLENGTHA = (0x0400 + 3);

        [NativeTypeName("#define SB_GETTEXTLENGTHW (WM_USER+12)")]
        public const int SB_GETTEXTLENGTHW = (0x0400 + 12);

        [NativeTypeName("#define SB_GETTEXT SB_GETTEXTW")]
        public const int SB_GETTEXT = (0x0400 + 13);

        [NativeTypeName("#define SB_SETTEXT SB_SETTEXTW")]
        public const int SB_SETTEXT = (0x0400 + 11);

        [NativeTypeName("#define SB_GETTEXTLENGTH SB_GETTEXTLENGTHW")]
        public const int SB_GETTEXTLENGTH = (0x0400 + 12);

        [NativeTypeName("#define SB_SETTIPTEXT SB_SETTIPTEXTW")]
        public const int SB_SETTIPTEXT = (0x0400 + 17);

        [NativeTypeName("#define SB_GETTIPTEXT SB_GETTIPTEXTW")]
        public const int SB_GETTIPTEXT = (0x0400 + 19);

        [NativeTypeName("#define SB_SETPARTS (WM_USER+4)")]
        public const int SB_SETPARTS = (0x0400 + 4);

        [NativeTypeName("#define SB_GETPARTS (WM_USER+6)")]
        public const int SB_GETPARTS = (0x0400 + 6);

        [NativeTypeName("#define SB_GETBORDERS (WM_USER+7)")]
        public const int SB_GETBORDERS = (0x0400 + 7);

        [NativeTypeName("#define SB_SETMINHEIGHT (WM_USER+8)")]
        public const int SB_SETMINHEIGHT = (0x0400 + 8);

        [NativeTypeName("#define SB_SIMPLE (WM_USER+9)")]
        public const int SB_SIMPLE = (0x0400 + 9);

        [NativeTypeName("#define SB_GETRECT (WM_USER+10)")]
        public const int SB_GETRECT = (0x0400 + 10);

        [NativeTypeName("#define SB_ISSIMPLE (WM_USER+14)")]
        public const int SB_ISSIMPLE = (0x0400 + 14);

        [NativeTypeName("#define SB_SETICON (WM_USER+15)")]
        public const int SB_SETICON = (0x0400 + 15);

        [NativeTypeName("#define SB_SETTIPTEXTA (WM_USER+16)")]
        public const int SB_SETTIPTEXTA = (0x0400 + 16);

        [NativeTypeName("#define SB_SETTIPTEXTW (WM_USER+17)")]
        public const int SB_SETTIPTEXTW = (0x0400 + 17);

        [NativeTypeName("#define SB_GETTIPTEXTA (WM_USER+18)")]
        public const int SB_GETTIPTEXTA = (0x0400 + 18);

        [NativeTypeName("#define SB_GETTIPTEXTW (WM_USER+19)")]
        public const int SB_GETTIPTEXTW = (0x0400 + 19);

        [NativeTypeName("#define SB_GETICON (WM_USER+20)")]
        public const int SB_GETICON = (0x0400 + 20);

        [NativeTypeName("#define SB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int SB_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define SB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int SB_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define SBT_OWNERDRAW 0x1000")]
        public const int SBT_OWNERDRAW = 0x1000;

        [NativeTypeName("#define SBT_NOBORDERS 0x0100")]
        public const int SBT_NOBORDERS = 0x0100;

        [NativeTypeName("#define SBT_POPOUT 0x0200")]
        public const int SBT_POPOUT = 0x0200;

        [NativeTypeName("#define SBT_RTLREADING 0x0400")]
        public const int SBT_RTLREADING = 0x0400;

        [NativeTypeName("#define SBT_NOTABPARSING 0x0800")]
        public const int SBT_NOTABPARSING = 0x0800;

        [NativeTypeName("#define SB_SETBKCOLOR CCM_SETBKCOLOR")]
        public const int SB_SETBKCOLOR = (0x2000 + 1);

        [NativeTypeName("#define SBN_SIMPLEMODECHANGE (SBN_FIRST - 0)")]
        public const uint SBN_SIMPLEMODECHANGE = unchecked((0U - 880U) - 0);

        [NativeTypeName("#define SB_SIMPLEID 0x00ff")]
        public const int SB_SIMPLEID = 0x00ff;

        [NativeTypeName("#define MINSYSCOMMAND SC_SIZE")]
        public const int MINSYSCOMMAND = 0xF000;

        [NativeTypeName("#define TRACKBAR_CLASSA \"msctls_trackbar32\"")]
        public static ReadOnlySpan<byte> TRACKBAR_CLASSA => new byte[] { 0x6D, 0x73, 0x63, 0x74, 0x6C, 0x73, 0x5F, 0x74, 0x72, 0x61, 0x63, 0x6B, 0x62, 0x61, 0x72, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define TRACKBAR_CLASSW L\"msctls_trackbar32\"")]
        public const string TRACKBAR_CLASSW = "msctls_trackbar32";

        [NativeTypeName("#define TRACKBAR_CLASS TRACKBAR_CLASSW")]
        public const string TRACKBAR_CLASS = "msctls_trackbar32";

        [NativeTypeName("#define TBS_AUTOTICKS 0x0001")]
        public const int TBS_AUTOTICKS = 0x0001;

        [NativeTypeName("#define TBS_VERT 0x0002")]
        public const int TBS_VERT = 0x0002;

        [NativeTypeName("#define TBS_HORZ 0x0000")]
        public const int TBS_HORZ = 0x0000;

        [NativeTypeName("#define TBS_TOP 0x0004")]
        public const int TBS_TOP = 0x0004;

        [NativeTypeName("#define TBS_BOTTOM 0x0000")]
        public const int TBS_BOTTOM = 0x0000;

        [NativeTypeName("#define TBS_LEFT 0x0004")]
        public const int TBS_LEFT = 0x0004;

        [NativeTypeName("#define TBS_RIGHT 0x0000")]
        public const int TBS_RIGHT = 0x0000;

        [NativeTypeName("#define TBS_BOTH 0x0008")]
        public const int TBS_BOTH = 0x0008;

        [NativeTypeName("#define TBS_NOTICKS 0x0010")]
        public const int TBS_NOTICKS = 0x0010;

        [NativeTypeName("#define TBS_ENABLESELRANGE 0x0020")]
        public const int TBS_ENABLESELRANGE = 0x0020;

        [NativeTypeName("#define TBS_FIXEDLENGTH 0x0040")]
        public const int TBS_FIXEDLENGTH = 0x0040;

        [NativeTypeName("#define TBS_NOTHUMB 0x0080")]
        public const int TBS_NOTHUMB = 0x0080;

        [NativeTypeName("#define TBS_TOOLTIPS 0x0100")]
        public const int TBS_TOOLTIPS = 0x0100;

        [NativeTypeName("#define TBS_REVERSED 0x0200")]
        public const int TBS_REVERSED = 0x0200;

        [NativeTypeName("#define TBS_DOWNISLEFT 0x0400")]
        public const int TBS_DOWNISLEFT = 0x0400;

        [NativeTypeName("#define TBS_NOTIFYBEFOREMOVE 0x0800")]
        public const int TBS_NOTIFYBEFOREMOVE = 0x0800;

        [NativeTypeName("#define TBS_TRANSPARENTBKGND 0x1000")]
        public const int TBS_TRANSPARENTBKGND = 0x1000;

        [NativeTypeName("#define TBM_GETPOS (WM_USER)")]
        public const int TBM_GETPOS = (0x0400);

        [NativeTypeName("#define TBM_GETRANGEMIN (WM_USER+1)")]
        public const int TBM_GETRANGEMIN = (0x0400 + 1);

        [NativeTypeName("#define TBM_GETRANGEMAX (WM_USER+2)")]
        public const int TBM_GETRANGEMAX = (0x0400 + 2);

        [NativeTypeName("#define TBM_GETTIC (WM_USER+3)")]
        public const int TBM_GETTIC = (0x0400 + 3);

        [NativeTypeName("#define TBM_SETTIC (WM_USER+4)")]
        public const int TBM_SETTIC = (0x0400 + 4);

        [NativeTypeName("#define TBM_SETPOS (WM_USER+5)")]
        public const int TBM_SETPOS = (0x0400 + 5);

        [NativeTypeName("#define TBM_SETRANGE (WM_USER+6)")]
        public const int TBM_SETRANGE = (0x0400 + 6);

        [NativeTypeName("#define TBM_SETRANGEMIN (WM_USER+7)")]
        public const int TBM_SETRANGEMIN = (0x0400 + 7);

        [NativeTypeName("#define TBM_SETRANGEMAX (WM_USER+8)")]
        public const int TBM_SETRANGEMAX = (0x0400 + 8);

        [NativeTypeName("#define TBM_CLEARTICS (WM_USER+9)")]
        public const int TBM_CLEARTICS = (0x0400 + 9);

        [NativeTypeName("#define TBM_SETSEL (WM_USER+10)")]
        public const int TBM_SETSEL = (0x0400 + 10);

        [NativeTypeName("#define TBM_SETSELSTART (WM_USER+11)")]
        public const int TBM_SETSELSTART = (0x0400 + 11);

        [NativeTypeName("#define TBM_SETSELEND (WM_USER+12)")]
        public const int TBM_SETSELEND = (0x0400 + 12);

        [NativeTypeName("#define TBM_GETPTICS (WM_USER+14)")]
        public const int TBM_GETPTICS = (0x0400 + 14);

        [NativeTypeName("#define TBM_GETTICPOS (WM_USER+15)")]
        public const int TBM_GETTICPOS = (0x0400 + 15);

        [NativeTypeName("#define TBM_GETNUMTICS (WM_USER+16)")]
        public const int TBM_GETNUMTICS = (0x0400 + 16);

        [NativeTypeName("#define TBM_GETSELSTART (WM_USER+17)")]
        public const int TBM_GETSELSTART = (0x0400 + 17);

        [NativeTypeName("#define TBM_GETSELEND (WM_USER+18)")]
        public const int TBM_GETSELEND = (0x0400 + 18);

        [NativeTypeName("#define TBM_CLEARSEL (WM_USER+19)")]
        public const int TBM_CLEARSEL = (0x0400 + 19);

        [NativeTypeName("#define TBM_SETTICFREQ (WM_USER+20)")]
        public const int TBM_SETTICFREQ = (0x0400 + 20);

        [NativeTypeName("#define TBM_SETPAGESIZE (WM_USER+21)")]
        public const int TBM_SETPAGESIZE = (0x0400 + 21);

        [NativeTypeName("#define TBM_GETPAGESIZE (WM_USER+22)")]
        public const int TBM_GETPAGESIZE = (0x0400 + 22);

        [NativeTypeName("#define TBM_SETLINESIZE (WM_USER+23)")]
        public const int TBM_SETLINESIZE = (0x0400 + 23);

        [NativeTypeName("#define TBM_GETLINESIZE (WM_USER+24)")]
        public const int TBM_GETLINESIZE = (0x0400 + 24);

        [NativeTypeName("#define TBM_GETTHUMBRECT (WM_USER+25)")]
        public const int TBM_GETTHUMBRECT = (0x0400 + 25);

        [NativeTypeName("#define TBM_GETCHANNELRECT (WM_USER+26)")]
        public const int TBM_GETCHANNELRECT = (0x0400 + 26);

        [NativeTypeName("#define TBM_SETTHUMBLENGTH (WM_USER+27)")]
        public const int TBM_SETTHUMBLENGTH = (0x0400 + 27);

        [NativeTypeName("#define TBM_GETTHUMBLENGTH (WM_USER+28)")]
        public const int TBM_GETTHUMBLENGTH = (0x0400 + 28);

        [NativeTypeName("#define TBM_SETTOOLTIPS (WM_USER+29)")]
        public const int TBM_SETTOOLTIPS = (0x0400 + 29);

        [NativeTypeName("#define TBM_GETTOOLTIPS (WM_USER+30)")]
        public const int TBM_GETTOOLTIPS = (0x0400 + 30);

        [NativeTypeName("#define TBM_SETTIPSIDE (WM_USER+31)")]
        public const int TBM_SETTIPSIDE = (0x0400 + 31);

        [NativeTypeName("#define TBTS_TOP 0")]
        public const int TBTS_TOP = 0;

        [NativeTypeName("#define TBTS_LEFT 1")]
        public const int TBTS_LEFT = 1;

        [NativeTypeName("#define TBTS_BOTTOM 2")]
        public const int TBTS_BOTTOM = 2;

        [NativeTypeName("#define TBTS_RIGHT 3")]
        public const int TBTS_RIGHT = 3;

        [NativeTypeName("#define TBM_SETBUDDY (WM_USER+32)")]
        public const int TBM_SETBUDDY = (0x0400 + 32);

        [NativeTypeName("#define TBM_GETBUDDY (WM_USER+33)")]
        public const int TBM_GETBUDDY = (0x0400 + 33);

        [NativeTypeName("#define TBM_SETPOSNOTIFY (WM_USER+34)")]
        public const int TBM_SETPOSNOTIFY = (0x0400 + 34);

        [NativeTypeName("#define TBM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int TBM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define TBM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int TBM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define TB_LINEUP 0")]
        public const int TB_LINEUP = 0;

        [NativeTypeName("#define TB_LINEDOWN 1")]
        public const int TB_LINEDOWN = 1;

        [NativeTypeName("#define TB_PAGEUP 2")]
        public const int TB_PAGEUP = 2;

        [NativeTypeName("#define TB_PAGEDOWN 3")]
        public const int TB_PAGEDOWN = 3;

        [NativeTypeName("#define TB_THUMBPOSITION 4")]
        public const int TB_THUMBPOSITION = 4;

        [NativeTypeName("#define TB_THUMBTRACK 5")]
        public const int TB_THUMBTRACK = 5;

        [NativeTypeName("#define TB_TOP 6")]
        public const int TB_TOP = 6;

        [NativeTypeName("#define TB_BOTTOM 7")]
        public const int TB_BOTTOM = 7;

        [NativeTypeName("#define TB_ENDTRACK 8")]
        public const int TB_ENDTRACK = 8;

        [NativeTypeName("#define TBCD_TICS 0x0001")]
        public const int TBCD_TICS = 0x0001;

        [NativeTypeName("#define TBCD_THUMB 0x0002")]
        public const int TBCD_THUMB = 0x0002;

        [NativeTypeName("#define TBCD_CHANNEL 0x0003")]
        public const int TBCD_CHANNEL = 0x0003;

        [NativeTypeName("#define TRBN_THUMBPOSCHANGING (TRBN_FIRST-1)")]
        public const uint TRBN_THUMBPOSCHANGING = unchecked((0U - 1501U) - 1);

        [NativeTypeName("#define DL_BEGINDRAG (WM_USER+133)")]
        public const int DL_BEGINDRAG = (0x0400 + 133);

        [NativeTypeName("#define DL_DRAGGING (WM_USER+134)")]
        public const int DL_DRAGGING = (0x0400 + 134);

        [NativeTypeName("#define DL_DROPPED (WM_USER+135)")]
        public const int DL_DROPPED = (0x0400 + 135);

        [NativeTypeName("#define DL_CANCELDRAG (WM_USER+136)")]
        public const int DL_CANCELDRAG = (0x0400 + 136);

        [NativeTypeName("#define DL_CURSORSET 0")]
        public const int DL_CURSORSET = 0;

        [NativeTypeName("#define DL_STOPCURSOR 1")]
        public const int DL_STOPCURSOR = 1;

        [NativeTypeName("#define DL_COPYCURSOR 2")]
        public const int DL_COPYCURSOR = 2;

        [NativeTypeName("#define DL_MOVECURSOR 3")]
        public const int DL_MOVECURSOR = 3;

        [NativeTypeName("#define DRAGLISTMSGSTRING TEXT(\"commctrl_DragListMsg\")")]
        public const string DRAGLISTMSGSTRING = "commctrl_DragListMsg";

        [NativeTypeName("#define UPDOWN_CLASSA \"msctls_updown32\"")]
        public static ReadOnlySpan<byte> UPDOWN_CLASSA => new byte[] { 0x6D, 0x73, 0x63, 0x74, 0x6C, 0x73, 0x5F, 0x75, 0x70, 0x64, 0x6F, 0x77, 0x6E, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define UPDOWN_CLASSW L\"msctls_updown32\"")]
        public const string UPDOWN_CLASSW = "msctls_updown32";

        [NativeTypeName("#define UPDOWN_CLASS UPDOWN_CLASSW")]
        public const string UPDOWN_CLASS = "msctls_updown32";

        [NativeTypeName("#define UD_MAXVAL 0x7fff")]
        public const int UD_MAXVAL = 0x7fff;

        [NativeTypeName("#define UD_MINVAL (-UD_MAXVAL)")]
        public const int UD_MINVAL = (-0x7fff);

        [NativeTypeName("#define UDS_WRAP 0x0001")]
        public const int UDS_WRAP = 0x0001;

        [NativeTypeName("#define UDS_SETBUDDYINT 0x0002")]
        public const int UDS_SETBUDDYINT = 0x0002;

        [NativeTypeName("#define UDS_ALIGNRIGHT 0x0004")]
        public const int UDS_ALIGNRIGHT = 0x0004;

        [NativeTypeName("#define UDS_ALIGNLEFT 0x0008")]
        public const int UDS_ALIGNLEFT = 0x0008;

        [NativeTypeName("#define UDS_AUTOBUDDY 0x0010")]
        public const int UDS_AUTOBUDDY = 0x0010;

        [NativeTypeName("#define UDS_ARROWKEYS 0x0020")]
        public const int UDS_ARROWKEYS = 0x0020;

        [NativeTypeName("#define UDS_HORZ 0x0040")]
        public const int UDS_HORZ = 0x0040;

        [NativeTypeName("#define UDS_NOTHOUSANDS 0x0080")]
        public const int UDS_NOTHOUSANDS = 0x0080;

        [NativeTypeName("#define UDS_HOTTRACK 0x0100")]
        public const int UDS_HOTTRACK = 0x0100;

        [NativeTypeName("#define UDM_SETRANGE (WM_USER+101)")]
        public const int UDM_SETRANGE = (0x0400 + 101);

        [NativeTypeName("#define UDM_GETRANGE (WM_USER+102)")]
        public const int UDM_GETRANGE = (0x0400 + 102);

        [NativeTypeName("#define UDM_SETPOS (WM_USER+103)")]
        public const int UDM_SETPOS = (0x0400 + 103);

        [NativeTypeName("#define UDM_GETPOS (WM_USER+104)")]
        public const int UDM_GETPOS = (0x0400 + 104);

        [NativeTypeName("#define UDM_SETBUDDY (WM_USER+105)")]
        public const int UDM_SETBUDDY = (0x0400 + 105);

        [NativeTypeName("#define UDM_GETBUDDY (WM_USER+106)")]
        public const int UDM_GETBUDDY = (0x0400 + 106);

        [NativeTypeName("#define UDM_SETACCEL (WM_USER+107)")]
        public const int UDM_SETACCEL = (0x0400 + 107);

        [NativeTypeName("#define UDM_GETACCEL (WM_USER+108)")]
        public const int UDM_GETACCEL = (0x0400 + 108);

        [NativeTypeName("#define UDM_SETBASE (WM_USER+109)")]
        public const int UDM_SETBASE = (0x0400 + 109);

        [NativeTypeName("#define UDM_GETBASE (WM_USER+110)")]
        public const int UDM_GETBASE = (0x0400 + 110);

        [NativeTypeName("#define UDM_SETRANGE32 (WM_USER+111)")]
        public const int UDM_SETRANGE32 = (0x0400 + 111);

        [NativeTypeName("#define UDM_GETRANGE32 (WM_USER+112)")]
        public const int UDM_GETRANGE32 = (0x0400 + 112);

        [NativeTypeName("#define UDM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int UDM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define UDM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int UDM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define UDM_SETPOS32 (WM_USER+113)")]
        public const int UDM_SETPOS32 = (0x0400 + 113);

        [NativeTypeName("#define UDM_GETPOS32 (WM_USER+114)")]
        public const int UDM_GETPOS32 = (0x0400 + 114);

        [NativeTypeName("#define UDN_DELTAPOS (UDN_FIRST - 1)")]
        public const uint UDN_DELTAPOS = unchecked((0U - 721U) - 1);

        [NativeTypeName("#define PROGRESS_CLASSA \"msctls_progress32\"")]
        public static ReadOnlySpan<byte> PROGRESS_CLASSA => new byte[] { 0x6D, 0x73, 0x63, 0x74, 0x6C, 0x73, 0x5F, 0x70, 0x72, 0x6F, 0x67, 0x72, 0x65, 0x73, 0x73, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define PROGRESS_CLASSW L\"msctls_progress32\"")]
        public const string PROGRESS_CLASSW = "msctls_progress32";

        [NativeTypeName("#define PROGRESS_CLASS PROGRESS_CLASSW")]
        public const string PROGRESS_CLASS = "msctls_progress32";

        [NativeTypeName("#define PBS_SMOOTH 0x01")]
        public const int PBS_SMOOTH = 0x01;

        [NativeTypeName("#define PBS_VERTICAL 0x04")]
        public const int PBS_VERTICAL = 0x04;

        [NativeTypeName("#define PBM_SETRANGE (WM_USER+1)")]
        public const int PBM_SETRANGE = (0x0400 + 1);

        [NativeTypeName("#define PBM_SETPOS (WM_USER+2)")]
        public const int PBM_SETPOS = (0x0400 + 2);

        [NativeTypeName("#define PBM_DELTAPOS (WM_USER+3)")]
        public const int PBM_DELTAPOS = (0x0400 + 3);

        [NativeTypeName("#define PBM_SETSTEP (WM_USER+4)")]
        public const int PBM_SETSTEP = (0x0400 + 4);

        [NativeTypeName("#define PBM_STEPIT (WM_USER+5)")]
        public const int PBM_STEPIT = (0x0400 + 5);

        [NativeTypeName("#define PBM_SETRANGE32 (WM_USER+6)")]
        public const int PBM_SETRANGE32 = (0x0400 + 6);

        [NativeTypeName("#define PBM_GETRANGE (WM_USER+7)")]
        public const int PBM_GETRANGE = (0x0400 + 7);

        [NativeTypeName("#define PBM_GETPOS (WM_USER+8)")]
        public const int PBM_GETPOS = (0x0400 + 8);

        [NativeTypeName("#define PBM_SETBARCOLOR (WM_USER+9)")]
        public const int PBM_SETBARCOLOR = (0x0400 + 9);

        [NativeTypeName("#define PBM_SETBKCOLOR CCM_SETBKCOLOR")]
        public const int PBM_SETBKCOLOR = (0x2000 + 1);

        [NativeTypeName("#define PBS_MARQUEE 0x08")]
        public const int PBS_MARQUEE = 0x08;

        [NativeTypeName("#define PBM_SETMARQUEE (WM_USER+10)")]
        public const int PBM_SETMARQUEE = (0x0400 + 10);

        [NativeTypeName("#define PBS_SMOOTHREVERSE 0x10")]
        public const int PBS_SMOOTHREVERSE = 0x10;

        [NativeTypeName("#define PBM_GETSTEP (WM_USER+13)")]
        public const int PBM_GETSTEP = (0x0400 + 13);

        [NativeTypeName("#define PBM_GETBKCOLOR (WM_USER+14)")]
        public const int PBM_GETBKCOLOR = (0x0400 + 14);

        [NativeTypeName("#define PBM_GETBARCOLOR (WM_USER+15)")]
        public const int PBM_GETBARCOLOR = (0x0400 + 15);

        [NativeTypeName("#define PBM_SETSTATE (WM_USER+16)")]
        public const int PBM_SETSTATE = (0x0400 + 16);

        [NativeTypeName("#define PBM_GETSTATE (WM_USER+17)")]
        public const int PBM_GETSTATE = (0x0400 + 17);

        [NativeTypeName("#define PBST_NORMAL 0x0001")]
        public const int PBST_NORMAL = 0x0001;

        [NativeTypeName("#define PBST_ERROR 0x0002")]
        public const int PBST_ERROR = 0x0002;

        [NativeTypeName("#define PBST_PAUSED 0x0003")]
        public const int PBST_PAUSED = 0x0003;

        [NativeTypeName("#define HOTKEYF_SHIFT 0x01")]
        public const int HOTKEYF_SHIFT = 0x01;

        [NativeTypeName("#define HOTKEYF_CONTROL 0x02")]
        public const int HOTKEYF_CONTROL = 0x02;

        [NativeTypeName("#define HOTKEYF_ALT 0x04")]
        public const int HOTKEYF_ALT = 0x04;

        [NativeTypeName("#define HOTKEYF_EXT 0x08")]
        public const int HOTKEYF_EXT = 0x08;

        [NativeTypeName("#define HKCOMB_NONE 0x0001")]
        public const int HKCOMB_NONE = 0x0001;

        [NativeTypeName("#define HKCOMB_S 0x0002")]
        public const int HKCOMB_S = 0x0002;

        [NativeTypeName("#define HKCOMB_C 0x0004")]
        public const int HKCOMB_C = 0x0004;

        [NativeTypeName("#define HKCOMB_A 0x0008")]
        public const int HKCOMB_A = 0x0008;

        [NativeTypeName("#define HKCOMB_SC 0x0010")]
        public const int HKCOMB_SC = 0x0010;

        [NativeTypeName("#define HKCOMB_SA 0x0020")]
        public const int HKCOMB_SA = 0x0020;

        [NativeTypeName("#define HKCOMB_CA 0x0040")]
        public const int HKCOMB_CA = 0x0040;

        [NativeTypeName("#define HKCOMB_SCA 0x0080")]
        public const int HKCOMB_SCA = 0x0080;

        [NativeTypeName("#define HKM_SETHOTKEY (WM_USER+1)")]
        public const int HKM_SETHOTKEY = (0x0400 + 1);

        [NativeTypeName("#define HKM_GETHOTKEY (WM_USER+2)")]
        public const int HKM_GETHOTKEY = (0x0400 + 2);

        [NativeTypeName("#define HKM_SETRULES (WM_USER+3)")]
        public const int HKM_SETRULES = (0x0400 + 3);

        [NativeTypeName("#define HOTKEY_CLASSA \"msctls_hotkey32\"")]
        public static ReadOnlySpan<byte> HOTKEY_CLASSA => new byte[] { 0x6D, 0x73, 0x63, 0x74, 0x6C, 0x73, 0x5F, 0x68, 0x6F, 0x74, 0x6B, 0x65, 0x79, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define HOTKEY_CLASSW L\"msctls_hotkey32\"")]
        public const string HOTKEY_CLASSW = "msctls_hotkey32";

        [NativeTypeName("#define HOTKEY_CLASS HOTKEY_CLASSW")]
        public const string HOTKEY_CLASS = "msctls_hotkey32";

        [NativeTypeName("#define CCS_TOP 0x00000001L")]
        public const int CCS_TOP = 0x00000001;

        [NativeTypeName("#define CCS_NOMOVEY 0x00000002L")]
        public const int CCS_NOMOVEY = 0x00000002;

        [NativeTypeName("#define CCS_BOTTOM 0x00000003L")]
        public const int CCS_BOTTOM = 0x00000003;

        [NativeTypeName("#define CCS_NORESIZE 0x00000004L")]
        public const int CCS_NORESIZE = 0x00000004;

        [NativeTypeName("#define CCS_NOPARENTALIGN 0x00000008L")]
        public const int CCS_NOPARENTALIGN = 0x00000008;

        [NativeTypeName("#define CCS_ADJUSTABLE 0x00000020L")]
        public const int CCS_ADJUSTABLE = 0x00000020;

        [NativeTypeName("#define CCS_NODIVIDER 0x00000040L")]
        public const int CCS_NODIVIDER = 0x00000040;

        [NativeTypeName("#define CCS_VERT 0x00000080L")]
        public const int CCS_VERT = 0x00000080;

        [NativeTypeName("#define CCS_LEFT (CCS_VERT | CCS_TOP)")]
        public const int CCS_LEFT = (0x00000080 | 0x00000001);

        [NativeTypeName("#define CCS_RIGHT (CCS_VERT | CCS_BOTTOM)")]
        public const int CCS_RIGHT = (0x00000080 | 0x00000003);

        [NativeTypeName("#define CCS_NOMOVEX (CCS_VERT | CCS_NOMOVEY)")]
        public const int CCS_NOMOVEX = (0x00000080 | 0x00000002);

        [NativeTypeName("#define INVALID_LINK_INDEX (-1)")]
        public const int INVALID_LINK_INDEX = (-1);

        [NativeTypeName("#define MAX_LINKID_TEXT 48")]
        public const int MAX_LINKID_TEXT = 48;

        [NativeTypeName("#define L_MAX_URL_LENGTH (2048 + 32 + sizeof(\"://\"))")]
        public const uint L_MAX_URL_LENGTH = (2048 + 32 + 4);

        [NativeTypeName("#define WC_LINK L\"SysLink\"")]
        public const string WC_LINK = "SysLink";

        [NativeTypeName("#define LWS_TRANSPARENT 0x0001")]
        public const int LWS_TRANSPARENT = 0x0001;

        [NativeTypeName("#define LWS_IGNORERETURN 0x0002")]
        public const int LWS_IGNORERETURN = 0x0002;

        [NativeTypeName("#define LWS_NOPREFIX 0x0004")]
        public const int LWS_NOPREFIX = 0x0004;

        [NativeTypeName("#define LWS_USEVISUALSTYLE 0x0008")]
        public const int LWS_USEVISUALSTYLE = 0x0008;

        [NativeTypeName("#define LWS_USECUSTOMTEXT 0x0010")]
        public const int LWS_USECUSTOMTEXT = 0x0010;

        [NativeTypeName("#define LWS_RIGHT 0x0020")]
        public const int LWS_RIGHT = 0x0020;

        [NativeTypeName("#define LIF_ITEMINDEX 0x00000001")]
        public const int LIF_ITEMINDEX = 0x00000001;

        [NativeTypeName("#define LIF_STATE 0x00000002")]
        public const int LIF_STATE = 0x00000002;

        [NativeTypeName("#define LIF_ITEMID 0x00000004")]
        public const int LIF_ITEMID = 0x00000004;

        [NativeTypeName("#define LIF_URL 0x00000008")]
        public const int LIF_URL = 0x00000008;

        [NativeTypeName("#define LIS_FOCUSED 0x00000001")]
        public const int LIS_FOCUSED = 0x00000001;

        [NativeTypeName("#define LIS_ENABLED 0x00000002")]
        public const int LIS_ENABLED = 0x00000002;

        [NativeTypeName("#define LIS_VISITED 0x00000004")]
        public const int LIS_VISITED = 0x00000004;

        [NativeTypeName("#define LIS_HOTTRACK 0x00000008")]
        public const int LIS_HOTTRACK = 0x00000008;

        [NativeTypeName("#define LIS_DEFAULTCOLORS 0x00000010")]
        public const int LIS_DEFAULTCOLORS = 0x00000010;

        [NativeTypeName("#define LM_HITTEST (WM_USER+0x300)")]
        public const int LM_HITTEST = (0x0400 + 0x300);

        [NativeTypeName("#define LM_GETIDEALHEIGHT (WM_USER+0x301)")]
        public const int LM_GETIDEALHEIGHT = (0x0400 + 0x301);

        [NativeTypeName("#define LM_SETITEM (WM_USER+0x302)")]
        public const int LM_SETITEM = (0x0400 + 0x302);

        [NativeTypeName("#define LM_GETITEM (WM_USER+0x303)")]
        public const int LM_GETITEM = (0x0400 + 0x303);

        [NativeTypeName("#define LM_GETIDEALSIZE (LM_GETIDEALHEIGHT)")]
        public const int LM_GETIDEALSIZE = ((0x0400 + 0x301));

        [NativeTypeName("#define WC_LISTVIEWA \"SysListView32\"")]
        public static ReadOnlySpan<byte> WC_LISTVIEWA => new byte[] { 0x53, 0x79, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x56, 0x69, 0x65, 0x77, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_LISTVIEWW L\"SysListView32\"")]
        public const string WC_LISTVIEWW = "SysListView32";

        [NativeTypeName("#define WC_LISTVIEW WC_LISTVIEWW")]
        public const string WC_LISTVIEW = "SysListView32";

        [NativeTypeName("#define LVS_ICON 0x0000")]
        public const int LVS_ICON = 0x0000;

        [NativeTypeName("#define LVS_REPORT 0x0001")]
        public const int LVS_REPORT = 0x0001;

        [NativeTypeName("#define LVS_SMALLICON 0x0002")]
        public const int LVS_SMALLICON = 0x0002;

        [NativeTypeName("#define LVS_LIST 0x0003")]
        public const int LVS_LIST = 0x0003;

        [NativeTypeName("#define LVS_TYPEMASK 0x0003")]
        public const int LVS_TYPEMASK = 0x0003;

        [NativeTypeName("#define LVS_SINGLESEL 0x0004")]
        public const int LVS_SINGLESEL = 0x0004;

        [NativeTypeName("#define LVS_SHOWSELALWAYS 0x0008")]
        public const int LVS_SHOWSELALWAYS = 0x0008;

        [NativeTypeName("#define LVS_SORTASCENDING 0x0010")]
        public const int LVS_SORTASCENDING = 0x0010;

        [NativeTypeName("#define LVS_SORTDESCENDING 0x0020")]
        public const int LVS_SORTDESCENDING = 0x0020;

        [NativeTypeName("#define LVS_SHAREIMAGELISTS 0x0040")]
        public const int LVS_SHAREIMAGELISTS = 0x0040;

        [NativeTypeName("#define LVS_NOLABELWRAP 0x0080")]
        public const int LVS_NOLABELWRAP = 0x0080;

        [NativeTypeName("#define LVS_AUTOARRANGE 0x0100")]
        public const int LVS_AUTOARRANGE = 0x0100;

        [NativeTypeName("#define LVS_EDITLABELS 0x0200")]
        public const int LVS_EDITLABELS = 0x0200;

        [NativeTypeName("#define LVS_OWNERDATA 0x1000")]
        public const int LVS_OWNERDATA = 0x1000;

        [NativeTypeName("#define LVS_NOSCROLL 0x2000")]
        public const int LVS_NOSCROLL = 0x2000;

        [NativeTypeName("#define LVS_TYPESTYLEMASK 0xfc00")]
        public const int LVS_TYPESTYLEMASK = 0xfc00;

        [NativeTypeName("#define LVS_ALIGNTOP 0x0000")]
        public const int LVS_ALIGNTOP = 0x0000;

        [NativeTypeName("#define LVS_ALIGNLEFT 0x0800")]
        public const int LVS_ALIGNLEFT = 0x0800;

        [NativeTypeName("#define LVS_ALIGNMASK 0x0c00")]
        public const int LVS_ALIGNMASK = 0x0c00;

        [NativeTypeName("#define LVS_OWNERDRAWFIXED 0x0400")]
        public const int LVS_OWNERDRAWFIXED = 0x0400;

        [NativeTypeName("#define LVS_NOCOLUMNHEADER 0x4000")]
        public const int LVS_NOCOLUMNHEADER = 0x4000;

        [NativeTypeName("#define LVS_NOSORTHEADER 0x8000")]
        public const int LVS_NOSORTHEADER = 0x8000;

        [NativeTypeName("#define LVM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int LVM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define LVM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int LVM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define LVM_GETBKCOLOR (LVM_FIRST + 0)")]
        public const int LVM_GETBKCOLOR = (0x1000 + 0);

        [NativeTypeName("#define LVM_SETBKCOLOR (LVM_FIRST + 1)")]
        public const int LVM_SETBKCOLOR = (0x1000 + 1);

        [NativeTypeName("#define LVM_GETIMAGELIST (LVM_FIRST + 2)")]
        public const int LVM_GETIMAGELIST = (0x1000 + 2);

        [NativeTypeName("#define LVSIL_NORMAL 0")]
        public const int LVSIL_NORMAL = 0;

        [NativeTypeName("#define LVSIL_SMALL 1")]
        public const int LVSIL_SMALL = 1;

        [NativeTypeName("#define LVSIL_STATE 2")]
        public const int LVSIL_STATE = 2;

        [NativeTypeName("#define LVSIL_GROUPHEADER 3")]
        public const int LVSIL_GROUPHEADER = 3;

        [NativeTypeName("#define LVM_SETIMAGELIST (LVM_FIRST + 3)")]
        public const int LVM_SETIMAGELIST = (0x1000 + 3);

        [NativeTypeName("#define LVM_GETITEMCOUNT (LVM_FIRST + 4)")]
        public const int LVM_GETITEMCOUNT = (0x1000 + 4);

        [NativeTypeName("#define LVIF_TEXT 0x00000001")]
        public const int LVIF_TEXT = 0x00000001;

        [NativeTypeName("#define LVIF_IMAGE 0x00000002")]
        public const int LVIF_IMAGE = 0x00000002;

        [NativeTypeName("#define LVIF_PARAM 0x00000004")]
        public const int LVIF_PARAM = 0x00000004;

        [NativeTypeName("#define LVIF_STATE 0x00000008")]
        public const int LVIF_STATE = 0x00000008;

        [NativeTypeName("#define LVIF_INDENT 0x00000010")]
        public const int LVIF_INDENT = 0x00000010;

        [NativeTypeName("#define LVIF_NORECOMPUTE 0x00000800")]
        public const int LVIF_NORECOMPUTE = 0x00000800;

        [NativeTypeName("#define LVIF_GROUPID 0x00000100")]
        public const int LVIF_GROUPID = 0x00000100;

        [NativeTypeName("#define LVIF_COLUMNS 0x00000200")]
        public const int LVIF_COLUMNS = 0x00000200;

        [NativeTypeName("#define LVIF_COLFMT 0x00010000")]
        public const int LVIF_COLFMT = 0x00010000;

        [NativeTypeName("#define LVIS_FOCUSED 0x0001")]
        public const int LVIS_FOCUSED = 0x0001;

        [NativeTypeName("#define LVIS_SELECTED 0x0002")]
        public const int LVIS_SELECTED = 0x0002;

        [NativeTypeName("#define LVIS_CUT 0x0004")]
        public const int LVIS_CUT = 0x0004;

        [NativeTypeName("#define LVIS_DROPHILITED 0x0008")]
        public const int LVIS_DROPHILITED = 0x0008;

        [NativeTypeName("#define LVIS_GLOW 0x0010")]
        public const int LVIS_GLOW = 0x0010;

        [NativeTypeName("#define LVIS_ACTIVATING 0x0020")]
        public const int LVIS_ACTIVATING = 0x0020;

        [NativeTypeName("#define LVIS_OVERLAYMASK 0x0F00")]
        public const int LVIS_OVERLAYMASK = 0x0F00;

        [NativeTypeName("#define LVIS_STATEIMAGEMASK 0xF000")]
        public const int LVIS_STATEIMAGEMASK = 0xF000;

        [NativeTypeName("#define I_INDENTCALLBACK (-1)")]
        public const int I_INDENTCALLBACK = (-1);

        [NativeTypeName("#define I_GROUPIDCALLBACK (-1)")]
        public const int I_GROUPIDCALLBACK = (-1);

        [NativeTypeName("#define I_GROUPIDNONE (-2)")]
        public const int I_GROUPIDNONE = (-2);

        [NativeTypeName("#define LPSTR_TEXTCALLBACKW ((LPWSTR)-1L)")]
        public static ushort* LPSTR_TEXTCALLBACKW => unchecked((ushort*)(-1));

        [NativeTypeName("#define LPSTR_TEXTCALLBACKA ((LPSTR)-1L)")]
        public static sbyte* LPSTR_TEXTCALLBACKA => unchecked((sbyte*)(-1));

        [NativeTypeName("#define LPSTR_TEXTCALLBACK LPSTR_TEXTCALLBACKW")]
        public static ushort* LPSTR_TEXTCALLBACK => unchecked((ushort*)(-1));

        [NativeTypeName("#define I_IMAGECALLBACK (-1)")]
        public const int I_IMAGECALLBACK = (-1);

        [NativeTypeName("#define I_IMAGENONE (-2)")]
        public const int I_IMAGENONE = (-2);

        [NativeTypeName("#define I_COLUMNSCALLBACK ((UINT)-1)")]
        public const uint I_COLUMNSCALLBACK = unchecked((uint)(-1));

        [NativeTypeName("#define LVM_GETITEMA (LVM_FIRST + 5)")]
        public const int LVM_GETITEMA = (0x1000 + 5);

        [NativeTypeName("#define LVM_GETITEMW (LVM_FIRST + 75)")]
        public const int LVM_GETITEMW = (0x1000 + 75);

        [NativeTypeName("#define LVM_GETITEM LVM_GETITEMW")]
        public const int LVM_GETITEM = (0x1000 + 75);

        [NativeTypeName("#define LVM_SETITEMA (LVM_FIRST + 6)")]
        public const int LVM_SETITEMA = (0x1000 + 6);

        [NativeTypeName("#define LVM_SETITEMW (LVM_FIRST + 76)")]
        public const int LVM_SETITEMW = (0x1000 + 76);

        [NativeTypeName("#define LVM_SETITEM LVM_SETITEMW")]
        public const int LVM_SETITEM = (0x1000 + 76);

        [NativeTypeName("#define LVM_INSERTITEMA (LVM_FIRST + 7)")]
        public const int LVM_INSERTITEMA = (0x1000 + 7);

        [NativeTypeName("#define LVM_INSERTITEMW (LVM_FIRST + 77)")]
        public const int LVM_INSERTITEMW = (0x1000 + 77);

        [NativeTypeName("#define LVM_INSERTITEM LVM_INSERTITEMW")]
        public const int LVM_INSERTITEM = (0x1000 + 77);

        [NativeTypeName("#define LVM_DELETEITEM (LVM_FIRST + 8)")]
        public const int LVM_DELETEITEM = (0x1000 + 8);

        [NativeTypeName("#define LVM_DELETEALLITEMS (LVM_FIRST + 9)")]
        public const int LVM_DELETEALLITEMS = (0x1000 + 9);

        [NativeTypeName("#define LVM_GETCALLBACKMASK (LVM_FIRST + 10)")]
        public const int LVM_GETCALLBACKMASK = (0x1000 + 10);

        [NativeTypeName("#define LVM_SETCALLBACKMASK (LVM_FIRST + 11)")]
        public const int LVM_SETCALLBACKMASK = (0x1000 + 11);

        [NativeTypeName("#define LVNI_ALL 0x0000")]
        public const int LVNI_ALL = 0x0000;

        [NativeTypeName("#define LVNI_FOCUSED 0x0001")]
        public const int LVNI_FOCUSED = 0x0001;

        [NativeTypeName("#define LVNI_SELECTED 0x0002")]
        public const int LVNI_SELECTED = 0x0002;

        [NativeTypeName("#define LVNI_CUT 0x0004")]
        public const int LVNI_CUT = 0x0004;

        [NativeTypeName("#define LVNI_DROPHILITED 0x0008")]
        public const int LVNI_DROPHILITED = 0x0008;

        [NativeTypeName("#define LVNI_STATEMASK (LVNI_FOCUSED | LVNI_SELECTED | LVNI_CUT | LVNI_DROPHILITED)")]
        public const int LVNI_STATEMASK = (0x0001 | 0x0002 | 0x0004 | 0x0008);

        [NativeTypeName("#define LVNI_VISIBLEORDER 0x0010")]
        public const int LVNI_VISIBLEORDER = 0x0010;

        [NativeTypeName("#define LVNI_PREVIOUS 0x0020")]
        public const int LVNI_PREVIOUS = 0x0020;

        [NativeTypeName("#define LVNI_VISIBLEONLY 0x0040")]
        public const int LVNI_VISIBLEONLY = 0x0040;

        [NativeTypeName("#define LVNI_SAMEGROUPONLY 0x0080")]
        public const int LVNI_SAMEGROUPONLY = 0x0080;

        [NativeTypeName("#define LVNI_ABOVE 0x0100")]
        public const int LVNI_ABOVE = 0x0100;

        [NativeTypeName("#define LVNI_BELOW 0x0200")]
        public const int LVNI_BELOW = 0x0200;

        [NativeTypeName("#define LVNI_TOLEFT 0x0400")]
        public const int LVNI_TOLEFT = 0x0400;

        [NativeTypeName("#define LVNI_TORIGHT 0x0800")]
        public const int LVNI_TORIGHT = 0x0800;

        [NativeTypeName("#define LVNI_DIRECTIONMASK (LVNI_ABOVE | LVNI_BELOW | LVNI_TOLEFT | LVNI_TORIGHT)")]
        public const int LVNI_DIRECTIONMASK = (0x0100 | 0x0200 | 0x0400 | 0x0800);

        [NativeTypeName("#define LVM_GETNEXTITEM (LVM_FIRST + 12)")]
        public const int LVM_GETNEXTITEM = (0x1000 + 12);

        [NativeTypeName("#define LVFI_PARAM 0x0001")]
        public const int LVFI_PARAM = 0x0001;

        [NativeTypeName("#define LVFI_STRING 0x0002")]
        public const int LVFI_STRING = 0x0002;

        [NativeTypeName("#define LVFI_SUBSTRING 0x0004")]
        public const int LVFI_SUBSTRING = 0x0004;

        [NativeTypeName("#define LVFI_PARTIAL 0x0008")]
        public const int LVFI_PARTIAL = 0x0008;

        [NativeTypeName("#define LVFI_WRAP 0x0020")]
        public const int LVFI_WRAP = 0x0020;

        [NativeTypeName("#define LVFI_NEARESTXY 0x0040")]
        public const int LVFI_NEARESTXY = 0x0040;

        [NativeTypeName("#define LVM_FINDITEMA (LVM_FIRST + 13)")]
        public const int LVM_FINDITEMA = (0x1000 + 13);

        [NativeTypeName("#define LVM_FINDITEMW (LVM_FIRST + 83)")]
        public const int LVM_FINDITEMW = (0x1000 + 83);

        [NativeTypeName("#define LVM_FINDITEM LVM_FINDITEMW")]
        public const int LVM_FINDITEM = (0x1000 + 83);

        [NativeTypeName("#define LVIR_BOUNDS 0")]
        public const int LVIR_BOUNDS = 0;

        [NativeTypeName("#define LVIR_ICON 1")]
        public const int LVIR_ICON = 1;

        [NativeTypeName("#define LVIR_LABEL 2")]
        public const int LVIR_LABEL = 2;

        [NativeTypeName("#define LVIR_SELECTBOUNDS 3")]
        public const int LVIR_SELECTBOUNDS = 3;

        [NativeTypeName("#define LVM_GETITEMRECT (LVM_FIRST + 14)")]
        public const int LVM_GETITEMRECT = (0x1000 + 14);

        [NativeTypeName("#define LVM_SETITEMPOSITION (LVM_FIRST + 15)")]
        public const int LVM_SETITEMPOSITION = (0x1000 + 15);

        [NativeTypeName("#define LVM_GETITEMPOSITION (LVM_FIRST + 16)")]
        public const int LVM_GETITEMPOSITION = (0x1000 + 16);

        [NativeTypeName("#define LVM_GETSTRINGWIDTHA (LVM_FIRST + 17)")]
        public const int LVM_GETSTRINGWIDTHA = (0x1000 + 17);

        [NativeTypeName("#define LVM_GETSTRINGWIDTHW (LVM_FIRST + 87)")]
        public const int LVM_GETSTRINGWIDTHW = (0x1000 + 87);

        [NativeTypeName("#define LVM_GETSTRINGWIDTH LVM_GETSTRINGWIDTHW")]
        public const int LVM_GETSTRINGWIDTH = (0x1000 + 87);

        [NativeTypeName("#define LVHT_NOWHERE 0x00000001")]
        public const int LVHT_NOWHERE = 0x00000001;

        [NativeTypeName("#define LVHT_ONITEMICON 0x00000002")]
        public const int LVHT_ONITEMICON = 0x00000002;

        [NativeTypeName("#define LVHT_ONITEMLABEL 0x00000004")]
        public const int LVHT_ONITEMLABEL = 0x00000004;

        [NativeTypeName("#define LVHT_ONITEMSTATEICON 0x00000008")]
        public const int LVHT_ONITEMSTATEICON = 0x00000008;

        [NativeTypeName("#define LVHT_ONITEM (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON)")]
        public const int LVHT_ONITEM = (0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define LVHT_ABOVE 0x00000008")]
        public const int LVHT_ABOVE = 0x00000008;

        [NativeTypeName("#define LVHT_BELOW 0x00000010")]
        public const int LVHT_BELOW = 0x00000010;

        [NativeTypeName("#define LVHT_TORIGHT 0x00000020")]
        public const int LVHT_TORIGHT = 0x00000020;

        [NativeTypeName("#define LVHT_TOLEFT 0x00000040")]
        public const int LVHT_TOLEFT = 0x00000040;

        [NativeTypeName("#define LVHT_EX_GROUP_HEADER 0x10000000")]
        public const int LVHT_EX_GROUP_HEADER = 0x10000000;

        [NativeTypeName("#define LVHT_EX_GROUP_FOOTER 0x20000000")]
        public const int LVHT_EX_GROUP_FOOTER = 0x20000000;

        [NativeTypeName("#define LVHT_EX_GROUP_COLLAPSE 0x40000000")]
        public const int LVHT_EX_GROUP_COLLAPSE = 0x40000000;

        [NativeTypeName("#define LVHT_EX_GROUP_BACKGROUND 0x80000000")]
        public const uint LVHT_EX_GROUP_BACKGROUND = 0x80000000;

        [NativeTypeName("#define LVHT_EX_GROUP_STATEICON 0x01000000")]
        public const int LVHT_EX_GROUP_STATEICON = 0x01000000;

        [NativeTypeName("#define LVHT_EX_GROUP_SUBSETLINK 0x02000000")]
        public const int LVHT_EX_GROUP_SUBSETLINK = 0x02000000;

        [NativeTypeName("#define LVHT_EX_GROUP (LVHT_EX_GROUP_BACKGROUND | LVHT_EX_GROUP_COLLAPSE | LVHT_EX_GROUP_FOOTER | LVHT_EX_GROUP_HEADER | LVHT_EX_GROUP_STATEICON | LVHT_EX_GROUP_SUBSETLINK)")]
        public const uint LVHT_EX_GROUP = (0x80000000 | 0x40000000 | 0x20000000 | 0x10000000 | 0x01000000 | 0x02000000);

        [NativeTypeName("#define LVHT_EX_ONCONTENTS 0x04000000")]
        public const int LVHT_EX_ONCONTENTS = 0x04000000;

        [NativeTypeName("#define LVHT_EX_FOOTER 0x08000000")]
        public const int LVHT_EX_FOOTER = 0x08000000;

        [NativeTypeName("#define LVM_HITTEST (LVM_FIRST + 18)")]
        public const int LVM_HITTEST = (0x1000 + 18);

        [NativeTypeName("#define LVM_ENSUREVISIBLE (LVM_FIRST + 19)")]
        public const int LVM_ENSUREVISIBLE = (0x1000 + 19);

        [NativeTypeName("#define LVM_SCROLL (LVM_FIRST + 20)")]
        public const int LVM_SCROLL = (0x1000 + 20);

        [NativeTypeName("#define LVM_REDRAWITEMS (LVM_FIRST + 21)")]
        public const int LVM_REDRAWITEMS = (0x1000 + 21);

        [NativeTypeName("#define LVA_DEFAULT 0x0000")]
        public const int LVA_DEFAULT = 0x0000;

        [NativeTypeName("#define LVA_ALIGNLEFT 0x0001")]
        public const int LVA_ALIGNLEFT = 0x0001;

        [NativeTypeName("#define LVA_ALIGNTOP 0x0002")]
        public const int LVA_ALIGNTOP = 0x0002;

        [NativeTypeName("#define LVA_SNAPTOGRID 0x0005")]
        public const int LVA_SNAPTOGRID = 0x0005;

        [NativeTypeName("#define LVM_ARRANGE (LVM_FIRST + 22)")]
        public const int LVM_ARRANGE = (0x1000 + 22);

        [NativeTypeName("#define LVM_EDITLABELA (LVM_FIRST + 23)")]
        public const int LVM_EDITLABELA = (0x1000 + 23);

        [NativeTypeName("#define LVM_EDITLABELW (LVM_FIRST + 118)")]
        public const int LVM_EDITLABELW = (0x1000 + 118);

        [NativeTypeName("#define LVM_EDITLABEL LVM_EDITLABELW")]
        public const int LVM_EDITLABEL = (0x1000 + 118);

        [NativeTypeName("#define LVM_GETEDITCONTROL (LVM_FIRST + 24)")]
        public const int LVM_GETEDITCONTROL = (0x1000 + 24);

        [NativeTypeName("#define LVCF_FMT 0x0001")]
        public const int LVCF_FMT = 0x0001;

        [NativeTypeName("#define LVCF_WIDTH 0x0002")]
        public const int LVCF_WIDTH = 0x0002;

        [NativeTypeName("#define LVCF_TEXT 0x0004")]
        public const int LVCF_TEXT = 0x0004;

        [NativeTypeName("#define LVCF_SUBITEM 0x0008")]
        public const int LVCF_SUBITEM = 0x0008;

        [NativeTypeName("#define LVCF_IMAGE 0x0010")]
        public const int LVCF_IMAGE = 0x0010;

        [NativeTypeName("#define LVCF_ORDER 0x0020")]
        public const int LVCF_ORDER = 0x0020;

        [NativeTypeName("#define LVCF_MINWIDTH 0x0040")]
        public const int LVCF_MINWIDTH = 0x0040;

        [NativeTypeName("#define LVCF_DEFAULTWIDTH 0x0080")]
        public const int LVCF_DEFAULTWIDTH = 0x0080;

        [NativeTypeName("#define LVCF_IDEALWIDTH 0x0100")]
        public const int LVCF_IDEALWIDTH = 0x0100;

        [NativeTypeName("#define LVCFMT_LEFT 0x0000")]
        public const int LVCFMT_LEFT = 0x0000;

        [NativeTypeName("#define LVCFMT_RIGHT 0x0001")]
        public const int LVCFMT_RIGHT = 0x0001;

        [NativeTypeName("#define LVCFMT_CENTER 0x0002")]
        public const int LVCFMT_CENTER = 0x0002;

        [NativeTypeName("#define LVCFMT_JUSTIFYMASK 0x0003")]
        public const int LVCFMT_JUSTIFYMASK = 0x0003;

        [NativeTypeName("#define LVCFMT_IMAGE 0x0800")]
        public const int LVCFMT_IMAGE = 0x0800;

        [NativeTypeName("#define LVCFMT_BITMAP_ON_RIGHT 0x1000")]
        public const int LVCFMT_BITMAP_ON_RIGHT = 0x1000;

        [NativeTypeName("#define LVCFMT_COL_HAS_IMAGES 0x8000")]
        public const int LVCFMT_COL_HAS_IMAGES = 0x8000;

        [NativeTypeName("#define LVCFMT_FIXED_WIDTH 0x00100")]
        public const int LVCFMT_FIXED_WIDTH = 0x00100;

        [NativeTypeName("#define LVCFMT_NO_DPI_SCALE 0x40000")]
        public const int LVCFMT_NO_DPI_SCALE = 0x40000;

        [NativeTypeName("#define LVCFMT_FIXED_RATIO 0x80000")]
        public const int LVCFMT_FIXED_RATIO = 0x80000;

        [NativeTypeName("#define LVCFMT_LINE_BREAK 0x100000")]
        public const int LVCFMT_LINE_BREAK = 0x100000;

        [NativeTypeName("#define LVCFMT_FILL 0x200000")]
        public const int LVCFMT_FILL = 0x200000;

        [NativeTypeName("#define LVCFMT_WRAP 0x400000")]
        public const int LVCFMT_WRAP = 0x400000;

        [NativeTypeName("#define LVCFMT_NO_TITLE 0x800000")]
        public const int LVCFMT_NO_TITLE = 0x800000;

        [NativeTypeName("#define LVCFMT_TILE_PLACEMENTMASK (LVCFMT_LINE_BREAK | LVCFMT_FILL)")]
        public const int LVCFMT_TILE_PLACEMENTMASK = (0x100000 | 0x200000);

        [NativeTypeName("#define LVCFMT_SPLITBUTTON 0x1000000")]
        public const int LVCFMT_SPLITBUTTON = 0x1000000;

        [NativeTypeName("#define LVM_GETCOLUMNA (LVM_FIRST + 25)")]
        public const int LVM_GETCOLUMNA = (0x1000 + 25);

        [NativeTypeName("#define LVM_GETCOLUMNW (LVM_FIRST + 95)")]
        public const int LVM_GETCOLUMNW = (0x1000 + 95);

        [NativeTypeName("#define LVM_GETCOLUMN LVM_GETCOLUMNW")]
        public const int LVM_GETCOLUMN = (0x1000 + 95);

        [NativeTypeName("#define LVM_SETCOLUMNA (LVM_FIRST + 26)")]
        public const int LVM_SETCOLUMNA = (0x1000 + 26);

        [NativeTypeName("#define LVM_SETCOLUMNW (LVM_FIRST + 96)")]
        public const int LVM_SETCOLUMNW = (0x1000 + 96);

        [NativeTypeName("#define LVM_SETCOLUMN LVM_SETCOLUMNW")]
        public const int LVM_SETCOLUMN = (0x1000 + 96);

        [NativeTypeName("#define LVM_INSERTCOLUMNA (LVM_FIRST + 27)")]
        public const int LVM_INSERTCOLUMNA = (0x1000 + 27);

        [NativeTypeName("#define LVM_INSERTCOLUMNW (LVM_FIRST + 97)")]
        public const int LVM_INSERTCOLUMNW = (0x1000 + 97);

        [NativeTypeName("#define LVM_INSERTCOLUMN LVM_INSERTCOLUMNW")]
        public const int LVM_INSERTCOLUMN = (0x1000 + 97);

        [NativeTypeName("#define LVM_DELETECOLUMN (LVM_FIRST + 28)")]
        public const int LVM_DELETECOLUMN = (0x1000 + 28);

        [NativeTypeName("#define LVM_GETCOLUMNWIDTH (LVM_FIRST + 29)")]
        public const int LVM_GETCOLUMNWIDTH = (0x1000 + 29);

        [NativeTypeName("#define LVSCW_AUTOSIZE -1")]
        public const int LVSCW_AUTOSIZE = -1;

        [NativeTypeName("#define LVSCW_AUTOSIZE_USEHEADER -2")]
        public const int LVSCW_AUTOSIZE_USEHEADER = -2;

        [NativeTypeName("#define LVM_SETCOLUMNWIDTH (LVM_FIRST + 30)")]
        public const int LVM_SETCOLUMNWIDTH = (0x1000 + 30);

        [NativeTypeName("#define LVM_GETHEADER (LVM_FIRST + 31)")]
        public const int LVM_GETHEADER = (0x1000 + 31);

        [NativeTypeName("#define LVM_CREATEDRAGIMAGE (LVM_FIRST + 33)")]
        public const int LVM_CREATEDRAGIMAGE = (0x1000 + 33);

        [NativeTypeName("#define LVM_GETVIEWRECT (LVM_FIRST + 34)")]
        public const int LVM_GETVIEWRECT = (0x1000 + 34);

        [NativeTypeName("#define LVM_GETTEXTCOLOR (LVM_FIRST + 35)")]
        public const int LVM_GETTEXTCOLOR = (0x1000 + 35);

        [NativeTypeName("#define LVM_SETTEXTCOLOR (LVM_FIRST + 36)")]
        public const int LVM_SETTEXTCOLOR = (0x1000 + 36);

        [NativeTypeName("#define LVM_GETTEXTBKCOLOR (LVM_FIRST + 37)")]
        public const int LVM_GETTEXTBKCOLOR = (0x1000 + 37);

        [NativeTypeName("#define LVM_SETTEXTBKCOLOR (LVM_FIRST + 38)")]
        public const int LVM_SETTEXTBKCOLOR = (0x1000 + 38);

        [NativeTypeName("#define LVM_GETTOPINDEX (LVM_FIRST + 39)")]
        public const int LVM_GETTOPINDEX = (0x1000 + 39);

        [NativeTypeName("#define LVM_GETCOUNTPERPAGE (LVM_FIRST + 40)")]
        public const int LVM_GETCOUNTPERPAGE = (0x1000 + 40);

        [NativeTypeName("#define LVM_GETORIGIN (LVM_FIRST + 41)")]
        public const int LVM_GETORIGIN = (0x1000 + 41);

        [NativeTypeName("#define LVM_UPDATE (LVM_FIRST + 42)")]
        public const int LVM_UPDATE = (0x1000 + 42);

        [NativeTypeName("#define LVM_SETITEMSTATE (LVM_FIRST + 43)")]
        public const int LVM_SETITEMSTATE = (0x1000 + 43);

        [NativeTypeName("#define LVM_GETITEMSTATE (LVM_FIRST + 44)")]
        public const int LVM_GETITEMSTATE = (0x1000 + 44);

        [NativeTypeName("#define LVM_GETITEMTEXTA (LVM_FIRST + 45)")]
        public const int LVM_GETITEMTEXTA = (0x1000 + 45);

        [NativeTypeName("#define LVM_GETITEMTEXTW (LVM_FIRST + 115)")]
        public const int LVM_GETITEMTEXTW = (0x1000 + 115);

        [NativeTypeName("#define LVM_GETITEMTEXT LVM_GETITEMTEXTW")]
        public const int LVM_GETITEMTEXT = (0x1000 + 115);

        [NativeTypeName("#define LVM_SETITEMTEXTA (LVM_FIRST + 46)")]
        public const int LVM_SETITEMTEXTA = (0x1000 + 46);

        [NativeTypeName("#define LVM_SETITEMTEXTW (LVM_FIRST + 116)")]
        public const int LVM_SETITEMTEXTW = (0x1000 + 116);

        [NativeTypeName("#define LVM_SETITEMTEXT LVM_SETITEMTEXTW")]
        public const int LVM_SETITEMTEXT = (0x1000 + 116);

        [NativeTypeName("#define LVSICF_NOINVALIDATEALL 0x00000001")]
        public const int LVSICF_NOINVALIDATEALL = 0x00000001;

        [NativeTypeName("#define LVSICF_NOSCROLL 0x00000002")]
        public const int LVSICF_NOSCROLL = 0x00000002;

        [NativeTypeName("#define LVM_SETITEMCOUNT (LVM_FIRST + 47)")]
        public const int LVM_SETITEMCOUNT = (0x1000 + 47);

        [NativeTypeName("#define LVM_SORTITEMS (LVM_FIRST + 48)")]
        public const int LVM_SORTITEMS = (0x1000 + 48);

        [NativeTypeName("#define LVM_SETITEMPOSITION32 (LVM_FIRST + 49)")]
        public const int LVM_SETITEMPOSITION32 = (0x1000 + 49);

        [NativeTypeName("#define LVM_GETSELECTEDCOUNT (LVM_FIRST + 50)")]
        public const int LVM_GETSELECTEDCOUNT = (0x1000 + 50);

        [NativeTypeName("#define LVM_GETITEMSPACING (LVM_FIRST + 51)")]
        public const int LVM_GETITEMSPACING = (0x1000 + 51);

        [NativeTypeName("#define LVM_GETISEARCHSTRINGA (LVM_FIRST + 52)")]
        public const int LVM_GETISEARCHSTRINGA = (0x1000 + 52);

        [NativeTypeName("#define LVM_GETISEARCHSTRINGW (LVM_FIRST + 117)")]
        public const int LVM_GETISEARCHSTRINGW = (0x1000 + 117);

        [NativeTypeName("#define LVM_GETISEARCHSTRING LVM_GETISEARCHSTRINGW")]
        public const int LVM_GETISEARCHSTRING = (0x1000 + 117);

        [NativeTypeName("#define LVM_SETICONSPACING (LVM_FIRST + 53)")]
        public const int LVM_SETICONSPACING = (0x1000 + 53);

        [NativeTypeName("#define LVM_SETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 54)")]
        public const int LVM_SETEXTENDEDLISTVIEWSTYLE = (0x1000 + 54);

        [NativeTypeName("#define LVM_GETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 55)")]
        public const int LVM_GETEXTENDEDLISTVIEWSTYLE = (0x1000 + 55);

        [NativeTypeName("#define LVS_EX_GRIDLINES 0x00000001")]
        public const int LVS_EX_GRIDLINES = 0x00000001;

        [NativeTypeName("#define LVS_EX_SUBITEMIMAGES 0x00000002")]
        public const int LVS_EX_SUBITEMIMAGES = 0x00000002;

        [NativeTypeName("#define LVS_EX_CHECKBOXES 0x00000004")]
        public const int LVS_EX_CHECKBOXES = 0x00000004;

        [NativeTypeName("#define LVS_EX_TRACKSELECT 0x00000008")]
        public const int LVS_EX_TRACKSELECT = 0x00000008;

        [NativeTypeName("#define LVS_EX_HEADERDRAGDROP 0x00000010")]
        public const int LVS_EX_HEADERDRAGDROP = 0x00000010;

        [NativeTypeName("#define LVS_EX_FULLROWSELECT 0x00000020")]
        public const int LVS_EX_FULLROWSELECT = 0x00000020;

        [NativeTypeName("#define LVS_EX_ONECLICKACTIVATE 0x00000040")]
        public const int LVS_EX_ONECLICKACTIVATE = 0x00000040;

        [NativeTypeName("#define LVS_EX_TWOCLICKACTIVATE 0x00000080")]
        public const int LVS_EX_TWOCLICKACTIVATE = 0x00000080;

        [NativeTypeName("#define LVS_EX_FLATSB 0x00000100")]
        public const int LVS_EX_FLATSB = 0x00000100;

        [NativeTypeName("#define LVS_EX_REGIONAL 0x00000200")]
        public const int LVS_EX_REGIONAL = 0x00000200;

        [NativeTypeName("#define LVS_EX_INFOTIP 0x00000400")]
        public const int LVS_EX_INFOTIP = 0x00000400;

        [NativeTypeName("#define LVS_EX_UNDERLINEHOT 0x00000800")]
        public const int LVS_EX_UNDERLINEHOT = 0x00000800;

        [NativeTypeName("#define LVS_EX_UNDERLINECOLD 0x00001000")]
        public const int LVS_EX_UNDERLINECOLD = 0x00001000;

        [NativeTypeName("#define LVS_EX_MULTIWORKAREAS 0x00002000")]
        public const int LVS_EX_MULTIWORKAREAS = 0x00002000;

        [NativeTypeName("#define LVS_EX_LABELTIP 0x00004000")]
        public const int LVS_EX_LABELTIP = 0x00004000;

        [NativeTypeName("#define LVS_EX_BORDERSELECT 0x00008000")]
        public const int LVS_EX_BORDERSELECT = 0x00008000;

        [NativeTypeName("#define LVS_EX_DOUBLEBUFFER 0x00010000")]
        public const int LVS_EX_DOUBLEBUFFER = 0x00010000;

        [NativeTypeName("#define LVS_EX_HIDELABELS 0x00020000")]
        public const int LVS_EX_HIDELABELS = 0x00020000;

        [NativeTypeName("#define LVS_EX_SINGLEROW 0x00040000")]
        public const int LVS_EX_SINGLEROW = 0x00040000;

        [NativeTypeName("#define LVS_EX_SNAPTOGRID 0x00080000")]
        public const int LVS_EX_SNAPTOGRID = 0x00080000;

        [NativeTypeName("#define LVS_EX_SIMPLESELECT 0x00100000")]
        public const int LVS_EX_SIMPLESELECT = 0x00100000;

        [NativeTypeName("#define LVS_EX_JUSTIFYCOLUMNS 0x00200000")]
        public const int LVS_EX_JUSTIFYCOLUMNS = 0x00200000;

        [NativeTypeName("#define LVS_EX_TRANSPARENTBKGND 0x00400000")]
        public const int LVS_EX_TRANSPARENTBKGND = 0x00400000;

        [NativeTypeName("#define LVS_EX_TRANSPARENTSHADOWTEXT 0x00800000")]
        public const int LVS_EX_TRANSPARENTSHADOWTEXT = 0x00800000;

        [NativeTypeName("#define LVS_EX_AUTOAUTOARRANGE 0x01000000")]
        public const int LVS_EX_AUTOAUTOARRANGE = 0x01000000;

        [NativeTypeName("#define LVS_EX_HEADERINALLVIEWS 0x02000000")]
        public const int LVS_EX_HEADERINALLVIEWS = 0x02000000;

        [NativeTypeName("#define LVS_EX_AUTOCHECKSELECT 0x08000000")]
        public const int LVS_EX_AUTOCHECKSELECT = 0x08000000;

        [NativeTypeName("#define LVS_EX_AUTOSIZECOLUMNS 0x10000000")]
        public const int LVS_EX_AUTOSIZECOLUMNS = 0x10000000;

        [NativeTypeName("#define LVS_EX_COLUMNSNAPPOINTS 0x40000000")]
        public const int LVS_EX_COLUMNSNAPPOINTS = 0x40000000;

        [NativeTypeName("#define LVS_EX_COLUMNOVERFLOW 0x80000000")]
        public const uint LVS_EX_COLUMNOVERFLOW = 0x80000000;

        [NativeTypeName("#define LVM_GETSUBITEMRECT (LVM_FIRST + 56)")]
        public const int LVM_GETSUBITEMRECT = (0x1000 + 56);

        [NativeTypeName("#define LVM_SUBITEMHITTEST (LVM_FIRST + 57)")]
        public const int LVM_SUBITEMHITTEST = (0x1000 + 57);

        [NativeTypeName("#define LVM_SETCOLUMNORDERARRAY (LVM_FIRST + 58)")]
        public const int LVM_SETCOLUMNORDERARRAY = (0x1000 + 58);

        [NativeTypeName("#define LVM_GETCOLUMNORDERARRAY (LVM_FIRST + 59)")]
        public const int LVM_GETCOLUMNORDERARRAY = (0x1000 + 59);

        [NativeTypeName("#define LVM_SETHOTITEM (LVM_FIRST + 60)")]
        public const int LVM_SETHOTITEM = (0x1000 + 60);

        [NativeTypeName("#define LVM_GETHOTITEM (LVM_FIRST + 61)")]
        public const int LVM_GETHOTITEM = (0x1000 + 61);

        [NativeTypeName("#define LVM_SETHOTCURSOR (LVM_FIRST + 62)")]
        public const int LVM_SETHOTCURSOR = (0x1000 + 62);

        [NativeTypeName("#define LVM_GETHOTCURSOR (LVM_FIRST + 63)")]
        public const int LVM_GETHOTCURSOR = (0x1000 + 63);

        [NativeTypeName("#define LVM_APPROXIMATEVIEWRECT (LVM_FIRST + 64)")]
        public const int LVM_APPROXIMATEVIEWRECT = (0x1000 + 64);

        [NativeTypeName("#define LV_MAX_WORKAREAS 16")]
        public const int LV_MAX_WORKAREAS = 16;

        [NativeTypeName("#define LVM_SETWORKAREAS (LVM_FIRST + 65)")]
        public const int LVM_SETWORKAREAS = (0x1000 + 65);

        [NativeTypeName("#define LVM_GETWORKAREAS (LVM_FIRST + 70)")]
        public const int LVM_GETWORKAREAS = (0x1000 + 70);

        [NativeTypeName("#define LVM_GETNUMBEROFWORKAREAS (LVM_FIRST + 73)")]
        public const int LVM_GETNUMBEROFWORKAREAS = (0x1000 + 73);

        [NativeTypeName("#define LVM_GETSELECTIONMARK (LVM_FIRST + 66)")]
        public const int LVM_GETSELECTIONMARK = (0x1000 + 66);

        [NativeTypeName("#define LVM_SETSELECTIONMARK (LVM_FIRST + 67)")]
        public const int LVM_SETSELECTIONMARK = (0x1000 + 67);

        [NativeTypeName("#define LVM_SETHOVERTIME (LVM_FIRST + 71)")]
        public const int LVM_SETHOVERTIME = (0x1000 + 71);

        [NativeTypeName("#define LVM_GETHOVERTIME (LVM_FIRST + 72)")]
        public const int LVM_GETHOVERTIME = (0x1000 + 72);

        [NativeTypeName("#define LVM_SETTOOLTIPS (LVM_FIRST + 74)")]
        public const int LVM_SETTOOLTIPS = (0x1000 + 74);

        [NativeTypeName("#define LVM_GETTOOLTIPS (LVM_FIRST + 78)")]
        public const int LVM_GETTOOLTIPS = (0x1000 + 78);

        [NativeTypeName("#define LVM_SORTITEMSEX (LVM_FIRST + 81)")]
        public const int LVM_SORTITEMSEX = (0x1000 + 81);

        [NativeTypeName("#define LVBKIF_SOURCE_NONE 0x00000000")]
        public const int LVBKIF_SOURCE_NONE = 0x00000000;

        [NativeTypeName("#define LVBKIF_SOURCE_HBITMAP 0x00000001")]
        public const int LVBKIF_SOURCE_HBITMAP = 0x00000001;

        [NativeTypeName("#define LVBKIF_SOURCE_URL 0x00000002")]
        public const int LVBKIF_SOURCE_URL = 0x00000002;

        [NativeTypeName("#define LVBKIF_SOURCE_MASK 0x00000003")]
        public const int LVBKIF_SOURCE_MASK = 0x00000003;

        [NativeTypeName("#define LVBKIF_STYLE_NORMAL 0x00000000")]
        public const int LVBKIF_STYLE_NORMAL = 0x00000000;

        [NativeTypeName("#define LVBKIF_STYLE_TILE 0x00000010")]
        public const int LVBKIF_STYLE_TILE = 0x00000010;

        [NativeTypeName("#define LVBKIF_STYLE_MASK 0x00000010")]
        public const int LVBKIF_STYLE_MASK = 0x00000010;

        [NativeTypeName("#define LVBKIF_FLAG_TILEOFFSET 0x00000100")]
        public const int LVBKIF_FLAG_TILEOFFSET = 0x00000100;

        [NativeTypeName("#define LVBKIF_TYPE_WATERMARK 0x10000000")]
        public const int LVBKIF_TYPE_WATERMARK = 0x10000000;

        [NativeTypeName("#define LVBKIF_FLAG_ALPHABLEND 0x20000000")]
        public const int LVBKIF_FLAG_ALPHABLEND = 0x20000000;

        [NativeTypeName("#define LVM_SETBKIMAGEA (LVM_FIRST + 68)")]
        public const int LVM_SETBKIMAGEA = (0x1000 + 68);

        [NativeTypeName("#define LVM_SETBKIMAGEW (LVM_FIRST + 138)")]
        public const int LVM_SETBKIMAGEW = (0x1000 + 138);

        [NativeTypeName("#define LVM_GETBKIMAGEA (LVM_FIRST + 69)")]
        public const int LVM_GETBKIMAGEA = (0x1000 + 69);

        [NativeTypeName("#define LVM_GETBKIMAGEW (LVM_FIRST + 139)")]
        public const int LVM_GETBKIMAGEW = (0x1000 + 139);

        [NativeTypeName("#define LVM_SETSELECTEDCOLUMN (LVM_FIRST + 140)")]
        public const int LVM_SETSELECTEDCOLUMN = (0x1000 + 140);

        [NativeTypeName("#define LV_VIEW_ICON 0x0000")]
        public const int LV_VIEW_ICON = 0x0000;

        [NativeTypeName("#define LV_VIEW_DETAILS 0x0001")]
        public const int LV_VIEW_DETAILS = 0x0001;

        [NativeTypeName("#define LV_VIEW_SMALLICON 0x0002")]
        public const int LV_VIEW_SMALLICON = 0x0002;

        [NativeTypeName("#define LV_VIEW_LIST 0x0003")]
        public const int LV_VIEW_LIST = 0x0003;

        [NativeTypeName("#define LV_VIEW_TILE 0x0004")]
        public const int LV_VIEW_TILE = 0x0004;

        [NativeTypeName("#define LV_VIEW_MAX 0x0004")]
        public const int LV_VIEW_MAX = 0x0004;

        [NativeTypeName("#define LVM_SETVIEW (LVM_FIRST + 142)")]
        public const int LVM_SETVIEW = (0x1000 + 142);

        [NativeTypeName("#define LVM_GETVIEW (LVM_FIRST + 143)")]
        public const int LVM_GETVIEW = (0x1000 + 143);

        [NativeTypeName("#define LVGF_NONE 0x00000000")]
        public const int LVGF_NONE = 0x00000000;

        [NativeTypeName("#define LVGF_HEADER 0x00000001")]
        public const int LVGF_HEADER = 0x00000001;

        [NativeTypeName("#define LVGF_FOOTER 0x00000002")]
        public const int LVGF_FOOTER = 0x00000002;

        [NativeTypeName("#define LVGF_STATE 0x00000004")]
        public const int LVGF_STATE = 0x00000004;

        [NativeTypeName("#define LVGF_ALIGN 0x00000008")]
        public const int LVGF_ALIGN = 0x00000008;

        [NativeTypeName("#define LVGF_GROUPID 0x00000010")]
        public const int LVGF_GROUPID = 0x00000010;

        [NativeTypeName("#define LVGF_SUBTITLE 0x00000100")]
        public const int LVGF_SUBTITLE = 0x00000100;

        [NativeTypeName("#define LVGF_TASK 0x00000200")]
        public const int LVGF_TASK = 0x00000200;

        [NativeTypeName("#define LVGF_DESCRIPTIONTOP 0x00000400")]
        public const int LVGF_DESCRIPTIONTOP = 0x00000400;

        [NativeTypeName("#define LVGF_DESCRIPTIONBOTTOM 0x00000800")]
        public const int LVGF_DESCRIPTIONBOTTOM = 0x00000800;

        [NativeTypeName("#define LVGF_TITLEIMAGE 0x00001000")]
        public const int LVGF_TITLEIMAGE = 0x00001000;

        [NativeTypeName("#define LVGF_EXTENDEDIMAGE 0x00002000")]
        public const int LVGF_EXTENDEDIMAGE = 0x00002000;

        [NativeTypeName("#define LVGF_ITEMS 0x00004000")]
        public const int LVGF_ITEMS = 0x00004000;

        [NativeTypeName("#define LVGF_SUBSET 0x00008000")]
        public const int LVGF_SUBSET = 0x00008000;

        [NativeTypeName("#define LVGF_SUBSETITEMS 0x00010000")]
        public const int LVGF_SUBSETITEMS = 0x00010000;

        [NativeTypeName("#define LVGS_NORMAL 0x00000000")]
        public const int LVGS_NORMAL = 0x00000000;

        [NativeTypeName("#define LVGS_COLLAPSED 0x00000001")]
        public const int LVGS_COLLAPSED = 0x00000001;

        [NativeTypeName("#define LVGS_HIDDEN 0x00000002")]
        public const int LVGS_HIDDEN = 0x00000002;

        [NativeTypeName("#define LVGS_NOHEADER 0x00000004")]
        public const int LVGS_NOHEADER = 0x00000004;

        [NativeTypeName("#define LVGS_COLLAPSIBLE 0x00000008")]
        public const int LVGS_COLLAPSIBLE = 0x00000008;

        [NativeTypeName("#define LVGS_FOCUSED 0x00000010")]
        public const int LVGS_FOCUSED = 0x00000010;

        [NativeTypeName("#define LVGS_SELECTED 0x00000020")]
        public const int LVGS_SELECTED = 0x00000020;

        [NativeTypeName("#define LVGS_SUBSETED 0x00000040")]
        public const int LVGS_SUBSETED = 0x00000040;

        [NativeTypeName("#define LVGS_SUBSETLINKFOCUSED 0x00000080")]
        public const int LVGS_SUBSETLINKFOCUSED = 0x00000080;

        [NativeTypeName("#define LVGA_HEADER_LEFT 0x00000001")]
        public const int LVGA_HEADER_LEFT = 0x00000001;

        [NativeTypeName("#define LVGA_HEADER_CENTER 0x00000002")]
        public const int LVGA_HEADER_CENTER = 0x00000002;

        [NativeTypeName("#define LVGA_HEADER_RIGHT 0x00000004")]
        public const int LVGA_HEADER_RIGHT = 0x00000004;

        [NativeTypeName("#define LVGA_FOOTER_LEFT 0x00000008")]
        public const int LVGA_FOOTER_LEFT = 0x00000008;

        [NativeTypeName("#define LVGA_FOOTER_CENTER 0x00000010")]
        public const int LVGA_FOOTER_CENTER = 0x00000010;

        [NativeTypeName("#define LVGA_FOOTER_RIGHT 0x00000020")]
        public const int LVGA_FOOTER_RIGHT = 0x00000020;

        [NativeTypeName("#define LVM_INSERTGROUP (LVM_FIRST + 145)")]
        public const int LVM_INSERTGROUP = (0x1000 + 145);

        [NativeTypeName("#define LVM_SETGROUPINFO (LVM_FIRST + 147)")]
        public const int LVM_SETGROUPINFO = (0x1000 + 147);

        [NativeTypeName("#define LVM_GETGROUPINFO (LVM_FIRST + 149)")]
        public const int LVM_GETGROUPINFO = (0x1000 + 149);

        [NativeTypeName("#define LVM_REMOVEGROUP (LVM_FIRST + 150)")]
        public const int LVM_REMOVEGROUP = (0x1000 + 150);

        [NativeTypeName("#define LVM_MOVEGROUP (LVM_FIRST + 151)")]
        public const int LVM_MOVEGROUP = (0x1000 + 151);

        [NativeTypeName("#define LVM_GETGROUPCOUNT (LVM_FIRST + 152)")]
        public const int LVM_GETGROUPCOUNT = (0x1000 + 152);

        [NativeTypeName("#define LVM_GETGROUPINFOBYINDEX (LVM_FIRST + 153)")]
        public const int LVM_GETGROUPINFOBYINDEX = (0x1000 + 153);

        [NativeTypeName("#define LVM_MOVEITEMTOGROUP (LVM_FIRST + 154)")]
        public const int LVM_MOVEITEMTOGROUP = (0x1000 + 154);

        [NativeTypeName("#define LVGGR_GROUP 0")]
        public const int LVGGR_GROUP = 0;

        [NativeTypeName("#define LVGGR_HEADER 1")]
        public const int LVGGR_HEADER = 1;

        [NativeTypeName("#define LVGGR_LABEL 2")]
        public const int LVGGR_LABEL = 2;

        [NativeTypeName("#define LVGGR_SUBSETLINK 3")]
        public const int LVGGR_SUBSETLINK = 3;

        [NativeTypeName("#define LVM_GETGROUPRECT (LVM_FIRST + 98)")]
        public const int LVM_GETGROUPRECT = (0x1000 + 98);

        [NativeTypeName("#define LVGMF_NONE 0x00000000")]
        public const int LVGMF_NONE = 0x00000000;

        [NativeTypeName("#define LVGMF_BORDERSIZE 0x00000001")]
        public const int LVGMF_BORDERSIZE = 0x00000001;

        [NativeTypeName("#define LVGMF_BORDERCOLOR 0x00000002")]
        public const int LVGMF_BORDERCOLOR = 0x00000002;

        [NativeTypeName("#define LVGMF_TEXTCOLOR 0x00000004")]
        public const int LVGMF_TEXTCOLOR = 0x00000004;

        [NativeTypeName("#define LVM_SETGROUPMETRICS (LVM_FIRST + 155)")]
        public const int LVM_SETGROUPMETRICS = (0x1000 + 155);

        [NativeTypeName("#define LVM_GETGROUPMETRICS (LVM_FIRST + 156)")]
        public const int LVM_GETGROUPMETRICS = (0x1000 + 156);

        [NativeTypeName("#define LVM_ENABLEGROUPVIEW (LVM_FIRST + 157)")]
        public const int LVM_ENABLEGROUPVIEW = (0x1000 + 157);

        [NativeTypeName("#define LVM_SORTGROUPS (LVM_FIRST + 158)")]
        public const int LVM_SORTGROUPS = (0x1000 + 158);

        [NativeTypeName("#define LVM_INSERTGROUPSORTED (LVM_FIRST + 159)")]
        public const int LVM_INSERTGROUPSORTED = (0x1000 + 159);

        [NativeTypeName("#define LVM_REMOVEALLGROUPS (LVM_FIRST + 160)")]
        public const int LVM_REMOVEALLGROUPS = (0x1000 + 160);

        [NativeTypeName("#define LVM_HASGROUP (LVM_FIRST + 161)")]
        public const int LVM_HASGROUP = (0x1000 + 161);

        [NativeTypeName("#define LVM_GETGROUPSTATE (LVM_FIRST + 92)")]
        public const int LVM_GETGROUPSTATE = (0x1000 + 92);

        [NativeTypeName("#define LVM_GETFOCUSEDGROUP (LVM_FIRST + 93)")]
        public const int LVM_GETFOCUSEDGROUP = (0x1000 + 93);

        [NativeTypeName("#define LVTVIF_AUTOSIZE 0x00000000")]
        public const int LVTVIF_AUTOSIZE = 0x00000000;

        [NativeTypeName("#define LVTVIF_FIXEDWIDTH 0x00000001")]
        public const int LVTVIF_FIXEDWIDTH = 0x00000001;

        [NativeTypeName("#define LVTVIF_FIXEDHEIGHT 0x00000002")]
        public const int LVTVIF_FIXEDHEIGHT = 0x00000002;

        [NativeTypeName("#define LVTVIF_FIXEDSIZE 0x00000003")]
        public const int LVTVIF_FIXEDSIZE = 0x00000003;

        [NativeTypeName("#define LVTVIF_EXTENDED 0x00000004")]
        public const int LVTVIF_EXTENDED = 0x00000004;

        [NativeTypeName("#define LVTVIM_TILESIZE 0x00000001")]
        public const int LVTVIM_TILESIZE = 0x00000001;

        [NativeTypeName("#define LVTVIM_COLUMNS 0x00000002")]
        public const int LVTVIM_COLUMNS = 0x00000002;

        [NativeTypeName("#define LVTVIM_LABELMARGIN 0x00000004")]
        public const int LVTVIM_LABELMARGIN = 0x00000004;

        [NativeTypeName("#define LVM_SETTILEVIEWINFO (LVM_FIRST + 162)")]
        public const int LVM_SETTILEVIEWINFO = (0x1000 + 162);

        [NativeTypeName("#define LVM_GETTILEVIEWINFO (LVM_FIRST + 163)")]
        public const int LVM_GETTILEVIEWINFO = (0x1000 + 163);

        [NativeTypeName("#define LVM_SETTILEINFO (LVM_FIRST + 164)")]
        public const int LVM_SETTILEINFO = (0x1000 + 164);

        [NativeTypeName("#define LVM_GETTILEINFO (LVM_FIRST + 165)")]
        public const int LVM_GETTILEINFO = (0x1000 + 165);

        [NativeTypeName("#define LVIM_AFTER 0x00000001")]
        public const int LVIM_AFTER = 0x00000001;

        [NativeTypeName("#define LVM_SETINSERTMARK (LVM_FIRST + 166)")]
        public const int LVM_SETINSERTMARK = (0x1000 + 166);

        [NativeTypeName("#define LVM_GETINSERTMARK (LVM_FIRST + 167)")]
        public const int LVM_GETINSERTMARK = (0x1000 + 167);

        [NativeTypeName("#define LVM_INSERTMARKHITTEST (LVM_FIRST + 168)")]
        public const int LVM_INSERTMARKHITTEST = (0x1000 + 168);

        [NativeTypeName("#define LVM_GETINSERTMARKRECT (LVM_FIRST + 169)")]
        public const int LVM_GETINSERTMARKRECT = (0x1000 + 169);

        [NativeTypeName("#define LVM_SETINSERTMARKCOLOR (LVM_FIRST + 170)")]
        public const int LVM_SETINSERTMARKCOLOR = (0x1000 + 170);

        [NativeTypeName("#define LVM_GETINSERTMARKCOLOR (LVM_FIRST + 171)")]
        public const int LVM_GETINSERTMARKCOLOR = (0x1000 + 171);

        [NativeTypeName("#define LVM_SETINFOTIP (LVM_FIRST + 173)")]
        public const int LVM_SETINFOTIP = (0x1000 + 173);

        [NativeTypeName("#define LVM_GETSELECTEDCOLUMN (LVM_FIRST + 174)")]
        public const int LVM_GETSELECTEDCOLUMN = (0x1000 + 174);

        [NativeTypeName("#define LVM_ISGROUPVIEWENABLED (LVM_FIRST + 175)")]
        public const int LVM_ISGROUPVIEWENABLED = (0x1000 + 175);

        [NativeTypeName("#define LVM_GETOUTLINECOLOR (LVM_FIRST + 176)")]
        public const int LVM_GETOUTLINECOLOR = (0x1000 + 176);

        [NativeTypeName("#define LVM_SETOUTLINECOLOR (LVM_FIRST + 177)")]
        public const int LVM_SETOUTLINECOLOR = (0x1000 + 177);

        [NativeTypeName("#define LVM_CANCELEDITLABEL (LVM_FIRST + 179)")]
        public const int LVM_CANCELEDITLABEL = (0x1000 + 179);

        [NativeTypeName("#define LVM_MAPINDEXTOID (LVM_FIRST + 180)")]
        public const int LVM_MAPINDEXTOID = (0x1000 + 180);

        [NativeTypeName("#define LVM_MAPIDTOINDEX (LVM_FIRST + 181)")]
        public const int LVM_MAPIDTOINDEX = (0x1000 + 181);

        [NativeTypeName("#define LVM_ISITEMVISIBLE (LVM_FIRST + 182)")]
        public const int LVM_ISITEMVISIBLE = (0x1000 + 182);

        [NativeTypeName("#define LVM_GETEMPTYTEXT (LVM_FIRST + 204)")]
        public const int LVM_GETEMPTYTEXT = (0x1000 + 204);

        [NativeTypeName("#define LVM_GETFOOTERRECT (LVM_FIRST + 205)")]
        public const int LVM_GETFOOTERRECT = (0x1000 + 205);

        [NativeTypeName("#define LVFF_ITEMCOUNT 0x00000001")]
        public const int LVFF_ITEMCOUNT = 0x00000001;

        [NativeTypeName("#define LVM_GETFOOTERINFO (LVM_FIRST + 206)")]
        public const int LVM_GETFOOTERINFO = (0x1000 + 206);

        [NativeTypeName("#define LVM_GETFOOTERITEMRECT (LVM_FIRST + 207)")]
        public const int LVM_GETFOOTERITEMRECT = (0x1000 + 207);

        [NativeTypeName("#define LVFIF_TEXT 0x00000001")]
        public const int LVFIF_TEXT = 0x00000001;

        [NativeTypeName("#define LVFIF_STATE 0x00000002")]
        public const int LVFIF_STATE = 0x00000002;

        [NativeTypeName("#define LVFIS_FOCUSED 0x0001")]
        public const int LVFIS_FOCUSED = 0x0001;

        [NativeTypeName("#define LVM_GETFOOTERITEM (LVM_FIRST + 208)")]
        public const int LVM_GETFOOTERITEM = (0x1000 + 208);

        [NativeTypeName("#define LVM_GETITEMINDEXRECT (LVM_FIRST + 209)")]
        public const int LVM_GETITEMINDEXRECT = (0x1000 + 209);

        [NativeTypeName("#define LVM_SETITEMINDEXSTATE (LVM_FIRST + 210)")]
        public const int LVM_SETITEMINDEXSTATE = (0x1000 + 210);

        [NativeTypeName("#define LVM_GETNEXTITEMINDEX (LVM_FIRST + 211)")]
        public const int LVM_GETNEXTITEMINDEX = (0x1000 + 211);

        [NativeTypeName("#define LVM_SETBKIMAGE LVM_SETBKIMAGEW")]
        public const int LVM_SETBKIMAGE = (0x1000 + 138);

        [NativeTypeName("#define LVM_GETBKIMAGE LVM_GETBKIMAGEW")]
        public const int LVM_GETBKIMAGE = (0x1000 + 139);

        [NativeTypeName("#define LVKF_ALT 0x0001")]
        public const int LVKF_ALT = 0x0001;

        [NativeTypeName("#define LVKF_CONTROL 0x0002")]
        public const int LVKF_CONTROL = 0x0002;

        [NativeTypeName("#define LVKF_SHIFT 0x0004")]
        public const int LVKF_SHIFT = 0x0004;

        [NativeTypeName("#define LVCDI_ITEM 0x00000000")]
        public const int LVCDI_ITEM = 0x00000000;

        [NativeTypeName("#define LVCDI_GROUP 0x00000001")]
        public const int LVCDI_GROUP = 0x00000001;

        [NativeTypeName("#define LVCDI_ITEMSLIST 0x00000002")]
        public const int LVCDI_ITEMSLIST = 0x00000002;

        [NativeTypeName("#define LVCDRF_NOSELECT 0x00010000")]
        public const int LVCDRF_NOSELECT = 0x00010000;

        [NativeTypeName("#define LVCDRF_NOGROUPFRAME 0x00020000")]
        public const int LVCDRF_NOGROUPFRAME = 0x00020000;

        [NativeTypeName("#define LVN_ITEMCHANGING (LVN_FIRST-0)")]
        public const uint LVN_ITEMCHANGING = unchecked((0U - 100U) - 0);

        [NativeTypeName("#define LVN_ITEMCHANGED (LVN_FIRST-1)")]
        public const uint LVN_ITEMCHANGED = unchecked((0U - 100U) - 1);

        [NativeTypeName("#define LVN_INSERTITEM (LVN_FIRST-2)")]
        public const uint LVN_INSERTITEM = unchecked((0U - 100U) - 2);

        [NativeTypeName("#define LVN_DELETEITEM (LVN_FIRST-3)")]
        public const uint LVN_DELETEITEM = unchecked((0U - 100U) - 3);

        [NativeTypeName("#define LVN_DELETEALLITEMS (LVN_FIRST-4)")]
        public const uint LVN_DELETEALLITEMS = unchecked((0U - 100U) - 4);

        [NativeTypeName("#define LVN_BEGINLABELEDITA (LVN_FIRST-5)")]
        public const uint LVN_BEGINLABELEDITA = unchecked((0U - 100U) - 5);

        [NativeTypeName("#define LVN_BEGINLABELEDITW (LVN_FIRST-75)")]
        public const uint LVN_BEGINLABELEDITW = unchecked((0U - 100U) - 75);

        [NativeTypeName("#define LVN_ENDLABELEDITA (LVN_FIRST-6)")]
        public const uint LVN_ENDLABELEDITA = unchecked((0U - 100U) - 6);

        [NativeTypeName("#define LVN_ENDLABELEDITW (LVN_FIRST-76)")]
        public const uint LVN_ENDLABELEDITW = unchecked((0U - 100U) - 76);

        [NativeTypeName("#define LVN_COLUMNCLICK (LVN_FIRST-8)")]
        public const uint LVN_COLUMNCLICK = unchecked((0U - 100U) - 8);

        [NativeTypeName("#define LVN_BEGINDRAG (LVN_FIRST-9)")]
        public const uint LVN_BEGINDRAG = unchecked((0U - 100U) - 9);

        [NativeTypeName("#define LVN_BEGINRDRAG (LVN_FIRST-11)")]
        public const uint LVN_BEGINRDRAG = unchecked((0U - 100U) - 11);

        [NativeTypeName("#define LVN_ODCACHEHINT (LVN_FIRST-13)")]
        public const uint LVN_ODCACHEHINT = unchecked((0U - 100U) - 13);

        [NativeTypeName("#define LVN_ODFINDITEMA (LVN_FIRST-52)")]
        public const uint LVN_ODFINDITEMA = unchecked((0U - 100U) - 52);

        [NativeTypeName("#define LVN_ODFINDITEMW (LVN_FIRST-79)")]
        public const uint LVN_ODFINDITEMW = unchecked((0U - 100U) - 79);

        [NativeTypeName("#define LVN_ITEMACTIVATE (LVN_FIRST-14)")]
        public const uint LVN_ITEMACTIVATE = unchecked((0U - 100U) - 14);

        [NativeTypeName("#define LVN_ODSTATECHANGED (LVN_FIRST-15)")]
        public const uint LVN_ODSTATECHANGED = unchecked((0U - 100U) - 15);

        [NativeTypeName("#define LVN_ODFINDITEM LVN_ODFINDITEMW")]
        public const uint LVN_ODFINDITEM = unchecked((0U - 100U) - 79);

        [NativeTypeName("#define LVN_HOTTRACK (LVN_FIRST-21)")]
        public const uint LVN_HOTTRACK = unchecked((0U - 100U) - 21);

        [NativeTypeName("#define LVN_GETDISPINFOA (LVN_FIRST-50)")]
        public const uint LVN_GETDISPINFOA = unchecked((0U - 100U) - 50);

        [NativeTypeName("#define LVN_GETDISPINFOW (LVN_FIRST-77)")]
        public const uint LVN_GETDISPINFOW = unchecked((0U - 100U) - 77);

        [NativeTypeName("#define LVN_SETDISPINFOA (LVN_FIRST-51)")]
        public const uint LVN_SETDISPINFOA = unchecked((0U - 100U) - 51);

        [NativeTypeName("#define LVN_SETDISPINFOW (LVN_FIRST-78)")]
        public const uint LVN_SETDISPINFOW = unchecked((0U - 100U) - 78);

        [NativeTypeName("#define LVN_BEGINLABELEDIT LVN_BEGINLABELEDITW")]
        public const uint LVN_BEGINLABELEDIT = unchecked((0U - 100U) - 75);

        [NativeTypeName("#define LVN_ENDLABELEDIT LVN_ENDLABELEDITW")]
        public const uint LVN_ENDLABELEDIT = unchecked((0U - 100U) - 76);

        [NativeTypeName("#define LVN_GETDISPINFO LVN_GETDISPINFOW")]
        public const uint LVN_GETDISPINFO = unchecked((0U - 100U) - 77);

        [NativeTypeName("#define LVN_SETDISPINFO LVN_SETDISPINFOW")]
        public const uint LVN_SETDISPINFO = unchecked((0U - 100U) - 78);

        [NativeTypeName("#define LVIF_DI_SETITEM 0x1000")]
        public const int LVIF_DI_SETITEM = 0x1000;

        [NativeTypeName("#define LVN_KEYDOWN (LVN_FIRST-55)")]
        public const uint LVN_KEYDOWN = unchecked((0U - 100U) - 55);

        [NativeTypeName("#define LVN_MARQUEEBEGIN (LVN_FIRST-56)")]
        public const uint LVN_MARQUEEBEGIN = unchecked((0U - 100U) - 56);

        [NativeTypeName("#define LVGIT_UNFOLDED 0x0001")]
        public const int LVGIT_UNFOLDED = 0x0001;

        [NativeTypeName("#define LVN_GETINFOTIPA (LVN_FIRST-57)")]
        public const uint LVN_GETINFOTIPA = unchecked((0U - 100U) - 57);

        [NativeTypeName("#define LVN_GETINFOTIPW (LVN_FIRST-58)")]
        public const uint LVN_GETINFOTIPW = unchecked((0U - 100U) - 58);

        [NativeTypeName("#define LVN_GETINFOTIP LVN_GETINFOTIPW")]
        public const uint LVN_GETINFOTIP = unchecked((0U - 100U) - 58);

        [NativeTypeName("#define LVNSCH_DEFAULT -1")]
        public const int LVNSCH_DEFAULT = -1;

        [NativeTypeName("#define LVNSCH_ERROR -2")]
        public const int LVNSCH_ERROR = -2;

        [NativeTypeName("#define LVNSCH_IGNORE -3")]
        public const int LVNSCH_IGNORE = -3;

        [NativeTypeName("#define LVN_INCREMENTALSEARCHA (LVN_FIRST-62)")]
        public const uint LVN_INCREMENTALSEARCHA = unchecked((0U - 100U) - 62);

        [NativeTypeName("#define LVN_INCREMENTALSEARCHW (LVN_FIRST-63)")]
        public const uint LVN_INCREMENTALSEARCHW = unchecked((0U - 100U) - 63);

        [NativeTypeName("#define LVN_INCREMENTALSEARCH LVN_INCREMENTALSEARCHW")]
        public const uint LVN_INCREMENTALSEARCH = unchecked((0U - 100U) - 63);

        [NativeTypeName("#define LVN_COLUMNDROPDOWN (LVN_FIRST-64)")]
        public const uint LVN_COLUMNDROPDOWN = unchecked((0U - 100U) - 64);

        [NativeTypeName("#define LVN_COLUMNOVERFLOWCLICK (LVN_FIRST-66)")]
        public const uint LVN_COLUMNOVERFLOWCLICK = unchecked((0U - 100U) - 66);

        [NativeTypeName("#define LVN_BEGINSCROLL (LVN_FIRST-80)")]
        public const uint LVN_BEGINSCROLL = unchecked((0U - 100U) - 80);

        [NativeTypeName("#define LVN_ENDSCROLL (LVN_FIRST-81)")]
        public const uint LVN_ENDSCROLL = unchecked((0U - 100U) - 81);

        [NativeTypeName("#define LVN_LINKCLICK (LVN_FIRST-84)")]
        public const uint LVN_LINKCLICK = unchecked((0U - 100U) - 84);

        [NativeTypeName("#define EMF_CENTERED 0x00000001")]
        public const int EMF_CENTERED = 0x00000001;

        [NativeTypeName("#define LVN_GETEMPTYMARKUP (LVN_FIRST-87)")]
        public const uint LVN_GETEMPTYMARKUP = unchecked((0U - 100U) - 87);

        [NativeTypeName("#define WC_TREEVIEWA \"SysTreeView32\"")]
        public static ReadOnlySpan<byte> WC_TREEVIEWA => new byte[] { 0x53, 0x79, 0x73, 0x54, 0x72, 0x65, 0x65, 0x56, 0x69, 0x65, 0x77, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_TREEVIEWW L\"SysTreeView32\"")]
        public const string WC_TREEVIEWW = "SysTreeView32";

        [NativeTypeName("#define WC_TREEVIEW WC_TREEVIEWW")]
        public const string WC_TREEVIEW = "SysTreeView32";

        [NativeTypeName("#define TVS_HASBUTTONS 0x0001")]
        public const int TVS_HASBUTTONS = 0x0001;

        [NativeTypeName("#define TVS_HASLINES 0x0002")]
        public const int TVS_HASLINES = 0x0002;

        [NativeTypeName("#define TVS_LINESATROOT 0x0004")]
        public const int TVS_LINESATROOT = 0x0004;

        [NativeTypeName("#define TVS_EDITLABELS 0x0008")]
        public const int TVS_EDITLABELS = 0x0008;

        [NativeTypeName("#define TVS_DISABLEDRAGDROP 0x0010")]
        public const int TVS_DISABLEDRAGDROP = 0x0010;

        [NativeTypeName("#define TVS_SHOWSELALWAYS 0x0020")]
        public const int TVS_SHOWSELALWAYS = 0x0020;

        [NativeTypeName("#define TVS_RTLREADING 0x0040")]
        public const int TVS_RTLREADING = 0x0040;

        [NativeTypeName("#define TVS_NOTOOLTIPS 0x0080")]
        public const int TVS_NOTOOLTIPS = 0x0080;

        [NativeTypeName("#define TVS_CHECKBOXES 0x0100")]
        public const int TVS_CHECKBOXES = 0x0100;

        [NativeTypeName("#define TVS_TRACKSELECT 0x0200")]
        public const int TVS_TRACKSELECT = 0x0200;

        [NativeTypeName("#define TVS_SINGLEEXPAND 0x0400")]
        public const int TVS_SINGLEEXPAND = 0x0400;

        [NativeTypeName("#define TVS_INFOTIP 0x0800")]
        public const int TVS_INFOTIP = 0x0800;

        [NativeTypeName("#define TVS_FULLROWSELECT 0x1000")]
        public const int TVS_FULLROWSELECT = 0x1000;

        [NativeTypeName("#define TVS_NOSCROLL 0x2000")]
        public const int TVS_NOSCROLL = 0x2000;

        [NativeTypeName("#define TVS_NONEVENHEIGHT 0x4000")]
        public const int TVS_NONEVENHEIGHT = 0x4000;

        [NativeTypeName("#define TVS_NOHSCROLL 0x8000")]
        public const int TVS_NOHSCROLL = 0x8000;

        [NativeTypeName("#define TVS_EX_NOSINGLECOLLAPSE 0x0001")]
        public const int TVS_EX_NOSINGLECOLLAPSE = 0x0001;

        [NativeTypeName("#define TVS_EX_MULTISELECT 0x0002")]
        public const int TVS_EX_MULTISELECT = 0x0002;

        [NativeTypeName("#define TVS_EX_DOUBLEBUFFER 0x0004")]
        public const int TVS_EX_DOUBLEBUFFER = 0x0004;

        [NativeTypeName("#define TVS_EX_NOINDENTSTATE 0x0008")]
        public const int TVS_EX_NOINDENTSTATE = 0x0008;

        [NativeTypeName("#define TVS_EX_RICHTOOLTIP 0x0010")]
        public const int TVS_EX_RICHTOOLTIP = 0x0010;

        [NativeTypeName("#define TVS_EX_AUTOHSCROLL 0x0020")]
        public const int TVS_EX_AUTOHSCROLL = 0x0020;

        [NativeTypeName("#define TVS_EX_FADEINOUTEXPANDOS 0x0040")]
        public const int TVS_EX_FADEINOUTEXPANDOS = 0x0040;

        [NativeTypeName("#define TVS_EX_PARTIALCHECKBOXES 0x0080")]
        public const int TVS_EX_PARTIALCHECKBOXES = 0x0080;

        [NativeTypeName("#define TVS_EX_EXCLUSIONCHECKBOXES 0x0100")]
        public const int TVS_EX_EXCLUSIONCHECKBOXES = 0x0100;

        [NativeTypeName("#define TVS_EX_DIMMEDCHECKBOXES 0x0200")]
        public const int TVS_EX_DIMMEDCHECKBOXES = 0x0200;

        [NativeTypeName("#define TVS_EX_DRAWIMAGEASYNC 0x0400")]
        public const int TVS_EX_DRAWIMAGEASYNC = 0x0400;

        [NativeTypeName("#define TVIF_TEXT 0x0001")]
        public const int TVIF_TEXT = 0x0001;

        [NativeTypeName("#define TVIF_IMAGE 0x0002")]
        public const int TVIF_IMAGE = 0x0002;

        [NativeTypeName("#define TVIF_PARAM 0x0004")]
        public const int TVIF_PARAM = 0x0004;

        [NativeTypeName("#define TVIF_STATE 0x0008")]
        public const int TVIF_STATE = 0x0008;

        [NativeTypeName("#define TVIF_HANDLE 0x0010")]
        public const int TVIF_HANDLE = 0x0010;

        [NativeTypeName("#define TVIF_SELECTEDIMAGE 0x0020")]
        public const int TVIF_SELECTEDIMAGE = 0x0020;

        [NativeTypeName("#define TVIF_CHILDREN 0x0040")]
        public const int TVIF_CHILDREN = 0x0040;

        [NativeTypeName("#define TVIF_INTEGRAL 0x0080")]
        public const int TVIF_INTEGRAL = 0x0080;

        [NativeTypeName("#define TVIF_STATEEX 0x0100")]
        public const int TVIF_STATEEX = 0x0100;

        [NativeTypeName("#define TVIF_EXPANDEDIMAGE 0x0200")]
        public const int TVIF_EXPANDEDIMAGE = 0x0200;

        [NativeTypeName("#define TVIS_SELECTED 0x0002")]
        public const int TVIS_SELECTED = 0x0002;

        [NativeTypeName("#define TVIS_CUT 0x0004")]
        public const int TVIS_CUT = 0x0004;

        [NativeTypeName("#define TVIS_DROPHILITED 0x0008")]
        public const int TVIS_DROPHILITED = 0x0008;

        [NativeTypeName("#define TVIS_BOLD 0x0010")]
        public const int TVIS_BOLD = 0x0010;

        [NativeTypeName("#define TVIS_EXPANDED 0x0020")]
        public const int TVIS_EXPANDED = 0x0020;

        [NativeTypeName("#define TVIS_EXPANDEDONCE 0x0040")]
        public const int TVIS_EXPANDEDONCE = 0x0040;

        [NativeTypeName("#define TVIS_EXPANDPARTIAL 0x0080")]
        public const int TVIS_EXPANDPARTIAL = 0x0080;

        [NativeTypeName("#define TVIS_OVERLAYMASK 0x0F00")]
        public const int TVIS_OVERLAYMASK = 0x0F00;

        [NativeTypeName("#define TVIS_STATEIMAGEMASK 0xF000")]
        public const int TVIS_STATEIMAGEMASK = 0xF000;

        [NativeTypeName("#define TVIS_USERMASK 0xF000")]
        public const int TVIS_USERMASK = 0xF000;

        [NativeTypeName("#define TVIS_EX_FLAT 0x0001")]
        public const int TVIS_EX_FLAT = 0x0001;

        [NativeTypeName("#define TVIS_EX_DISABLED 0x0002")]
        public const int TVIS_EX_DISABLED = 0x0002;

        [NativeTypeName("#define TVIS_EX_ALL 0x0002")]
        public const int TVIS_EX_ALL = 0x0002;

        [NativeTypeName("#define I_CHILDRENCALLBACK (-1)")]
        public const int I_CHILDRENCALLBACK = (-1);

        [NativeTypeName("#define I_CHILDRENAUTO (-2)")]
        public const int I_CHILDRENAUTO = (-2);

        [NativeTypeName("#define TVI_ROOT ((HTREEITEM)(ULONG_PTR)-0x10000)")]
        public static IntPtr TVI_ROOT => unchecked((nint)((nuint)(-0x10000)));

        [NativeTypeName("#define TVI_FIRST ((HTREEITEM)(ULONG_PTR)-0x0FFFF)")]
        public static IntPtr TVI_FIRST => unchecked((nint)((nuint)(-0x0FFFF)));

        [NativeTypeName("#define TVI_LAST ((HTREEITEM)(ULONG_PTR)-0x0FFFE)")]
        public static IntPtr TVI_LAST => unchecked((nint)((nuint)(-0x0FFFE)));

        [NativeTypeName("#define TVI_SORT ((HTREEITEM)(ULONG_PTR)-0x0FFFD)")]
        public static IntPtr TVI_SORT => unchecked((nint)((nuint)(-0x0FFFD)));

        [NativeTypeName("#define TVM_INSERTITEMA (TV_FIRST + 0)")]
        public const int TVM_INSERTITEMA = (0x1100 + 0);

        [NativeTypeName("#define TVM_INSERTITEMW (TV_FIRST + 50)")]
        public const int TVM_INSERTITEMW = (0x1100 + 50);

        [NativeTypeName("#define TVM_INSERTITEM TVM_INSERTITEMW")]
        public const int TVM_INSERTITEM = (0x1100 + 50);

        [NativeTypeName("#define TVM_DELETEITEM (TV_FIRST + 1)")]
        public const int TVM_DELETEITEM = (0x1100 + 1);

        [NativeTypeName("#define TVM_EXPAND (TV_FIRST + 2)")]
        public const int TVM_EXPAND = (0x1100 + 2);

        [NativeTypeName("#define TVE_COLLAPSE 0x0001")]
        public const int TVE_COLLAPSE = 0x0001;

        [NativeTypeName("#define TVE_EXPAND 0x0002")]
        public const int TVE_EXPAND = 0x0002;

        [NativeTypeName("#define TVE_TOGGLE 0x0003")]
        public const int TVE_TOGGLE = 0x0003;

        [NativeTypeName("#define TVE_EXPANDPARTIAL 0x4000")]
        public const int TVE_EXPANDPARTIAL = 0x4000;

        [NativeTypeName("#define TVE_COLLAPSERESET 0x8000")]
        public const int TVE_COLLAPSERESET = 0x8000;

        [NativeTypeName("#define TVM_GETITEMRECT (TV_FIRST + 4)")]
        public const int TVM_GETITEMRECT = (0x1100 + 4);

        [NativeTypeName("#define TVM_GETCOUNT (TV_FIRST + 5)")]
        public const int TVM_GETCOUNT = (0x1100 + 5);

        [NativeTypeName("#define TVM_GETINDENT (TV_FIRST + 6)")]
        public const int TVM_GETINDENT = (0x1100 + 6);

        [NativeTypeName("#define TVM_SETINDENT (TV_FIRST + 7)")]
        public const int TVM_SETINDENT = (0x1100 + 7);

        [NativeTypeName("#define TVM_GETIMAGELIST (TV_FIRST + 8)")]
        public const int TVM_GETIMAGELIST = (0x1100 + 8);

        [NativeTypeName("#define TVSIL_NORMAL 0")]
        public const int TVSIL_NORMAL = 0;

        [NativeTypeName("#define TVSIL_STATE 2")]
        public const int TVSIL_STATE = 2;

        [NativeTypeName("#define TVM_SETIMAGELIST (TV_FIRST + 9)")]
        public const int TVM_SETIMAGELIST = (0x1100 + 9);

        [NativeTypeName("#define TVM_GETNEXTITEM (TV_FIRST + 10)")]
        public const int TVM_GETNEXTITEM = (0x1100 + 10);

        [NativeTypeName("#define TVGN_ROOT 0x0000")]
        public const int TVGN_ROOT = 0x0000;

        [NativeTypeName("#define TVGN_NEXT 0x0001")]
        public const int TVGN_NEXT = 0x0001;

        [NativeTypeName("#define TVGN_PREVIOUS 0x0002")]
        public const int TVGN_PREVIOUS = 0x0002;

        [NativeTypeName("#define TVGN_PARENT 0x0003")]
        public const int TVGN_PARENT = 0x0003;

        [NativeTypeName("#define TVGN_CHILD 0x0004")]
        public const int TVGN_CHILD = 0x0004;

        [NativeTypeName("#define TVGN_FIRSTVISIBLE 0x0005")]
        public const int TVGN_FIRSTVISIBLE = 0x0005;

        [NativeTypeName("#define TVGN_NEXTVISIBLE 0x0006")]
        public const int TVGN_NEXTVISIBLE = 0x0006;

        [NativeTypeName("#define TVGN_PREVIOUSVISIBLE 0x0007")]
        public const int TVGN_PREVIOUSVISIBLE = 0x0007;

        [NativeTypeName("#define TVGN_DROPHILITE 0x0008")]
        public const int TVGN_DROPHILITE = 0x0008;

        [NativeTypeName("#define TVGN_CARET 0x0009")]
        public const int TVGN_CARET = 0x0009;

        [NativeTypeName("#define TVGN_LASTVISIBLE 0x000A")]
        public const int TVGN_LASTVISIBLE = 0x000A;

        [NativeTypeName("#define TVGN_NEXTSELECTED 0x000B")]
        public const int TVGN_NEXTSELECTED = 0x000B;

        [NativeTypeName("#define TVSI_NOSINGLEEXPAND 0x8000")]
        public const int TVSI_NOSINGLEEXPAND = 0x8000;

        [NativeTypeName("#define TVM_SELECTITEM (TV_FIRST + 11)")]
        public const int TVM_SELECTITEM = (0x1100 + 11);

        [NativeTypeName("#define TVM_GETITEMA (TV_FIRST + 12)")]
        public const int TVM_GETITEMA = (0x1100 + 12);

        [NativeTypeName("#define TVM_GETITEMW (TV_FIRST + 62)")]
        public const int TVM_GETITEMW = (0x1100 + 62);

        [NativeTypeName("#define TVM_GETITEM TVM_GETITEMW")]
        public const int TVM_GETITEM = (0x1100 + 62);

        [NativeTypeName("#define TVM_SETITEMA (TV_FIRST + 13)")]
        public const int TVM_SETITEMA = (0x1100 + 13);

        [NativeTypeName("#define TVM_SETITEMW (TV_FIRST + 63)")]
        public const int TVM_SETITEMW = (0x1100 + 63);

        [NativeTypeName("#define TVM_SETITEM TVM_SETITEMW")]
        public const int TVM_SETITEM = (0x1100 + 63);

        [NativeTypeName("#define TVM_EDITLABELA (TV_FIRST + 14)")]
        public const int TVM_EDITLABELA = (0x1100 + 14);

        [NativeTypeName("#define TVM_EDITLABELW (TV_FIRST + 65)")]
        public const int TVM_EDITLABELW = (0x1100 + 65);

        [NativeTypeName("#define TVM_EDITLABEL TVM_EDITLABELW")]
        public const int TVM_EDITLABEL = (0x1100 + 65);

        [NativeTypeName("#define TVM_GETEDITCONTROL (TV_FIRST + 15)")]
        public const int TVM_GETEDITCONTROL = (0x1100 + 15);

        [NativeTypeName("#define TVM_GETVISIBLECOUNT (TV_FIRST + 16)")]
        public const int TVM_GETVISIBLECOUNT = (0x1100 + 16);

        [NativeTypeName("#define TVM_HITTEST (TV_FIRST + 17)")]
        public const int TVM_HITTEST = (0x1100 + 17);

        [NativeTypeName("#define TVHT_NOWHERE 0x0001")]
        public const int TVHT_NOWHERE = 0x0001;

        [NativeTypeName("#define TVHT_ONITEMICON 0x0002")]
        public const int TVHT_ONITEMICON = 0x0002;

        [NativeTypeName("#define TVHT_ONITEMLABEL 0x0004")]
        public const int TVHT_ONITEMLABEL = 0x0004;

        [NativeTypeName("#define TVHT_ONITEM (TVHT_ONITEMICON | TVHT_ONITEMLABEL | TVHT_ONITEMSTATEICON)")]
        public const int TVHT_ONITEM = (0x0002 | 0x0004 | 0x0040);

        [NativeTypeName("#define TVHT_ONITEMINDENT 0x0008")]
        public const int TVHT_ONITEMINDENT = 0x0008;

        [NativeTypeName("#define TVHT_ONITEMBUTTON 0x0010")]
        public const int TVHT_ONITEMBUTTON = 0x0010;

        [NativeTypeName("#define TVHT_ONITEMRIGHT 0x0020")]
        public const int TVHT_ONITEMRIGHT = 0x0020;

        [NativeTypeName("#define TVHT_ONITEMSTATEICON 0x0040")]
        public const int TVHT_ONITEMSTATEICON = 0x0040;

        [NativeTypeName("#define TVHT_ABOVE 0x0100")]
        public const int TVHT_ABOVE = 0x0100;

        [NativeTypeName("#define TVHT_BELOW 0x0200")]
        public const int TVHT_BELOW = 0x0200;

        [NativeTypeName("#define TVHT_TORIGHT 0x0400")]
        public const int TVHT_TORIGHT = 0x0400;

        [NativeTypeName("#define TVHT_TOLEFT 0x0800")]
        public const int TVHT_TOLEFT = 0x0800;

        [NativeTypeName("#define TVM_CREATEDRAGIMAGE (TV_FIRST + 18)")]
        public const int TVM_CREATEDRAGIMAGE = (0x1100 + 18);

        [NativeTypeName("#define TVM_SORTCHILDREN (TV_FIRST + 19)")]
        public const int TVM_SORTCHILDREN = (0x1100 + 19);

        [NativeTypeName("#define TVM_ENSUREVISIBLE (TV_FIRST + 20)")]
        public const int TVM_ENSUREVISIBLE = (0x1100 + 20);

        [NativeTypeName("#define TVM_SORTCHILDRENCB (TV_FIRST + 21)")]
        public const int TVM_SORTCHILDRENCB = (0x1100 + 21);

        [NativeTypeName("#define TVM_ENDEDITLABELNOW (TV_FIRST + 22)")]
        public const int TVM_ENDEDITLABELNOW = (0x1100 + 22);

        [NativeTypeName("#define TVM_GETISEARCHSTRINGA (TV_FIRST + 23)")]
        public const int TVM_GETISEARCHSTRINGA = (0x1100 + 23);

        [NativeTypeName("#define TVM_GETISEARCHSTRINGW (TV_FIRST + 64)")]
        public const int TVM_GETISEARCHSTRINGW = (0x1100 + 64);

        [NativeTypeName("#define TVM_GETISEARCHSTRING TVM_GETISEARCHSTRINGW")]
        public const int TVM_GETISEARCHSTRING = (0x1100 + 64);

        [NativeTypeName("#define TVM_SETTOOLTIPS (TV_FIRST + 24)")]
        public const int TVM_SETTOOLTIPS = (0x1100 + 24);

        [NativeTypeName("#define TVM_GETTOOLTIPS (TV_FIRST + 25)")]
        public const int TVM_GETTOOLTIPS = (0x1100 + 25);

        [NativeTypeName("#define TVM_SETINSERTMARK (TV_FIRST + 26)")]
        public const int TVM_SETINSERTMARK = (0x1100 + 26);

        [NativeTypeName("#define TVM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int TVM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define TVM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int TVM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define TVM_SETITEMHEIGHT (TV_FIRST + 27)")]
        public const int TVM_SETITEMHEIGHT = (0x1100 + 27);

        [NativeTypeName("#define TVM_GETITEMHEIGHT (TV_FIRST + 28)")]
        public const int TVM_GETITEMHEIGHT = (0x1100 + 28);

        [NativeTypeName("#define TVM_SETBKCOLOR (TV_FIRST + 29)")]
        public const int TVM_SETBKCOLOR = (0x1100 + 29);

        [NativeTypeName("#define TVM_SETTEXTCOLOR (TV_FIRST + 30)")]
        public const int TVM_SETTEXTCOLOR = (0x1100 + 30);

        [NativeTypeName("#define TVM_GETBKCOLOR (TV_FIRST + 31)")]
        public const int TVM_GETBKCOLOR = (0x1100 + 31);

        [NativeTypeName("#define TVM_GETTEXTCOLOR (TV_FIRST + 32)")]
        public const int TVM_GETTEXTCOLOR = (0x1100 + 32);

        [NativeTypeName("#define TVM_SETSCROLLTIME (TV_FIRST + 33)")]
        public const int TVM_SETSCROLLTIME = (0x1100 + 33);

        [NativeTypeName("#define TVM_GETSCROLLTIME (TV_FIRST + 34)")]
        public const int TVM_GETSCROLLTIME = (0x1100 + 34);

        [NativeTypeName("#define TVM_SETINSERTMARKCOLOR (TV_FIRST + 37)")]
        public const int TVM_SETINSERTMARKCOLOR = (0x1100 + 37);

        [NativeTypeName("#define TVM_GETINSERTMARKCOLOR (TV_FIRST + 38)")]
        public const int TVM_GETINSERTMARKCOLOR = (0x1100 + 38);

        [NativeTypeName("#define TVM_SETBORDER (TV_FIRST + 35)")]
        public const int TVM_SETBORDER = (0x1100 + 35);

        [NativeTypeName("#define TVSBF_XBORDER 0x00000001")]
        public const int TVSBF_XBORDER = 0x00000001;

        [NativeTypeName("#define TVSBF_YBORDER 0x00000002")]
        public const int TVSBF_YBORDER = 0x00000002;

        [NativeTypeName("#define TVM_GETITEMSTATE (TV_FIRST + 39)")]
        public const int TVM_GETITEMSTATE = (0x1100 + 39);

        [NativeTypeName("#define TVM_SETLINECOLOR (TV_FIRST + 40)")]
        public const int TVM_SETLINECOLOR = (0x1100 + 40);

        [NativeTypeName("#define TVM_GETLINECOLOR (TV_FIRST + 41)")]
        public const int TVM_GETLINECOLOR = (0x1100 + 41);

        [NativeTypeName("#define TVM_MAPACCIDTOHTREEITEM (TV_FIRST + 42)")]
        public const int TVM_MAPACCIDTOHTREEITEM = (0x1100 + 42);

        [NativeTypeName("#define TVM_MAPHTREEITEMTOACCID (TV_FIRST + 43)")]
        public const int TVM_MAPHTREEITEMTOACCID = (0x1100 + 43);

        [NativeTypeName("#define TVM_SETEXTENDEDSTYLE (TV_FIRST + 44)")]
        public const int TVM_SETEXTENDEDSTYLE = (0x1100 + 44);

        [NativeTypeName("#define TVM_GETEXTENDEDSTYLE (TV_FIRST + 45)")]
        public const int TVM_GETEXTENDEDSTYLE = (0x1100 + 45);

        [NativeTypeName("#define TVM_SETAUTOSCROLLINFO (TV_FIRST + 59)")]
        public const int TVM_SETAUTOSCROLLINFO = (0x1100 + 59);

        [NativeTypeName("#define TVM_SETHOT (TV_FIRST + 58)")]
        public const int TVM_SETHOT = (0x1100 + 58);

        [NativeTypeName("#define TVM_GETSELECTEDCOUNT (TV_FIRST + 70)")]
        public const int TVM_GETSELECTEDCOUNT = (0x1100 + 70);

        [NativeTypeName("#define TVM_SHOWINFOTIP (TV_FIRST + 71)")]
        public const int TVM_SHOWINFOTIP = (0x1100 + 71);

        [NativeTypeName("#define TVM_GETITEMPARTRECT (TV_FIRST + 72)")]
        public const int TVM_GETITEMPARTRECT = (0x1100 + 72);

        [NativeTypeName("#define TVN_SELCHANGINGA (TVN_FIRST-1)")]
        public const uint TVN_SELCHANGINGA = unchecked((0U - 400U) - 1);

        [NativeTypeName("#define TVN_SELCHANGINGW (TVN_FIRST-50)")]
        public const uint TVN_SELCHANGINGW = unchecked((0U - 400U) - 50);

        [NativeTypeName("#define TVN_SELCHANGEDA (TVN_FIRST-2)")]
        public const uint TVN_SELCHANGEDA = unchecked((0U - 400U) - 2);

        [NativeTypeName("#define TVN_SELCHANGEDW (TVN_FIRST-51)")]
        public const uint TVN_SELCHANGEDW = unchecked((0U - 400U) - 51);

        [NativeTypeName("#define TVC_UNKNOWN 0x0000")]
        public const int TVC_UNKNOWN = 0x0000;

        [NativeTypeName("#define TVC_BYMOUSE 0x0001")]
        public const int TVC_BYMOUSE = 0x0001;

        [NativeTypeName("#define TVC_BYKEYBOARD 0x0002")]
        public const int TVC_BYKEYBOARD = 0x0002;

        [NativeTypeName("#define TVN_GETDISPINFOA (TVN_FIRST-3)")]
        public const uint TVN_GETDISPINFOA = unchecked((0U - 400U) - 3);

        [NativeTypeName("#define TVN_GETDISPINFOW (TVN_FIRST-52)")]
        public const uint TVN_GETDISPINFOW = unchecked((0U - 400U) - 52);

        [NativeTypeName("#define TVN_SETDISPINFOA (TVN_FIRST-4)")]
        public const uint TVN_SETDISPINFOA = unchecked((0U - 400U) - 4);

        [NativeTypeName("#define TVN_SETDISPINFOW (TVN_FIRST-53)")]
        public const uint TVN_SETDISPINFOW = unchecked((0U - 400U) - 53);

        [NativeTypeName("#define TVIF_DI_SETITEM 0x1000")]
        public const int TVIF_DI_SETITEM = 0x1000;

        [NativeTypeName("#define TVN_ITEMEXPANDINGA (TVN_FIRST-5)")]
        public const uint TVN_ITEMEXPANDINGA = unchecked((0U - 400U) - 5);

        [NativeTypeName("#define TVN_ITEMEXPANDINGW (TVN_FIRST-54)")]
        public const uint TVN_ITEMEXPANDINGW = unchecked((0U - 400U) - 54);

        [NativeTypeName("#define TVN_ITEMEXPANDEDA (TVN_FIRST-6)")]
        public const uint TVN_ITEMEXPANDEDA = unchecked((0U - 400U) - 6);

        [NativeTypeName("#define TVN_ITEMEXPANDEDW (TVN_FIRST-55)")]
        public const uint TVN_ITEMEXPANDEDW = unchecked((0U - 400U) - 55);

        [NativeTypeName("#define TVN_BEGINDRAGA (TVN_FIRST-7)")]
        public const uint TVN_BEGINDRAGA = unchecked((0U - 400U) - 7);

        [NativeTypeName("#define TVN_BEGINDRAGW (TVN_FIRST-56)")]
        public const uint TVN_BEGINDRAGW = unchecked((0U - 400U) - 56);

        [NativeTypeName("#define TVN_BEGINRDRAGA (TVN_FIRST-8)")]
        public const uint TVN_BEGINRDRAGA = unchecked((0U - 400U) - 8);

        [NativeTypeName("#define TVN_BEGINRDRAGW (TVN_FIRST-57)")]
        public const uint TVN_BEGINRDRAGW = unchecked((0U - 400U) - 57);

        [NativeTypeName("#define TVN_DELETEITEMA (TVN_FIRST-9)")]
        public const uint TVN_DELETEITEMA = unchecked((0U - 400U) - 9);

        [NativeTypeName("#define TVN_DELETEITEMW (TVN_FIRST-58)")]
        public const uint TVN_DELETEITEMW = unchecked((0U - 400U) - 58);

        [NativeTypeName("#define TVN_BEGINLABELEDITA (TVN_FIRST-10)")]
        public const uint TVN_BEGINLABELEDITA = unchecked((0U - 400U) - 10);

        [NativeTypeName("#define TVN_BEGINLABELEDITW (TVN_FIRST-59)")]
        public const uint TVN_BEGINLABELEDITW = unchecked((0U - 400U) - 59);

        [NativeTypeName("#define TVN_ENDLABELEDITA (TVN_FIRST-11)")]
        public const uint TVN_ENDLABELEDITA = unchecked((0U - 400U) - 11);

        [NativeTypeName("#define TVN_ENDLABELEDITW (TVN_FIRST-60)")]
        public const uint TVN_ENDLABELEDITW = unchecked((0U - 400U) - 60);

        [NativeTypeName("#define TVN_KEYDOWN (TVN_FIRST-12)")]
        public const uint TVN_KEYDOWN = unchecked((0U - 400U) - 12);

        [NativeTypeName("#define TVN_GETINFOTIPA (TVN_FIRST-13)")]
        public const uint TVN_GETINFOTIPA = unchecked((0U - 400U) - 13);

        [NativeTypeName("#define TVN_GETINFOTIPW (TVN_FIRST-14)")]
        public const uint TVN_GETINFOTIPW = unchecked((0U - 400U) - 14);

        [NativeTypeName("#define TVN_SINGLEEXPAND (TVN_FIRST-15)")]
        public const uint TVN_SINGLEEXPAND = unchecked((0U - 400U) - 15);

        [NativeTypeName("#define TVNRET_DEFAULT 0")]
        public const int TVNRET_DEFAULT = 0;

        [NativeTypeName("#define TVNRET_SKIPOLD 1")]
        public const int TVNRET_SKIPOLD = 1;

        [NativeTypeName("#define TVNRET_SKIPNEW 2")]
        public const int TVNRET_SKIPNEW = 2;

        [NativeTypeName("#define TVN_ITEMCHANGINGA (TVN_FIRST-16)")]
        public const uint TVN_ITEMCHANGINGA = unchecked((0U - 400U) - 16);

        [NativeTypeName("#define TVN_ITEMCHANGINGW (TVN_FIRST-17)")]
        public const uint TVN_ITEMCHANGINGW = unchecked((0U - 400U) - 17);

        [NativeTypeName("#define TVN_ITEMCHANGEDA (TVN_FIRST-18)")]
        public const uint TVN_ITEMCHANGEDA = unchecked((0U - 400U) - 18);

        [NativeTypeName("#define TVN_ITEMCHANGEDW (TVN_FIRST-19)")]
        public const uint TVN_ITEMCHANGEDW = unchecked((0U - 400U) - 19);

        [NativeTypeName("#define TVN_ASYNCDRAW (TVN_FIRST-20)")]
        public const uint TVN_ASYNCDRAW = unchecked((0U - 400U) - 20);

        [NativeTypeName("#define TVN_SELCHANGING TVN_SELCHANGINGW")]
        public const uint TVN_SELCHANGING = unchecked((0U - 400U) - 50);

        [NativeTypeName("#define TVN_SELCHANGED TVN_SELCHANGEDW")]
        public const uint TVN_SELCHANGED = unchecked((0U - 400U) - 51);

        [NativeTypeName("#define TVN_GETDISPINFO TVN_GETDISPINFOW")]
        public const uint TVN_GETDISPINFO = unchecked((0U - 400U) - 52);

        [NativeTypeName("#define TVN_SETDISPINFO TVN_SETDISPINFOW")]
        public const uint TVN_SETDISPINFO = unchecked((0U - 400U) - 53);

        [NativeTypeName("#define TVN_ITEMEXPANDING TVN_ITEMEXPANDINGW")]
        public const uint TVN_ITEMEXPANDING = unchecked((0U - 400U) - 54);

        [NativeTypeName("#define TVN_ITEMEXPANDED TVN_ITEMEXPANDEDW")]
        public const uint TVN_ITEMEXPANDED = unchecked((0U - 400U) - 55);

        [NativeTypeName("#define TVN_BEGINDRAG TVN_BEGINDRAGW")]
        public const uint TVN_BEGINDRAG = unchecked((0U - 400U) - 56);

        [NativeTypeName("#define TVN_BEGINRDRAG TVN_BEGINRDRAGW")]
        public const uint TVN_BEGINRDRAG = unchecked((0U - 400U) - 57);

        [NativeTypeName("#define TVN_DELETEITEM TVN_DELETEITEMW")]
        public const uint TVN_DELETEITEM = unchecked((0U - 400U) - 58);

        [NativeTypeName("#define TVN_BEGINLABELEDIT TVN_BEGINLABELEDITW")]
        public const uint TVN_BEGINLABELEDIT = unchecked((0U - 400U) - 59);

        [NativeTypeName("#define TVN_ENDLABELEDIT TVN_ENDLABELEDITW")]
        public const uint TVN_ENDLABELEDIT = unchecked((0U - 400U) - 60);

        [NativeTypeName("#define TVN_GETINFOTIP TVN_GETINFOTIPW")]
        public const uint TVN_GETINFOTIP = unchecked((0U - 400U) - 14);

        [NativeTypeName("#define TVCDRF_NOIMAGES 0x00010000")]
        public const int TVCDRF_NOIMAGES = 0x00010000;

        [NativeTypeName("#define TVN_ITEMCHANGING TVN_ITEMCHANGINGW")]
        public const uint TVN_ITEMCHANGING = unchecked((0U - 400U) - 17);

        [NativeTypeName("#define TVN_ITEMCHANGED TVN_ITEMCHANGEDW")]
        public const uint TVN_ITEMCHANGED = unchecked((0U - 400U) - 19);

        [NativeTypeName("#define WC_COMBOBOXEXW L\"ComboBoxEx32\"")]
        public const string WC_COMBOBOXEXW = "ComboBoxEx32";

        [NativeTypeName("#define WC_COMBOBOXEXA \"ComboBoxEx32\"")]
        public static ReadOnlySpan<byte> WC_COMBOBOXEXA => new byte[] { 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x42, 0x6F, 0x78, 0x45, 0x78, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_COMBOBOXEX WC_COMBOBOXEXW")]
        public const string WC_COMBOBOXEX = "ComboBoxEx32";

        [NativeTypeName("#define CBEIF_TEXT 0x00000001")]
        public const int CBEIF_TEXT = 0x00000001;

        [NativeTypeName("#define CBEIF_IMAGE 0x00000002")]
        public const int CBEIF_IMAGE = 0x00000002;

        [NativeTypeName("#define CBEIF_SELECTEDIMAGE 0x00000004")]
        public const int CBEIF_SELECTEDIMAGE = 0x00000004;

        [NativeTypeName("#define CBEIF_OVERLAY 0x00000008")]
        public const int CBEIF_OVERLAY = 0x00000008;

        [NativeTypeName("#define CBEIF_INDENT 0x00000010")]
        public const int CBEIF_INDENT = 0x00000010;

        [NativeTypeName("#define CBEIF_LPARAM 0x00000020")]
        public const int CBEIF_LPARAM = 0x00000020;

        [NativeTypeName("#define CBEIF_DI_SETITEM 0x10000000")]
        public const int CBEIF_DI_SETITEM = 0x10000000;

        [NativeTypeName("#define CBEM_INSERTITEMA (WM_USER + 1)")]
        public const int CBEM_INSERTITEMA = (0x0400 + 1);

        [NativeTypeName("#define CBEM_SETIMAGELIST (WM_USER + 2)")]
        public const int CBEM_SETIMAGELIST = (0x0400 + 2);

        [NativeTypeName("#define CBEM_GETIMAGELIST (WM_USER + 3)")]
        public const int CBEM_GETIMAGELIST = (0x0400 + 3);

        [NativeTypeName("#define CBEM_GETITEMA (WM_USER + 4)")]
        public const int CBEM_GETITEMA = (0x0400 + 4);

        [NativeTypeName("#define CBEM_SETITEMA (WM_USER + 5)")]
        public const int CBEM_SETITEMA = (0x0400 + 5);

        [NativeTypeName("#define CBEM_DELETEITEM CB_DELETESTRING")]
        public const int CBEM_DELETEITEM = 0x0144;

        [NativeTypeName("#define CBEM_GETCOMBOCONTROL (WM_USER + 6)")]
        public const int CBEM_GETCOMBOCONTROL = (0x0400 + 6);

        [NativeTypeName("#define CBEM_GETEDITCONTROL (WM_USER + 7)")]
        public const int CBEM_GETEDITCONTROL = (0x0400 + 7);

        [NativeTypeName("#define CBEM_SETEXSTYLE (WM_USER + 8)")]
        public const int CBEM_SETEXSTYLE = (0x0400 + 8);

        [NativeTypeName("#define CBEM_SETEXTENDEDSTYLE (WM_USER + 14)")]
        public const int CBEM_SETEXTENDEDSTYLE = (0x0400 + 14);

        [NativeTypeName("#define CBEM_GETEXSTYLE (WM_USER + 9)")]
        public const int CBEM_GETEXSTYLE = (0x0400 + 9);

        [NativeTypeName("#define CBEM_GETEXTENDEDSTYLE (WM_USER + 9)")]
        public const int CBEM_GETEXTENDEDSTYLE = (0x0400 + 9);

        [NativeTypeName("#define CBEM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int CBEM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define CBEM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int CBEM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define CBEM_HASEDITCHANGED (WM_USER + 10)")]
        public const int CBEM_HASEDITCHANGED = (0x0400 + 10);

        [NativeTypeName("#define CBEM_INSERTITEMW (WM_USER + 11)")]
        public const int CBEM_INSERTITEMW = (0x0400 + 11);

        [NativeTypeName("#define CBEM_SETITEMW (WM_USER + 12)")]
        public const int CBEM_SETITEMW = (0x0400 + 12);

        [NativeTypeName("#define CBEM_GETITEMW (WM_USER + 13)")]
        public const int CBEM_GETITEMW = (0x0400 + 13);

        [NativeTypeName("#define CBEM_INSERTITEM CBEM_INSERTITEMW")]
        public const int CBEM_INSERTITEM = (0x0400 + 11);

        [NativeTypeName("#define CBEM_SETITEM CBEM_SETITEMW")]
        public const int CBEM_SETITEM = (0x0400 + 12);

        [NativeTypeName("#define CBEM_GETITEM CBEM_GETITEMW")]
        public const int CBEM_GETITEM = (0x0400 + 13);

        [NativeTypeName("#define CBEM_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
        public const int CBEM_SETWINDOWTHEME = (0x2000 + 0xb);

        [NativeTypeName("#define CBES_EX_NOEDITIMAGE 0x00000001")]
        public const int CBES_EX_NOEDITIMAGE = 0x00000001;

        [NativeTypeName("#define CBES_EX_NOEDITIMAGEINDENT 0x00000002")]
        public const int CBES_EX_NOEDITIMAGEINDENT = 0x00000002;

        [NativeTypeName("#define CBES_EX_PATHWORDBREAKPROC 0x00000004")]
        public const int CBES_EX_PATHWORDBREAKPROC = 0x00000004;

        [NativeTypeName("#define CBES_EX_NOSIZELIMIT 0x00000008")]
        public const int CBES_EX_NOSIZELIMIT = 0x00000008;

        [NativeTypeName("#define CBES_EX_CASESENSITIVE 0x00000010")]
        public const int CBES_EX_CASESENSITIVE = 0x00000010;

        [NativeTypeName("#define CBES_EX_TEXTENDELLIPSIS 0x00000020")]
        public const int CBES_EX_TEXTENDELLIPSIS = 0x00000020;

        [NativeTypeName("#define CBEN_GETDISPINFO CBEN_GETDISPINFOW")]
        public const uint CBEN_GETDISPINFO = unchecked((0U - 800U) - 7);

        [NativeTypeName("#define CBEN_GETDISPINFOA (CBEN_FIRST - 0)")]
        public const uint CBEN_GETDISPINFOA = unchecked((0U - 800U) - 0);

        [NativeTypeName("#define CBEN_INSERTITEM (CBEN_FIRST - 1)")]
        public const uint CBEN_INSERTITEM = unchecked((0U - 800U) - 1);

        [NativeTypeName("#define CBEN_DELETEITEM (CBEN_FIRST - 2)")]
        public const uint CBEN_DELETEITEM = unchecked((0U - 800U) - 2);

        [NativeTypeName("#define CBEN_BEGINEDIT (CBEN_FIRST - 4)")]
        public const uint CBEN_BEGINEDIT = unchecked((0U - 800U) - 4);

        [NativeTypeName("#define CBEN_ENDEDITA (CBEN_FIRST - 5)")]
        public const uint CBEN_ENDEDITA = unchecked((0U - 800U) - 5);

        [NativeTypeName("#define CBEN_ENDEDITW (CBEN_FIRST - 6)")]
        public const uint CBEN_ENDEDITW = unchecked((0U - 800U) - 6);

        [NativeTypeName("#define CBEN_GETDISPINFOW (CBEN_FIRST - 7)")]
        public const uint CBEN_GETDISPINFOW = unchecked((0U - 800U) - 7);

        [NativeTypeName("#define CBEN_DRAGBEGINA (CBEN_FIRST - 8)")]
        public const uint CBEN_DRAGBEGINA = unchecked((0U - 800U) - 8);

        [NativeTypeName("#define CBEN_DRAGBEGINW (CBEN_FIRST - 9)")]
        public const uint CBEN_DRAGBEGINW = unchecked((0U - 800U) - 9);

        [NativeTypeName("#define CBEN_DRAGBEGIN CBEN_DRAGBEGINW")]
        public const uint CBEN_DRAGBEGIN = unchecked((0U - 800U) - 9);

        [NativeTypeName("#define CBEN_ENDEDIT CBEN_ENDEDITW")]
        public const uint CBEN_ENDEDIT = unchecked((0U - 800U) - 6);

        [NativeTypeName("#define CBENF_KILLFOCUS 1")]
        public const int CBENF_KILLFOCUS = 1;

        [NativeTypeName("#define CBENF_RETURN 2")]
        public const int CBENF_RETURN = 2;

        [NativeTypeName("#define CBENF_ESCAPE 3")]
        public const int CBENF_ESCAPE = 3;

        [NativeTypeName("#define CBENF_DROPDOWN 4")]
        public const int CBENF_DROPDOWN = 4;

        [NativeTypeName("#define CBEMAXSTRLEN 260")]
        public const int CBEMAXSTRLEN = 260;

        [NativeTypeName("#define WC_TABCONTROLA \"SysTabControl32\"")]
        public static ReadOnlySpan<byte> WC_TABCONTROLA => new byte[] { 0x53, 0x79, 0x73, 0x54, 0x61, 0x62, 0x43, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_TABCONTROLW L\"SysTabControl32\"")]
        public const string WC_TABCONTROLW = "SysTabControl32";

        [NativeTypeName("#define WC_TABCONTROL WC_TABCONTROLW")]
        public const string WC_TABCONTROL = "SysTabControl32";

        [NativeTypeName("#define TCS_SCROLLOPPOSITE 0x0001")]
        public const int TCS_SCROLLOPPOSITE = 0x0001;

        [NativeTypeName("#define TCS_BOTTOM 0x0002")]
        public const int TCS_BOTTOM = 0x0002;

        [NativeTypeName("#define TCS_RIGHT 0x0002")]
        public const int TCS_RIGHT = 0x0002;

        [NativeTypeName("#define TCS_MULTISELECT 0x0004")]
        public const int TCS_MULTISELECT = 0x0004;

        [NativeTypeName("#define TCS_FLATBUTTONS 0x0008")]
        public const int TCS_FLATBUTTONS = 0x0008;

        [NativeTypeName("#define TCS_FORCEICONLEFT 0x0010")]
        public const int TCS_FORCEICONLEFT = 0x0010;

        [NativeTypeName("#define TCS_FORCELABELLEFT 0x0020")]
        public const int TCS_FORCELABELLEFT = 0x0020;

        [NativeTypeName("#define TCS_HOTTRACK 0x0040")]
        public const int TCS_HOTTRACK = 0x0040;

        [NativeTypeName("#define TCS_VERTICAL 0x0080")]
        public const int TCS_VERTICAL = 0x0080;

        [NativeTypeName("#define TCS_TABS 0x0000")]
        public const int TCS_TABS = 0x0000;

        [NativeTypeName("#define TCS_BUTTONS 0x0100")]
        public const int TCS_BUTTONS = 0x0100;

        [NativeTypeName("#define TCS_SINGLELINE 0x0000")]
        public const int TCS_SINGLELINE = 0x0000;

        [NativeTypeName("#define TCS_MULTILINE 0x0200")]
        public const int TCS_MULTILINE = 0x0200;

        [NativeTypeName("#define TCS_RIGHTJUSTIFY 0x0000")]
        public const int TCS_RIGHTJUSTIFY = 0x0000;

        [NativeTypeName("#define TCS_FIXEDWIDTH 0x0400")]
        public const int TCS_FIXEDWIDTH = 0x0400;

        [NativeTypeName("#define TCS_RAGGEDRIGHT 0x0800")]
        public const int TCS_RAGGEDRIGHT = 0x0800;

        [NativeTypeName("#define TCS_FOCUSONBUTTONDOWN 0x1000")]
        public const int TCS_FOCUSONBUTTONDOWN = 0x1000;

        [NativeTypeName("#define TCS_OWNERDRAWFIXED 0x2000")]
        public const int TCS_OWNERDRAWFIXED = 0x2000;

        [NativeTypeName("#define TCS_TOOLTIPS 0x4000")]
        public const int TCS_TOOLTIPS = 0x4000;

        [NativeTypeName("#define TCS_FOCUSNEVER 0x8000")]
        public const int TCS_FOCUSNEVER = 0x8000;

        [NativeTypeName("#define TCS_EX_FLATSEPARATORS 0x00000001")]
        public const int TCS_EX_FLATSEPARATORS = 0x00000001;

        [NativeTypeName("#define TCS_EX_REGISTERDROP 0x00000002")]
        public const int TCS_EX_REGISTERDROP = 0x00000002;

        [NativeTypeName("#define TCM_GETIMAGELIST (TCM_FIRST + 2)")]
        public const int TCM_GETIMAGELIST = (0x1300 + 2);

        [NativeTypeName("#define TCM_SETIMAGELIST (TCM_FIRST + 3)")]
        public const int TCM_SETIMAGELIST = (0x1300 + 3);

        [NativeTypeName("#define TCM_GETITEMCOUNT (TCM_FIRST + 4)")]
        public const int TCM_GETITEMCOUNT = (0x1300 + 4);

        [NativeTypeName("#define TCIF_TEXT 0x0001")]
        public const int TCIF_TEXT = 0x0001;

        [NativeTypeName("#define TCIF_IMAGE 0x0002")]
        public const int TCIF_IMAGE = 0x0002;

        [NativeTypeName("#define TCIF_RTLREADING 0x0004")]
        public const int TCIF_RTLREADING = 0x0004;

        [NativeTypeName("#define TCIF_PARAM 0x0008")]
        public const int TCIF_PARAM = 0x0008;

        [NativeTypeName("#define TCIF_STATE 0x0010")]
        public const int TCIF_STATE = 0x0010;

        [NativeTypeName("#define TCIS_BUTTONPRESSED 0x0001")]
        public const int TCIS_BUTTONPRESSED = 0x0001;

        [NativeTypeName("#define TCIS_HIGHLIGHTED 0x0002")]
        public const int TCIS_HIGHLIGHTED = 0x0002;

        [NativeTypeName("#define TCM_GETITEMA (TCM_FIRST + 5)")]
        public const int TCM_GETITEMA = (0x1300 + 5);

        [NativeTypeName("#define TCM_GETITEMW (TCM_FIRST + 60)")]
        public const int TCM_GETITEMW = (0x1300 + 60);

        [NativeTypeName("#define TCM_GETITEM TCM_GETITEMW")]
        public const int TCM_GETITEM = (0x1300 + 60);

        [NativeTypeName("#define TCM_SETITEMA (TCM_FIRST + 6)")]
        public const int TCM_SETITEMA = (0x1300 + 6);

        [NativeTypeName("#define TCM_SETITEMW (TCM_FIRST + 61)")]
        public const int TCM_SETITEMW = (0x1300 + 61);

        [NativeTypeName("#define TCM_SETITEM TCM_SETITEMW")]
        public const int TCM_SETITEM = (0x1300 + 61);

        [NativeTypeName("#define TCM_INSERTITEMA (TCM_FIRST + 7)")]
        public const int TCM_INSERTITEMA = (0x1300 + 7);

        [NativeTypeName("#define TCM_INSERTITEMW (TCM_FIRST + 62)")]
        public const int TCM_INSERTITEMW = (0x1300 + 62);

        [NativeTypeName("#define TCM_INSERTITEM TCM_INSERTITEMW")]
        public const int TCM_INSERTITEM = (0x1300 + 62);

        [NativeTypeName("#define TCM_DELETEITEM (TCM_FIRST + 8)")]
        public const int TCM_DELETEITEM = (0x1300 + 8);

        [NativeTypeName("#define TCM_DELETEALLITEMS (TCM_FIRST + 9)")]
        public const int TCM_DELETEALLITEMS = (0x1300 + 9);

        [NativeTypeName("#define TCM_GETITEMRECT (TCM_FIRST + 10)")]
        public const int TCM_GETITEMRECT = (0x1300 + 10);

        [NativeTypeName("#define TCM_GETCURSEL (TCM_FIRST + 11)")]
        public const int TCM_GETCURSEL = (0x1300 + 11);

        [NativeTypeName("#define TCM_SETCURSEL (TCM_FIRST + 12)")]
        public const int TCM_SETCURSEL = (0x1300 + 12);

        [NativeTypeName("#define TCHT_NOWHERE 0x0001")]
        public const int TCHT_NOWHERE = 0x0001;

        [NativeTypeName("#define TCHT_ONITEMICON 0x0002")]
        public const int TCHT_ONITEMICON = 0x0002;

        [NativeTypeName("#define TCHT_ONITEMLABEL 0x0004")]
        public const int TCHT_ONITEMLABEL = 0x0004;

        [NativeTypeName("#define TCHT_ONITEM (TCHT_ONITEMICON | TCHT_ONITEMLABEL)")]
        public const int TCHT_ONITEM = (0x0002 | 0x0004);

        [NativeTypeName("#define TCM_HITTEST (TCM_FIRST + 13)")]
        public const int TCM_HITTEST = (0x1300 + 13);

        [NativeTypeName("#define TCM_SETITEMEXTRA (TCM_FIRST + 14)")]
        public const int TCM_SETITEMEXTRA = (0x1300 + 14);

        [NativeTypeName("#define TCM_ADJUSTRECT (TCM_FIRST + 40)")]
        public const int TCM_ADJUSTRECT = (0x1300 + 40);

        [NativeTypeName("#define TCM_SETITEMSIZE (TCM_FIRST + 41)")]
        public const int TCM_SETITEMSIZE = (0x1300 + 41);

        [NativeTypeName("#define TCM_REMOVEIMAGE (TCM_FIRST + 42)")]
        public const int TCM_REMOVEIMAGE = (0x1300 + 42);

        [NativeTypeName("#define TCM_SETPADDING (TCM_FIRST + 43)")]
        public const int TCM_SETPADDING = (0x1300 + 43);

        [NativeTypeName("#define TCM_GETROWCOUNT (TCM_FIRST + 44)")]
        public const int TCM_GETROWCOUNT = (0x1300 + 44);

        [NativeTypeName("#define TCM_GETTOOLTIPS (TCM_FIRST + 45)")]
        public const int TCM_GETTOOLTIPS = (0x1300 + 45);

        [NativeTypeName("#define TCM_SETTOOLTIPS (TCM_FIRST + 46)")]
        public const int TCM_SETTOOLTIPS = (0x1300 + 46);

        [NativeTypeName("#define TCM_GETCURFOCUS (TCM_FIRST + 47)")]
        public const int TCM_GETCURFOCUS = (0x1300 + 47);

        [NativeTypeName("#define TCM_SETCURFOCUS (TCM_FIRST + 48)")]
        public const int TCM_SETCURFOCUS = (0x1300 + 48);

        [NativeTypeName("#define TCM_SETMINTABWIDTH (TCM_FIRST + 49)")]
        public const int TCM_SETMINTABWIDTH = (0x1300 + 49);

        [NativeTypeName("#define TCM_DESELECTALL (TCM_FIRST + 50)")]
        public const int TCM_DESELECTALL = (0x1300 + 50);

        [NativeTypeName("#define TCM_HIGHLIGHTITEM (TCM_FIRST + 51)")]
        public const int TCM_HIGHLIGHTITEM = (0x1300 + 51);

        [NativeTypeName("#define TCM_SETEXTENDEDSTYLE (TCM_FIRST + 52)")]
        public const int TCM_SETEXTENDEDSTYLE = (0x1300 + 52);

        [NativeTypeName("#define TCM_GETEXTENDEDSTYLE (TCM_FIRST + 53)")]
        public const int TCM_GETEXTENDEDSTYLE = (0x1300 + 53);

        [NativeTypeName("#define TCM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int TCM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define TCM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int TCM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define TCN_KEYDOWN (TCN_FIRST - 0)")]
        public const uint TCN_KEYDOWN = unchecked((0U - 550U) - 0);

        [NativeTypeName("#define TCN_SELCHANGE (TCN_FIRST - 1)")]
        public const uint TCN_SELCHANGE = unchecked((0U - 550U) - 1);

        [NativeTypeName("#define TCN_SELCHANGING (TCN_FIRST - 2)")]
        public const uint TCN_SELCHANGING = unchecked((0U - 550U) - 2);

        [NativeTypeName("#define TCN_GETOBJECT (TCN_FIRST - 3)")]
        public const uint TCN_GETOBJECT = unchecked((0U - 550U) - 3);

        [NativeTypeName("#define TCN_FOCUSCHANGE (TCN_FIRST - 4)")]
        public const uint TCN_FOCUSCHANGE = unchecked((0U - 550U) - 4);

        [NativeTypeName("#define ANIMATE_CLASSW L\"SysAnimate32\"")]
        public const string ANIMATE_CLASSW = "SysAnimate32";

        [NativeTypeName("#define ANIMATE_CLASSA \"SysAnimate32\"")]
        public static ReadOnlySpan<byte> ANIMATE_CLASSA => new byte[] { 0x53, 0x79, 0x73, 0x41, 0x6E, 0x69, 0x6D, 0x61, 0x74, 0x65, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define ANIMATE_CLASS ANIMATE_CLASSW")]
        public const string ANIMATE_CLASS = "SysAnimate32";

        [NativeTypeName("#define ACS_CENTER 0x0001")]
        public const int ACS_CENTER = 0x0001;

        [NativeTypeName("#define ACS_TRANSPARENT 0x0002")]
        public const int ACS_TRANSPARENT = 0x0002;

        [NativeTypeName("#define ACS_AUTOPLAY 0x0004")]
        public const int ACS_AUTOPLAY = 0x0004;

        [NativeTypeName("#define ACS_TIMER 0x0008")]
        public const int ACS_TIMER = 0x0008;

        [NativeTypeName("#define ACM_OPENA (WM_USER+100)")]
        public const int ACM_OPENA = (0x0400 + 100);

        [NativeTypeName("#define ACM_OPENW (WM_USER+103)")]
        public const int ACM_OPENW = (0x0400 + 103);

        [NativeTypeName("#define ACM_OPEN ACM_OPENW")]
        public const int ACM_OPEN = (0x0400 + 103);

        [NativeTypeName("#define ACM_PLAY (WM_USER+101)")]
        public const int ACM_PLAY = (0x0400 + 101);

        [NativeTypeName("#define ACM_STOP (WM_USER+102)")]
        public const int ACM_STOP = (0x0400 + 102);

        [NativeTypeName("#define ACM_ISPLAYING (WM_USER+104)")]
        public const int ACM_ISPLAYING = (0x0400 + 104);

        [NativeTypeName("#define ACN_START 1")]
        public const int ACN_START = 1;

        [NativeTypeName("#define ACN_STOP 2")]
        public const int ACN_STOP = 2;

        [NativeTypeName("#define MONTHCAL_CLASSW L\"SysMonthCal32\"")]
        public const string MONTHCAL_CLASSW = "SysMonthCal32";

        [NativeTypeName("#define MONTHCAL_CLASSA \"SysMonthCal32\"")]
        public static ReadOnlySpan<byte> MONTHCAL_CLASSA => new byte[] { 0x53, 0x79, 0x73, 0x4D, 0x6F, 0x6E, 0x74, 0x68, 0x43, 0x61, 0x6C, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define MONTHCAL_CLASS MONTHCAL_CLASSW")]
        public const string MONTHCAL_CLASS = "SysMonthCal32";

        [NativeTypeName("#define MCM_FIRST 0x1000")]
        public const int MCM_FIRST = 0x1000;

        [NativeTypeName("#define MCM_GETCURSEL (MCM_FIRST + 1)")]
        public const int MCM_GETCURSEL = (0x1000 + 1);

        [NativeTypeName("#define MCM_SETCURSEL (MCM_FIRST + 2)")]
        public const int MCM_SETCURSEL = (0x1000 + 2);

        [NativeTypeName("#define MCM_GETMAXSELCOUNT (MCM_FIRST + 3)")]
        public const int MCM_GETMAXSELCOUNT = (0x1000 + 3);

        [NativeTypeName("#define MCM_SETMAXSELCOUNT (MCM_FIRST + 4)")]
        public const int MCM_SETMAXSELCOUNT = (0x1000 + 4);

        [NativeTypeName("#define MCM_GETSELRANGE (MCM_FIRST + 5)")]
        public const int MCM_GETSELRANGE = (0x1000 + 5);

        [NativeTypeName("#define MCM_SETSELRANGE (MCM_FIRST + 6)")]
        public const int MCM_SETSELRANGE = (0x1000 + 6);

        [NativeTypeName("#define MCM_GETMONTHRANGE (MCM_FIRST + 7)")]
        public const int MCM_GETMONTHRANGE = (0x1000 + 7);

        [NativeTypeName("#define MCM_SETDAYSTATE (MCM_FIRST + 8)")]
        public const int MCM_SETDAYSTATE = (0x1000 + 8);

        [NativeTypeName("#define MCM_GETMINREQRECT (MCM_FIRST + 9)")]
        public const int MCM_GETMINREQRECT = (0x1000 + 9);

        [NativeTypeName("#define MCM_SETCOLOR (MCM_FIRST + 10)")]
        public const int MCM_SETCOLOR = (0x1000 + 10);

        [NativeTypeName("#define MCM_GETCOLOR (MCM_FIRST + 11)")]
        public const int MCM_GETCOLOR = (0x1000 + 11);

        [NativeTypeName("#define MCSC_BACKGROUND 0")]
        public const int MCSC_BACKGROUND = 0;

        [NativeTypeName("#define MCSC_TEXT 1")]
        public const int MCSC_TEXT = 1;

        [NativeTypeName("#define MCSC_TITLEBK 2")]
        public const int MCSC_TITLEBK = 2;

        [NativeTypeName("#define MCSC_TITLETEXT 3")]
        public const int MCSC_TITLETEXT = 3;

        [NativeTypeName("#define MCSC_MONTHBK 4")]
        public const int MCSC_MONTHBK = 4;

        [NativeTypeName("#define MCSC_TRAILINGTEXT 5")]
        public const int MCSC_TRAILINGTEXT = 5;

        [NativeTypeName("#define MCM_SETTODAY (MCM_FIRST + 12)")]
        public const int MCM_SETTODAY = (0x1000 + 12);

        [NativeTypeName("#define MCM_GETTODAY (MCM_FIRST + 13)")]
        public const int MCM_GETTODAY = (0x1000 + 13);

        [NativeTypeName("#define MCM_HITTEST (MCM_FIRST + 14)")]
        public const int MCM_HITTEST = (0x1000 + 14);

        [NativeTypeName("#define MCHT_TITLE 0x00010000")]
        public const int MCHT_TITLE = 0x00010000;

        [NativeTypeName("#define MCHT_CALENDAR 0x00020000")]
        public const int MCHT_CALENDAR = 0x00020000;

        [NativeTypeName("#define MCHT_TODAYLINK 0x00030000")]
        public const int MCHT_TODAYLINK = 0x00030000;

        [NativeTypeName("#define MCHT_CALENDARCONTROL 0x00100000")]
        public const int MCHT_CALENDARCONTROL = 0x00100000;

        [NativeTypeName("#define MCHT_NEXT 0x01000000")]
        public const int MCHT_NEXT = 0x01000000;

        [NativeTypeName("#define MCHT_PREV 0x02000000")]
        public const int MCHT_PREV = 0x02000000;

        [NativeTypeName("#define MCHT_NOWHERE 0x00000000")]
        public const int MCHT_NOWHERE = 0x00000000;

        [NativeTypeName("#define MCHT_TITLEBK (MCHT_TITLE)")]
        public const int MCHT_TITLEBK = (0x00010000);

        [NativeTypeName("#define MCHT_TITLEMONTH (MCHT_TITLE | 0x0001)")]
        public const int MCHT_TITLEMONTH = (0x00010000 | 0x0001);

        [NativeTypeName("#define MCHT_TITLEYEAR (MCHT_TITLE | 0x0002)")]
        public const int MCHT_TITLEYEAR = (0x00010000 | 0x0002);

        [NativeTypeName("#define MCHT_TITLEBTNNEXT (MCHT_TITLE | MCHT_NEXT | 0x0003)")]
        public const int MCHT_TITLEBTNNEXT = (0x00010000 | 0x01000000 | 0x0003);

        [NativeTypeName("#define MCHT_TITLEBTNPREV (MCHT_TITLE | MCHT_PREV | 0x0003)")]
        public const int MCHT_TITLEBTNPREV = (0x00010000 | 0x02000000 | 0x0003);

        [NativeTypeName("#define MCHT_CALENDARBK (MCHT_CALENDAR)")]
        public const int MCHT_CALENDARBK = (0x00020000);

        [NativeTypeName("#define MCHT_CALENDARDATE (MCHT_CALENDAR | 0x0001)")]
        public const int MCHT_CALENDARDATE = (0x00020000 | 0x0001);

        [NativeTypeName("#define MCHT_CALENDARDATENEXT (MCHT_CALENDARDATE | MCHT_NEXT)")]
        public const int MCHT_CALENDARDATENEXT = ((0x00020000 | 0x0001) | 0x01000000);

        [NativeTypeName("#define MCHT_CALENDARDATEPREV (MCHT_CALENDARDATE | MCHT_PREV)")]
        public const int MCHT_CALENDARDATEPREV = ((0x00020000 | 0x0001) | 0x02000000);

        [NativeTypeName("#define MCHT_CALENDARDAY (MCHT_CALENDAR | 0x0002)")]
        public const int MCHT_CALENDARDAY = (0x00020000 | 0x0002);

        [NativeTypeName("#define MCHT_CALENDARWEEKNUM (MCHT_CALENDAR | 0x0003)")]
        public const int MCHT_CALENDARWEEKNUM = (0x00020000 | 0x0003);

        [NativeTypeName("#define MCHT_CALENDARDATEMIN (MCHT_CALENDAR | 0x0004)")]
        public const int MCHT_CALENDARDATEMIN = (0x00020000 | 0x0004);

        [NativeTypeName("#define MCHT_CALENDARDATEMAX (MCHT_CALENDAR | 0x0005)")]
        public const int MCHT_CALENDARDATEMAX = (0x00020000 | 0x0005);

        [NativeTypeName("#define MCM_SETFIRSTDAYOFWEEK (MCM_FIRST + 15)")]
        public const int MCM_SETFIRSTDAYOFWEEK = (0x1000 + 15);

        [NativeTypeName("#define MCM_GETFIRSTDAYOFWEEK (MCM_FIRST + 16)")]
        public const int MCM_GETFIRSTDAYOFWEEK = (0x1000 + 16);

        [NativeTypeName("#define MCM_GETRANGE (MCM_FIRST + 17)")]
        public const int MCM_GETRANGE = (0x1000 + 17);

        [NativeTypeName("#define MCM_SETRANGE (MCM_FIRST + 18)")]
        public const int MCM_SETRANGE = (0x1000 + 18);

        [NativeTypeName("#define MCM_GETMONTHDELTA (MCM_FIRST + 19)")]
        public const int MCM_GETMONTHDELTA = (0x1000 + 19);

        [NativeTypeName("#define MCM_SETMONTHDELTA (MCM_FIRST + 20)")]
        public const int MCM_SETMONTHDELTA = (0x1000 + 20);

        [NativeTypeName("#define MCM_GETMAXTODAYWIDTH (MCM_FIRST + 21)")]
        public const int MCM_GETMAXTODAYWIDTH = (0x1000 + 21);

        [NativeTypeName("#define MCM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
        public const int MCM_SETUNICODEFORMAT = (0x2000 + 5);

        [NativeTypeName("#define MCM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
        public const int MCM_GETUNICODEFORMAT = (0x2000 + 6);

        [NativeTypeName("#define MCMV_MONTH 0")]
        public const int MCMV_MONTH = 0;

        [NativeTypeName("#define MCMV_YEAR 1")]
        public const int MCMV_YEAR = 1;

        [NativeTypeName("#define MCMV_DECADE 2")]
        public const int MCMV_DECADE = 2;

        [NativeTypeName("#define MCMV_CENTURY 3")]
        public const int MCMV_CENTURY = 3;

        [NativeTypeName("#define MCMV_MAX MCMV_CENTURY")]
        public const int MCMV_MAX = 3;

        [NativeTypeName("#define MCM_GETCURRENTVIEW (MCM_FIRST + 22)")]
        public const int MCM_GETCURRENTVIEW = (0x1000 + 22);

        [NativeTypeName("#define MCM_GETCALENDARCOUNT (MCM_FIRST + 23)")]
        public const int MCM_GETCALENDARCOUNT = (0x1000 + 23);

        [NativeTypeName("#define MCGIP_CALENDARCONTROL 0")]
        public const int MCGIP_CALENDARCONTROL = 0;

        [NativeTypeName("#define MCGIP_NEXT 1")]
        public const int MCGIP_NEXT = 1;

        [NativeTypeName("#define MCGIP_PREV 2")]
        public const int MCGIP_PREV = 2;

        [NativeTypeName("#define MCGIP_FOOTER 3")]
        public const int MCGIP_FOOTER = 3;

        [NativeTypeName("#define MCGIP_CALENDAR 4")]
        public const int MCGIP_CALENDAR = 4;

        [NativeTypeName("#define MCGIP_CALENDARHEADER 5")]
        public const int MCGIP_CALENDARHEADER = 5;

        [NativeTypeName("#define MCGIP_CALENDARBODY 6")]
        public const int MCGIP_CALENDARBODY = 6;

        [NativeTypeName("#define MCGIP_CALENDARROW 7")]
        public const int MCGIP_CALENDARROW = 7;

        [NativeTypeName("#define MCGIP_CALENDARCELL 8")]
        public const int MCGIP_CALENDARCELL = 8;

        [NativeTypeName("#define MCGIF_DATE 0x00000001")]
        public const int MCGIF_DATE = 0x00000001;

        [NativeTypeName("#define MCGIF_RECT 0x00000002")]
        public const int MCGIF_RECT = 0x00000002;

        [NativeTypeName("#define MCGIF_NAME 0x00000004")]
        public const int MCGIF_NAME = 0x00000004;

        [NativeTypeName("#define MCM_GETCALENDARGRIDINFO (MCM_FIRST + 24)")]
        public const int MCM_GETCALENDARGRIDINFO = (0x1000 + 24);

        [NativeTypeName("#define MCM_GETCALID (MCM_FIRST + 27)")]
        public const int MCM_GETCALID = (0x1000 + 27);

        [NativeTypeName("#define MCM_SETCALID (MCM_FIRST + 28)")]
        public const int MCM_SETCALID = (0x1000 + 28);

        [NativeTypeName("#define MCM_SIZERECTTOMIN (MCM_FIRST + 29)")]
        public const int MCM_SIZERECTTOMIN = (0x1000 + 29);

        [NativeTypeName("#define MCM_SETCALENDARBORDER (MCM_FIRST + 30)")]
        public const int MCM_SETCALENDARBORDER = (0x1000 + 30);

        [NativeTypeName("#define MCM_GETCALENDARBORDER (MCM_FIRST + 31)")]
        public const int MCM_GETCALENDARBORDER = (0x1000 + 31);

        [NativeTypeName("#define MCM_SETCURRENTVIEW (MCM_FIRST + 32)")]
        public const int MCM_SETCURRENTVIEW = (0x1000 + 32);

        [NativeTypeName("#define MCN_SELCHANGE (MCN_FIRST - 3)")]
        public const uint MCN_SELCHANGE = unchecked((0U - 746U) - 3);

        [NativeTypeName("#define MCN_GETDAYSTATE (MCN_FIRST - 1)")]
        public const uint MCN_GETDAYSTATE = unchecked((0U - 746U) - 1);

        [NativeTypeName("#define MCN_SELECT (MCN_FIRST)")]
        public const uint MCN_SELECT = unchecked((0U - 746U));

        [NativeTypeName("#define MCN_VIEWCHANGE (MCN_FIRST - 4)")]
        public const uint MCN_VIEWCHANGE = unchecked((0U - 746U) - 4);

        [NativeTypeName("#define MCS_DAYSTATE 0x0001")]
        public const int MCS_DAYSTATE = 0x0001;

        [NativeTypeName("#define MCS_MULTISELECT 0x0002")]
        public const int MCS_MULTISELECT = 0x0002;

        [NativeTypeName("#define MCS_WEEKNUMBERS 0x0004")]
        public const int MCS_WEEKNUMBERS = 0x0004;

        [NativeTypeName("#define MCS_NOTODAYCIRCLE 0x0008")]
        public const int MCS_NOTODAYCIRCLE = 0x0008;

        [NativeTypeName("#define MCS_NOTODAY 0x0010")]
        public const int MCS_NOTODAY = 0x0010;

        [NativeTypeName("#define MCS_NOTRAILINGDATES 0x0040")]
        public const int MCS_NOTRAILINGDATES = 0x0040;

        [NativeTypeName("#define MCS_SHORTDAYSOFWEEK 0x0080")]
        public const int MCS_SHORTDAYSOFWEEK = 0x0080;

        [NativeTypeName("#define MCS_NOSELCHANGEONNAV 0x0100")]
        public const int MCS_NOSELCHANGEONNAV = 0x0100;

        [NativeTypeName("#define GMR_VISIBLE 0")]
        public const int GMR_VISIBLE = 0;

        [NativeTypeName("#define GMR_DAYSTATE 1")]
        public const int GMR_DAYSTATE = 1;

        [NativeTypeName("#define DATETIMEPICK_CLASSW L\"SysDateTimePick32\"")]
        public const string DATETIMEPICK_CLASSW = "SysDateTimePick32";

        [NativeTypeName("#define DATETIMEPICK_CLASSA \"SysDateTimePick32\"")]
        public static ReadOnlySpan<byte> DATETIMEPICK_CLASSA => new byte[] { 0x53, 0x79, 0x73, 0x44, 0x61, 0x74, 0x65, 0x54, 0x69, 0x6D, 0x65, 0x50, 0x69, 0x63, 0x6B, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define DATETIMEPICK_CLASS DATETIMEPICK_CLASSW")]
        public const string DATETIMEPICK_CLASS = "SysDateTimePick32";

        [NativeTypeName("#define DTM_FIRST 0x1000")]
        public const int DTM_FIRST = 0x1000;

        [NativeTypeName("#define DTM_GETSYSTEMTIME (DTM_FIRST + 1)")]
        public const int DTM_GETSYSTEMTIME = (0x1000 + 1);

        [NativeTypeName("#define DTM_SETSYSTEMTIME (DTM_FIRST + 2)")]
        public const int DTM_SETSYSTEMTIME = (0x1000 + 2);

        [NativeTypeName("#define DTM_GETRANGE (DTM_FIRST + 3)")]
        public const int DTM_GETRANGE = (0x1000 + 3);

        [NativeTypeName("#define DTM_SETRANGE (DTM_FIRST + 4)")]
        public const int DTM_SETRANGE = (0x1000 + 4);

        [NativeTypeName("#define DTM_SETFORMATA (DTM_FIRST + 5)")]
        public const int DTM_SETFORMATA = (0x1000 + 5);

        [NativeTypeName("#define DTM_SETFORMATW (DTM_FIRST + 50)")]
        public const int DTM_SETFORMATW = (0x1000 + 50);

        [NativeTypeName("#define DTM_SETFORMAT DTM_SETFORMATW")]
        public const int DTM_SETFORMAT = (0x1000 + 50);

        [NativeTypeName("#define DTM_SETMCCOLOR (DTM_FIRST + 6)")]
        public const int DTM_SETMCCOLOR = (0x1000 + 6);

        [NativeTypeName("#define DTM_GETMCCOLOR (DTM_FIRST + 7)")]
        public const int DTM_GETMCCOLOR = (0x1000 + 7);

        [NativeTypeName("#define DTM_GETMONTHCAL (DTM_FIRST + 8)")]
        public const int DTM_GETMONTHCAL = (0x1000 + 8);

        [NativeTypeName("#define DTM_SETMCFONT (DTM_FIRST + 9)")]
        public const int DTM_SETMCFONT = (0x1000 + 9);

        [NativeTypeName("#define DTM_GETMCFONT (DTM_FIRST + 10)")]
        public const int DTM_GETMCFONT = (0x1000 + 10);

        [NativeTypeName("#define DTM_SETMCSTYLE (DTM_FIRST + 11)")]
        public const int DTM_SETMCSTYLE = (0x1000 + 11);

        [NativeTypeName("#define DTM_GETMCSTYLE (DTM_FIRST + 12)")]
        public const int DTM_GETMCSTYLE = (0x1000 + 12);

        [NativeTypeName("#define DTM_CLOSEMONTHCAL (DTM_FIRST + 13)")]
        public const int DTM_CLOSEMONTHCAL = (0x1000 + 13);

        [NativeTypeName("#define DTM_GETDATETIMEPICKERINFO (DTM_FIRST + 14)")]
        public const int DTM_GETDATETIMEPICKERINFO = (0x1000 + 14);

        [NativeTypeName("#define DTM_GETIDEALSIZE (DTM_FIRST + 15)")]
        public const int DTM_GETIDEALSIZE = (0x1000 + 15);

        [NativeTypeName("#define DTS_UPDOWN 0x0001")]
        public const int DTS_UPDOWN = 0x0001;

        [NativeTypeName("#define DTS_SHOWNONE 0x0002")]
        public const int DTS_SHOWNONE = 0x0002;

        [NativeTypeName("#define DTS_SHORTDATEFORMAT 0x0000")]
        public const int DTS_SHORTDATEFORMAT = 0x0000;

        [NativeTypeName("#define DTS_LONGDATEFORMAT 0x0004")]
        public const int DTS_LONGDATEFORMAT = 0x0004;

        [NativeTypeName("#define DTS_SHORTDATECENTURYFORMAT 0x000C")]
        public const int DTS_SHORTDATECENTURYFORMAT = 0x000C;

        [NativeTypeName("#define DTS_TIMEFORMAT 0x0009")]
        public const int DTS_TIMEFORMAT = 0x0009;

        [NativeTypeName("#define DTS_APPCANPARSE 0x0010")]
        public const int DTS_APPCANPARSE = 0x0010;

        [NativeTypeName("#define DTS_RIGHTALIGN 0x0020")]
        public const int DTS_RIGHTALIGN = 0x0020;

        [NativeTypeName("#define DTN_DATETIMECHANGE (DTN_FIRST2 - 6)")]
        public const uint DTN_DATETIMECHANGE = unchecked((0U - 753U) - 6);

        [NativeTypeName("#define DTN_USERSTRINGA (DTN_FIRST2 - 5)")]
        public const uint DTN_USERSTRINGA = unchecked((0U - 753U) - 5);

        [NativeTypeName("#define DTN_USERSTRINGW (DTN_FIRST - 5)")]
        public const uint DTN_USERSTRINGW = unchecked((0U - 740U) - 5);

        [NativeTypeName("#define DTN_USERSTRING DTN_USERSTRINGW")]
        public const uint DTN_USERSTRING = unchecked((0U - 740U) - 5);

        [NativeTypeName("#define DTN_WMKEYDOWNA (DTN_FIRST2 - 4)")]
        public const uint DTN_WMKEYDOWNA = unchecked((0U - 753U) - 4);

        [NativeTypeName("#define DTN_WMKEYDOWNW (DTN_FIRST - 4)")]
        public const uint DTN_WMKEYDOWNW = unchecked((0U - 740U) - 4);

        [NativeTypeName("#define DTN_WMKEYDOWN DTN_WMKEYDOWNW")]
        public const uint DTN_WMKEYDOWN = unchecked((0U - 740U) - 4);

        [NativeTypeName("#define DTN_FORMATA (DTN_FIRST2 - 3)")]
        public const uint DTN_FORMATA = unchecked((0U - 753U) - 3);

        [NativeTypeName("#define DTN_FORMATW (DTN_FIRST - 3)")]
        public const uint DTN_FORMATW = unchecked((0U - 740U) - 3);

        [NativeTypeName("#define DTN_FORMAT DTN_FORMATW")]
        public const uint DTN_FORMAT = unchecked((0U - 740U) - 3);

        [NativeTypeName("#define DTN_FORMATQUERYA (DTN_FIRST2 - 2)")]
        public const uint DTN_FORMATQUERYA = unchecked((0U - 753U) - 2);

        [NativeTypeName("#define DTN_FORMATQUERYW (DTN_FIRST - 2)")]
        public const uint DTN_FORMATQUERYW = unchecked((0U - 740U) - 2);

        [NativeTypeName("#define DTN_FORMATQUERY DTN_FORMATQUERYW")]
        public const uint DTN_FORMATQUERY = unchecked((0U - 740U) - 2);

        [NativeTypeName("#define DTN_DROPDOWN (DTN_FIRST2 - 1)")]
        public const uint DTN_DROPDOWN = unchecked((0U - 753U) - 1);

        [NativeTypeName("#define DTN_CLOSEUP (DTN_FIRST2)")]
        public const uint DTN_CLOSEUP = unchecked((0U - 753U));

        [NativeTypeName("#define GDTR_MIN 0x0001")]
        public const int GDTR_MIN = 0x0001;

        [NativeTypeName("#define GDTR_MAX 0x0002")]
        public const int GDTR_MAX = 0x0002;

        [NativeTypeName("#define GDT_ERROR -1")]
        public const int GDT_ERROR = -1;

        [NativeTypeName("#define GDT_VALID 0")]
        public const int GDT_VALID = 0;

        [NativeTypeName("#define GDT_NONE 1")]
        public const int GDT_NONE = 1;

        [NativeTypeName("#define IPM_CLEARADDRESS (WM_USER+100)")]
        public const int IPM_CLEARADDRESS = (0x0400 + 100);

        [NativeTypeName("#define IPM_SETADDRESS (WM_USER+101)")]
        public const int IPM_SETADDRESS = (0x0400 + 101);

        [NativeTypeName("#define IPM_GETADDRESS (WM_USER+102)")]
        public const int IPM_GETADDRESS = (0x0400 + 102);

        [NativeTypeName("#define IPM_SETRANGE (WM_USER+103)")]
        public const int IPM_SETRANGE = (0x0400 + 103);

        [NativeTypeName("#define IPM_SETFOCUS (WM_USER+104)")]
        public const int IPM_SETFOCUS = (0x0400 + 104);

        [NativeTypeName("#define IPM_ISBLANK (WM_USER+105)")]
        public const int IPM_ISBLANK = (0x0400 + 105);

        [NativeTypeName("#define WC_IPADDRESSW L\"SysIPAddress32\"")]
        public const string WC_IPADDRESSW = "SysIPAddress32";

        [NativeTypeName("#define WC_IPADDRESSA \"SysIPAddress32\"")]
        public static ReadOnlySpan<byte> WC_IPADDRESSA => new byte[] { 0x53, 0x79, 0x73, 0x49, 0x50, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x33, 0x32, 0x00 };

        [NativeTypeName("#define WC_IPADDRESS WC_IPADDRESSW")]
        public const string WC_IPADDRESS = "SysIPAddress32";

        [NativeTypeName("#define IPN_FIELDCHANGED (IPN_FIRST - 0)")]
        public const uint IPN_FIELDCHANGED = unchecked((0U - 860U) - 0);

        [NativeTypeName("#define WC_PAGESCROLLERW L\"SysPager\"")]
        public const string WC_PAGESCROLLERW = "SysPager";

        [NativeTypeName("#define WC_PAGESCROLLERA \"SysPager\"")]
        public static ReadOnlySpan<byte> WC_PAGESCROLLERA => new byte[] { 0x53, 0x79, 0x73, 0x50, 0x61, 0x67, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define WC_PAGESCROLLER WC_PAGESCROLLERW")]
        public const string WC_PAGESCROLLER = "SysPager";

        [NativeTypeName("#define PGS_VERT 0x00000000")]
        public const int PGS_VERT = 0x00000000;

        [NativeTypeName("#define PGS_HORZ 0x00000001")]
        public const int PGS_HORZ = 0x00000001;

        [NativeTypeName("#define PGS_AUTOSCROLL 0x00000002")]
        public const int PGS_AUTOSCROLL = 0x00000002;

        [NativeTypeName("#define PGS_DRAGNDROP 0x00000004")]
        public const int PGS_DRAGNDROP = 0x00000004;

        [NativeTypeName("#define PGF_INVISIBLE 0")]
        public const int PGF_INVISIBLE = 0;

        [NativeTypeName("#define PGF_NORMAL 1")]
        public const int PGF_NORMAL = 1;

        [NativeTypeName("#define PGF_GRAYED 2")]
        public const int PGF_GRAYED = 2;

        [NativeTypeName("#define PGF_DEPRESSED 4")]
        public const int PGF_DEPRESSED = 4;

        [NativeTypeName("#define PGF_HOT 8")]
        public const int PGF_HOT = 8;

        [NativeTypeName("#define PGB_TOPORLEFT 0")]
        public const int PGB_TOPORLEFT = 0;

        [NativeTypeName("#define PGB_BOTTOMORRIGHT 1")]
        public const int PGB_BOTTOMORRIGHT = 1;

        [NativeTypeName("#define PGM_SETCHILD (PGM_FIRST + 1)")]
        public const int PGM_SETCHILD = (0x1400 + 1);

        [NativeTypeName("#define PGM_RECALCSIZE (PGM_FIRST + 2)")]
        public const int PGM_RECALCSIZE = (0x1400 + 2);

        [NativeTypeName("#define PGM_FORWARDMOUSE (PGM_FIRST + 3)")]
        public const int PGM_FORWARDMOUSE = (0x1400 + 3);

        [NativeTypeName("#define PGM_SETBKCOLOR (PGM_FIRST + 4)")]
        public const int PGM_SETBKCOLOR = (0x1400 + 4);

        [NativeTypeName("#define PGM_GETBKCOLOR (PGM_FIRST + 5)")]
        public const int PGM_GETBKCOLOR = (0x1400 + 5);

        [NativeTypeName("#define PGM_SETBORDER (PGM_FIRST + 6)")]
        public const int PGM_SETBORDER = (0x1400 + 6);

        [NativeTypeName("#define PGM_GETBORDER (PGM_FIRST + 7)")]
        public const int PGM_GETBORDER = (0x1400 + 7);

        [NativeTypeName("#define PGM_SETPOS (PGM_FIRST + 8)")]
        public const int PGM_SETPOS = (0x1400 + 8);

        [NativeTypeName("#define PGM_GETPOS (PGM_FIRST + 9)")]
        public const int PGM_GETPOS = (0x1400 + 9);

        [NativeTypeName("#define PGM_SETBUTTONSIZE (PGM_FIRST + 10)")]
        public const int PGM_SETBUTTONSIZE = (0x1400 + 10);

        [NativeTypeName("#define PGM_GETBUTTONSIZE (PGM_FIRST + 11)")]
        public const int PGM_GETBUTTONSIZE = (0x1400 + 11);

        [NativeTypeName("#define PGM_GETBUTTONSTATE (PGM_FIRST + 12)")]
        public const int PGM_GETBUTTONSTATE = (0x1400 + 12);

        [NativeTypeName("#define PGM_GETDROPTARGET CCM_GETDROPTARGET")]
        public const int PGM_GETDROPTARGET = (0x2000 + 4);

        [NativeTypeName("#define PGM_SETSCROLLINFO (PGM_FIRST + 13)")]
        public const int PGM_SETSCROLLINFO = (0x1400 + 13);

        [NativeTypeName("#define PGN_SCROLL (PGN_FIRST-1)")]
        public const uint PGN_SCROLL = unchecked((0U - 900U) - 1);

        [NativeTypeName("#define PGF_SCROLLUP 1")]
        public const int PGF_SCROLLUP = 1;

        [NativeTypeName("#define PGF_SCROLLDOWN 2")]
        public const int PGF_SCROLLDOWN = 2;

        [NativeTypeName("#define PGF_SCROLLLEFT 4")]
        public const int PGF_SCROLLLEFT = 4;

        [NativeTypeName("#define PGF_SCROLLRIGHT 8")]
        public const int PGF_SCROLLRIGHT = 8;

        [NativeTypeName("#define PGK_SHIFT 1")]
        public const int PGK_SHIFT = 1;

        [NativeTypeName("#define PGK_CONTROL 2")]
        public const int PGK_CONTROL = 2;

        [NativeTypeName("#define PGK_MENU 4")]
        public const int PGK_MENU = 4;

        [NativeTypeName("#define PGN_CALCSIZE (PGN_FIRST-2)")]
        public const uint PGN_CALCSIZE = unchecked((0U - 900U) - 2);

        [NativeTypeName("#define PGF_CALCWIDTH 1")]
        public const int PGF_CALCWIDTH = 1;

        [NativeTypeName("#define PGF_CALCHEIGHT 2")]
        public const int PGF_CALCHEIGHT = 2;

        [NativeTypeName("#define PGN_HOTITEMCHANGE (PGN_FIRST-3)")]
        public const uint PGN_HOTITEMCHANGE = unchecked((0U - 900U) - 3);

        [NativeTypeName("#define WC_NATIVEFONTCTLW L\"NativeFontCtl\"")]
        public const string WC_NATIVEFONTCTLW = "NativeFontCtl";

        [NativeTypeName("#define WC_NATIVEFONTCTLA \"NativeFontCtl\"")]
        public static ReadOnlySpan<byte> WC_NATIVEFONTCTLA => new byte[] { 0x4E, 0x61, 0x74, 0x69, 0x76, 0x65, 0x46, 0x6F, 0x6E, 0x74, 0x43, 0x74, 0x6C, 0x00 };

        [NativeTypeName("#define WC_NATIVEFONTCTL WC_NATIVEFONTCTLW")]
        public const string WC_NATIVEFONTCTL = "NativeFontCtl";

        [NativeTypeName("#define NFS_EDIT 0x0001")]
        public const int NFS_EDIT = 0x0001;

        [NativeTypeName("#define NFS_STATIC 0x0002")]
        public const int NFS_STATIC = 0x0002;

        [NativeTypeName("#define NFS_LISTCOMBO 0x0004")]
        public const int NFS_LISTCOMBO = 0x0004;

        [NativeTypeName("#define NFS_BUTTON 0x0008")]
        public const int NFS_BUTTON = 0x0008;

        [NativeTypeName("#define NFS_ALL 0x0010")]
        public const int NFS_ALL = 0x0010;

        [NativeTypeName("#define NFS_USEFONTASSOC 0x0020")]
        public const int NFS_USEFONTASSOC = 0x0020;

        [NativeTypeName("#define WC_BUTTONA \"Button\"")]
        public static ReadOnlySpan<byte> WC_BUTTONA => new byte[] { 0x42, 0x75, 0x74, 0x74, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define WC_BUTTONW L\"Button\"")]
        public const string WC_BUTTONW = "Button";

        [NativeTypeName("#define WC_BUTTON WC_BUTTONW")]
        public const string WC_BUTTON = "Button";

        [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_LEFT 0")]
        public const int BUTTON_IMAGELIST_ALIGN_LEFT = 0;

        [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_RIGHT 1")]
        public const int BUTTON_IMAGELIST_ALIGN_RIGHT = 1;

        [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_TOP 2")]
        public const int BUTTON_IMAGELIST_ALIGN_TOP = 2;

        [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_BOTTOM 3")]
        public const int BUTTON_IMAGELIST_ALIGN_BOTTOM = 3;

        [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_CENTER 4")]
        public const int BUTTON_IMAGELIST_ALIGN_CENTER = 4;

        [NativeTypeName("#define BCM_GETIDEALSIZE (BCM_FIRST + 0x0001)")]
        public const int BCM_GETIDEALSIZE = (0x1600 + 0x0001);

        [NativeTypeName("#define BCM_SETIMAGELIST (BCM_FIRST + 0x0002)")]
        public const int BCM_SETIMAGELIST = (0x1600 + 0x0002);

        [NativeTypeName("#define BCM_GETIMAGELIST (BCM_FIRST + 0x0003)")]
        public const int BCM_GETIMAGELIST = (0x1600 + 0x0003);

        [NativeTypeName("#define BCM_SETTEXTMARGIN (BCM_FIRST + 0x0004)")]
        public const int BCM_SETTEXTMARGIN = (0x1600 + 0x0004);

        [NativeTypeName("#define BCM_GETTEXTMARGIN (BCM_FIRST + 0x0005)")]
        public const int BCM_GETTEXTMARGIN = (0x1600 + 0x0005);

        [NativeTypeName("#define BCN_HOTITEMCHANGE (BCN_FIRST + 0x0001)")]
        public const uint BCN_HOTITEMCHANGE = unchecked((0U - 1250U) + 0x0001);

        [NativeTypeName("#define BST_HOT 0x0200")]
        public const int BST_HOT = 0x0200;

        [NativeTypeName("#define BST_DROPDOWNPUSHED 0x0400")]
        public const int BST_DROPDOWNPUSHED = 0x0400;

        [NativeTypeName("#define BS_SPLITBUTTON 0x0000000CL")]
        public const int BS_SPLITBUTTON = 0x0000000C;

        [NativeTypeName("#define BS_DEFSPLITBUTTON 0x0000000DL")]
        public const int BS_DEFSPLITBUTTON = 0x0000000D;

        [NativeTypeName("#define BS_COMMANDLINK 0x0000000EL")]
        public const int BS_COMMANDLINK = 0x0000000E;

        [NativeTypeName("#define BS_DEFCOMMANDLINK 0x0000000FL")]
        public const int BS_DEFCOMMANDLINK = 0x0000000F;

        [NativeTypeName("#define BCSIF_GLYPH 0x0001")]
        public const int BCSIF_GLYPH = 0x0001;

        [NativeTypeName("#define BCSIF_IMAGE 0x0002")]
        public const int BCSIF_IMAGE = 0x0002;

        [NativeTypeName("#define BCSIF_STYLE 0x0004")]
        public const int BCSIF_STYLE = 0x0004;

        [NativeTypeName("#define BCSIF_SIZE 0x0008")]
        public const int BCSIF_SIZE = 0x0008;

        [NativeTypeName("#define BCSS_NOSPLIT 0x0001")]
        public const int BCSS_NOSPLIT = 0x0001;

        [NativeTypeName("#define BCSS_STRETCH 0x0002")]
        public const int BCSS_STRETCH = 0x0002;

        [NativeTypeName("#define BCSS_ALIGNLEFT 0x0004")]
        public const int BCSS_ALIGNLEFT = 0x0004;

        [NativeTypeName("#define BCSS_IMAGE 0x0008")]
        public const int BCSS_IMAGE = 0x0008;

        [NativeTypeName("#define BCM_SETDROPDOWNSTATE (BCM_FIRST + 0x0006)")]
        public const int BCM_SETDROPDOWNSTATE = (0x1600 + 0x0006);

        [NativeTypeName("#define BCM_SETSPLITINFO (BCM_FIRST + 0x0007)")]
        public const int BCM_SETSPLITINFO = (0x1600 + 0x0007);

        [NativeTypeName("#define BCM_GETSPLITINFO (BCM_FIRST + 0x0008)")]
        public const int BCM_GETSPLITINFO = (0x1600 + 0x0008);

        [NativeTypeName("#define BCM_SETNOTE (BCM_FIRST + 0x0009)")]
        public const int BCM_SETNOTE = (0x1600 + 0x0009);

        [NativeTypeName("#define BCM_GETNOTE (BCM_FIRST + 0x000A)")]
        public const int BCM_GETNOTE = (0x1600 + 0x000A);

        [NativeTypeName("#define BCM_GETNOTELENGTH (BCM_FIRST + 0x000B)")]
        public const int BCM_GETNOTELENGTH = (0x1600 + 0x000B);

        [NativeTypeName("#define BCM_SETSHIELD (BCM_FIRST + 0x000C)")]
        public const int BCM_SETSHIELD = (0x1600 + 0x000C);

        [NativeTypeName("#define BCCL_NOGLYPH (HIMAGELIST)(-1)")]
        public static IntPtr BCCL_NOGLYPH => (nint)(-1);

        [NativeTypeName("#define BCN_DROPDOWN (BCN_FIRST + 0x0002)")]
        public const uint BCN_DROPDOWN = unchecked((0U - 1250U) + 0x0002);

        [NativeTypeName("#define WC_STATICA \"Static\"")]
        public static ReadOnlySpan<byte> WC_STATICA => new byte[] { 0x53, 0x74, 0x61, 0x74, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define WC_STATICW L\"Static\"")]
        public const string WC_STATICW = "Static";

        [NativeTypeName("#define WC_STATIC WC_STATICW")]
        public const string WC_STATIC = "Static";

        [NativeTypeName("#define WC_EDITA \"Edit\"")]
        public static ReadOnlySpan<byte> WC_EDITA => new byte[] { 0x45, 0x64, 0x69, 0x74, 0x00 };

        [NativeTypeName("#define WC_EDITW L\"Edit\"")]
        public const string WC_EDITW = "Edit";

        [NativeTypeName("#define WC_EDIT WC_EDITW")]
        public const string WC_EDIT = "Edit";

        [NativeTypeName("#define ES_EX_ALLOWEOL_CR 0x0001L")]
        public const int ES_EX_ALLOWEOL_CR = 0x0001;

        [NativeTypeName("#define ES_EX_ALLOWEOL_LF 0x0002L")]
        public const int ES_EX_ALLOWEOL_LF = 0x0002;

        [NativeTypeName("#define ES_EX_ALLOWEOL_ALL (ES_EX_ALLOWEOL_CR | ES_EX_ALLOWEOL_LF)")]
        public const int ES_EX_ALLOWEOL_ALL = (0x0001 | 0x0002);

        [NativeTypeName("#define ES_EX_CONVERT_EOL_ON_PASTE 0x0004L")]
        public const int ES_EX_CONVERT_EOL_ON_PASTE = 0x0004;

        [NativeTypeName("#define ES_EX_ZOOMABLE 0x0010L")]
        public const int ES_EX_ZOOMABLE = 0x0010;

        [NativeTypeName("#define EM_SETCUEBANNER (ECM_FIRST + 1)")]
        public const int EM_SETCUEBANNER = (0x1500 + 1);

        [NativeTypeName("#define EM_GETCUEBANNER (ECM_FIRST + 2)")]
        public const int EM_GETCUEBANNER = (0x1500 + 2);

        [NativeTypeName("#define EM_SHOWBALLOONTIP (ECM_FIRST + 3)")]
        public const int EM_SHOWBALLOONTIP = (0x1500 + 3);

        [NativeTypeName("#define EM_HIDEBALLOONTIP (ECM_FIRST + 4)")]
        public const int EM_HIDEBALLOONTIP = (0x1500 + 4);

        [NativeTypeName("#define EM_SETHILITE (ECM_FIRST + 5)")]
        public const int EM_SETHILITE = (0x1500 + 5);

        [NativeTypeName("#define EM_GETHILITE (ECM_FIRST + 6)")]
        public const int EM_GETHILITE = (0x1500 + 6);

        [NativeTypeName("#define EM_NOSETFOCUS (ECM_FIRST + 7)")]
        public const int EM_NOSETFOCUS = (0x1500 + 7);

        [NativeTypeName("#define EM_TAKEFOCUS (ECM_FIRST + 8)")]
        public const int EM_TAKEFOCUS = (0x1500 + 8);

        [NativeTypeName("#define EM_SETEXTENDEDSTYLE (ECM_FIRST + 10)")]
        public const int EM_SETEXTENDEDSTYLE = (0x1500 + 10);

        [NativeTypeName("#define EM_GETEXTENDEDSTYLE (ECM_FIRST + 11)")]
        public const int EM_GETEXTENDEDSTYLE = (0x1500 + 11);

        [NativeTypeName("#define EM_SETENDOFLINE (ECM_FIRST + 12)")]
        public const int EM_SETENDOFLINE = (0x1500 + 12);

        [NativeTypeName("#define EM_GETENDOFLINE (ECM_FIRST + 13)")]
        public const int EM_GETENDOFLINE = (0x1500 + 13);

        [NativeTypeName("#define EM_ENABLESEARCHWEB (ECM_FIRST + 14)")]
        public const int EM_ENABLESEARCHWEB = (0x1500 + 14);

        [NativeTypeName("#define EM_SEARCHWEB (ECM_FIRST + 15)")]
        public const int EM_SEARCHWEB = (0x1500 + 15);

        [NativeTypeName("#define EM_SETCARETINDEX (ECM_FIRST + 17)")]
        public const int EM_SETCARETINDEX = (0x1500 + 17);

        [NativeTypeName("#define EM_GETCARETINDEX (ECM_FIRST + 18)")]
        public const int EM_GETCARETINDEX = (0x1500 + 18);

        [NativeTypeName("#define EM_GETZOOM (WM_USER + 224)")]
        public const int EM_GETZOOM = (0x0400 + 224);

        [NativeTypeName("#define EM_SETZOOM (WM_USER + 225)")]
        public const int EM_SETZOOM = (0x0400 + 225);

        [NativeTypeName("#define EM_FILELINEFROMCHAR (ECM_FIRST + 19)")]
        public const int EM_FILELINEFROMCHAR = (0x1500 + 19);

        [NativeTypeName("#define EM_FILELINEINDEX (ECM_FIRST + 20)")]
        public const int EM_FILELINEINDEX = (0x1500 + 20);

        [NativeTypeName("#define EM_FILELINELENGTH (ECM_FIRST + 21)")]
        public const int EM_FILELINELENGTH = (0x1500 + 21);

        [NativeTypeName("#define EM_GETFILELINE (ECM_FIRST + 22)")]
        public const int EM_GETFILELINE = (0x1500 + 22);

        [NativeTypeName("#define EM_GETFILELINECOUNT (ECM_FIRST + 23)")]
        public const int EM_GETFILELINECOUNT = (0x1500 + 23);

        [NativeTypeName("#define EN_SEARCHWEB (EN_FIRST - 0)")]
        public const uint EN_SEARCHWEB = unchecked((0U - 1520U) - 0);

        [NativeTypeName("#define WC_LISTBOXA \"ListBox\"")]
        public static ReadOnlySpan<byte> WC_LISTBOXA => new byte[] { 0x4C, 0x69, 0x73, 0x74, 0x42, 0x6F, 0x78, 0x00 };

        [NativeTypeName("#define WC_LISTBOXW L\"ListBox\"")]
        public const string WC_LISTBOXW = "ListBox";

        [NativeTypeName("#define WC_LISTBOX WC_LISTBOXW")]
        public const string WC_LISTBOX = "ListBox";

        [NativeTypeName("#define WC_COMBOBOXA \"ComboBox\"")]
        public static ReadOnlySpan<byte> WC_COMBOBOXA => new byte[] { 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x42, 0x6F, 0x78, 0x00 };

        [NativeTypeName("#define WC_COMBOBOXW L\"ComboBox\"")]
        public const string WC_COMBOBOXW = "ComboBox";

        [NativeTypeName("#define WC_COMBOBOX WC_COMBOBOXW")]
        public const string WC_COMBOBOX = "ComboBox";

        [NativeTypeName("#define CB_SETMINVISIBLE (CBM_FIRST + 1)")]
        public const int CB_SETMINVISIBLE = (0x1700 + 1);

        [NativeTypeName("#define CB_GETMINVISIBLE (CBM_FIRST + 2)")]
        public const int CB_GETMINVISIBLE = (0x1700 + 2);

        [NativeTypeName("#define CB_SETCUEBANNER (CBM_FIRST + 3)")]
        public const int CB_SETCUEBANNER = (0x1700 + 3);

        [NativeTypeName("#define CB_GETCUEBANNER (CBM_FIRST + 4)")]
        public const int CB_GETCUEBANNER = (0x1700 + 4);

        [NativeTypeName("#define WC_SCROLLBARA \"ScrollBar\"")]
        public static ReadOnlySpan<byte> WC_SCROLLBARA => new byte[] { 0x53, 0x63, 0x72, 0x6F, 0x6C, 0x6C, 0x42, 0x61, 0x72, 0x00 };

        [NativeTypeName("#define WC_SCROLLBARW L\"ScrollBar\"")]
        public const string WC_SCROLLBARW = "ScrollBar";

        [NativeTypeName("#define WC_SCROLLBAR WC_SCROLLBARW")]
        public const string WC_SCROLLBAR = "ScrollBar";

        [NativeTypeName("#define TD_WARNING_ICON MAKEINTRESOURCEW(-1)")]
        public static ushort* TD_WARNING_ICON => unchecked((ushort*)((nuint)((ushort)(-1))));

        [NativeTypeName("#define TD_ERROR_ICON MAKEINTRESOURCEW(-2)")]
        public static ushort* TD_ERROR_ICON => unchecked((ushort*)((nuint)((ushort)(-2))));

        [NativeTypeName("#define TD_INFORMATION_ICON MAKEINTRESOURCEW(-3)")]
        public static ushort* TD_INFORMATION_ICON => unchecked((ushort*)((nuint)((ushort)(-3))));

        [NativeTypeName("#define TD_SHIELD_ICON MAKEINTRESOURCEW(-4)")]
        public static ushort* TD_SHIELD_ICON => unchecked((ushort*)((nuint)((ushort)(-4))));

        [NativeTypeName("#define WSB_PROP_CYVSCROLL 0x00000001L")]
        public const int WSB_PROP_CYVSCROLL = 0x00000001;

        [NativeTypeName("#define WSB_PROP_CXHSCROLL 0x00000002L")]
        public const int WSB_PROP_CXHSCROLL = 0x00000002;

        [NativeTypeName("#define WSB_PROP_CYHSCROLL 0x00000004L")]
        public const int WSB_PROP_CYHSCROLL = 0x00000004;

        [NativeTypeName("#define WSB_PROP_CXVSCROLL 0x00000008L")]
        public const int WSB_PROP_CXVSCROLL = 0x00000008;

        [NativeTypeName("#define WSB_PROP_CXHTHUMB 0x00000010L")]
        public const int WSB_PROP_CXHTHUMB = 0x00000010;

        [NativeTypeName("#define WSB_PROP_CYVTHUMB 0x00000020L")]
        public const int WSB_PROP_CYVTHUMB = 0x00000020;

        [NativeTypeName("#define WSB_PROP_VBKGCOLOR 0x00000040L")]
        public const int WSB_PROP_VBKGCOLOR = 0x00000040;

        [NativeTypeName("#define WSB_PROP_HBKGCOLOR 0x00000080L")]
        public const int WSB_PROP_HBKGCOLOR = 0x00000080;

        [NativeTypeName("#define WSB_PROP_VSTYLE 0x00000100L")]
        public const int WSB_PROP_VSTYLE = 0x00000100;

        [NativeTypeName("#define WSB_PROP_HSTYLE 0x00000200L")]
        public const int WSB_PROP_HSTYLE = 0x00000200;

        [NativeTypeName("#define WSB_PROP_WINSTYLE 0x00000400L")]
        public const int WSB_PROP_WINSTYLE = 0x00000400;

        [NativeTypeName("#define WSB_PROP_PALETTE 0x00000800L")]
        public const int WSB_PROP_PALETTE = 0x00000800;

        [NativeTypeName("#define WSB_PROP_MASK 0x00000FFFL")]
        public const int WSB_PROP_MASK = 0x00000FFF;

        [NativeTypeName("#define FSB_FLAT_MODE 2")]
        public const int FSB_FLAT_MODE = 2;

        [NativeTypeName("#define FSB_ENCARTA_MODE 1")]
        public const int FSB_ENCARTA_MODE = 1;

        [NativeTypeName("#define FSB_REGULAR_MODE 0")]
        public const int FSB_REGULAR_MODE = 0;

        [NativeTypeName("#define FlatSB_SetScrollPropPtr FlatSB_SetScrollProp")]
        public static delegate*<IntPtr, uint, nint, BOOL, BOOL> FlatSB_SetScrollPropPtr => &FlatSB_SetScrollProp;
    }
}
