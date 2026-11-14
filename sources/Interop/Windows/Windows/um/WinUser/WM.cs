// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WM
{
    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NULL"]/*' />
    [NativeTypeName("#define WM_NULL 0x0000")]
    public const int WM_NULL = 0x0000;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CREATE"]/*' />
    [NativeTypeName("#define WM_CREATE 0x0001")]
    public const int WM_CREATE = 0x0001;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DESTROY"]/*' />
    [NativeTypeName("#define WM_DESTROY 0x0002")]
    public const int WM_DESTROY = 0x0002;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOVE"]/*' />
    [NativeTypeName("#define WM_MOVE 0x0003")]
    public const int WM_MOVE = 0x0003;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SIZE"]/*' />
    [NativeTypeName("#define WM_SIZE 0x0005")]
    public const int WM_SIZE = 0x0005;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ACTIVATE"]/*' />
    [NativeTypeName("#define WM_ACTIVATE 0x0006")]
    public const int WM_ACTIVATE = 0x0006;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETFOCUS"]/*' />
    [NativeTypeName("#define WM_SETFOCUS 0x0007")]
    public const int WM_SETFOCUS = 0x0007;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_KILLFOCUS"]/*' />
    [NativeTypeName("#define WM_KILLFOCUS 0x0008")]
    public const int WM_KILLFOCUS = 0x0008;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENABLE"]/*' />
    [NativeTypeName("#define WM_ENABLE 0x000A")]
    public const int WM_ENABLE = 0x000A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETREDRAW"]/*' />
    [NativeTypeName("#define WM_SETREDRAW 0x000B")]
    public const int WM_SETREDRAW = 0x000B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETTEXT"]/*' />
    [NativeTypeName("#define WM_SETTEXT 0x000C")]
    public const int WM_SETTEXT = 0x000C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETTEXT"]/*' />
    [NativeTypeName("#define WM_GETTEXT 0x000D")]
    public const int WM_GETTEXT = 0x000D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETTEXTLENGTH"]/*' />
    [NativeTypeName("#define WM_GETTEXTLENGTH 0x000E")]
    public const int WM_GETTEXTLENGTH = 0x000E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PAINT"]/*' />
    [NativeTypeName("#define WM_PAINT 0x000F")]
    public const int WM_PAINT = 0x000F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CLOSE"]/*' />
    [NativeTypeName("#define WM_CLOSE 0x0010")]
    public const int WM_CLOSE = 0x0010;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUERYENDSESSION"]/*' />
    [NativeTypeName("#define WM_QUERYENDSESSION 0x0011")]
    public const int WM_QUERYENDSESSION = 0x0011;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUERYOPEN"]/*' />
    [NativeTypeName("#define WM_QUERYOPEN 0x0013")]
    public const int WM_QUERYOPEN = 0x0013;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENDSESSION"]/*' />
    [NativeTypeName("#define WM_ENDSESSION 0x0016")]
    public const int WM_ENDSESSION = 0x0016;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUIT"]/*' />
    [NativeTypeName("#define WM_QUIT 0x0012")]
    public const int WM_QUIT = 0x0012;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ERASEBKGND"]/*' />
    [NativeTypeName("#define WM_ERASEBKGND 0x0014")]
    public const int WM_ERASEBKGND = 0x0014;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSCOLORCHANGE"]/*' />
    [NativeTypeName("#define WM_SYSCOLORCHANGE 0x0015")]
    public const int WM_SYSCOLORCHANGE = 0x0015;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SHOWWINDOW"]/*' />
    [NativeTypeName("#define WM_SHOWWINDOW 0x0018")]
    public const int WM_SHOWWINDOW = 0x0018;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_WININICHANGE"]/*' />
    [NativeTypeName("#define WM_WININICHANGE 0x001A")]
    public const int WM_WININICHANGE = 0x001A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETTINGCHANGE"]/*' />
    [NativeTypeName("#define WM_SETTINGCHANGE WM_WININICHANGE")]
    public const int WM_SETTINGCHANGE = 0x001A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DEVMODECHANGE"]/*' />
    [NativeTypeName("#define WM_DEVMODECHANGE 0x001B")]
    public const int WM_DEVMODECHANGE = 0x001B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ACTIVATEAPP"]/*' />
    [NativeTypeName("#define WM_ACTIVATEAPP 0x001C")]
    public const int WM_ACTIVATEAPP = 0x001C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_FONTCHANGE"]/*' />
    [NativeTypeName("#define WM_FONTCHANGE 0x001D")]
    public const int WM_FONTCHANGE = 0x001D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TIMECHANGE"]/*' />
    [NativeTypeName("#define WM_TIMECHANGE 0x001E")]
    public const int WM_TIMECHANGE = 0x001E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CANCELMODE"]/*' />
    [NativeTypeName("#define WM_CANCELMODE 0x001F")]
    public const int WM_CANCELMODE = 0x001F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETCURSOR"]/*' />
    [NativeTypeName("#define WM_SETCURSOR 0x0020")]
    public const int WM_SETCURSOR = 0x0020;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEACTIVATE"]/*' />
    [NativeTypeName("#define WM_MOUSEACTIVATE 0x0021")]
    public const int WM_MOUSEACTIVATE = 0x0021;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHILDACTIVATE"]/*' />
    [NativeTypeName("#define WM_CHILDACTIVATE 0x0022")]
    public const int WM_CHILDACTIVATE = 0x0022;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUEUESYNC"]/*' />
    [NativeTypeName("#define WM_QUEUESYNC 0x0023")]
    public const int WM_QUEUESYNC = 0x0023;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETMINMAXINFO"]/*' />
    [NativeTypeName("#define WM_GETMINMAXINFO 0x0024")]
    public const int WM_GETMINMAXINFO = 0x0024;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PAINTICON"]/*' />
    [NativeTypeName("#define WM_PAINTICON 0x0026")]
    public const int WM_PAINTICON = 0x0026;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ICONERASEBKGND"]/*' />
    [NativeTypeName("#define WM_ICONERASEBKGND 0x0027")]
    public const int WM_ICONERASEBKGND = 0x0027;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NEXTDLGCTL"]/*' />
    [NativeTypeName("#define WM_NEXTDLGCTL 0x0028")]
    public const int WM_NEXTDLGCTL = 0x0028;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SPOOLERSTATUS"]/*' />
    [NativeTypeName("#define WM_SPOOLERSTATUS 0x002A")]
    public const int WM_SPOOLERSTATUS = 0x002A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DRAWITEM"]/*' />
    [NativeTypeName("#define WM_DRAWITEM 0x002B")]
    public const int WM_DRAWITEM = 0x002B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MEASUREITEM"]/*' />
    [NativeTypeName("#define WM_MEASUREITEM 0x002C")]
    public const int WM_MEASUREITEM = 0x002C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DELETEITEM"]/*' />
    [NativeTypeName("#define WM_DELETEITEM 0x002D")]
    public const int WM_DELETEITEM = 0x002D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_VKEYTOITEM"]/*' />
    [NativeTypeName("#define WM_VKEYTOITEM 0x002E")]
    public const int WM_VKEYTOITEM = 0x002E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHARTOITEM"]/*' />
    [NativeTypeName("#define WM_CHARTOITEM 0x002F")]
    public const int WM_CHARTOITEM = 0x002F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETFONT"]/*' />
    [NativeTypeName("#define WM_SETFONT 0x0030")]
    public const int WM_SETFONT = 0x0030;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETFONT"]/*' />
    [NativeTypeName("#define WM_GETFONT 0x0031")]
    public const int WM_GETFONT = 0x0031;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETHOTKEY"]/*' />
    [NativeTypeName("#define WM_SETHOTKEY 0x0032")]
    public const int WM_SETHOTKEY = 0x0032;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETHOTKEY"]/*' />
    [NativeTypeName("#define WM_GETHOTKEY 0x0033")]
    public const int WM_GETHOTKEY = 0x0033;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUERYDRAGICON"]/*' />
    [NativeTypeName("#define WM_QUERYDRAGICON 0x0037")]
    public const int WM_QUERYDRAGICON = 0x0037;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COMPAREITEM"]/*' />
    [NativeTypeName("#define WM_COMPAREITEM 0x0039")]
    public const int WM_COMPAREITEM = 0x0039;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETOBJECT"]/*' />
    [NativeTypeName("#define WM_GETOBJECT 0x003D")]
    public const int WM_GETOBJECT = 0x003D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COMPACTING"]/*' />
    [NativeTypeName("#define WM_COMPACTING 0x0041")]
    public const int WM_COMPACTING = 0x0041;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COMMNOTIFY"]/*' />
    [NativeTypeName("#define WM_COMMNOTIFY 0x0044")]
    public const int WM_COMMNOTIFY = 0x0044;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_WINDOWPOSCHANGING"]/*' />
    [NativeTypeName("#define WM_WINDOWPOSCHANGING 0x0046")]
    public const int WM_WINDOWPOSCHANGING = 0x0046;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_WINDOWPOSCHANGED"]/*' />
    [NativeTypeName("#define WM_WINDOWPOSCHANGED 0x0047")]
    public const int WM_WINDOWPOSCHANGED = 0x0047;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POWER"]/*' />
    [NativeTypeName("#define WM_POWER 0x0048")]
    public const int WM_POWER = 0x0048;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COPYDATA"]/*' />
    [NativeTypeName("#define WM_COPYDATA 0x004A")]
    public const int WM_COPYDATA = 0x004A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CANCELJOURNAL"]/*' />
    [NativeTypeName("#define WM_CANCELJOURNAL 0x004B")]
    public const int WM_CANCELJOURNAL = 0x004B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NOTIFY"]/*' />
    [NativeTypeName("#define WM_NOTIFY 0x004E")]
    public const int WM_NOTIFY = 0x004E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INPUTLANGCHANGEREQUEST"]/*' />
    [NativeTypeName("#define WM_INPUTLANGCHANGEREQUEST 0x0050")]
    public const int WM_INPUTLANGCHANGEREQUEST = 0x0050;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INPUTLANGCHANGE"]/*' />
    [NativeTypeName("#define WM_INPUTLANGCHANGE 0x0051")]
    public const int WM_INPUTLANGCHANGE = 0x0051;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TCARD"]/*' />
    [NativeTypeName("#define WM_TCARD 0x0052")]
    public const int WM_TCARD = 0x0052;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HELP"]/*' />
    [NativeTypeName("#define WM_HELP 0x0053")]
    public const int WM_HELP = 0x0053;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_USERCHANGED"]/*' />
    [NativeTypeName("#define WM_USERCHANGED 0x0054")]
    public const int WM_USERCHANGED = 0x0054;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NOTIFYFORMAT"]/*' />
    [NativeTypeName("#define WM_NOTIFYFORMAT 0x0055")]
    public const int WM_NOTIFYFORMAT = 0x0055;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CONTEXTMENU"]/*' />
    [NativeTypeName("#define WM_CONTEXTMENU 0x007B")]
    public const int WM_CONTEXTMENU = 0x007B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_STYLECHANGING"]/*' />
    [NativeTypeName("#define WM_STYLECHANGING 0x007C")]
    public const int WM_STYLECHANGING = 0x007C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_STYLECHANGED"]/*' />
    [NativeTypeName("#define WM_STYLECHANGED 0x007D")]
    public const int WM_STYLECHANGED = 0x007D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DISPLAYCHANGE"]/*' />
    [NativeTypeName("#define WM_DISPLAYCHANGE 0x007E")]
    public const int WM_DISPLAYCHANGE = 0x007E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETICON"]/*' />
    [NativeTypeName("#define WM_GETICON 0x007F")]
    public const int WM_GETICON = 0x007F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SETICON"]/*' />
    [NativeTypeName("#define WM_SETICON 0x0080")]
    public const int WM_SETICON = 0x0080;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCCREATE"]/*' />
    [NativeTypeName("#define WM_NCCREATE 0x0081")]
    public const int WM_NCCREATE = 0x0081;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCDESTROY"]/*' />
    [NativeTypeName("#define WM_NCDESTROY 0x0082")]
    public const int WM_NCDESTROY = 0x0082;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCCALCSIZE"]/*' />
    [NativeTypeName("#define WM_NCCALCSIZE 0x0083")]
    public const int WM_NCCALCSIZE = 0x0083;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCHITTEST"]/*' />
    [NativeTypeName("#define WM_NCHITTEST 0x0084")]
    public const int WM_NCHITTEST = 0x0084;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCPAINT"]/*' />
    [NativeTypeName("#define WM_NCPAINT 0x0085")]
    public const int WM_NCPAINT = 0x0085;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCACTIVATE"]/*' />
    [NativeTypeName("#define WM_NCACTIVATE 0x0086")]
    public const int WM_NCACTIVATE = 0x0086;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETDLGCODE"]/*' />
    [NativeTypeName("#define WM_GETDLGCODE 0x0087")]
    public const int WM_GETDLGCODE = 0x0087;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYNCPAINT"]/*' />
    [NativeTypeName("#define WM_SYNCPAINT 0x0088")]
    public const int WM_SYNCPAINT = 0x0088;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMOUSEMOVE"]/*' />
    [NativeTypeName("#define WM_NCMOUSEMOVE 0x00A0")]
    public const int WM_NCMOUSEMOVE = 0x00A0;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCLBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_NCLBUTTONDOWN 0x00A1")]
    public const int WM_NCLBUTTONDOWN = 0x00A1;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCLBUTTONUP"]/*' />
    [NativeTypeName("#define WM_NCLBUTTONUP 0x00A2")]
    public const int WM_NCLBUTTONUP = 0x00A2;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCLBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_NCLBUTTONDBLCLK 0x00A3")]
    public const int WM_NCLBUTTONDBLCLK = 0x00A3;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCRBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_NCRBUTTONDOWN 0x00A4")]
    public const int WM_NCRBUTTONDOWN = 0x00A4;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCRBUTTONUP"]/*' />
    [NativeTypeName("#define WM_NCRBUTTONUP 0x00A5")]
    public const int WM_NCRBUTTONUP = 0x00A5;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCRBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_NCRBUTTONDBLCLK 0x00A6")]
    public const int WM_NCRBUTTONDBLCLK = 0x00A6;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_NCMBUTTONDOWN 0x00A7")]
    public const int WM_NCMBUTTONDOWN = 0x00A7;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMBUTTONUP"]/*' />
    [NativeTypeName("#define WM_NCMBUTTONUP 0x00A8")]
    public const int WM_NCMBUTTONUP = 0x00A8;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_NCMBUTTONDBLCLK 0x00A9")]
    public const int WM_NCMBUTTONDBLCLK = 0x00A9;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCXBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_NCXBUTTONDOWN 0x00AB")]
    public const int WM_NCXBUTTONDOWN = 0x00AB;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCXBUTTONUP"]/*' />
    [NativeTypeName("#define WM_NCXBUTTONUP 0x00AC")]
    public const int WM_NCXBUTTONUP = 0x00AC;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCXBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_NCXBUTTONDBLCLK 0x00AD")]
    public const int WM_NCXBUTTONDBLCLK = 0x00AD;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INPUT_DEVICE_CHANGE"]/*' />
    [NativeTypeName("#define WM_INPUT_DEVICE_CHANGE 0x00FE")]
    public const int WM_INPUT_DEVICE_CHANGE = 0x00FE;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INPUT"]/*' />
    [NativeTypeName("#define WM_INPUT 0x00FF")]
    public const int WM_INPUT = 0x00FF;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_KEYFIRST"]/*' />
    [NativeTypeName("#define WM_KEYFIRST 0x0100")]
    public const int WM_KEYFIRST = 0x0100;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_KEYDOWN"]/*' />
    [NativeTypeName("#define WM_KEYDOWN 0x0100")]
    public const int WM_KEYDOWN = 0x0100;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_KEYUP"]/*' />
    [NativeTypeName("#define WM_KEYUP 0x0101")]
    public const int WM_KEYUP = 0x0101;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHAR"]/*' />
    [NativeTypeName("#define WM_CHAR 0x0102")]
    public const int WM_CHAR = 0x0102;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DEADCHAR"]/*' />
    [NativeTypeName("#define WM_DEADCHAR 0x0103")]
    public const int WM_DEADCHAR = 0x0103;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSKEYDOWN"]/*' />
    [NativeTypeName("#define WM_SYSKEYDOWN 0x0104")]
    public const int WM_SYSKEYDOWN = 0x0104;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSKEYUP"]/*' />
    [NativeTypeName("#define WM_SYSKEYUP 0x0105")]
    public const int WM_SYSKEYUP = 0x0105;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSCHAR"]/*' />
    [NativeTypeName("#define WM_SYSCHAR 0x0106")]
    public const int WM_SYSCHAR = 0x0106;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSDEADCHAR"]/*' />
    [NativeTypeName("#define WM_SYSDEADCHAR 0x0107")]
    public const int WM_SYSDEADCHAR = 0x0107;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_UNICHAR"]/*' />
    [NativeTypeName("#define WM_UNICHAR 0x0109")]
    public const int WM_UNICHAR = 0x0109;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_KEYLAST"]/*' />
    [NativeTypeName("#define WM_KEYLAST 0x0109")]
    public const int WM_KEYLAST = 0x0109;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_STARTCOMPOSITION"]/*' />
    [NativeTypeName("#define WM_IME_STARTCOMPOSITION 0x010D")]
    public const int WM_IME_STARTCOMPOSITION = 0x010D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_ENDCOMPOSITION"]/*' />
    [NativeTypeName("#define WM_IME_ENDCOMPOSITION 0x010E")]
    public const int WM_IME_ENDCOMPOSITION = 0x010E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_COMPOSITION"]/*' />
    [NativeTypeName("#define WM_IME_COMPOSITION 0x010F")]
    public const int WM_IME_COMPOSITION = 0x010F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_KEYLAST"]/*' />
    [NativeTypeName("#define WM_IME_KEYLAST 0x010F")]
    public const int WM_IME_KEYLAST = 0x010F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INITDIALOG"]/*' />
    [NativeTypeName("#define WM_INITDIALOG 0x0110")]
    public const int WM_INITDIALOG = 0x0110;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COMMAND"]/*' />
    [NativeTypeName("#define WM_COMMAND 0x0111")]
    public const int WM_COMMAND = 0x0111;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SYSCOMMAND"]/*' />
    [NativeTypeName("#define WM_SYSCOMMAND 0x0112")]
    public const int WM_SYSCOMMAND = 0x0112;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TIMER"]/*' />
    [NativeTypeName("#define WM_TIMER 0x0113")]
    public const int WM_TIMER = 0x0113;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HSCROLL"]/*' />
    [NativeTypeName("#define WM_HSCROLL 0x0114")]
    public const int WM_HSCROLL = 0x0114;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_VSCROLL"]/*' />
    [NativeTypeName("#define WM_VSCROLL 0x0115")]
    public const int WM_VSCROLL = 0x0115;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INITMENU"]/*' />
    [NativeTypeName("#define WM_INITMENU 0x0116")]
    public const int WM_INITMENU = 0x0116;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INITMENUPOPUP"]/*' />
    [NativeTypeName("#define WM_INITMENUPOPUP 0x0117")]
    public const int WM_INITMENUPOPUP = 0x0117;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GESTURE"]/*' />
    [NativeTypeName("#define WM_GESTURE 0x0119")]
    public const int WM_GESTURE = 0x0119;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GESTURENOTIFY"]/*' />
    [NativeTypeName("#define WM_GESTURENOTIFY 0x011A")]
    public const int WM_GESTURENOTIFY = 0x011A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENUSELECT"]/*' />
    [NativeTypeName("#define WM_MENUSELECT 0x011F")]
    public const int WM_MENUSELECT = 0x011F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENUCHAR"]/*' />
    [NativeTypeName("#define WM_MENUCHAR 0x0120")]
    public const int WM_MENUCHAR = 0x0120;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENTERIDLE"]/*' />
    [NativeTypeName("#define WM_ENTERIDLE 0x0121")]
    public const int WM_ENTERIDLE = 0x0121;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENURBUTTONUP"]/*' />
    [NativeTypeName("#define WM_MENURBUTTONUP 0x0122")]
    public const int WM_MENURBUTTONUP = 0x0122;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENUDRAG"]/*' />
    [NativeTypeName("#define WM_MENUDRAG 0x0123")]
    public const int WM_MENUDRAG = 0x0123;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENUGETOBJECT"]/*' />
    [NativeTypeName("#define WM_MENUGETOBJECT 0x0124")]
    public const int WM_MENUGETOBJECT = 0x0124;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_UNINITMENUPOPUP"]/*' />
    [NativeTypeName("#define WM_UNINITMENUPOPUP 0x0125")]
    public const int WM_UNINITMENUPOPUP = 0x0125;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MENUCOMMAND"]/*' />
    [NativeTypeName("#define WM_MENUCOMMAND 0x0126")]
    public const int WM_MENUCOMMAND = 0x0126;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHANGEUISTATE"]/*' />
    [NativeTypeName("#define WM_CHANGEUISTATE 0x0127")]
    public const int WM_CHANGEUISTATE = 0x0127;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_UPDATEUISTATE"]/*' />
    [NativeTypeName("#define WM_UPDATEUISTATE 0x0128")]
    public const int WM_UPDATEUISTATE = 0x0128;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUERYUISTATE"]/*' />
    [NativeTypeName("#define WM_QUERYUISTATE 0x0129")]
    public const int WM_QUERYUISTATE = 0x0129;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORMSGBOX"]/*' />
    [NativeTypeName("#define WM_CTLCOLORMSGBOX 0x0132")]
    public const int WM_CTLCOLORMSGBOX = 0x0132;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLOREDIT"]/*' />
    [NativeTypeName("#define WM_CTLCOLOREDIT 0x0133")]
    public const int WM_CTLCOLOREDIT = 0x0133;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORLISTBOX"]/*' />
    [NativeTypeName("#define WM_CTLCOLORLISTBOX 0x0134")]
    public const int WM_CTLCOLORLISTBOX = 0x0134;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORBTN"]/*' />
    [NativeTypeName("#define WM_CTLCOLORBTN 0x0135")]
    public const int WM_CTLCOLORBTN = 0x0135;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORDLG"]/*' />
    [NativeTypeName("#define WM_CTLCOLORDLG 0x0136")]
    public const int WM_CTLCOLORDLG = 0x0136;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORSCROLLBAR"]/*' />
    [NativeTypeName("#define WM_CTLCOLORSCROLLBAR 0x0137")]
    public const int WM_CTLCOLORSCROLLBAR = 0x0137;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CTLCOLORSTATIC"]/*' />
    [NativeTypeName("#define WM_CTLCOLORSTATIC 0x0138")]
    public const int WM_CTLCOLORSTATIC = 0x0138;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEFIRST"]/*' />
    [NativeTypeName("#define WM_MOUSEFIRST 0x0200")]
    public const int WM_MOUSEFIRST = 0x0200;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEMOVE"]/*' />
    [NativeTypeName("#define WM_MOUSEMOVE 0x0200")]
    public const int WM_MOUSEMOVE = 0x0200;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_LBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_LBUTTONDOWN 0x0201")]
    public const int WM_LBUTTONDOWN = 0x0201;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_LBUTTONUP"]/*' />
    [NativeTypeName("#define WM_LBUTTONUP 0x0202")]
    public const int WM_LBUTTONUP = 0x0202;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_LBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_LBUTTONDBLCLK 0x0203")]
    public const int WM_LBUTTONDBLCLK = 0x0203;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_RBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_RBUTTONDOWN 0x0204")]
    public const int WM_RBUTTONDOWN = 0x0204;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_RBUTTONUP"]/*' />
    [NativeTypeName("#define WM_RBUTTONUP 0x0205")]
    public const int WM_RBUTTONUP = 0x0205;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_RBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_RBUTTONDBLCLK 0x0206")]
    public const int WM_RBUTTONDBLCLK = 0x0206;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_MBUTTONDOWN 0x0207")]
    public const int WM_MBUTTONDOWN = 0x0207;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MBUTTONUP"]/*' />
    [NativeTypeName("#define WM_MBUTTONUP 0x0208")]
    public const int WM_MBUTTONUP = 0x0208;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_MBUTTONDBLCLK 0x0209")]
    public const int WM_MBUTTONDBLCLK = 0x0209;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEWHEEL"]/*' />
    [NativeTypeName("#define WM_MOUSEWHEEL 0x020A")]
    public const int WM_MOUSEWHEEL = 0x020A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_XBUTTONDOWN"]/*' />
    [NativeTypeName("#define WM_XBUTTONDOWN 0x020B")]
    public const int WM_XBUTTONDOWN = 0x020B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_XBUTTONUP"]/*' />
    [NativeTypeName("#define WM_XBUTTONUP 0x020C")]
    public const int WM_XBUTTONUP = 0x020C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_XBUTTONDBLCLK"]/*' />
    [NativeTypeName("#define WM_XBUTTONDBLCLK 0x020D")]
    public const int WM_XBUTTONDBLCLK = 0x020D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEHWHEEL"]/*' />
    [NativeTypeName("#define WM_MOUSEHWHEEL 0x020E")]
    public const int WM_MOUSEHWHEEL = 0x020E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSELAST"]/*' />
    [NativeTypeName("#define WM_MOUSELAST 0x020E")]
    public const int WM_MOUSELAST = 0x020E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PARENTNOTIFY"]/*' />
    [NativeTypeName("#define WM_PARENTNOTIFY 0x0210")]
    public const int WM_PARENTNOTIFY = 0x0210;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENTERMENULOOP"]/*' />
    [NativeTypeName("#define WM_ENTERMENULOOP 0x0211")]
    public const int WM_ENTERMENULOOP = 0x0211;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_EXITMENULOOP"]/*' />
    [NativeTypeName("#define WM_EXITMENULOOP 0x0212")]
    public const int WM_EXITMENULOOP = 0x0212;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NEXTMENU"]/*' />
    [NativeTypeName("#define WM_NEXTMENU 0x0213")]
    public const int WM_NEXTMENU = 0x0213;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SIZING"]/*' />
    [NativeTypeName("#define WM_SIZING 0x0214")]
    public const int WM_SIZING = 0x0214;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CAPTURECHANGED"]/*' />
    [NativeTypeName("#define WM_CAPTURECHANGED 0x0215")]
    public const int WM_CAPTURECHANGED = 0x0215;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOVING"]/*' />
    [NativeTypeName("#define WM_MOVING 0x0216")]
    public const int WM_MOVING = 0x0216;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POWERBROADCAST"]/*' />
    [NativeTypeName("#define WM_POWERBROADCAST 0x0218")]
    public const int WM_POWERBROADCAST = 0x0218;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DEVICECHANGE"]/*' />
    [NativeTypeName("#define WM_DEVICECHANGE 0x0219")]
    public const int WM_DEVICECHANGE = 0x0219;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDICREATE"]/*' />
    [NativeTypeName("#define WM_MDICREATE 0x0220")]
    public const int WM_MDICREATE = 0x0220;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIDESTROY"]/*' />
    [NativeTypeName("#define WM_MDIDESTROY 0x0221")]
    public const int WM_MDIDESTROY = 0x0221;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIACTIVATE"]/*' />
    [NativeTypeName("#define WM_MDIACTIVATE 0x0222")]
    public const int WM_MDIACTIVATE = 0x0222;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIRESTORE"]/*' />
    [NativeTypeName("#define WM_MDIRESTORE 0x0223")]
    public const int WM_MDIRESTORE = 0x0223;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDINEXT"]/*' />
    [NativeTypeName("#define WM_MDINEXT 0x0224")]
    public const int WM_MDINEXT = 0x0224;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIMAXIMIZE"]/*' />
    [NativeTypeName("#define WM_MDIMAXIMIZE 0x0225")]
    public const int WM_MDIMAXIMIZE = 0x0225;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDITILE"]/*' />
    [NativeTypeName("#define WM_MDITILE 0x0226")]
    public const int WM_MDITILE = 0x0226;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDICASCADE"]/*' />
    [NativeTypeName("#define WM_MDICASCADE 0x0227")]
    public const int WM_MDICASCADE = 0x0227;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIICONARRANGE"]/*' />
    [NativeTypeName("#define WM_MDIICONARRANGE 0x0228")]
    public const int WM_MDIICONARRANGE = 0x0228;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIGETACTIVE"]/*' />
    [NativeTypeName("#define WM_MDIGETACTIVE 0x0229")]
    public const int WM_MDIGETACTIVE = 0x0229;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDISETMENU"]/*' />
    [NativeTypeName("#define WM_MDISETMENU 0x0230")]
    public const int WM_MDISETMENU = 0x0230;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENTERSIZEMOVE"]/*' />
    [NativeTypeName("#define WM_ENTERSIZEMOVE 0x0231")]
    public const int WM_ENTERSIZEMOVE = 0x0231;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_EXITSIZEMOVE"]/*' />
    [NativeTypeName("#define WM_EXITSIZEMOVE 0x0232")]
    public const int WM_EXITSIZEMOVE = 0x0232;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DROPFILES"]/*' />
    [NativeTypeName("#define WM_DROPFILES 0x0233")]
    public const int WM_DROPFILES = 0x0233;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MDIREFRESHMENU"]/*' />
    [NativeTypeName("#define WM_MDIREFRESHMENU 0x0234")]
    public const int WM_MDIREFRESHMENU = 0x0234;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERDEVICECHANGE"]/*' />
    [NativeTypeName("#define WM_POINTERDEVICECHANGE 0x238")]
    public const int WM_POINTERDEVICECHANGE = 0x238;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERDEVICEINRANGE"]/*' />
    [NativeTypeName("#define WM_POINTERDEVICEINRANGE 0x239")]
    public const int WM_POINTERDEVICEINRANGE = 0x239;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERDEVICEOUTOFRANGE"]/*' />
    [NativeTypeName("#define WM_POINTERDEVICEOUTOFRANGE 0x23A")]
    public const int WM_POINTERDEVICEOUTOFRANGE = 0x23A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_STOPINERTIA"]/*' />
    [NativeTypeName("#define WM_STOPINERTIA 0x023B")]
    public const int WM_STOPINERTIA = 0x023B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ENDINERTIA"]/*' />
    [NativeTypeName("#define WM_ENDINERTIA 0x023C")]
    public const int WM_ENDINERTIA = 0x023C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TOUCH"]/*' />
    [NativeTypeName("#define WM_TOUCH 0x0240")]
    public const int WM_TOUCH = 0x0240;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCPOINTERUPDATE"]/*' />
    [NativeTypeName("#define WM_NCPOINTERUPDATE 0x0241")]
    public const int WM_NCPOINTERUPDATE = 0x0241;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCPOINTERDOWN"]/*' />
    [NativeTypeName("#define WM_NCPOINTERDOWN 0x0242")]
    public const int WM_NCPOINTERDOWN = 0x0242;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCPOINTERUP"]/*' />
    [NativeTypeName("#define WM_NCPOINTERUP 0x0243")]
    public const int WM_NCPOINTERUP = 0x0243;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERUPDATE"]/*' />
    [NativeTypeName("#define WM_POINTERUPDATE 0x0245")]
    public const int WM_POINTERUPDATE = 0x0245;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERDOWN"]/*' />
    [NativeTypeName("#define WM_POINTERDOWN 0x0246")]
    public const int WM_POINTERDOWN = 0x0246;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERUP"]/*' />
    [NativeTypeName("#define WM_POINTERUP 0x0247")]
    public const int WM_POINTERUP = 0x0247;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERENTER"]/*' />
    [NativeTypeName("#define WM_POINTERENTER 0x0249")]
    public const int WM_POINTERENTER = 0x0249;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERLEAVE"]/*' />
    [NativeTypeName("#define WM_POINTERLEAVE 0x024A")]
    public const int WM_POINTERLEAVE = 0x024A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERACTIVATE"]/*' />
    [NativeTypeName("#define WM_POINTERACTIVATE 0x024B")]
    public const int WM_POINTERACTIVATE = 0x024B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERCAPTURECHANGED"]/*' />
    [NativeTypeName("#define WM_POINTERCAPTURECHANGED 0x024C")]
    public const int WM_POINTERCAPTURECHANGED = 0x024C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TOUCHHITTESTING"]/*' />
    [NativeTypeName("#define WM_TOUCHHITTESTING 0x024D")]
    public const int WM_TOUCHHITTESTING = 0x024D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERWHEEL"]/*' />
    [NativeTypeName("#define WM_POINTERWHEEL 0x024E")]
    public const int WM_POINTERWHEEL = 0x024E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERHWHEEL"]/*' />
    [NativeTypeName("#define WM_POINTERHWHEEL 0x024F")]
    public const int WM_POINTERHWHEEL = 0x024F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERROUTEDTO"]/*' />
    [NativeTypeName("#define WM_POINTERROUTEDTO 0x0251")]
    public const int WM_POINTERROUTEDTO = 0x0251;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERROUTEDAWAY"]/*' />
    [NativeTypeName("#define WM_POINTERROUTEDAWAY 0x0252")]
    public const int WM_POINTERROUTEDAWAY = 0x0252;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_POINTERROUTEDRELEASED"]/*' />
    [NativeTypeName("#define WM_POINTERROUTEDRELEASED 0x0253")]
    public const int WM_POINTERROUTEDRELEASED = 0x0253;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_SETCONTEXT"]/*' />
    [NativeTypeName("#define WM_IME_SETCONTEXT 0x0281")]
    public const int WM_IME_SETCONTEXT = 0x0281;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_NOTIFY"]/*' />
    [NativeTypeName("#define WM_IME_NOTIFY 0x0282")]
    public const int WM_IME_NOTIFY = 0x0282;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_CONTROL"]/*' />
    [NativeTypeName("#define WM_IME_CONTROL 0x0283")]
    public const int WM_IME_CONTROL = 0x0283;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_COMPOSITIONFULL"]/*' />
    [NativeTypeName("#define WM_IME_COMPOSITIONFULL 0x0284")]
    public const int WM_IME_COMPOSITIONFULL = 0x0284;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_SELECT"]/*' />
    [NativeTypeName("#define WM_IME_SELECT 0x0285")]
    public const int WM_IME_SELECT = 0x0285;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_CHAR"]/*' />
    [NativeTypeName("#define WM_IME_CHAR 0x0286")]
    public const int WM_IME_CHAR = 0x0286;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_REQUEST"]/*' />
    [NativeTypeName("#define WM_IME_REQUEST 0x0288")]
    public const int WM_IME_REQUEST = 0x0288;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_KEYDOWN"]/*' />
    [NativeTypeName("#define WM_IME_KEYDOWN 0x0290")]
    public const int WM_IME_KEYDOWN = 0x0290;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_IME_KEYUP"]/*' />
    [NativeTypeName("#define WM_IME_KEYUP 0x0291")]
    public const int WM_IME_KEYUP = 0x0291;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSEHOVER"]/*' />
    [NativeTypeName("#define WM_MOUSEHOVER 0x02A1")]
    public const int WM_MOUSEHOVER = 0x02A1;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_MOUSELEAVE"]/*' />
    [NativeTypeName("#define WM_MOUSELEAVE 0x02A3")]
    public const int WM_MOUSELEAVE = 0x02A3;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMOUSEHOVER"]/*' />
    [NativeTypeName("#define WM_NCMOUSEHOVER 0x02A0")]
    public const int WM_NCMOUSEHOVER = 0x02A0;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_NCMOUSELEAVE"]/*' />
    [NativeTypeName("#define WM_NCMOUSELEAVE 0x02A2")]
    public const int WM_NCMOUSELEAVE = 0x02A2;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_WTSSESSION_CHANGE"]/*' />
    [NativeTypeName("#define WM_WTSSESSION_CHANGE 0x02B1")]
    public const int WM_WTSSESSION_CHANGE = 0x02B1;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_FIRST"]/*' />
    [NativeTypeName("#define WM_TABLET_FIRST 0x02c0")]
    public const int WM_TABLET_FIRST = 0x02c0;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_LAST"]/*' />
    [NativeTypeName("#define WM_TABLET_LAST 0x02df")]
    public const int WM_TABLET_LAST = 0x02df;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DPICHANGED"]/*' />
    [NativeTypeName("#define WM_DPICHANGED 0x02E0")]
    public const int WM_DPICHANGED = 0x02E0;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DPICHANGED_BEFOREPARENT"]/*' />
    [NativeTypeName("#define WM_DPICHANGED_BEFOREPARENT 0x02E2")]
    public const int WM_DPICHANGED_BEFOREPARENT = 0x02E2;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DPICHANGED_AFTERPARENT"]/*' />
    [NativeTypeName("#define WM_DPICHANGED_AFTERPARENT 0x02E3")]
    public const int WM_DPICHANGED_AFTERPARENT = 0x02E3;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETDPISCALEDSIZE"]/*' />
    [NativeTypeName("#define WM_GETDPISCALEDSIZE 0x02E4")]
    public const int WM_GETDPISCALEDSIZE = 0x02E4;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CUT"]/*' />
    [NativeTypeName("#define WM_CUT 0x0300")]
    public const int WM_CUT = 0x0300;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_COPY"]/*' />
    [NativeTypeName("#define WM_COPY 0x0301")]
    public const int WM_COPY = 0x0301;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PASTE"]/*' />
    [NativeTypeName("#define WM_PASTE 0x0302")]
    public const int WM_PASTE = 0x0302;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CLEAR"]/*' />
    [NativeTypeName("#define WM_CLEAR 0x0303")]
    public const int WM_CLEAR = 0x0303;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_UNDO"]/*' />
    [NativeTypeName("#define WM_UNDO 0x0304")]
    public const int WM_UNDO = 0x0304;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_RENDERFORMAT"]/*' />
    [NativeTypeName("#define WM_RENDERFORMAT 0x0305")]
    public const int WM_RENDERFORMAT = 0x0305;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_RENDERALLFORMATS"]/*' />
    [NativeTypeName("#define WM_RENDERALLFORMATS 0x0306")]
    public const int WM_RENDERALLFORMATS = 0x0306;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DESTROYCLIPBOARD"]/*' />
    [NativeTypeName("#define WM_DESTROYCLIPBOARD 0x0307")]
    public const int WM_DESTROYCLIPBOARD = 0x0307;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DRAWCLIPBOARD"]/*' />
    [NativeTypeName("#define WM_DRAWCLIPBOARD 0x0308")]
    public const int WM_DRAWCLIPBOARD = 0x0308;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PAINTCLIPBOARD"]/*' />
    [NativeTypeName("#define WM_PAINTCLIPBOARD 0x0309")]
    public const int WM_PAINTCLIPBOARD = 0x0309;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_VSCROLLCLIPBOARD"]/*' />
    [NativeTypeName("#define WM_VSCROLLCLIPBOARD 0x030A")]
    public const int WM_VSCROLLCLIPBOARD = 0x030A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_SIZECLIPBOARD"]/*' />
    [NativeTypeName("#define WM_SIZECLIPBOARD 0x030B")]
    public const int WM_SIZECLIPBOARD = 0x030B;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_ASKCBFORMATNAME"]/*' />
    [NativeTypeName("#define WM_ASKCBFORMATNAME 0x030C")]
    public const int WM_ASKCBFORMATNAME = 0x030C;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CHANGECBCHAIN"]/*' />
    [NativeTypeName("#define WM_CHANGECBCHAIN 0x030D")]
    public const int WM_CHANGECBCHAIN = 0x030D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HSCROLLCLIPBOARD"]/*' />
    [NativeTypeName("#define WM_HSCROLLCLIPBOARD 0x030E")]
    public const int WM_HSCROLLCLIPBOARD = 0x030E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_QUERYNEWPALETTE"]/*' />
    [NativeTypeName("#define WM_QUERYNEWPALETTE 0x030F")]
    public const int WM_QUERYNEWPALETTE = 0x030F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PALETTEISCHANGING"]/*' />
    [NativeTypeName("#define WM_PALETTEISCHANGING 0x0310")]
    public const int WM_PALETTEISCHANGING = 0x0310;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PALETTECHANGED"]/*' />
    [NativeTypeName("#define WM_PALETTECHANGED 0x0311")]
    public const int WM_PALETTECHANGED = 0x0311;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HOTKEY"]/*' />
    [NativeTypeName("#define WM_HOTKEY 0x0312")]
    public const int WM_HOTKEY = 0x0312;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PRINT"]/*' />
    [NativeTypeName("#define WM_PRINT 0x0317")]
    public const int WM_PRINT = 0x0317;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PRINTCLIENT"]/*' />
    [NativeTypeName("#define WM_PRINTCLIENT 0x0318")]
    public const int WM_PRINTCLIENT = 0x0318;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_APPCOMMAND"]/*' />
    [NativeTypeName("#define WM_APPCOMMAND 0x0319")]
    public const int WM_APPCOMMAND = 0x0319;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_THEMECHANGED"]/*' />
    [NativeTypeName("#define WM_THEMECHANGED 0x031A")]
    public const int WM_THEMECHANGED = 0x031A;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CLIPBOARDUPDATE"]/*' />
    [NativeTypeName("#define WM_CLIPBOARDUPDATE 0x031D")]
    public const int WM_CLIPBOARDUPDATE = 0x031D;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMCOMPOSITIONCHANGED"]/*' />
    [NativeTypeName("#define WM_DWMCOMPOSITIONCHANGED 0x031E")]
    public const int WM_DWMCOMPOSITIONCHANGED = 0x031E;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMNCRENDERINGCHANGED"]/*' />
    [NativeTypeName("#define WM_DWMNCRENDERINGCHANGED 0x031F")]
    public const int WM_DWMNCRENDERINGCHANGED = 0x031F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMCOLORIZATIONCOLORCHANGED"]/*' />
    [NativeTypeName("#define WM_DWMCOLORIZATIONCOLORCHANGED 0x0320")]
    public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMWINDOWMAXIMIZEDCHANGE"]/*' />
    [NativeTypeName("#define WM_DWMWINDOWMAXIMIZEDCHANGE 0x0321")]
    public const int WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMSENDICONICTHUMBNAIL"]/*' />
    [NativeTypeName("#define WM_DWMSENDICONICTHUMBNAIL 0x0323")]
    public const int WM_DWMSENDICONICTHUMBNAIL = 0x0323;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_DWMSENDICONICLIVEPREVIEWBITMAP"]/*' />
    [NativeTypeName("#define WM_DWMSENDICONICLIVEPREVIEWBITMAP 0x0326")]
    public const int WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_GETTITLEBARINFOEX"]/*' />
    [NativeTypeName("#define WM_GETTITLEBARINFOEX 0x033F")]
    public const int WM_GETTITLEBARINFOEX = 0x033F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HANDHELDFIRST"]/*' />
    [NativeTypeName("#define WM_HANDHELDFIRST 0x0358")]
    public const int WM_HANDHELDFIRST = 0x0358;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_HANDHELDLAST"]/*' />
    [NativeTypeName("#define WM_HANDHELDLAST 0x035F")]
    public const int WM_HANDHELDLAST = 0x035F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_AFXFIRST"]/*' />
    [NativeTypeName("#define WM_AFXFIRST 0x0360")]
    public const int WM_AFXFIRST = 0x0360;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_AFXLAST"]/*' />
    [NativeTypeName("#define WM_AFXLAST 0x037F")]
    public const int WM_AFXLAST = 0x037F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PENWINFIRST"]/*' />
    [NativeTypeName("#define WM_PENWINFIRST 0x0380")]
    public const int WM_PENWINFIRST = 0x0380;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_PENWINLAST"]/*' />
    [NativeTypeName("#define WM_PENWINLAST 0x038F")]
    public const int WM_PENWINLAST = 0x038F;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_APP"]/*' />
    [NativeTypeName("#define WM_APP 0x8000")]
    public const int WM_APP = 0x8000;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_USER"]/*' />
    [NativeTypeName("#define WM_USER 0x0400")]
    public const int WM_USER = 0x0400;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_INTERCEPTED_WINDOW_ACTION"]/*' />
    [NativeTypeName("#define WM_INTERCEPTED_WINDOW_ACTION 0x0346")]
    public const int WM_INTERCEPTED_WINDOW_ACTION = 0x0346;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TOOLTIPDISMISS"]/*' />
    [NativeTypeName("#define WM_TOOLTIPDISMISS 0x0345")]
    public const int WM_TOOLTIPDISMISS = 0x0345;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_CLOAKED_STATE_CHANGED"]/*' />
    [NativeTypeName("#define WM_CLOAKED_STATE_CHANGED 0x0347")]
    public const int WM_CLOAKED_STATE_CHANGED = 0x0347;
}
