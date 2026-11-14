// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SM
{
    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXSCREEN"]/*' />
    [NativeTypeName("#define SM_CXSCREEN 0")]
    public const int SM_CXSCREEN = 0;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSCREEN"]/*' />
    [NativeTypeName("#define SM_CYSCREEN 1")]
    public const int SM_CYSCREEN = 1;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXVSCROLL"]/*' />
    [NativeTypeName("#define SM_CXVSCROLL 2")]
    public const int SM_CXVSCROLL = 2;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYHSCROLL"]/*' />
    [NativeTypeName("#define SM_CYHSCROLL 3")]
    public const int SM_CYHSCROLL = 3;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYCAPTION"]/*' />
    [NativeTypeName("#define SM_CYCAPTION 4")]
    public const int SM_CYCAPTION = 4;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXBORDER"]/*' />
    [NativeTypeName("#define SM_CXBORDER 5")]
    public const int SM_CXBORDER = 5;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYBORDER"]/*' />
    [NativeTypeName("#define SM_CYBORDER 6")]
    public const int SM_CYBORDER = 6;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXDLGFRAME"]/*' />
    [NativeTypeName("#define SM_CXDLGFRAME 7")]
    public const int SM_CXDLGFRAME = 7;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYDLGFRAME"]/*' />
    [NativeTypeName("#define SM_CYDLGFRAME 8")]
    public const int SM_CYDLGFRAME = 8;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYVTHUMB"]/*' />
    [NativeTypeName("#define SM_CYVTHUMB 9")]
    public const int SM_CYVTHUMB = 9;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXHTHUMB"]/*' />
    [NativeTypeName("#define SM_CXHTHUMB 10")]
    public const int SM_CXHTHUMB = 10;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXICON"]/*' />
    [NativeTypeName("#define SM_CXICON 11")]
    public const int SM_CXICON = 11;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYICON"]/*' />
    [NativeTypeName("#define SM_CYICON 12")]
    public const int SM_CYICON = 12;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXCURSOR"]/*' />
    [NativeTypeName("#define SM_CXCURSOR 13")]
    public const int SM_CXCURSOR = 13;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYCURSOR"]/*' />
    [NativeTypeName("#define SM_CYCURSOR 14")]
    public const int SM_CYCURSOR = 14;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMENU"]/*' />
    [NativeTypeName("#define SM_CYMENU 15")]
    public const int SM_CYMENU = 15;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXFULLSCREEN"]/*' />
    [NativeTypeName("#define SM_CXFULLSCREEN 16")]
    public const int SM_CXFULLSCREEN = 16;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYFULLSCREEN"]/*' />
    [NativeTypeName("#define SM_CYFULLSCREEN 17")]
    public const int SM_CYFULLSCREEN = 17;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYKANJIWINDOW"]/*' />
    [NativeTypeName("#define SM_CYKANJIWINDOW 18")]
    public const int SM_CYKANJIWINDOW = 18;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MOUSEPRESENT"]/*' />
    [NativeTypeName("#define SM_MOUSEPRESENT 19")]
    public const int SM_MOUSEPRESENT = 19;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYVSCROLL"]/*' />
    [NativeTypeName("#define SM_CYVSCROLL 20")]
    public const int SM_CYVSCROLL = 20;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXHSCROLL"]/*' />
    [NativeTypeName("#define SM_CXHSCROLL 21")]
    public const int SM_CXHSCROLL = 21;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_DEBUG"]/*' />
    [NativeTypeName("#define SM_DEBUG 22")]
    public const int SM_DEBUG = 22;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SWAPBUTTON"]/*' />
    [NativeTypeName("#define SM_SWAPBUTTON 23")]
    public const int SM_SWAPBUTTON = 23;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_RESERVED1"]/*' />
    [NativeTypeName("#define SM_RESERVED1 24")]
    public const int SM_RESERVED1 = 24;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_RESERVED2"]/*' />
    [NativeTypeName("#define SM_RESERVED2 25")]
    public const int SM_RESERVED2 = 25;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_RESERVED3"]/*' />
    [NativeTypeName("#define SM_RESERVED3 26")]
    public const int SM_RESERVED3 = 26;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_RESERVED4"]/*' />
    [NativeTypeName("#define SM_RESERVED4 27")]
    public const int SM_RESERVED4 = 27;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMIN"]/*' />
    [NativeTypeName("#define SM_CXMIN 28")]
    public const int SM_CXMIN = 28;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMIN"]/*' />
    [NativeTypeName("#define SM_CYMIN 29")]
    public const int SM_CYMIN = 29;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXSIZE"]/*' />
    [NativeTypeName("#define SM_CXSIZE 30")]
    public const int SM_CXSIZE = 30;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSIZE"]/*' />
    [NativeTypeName("#define SM_CYSIZE 31")]
    public const int SM_CYSIZE = 31;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXFRAME"]/*' />
    [NativeTypeName("#define SM_CXFRAME 32")]
    public const int SM_CXFRAME = 32;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYFRAME"]/*' />
    [NativeTypeName("#define SM_CYFRAME 33")]
    public const int SM_CYFRAME = 33;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMINTRACK"]/*' />
    [NativeTypeName("#define SM_CXMINTRACK 34")]
    public const int SM_CXMINTRACK = 34;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMINTRACK"]/*' />
    [NativeTypeName("#define SM_CYMINTRACK 35")]
    public const int SM_CYMINTRACK = 35;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXDOUBLECLK"]/*' />
    [NativeTypeName("#define SM_CXDOUBLECLK 36")]
    public const int SM_CXDOUBLECLK = 36;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYDOUBLECLK"]/*' />
    [NativeTypeName("#define SM_CYDOUBLECLK 37")]
    public const int SM_CYDOUBLECLK = 37;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXICONSPACING"]/*' />
    [NativeTypeName("#define SM_CXICONSPACING 38")]
    public const int SM_CXICONSPACING = 38;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYICONSPACING"]/*' />
    [NativeTypeName("#define SM_CYICONSPACING 39")]
    public const int SM_CYICONSPACING = 39;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MENUDROPALIGNMENT"]/*' />
    [NativeTypeName("#define SM_MENUDROPALIGNMENT 40")]
    public const int SM_MENUDROPALIGNMENT = 40;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_PENWINDOWS"]/*' />
    [NativeTypeName("#define SM_PENWINDOWS 41")]
    public const int SM_PENWINDOWS = 41;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_DBCSENABLED"]/*' />
    [NativeTypeName("#define SM_DBCSENABLED 42")]
    public const int SM_DBCSENABLED = 42;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CMOUSEBUTTONS"]/*' />
    [NativeTypeName("#define SM_CMOUSEBUTTONS 43")]
    public const int SM_CMOUSEBUTTONS = 43;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXFIXEDFRAME"]/*' />
    [NativeTypeName("#define SM_CXFIXEDFRAME SM_CXDLGFRAME")]
    public const int SM_CXFIXEDFRAME = 7;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYFIXEDFRAME"]/*' />
    [NativeTypeName("#define SM_CYFIXEDFRAME SM_CYDLGFRAME")]
    public const int SM_CYFIXEDFRAME = 8;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXSIZEFRAME"]/*' />
    [NativeTypeName("#define SM_CXSIZEFRAME SM_CXFRAME")]
    public const int SM_CXSIZEFRAME = 32;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSIZEFRAME"]/*' />
    [NativeTypeName("#define SM_CYSIZEFRAME SM_CYFRAME")]
    public const int SM_CYSIZEFRAME = 33;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SECURE"]/*' />
    [NativeTypeName("#define SM_SECURE 44")]
    public const int SM_SECURE = 44;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXEDGE"]/*' />
    [NativeTypeName("#define SM_CXEDGE 45")]
    public const int SM_CXEDGE = 45;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYEDGE"]/*' />
    [NativeTypeName("#define SM_CYEDGE 46")]
    public const int SM_CYEDGE = 46;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMINSPACING"]/*' />
    [NativeTypeName("#define SM_CXMINSPACING 47")]
    public const int SM_CXMINSPACING = 47;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMINSPACING"]/*' />
    [NativeTypeName("#define SM_CYMINSPACING 48")]
    public const int SM_CYMINSPACING = 48;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXSMICON"]/*' />
    [NativeTypeName("#define SM_CXSMICON 49")]
    public const int SM_CXSMICON = 49;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSMICON"]/*' />
    [NativeTypeName("#define SM_CYSMICON 50")]
    public const int SM_CYSMICON = 50;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSMCAPTION"]/*' />
    [NativeTypeName("#define SM_CYSMCAPTION 51")]
    public const int SM_CYSMCAPTION = 51;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXSMSIZE"]/*' />
    [NativeTypeName("#define SM_CXSMSIZE 52")]
    public const int SM_CXSMSIZE = 52;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYSMSIZE"]/*' />
    [NativeTypeName("#define SM_CYSMSIZE 53")]
    public const int SM_CYSMSIZE = 53;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMENUSIZE"]/*' />
    [NativeTypeName("#define SM_CXMENUSIZE 54")]
    public const int SM_CXMENUSIZE = 54;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMENUSIZE"]/*' />
    [NativeTypeName("#define SM_CYMENUSIZE 55")]
    public const int SM_CYMENUSIZE = 55;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_ARRANGE"]/*' />
    [NativeTypeName("#define SM_ARRANGE 56")]
    public const int SM_ARRANGE = 56;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMINIMIZED"]/*' />
    [NativeTypeName("#define SM_CXMINIMIZED 57")]
    public const int SM_CXMINIMIZED = 57;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMINIMIZED"]/*' />
    [NativeTypeName("#define SM_CYMINIMIZED 58")]
    public const int SM_CYMINIMIZED = 58;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMAXTRACK"]/*' />
    [NativeTypeName("#define SM_CXMAXTRACK 59")]
    public const int SM_CXMAXTRACK = 59;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMAXTRACK"]/*' />
    [NativeTypeName("#define SM_CYMAXTRACK 60")]
    public const int SM_CYMAXTRACK = 60;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMAXIMIZED"]/*' />
    [NativeTypeName("#define SM_CXMAXIMIZED 61")]
    public const int SM_CXMAXIMIZED = 61;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMAXIMIZED"]/*' />
    [NativeTypeName("#define SM_CYMAXIMIZED 62")]
    public const int SM_CYMAXIMIZED = 62;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_NETWORK"]/*' />
    [NativeTypeName("#define SM_NETWORK 63")]
    public const int SM_NETWORK = 63;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CLEANBOOT"]/*' />
    [NativeTypeName("#define SM_CLEANBOOT 67")]
    public const int SM_CLEANBOOT = 67;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXDRAG"]/*' />
    [NativeTypeName("#define SM_CXDRAG 68")]
    public const int SM_CXDRAG = 68;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYDRAG"]/*' />
    [NativeTypeName("#define SM_CYDRAG 69")]
    public const int SM_CYDRAG = 69;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SHOWSOUNDS"]/*' />
    [NativeTypeName("#define SM_SHOWSOUNDS 70")]
    public const int SM_SHOWSOUNDS = 70;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXMENUCHECK"]/*' />
    [NativeTypeName("#define SM_CXMENUCHECK 71")]
    public const int SM_CXMENUCHECK = 71;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYMENUCHECK"]/*' />
    [NativeTypeName("#define SM_CYMENUCHECK 72")]
    public const int SM_CYMENUCHECK = 72;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SLOWMACHINE"]/*' />
    [NativeTypeName("#define SM_SLOWMACHINE 73")]
    public const int SM_SLOWMACHINE = 73;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MIDEASTENABLED"]/*' />
    [NativeTypeName("#define SM_MIDEASTENABLED 74")]
    public const int SM_MIDEASTENABLED = 74;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MOUSEWHEELPRESENT"]/*' />
    [NativeTypeName("#define SM_MOUSEWHEELPRESENT 75")]
    public const int SM_MOUSEWHEELPRESENT = 75;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_XVIRTUALSCREEN"]/*' />
    [NativeTypeName("#define SM_XVIRTUALSCREEN 76")]
    public const int SM_XVIRTUALSCREEN = 76;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_YVIRTUALSCREEN"]/*' />
    [NativeTypeName("#define SM_YVIRTUALSCREEN 77")]
    public const int SM_YVIRTUALSCREEN = 77;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXVIRTUALSCREEN"]/*' />
    [NativeTypeName("#define SM_CXVIRTUALSCREEN 78")]
    public const int SM_CXVIRTUALSCREEN = 78;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYVIRTUALSCREEN"]/*' />
    [NativeTypeName("#define SM_CYVIRTUALSCREEN 79")]
    public const int SM_CYVIRTUALSCREEN = 79;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CMONITORS"]/*' />
    [NativeTypeName("#define SM_CMONITORS 80")]
    public const int SM_CMONITORS = 80;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SAMEDISPLAYFORMAT"]/*' />
    [NativeTypeName("#define SM_SAMEDISPLAYFORMAT 81")]
    public const int SM_SAMEDISPLAYFORMAT = 81;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_IMMENABLED"]/*' />
    [NativeTypeName("#define SM_IMMENABLED 82")]
    public const int SM_IMMENABLED = 82;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXFOCUSBORDER"]/*' />
    [NativeTypeName("#define SM_CXFOCUSBORDER 83")]
    public const int SM_CXFOCUSBORDER = 83;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CYFOCUSBORDER"]/*' />
    [NativeTypeName("#define SM_CYFOCUSBORDER 84")]
    public const int SM_CYFOCUSBORDER = 84;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_TABLETPC"]/*' />
    [NativeTypeName("#define SM_TABLETPC 86")]
    public const int SM_TABLETPC = 86;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MEDIACENTER"]/*' />
    [NativeTypeName("#define SM_MEDIACENTER 87")]
    public const int SM_MEDIACENTER = 87;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_STARTER"]/*' />
    [NativeTypeName("#define SM_STARTER 88")]
    public const int SM_STARTER = 88;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SERVERR2"]/*' />
    [NativeTypeName("#define SM_SERVERR2 89")]
    public const int SM_SERVERR2 = 89;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MOUSEHORIZONTALWHEELPRESENT"]/*' />
    [NativeTypeName("#define SM_MOUSEHORIZONTALWHEELPRESENT 91")]
    public const int SM_MOUSEHORIZONTALWHEELPRESENT = 91;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CXPADDEDBORDER"]/*' />
    [NativeTypeName("#define SM_CXPADDEDBORDER 92")]
    public const int SM_CXPADDEDBORDER = 92;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_DIGITIZER"]/*' />
    [NativeTypeName("#define SM_DIGITIZER 94")]
    public const int SM_DIGITIZER = 94;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_MAXIMUMTOUCHES"]/*' />
    [NativeTypeName("#define SM_MAXIMUMTOUCHES 95")]
    public const int SM_MAXIMUMTOUCHES = 95;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CMETRICS"]/*' />
    [NativeTypeName("#define SM_CMETRICS 97")]
    public const int SM_CMETRICS = 97;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_REMOTESESSION"]/*' />
    [NativeTypeName("#define SM_REMOTESESSION 0x1000")]
    public const int SM_REMOTESESSION = 0x1000;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SHUTTINGDOWN"]/*' />
    [NativeTypeName("#define SM_SHUTTINGDOWN 0x2000")]
    public const int SM_SHUTTINGDOWN = 0x2000;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_REMOTECONTROL"]/*' />
    [NativeTypeName("#define SM_REMOTECONTROL 0x2001")]
    public const int SM_REMOTECONTROL = 0x2001;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CARETBLINKINGENABLED"]/*' />
    [NativeTypeName("#define SM_CARETBLINKINGENABLED 0x2002")]
    public const int SM_CARETBLINKINGENABLED = 0x2002;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_CONVERTIBLESLATEMODE"]/*' />
    [NativeTypeName("#define SM_CONVERTIBLESLATEMODE 0x2003")]
    public const int SM_CONVERTIBLESLATEMODE = 0x2003;

    /// <include file='SM.xml' path='doc/member[@name="SM.SM_SYSTEMDOCKED"]/*' />
    [NativeTypeName("#define SM_SYSTEMDOCKED 0x2004")]
    public const int SM_SYSTEMDOCKED = 0x2004;
}
