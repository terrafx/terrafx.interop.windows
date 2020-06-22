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

        public const int PSM_SETCURSEL = WM_USER + 101;

        public const int PSM_ADDPAGE = WM_USER + 103;

        public const int PSM_CHANGED = WM_USER + 104;

        public const int PSM_RESTARTWINDOWS = WM_USER + 105;

        public const int PSM_REBOOTSYSTEM = WM_USER + 106;

        public const int PSM_CANCELTOCLOSE = WM_USER + 107;

        public const int PSM_QUERYSIBLINGS = WM_USER + 108;

        public const int PSM_UNCHANGED = WM_USER + 109;

        public const int PSM_APPLY = WM_USER + 110;

        public const int PSM_SETTITLEA = WM_USER + 111;

        public const int PSM_SETTITLEW = WM_USER + 120;

        public const int PSM_SETWIZBUTTONS = WM_USER + 112;

        public const int PSM_PRESSBUTTON = WM_USER + 113;

        public const int PSM_SETCURSELID = WM_USER + 114;

        public const int PSM_SETFINISHTEXTA = WM_USER + 115;

        public const int PSM_SETFINISHTEXTW = WM_USER + 121;

        public const int PSM_GETTABCONTROL = WM_USER + 116;

        public const int PSM_ISDIALOGMESSAGE = WM_USER + 117;

        public const int PSM_GETCURRENTPAGEHWND = WM_USER + 118;

        public const int PSM_INSERTPAGE = WM_USER + 119;

        public const uint PSWIZF_SETCOLOR = unchecked((uint)-1);

        public const int PSM_SETHEADERTITLEA = WM_USER + 125;

        public const int PSM_SETHEADERTITLEW = WM_USER + 126;

        public const int PSM_SETHEADERSUBTITLEA = WM_USER + 127;

        public const int PSM_SETHEADERSUBTITLEW = WM_USER + 128;

        public const int PSM_HWNDTOINDEX = WM_USER + 129;

        public const int PSM_INDEXTOHWND = WM_USER + 130;

        public const int PSM_PAGETOINDEX = WM_USER + 131;

        public const int PSM_INDEXTOPAGE = WM_USER + 132;

        public const int PSM_IDTOINDEX = WM_USER + 133;

        public const int PSM_INDEXTOID = WM_USER + 134;

        public const int PSM_GETRESULT = WM_USER + 135;

        public const int PSM_RECALCPAGESIZES = WM_USER + 136;

        public const int PSM_SETNEXTTEXTW = WM_USER + 137;

        public const int PSM_SHOWWIZBUTTONS = WM_USER + 138;

        public const int PSM_ENABLEWIZBUTTONS = WM_USER + 139;

        public const int PSM_SETBUTTONTEXTW = WM_USER + 140;

        public const int ID_PSREBOOTSYSTEM = ID_PSRESTARTWINDOWS | 0x1;
    }
}
