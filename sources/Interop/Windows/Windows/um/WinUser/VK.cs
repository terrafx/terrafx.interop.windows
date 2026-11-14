// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VK
{
    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LBUTTON"]/*' />
    [NativeTypeName("#define VK_LBUTTON 0x01")]
    public const int VK_LBUTTON = 0x01;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RBUTTON"]/*' />
    [NativeTypeName("#define VK_RBUTTON 0x02")]
    public const int VK_RBUTTON = 0x02;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CANCEL"]/*' />
    [NativeTypeName("#define VK_CANCEL 0x03")]
    public const int VK_CANCEL = 0x03;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MBUTTON"]/*' />
    [NativeTypeName("#define VK_MBUTTON 0x04")]
    public const int VK_MBUTTON = 0x04;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_XBUTTON1"]/*' />
    [NativeTypeName("#define VK_XBUTTON1 0x05")]
    public const int VK_XBUTTON1 = 0x05;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_XBUTTON2"]/*' />
    [NativeTypeName("#define VK_XBUTTON2 0x06")]
    public const int VK_XBUTTON2 = 0x06;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BACK"]/*' />
    [NativeTypeName("#define VK_BACK 0x08")]
    public const int VK_BACK = 0x08;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_TAB"]/*' />
    [NativeTypeName("#define VK_TAB 0x09")]
    public const int VK_TAB = 0x09;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CLEAR"]/*' />
    [NativeTypeName("#define VK_CLEAR 0x0C")]
    public const int VK_CLEAR = 0x0C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RETURN"]/*' />
    [NativeTypeName("#define VK_RETURN 0x0D")]
    public const int VK_RETURN = 0x0D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SHIFT"]/*' />
    [NativeTypeName("#define VK_SHIFT 0x10")]
    public const int VK_SHIFT = 0x10;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CONTROL"]/*' />
    [NativeTypeName("#define VK_CONTROL 0x11")]
    public const int VK_CONTROL = 0x11;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MENU"]/*' />
    [NativeTypeName("#define VK_MENU 0x12")]
    public const int VK_MENU = 0x12;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PAUSE"]/*' />
    [NativeTypeName("#define VK_PAUSE 0x13")]
    public const int VK_PAUSE = 0x13;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CAPITAL"]/*' />
    [NativeTypeName("#define VK_CAPITAL 0x14")]
    public const int VK_CAPITAL = 0x14;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_KANA"]/*' />
    [NativeTypeName("#define VK_KANA 0x15")]
    public const int VK_KANA = 0x15;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_HANGEUL"]/*' />
    [NativeTypeName("#define VK_HANGEUL 0x15")]
    public const int VK_HANGEUL = 0x15;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_HANGUL"]/*' />
    [NativeTypeName("#define VK_HANGUL 0x15")]
    public const int VK_HANGUL = 0x15;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_IME_ON"]/*' />
    [NativeTypeName("#define VK_IME_ON 0x16")]
    public const int VK_IME_ON = 0x16;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_JUNJA"]/*' />
    [NativeTypeName("#define VK_JUNJA 0x17")]
    public const int VK_JUNJA = 0x17;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_FINAL"]/*' />
    [NativeTypeName("#define VK_FINAL 0x18")]
    public const int VK_FINAL = 0x18;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_HANJA"]/*' />
    [NativeTypeName("#define VK_HANJA 0x19")]
    public const int VK_HANJA = 0x19;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_KANJI"]/*' />
    [NativeTypeName("#define VK_KANJI 0x19")]
    public const int VK_KANJI = 0x19;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_IME_OFF"]/*' />
    [NativeTypeName("#define VK_IME_OFF 0x1A")]
    public const int VK_IME_OFF = 0x1A;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ESCAPE"]/*' />
    [NativeTypeName("#define VK_ESCAPE 0x1B")]
    public const int VK_ESCAPE = 0x1B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CONVERT"]/*' />
    [NativeTypeName("#define VK_CONVERT 0x1C")]
    public const int VK_CONVERT = 0x1C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NONCONVERT"]/*' />
    [NativeTypeName("#define VK_NONCONVERT 0x1D")]
    public const int VK_NONCONVERT = 0x1D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ACCEPT"]/*' />
    [NativeTypeName("#define VK_ACCEPT 0x1E")]
    public const int VK_ACCEPT = 0x1E;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MODECHANGE"]/*' />
    [NativeTypeName("#define VK_MODECHANGE 0x1F")]
    public const int VK_MODECHANGE = 0x1F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SPACE"]/*' />
    [NativeTypeName("#define VK_SPACE 0x20")]
    public const int VK_SPACE = 0x20;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PRIOR"]/*' />
    [NativeTypeName("#define VK_PRIOR 0x21")]
    public const int VK_PRIOR = 0x21;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NEXT"]/*' />
    [NativeTypeName("#define VK_NEXT 0x22")]
    public const int VK_NEXT = 0x22;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_END"]/*' />
    [NativeTypeName("#define VK_END 0x23")]
    public const int VK_END = 0x23;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_HOME"]/*' />
    [NativeTypeName("#define VK_HOME 0x24")]
    public const int VK_HOME = 0x24;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LEFT"]/*' />
    [NativeTypeName("#define VK_LEFT 0x25")]
    public const int VK_LEFT = 0x25;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_UP"]/*' />
    [NativeTypeName("#define VK_UP 0x26")]
    public const int VK_UP = 0x26;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RIGHT"]/*' />
    [NativeTypeName("#define VK_RIGHT 0x27")]
    public const int VK_RIGHT = 0x27;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_DOWN"]/*' />
    [NativeTypeName("#define VK_DOWN 0x28")]
    public const int VK_DOWN = 0x28;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SELECT"]/*' />
    [NativeTypeName("#define VK_SELECT 0x29")]
    public const int VK_SELECT = 0x29;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PRINT"]/*' />
    [NativeTypeName("#define VK_PRINT 0x2A")]
    public const int VK_PRINT = 0x2A;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_EXECUTE"]/*' />
    [NativeTypeName("#define VK_EXECUTE 0x2B")]
    public const int VK_EXECUTE = 0x2B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SNAPSHOT"]/*' />
    [NativeTypeName("#define VK_SNAPSHOT 0x2C")]
    public const int VK_SNAPSHOT = 0x2C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_INSERT"]/*' />
    [NativeTypeName("#define VK_INSERT 0x2D")]
    public const int VK_INSERT = 0x2D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_DELETE"]/*' />
    [NativeTypeName("#define VK_DELETE 0x2E")]
    public const int VK_DELETE = 0x2E;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_HELP"]/*' />
    [NativeTypeName("#define VK_HELP 0x2F")]
    public const int VK_HELP = 0x2F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LWIN"]/*' />
    [NativeTypeName("#define VK_LWIN 0x5B")]
    public const int VK_LWIN = 0x5B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RWIN"]/*' />
    [NativeTypeName("#define VK_RWIN 0x5C")]
    public const int VK_RWIN = 0x5C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_APPS"]/*' />
    [NativeTypeName("#define VK_APPS 0x5D")]
    public const int VK_APPS = 0x5D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SLEEP"]/*' />
    [NativeTypeName("#define VK_SLEEP 0x5F")]
    public const int VK_SLEEP = 0x5F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD0"]/*' />
    [NativeTypeName("#define VK_NUMPAD0 0x60")]
    public const int VK_NUMPAD0 = 0x60;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD1"]/*' />
    [NativeTypeName("#define VK_NUMPAD1 0x61")]
    public const int VK_NUMPAD1 = 0x61;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD2"]/*' />
    [NativeTypeName("#define VK_NUMPAD2 0x62")]
    public const int VK_NUMPAD2 = 0x62;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD3"]/*' />
    [NativeTypeName("#define VK_NUMPAD3 0x63")]
    public const int VK_NUMPAD3 = 0x63;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD4"]/*' />
    [NativeTypeName("#define VK_NUMPAD4 0x64")]
    public const int VK_NUMPAD4 = 0x64;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD5"]/*' />
    [NativeTypeName("#define VK_NUMPAD5 0x65")]
    public const int VK_NUMPAD5 = 0x65;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD6"]/*' />
    [NativeTypeName("#define VK_NUMPAD6 0x66")]
    public const int VK_NUMPAD6 = 0x66;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD7"]/*' />
    [NativeTypeName("#define VK_NUMPAD7 0x67")]
    public const int VK_NUMPAD7 = 0x67;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD8"]/*' />
    [NativeTypeName("#define VK_NUMPAD8 0x68")]
    public const int VK_NUMPAD8 = 0x68;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMPAD9"]/*' />
    [NativeTypeName("#define VK_NUMPAD9 0x69")]
    public const int VK_NUMPAD9 = 0x69;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MULTIPLY"]/*' />
    [NativeTypeName("#define VK_MULTIPLY 0x6A")]
    public const int VK_MULTIPLY = 0x6A;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ADD"]/*' />
    [NativeTypeName("#define VK_ADD 0x6B")]
    public const int VK_ADD = 0x6B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SEPARATOR"]/*' />
    [NativeTypeName("#define VK_SEPARATOR 0x6C")]
    public const int VK_SEPARATOR = 0x6C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SUBTRACT"]/*' />
    [NativeTypeName("#define VK_SUBTRACT 0x6D")]
    public const int VK_SUBTRACT = 0x6D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_DECIMAL"]/*' />
    [NativeTypeName("#define VK_DECIMAL 0x6E")]
    public const int VK_DECIMAL = 0x6E;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_DIVIDE"]/*' />
    [NativeTypeName("#define VK_DIVIDE 0x6F")]
    public const int VK_DIVIDE = 0x6F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F1"]/*' />
    [NativeTypeName("#define VK_F1 0x70")]
    public const int VK_F1 = 0x70;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F2"]/*' />
    [NativeTypeName("#define VK_F2 0x71")]
    public const int VK_F2 = 0x71;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F3"]/*' />
    [NativeTypeName("#define VK_F3 0x72")]
    public const int VK_F3 = 0x72;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F4"]/*' />
    [NativeTypeName("#define VK_F4 0x73")]
    public const int VK_F4 = 0x73;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F5"]/*' />
    [NativeTypeName("#define VK_F5 0x74")]
    public const int VK_F5 = 0x74;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F6"]/*' />
    [NativeTypeName("#define VK_F6 0x75")]
    public const int VK_F6 = 0x75;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F7"]/*' />
    [NativeTypeName("#define VK_F7 0x76")]
    public const int VK_F7 = 0x76;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F8"]/*' />
    [NativeTypeName("#define VK_F8 0x77")]
    public const int VK_F8 = 0x77;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F9"]/*' />
    [NativeTypeName("#define VK_F9 0x78")]
    public const int VK_F9 = 0x78;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F10"]/*' />
    [NativeTypeName("#define VK_F10 0x79")]
    public const int VK_F10 = 0x79;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F11"]/*' />
    [NativeTypeName("#define VK_F11 0x7A")]
    public const int VK_F11 = 0x7A;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F12"]/*' />
    [NativeTypeName("#define VK_F12 0x7B")]
    public const int VK_F12 = 0x7B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F13"]/*' />
    [NativeTypeName("#define VK_F13 0x7C")]
    public const int VK_F13 = 0x7C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F14"]/*' />
    [NativeTypeName("#define VK_F14 0x7D")]
    public const int VK_F14 = 0x7D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F15"]/*' />
    [NativeTypeName("#define VK_F15 0x7E")]
    public const int VK_F15 = 0x7E;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F16"]/*' />
    [NativeTypeName("#define VK_F16 0x7F")]
    public const int VK_F16 = 0x7F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F17"]/*' />
    [NativeTypeName("#define VK_F17 0x80")]
    public const int VK_F17 = 0x80;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F18"]/*' />
    [NativeTypeName("#define VK_F18 0x81")]
    public const int VK_F18 = 0x81;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F19"]/*' />
    [NativeTypeName("#define VK_F19 0x82")]
    public const int VK_F19 = 0x82;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F20"]/*' />
    [NativeTypeName("#define VK_F20 0x83")]
    public const int VK_F20 = 0x83;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F21"]/*' />
    [NativeTypeName("#define VK_F21 0x84")]
    public const int VK_F21 = 0x84;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F22"]/*' />
    [NativeTypeName("#define VK_F22 0x85")]
    public const int VK_F22 = 0x85;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F23"]/*' />
    [NativeTypeName("#define VK_F23 0x86")]
    public const int VK_F23 = 0x86;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_F24"]/*' />
    [NativeTypeName("#define VK_F24 0x87")]
    public const int VK_F24 = 0x87;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_VIEW"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_VIEW 0x88")]
    public const int VK_NAVIGATION_VIEW = 0x88;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_MENU"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_MENU 0x89")]
    public const int VK_NAVIGATION_MENU = 0x89;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_UP"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_UP 0x8A")]
    public const int VK_NAVIGATION_UP = 0x8A;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_DOWN"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_DOWN 0x8B")]
    public const int VK_NAVIGATION_DOWN = 0x8B;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_LEFT"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_LEFT 0x8C")]
    public const int VK_NAVIGATION_LEFT = 0x8C;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_RIGHT"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_RIGHT 0x8D")]
    public const int VK_NAVIGATION_RIGHT = 0x8D;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_ACCEPT"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_ACCEPT 0x8E")]
    public const int VK_NAVIGATION_ACCEPT = 0x8E;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NAVIGATION_CANCEL"]/*' />
    [NativeTypeName("#define VK_NAVIGATION_CANCEL 0x8F")]
    public const int VK_NAVIGATION_CANCEL = 0x8F;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NUMLOCK"]/*' />
    [NativeTypeName("#define VK_NUMLOCK 0x90")]
    public const int VK_NUMLOCK = 0x90;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_SCROLL"]/*' />
    [NativeTypeName("#define VK_SCROLL 0x91")]
    public const int VK_SCROLL = 0x91;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_NEC_EQUAL"]/*' />
    [NativeTypeName("#define VK_OEM_NEC_EQUAL 0x92")]
    public const int VK_OEM_NEC_EQUAL = 0x92;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FJ_JISHO"]/*' />
    [NativeTypeName("#define VK_OEM_FJ_JISHO 0x92")]
    public const int VK_OEM_FJ_JISHO = 0x92;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FJ_MASSHOU"]/*' />
    [NativeTypeName("#define VK_OEM_FJ_MASSHOU 0x93")]
    public const int VK_OEM_FJ_MASSHOU = 0x93;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FJ_TOUROKU"]/*' />
    [NativeTypeName("#define VK_OEM_FJ_TOUROKU 0x94")]
    public const int VK_OEM_FJ_TOUROKU = 0x94;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FJ_LOYA"]/*' />
    [NativeTypeName("#define VK_OEM_FJ_LOYA 0x95")]
    public const int VK_OEM_FJ_LOYA = 0x95;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FJ_ROYA"]/*' />
    [NativeTypeName("#define VK_OEM_FJ_ROYA 0x96")]
    public const int VK_OEM_FJ_ROYA = 0x96;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LSHIFT"]/*' />
    [NativeTypeName("#define VK_LSHIFT 0xA0")]
    public const int VK_LSHIFT = 0xA0;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RSHIFT"]/*' />
    [NativeTypeName("#define VK_RSHIFT 0xA1")]
    public const int VK_RSHIFT = 0xA1;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LCONTROL"]/*' />
    [NativeTypeName("#define VK_LCONTROL 0xA2")]
    public const int VK_LCONTROL = 0xA2;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RCONTROL"]/*' />
    [NativeTypeName("#define VK_RCONTROL 0xA3")]
    public const int VK_RCONTROL = 0xA3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LMENU"]/*' />
    [NativeTypeName("#define VK_LMENU 0xA4")]
    public const int VK_LMENU = 0xA4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_RMENU"]/*' />
    [NativeTypeName("#define VK_RMENU 0xA5")]
    public const int VK_RMENU = 0xA5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_BACK"]/*' />
    [NativeTypeName("#define VK_BROWSER_BACK 0xA6")]
    public const int VK_BROWSER_BACK = 0xA6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_FORWARD"]/*' />
    [NativeTypeName("#define VK_BROWSER_FORWARD 0xA7")]
    public const int VK_BROWSER_FORWARD = 0xA7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_REFRESH"]/*' />
    [NativeTypeName("#define VK_BROWSER_REFRESH 0xA8")]
    public const int VK_BROWSER_REFRESH = 0xA8;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_STOP"]/*' />
    [NativeTypeName("#define VK_BROWSER_STOP 0xA9")]
    public const int VK_BROWSER_STOP = 0xA9;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_SEARCH"]/*' />
    [NativeTypeName("#define VK_BROWSER_SEARCH 0xAA")]
    public const int VK_BROWSER_SEARCH = 0xAA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_FAVORITES"]/*' />
    [NativeTypeName("#define VK_BROWSER_FAVORITES 0xAB")]
    public const int VK_BROWSER_FAVORITES = 0xAB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_BROWSER_HOME"]/*' />
    [NativeTypeName("#define VK_BROWSER_HOME 0xAC")]
    public const int VK_BROWSER_HOME = 0xAC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_VOLUME_MUTE"]/*' />
    [NativeTypeName("#define VK_VOLUME_MUTE 0xAD")]
    public const int VK_VOLUME_MUTE = 0xAD;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_VOLUME_DOWN"]/*' />
    [NativeTypeName("#define VK_VOLUME_DOWN 0xAE")]
    public const int VK_VOLUME_DOWN = 0xAE;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_VOLUME_UP"]/*' />
    [NativeTypeName("#define VK_VOLUME_UP 0xAF")]
    public const int VK_VOLUME_UP = 0xAF;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MEDIA_NEXT_TRACK"]/*' />
    [NativeTypeName("#define VK_MEDIA_NEXT_TRACK 0xB0")]
    public const int VK_MEDIA_NEXT_TRACK = 0xB0;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MEDIA_PREV_TRACK"]/*' />
    [NativeTypeName("#define VK_MEDIA_PREV_TRACK 0xB1")]
    public const int VK_MEDIA_PREV_TRACK = 0xB1;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MEDIA_STOP"]/*' />
    [NativeTypeName("#define VK_MEDIA_STOP 0xB2")]
    public const int VK_MEDIA_STOP = 0xB2;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_MEDIA_PLAY_PAUSE"]/*' />
    [NativeTypeName("#define VK_MEDIA_PLAY_PAUSE 0xB3")]
    public const int VK_MEDIA_PLAY_PAUSE = 0xB3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LAUNCH_MAIL"]/*' />
    [NativeTypeName("#define VK_LAUNCH_MAIL 0xB4")]
    public const int VK_LAUNCH_MAIL = 0xB4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LAUNCH_MEDIA_SELECT"]/*' />
    [NativeTypeName("#define VK_LAUNCH_MEDIA_SELECT 0xB5")]
    public const int VK_LAUNCH_MEDIA_SELECT = 0xB5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LAUNCH_APP1"]/*' />
    [NativeTypeName("#define VK_LAUNCH_APP1 0xB6")]
    public const int VK_LAUNCH_APP1 = 0xB6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_LAUNCH_APP2"]/*' />
    [NativeTypeName("#define VK_LAUNCH_APP2 0xB7")]
    public const int VK_LAUNCH_APP2 = 0xB7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_1"]/*' />
    [NativeTypeName("#define VK_OEM_1 0xBA")]
    public const int VK_OEM_1 = 0xBA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_PLUS"]/*' />
    [NativeTypeName("#define VK_OEM_PLUS 0xBB")]
    public const int VK_OEM_PLUS = 0xBB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_COMMA"]/*' />
    [NativeTypeName("#define VK_OEM_COMMA 0xBC")]
    public const int VK_OEM_COMMA = 0xBC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_MINUS"]/*' />
    [NativeTypeName("#define VK_OEM_MINUS 0xBD")]
    public const int VK_OEM_MINUS = 0xBD;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_PERIOD"]/*' />
    [NativeTypeName("#define VK_OEM_PERIOD 0xBE")]
    public const int VK_OEM_PERIOD = 0xBE;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_2"]/*' />
    [NativeTypeName("#define VK_OEM_2 0xBF")]
    public const int VK_OEM_2 = 0xBF;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_3"]/*' />
    [NativeTypeName("#define VK_OEM_3 0xC0")]
    public const int VK_OEM_3 = 0xC0;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_A"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_A 0xC3")]
    public const int VK_GAMEPAD_A = 0xC3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_B"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_B 0xC4")]
    public const int VK_GAMEPAD_B = 0xC4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_X"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_X 0xC5")]
    public const int VK_GAMEPAD_X = 0xC5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_Y"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_Y 0xC6")]
    public const int VK_GAMEPAD_Y = 0xC6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_SHOULDER"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_SHOULDER 0xC7")]
    public const int VK_GAMEPAD_RIGHT_SHOULDER = 0xC7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_SHOULDER"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_SHOULDER 0xC8")]
    public const int VK_GAMEPAD_LEFT_SHOULDER = 0xC8;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_TRIGGER"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_TRIGGER 0xC9")]
    public const int VK_GAMEPAD_LEFT_TRIGGER = 0xC9;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_TRIGGER"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_TRIGGER 0xCA")]
    public const int VK_GAMEPAD_RIGHT_TRIGGER = 0xCA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_DPAD_UP"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_DPAD_UP 0xCB")]
    public const int VK_GAMEPAD_DPAD_UP = 0xCB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_DPAD_DOWN"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_DPAD_DOWN 0xCC")]
    public const int VK_GAMEPAD_DPAD_DOWN = 0xCC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_DPAD_LEFT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_DPAD_LEFT 0xCD")]
    public const int VK_GAMEPAD_DPAD_LEFT = 0xCD;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_DPAD_RIGHT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_DPAD_RIGHT 0xCE")]
    public const int VK_GAMEPAD_DPAD_RIGHT = 0xCE;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_MENU"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_MENU 0xCF")]
    public const int VK_GAMEPAD_MENU = 0xCF;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_VIEW"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_VIEW 0xD0")]
    public const int VK_GAMEPAD_VIEW = 0xD0;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON 0xD1")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON = 0xD1;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON 0xD2")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON = 0xD2;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_THUMBSTICK_UP"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_UP 0xD3")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_UP = 0xD3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_THUMBSTICK_DOWN"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_DOWN 0xD4")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_DOWN = 0xD4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT 0xD5")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT = 0xD5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_LEFT_THUMBSTICK_LEFT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_LEFT 0xD6")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_LEFT = 0xD6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_THUMBSTICK_UP"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_UP 0xD7")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_UP = 0xD7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN 0xD8")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN = 0xD8;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT 0xD9")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT = 0xD9;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT"]/*' />
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT 0xDA")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT = 0xDA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_4"]/*' />
    [NativeTypeName("#define VK_OEM_4 0xDB")]
    public const int VK_OEM_4 = 0xDB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_5"]/*' />
    [NativeTypeName("#define VK_OEM_5 0xDC")]
    public const int VK_OEM_5 = 0xDC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_6"]/*' />
    [NativeTypeName("#define VK_OEM_6 0xDD")]
    public const int VK_OEM_6 = 0xDD;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_7"]/*' />
    [NativeTypeName("#define VK_OEM_7 0xDE")]
    public const int VK_OEM_7 = 0xDE;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_8"]/*' />
    [NativeTypeName("#define VK_OEM_8 0xDF")]
    public const int VK_OEM_8 = 0xDF;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_AX"]/*' />
    [NativeTypeName("#define VK_OEM_AX 0xE1")]
    public const int VK_OEM_AX = 0xE1;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_102"]/*' />
    [NativeTypeName("#define VK_OEM_102 0xE2")]
    public const int VK_OEM_102 = 0xE2;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ICO_HELP"]/*' />
    [NativeTypeName("#define VK_ICO_HELP 0xE3")]
    public const int VK_ICO_HELP = 0xE3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ICO_00"]/*' />
    [NativeTypeName("#define VK_ICO_00 0xE4")]
    public const int VK_ICO_00 = 0xE4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PROCESSKEY"]/*' />
    [NativeTypeName("#define VK_PROCESSKEY 0xE5")]
    public const int VK_PROCESSKEY = 0xE5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ICO_CLEAR"]/*' />
    [NativeTypeName("#define VK_ICO_CLEAR 0xE6")]
    public const int VK_ICO_CLEAR = 0xE6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PACKET"]/*' />
    [NativeTypeName("#define VK_PACKET 0xE7")]
    public const int VK_PACKET = 0xE7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_RESET"]/*' />
    [NativeTypeName("#define VK_OEM_RESET 0xE9")]
    public const int VK_OEM_RESET = 0xE9;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_JUMP"]/*' />
    [NativeTypeName("#define VK_OEM_JUMP 0xEA")]
    public const int VK_OEM_JUMP = 0xEA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_PA1"]/*' />
    [NativeTypeName("#define VK_OEM_PA1 0xEB")]
    public const int VK_OEM_PA1 = 0xEB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_PA2"]/*' />
    [NativeTypeName("#define VK_OEM_PA2 0xEC")]
    public const int VK_OEM_PA2 = 0xEC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_PA3"]/*' />
    [NativeTypeName("#define VK_OEM_PA3 0xED")]
    public const int VK_OEM_PA3 = 0xED;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_WSCTRL"]/*' />
    [NativeTypeName("#define VK_OEM_WSCTRL 0xEE")]
    public const int VK_OEM_WSCTRL = 0xEE;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_CUSEL"]/*' />
    [NativeTypeName("#define VK_OEM_CUSEL 0xEF")]
    public const int VK_OEM_CUSEL = 0xEF;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_ATTN"]/*' />
    [NativeTypeName("#define VK_OEM_ATTN 0xF0")]
    public const int VK_OEM_ATTN = 0xF0;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_FINISH"]/*' />
    [NativeTypeName("#define VK_OEM_FINISH 0xF1")]
    public const int VK_OEM_FINISH = 0xF1;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_COPY"]/*' />
    [NativeTypeName("#define VK_OEM_COPY 0xF2")]
    public const int VK_OEM_COPY = 0xF2;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_AUTO"]/*' />
    [NativeTypeName("#define VK_OEM_AUTO 0xF3")]
    public const int VK_OEM_AUTO = 0xF3;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_ENLW"]/*' />
    [NativeTypeName("#define VK_OEM_ENLW 0xF4")]
    public const int VK_OEM_ENLW = 0xF4;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_BACKTAB"]/*' />
    [NativeTypeName("#define VK_OEM_BACKTAB 0xF5")]
    public const int VK_OEM_BACKTAB = 0xF5;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ATTN"]/*' />
    [NativeTypeName("#define VK_ATTN 0xF6")]
    public const int VK_ATTN = 0xF6;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_CRSEL"]/*' />
    [NativeTypeName("#define VK_CRSEL 0xF7")]
    public const int VK_CRSEL = 0xF7;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_EXSEL"]/*' />
    [NativeTypeName("#define VK_EXSEL 0xF8")]
    public const int VK_EXSEL = 0xF8;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_EREOF"]/*' />
    [NativeTypeName("#define VK_EREOF 0xF9")]
    public const int VK_EREOF = 0xF9;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PLAY"]/*' />
    [NativeTypeName("#define VK_PLAY 0xFA")]
    public const int VK_PLAY = 0xFA;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_ZOOM"]/*' />
    [NativeTypeName("#define VK_ZOOM 0xFB")]
    public const int VK_ZOOM = 0xFB;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_NONAME"]/*' />
    [NativeTypeName("#define VK_NONAME 0xFC")]
    public const int VK_NONAME = 0xFC;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_PA1"]/*' />
    [NativeTypeName("#define VK_PA1 0xFD")]
    public const int VK_PA1 = 0xFD;

    /// <include file='VK.xml' path='doc/member[@name="VK.VK_OEM_CLEAR"]/*' />
    [NativeTypeName("#define VK_OEM_CLEAR 0xFE")]
    public const int VK_OEM_CLEAR = 0xFE;
}
