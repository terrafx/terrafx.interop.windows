// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MAXPROPPAGES = 100;

        public const int PSP_DEFAULT = 0x00000000;

        public const int PSP_DLGINDIRECT = 0x00000001;

        public const int PSP_USEHICON = 0x00000002;

        public const int PSP_USEICONID = 0x00000004;

        public const int PSP_USETITLE = 0x00000008;

        public const int PSP_RTLREADING = 0x00000010;

        public const int PSP_HASHELP = 0x00000020;

        public const int PSP_USEREFPARENT = 0x00000040;

        public const int PSP_USECALLBACK = 0x00000080;

        public const int PSP_PREMATURE = 0x00000400;

        public const int PSP_HIDEHEADER = 0x00000800;

        public const int PSP_USEHEADERTITLE = 0x00001000;

        public const int PSP_USEHEADERSUBTITLE = 0x00002000;

        public const int PSP_USEFUSIONCONTEXT = 0x00004000;

        public const int PSPCB_ADDREF = 0;

        public const int PSPCB_RELEASE = 1;

        public const int PSPCB_CREATE = 2;

        public const int PSH_DEFAULT = 0x00000000;

        public const int PSH_PROPTITLE = 0x00000001;

        public const int PSH_USEHICON = 0x00000002;

        public const int PSH_USEICONID = 0x00000004;

        public const int PSH_PROPSHEETPAGE = 0x00000008;

        public const int PSH_WIZARDHASFINISH = 0x00000010;

        public const int PSH_WIZARD = 0x00000020;

        public const int PSH_USEPSTARTPAGE = 0x00000040;

        public const int PSH_NOAPPLYNOW = 0x00000080;

        public const int PSH_USECALLBACK = 0x00000100;

        public const int PSH_HASHELP = 0x00000200;

        public const int PSH_MODELESS = 0x00000400;

        public const int PSH_RTLREADING = 0x00000800;

        public const int PSH_WIZARDCONTEXTHELP = 0x00001000;

        public const int PSH_WIZARD97 = 0x01000000;

        public const int PSH_WATERMARK = 0x00008000;

        public const int PSH_USEHBMWATERMARK = 0x00010000;

        public const int PSH_USEHPLWATERMARK = 0x00020000;

        public const int PSH_STRETCHWATERMARK = 0x00040000;

        public const int PSH_HEADER = 0x00080000;

        public const int PSH_USEHBMHEADER = 0x00100000;

        public const int PSH_USEPAGELANG = 0x00200000;

        public const int PSH_WIZARD_LITE = 0x00400000;

        public const int PSH_NOCONTEXTHELP = 0x02000000;

        public const int PSH_AEROWIZARD = 0x00004000;

        public const int PSH_RESIZABLE = 0x04000000;

        public const int PSH_HEADERBITMAP = 0x08000000;

        public const int PSH_NOMARGIN = 0x10000000;

        public const int PSCB_INITIALIZED = 1;

        public const int PSCB_PRECREATE = 2;

        public const int PSCB_BUTTONPRESSED = 3;

        public const int PSNRET_NOERROR = 0;

        public const int PSNRET_INVALID = 1;

        public const int PSNRET_INVALID_NOCHANGEPAGE = 2;

        public const int PSNRET_MESSAGEHANDLED = 3;

        public const int PSWIZB_BACK = 0x00000001;

        public const int PSWIZB_NEXT = 0x00000002;

        public const int PSWIZB_FINISH = 0x00000004;

        public const int PSWIZB_DISABLEDFINISH = 0x00000008;

        public const int PSWIZBF_ELEVATIONREQUIRED = 0x00000001;

        public const int PSWIZB_CANCEL = 0x00000010;

        public const int PSBTN_BACK = 0;

        public const int PSBTN_NEXT = 1;

        public const int PSBTN_FINISH = 2;

        public const int PSBTN_OK = 3;

        public const int PSBTN_APPLYNOW = 4;

        public const int PSBTN_CANCEL = 5;

        public const int PSBTN_HELP = 6;

        public const int PSBTN_MAX = 6;

        public const int PSWIZB_SHOW = 0;

        public const int PSWIZB_RESTORE = 1;

        public const int ID_PSRESTARTWINDOWS = 0x2;

        public const int WIZ_CXDLG = 276;

        public const int WIZ_CYDLG = 140;

        public const int WIZ_CXBMP = 80;

        public const int WIZ_BODYX = 92;

        public const int WIZ_BODYCX = 184;

        public const int PROP_SM_CXDLG = 212;

        public const int PROP_SM_CYDLG = 188;

        public const int PROP_MED_CXDLG = 227;

        public const int PROP_MED_CYDLG = 215;

        public const int PROP_LG_CXDLG = 252;

        public const int PROP_LG_CYDLG = 218;

        public const int PSN_FIRST = 0 - 200;

        public const int PSN_LAST = 0 - 299;

        public const int PSN_SETACTIVE = PSN_FIRST - 0;

        public const int PSN_KILLACTIVE = PSN_FIRST - 1;

        public const int PSN_APPLY = PSN_FIRST - 2;

        public const int PSN_RESET = PSN_FIRST - 3;

        public const int PSN_HELP = PSN_FIRST - 5;

        public const int PSN_WIZBACK = PSN_FIRST - 6;

        public const int PSN_WIZNEXT = PSN_FIRST - 7;

        public const int PSN_WIZFINISH = PSN_FIRST - 8;

        public const int PSN_QUERYCANCEL = PSN_FIRST - 9;

        public const int PSN_GETOBJECT = PSN_FIRST - 10;

        public const int PSN_TRANSLATEACCELERATOR = PSN_FIRST - 12;

        public const int PSN_QUERYINITIALFOCUS = PSN_FIRST - 13;

        public const int PSM_SETCURSEL = User32.WM_USER + 101;

        public const int PSM_ADDPAGE = User32.WM_USER + 103;

        public const int PSM_CHANGED = User32.WM_USER + 104;

        public const int PSM_RESTARTWINDOWS = User32.WM_USER + 105;

        public const int PSM_REBOOTSYSTEM = User32.WM_USER + 106;

        public const int PSM_CANCELTOCLOSE = User32.WM_USER + 107;

        public const int PSM_QUERYSIBLINGS = User32.WM_USER + 108;

        public const int PSM_UNCHANGED = User32.WM_USER + 109;

        public const int PSM_APPLY = User32.WM_USER + 110;

        public const int PSM_SETTITLEA = User32.WM_USER + 111;

        public const int PSM_SETTITLEW = User32.WM_USER + 120;

        public const int PSM_SETWIZBUTTONS = User32.WM_USER + 112;

        public const int PSM_PRESSBUTTON = User32.WM_USER + 113;

        public const int PSM_SETCURSELID = User32.WM_USER + 114;

        public const int PSM_SETFINISHTEXTA = User32.WM_USER + 115;

        public const int PSM_SETFINISHTEXTW = User32.WM_USER + 121;

        public const int PSM_GETTABCONTROL = User32.WM_USER + 116;

        public const int PSM_ISDIALOGMESSAGE = User32.WM_USER + 117;

        public const int PSM_GETCURRENTPAGEHWND = User32.WM_USER + 118;

        public const int PSM_INSERTPAGE = User32.WM_USER + 119;

        public const uint PSWIZF_SETCOLOR = unchecked((uint)-1);

        public const int PSM_SETHEADERTITLEA = User32.WM_USER + 125;

        public const int PSM_SETHEADERTITLEW = User32.WM_USER + 126;

        public const int PSM_SETHEADERSUBTITLEA = User32.WM_USER + 127;

        public const int PSM_SETHEADERSUBTITLEW = User32.WM_USER + 128;

        public const int PSM_HWNDTOINDEX = User32.WM_USER + 129;

        public const int PSM_INDEXTOHWND = User32.WM_USER + 130;

        public const int PSM_PAGETOINDEX = User32.WM_USER + 131;

        public const int PSM_INDEXTOPAGE = User32.WM_USER + 132;

        public const int PSM_IDTOINDEX = User32.WM_USER + 133;

        public const int PSM_INDEXTOID = User32.WM_USER + 134;

        public const int PSM_GETRESULT = User32.WM_USER + 135;

        public const int PSM_RECALCPAGESIZES = User32.WM_USER + 136;

        public const int PSM_SETNEXTTEXTW = User32.WM_USER + 137;

        public const int PSM_SHOWWIZBUTTONS = User32.WM_USER + 138;

        public const int PSM_ENABLEWIZBUTTONS = User32.WM_USER + 139;

        public const int PSM_SETBUTTONTEXTW = User32.WM_USER + 140;

        public const int ID_PSREBOOTSYSTEM = ID_PSRESTARTWINDOWS | 0x1;

        // Line 637: #define PropSheet_SetCurSel(hDlg, hpage, index) \
        // Line 642: #define PropSheet_RemovePage(hDlg, index, hpage) \
        // Line 647: #define PropSheet_AddPage(hDlg, hpage) \
        // Line 652: #define PropSheet_Changed(hDlg, hwnd) \
        // Line 657: #define PropSheet_RestartWindows(hDlg) \
        // Line 662: #define PropSheet_RebootSystem(hDlg) \
        // Line 667: #define PropSheet_CancelToClose(hDlg) \
        // Line 672: #define PropSheet_QuerySiblings(hDlg, wParam, lParam) \
        // Line 677: #define PropSheet_UnChanged(hDlg, hwnd) \
        // Line 682: #define PropSheet_Apply(hDlg) \
        // Line 696: #define PropSheet_SetTitle(hDlg, wStyle, lpszText)\
        // Line 701: #define PropSheet_SetWizButtons(hDlg, dwFlags) \
        // Line 719: #define PropSheet_PressButton(hDlg, iButton) \
        // Line 735: #define PropSheet_SetCurSelByID(hDlg, id) \
        // Line 748: #define PropSheet_SetFinishText(hDlg, lpszText) \
        // Line 753: #define PropSheet_GetTabControl(hDlg) \
        // Line 757: #define PropSheet_IsDialogMessage(hDlg, pMsg) \
        // Line 761: #define PropSheet_GetCurrentPageHwnd(hDlg) \
        // Line 765: #define PropSheet_InsertPage(hDlg, index, hpage) \
        // Line 782: #define PropSheet_SetHeaderTitle(hDlg, index, lpszText) \
        // Line 795: #define PropSheet_SetHeaderSubTitle(hDlg, index, lpszText) \
        // Line 799: #define PropSheet_HwndToIndex(hDlg, hwnd) \
        // Line 803: #define PropSheet_IndexToHwnd(hDlg, i) \
        // Line 807: #define PropSheet_PageToIndex(hDlg, hpage) \
        // Line 811: #define PropSheet_IndexToPage(hDlg, i) \
        // Line 815: #define PropSheet_IdToIndex(hDlg, id) \
        // Line 819: #define PropSheet_IndexToId(hDlg, i) \
        // Line 823: #define PropSheet_GetResult(hDlg) \
        // Line 827: #define PropSheet_RecalcPageSizes(hDlg) \
        // Line 839: #define PropSheet_SetNextText(hDlg, lpszText) \
        // Line 847: #define PropSheet_ShowWizButtons(hDlg, dwFlag, dwButton) \
        // Line 852: #define PropSheet_EnableWizButtons(hDlg, dwState, dwMask) \
        // Line 858: #define PropSheet_SetButtonText(hDlg, dwButton, lpszText) \
    }
}
