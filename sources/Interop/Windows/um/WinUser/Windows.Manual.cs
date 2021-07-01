// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int WH_HARDWARE = 8;

        public const int OBM_CLOSE = 32754;

        public const int OBM_UPARROW = 32753;

        public const int OBM_DNARROW = 32752;

        public const int OBM_RGARROW = 32751;

        public const int OBM_LFARROW = 32750;

        public const int OBM_REDUCE = 32749;

        public const int OBM_ZOOM = 32748;

        public const int OBM_RESTORE = 32747;

        public const int OBM_REDUCED = 32746;

        public const int OBM_ZOOMD = 32745;

        public const int OBM_RESTORED = 32744;

        public const int OBM_UPARROWD = 32743;

        public const int OBM_DNARROWD = 32742;

        public const int OBM_RGARROWD = 32741;

        public const int OBM_LFARROWD = 32740;

        public const int OBM_MNARROW = 32739;

        public const int OBM_COMBO = 32738;

        public const int OBM_UPARROWI = 32737;

        public const int OBM_DNARROWI = 32736;

        public const int OBM_RGARROWI = 32735;

        public const int OBM_LFARROWI = 32734;

        public const int OBM_OLD_CLOSE = 32767;

        public const int OBM_SIZE = 32766;

        public const int OBM_OLD_UPARROW = 32765;

        public const int OBM_OLD_DNARROW = 32764;

        public const int OBM_OLD_RGARROW = 32763;

        public const int OBM_OLD_LFARROW = 32762;

        public const int OBM_BTSIZE = 32761;

        public const int OBM_CHECK = 32760;

        public const int OBM_CHECKBOXES = 32759;

        public const int OBM_BTNCORNERS = 32758;

        public const int OBM_OLD_REDUCE = 32757;

        public const int OBM_OLD_ZOOM = 32756;

        public const int OBM_OLD_RESTORE = 32755;

        public const int OCR_NORMAL = 32512;

        public const int OCR_IBEAM = 32513;

        public const int OCR_WAIT = 32514;

        public const int OCR_CROSS = 32515;

        public const int OCR_UP = 32516;

        [Obsolete("use OCR_SIZEALL")]
        public const int OCR_SIZE = 32640;

        [Obsolete("use OCR_NORMAL")]
        public const int OCR_ICON = 32641;

        public const int OCR_SIZENWSE = 32642;

        public const int OCR_SIZENESW = 32643;

        public const int OCR_SIZEWE = 32644;

        public const int OCR_SIZENS = 32645;

        public const int OCR_SIZEALL = 32646;

        [Obsolete("use OIC_WINLOGO")]
        public const int OCR_ICOCUR = 32647;

        public const int OCR_NO = 32648;

        public const int OCR_HAND = 32649;

        public const int OCR_APPSTARTING = 32650;

        public const int OIC_SAMPLE = 32512;

        public const int OIC_HAND = 32513;

        public const int OIC_QUES = 32514;

        public const int OIC_BANG = 32515;

        public const int OIC_NOTE = 32516;

        public const int OIC_WINLOGO = 32517;

        public const int OIC_WARNING = OIC_BANG;

        public const int OIC_ERROR = OIC_HAND;

        public const int OIC_INFORMATION = OIC_NOTE;

        public const int OIC_SHIELD = 32518;

        public const int DS_USEPIXELS = 0x8000;

        public const int LB_MULTIPLEADDSTRING = 0x01B1;

        public const int CB_MULTIPLEADDSTRING = 0x0163;

        public const int SPI_GETBEEP = 0x0001;

        public const int SPI_SETBEEP = 0x0002;

        public const int SPI_GETMOUSE = 0x0003;

        public const int SPI_SETMOUSE = 0x0004;

        public const int SPI_GETBORDER = 0x0005;

        public const int SPI_SETBORDER = 0x0006;

        public const int SPI_GETKEYBOARDSPEED = 0x000A;

        public const int SPI_SETKEYBOARDSPEED = 0x000B;

        public const int SPI_LANGDRIVER = 0x000C;

        public const int SPI_ICONHORIZONTALSPACING = 0x000D;

        public const int SPI_GETSCREENSAVETIMEOUT = 0x000E;

        public const int SPI_SETSCREENSAVETIMEOUT = 0x000F;

        public const int SPI_GETSCREENSAVEACTIVE = 0x0010;

        public const int SPI_SETSCREENSAVEACTIVE = 0x0011;

        public const int SPI_GETGRIDGRANULARITY = 0x0012;

        public const int SPI_SETGRIDGRANULARITY = 0x0013;

        public const int SPI_SETDESKWALLPAPER = 0x0014;

        public const int SPI_SETDESKPATTERN = 0x0015;

        public const int SPI_GETKEYBOARDDELAY = 0x0016;

        public const int SPI_SETKEYBOARDDELAY = 0x0017;

        public const int SPI_ICONVERTICALSPACING = 0x0018;

        public const int SPI_GETICONTITLEWRAP = 0x0019;

        public const int SPI_SETICONTITLEWRAP = 0x001A;

        public const int SPI_GETMENUDROPALIGNMENT = 0x001B;

        public const int SPI_SETMENUDROPALIGNMENT = 0x001C;

        public const int SPI_SETDOUBLECLKWIDTH = 0x001D;

        public const int SPI_SETDOUBLECLKHEIGHT = 0x001E;

        public const int SPI_GETICONTITLELOGFONT = 0x001F;

        public const int SPI_SETDOUBLECLICKTIME = 0x0020;

        public const int SPI_SETMOUSEBUTTONSWAP = 0x0021;

        public const int SPI_SETICONTITLELOGFONT = 0x0022;

        public const int SPI_GETFASTTASKSWITCH = 0x0023;

        public const int SPI_SETFASTTASKSWITCH = 0x0024;

        public const int SPI_SETDRAGFULLWINDOWS = 0x0025;

        public const int SPI_GETDRAGFULLWINDOWS = 0x0026;

        public const int SPI_GETNONCLIENTMETRICS = 0x0029;

        public const int SPI_SETNONCLIENTMETRICS = 0x002A;

        public const int SPI_GETMINIMIZEDMETRICS = 0x002B;

        public const int SPI_SETMINIMIZEDMETRICS = 0x002C;

        public const int SPI_GETICONMETRICS = 0x002D;

        public const int SPI_SETICONMETRICS = 0x002E;

        public const int SPI_SETWORKAREA = 0x002F;

        public const int SPI_GETWORKAREA = 0x0030;

        public const int SPI_SETPENWINDOWS = 0x0031;

        public const int SPI_GETHIGHCONTRAST = 0x0042;

        public const int SPI_SETHIGHCONTRAST = 0x0043;

        public const int SPI_GETKEYBOARDPREF = 0x0044;

        public const int SPI_SETKEYBOARDPREF = 0x0045;

        public const int SPI_GETSCREENREADER = 0x0046;

        public const int SPI_SETSCREENREADER = 0x0047;

        public const int SPI_GETANIMATION = 0x0048;

        public const int SPI_SETANIMATION = 0x0049;

        public const int SPI_GETFONTSMOOTHING = 0x004A;

        public const int SPI_SETFONTSMOOTHING = 0x004B;

        public const int SPI_SETDRAGWIDTH = 0x004C;

        public const int SPI_SETDRAGHEIGHT = 0x004D;

        public const int SPI_SETHANDHELD = 0x004E;

        public const int SPI_GETLOWPOWERTIMEOUT = 0x004F;

        public const int SPI_GETPOWEROFFTIMEOUT = 0x0050;

        public const int SPI_SETLOWPOWERTIMEOUT = 0x0051;

        public const int SPI_SETPOWEROFFTIMEOUT = 0x0052;

        public const int SPI_GETLOWPOWERACTIVE = 0x0053;

        public const int SPI_GETPOWEROFFACTIVE = 0x0054;

        public const int SPI_SETLOWPOWERACTIVE = 0x0055;

        public const int SPI_SETPOWEROFFACTIVE = 0x0056;

        public const int SPI_SETCURSORS = 0x0057;

        public const int SPI_SETICONS = 0x0058;

        public const int SPI_GETDEFAULTINPUTLANG = 0x0059;

        public const int SPI_SETDEFAULTINPUTLANG = 0x005A;

        public const int SPI_SETLANGTOGGLE = 0x005B;

        public const int SPI_GETWINDOWSEXTENSION = 0x005C;

        public const int SPI_SETMOUSETRAILS = 0x005D;

        public const int SPI_GETMOUSETRAILS = 0x005E;

        public const int SPI_SETSCREENSAVERRUNNING = 0x0061;

        public const int SPI_SCREENSAVERRUNNING = SPI_SETSCREENSAVERRUNNING;

        public const int SPI_GETFILTERKEYS = 0x0032;

        public const int SPI_SETFILTERKEYS = 0x0033;

        public const int SPI_GETTOGGLEKEYS = 0x0034;

        public const int SPI_SETTOGGLEKEYS = 0x0035;

        public const int SPI_GETMOUSEKEYS = 0x0036;

        public const int SPI_SETMOUSEKEYS = 0x0037;

        public const int SPI_GETSHOWSOUNDS = 0x0038;

        public const int SPI_SETSHOWSOUNDS = 0x0039;

        public const int SPI_GETSTICKYKEYS = 0x003A;

        public const int SPI_SETSTICKYKEYS = 0x003B;

        public const int SPI_GETACCESSTIMEOUT = 0x003C;

        public const int SPI_SETACCESSTIMEOUT = 0x003D;

        public const int SPI_GETSERIALKEYS = 0x003E;

        public const int SPI_SETSERIALKEYS = 0x003F;

        public const int SPI_GETSOUNDSENTRY = 0x0040;

        public const int SPI_SETSOUNDSENTRY = 0x0041;

        public const int SPI_GETSNAPTODEFBUTTON = 0x005F;

        public const int SPI_SETSNAPTODEFBUTTON = 0x0060;

        public const int SPI_GETMOUSEHOVERWIDTH = 0x0062;

        public const int SPI_SETMOUSEHOVERWIDTH = 0x0063;

        public const int SPI_GETMOUSEHOVERHEIGHT = 0x0064;

        public const int SPI_SETMOUSEHOVERHEIGHT = 0x0065;

        public const int SPI_GETMOUSEHOVERTIME = 0x0066;

        public const int SPI_SETMOUSEHOVERTIME = 0x0067;

        public const int SPI_GETWHEELSCROLLLINES = 0x0068;

        public const int SPI_SETWHEELSCROLLLINES = 0x0069;

        public const int SPI_GETMENUSHOWDELAY = 0x006A;

        public const int SPI_SETMENUSHOWDELAY = 0x006B;

        public const int SPI_GETWHEELSCROLLCHARS = 0x006C;

        public const int SPI_SETWHEELSCROLLCHARS = 0x006D;

        public const int SPI_GETSHOWIMEUI = 0x006E;

        public const int SPI_SETSHOWIMEUI = 0x006F;

        public const int SPI_GETMOUSESPEED = 0x0070;

        public const int SPI_SETMOUSESPEED = 0x0071;

        public const int SPI_GETSCREENSAVERRUNNING = 0x0072;

        public const int SPI_GETDESKWALLPAPER = 0x0073;

        public const int SPI_GETAUDIODESCRIPTION = 0x0074;

        public const int SPI_SETAUDIODESCRIPTION = 0x0075;

        public const int SPI_GETSCREENSAVESECURE = 0x0076;

        public const int SPI_SETSCREENSAVESECURE = 0x0077;

        public const int SPI_GETHUNGAPPTIMEOUT = 0x0078;

        public const int SPI_SETHUNGAPPTIMEOUT = 0x0079;

        public const int SPI_GETWAITTOKILLTIMEOUT = 0x007A;

        public const int SPI_SETWAITTOKILLTIMEOUT = 0x007B;

        public const int SPI_GETWAITTOKILLSERVICETIMEOUT = 0x007C;

        public const int SPI_SETWAITTOKILLSERVICETIMEOUT = 0x007D;

        public const int SPI_GETMOUSEDOCKTHRESHOLD = 0x007E;

        public const int SPI_SETMOUSEDOCKTHRESHOLD = 0x007F;

        public const int SPI_GETPENDOCKTHRESHOLD = 0x0080;

        public const int SPI_SETPENDOCKTHRESHOLD = 0x0081;

        public const int SPI_GETWINARRANGING = 0x0082;

        public const int SPI_SETWINARRANGING = 0x0083;

        public const int SPI_GETMOUSEDRAGOUTTHRESHOLD = 0x0084;

        public const int SPI_SETMOUSEDRAGOUTTHRESHOLD = 0x0085;

        public const int SPI_GETPENDRAGOUTTHRESHOLD = 0x0086;

        public const int SPI_SETPENDRAGOUTTHRESHOLD = 0x0087;

        public const int SPI_GETMOUSESIDEMOVETHRESHOLD = 0x0088;

        public const int SPI_SETMOUSESIDEMOVETHRESHOLD = 0x0089;

        public const int SPI_GETPENSIDEMOVETHRESHOLD = 0x008A;

        public const int SPI_SETPENSIDEMOVETHRESHOLD = 0x008B;

        public const int SPI_GETDRAGFROMMAXIMIZE = 0x008C;

        public const int SPI_SETDRAGFROMMAXIMIZE = 0x008D;

        public const int SPI_GETSNAPSIZING = 0x008E;

        public const int SPI_SETSNAPSIZING = 0x008F;

        public const int SPI_GETDOCKMOVING = 0x0090;

        public const int SPI_SETDOCKMOVING = 0x0091;

        public const int MAX_TOUCH_PREDICTION_FILTER_TAPS = 3;

        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY = 8;

        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME = 8;

        public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP = 1;

        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA = 0.001f;

        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN = 0.9f;

        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX = 0.999f;

        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE = 0.001f;

        public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA = 0.99f;

        public const int SPI_GETTOUCHPREDICTIONPARAMETERS = 0x009C;

        public const int SPI_SETTOUCHPREDICTIONPARAMETERS = 0x009D;

        public const int MAX_LOGICALDPIOVERRIDE = 2;

        public const int MIN_LOGICALDPIOVERRIDE = -2;

        public const int SPI_GETLOGICALDPIOVERRIDE = 0x009E;

        public const int SPI_SETLOGICALDPIOVERRIDE = 0x009F;

        public const int SPI_GETMENURECT = 0x00A2;

        public const int SPI_SETMENURECT = 0x00A3;

        public const int SPI_GETACTIVEWINDOWTRACKING = 0x1000;

        public const int SPI_SETACTIVEWINDOWTRACKING = 0x1001;

        public const int SPI_GETMENUANIMATION = 0x1002;

        public const int SPI_SETMENUANIMATION = 0x1003;

        public const int SPI_GETCOMBOBOXANIMATION = 0x1004;

        public const int SPI_SETCOMBOBOXANIMATION = 0x1005;

        public const int SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;

        public const int SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;

        public const int SPI_GETGRADIENTCAPTIONS = 0x1008;

        public const int SPI_SETGRADIENTCAPTIONS = 0x1009;

        public const int SPI_GETKEYBOARDCUES = 0x100A;

        public const int SPI_SETKEYBOARDCUES = 0x100B;

        public const int SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES;

        public const int SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES;

        public const int SPI_GETACTIVEWNDTRKZORDER = 0x100C;

        public const int SPI_SETACTIVEWNDTRKZORDER = 0x100D;

        public const int SPI_GETHOTTRACKING = 0x100E;

        public const int SPI_SETHOTTRACKING = 0x100F;

        public const int SPI_GETMENUFADE = 0x1012;

        public const int SPI_SETMENUFADE = 0x1013;

        public const int SPI_GETSELECTIONFADE = 0x1014;

        public const int SPI_SETSELECTIONFADE = 0x1015;

        public const int SPI_GETTOOLTIPANIMATION = 0x1016;

        public const int SPI_SETTOOLTIPANIMATION = 0x1017;

        public const int SPI_GETTOOLTIPFADE = 0x1018;

        public const int SPI_SETTOOLTIPFADE = 0x1019;

        public const int SPI_GETCURSORSHADOW = 0x101A;

        public const int SPI_SETCURSORSHADOW = 0x101B;

        public const int SPI_GETMOUSESONAR = 0x101C;

        public const int SPI_SETMOUSESONAR = 0x101D;

        public const int SPI_GETMOUSECLICKLOCK = 0x101E;

        public const int SPI_SETMOUSECLICKLOCK = 0x101F;

        public const int SPI_GETMOUSEVANISH = 0x1020;

        public const int SPI_SETMOUSEVANISH = 0x1021;

        public const int SPI_GETFLATMENU = 0x1022;

        public const int SPI_SETFLATMENU = 0x1023;

        public const int SPI_GETDROPSHADOW = 0x1024;

        public const int SPI_SETDROPSHADOW = 0x1025;

        public const int SPI_GETBLOCKSENDINPUTRESETS = 0x1026;

        public const int SPI_SETBLOCKSENDINPUTRESETS = 0x1027;

        public const int SPI_GETUIEFFECTS = 0x103E;

        public const int SPI_SETUIEFFECTS = 0x103F;

        public const int SPI_GETDISABLEOVERLAPPEDCONTENT = 0x1040;

        public const int SPI_SETDISABLEOVERLAPPEDCONTENT = 0x1041;

        public const int SPI_GETCLIENTAREAANIMATION = 0x1042;

        public const int SPI_SETCLIENTAREAANIMATION = 0x1043;

        public const int SPI_GETCLEARTYPE = 0x1048;

        public const int SPI_SETCLEARTYPE = 0x1049;

        public const int SPI_GETSPEECHRECOGNITION = 0x104A;

        public const int SPI_SETSPEECHRECOGNITION = 0x104B;

        public const int SPI_GETCARETBROWSING = 0x104C;

        public const int SPI_SETCARETBROWSING = 0x104D;

        public const int SPI_GETTHREADLOCALINPUTSETTINGS = 0x104E;

        public const int SPI_SETTHREADLOCALINPUTSETTINGS = 0x104F;

        public const int SPI_GETSYSTEMLANGUAGEBAR = 0x1050;

        public const int SPI_SETSYSTEMLANGUAGEBAR = 0x1051;

        public const int SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;

        public const int SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;

        public const int SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;

        public const int SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;

        public const int SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;

        public const int SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;

        public const int SPI_GETCARETWIDTH = 0x2006;

        public const int SPI_SETCARETWIDTH = 0x2007;

        public const int SPI_GETMOUSECLICKLOCKTIME = 0x2008;

        public const int SPI_SETMOUSECLICKLOCKTIME = 0x2009;

        public const int SPI_GETFONTSMOOTHINGTYPE = 0x200A;

        public const int SPI_SETFONTSMOOTHINGTYPE = 0x200B;

        public const int FE_FONTSMOOTHINGSTANDARD = 0x0001;

        public const int FE_FONTSMOOTHINGCLEARTYPE = 0x0002;

        public const int SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;

        public const int SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;

        public const int SPI_GETFOCUSBORDERWIDTH = 0x200E;

        public const int SPI_SETFOCUSBORDERWIDTH = 0x200F;

        public const int SPI_GETFOCUSBORDERHEIGHT = 0x2010;

        public const int SPI_SETFOCUSBORDERHEIGHT = 0x2011;

        public const int SPI_GETFONTSMOOTHINGORIENTATION = 0x2012;

        public const int SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;

        public const int FE_FONTSMOOTHINGORIENTATIONBGR = 0x0000;

        public const int FE_FONTSMOOTHINGORIENTATIONRGB = 0x0001;

        public const int SPI_GETMINIMUMHITRADIUS = 0x2014;

        public const int SPI_SETMINIMUMHITRADIUS = 0x2015;

        public const int SPI_GETMESSAGEDURATION = 0x2016;

        public const int SPI_SETMESSAGEDURATION = 0x2017;

        public const int SPI_GETCONTACTVISUALIZATION = 0x2018;

        public const int SPI_SETCONTACTVISUALIZATION = 0x2019;

        public const int CONTACTVISUALIZATION_OFF = 0x0000;

        public const int CONTACTVISUALIZATION_ON = 0x0001;

        public const int CONTACTVISUALIZATION_PRESENTATIONMODE = 0x0002;

        public const int SPI_GETGESTUREVISUALIZATION = 0x201A;

        public const int SPI_SETGESTUREVISUALIZATION = 0x201B;

        public const int GESTUREVISUALIZATION_OFF = 0x0000;

        public const int GESTUREVISUALIZATION_ON = 0x001F;

        public const int GESTUREVISUALIZATION_TAP = 0x0001;

        public const int GESTUREVISUALIZATION_DOUBLETAP = 0x0002;

        public const int GESTUREVISUALIZATION_PRESSANDTAP = 0x0004;

        public const int GESTUREVISUALIZATION_PRESSANDHOLD = 0x0008;

        public const int GESTUREVISUALIZATION_RIGHTTAP = 0x0010;

        public const int SPI_GETMOUSEWHEELROUTING = 0x201C;

        public const int SPI_SETMOUSEWHEELROUTING = 0x201D;

        public const int MOUSEWHEEL_ROUTING_FOCUS = 0;

        public const int MOUSEWHEEL_ROUTING_HYBRID = 1;

        public const int MOUSEWHEEL_ROUTING_MOUSE_POS = 2;

        public const int SPI_GETPENVISUALIZATION = 0x201E;

        public const int SPI_SETPENVISUALIZATION = 0x201F;

        public const int PENVISUALIZATION_ON = 0x0023;

        public const int PENVISUALIZATION_OFF = 0x0000;

        public const int PENVISUALIZATION_TAP = 0x0001;

        public const int PENVISUALIZATION_DOUBLETAP = 0x0002;

        public const int PENVISUALIZATION_CURSOR = 0x0020;

        public const int SPI_GETPENARBITRATIONTYPE = 0x2020;

        public const int SPI_SETPENARBITRATIONTYPE = 0x2021;

        public const int PENARBITRATIONTYPE_NONE = 0x0000;

        public const int PENARBITRATIONTYPE_WIN8 = 0x0001;

        public const int PENARBITRATIONTYPE_FIS = 0x0002;

        public const int PENARBITRATIONTYPE_SPT = 0x0003;

        public const int PENARBITRATIONTYPE_MAX = 0x0004;

        public const int SPI_GETCARETTIMEOUT = 0x2022;

        public const int SPI_SETCARETTIMEOUT = 0x2023;

        public const int SPI_GETHANDEDNESS = 0x2024;

        public const int SPI_SETHANDEDNESS = 0x2025;

        public const int SPIF_UPDATEINIFILE = 0x0001;

        public const int SPIF_SENDWININICHANGE = 0x0002;

        public const int SPIF_SENDCHANGE = SPIF_SENDWININICHANGE;

        public const int METRICS_USEDEFAULT = -1;

        public const int ARW_BOTTOMLEFT = 0x0000;

        public const int ARW_BOTTOMRIGHT = 0x0001;

        public const int ARW_TOPLEFT = 0x0002;

        public const int ARW_TOPRIGHT = 0x0003;

        public const int ARW_STARTMASK = 0x0003;

        public const int ARW_STARTRIGHT = 0x0001;

        public const int ARW_STARTTOP = 0x0002;

        public const int ARW_LEFT = 0x0000;

        public const int ARW_RIGHT = 0x0000;

        public const int ARW_UP = 0x0004;

        public const int ARW_DOWN = 0x0004;

        public const int ARW_HIDE = 0x0008;

        public const int SERKF_SERIALKEYSON = 0x00000001;

        public const int SERKF_AVAILABLE = 0x00000002;

        public const int SERKF_INDICATOR = 0x00000004;

        public const int HCF_HIGHCONTRASTON = 0x00000001;

        public const int HCF_AVAILABLE = 0x00000002;

        public const int HCF_HOTKEYACTIVE = 0x00000004;

        public const int HCF_CONFIRMHOTKEY = 0x00000008;

        public const int HCF_HOTKEYSOUND = 0x00000010;

        public const int HCF_INDICATOR = 0x00000020;

        public const int HCF_HOTKEYAVAILABLE = 0x00000040;

        public const int HCF_LOGONDESKTOP = 0x00000100;

        public const int HCF_DEFAULTDESKTOP = 0x00000200;

        public const int HCF_OPTION_NOTHEMECHANGE = 0x00001000;

        public const int CDS_UPDATEREGISTRY = 0x00000001;

        public const int CDS_TEST = 0x00000002;

        public const int CDS_FULLSCREEN = 0x00000004;

        public const int CDS_GLOBAL = 0x00000008;

        public const int CDS_SET_PRIMARY = 0x00000010;

        public const int CDS_VIDEOPARAMETERS = 0x00000020;

        public const int CDS_ENABLE_UNSAFE_MODES = 0x00000100;

        public const int CDS_DISABLE_UNSAFE_MODES = 0x00000200;

        public const int CDS_RESET = 0x40000000;

        public const int CDS_RESET_EX = 0x20000000;

        public const int CDS_NORESET = 0x10000000;

        public const int DISP_CHANGE_SUCCESSFUL = 0;

        public const int DISP_CHANGE_RESTART = 1;

        public const int DISP_CHANGE_FAILED = -1;

        public const int DISP_CHANGE_BADMODE = -2;

        public const int DISP_CHANGE_NOTUPDATED = -3;

        public const int DISP_CHANGE_BADFLAGS = -4;

        public const int DISP_CHANGE_BADPARAM = -5;

        public const int DISP_CHANGE_BADDUALVIEW = -6;

        public const uint ENUM_CURRENT_SETTINGS = unchecked((uint)-1);

        public const uint ENUM_REGISTRY_SETTINGS = unchecked((uint)-2);

        public const int EDS_RAWMODE = 0x00000002;

        public const int EDS_ROTATEDMODE = 0x00000004;

        public const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_INTRESOURCE([NativeTypeName("ULONG_PTR")] nuint _r)
        {
            return (_r >> 16) == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPWSTR")]
        public static ushort* MAKEINTRESOURCE(ushort i) => (ushort*)(nuint)i;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static POINT POINTSTOPOINT(POINTS pts)
        {
            return new POINT {
                x = (short)LOWORD(*(uint*)&pts),
                y = (short)HIWORD(*(uint*)&pts),
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int POINTTOPOINTS(POINTS pt) => MAKELONG((ushort)pt.x, (ushort)pt.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("WPARAM")]
        public static nuint MAKEWPARAM(ushort l, ushort h) => (nuint)MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPARAM")]
        public static nint MAKELPARAM(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public static nint MAKELRESULT(ushort l, ushort h) => MAKELONG(l, h);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_APPCOMMAND_LPARAM([NativeTypeName("LPARAM")] nint lParam) => unchecked((short)(HIWORD((uint)lParam) & ~FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => unchecked((ushort)(HIWORD((uint)lParam) & FAPPCOMMAND_MASK));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_MOUSEORKEY_LPARAM([NativeTypeName("LPARAM")] nint lParam) => GET_DEVICE_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_FLAGS_LPARAM([NativeTypeName("LPARAM")] nint lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => GET_FLAGS_LPARAM(lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_WHEEL_DELTA_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((short)HIWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_KEYSTATE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short GET_NCHITTEST_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((short)LOWORD((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_XBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => HIWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int ExitWindows(uint dwReserved, int Code) => ExitWindowsEx(EWX_LOGOFF, 0xFFFFFFFF);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int PostAppMessageA([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam) => PostThreadMessageA(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int PostAppMessageW([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam) => PostThreadMessageW(idThread, wMsg, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExA(0, lpClassName, lpWindowName, dwStyle, x, y,nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("HMENU")] IntPtr hMenu, [NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExW(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogIndirectA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr CreateDialogIndirectW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectA([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("INT_PTR")]
        public static IntPtr DialogBoxIndirectW([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpDialogFunc) => DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TOUCH_COORD_TO_PIXEL(int l) => l / 100;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_POINTERID_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FLAG_SET_WPARAM([NativeTypeName("WPARAM")] nuint wParam, uint flag) => (HIWORD(unchecked((uint)wParam)) & flag) == flag;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_NEW_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_NEW);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INRANGE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INRANGE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_INCONTACT_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INCONTACT);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIRSTBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIRSTBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_SECONDBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_SECONDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_THIRDBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_THIRDBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FOURTHBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FOURTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_FIFTHBUTTON_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIFTHBUTTON);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_PRIMARY_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_PRIMARY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HAS_POINTER_CONFIDENCE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CONFIDENCE);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IS_POINTER_CANCELED_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CANCELED);

        [NativeTypeName("#define GetWindowLongPtr GetWindowLongPtrW")]
        public static readonly delegate*<IntPtr, int, nint> GetWindowLongPtr = &GetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetWindowLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint GetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nint) == 4)
            {
                return GetWindowLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _GetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetWindowLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetWindowLongPtr SetWindowLongPtrW")]
        public static readonly delegate*<IntPtr, int, nint, nint> SetWindowLongPtr = &SetWindowLongPtrW;

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("LONG_PTR")]
        public static nint SetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nint) == 4)
            {
                return SetWindowLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("LONG_PTR")]
                static extern nint _SetWindowLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetWindowLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [NativeTypeName("#define GetClassLongPtr GetClassLongPtrW")]
        public static readonly delegate*<IntPtr, int, nuint> GetClassLongPtr = &GetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongA(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetClassLongPtrA(hWnd, nIndex);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint GetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex)
        {
            if (sizeof(nuint) == 4)
            {
                return GetClassLongW(hWnd, nIndex);
            }
            else
            {
                [DllImport("user32", EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _GetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex);

                return _GetClassLongPtrW(hWnd, nIndex);
            }
        }

        [NativeTypeName("#define SetClassLongPtr SetClassLongPtrW")]
        public static readonly delegate*<IntPtr, int, nint, nuint> SetClassLongPtr = &SetClassLongPtrW;

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongA(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrA", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrA([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrA(hWnd, nIndex, dwNewLong);
            }
        }

        [return: NativeTypeName("ULONG_PTR")]
        public static nuint SetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
        {
            if (sizeof(nuint) == 4)
            {
                return SetClassLongW(hWnd, nIndex, (int)dwNewLong);
            }
            else
            {
                [DllImport("user32", EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
                [return: NativeTypeName("ULONG_PTR")]
                static extern nuint _SetClassLongPtrW([NativeTypeName("HWND")] IntPtr hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

                return _SetClassLongPtrW(hWnd, nIndex, dwNewLong);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public static int EnumTaskWindows(IntPtr hTask, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<IntPtr, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam) => EnumThreadWindows((uint)hTask, lpfn, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr GetNextWindow([NativeTypeName("HWND")] IntPtr hWnd, ushort wCmd) => GetWindow(hWnd, wCmd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr GetSysModalWindow() => IntPtr.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HWND")]
        public static IntPtr SetSysModalWindow([NativeTypeName("HWND")] IntPtr hWnd) => IntPtr.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public static void* GetWindowTask([NativeTypeName("HWND")] IntPtr hWnd) => (void*)(nuint)GetWindowThreadProcessId(hWnd, null);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LRESULT")]
        public static IntPtr DefHookProc(int nCode, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("HHOOK")] IntPtr* phhk) => CallNextHookEx(*phhk, nCode, wParam, lParam);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GET_SC_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => unchecked((int)(wParam & 0xFFF0));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint GET_RAWINPUT_CODE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => wParam & 0xFF;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint RAWINPUT_ALIGN(nint x) => (x + sizeof(nint) - 1) & ~(sizeof(nint) - 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RAWINPUT* NEXTRAWINPUTBLOCK(RAWINPUT* ptr) => (RAWINPUT*)(RAWINPUT_ALIGN((nint)ptr) + ptr->header.dwSize);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RIDEV_EXMODE(int mode) => mode & RIDEV_EXMODEMASK;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_WPARAM([NativeTypeName("WPARAM")] nuint wParam) => LOWORD(unchecked((uint)wParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GET_DEVICE_CHANGE_LPARAM([NativeTypeName("LPARAM")] nint lParam) => LOWORD(unchecked((uint)lParam));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort GID_ROTATE_ANGLE_TO_ARGUMENT(ushort _arg_) => (ushort)((_arg_ + (2.0 * 3.14159265)) / (4.0 * 3.14159265) * 65535.0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double GID_ROTATE_ANGLE_FROM_ARGUMENT(double  _arg_) => (_arg_ / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);
    }
}
