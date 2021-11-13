// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("comctl32", ExactSpelling = true)]
        public static extern HPROPSHEETPAGE CreatePropertySheetPageA([NativeTypeName("LPCPROPSHEETPAGEA")] PROPSHEETPAGEA* constPropSheetPagePointer);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern HPROPSHEETPAGE CreatePropertySheetPageW([NativeTypeName("LPCPROPSHEETPAGEW")] PROPSHEETPAGEW* constPropSheetPagePointer);

        [DllImport("comctl32", ExactSpelling = true)]
        public static extern BOOL DestroyPropertySheetPage(HPROPSHEETPAGE param0);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint PropertySheetA([NativeTypeName("LPCPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* param0);

        [DllImport("comctl32", ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint PropertySheetW([NativeTypeName("LPCPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* param0);

        [NativeTypeName("#define SNDMSG ::SendMessage")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> SNDMSG => &SendMessageW;

        [NativeTypeName("#define PSTMSG ::PostMessage")]
        public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> PSTMSG => &PostMessageW;

        [NativeTypeName("#define MAXPROPPAGES 100")]
        public const int MAXPROPPAGES = 100;

        [NativeTypeName("#define PSP_DEFAULT 0x00000000")]
        public const int PSP_DEFAULT = 0x00000000;

        [NativeTypeName("#define PSP_DLGINDIRECT 0x00000001")]
        public const int PSP_DLGINDIRECT = 0x00000001;

        [NativeTypeName("#define PSP_USEHICON 0x00000002")]
        public const int PSP_USEHICON = 0x00000002;

        [NativeTypeName("#define PSP_USEICONID 0x00000004")]
        public const int PSP_USEICONID = 0x00000004;

        [NativeTypeName("#define PSP_USETITLE 0x00000008")]
        public const int PSP_USETITLE = 0x00000008;

        [NativeTypeName("#define PSP_RTLREADING 0x00000010")]
        public const int PSP_RTLREADING = 0x00000010;

        [NativeTypeName("#define PSP_HASHELP 0x00000020")]
        public const int PSP_HASHELP = 0x00000020;

        [NativeTypeName("#define PSP_USEREFPARENT 0x00000040")]
        public const int PSP_USEREFPARENT = 0x00000040;

        [NativeTypeName("#define PSP_USECALLBACK 0x00000080")]
        public const int PSP_USECALLBACK = 0x00000080;

        [NativeTypeName("#define PSP_PREMATURE 0x00000400")]
        public const int PSP_PREMATURE = 0x00000400;

        [NativeTypeName("#define PSP_HIDEHEADER 0x00000800")]
        public const int PSP_HIDEHEADER = 0x00000800;

        [NativeTypeName("#define PSP_USEHEADERTITLE 0x00001000")]
        public const int PSP_USEHEADERTITLE = 0x00001000;

        [NativeTypeName("#define PSP_USEHEADERSUBTITLE 0x00002000")]
        public const int PSP_USEHEADERSUBTITLE = 0x00002000;

        [NativeTypeName("#define PSP_USEFUSIONCONTEXT 0x00004000")]
        public const int PSP_USEFUSIONCONTEXT = 0x00004000;

        [NativeTypeName("#define PSPCB_ADDREF 0")]
        public const int PSPCB_ADDREF = 0;

        [NativeTypeName("#define PSPCB_RELEASE 1")]
        public const int PSPCB_RELEASE = 1;

        [NativeTypeName("#define PSPCB_CREATE 2")]
        public const int PSPCB_CREATE = 2;

        [NativeTypeName("#define PROPSHEETPAGEA_V1_SIZE sizeof(PROPSHEETPAGEA_V1)")]
        public static uint PROPSHEETPAGEA_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V1))));

        [NativeTypeName("#define PROPSHEETPAGEW_V1_SIZE sizeof(PROPSHEETPAGEW_V1)")]
        public static uint PROPSHEETPAGEW_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V1))));

        [NativeTypeName("#define PROPSHEETPAGEA_V2_SIZE sizeof(PROPSHEETPAGEA_V2)")]
        public static uint PROPSHEETPAGEA_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V2))));

        [NativeTypeName("#define PROPSHEETPAGEW_V2_SIZE sizeof(PROPSHEETPAGEW_V2)")]
        public static uint PROPSHEETPAGEW_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V2))));

        [NativeTypeName("#define PROPSHEETPAGEA_V3_SIZE sizeof(PROPSHEETPAGEA_V3)")]
        public static uint PROPSHEETPAGEA_V3_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V3))));

        [NativeTypeName("#define PROPSHEETPAGEW_V3_SIZE sizeof(PROPSHEETPAGEW_V3)")]
        public static uint PROPSHEETPAGEW_V3_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V3))));

        [NativeTypeName("#define PROPSHEETPAGEA_V4_SIZE sizeof(PROPSHEETPAGEA_V4)")]
        public static uint PROPSHEETPAGEA_V4_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA))));

        [NativeTypeName("#define PROPSHEETPAGEW_V4_SIZE sizeof(PROPSHEETPAGEW_V4)")]
        public static uint PROPSHEETPAGEW_V4_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW))));

        [NativeTypeName("#define PROPSHEETPAGE_V1_SIZE PROPSHEETPAGEW_V1_SIZE")]
        public static uint PROPSHEETPAGE_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V1))));

        [NativeTypeName("#define PROPSHEETPAGE_V2_SIZE PROPSHEETPAGEW_V2_SIZE")]
        public static uint PROPSHEETPAGE_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V2))));

        [NativeTypeName("#define PSH_DEFAULT 0x00000000")]
        public const int PSH_DEFAULT = 0x00000000;

        [NativeTypeName("#define PSH_PROPTITLE 0x00000001")]
        public const int PSH_PROPTITLE = 0x00000001;

        [NativeTypeName("#define PSH_USEHICON 0x00000002")]
        public const int PSH_USEHICON = 0x00000002;

        [NativeTypeName("#define PSH_USEICONID 0x00000004")]
        public const int PSH_USEICONID = 0x00000004;

        [NativeTypeName("#define PSH_PROPSHEETPAGE 0x00000008")]
        public const int PSH_PROPSHEETPAGE = 0x00000008;

        [NativeTypeName("#define PSH_WIZARDHASFINISH 0x00000010")]
        public const int PSH_WIZARDHASFINISH = 0x00000010;

        [NativeTypeName("#define PSH_WIZARD 0x00000020")]
        public const int PSH_WIZARD = 0x00000020;

        [NativeTypeName("#define PSH_USEPSTARTPAGE 0x00000040")]
        public const int PSH_USEPSTARTPAGE = 0x00000040;

        [NativeTypeName("#define PSH_NOAPPLYNOW 0x00000080")]
        public const int PSH_NOAPPLYNOW = 0x00000080;

        [NativeTypeName("#define PSH_USECALLBACK 0x00000100")]
        public const int PSH_USECALLBACK = 0x00000100;

        [NativeTypeName("#define PSH_HASHELP 0x00000200")]
        public const int PSH_HASHELP = 0x00000200;

        [NativeTypeName("#define PSH_MODELESS 0x00000400")]
        public const int PSH_MODELESS = 0x00000400;

        [NativeTypeName("#define PSH_RTLREADING 0x00000800")]
        public const int PSH_RTLREADING = 0x00000800;

        [NativeTypeName("#define PSH_WIZARDCONTEXTHELP 0x00001000")]
        public const int PSH_WIZARDCONTEXTHELP = 0x00001000;

        [NativeTypeName("#define PSH_WIZARD97 0x01000000")]
        public const int PSH_WIZARD97 = 0x01000000;

        [NativeTypeName("#define PSH_WATERMARK 0x00008000")]
        public const int PSH_WATERMARK = 0x00008000;

        [NativeTypeName("#define PSH_USEHBMWATERMARK 0x00010000")]
        public const int PSH_USEHBMWATERMARK = 0x00010000;

        [NativeTypeName("#define PSH_USEHPLWATERMARK 0x00020000")]
        public const int PSH_USEHPLWATERMARK = 0x00020000;

        [NativeTypeName("#define PSH_STRETCHWATERMARK 0x00040000")]
        public const int PSH_STRETCHWATERMARK = 0x00040000;

        [NativeTypeName("#define PSH_HEADER 0x00080000")]
        public const int PSH_HEADER = 0x00080000;

        [NativeTypeName("#define PSH_USEHBMHEADER 0x00100000")]
        public const int PSH_USEHBMHEADER = 0x00100000;

        [NativeTypeName("#define PSH_USEPAGELANG 0x00200000")]
        public const int PSH_USEPAGELANG = 0x00200000;

        [NativeTypeName("#define PSH_WIZARD_LITE 0x00400000")]
        public const int PSH_WIZARD_LITE = 0x00400000;

        [NativeTypeName("#define PSH_NOCONTEXTHELP 0x02000000")]
        public const int PSH_NOCONTEXTHELP = 0x02000000;

        [NativeTypeName("#define PSH_AEROWIZARD 0x00004000")]
        public const int PSH_AEROWIZARD = 0x00004000;

        [NativeTypeName("#define PSH_RESIZABLE 0x04000000")]
        public const int PSH_RESIZABLE = 0x04000000;

        [NativeTypeName("#define PSH_HEADERBITMAP 0x08000000")]
        public const int PSH_HEADERBITMAP = 0x08000000;

        [NativeTypeName("#define PSH_NOMARGIN 0x10000000")]
        public const int PSH_NOMARGIN = 0x10000000;

        [NativeTypeName("#define PROPSHEETHEADERA_V1_SIZE sizeof(PROPSHEETHEADERA_V1)")]
        public static uint PROPSHEETHEADERA_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERA_V1))));

        [NativeTypeName("#define PROPSHEETHEADERW_V1_SIZE sizeof(PROPSHEETHEADERW_V1)")]
        public static uint PROPSHEETHEADERW_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V1))));

        [NativeTypeName("#define PROPSHEETHEADERA_V2_SIZE sizeof(PROPSHEETHEADERA_V2)")]
        public static uint PROPSHEETHEADERA_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERA_V2))));

        [NativeTypeName("#define PROPSHEETHEADERW_V2_SIZE sizeof(PROPSHEETHEADERW_V2)")]
        public static uint PROPSHEETHEADERW_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V2))));

        [NativeTypeName("#define PROPSHEETHEADER_V1_SIZE PROPSHEETHEADERW_V1_SIZE")]
        public static uint PROPSHEETHEADER_V1_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V1))));

        [NativeTypeName("#define PROPSHEETHEADER_V2_SIZE PROPSHEETHEADERW_V2_SIZE")]
        public static uint PROPSHEETHEADER_V2_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V2))));

        [NativeTypeName("#define PSCB_INITIALIZED 1")]
        public const int PSCB_INITIALIZED = 1;

        [NativeTypeName("#define PSCB_PRECREATE 2")]
        public const int PSCB_PRECREATE = 2;

        [NativeTypeName("#define PSCB_BUTTONPRESSED 3")]
        public const int PSCB_BUTTONPRESSED = 3;

        [NativeTypeName("#define CreatePropertySheetPage CreatePropertySheetPageW")]
        public static delegate*<PROPSHEETPAGEW*, HPROPSHEETPAGE> CreatePropertySheetPage => &CreatePropertySheetPageW;

        [NativeTypeName("#define PropertySheet PropertySheetW")]
        public static delegate*<PROPSHEETHEADERW_V2*, nint> PropertySheet => &PropertySheetW;

        [NativeTypeName("#define PSN_FIRST (0U-200U)")]
        public const uint PSN_FIRST = unchecked(0U - 200U);

        [NativeTypeName("#define PSN_LAST (0U-299U)")]
        public const uint PSN_LAST = unchecked(0U - 299U);

        [NativeTypeName("#define PSN_SETACTIVE (PSN_FIRST-0)")]
        public const uint PSN_SETACTIVE = unchecked((0U - 200U) - 0);

        [NativeTypeName("#define PSN_KILLACTIVE (PSN_FIRST-1)")]
        public const uint PSN_KILLACTIVE = unchecked((0U - 200U) - 1);

        [NativeTypeName("#define PSN_APPLY (PSN_FIRST-2)")]
        public const uint PSN_APPLY = unchecked((0U - 200U) - 2);

        [NativeTypeName("#define PSN_RESET (PSN_FIRST-3)")]
        public const uint PSN_RESET = unchecked((0U - 200U) - 3);

        [NativeTypeName("#define PSN_HELP (PSN_FIRST-5)")]
        public const uint PSN_HELP = unchecked((0U - 200U) - 5);

        [NativeTypeName("#define PSN_WIZBACK (PSN_FIRST-6)")]
        public const uint PSN_WIZBACK = unchecked((0U - 200U) - 6);

        [NativeTypeName("#define PSN_WIZNEXT (PSN_FIRST-7)")]
        public const uint PSN_WIZNEXT = unchecked((0U - 200U) - 7);

        [NativeTypeName("#define PSN_WIZFINISH (PSN_FIRST-8)")]
        public const uint PSN_WIZFINISH = unchecked((0U - 200U) - 8);

        [NativeTypeName("#define PSN_QUERYCANCEL (PSN_FIRST-9)")]
        public const uint PSN_QUERYCANCEL = unchecked((0U - 200U) - 9);

        [NativeTypeName("#define PSN_GETOBJECT (PSN_FIRST-10)")]
        public const uint PSN_GETOBJECT = unchecked((0U - 200U) - 10);

        [NativeTypeName("#define PSN_TRANSLATEACCELERATOR (PSN_FIRST-12)")]
        public const uint PSN_TRANSLATEACCELERATOR = unchecked((0U - 200U) - 12);

        [NativeTypeName("#define PSN_QUERYINITIALFOCUS (PSN_FIRST-13)")]
        public const uint PSN_QUERYINITIALFOCUS = unchecked((0U - 200U) - 13);

        [NativeTypeName("#define PSNRET_NOERROR 0")]
        public const int PSNRET_NOERROR = 0;

        [NativeTypeName("#define PSNRET_INVALID 1")]
        public const int PSNRET_INVALID = 1;

        [NativeTypeName("#define PSNRET_INVALID_NOCHANGEPAGE 2")]
        public const int PSNRET_INVALID_NOCHANGEPAGE = 2;

        [NativeTypeName("#define PSNRET_MESSAGEHANDLED 3")]
        public const int PSNRET_MESSAGEHANDLED = 3;

        [NativeTypeName("#define PSM_SETCURSEL (WM_USER + 101)")]
        public const int PSM_SETCURSEL = (0x0400 + 101);

        [NativeTypeName("#define PSM_REMOVEPAGE (WM_USER + 102)")]
        public const int PSM_REMOVEPAGE = (0x0400 + 102);

        [NativeTypeName("#define PSM_ADDPAGE (WM_USER + 103)")]
        public const int PSM_ADDPAGE = (0x0400 + 103);

        [NativeTypeName("#define PSM_CHANGED (WM_USER + 104)")]
        public const int PSM_CHANGED = (0x0400 + 104);

        [NativeTypeName("#define PSM_RESTARTWINDOWS (WM_USER + 105)")]
        public const int PSM_RESTARTWINDOWS = (0x0400 + 105);

        [NativeTypeName("#define PSM_REBOOTSYSTEM (WM_USER + 106)")]
        public const int PSM_REBOOTSYSTEM = (0x0400 + 106);

        [NativeTypeName("#define PSM_CANCELTOCLOSE (WM_USER + 107)")]
        public const int PSM_CANCELTOCLOSE = (0x0400 + 107);

        [NativeTypeName("#define PSM_QUERYSIBLINGS (WM_USER + 108)")]
        public const int PSM_QUERYSIBLINGS = (0x0400 + 108);

        [NativeTypeName("#define PSM_UNCHANGED (WM_USER + 109)")]
        public const int PSM_UNCHANGED = (0x0400 + 109);

        [NativeTypeName("#define PSM_APPLY (WM_USER + 110)")]
        public const int PSM_APPLY = (0x0400 + 110);

        [NativeTypeName("#define PSM_SETTITLEA (WM_USER + 111)")]
        public const int PSM_SETTITLEA = (0x0400 + 111);

        [NativeTypeName("#define PSM_SETTITLEW (WM_USER + 120)")]
        public const int PSM_SETTITLEW = (0x0400 + 120);

        [NativeTypeName("#define PSM_SETTITLE PSM_SETTITLEW")]
        public const int PSM_SETTITLE = (0x0400 + 120);

        [NativeTypeName("#define PSM_SETWIZBUTTONS (WM_USER + 112)")]
        public const int PSM_SETWIZBUTTONS = (0x0400 + 112);

        [NativeTypeName("#define PSWIZB_BACK 0x00000001")]
        public const int PSWIZB_BACK = 0x00000001;

        [NativeTypeName("#define PSWIZB_NEXT 0x00000002")]
        public const int PSWIZB_NEXT = 0x00000002;

        [NativeTypeName("#define PSWIZB_FINISH 0x00000004")]
        public const int PSWIZB_FINISH = 0x00000004;

        [NativeTypeName("#define PSWIZB_DISABLEDFINISH 0x00000008")]
        public const int PSWIZB_DISABLEDFINISH = 0x00000008;

        [NativeTypeName("#define PSWIZBF_ELEVATIONREQUIRED 0x00000001")]
        public const int PSWIZBF_ELEVATIONREQUIRED = 0x00000001;

        [NativeTypeName("#define PSWIZB_CANCEL 0x00000010")]
        public const int PSWIZB_CANCEL = 0x00000010;

        [NativeTypeName("#define PSM_PRESSBUTTON (WM_USER + 113)")]
        public const int PSM_PRESSBUTTON = (0x0400 + 113);

        [NativeTypeName("#define PSBTN_BACK 0")]
        public const int PSBTN_BACK = 0;

        [NativeTypeName("#define PSBTN_NEXT 1")]
        public const int PSBTN_NEXT = 1;

        [NativeTypeName("#define PSBTN_FINISH 2")]
        public const int PSBTN_FINISH = 2;

        [NativeTypeName("#define PSBTN_OK 3")]
        public const int PSBTN_OK = 3;

        [NativeTypeName("#define PSBTN_APPLYNOW 4")]
        public const int PSBTN_APPLYNOW = 4;

        [NativeTypeName("#define PSBTN_CANCEL 5")]
        public const int PSBTN_CANCEL = 5;

        [NativeTypeName("#define PSBTN_HELP 6")]
        public const int PSBTN_HELP = 6;

        [NativeTypeName("#define PSBTN_MAX 6")]
        public const int PSBTN_MAX = 6;

        [NativeTypeName("#define PSM_SETCURSELID (WM_USER + 114)")]
        public const int PSM_SETCURSELID = (0x0400 + 114);

        [NativeTypeName("#define PSM_SETFINISHTEXTA (WM_USER + 115)")]
        public const int PSM_SETFINISHTEXTA = (0x0400 + 115);

        [NativeTypeName("#define PSM_SETFINISHTEXTW (WM_USER + 121)")]
        public const int PSM_SETFINISHTEXTW = (0x0400 + 121);

        [NativeTypeName("#define PSM_SETFINISHTEXT PSM_SETFINISHTEXTW")]
        public const int PSM_SETFINISHTEXT = (0x0400 + 121);

        [NativeTypeName("#define PSM_GETTABCONTROL (WM_USER + 116)")]
        public const int PSM_GETTABCONTROL = (0x0400 + 116);

        [NativeTypeName("#define PSM_ISDIALOGMESSAGE (WM_USER + 117)")]
        public const int PSM_ISDIALOGMESSAGE = (0x0400 + 117);

        [NativeTypeName("#define PSM_GETCURRENTPAGEHWND (WM_USER + 118)")]
        public const int PSM_GETCURRENTPAGEHWND = (0x0400 + 118);

        [NativeTypeName("#define PSM_INSERTPAGE (WM_USER + 119)")]
        public const int PSM_INSERTPAGE = (0x0400 + 119);

        [NativeTypeName("#define PSWIZF_SETCOLOR ((UINT)(-1))")]
        public const uint PSWIZF_SETCOLOR = unchecked((uint)(-1));

        [NativeTypeName("#define PSM_SETHEADERTITLEA (WM_USER + 125)")]
        public const int PSM_SETHEADERTITLEA = (0x0400 + 125);

        [NativeTypeName("#define PSM_SETHEADERTITLEW (WM_USER + 126)")]
        public const int PSM_SETHEADERTITLEW = (0x0400 + 126);

        [NativeTypeName("#define PSM_SETHEADERTITLE PSM_SETHEADERTITLEW")]
        public const int PSM_SETHEADERTITLE = (0x0400 + 126);

        [NativeTypeName("#define PSM_SETHEADERSUBTITLEA (WM_USER + 127)")]
        public const int PSM_SETHEADERSUBTITLEA = (0x0400 + 127);

        [NativeTypeName("#define PSM_SETHEADERSUBTITLEW (WM_USER + 128)")]
        public const int PSM_SETHEADERSUBTITLEW = (0x0400 + 128);

        [NativeTypeName("#define PSM_SETHEADERSUBTITLE PSM_SETHEADERSUBTITLEW")]
        public const int PSM_SETHEADERSUBTITLE = (0x0400 + 128);

        [NativeTypeName("#define PSM_HWNDTOINDEX (WM_USER + 129)")]
        public const int PSM_HWNDTOINDEX = (0x0400 + 129);

        [NativeTypeName("#define PSM_INDEXTOHWND (WM_USER + 130)")]
        public const int PSM_INDEXTOHWND = (0x0400 + 130);

        [NativeTypeName("#define PSM_PAGETOINDEX (WM_USER + 131)")]
        public const int PSM_PAGETOINDEX = (0x0400 + 131);

        [NativeTypeName("#define PSM_INDEXTOPAGE (WM_USER + 132)")]
        public const int PSM_INDEXTOPAGE = (0x0400 + 132);

        [NativeTypeName("#define PSM_IDTOINDEX (WM_USER + 133)")]
        public const int PSM_IDTOINDEX = (0x0400 + 133);

        [NativeTypeName("#define PSM_INDEXTOID (WM_USER + 134)")]
        public const int PSM_INDEXTOID = (0x0400 + 134);

        [NativeTypeName("#define PSM_GETRESULT (WM_USER + 135)")]
        public const int PSM_GETRESULT = (0x0400 + 135);

        [NativeTypeName("#define PSM_RECALCPAGESIZES (WM_USER + 136)")]
        public const int PSM_RECALCPAGESIZES = (0x0400 + 136);

        [NativeTypeName("#define PSM_SETNEXTTEXTW (WM_USER + 137)")]
        public const int PSM_SETNEXTTEXTW = (0x0400 + 137);

        [NativeTypeName("#define PSM_SETNEXTTEXT PSM_SETNEXTTEXTW")]
        public const int PSM_SETNEXTTEXT = (0x0400 + 137);

        [NativeTypeName("#define PSWIZB_SHOW 0")]
        public const int PSWIZB_SHOW = 0;

        [NativeTypeName("#define PSWIZB_RESTORE 1")]
        public const int PSWIZB_RESTORE = 1;

        [NativeTypeName("#define PSM_SHOWWIZBUTTONS (WM_USER + 138)")]
        public const int PSM_SHOWWIZBUTTONS = (0x0400 + 138);

        [NativeTypeName("#define PSM_ENABLEWIZBUTTONS (WM_USER + 139)")]
        public const int PSM_ENABLEWIZBUTTONS = (0x0400 + 139);

        [NativeTypeName("#define PSM_SETBUTTONTEXTW (WM_USER + 140)")]
        public const int PSM_SETBUTTONTEXTW = (0x0400 + 140);

        [NativeTypeName("#define PSM_SETBUTTONTEXT PSM_SETBUTTONTEXTW")]
        public const int PSM_SETBUTTONTEXT = (0x0400 + 140);

        [NativeTypeName("#define ID_PSRESTARTWINDOWS 0x2")]
        public const int ID_PSRESTARTWINDOWS = 0x2;

        [NativeTypeName("#define ID_PSREBOOTSYSTEM (ID_PSRESTARTWINDOWS | 0x1)")]
        public const int ID_PSREBOOTSYSTEM = (0x2 | 0x1);

        [NativeTypeName("#define WIZ_CXDLG 276")]
        public const int WIZ_CXDLG = 276;

        [NativeTypeName("#define WIZ_CYDLG 140")]
        public const int WIZ_CYDLG = 140;

        [NativeTypeName("#define WIZ_CXBMP 80")]
        public const int WIZ_CXBMP = 80;

        [NativeTypeName("#define WIZ_BODYX 92")]
        public const int WIZ_BODYX = 92;

        [NativeTypeName("#define WIZ_BODYCX 184")]
        public const int WIZ_BODYCX = 184;

        [NativeTypeName("#define PROP_SM_CXDLG 212")]
        public const int PROP_SM_CXDLG = 212;

        [NativeTypeName("#define PROP_SM_CYDLG 188")]
        public const int PROP_SM_CYDLG = 188;

        [NativeTypeName("#define PROP_MED_CXDLG 227")]
        public const int PROP_MED_CXDLG = 227;

        [NativeTypeName("#define PROP_MED_CYDLG 215")]
        public const int PROP_MED_CYDLG = 215;

        [NativeTypeName("#define PROP_LG_CXDLG 252")]
        public const int PROP_LG_CXDLG = 252;

        [NativeTypeName("#define PROP_LG_CYDLG 218")]
        public const int PROP_LG_CYDLG = 218;
    }
}
