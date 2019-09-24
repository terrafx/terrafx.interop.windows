// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class User32
    {
        private const string DllName = nameof(User32);

        public const int SW_HIDE = 0;

        public const int SW_SHOWNORMAL = 1;

        public const int SW_NORMAL = 1;

        public const int SW_SHOWMINIMIZED = 2;

        public const int SW_SHOWMAXIMIZED = 3;

        public const int SW_MAXIMIZE = 3;

        public const int SW_SHOWNOACTIVATE = 4;

        public const int SW_SHOW = 5;

        public const int SW_MINIMIZE = 6;

        public const int SW_SHOWMINNOACTIVE = 7;

        public const int SW_SHOWNA = 8;

        public const int SW_RESTORE = 9;

        public const int SW_SHOWDEFAULT = 10;

        public const int SW_FORCEMINIMIZE = 11;

        public const int SW_MAX = 11;

        public const int GWL_WNDPROC = -4;

        public const int GWL_HINSTANCE = -6;

        public const int GWL_HWNDPARENT = -8;

        public const int GWL_STYLE = -16;

        public const int GWL_EXSTYLE = -20;

        public const int GWL_USERDATA = -21;

        public const int GWL_ID = -12;

        public const int GWLP_WNDPROC = -4;

        public const int GWLP_HINSTANCE = -6;

        public const int GWLP_HWNDPARENT = -8;

        public const int GWLP_USERDATA = -21;

        public const int GWLP_ID = -12;

        public const uint WM_NULL = 0x0000;

        public const uint WM_CREATE = 0x0001;

        public const uint WM_DESTROY = 0x0002;

        public const uint WM_MOVE = 0x0003;

        public const uint WM_SIZE = 0x0005;

        public const uint WM_ACTIVATE = 0x0006;

        public const uint WM_SETFOCUS = 0x0007;

        public const uint WM_KILLFOCUS = 0x0008;

        public const uint WM_ENABLE = 0x000A;

        public const uint WM_SETREDRAW = 0x000B;

        public const uint WM_SETTEXT = 0x000C;

        public const uint WM_GETTEXT = 0x000D;

        public const uint WM_GETTEXTLENGTH = 0x000E;

        public const uint WM_PAINT = 0x000F;

        public const uint WM_CLOSE = 0x0010;

        public const uint WM_QUERYENDSESSION = 0x0011;

        public const uint WM_QUERYOPEN = 0x0013;

        public const uint WM_ENDSESSION = 0x0016;

        public const uint WM_QUIT = 0x0012;

        public const uint WM_ERASEBKGND = 0x0014;

        public const uint WM_SYSCOLORCHANGE = 0x0015;

        public const uint WM_SHOWWINDOW = 0x0018;

        public const uint WM_WININICHANGE = 0x001A;

        public const uint WM_SETTINGCHANGE = WM_WININICHANGE;

        public const uint WM_DEVMODECHANGE = 0x001B;

        public const uint WM_ACTIVATEAPP = 0x001C;

        public const uint WM_FONTCHANGE = 0x001D;

        public const uint WM_TIMECHANGE = 0x001E;

        public const uint WM_CANCELMODE = 0x001F;

        public const uint WM_SETCURSOR = 0x0020;

        public const uint WM_MOUSEACTIVATE = 0x0021;

        public const uint WM_CHILDACTIVATE = 0x0022;

        public const uint WM_QUEUESYNC = 0x0023;

        public const uint WM_GETMINMAXINFO = 0x0024;

        public const uint WM_PAINTICON = 0x0026;

        public const uint WM_ICONERASEBKGND = 0x0027;

        public const uint WM_NEXTDLGCTL = 0x0028;

        public const uint WM_SPOOLERSTATUS = 0x002A;

        public const uint WM_DRAWITEM = 0x002B;

        public const uint WM_MEASUREITEM = 0x002C;

        public const uint WM_DELETEITEM = 0x002D;

        public const uint WM_VKEYTOITEM = 0x002E;

        public const uint WM_CHARTOITEM = 0x002F;

        public const uint WM_SETFONT = 0x0030;

        public const uint WM_GETFONT = 0x0031;

        public const uint WM_SETHOTKEY = 0x0032;

        public const uint WM_GETHOTKEY = 0x0033;

        public const uint WM_QUERYDRAGICON = 0x0037;

        public const uint WM_COMPAREITEM = 0x0039;

        public const uint WM_GETOBJECT = 0x003D;

        public const uint WM_COMPACTING = 0x0041;

        public const uint WM_COMMNOTIFY = 0x0044;

        public const uint WM_WINDOWPOSCHANGING = 0x0046;

        public const uint WM_WINDOWPOSCHANGED = 0x0047;

        public const uint WM_POWER = 0x0048;

        public const uint WM_COPYDATA = 0x004A;

        public const uint WM_CANCELJOURNAL = 0x004B;

        public const uint WM_NOTIFY = 0x004E;

        public const uint WM_INPUTLANGCHANGEREQUEST = 0x0050;

        public const uint WM_INPUTLANGCHANGE = 0x0051;

        public const uint WM_TCARD = 0x0052;

        public const uint WM_HELP = 0x0053;

        public const uint WM_USERCHANGED = 0x0054;

        public const uint WM_NOTIFYFORMAT = 0x0055;

        public const uint WM_CONTEXTMENU = 0x007B;

        public const uint WM_STYLECHANGING = 0x007C;

        public const uint WM_STYLECHANGED = 0x007D;

        public const uint WM_DISPLAYCHANGE = 0x007E;

        public const uint WM_GETICON = 0x007F;

        public const uint WM_SETICON = 0x0080;

        public const uint WM_NCCREATE = 0x0081;

        public const uint WM_NCDESTROY = 0x0082;

        public const uint WM_NCCALCSIZE = 0x0083;

        public const uint WM_NCHITTEST = 0x0084;

        public const uint WM_NCPAINT = 0x0085;

        public const uint WM_NCACTIVATE = 0x0086;

        public const uint WM_GETDLGCODE = 0x0087;

        public const uint WM_SYNCPAINT = 0x0088;

        public const uint WM_NCMOUSEMOVE = 0x00A0;

        public const uint WM_NCLBUTTONDOWN = 0x00A1;

        public const uint WM_NCLBUTTONUP = 0x00A2;

        public const uint WM_NCLBUTTONDBLCLK = 0x00A3;

        public const uint WM_NCRBUTTONDOWN = 0x00A4;

        public const uint WM_NCRBUTTONUP = 0x00A5;

        public const uint WM_NCRBUTTONDBLCLK = 0x00A6;

        public const uint WM_NCMBUTTONDOWN = 0x00A7;

        public const uint WM_NCMBUTTONUP = 0x00A8;

        public const uint WM_NCMBUTTONDBLCLK = 0x00A9;

        public const uint WM_NCXBUTTONDOWN = 0x00AB;

        public const uint WM_NCXBUTTONUP = 0x00AC;

        public const uint WM_NCXBUTTONDBLCLK = 0x00AD;

        public const uint WM_INPUT_DEVICE_CHANGE = 0x00FE;

        public const uint WM_INPUT = 0x00FF;

        public const uint WM_KEYFIRST = 0x0100;

        public const uint WM_KEYDOWN = 0x0100;

        public const uint WM_KEYUP = 0x0101;

        public const uint WM_CHAR = 0x0102;

        public const uint WM_DEADCHAR = 0x0103;

        public const uint WM_SYSKEYDOWN = 0x0104;

        public const uint WM_SYSKEYUP = 0x0105;

        public const uint WM_SYSCHAR = 0x0106;

        public const uint WM_SYSDEADCHAR = 0x0107;

        public const uint WM_UNICHAR = 0x0109;

        public const uint WM_KEYLAST = 0x0109;

        public const uint WM_IME_STARTCOMPOSITION = 0x010D;

        public const uint WM_IME_ENDCOMPOSITION = 0x010E;

        public const uint WM_IME_COMPOSITION = 0x010F;

        public const uint WM_IME_KEYLAST = 0x010F;

        public const uint WM_INITDIALOG = 0x0110;

        public const uint WM_COMMAND = 0x0111;

        public const uint WM_SYSCOMMAND = 0x0112;

        public const uint WM_TIMER = 0x0113;

        public const uint WM_HSCROLL = 0x0114;

        public const uint WM_VSCROLL = 0x0115;

        public const uint WM_INITMENU = 0x0116;

        public const uint WM_INITMENUPOPUP = 0x0117;

        public const uint WM_GESTURE = 0x0119;

        public const uint WM_GESTURENOTIFY = 0x011A;

        public const uint WM_MENUSELECT = 0x011F;

        public const uint WM_MENUCHAR = 0x0120;

        public const uint WM_ENTERIDLE = 0x0121;

        public const uint WM_MENURBUTTONUP = 0x0122;

        public const uint WM_MENUDRAG = 0x0123;

        public const uint WM_MENUGETOBJECT = 0x0124;

        public const uint WM_UNINITMENUPOPUP = 0x0125;

        public const uint WM_MENUCOMMAND = 0x0126;

        public const uint WM_CHANGEUISTATE = 0x0127;

        public const uint WM_UPDATEUISTATE = 0x0128;

        public const uint WM_QUERYUISTATE = 0x0129;

        public const uint WM_CTLCOLORMSGBOX = 0x0132;

        public const uint WM_CTLCOLOREDIT = 0x0133;

        public const uint WM_CTLCOLORLISTBOX = 0x0134;

        public const uint WM_CTLCOLORBTN = 0x0135;

        public const uint WM_CTLCOLORDLG = 0x0136;

        public const uint WM_CTLCOLORSCROLLBAR = 0x0137;

        public const uint WM_CTLCOLORSTATIC = 0x0138;

        public const uint WM_GETHMENU = 0x01E1;

        public const uint WM_MOUSEFIRST = 0x0200;

        public const uint WM_MOUSEMOVE = 0x0200;

        public const uint WM_LBUTTONDOWN = 0x0201;

        public const uint WM_LBUTTONUP = 0x0202;

        public const uint WM_LBUTTONDBLCLK = 0x0203;

        public const uint WM_RBUTTONDOWN = 0x0204;

        public const uint WM_RBUTTONUP = 0x0205;

        public const uint WM_RBUTTONDBLCLK = 0x0206;

        public const uint WM_MBUTTONDOWN = 0x0207;

        public const uint WM_MBUTTONUP = 0x0208;

        public const uint WM_MBUTTONDBLCLK = 0x0209;

        public const uint WM_MOUSEWHEEL = 0x020A;

        public const uint WM_XBUTTONDOWN = 0x020B;

        public const uint WM_XBUTTONUP = 0x020C;

        public const uint WM_XBUTTONDBLCLK = 0x020D;

        public const uint WM_MOUSEHWHEEL = 0x020E;

        public const uint WM_MOUSELAST = 0x020E;

        public const uint WM_PARENTNOTIFY = 0x0210;

        public const uint WM_ENTERMENULOOP = 0x0211;

        public const uint WM_EXITMENULOOP = 0x0212;

        public const uint WM_NEXTMENU = 0x0213;

        public const uint WM_SIZING = 0x0214;

        public const uint WM_CAPTURECHANGED = 0x0215;

        public const uint WM_MOVING = 0x0216;

        public const uint WM_POWERBROADCAST = 0x0218;

        public const uint WM_DEVICECHANGE = 0x0219;

        public const uint WM_MDICREATE = 0x0220;

        public const uint WM_MDIDESTROY = 0x0221;

        public const uint WM_MDIACTIVATE = 0x0222;

        public const uint WM_MDIRESTORE = 0x0223;

        public const uint WM_MDINEXT = 0x0224;

        public const uint WM_MDIMAXIMIZE = 0x0225;

        public const uint WM_MDITILE = 0x0226;

        public const uint WM_MDICASCADE = 0x0227;

        public const uint WM_MDIICONARRANGE = 0x0228;

        public const uint WM_MDIGETACTIVE = 0x0229;

        public const uint WM_MDISETMENU = 0x0230;

        public const uint WM_ENTERSIZEMOVE = 0x0231;

        public const uint WM_EXITSIZEMOVE = 0x0232;

        public const uint WM_DROPFILES = 0x0233;

        public const uint WM_MDIREFRESHMENU = 0x0234;

        public const uint WM_POINTERDEVICECHANGE = 0x0238;

        public const uint WM_POINTERDEVICEINRANGE = 0x0239;

        public const uint WM_POINTERDEVICEOUTOFRANGE = 0x023A;

        public const uint WM_TOUCH = 0x0240;

        public const uint WM_NCPOINTERUPDATE = 0x0241;

        public const uint WM_NCPOINTERDOWN = 0x0242;

        public const uint WM_NCPOINTERUP = 0x0243;

        public const uint WM_POINTERUPDATE = 0x0245;

        public const uint WM_POINTERDOWN = 0x0246;

        public const uint WM_POINTERUP = 0x0247;

        public const uint WM_POINTERENTER = 0x0249;

        public const uint WM_POINTERLEAVE = 0x024A;

        public const uint WM_POINTERACTIVATE = 0x024B;

        public const uint WM_POINTERCAPTURECHANGED = 0x024C;

        public const uint WM_TOUCHHITTESTING = 0x024D;

        public const uint WM_POINTERWHEEL = 0x024E;

        public const uint WM_POINTERHWHEEL = 0x024F;

        public const uint WM_POINTERROUTEDTO = 0x0251;

        public const uint WM_POINTERROUTEDAWAY = 0x0252;

        public const uint WM_POINTERROUTEDRELEASED = 0x0253;

        public const uint WM_IME_SETCONTEXT = 0x0281;

        public const uint WM_IME_NOTIFY = 0x0282;

        public const uint WM_IME_CONTROL = 0x0283;

        public const uint WM_IME_COMPOSITIONFULL = 0x0284;

        public const uint WM_IME_SELECT = 0x0285;

        public const uint WM_IME_CHAR = 0x0286;

        public const uint WM_IME_REQUEST = 0x0288;

        public const uint WM_IME_KEYDOWN = 0x0290;

        public const uint WM_IME_KEYUP = 0x0291;

        public const uint WM_MOUSEHOVER = 0x02A1;

        public const uint WM_MOUSELEAVE = 0x02A3;

        public const uint WM_NCMOUSEHOVER = 0x02A0;

        public const uint WM_NCMOUSELEAVE = 0x02A2;

        public const uint WM_WTSSESSION_CHANGE = 0x02B1;

        public const uint WM_TABLET_FIRST = 0x02C0;

        public const uint WM_TABLET_LAST = 0x02DF;

        public const uint WM_DPICHANGED = 0x02E0;

        public const uint WM_DPICHANGED_BEFOREPARENT = 0x02E2;

        public const uint WM_DPICHANGED_AFTERPARENT = 0x02E3;

        public const uint WM_GETDPISCALEDSIZE = 0x02E4;

        public const uint WM_CUT = 0x0300;

        public const uint WM_COPY = 0x0301;

        public const uint WM_PASTE = 0x0302;

        public const uint WM_CLEAR = 0x0303;

        public const uint WM_UNDO = 0x0304;

        public const uint WM_RENDERFORMAT = 0x0305;

        public const uint WM_RENDERALLFORMATS = 0x0306;

        public const uint WM_DESTROYCLIPBOARD = 0x0307;

        public const uint WM_DRAWCLIPBOARD = 0x0308;

        public const uint WM_PAINTCLIPBOARD = 0x0309;

        public const uint WM_VSCROLLCLIPBOARD = 0x030A;

        public const uint WM_SIZECLIPBOARD = 0x030B;

        public const uint WM_ASKCBFORMATNAME = 0x030C;

        public const uint WM_CHANGECBCHAIN = 0x030D;

        public const uint WM_HSCROLLCLIPBOARD = 0x030E;

        public const uint WM_QUERYNEWPALETTE = 0x030F;

        public const uint WM_PALETTEISCHANGING = 0x0310;

        public const uint WM_PALETTECHANGED = 0x0311;

        public const uint WM_HOTKEY = 0x0312;

        public const uint WM_PRINT = 0x0317;

        public const uint WM_PRINTCLIENT = 0x0318;

        public const uint WM_APPCOMMAND = 0x0319;

        public const uint WM_THEMECHANGED = 0x031A;

        public const uint WM_CLIPBOARDUPDATE = 0x031D;

        public const uint WM_DWMCOMPOSITIONCHANGED = 0x031E;

        public const uint WM_DWMNCRENDERINGCHANGED = 0x031F;

        public const uint WM_DWMCOLORIZATIONCOLORCHANGE = 0x0320;

        public const uint WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321;

        public const uint WM_DWMSENDICONICTHUMBNAIL = 0x0323;

        public const uint WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;

        public const uint WM_GETTITLEBARINFOEX = 0x033F;

        public const uint WM_HANDHELDFIRST = 0x0358;

        public const uint WM_HANDHELDLAST = 0x035F;

        public const uint WM_AFXFIRST = 0x0360;

        public const uint WM_AFXLAST = 0x037F;

        public const uint WM_PENWINFIRST = 0x0380;

        public const uint WM_PENWINLAST = 0x038F;

        public const uint WM_USER = 0x0400;

        public const uint WM_APP = 0x8000;

        public const int WA_INACTIVE = 0;

        public const int WA_ACTIVE = 1;

        public const int WA_CLICKACTIVE = 2;

        public const int SIZE_RESTORED = 0;

        public const int SIZE_MINIMIZED = 1;

        public const int SIZE_MAXIMIZED = 2;

        public const int SIZE_MAXSHOW = 3;

        public const int SIZE_MAXHIDE = 4;

        public const uint WS_OVERLAPPED = 0x00000000;

        public const uint WS_POPUP = 0x80000000;

        public const uint WS_CHILD = 0x40000000;

        public const uint WS_MINIMIZE = 0x20000000;

        public const uint WS_VISIBLE = 0x10000000;

        public const uint WS_DISABLED = 0x08000000;

        public const uint WS_CLIPSIBLINGS = 0x04000000;

        public const uint WS_CLIPCHILDREN = 0x02000000;

        public const uint WS_MAXIMIZE = 0x01000000;

        public const uint WS_CAPTION = 0x00C00000;

        public const uint WS_BORDER = 0x00800000;

        public const uint WS_DLGFRAME = 0x00400000;

        public const uint WS_VSCROLL = 0x00200000;

        public const uint WS_HSCROLL = 0x00100000;

        public const uint WS_SYSMENU = 0x00080000;

        public const uint WS_THICKFRAME = 0x00040000;

        public const uint WS_GROUP = 0x00020000;

        public const uint WS_TABSTOP = 0x00010000;

        public const uint WS_MINIMIZEBOX = 0x00020000;

        public const uint WS_MAXIMIZEBOX = 0x00010000;

        public const uint WS_TILED = WS_OVERLAPPED;

        public const uint WS_ICONIC = WS_MINIMIZE;

        public const uint WS_SIZEBOX = WS_THICKFRAME;

        public const uint WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;

        public const uint WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;

        public const uint WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU;

        public const uint WS_CHILDWINDOW = WS_CHILD;

        public const uint WS_EX_DLGMODALFRAME = 0x00000001;

        public const uint WS_EX_NOPARENTNOTIFY = 0x00000004;

        public const uint WS_EX_TOPMOST = 0x00000008;

        public const uint WS_EX_ACCEPTFILES = 0x00000010;

        public const uint WS_EX_TRANSPARENT = 0x00000020;

        public const uint WS_EX_MDICHILD = 0x00000040;

        public const uint WS_EX_TOOLWINDOW = 0x00000080;

        public const uint WS_EX_WINDOWEDGE = 0x00000100;

        public const uint WS_EX_CLIENTEDGE = 0x00000200;

        public const uint WS_EX_CONTEXTHELP = 0x00000400;

        public const uint WS_EX_RIGHT = 0x00001000;

        public const uint WS_EX_LEFT = 0x00000000;

        public const uint WS_EX_RTLREADING = 0x00002000;

        public const uint WS_EX_LTRREADING = 0x00000000;

        public const uint WS_EX_LEFTSCROLLBAR = 0x00004000;

        public const uint WS_EX_RIGHTSCROLLBAR = 0x00000000;

        public const uint WS_EX_CONTROLPARENT = 0x00010000;

        public const uint WS_EX_STATICEDGE = 0x00020000;

        public const uint WS_EX_APPWINDOW = 0x00040000;

        public const uint WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;

        public const uint WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;

        public const uint WS_EX_LAYERED = 0x00080000;

        public const uint WS_EX_NOINHERITLAYOUT = 0x00100000;

        public const uint WS_EX_NOREDIRECTIONBITMAP = 0x00200000;

        public const uint WS_EX_LAYOUTRTL = 0x00400000;

        public const uint WS_EX_COMPOSITED = 0x02000000;

        public const uint WS_EX_NOACTIVATE = 0x08000000;

        public const uint CS_VREDRAW = 0x0001;

        public const uint CS_HREDRAW = 0x0002;

        public const uint CS_DBLCLKS = 0x0008;

        public const uint CS_OWNDC = 0x0020;

        public const uint CS_CLASSDC = 0x0040;

        public const uint CS_PARENTDC = 0x0080;

        public const uint CS_NOCLOSE = 0x0200;

        public const uint CS_SAVEBITS = 0x0800;

        public const uint CS_BYTEALIGNCLIENT = 0x1000;

        public const uint CS_BYTEALIGNWINDOW = 0x2000;

        public const uint CS_GLOBALCLASS = 0x4000;

        public const uint CS_IME = 0x00010000;

        public const uint CS_DROPSHADOW = 0x00020000;

        public const int PM_NOREMOVE = 0x0000;

        public const int PM_REMOVE = 0x0001;

        public const int PM_NOYIELD = 0x0002;

        public const int PM_QS_INPUT = QS_INPUT << 16;

        public const int PM_QS_POSTMESSAGE = (QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) << 16;

        public const int PM_QS_PAINT = QS_PAINT << 16;

        public const int PM_QS_SENDMESSAGE = QS_SENDMESSAGE << 16;

        public const int CW_USEDEFAULT = unchecked((int)0x80000000);

        public const uint HWND_DESKTOP = 0;

        public const int QS_KEY = 0x0001;

        public const int QS_MOUSEMOVE = 0x0002;

        public const int QS_MOUSEBUTTON = 0x0004;

        public const int QS_POSTMESSAGE = 0x0008;

        public const int QS_TIMER = 0x0010;

        public const int QS_PAINT = 0x0020;

        public const int QS_SENDMESSAGE = 0x0040;

        public const int QS_HOTKEY = 0x0080;

        public const int QS_ALLPOSTMESSAGE = 0x0100;

        public const int QS_RAWINPUT = 0x0400;

        public const int QS_TOUCH = 0x0800;

        public const int QS_POINTER = 0x1000;

        public const int QS_MOUSE = QS_MOUSEMOVE | QS_MOUSEBUTTON;

        public const int QS_INPUT = QS_MOUSE | QS_KEY | QS_RAWINPUT | QS_TOUCH | QS_POINTER;

        public const int QS_ALLEVENTS = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY;

        public const int QS_ALLINPUT = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE;

        public const int COLOR_SCROLLBAR = 0;

        public const int COLOR_BACKGROUND = 1;

        public const int COLOR_ACTIVECAPTION = 2;

        public const int COLOR_INACTIVECAPTION = 3;

        public const int COLOR_MENU = 4;

        public const int COLOR_WINDOW = 5;

        public const int COLOR_WINDOWFRAME = 6;

        public const int COLOR_MENUTEXT = 7;

        public const int COLOR_WINDOWTEXT = 8;

        public const int COLOR_CAPTIONTEXT = 9;

        public const int COLOR_ACTIVEBORDER = 10;

        public const int COLOR_INACTIVEBORDER = 11;

        public const int COLOR_APPWORKSPACE = 12;

        public const int COLOR_HIGHLIGHT = 13;

        public const int COLOR_HIGHLIGHTTEXT = 14;

        public const int COLOR_BTNFACE = 15;

        public const int COLOR_BTNSHADOW = 16;

        public const int COLOR_GRAYTEXT = 17;

        public const int COLOR_BTNTEXT = 18;

        public const int COLOR_INACTIVECAPTIONTEXT = 19;

        public const int COLOR_BTNHIGHLIGHT = 20;

        public const int COLOR_3DDKSHADOW = 21;

        public const int COLOR_3DLIGHT = 22;

        public const int COLOR_INFOTEXT = 23;

        public const int COLOR_INFOBK = 24;

        public const int COLOR_HOTLIGHT = 26;

        public const int COLOR_GRADIENTACTIVECAPTION = 27;

        public const int COLOR_GRADIENTINACTIVECAPTION = 28;

        public const int COLOR_MENUHILIGHT = 29;

        public const int COLOR_MENUBAR = 30;

        public const int COLOR_DESKTOP = COLOR_BACKGROUND;

        public const int COLOR_3DFACE = COLOR_BTNFACE;

        public const int COLOR_3DSHADOW = COLOR_BTNSHADOW;

        public const int COLOR_3DHIGHLIGHT = COLOR_BTNHIGHLIGHT;

        public const int COLOR_3DHILIGHT = COLOR_BTNHIGHLIGHT;

        public const int COLOR_BTNHILIGHT = COLOR_BTNHIGHLIGHT;

        public const ushort IDC_ARROW = 32512;

        public const ushort IDC_IBEAM = 32513;

        public const ushort IDC_WAIT = 32514;

        public const ushort IDC_CROSS = 32515;

        public const ushort IDC_UPARROW = 32516;

        public const ushort IDC_SIZE = 32640;

        public const ushort IDC_ICON = 32641;

        public const ushort IDC_SIZENWSE = 32642;

        public const ushort IDC_SIZENESW = 32643;

        public const ushort IDC_SIZEWE = 32644;

        public const ushort IDC_SIZENS = 32645;

        public const ushort IDC_SIZEALL = 32646;

        public const ushort IDC_NO = 32648;

        public const ushort IDC_HAND = 32649;

        public const ushort IDC_APPSTARTING = 32650;

        public const ushort IDC_HELP = 32651;

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "AdjustWindowRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateWindowExW", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr CreateWindowEx([NativeTypeName("DWORD")] uint dwExStyle, [Optional, NativeTypeName("LPCWSTR")] ushort* lpClassName, [Optional, NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [Optional, NativeTypeName("HWND")] IntPtr hWndParent, [Optional, NativeTypeName("HMENU")] IntPtr hMenu, [Optional, NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefWindowProcW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DefWindowProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "DestroyWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "DispatchMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr DispatchMessage(MSG* lpMsg);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "EnableWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableWindow([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("BOOL")] int bEnable);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetActiveWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetActiveWindow();

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoEx([Optional, NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEX")] WNDCLASSEX* lpwcx);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetClassNameW", ExactSpelling = true)]
        public static extern int GetClassName([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDesktopWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern IntPtr _GetWindowLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetWindowRect", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowRect([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsWindowVisible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowVisible([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "LoadCursorW", ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern IntPtr LoadCursor([Optional, NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "PeekMessageW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessage([NativeTypeName("LPMSG")] MSG* lpMsg, [Optional, NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "PostQuitMessage", ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "RegisterClassExW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassEx(WNDCLASSEX* lpWndClassEx);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SendMessageW", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern IntPtr SendMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] UIntPtr wParam, [NativeTypeName("LPARAM")] IntPtr lParam);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetActiveWindow", ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern IntPtr SetActiveWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetForegroundWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetForegroundWindow([NativeTypeName("HWND")] IntPtr hWnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowLongW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLong([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern IntPtr _SetWindowLongPtr([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] IntPtr dwNewLong);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetWindowTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowText([NativeTypeName("HWND")] IntPtr hWnd, [Optional, NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "ShowWindow", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindow([NativeTypeName("HWND")] IntPtr hWnd, int nCmdShow);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "TranslateMessage", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMessage(MSG* lpMsg);

        [DllImport(DllName, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnregisterClassW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClass([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("HINSTANCE")] IntPtr hInstance = default);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 4)
            {
                return (IntPtr)GetWindowLong(hWnd, nIndex);
            }
            else
            {
                return _GetWindowLongPtr(hWnd, nIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 4)
            {
                return (IntPtr)SetWindowLong(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                return _SetWindowLongPtr(hWnd, nIndex, dwNewLong);
            }
        }
    }
}
