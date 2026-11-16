// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EVENT
{
    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_MIN"]/*' />
    [NativeTypeName("#define EVENT_MIN 0x00000001")]
    public const int EVENT_MIN = 0x00000001;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_MAX"]/*' />
    [NativeTypeName("#define EVENT_MAX 0x7FFFFFFF")]
    public const int EVENT_MAX = 0x7FFFFFFF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SOUND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SOUND 0x0001")]
    public const int EVENT_SYSTEM_SOUND = 0x0001;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_ALERT"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_ALERT 0x0002")]
    public const int EVENT_SYSTEM_ALERT = 0x0002;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_FOREGROUND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_FOREGROUND 0x0003")]
    public const int EVENT_SYSTEM_FOREGROUND = 0x0003;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MENUSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MENUSTART 0x0004")]
    public const int EVENT_SYSTEM_MENUSTART = 0x0004;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MENUEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MENUEND 0x0005")]
    public const int EVENT_SYSTEM_MENUEND = 0x0005;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MENUPOPUPSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPSTART 0x0006")]
    public const int EVENT_SYSTEM_MENUPOPUPSTART = 0x0006;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MENUPOPUPEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPEND 0x0007")]
    public const int EVENT_SYSTEM_MENUPOPUPEND = 0x0007;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_CAPTURESTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_CAPTURESTART 0x0008")]
    public const int EVENT_SYSTEM_CAPTURESTART = 0x0008;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_CAPTUREEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_CAPTUREEND 0x0009")]
    public const int EVENT_SYSTEM_CAPTUREEND = 0x0009;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MOVESIZESTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MOVESIZESTART 0x000A")]
    public const int EVENT_SYSTEM_MOVESIZESTART = 0x000A;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MOVESIZEEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MOVESIZEEND 0x000B")]
    public const int EVENT_SYSTEM_MOVESIZEEND = 0x000B;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_CONTEXTHELPSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPSTART 0x000C")]
    public const int EVENT_SYSTEM_CONTEXTHELPSTART = 0x000C;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_CONTEXTHELPEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPEND 0x000D")]
    public const int EVENT_SYSTEM_CONTEXTHELPEND = 0x000D;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_DRAGDROPSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPSTART 0x000E")]
    public const int EVENT_SYSTEM_DRAGDROPSTART = 0x000E;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_DRAGDROPEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPEND 0x000F")]
    public const int EVENT_SYSTEM_DRAGDROPEND = 0x000F;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_DIALOGSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_DIALOGSTART 0x0010")]
    public const int EVENT_SYSTEM_DIALOGSTART = 0x0010;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_DIALOGEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_DIALOGEND 0x0011")]
    public const int EVENT_SYSTEM_DIALOGEND = 0x0011;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SCROLLINGSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGSTART 0x0012")]
    public const int EVENT_SYSTEM_SCROLLINGSTART = 0x0012;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SCROLLINGEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGEND 0x0013")]
    public const int EVENT_SYSTEM_SCROLLINGEND = 0x0013;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHSTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHSTART 0x0014")]
    public const int EVENT_SYSTEM_SWITCHSTART = 0x0014;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHEND 0x0015")]
    public const int EVENT_SYSTEM_SWITCHEND = 0x0015;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MINIMIZESTART"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MINIMIZESTART 0x0016")]
    public const int EVENT_SYSTEM_MINIMIZESTART = 0x0016;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_MINIMIZEEND"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_MINIMIZEEND 0x0017")]
    public const int EVENT_SYSTEM_MINIMIZEEND = 0x0017;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_DESKTOPSWITCH"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_DESKTOPSWITCH 0x0020")]
    public const int EVENT_SYSTEM_DESKTOPSWITCH = 0x0020;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHER_APPGRABBED"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPGRABBED 0x0024")]
    public const int EVENT_SYSTEM_SWITCHER_APPGRABBED = 0x0024;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHER_APPOVERTARGET"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPOVERTARGET 0x0025")]
    public const int EVENT_SYSTEM_SWITCHER_APPOVERTARGET = 0x0025;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHER_APPDROPPED"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPDROPPED 0x0026")]
    public const int EVENT_SYSTEM_SWITCHER_APPDROPPED = 0x0026;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_SWITCHER_CANCELLED"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_CANCELLED 0x0027")]
    public const int EVENT_SYSTEM_SWITCHER_CANCELLED = 0x0027;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_IME_KEY_NOTIFICATION"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_IME_KEY_NOTIFICATION 0x0029")]
    public const int EVENT_SYSTEM_IME_KEY_NOTIFICATION = 0x0029;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_END"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_END 0x00FF")]
    public const int EVENT_SYSTEM_END = 0x00FF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OEM_DEFINED_START"]/*' />
    [NativeTypeName("#define EVENT_OEM_DEFINED_START 0x0101")]
    public const int EVENT_OEM_DEFINED_START = 0x0101;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OEM_DEFINED_END"]/*' />
    [NativeTypeName("#define EVENT_OEM_DEFINED_END 0x01FF")]
    public const int EVENT_OEM_DEFINED_END = 0x01FF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_UIA_EVENTID_START"]/*' />
    [NativeTypeName("#define EVENT_UIA_EVENTID_START 0x4E00")]
    public const int EVENT_UIA_EVENTID_START = 0x4E00;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_UIA_EVENTID_END"]/*' />
    [NativeTypeName("#define EVENT_UIA_EVENTID_END 0x4EFF")]
    public const int EVENT_UIA_EVENTID_END = 0x4EFF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_UIA_PROPID_START"]/*' />
    [NativeTypeName("#define EVENT_UIA_PROPID_START 0x7500")]
    public const int EVENT_UIA_PROPID_START = 0x7500;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_UIA_PROPID_END"]/*' />
    [NativeTypeName("#define EVENT_UIA_PROPID_END 0x75FF")]
    public const int EVENT_UIA_PROPID_END = 0x75FF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_CARET"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_CARET 0x4001")]
    public const int EVENT_CONSOLE_CARET = 0x4001;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_UPDATE_REGION"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_REGION 0x4002")]
    public const int EVENT_CONSOLE_UPDATE_REGION = 0x4002;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_UPDATE_SIMPLE"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SIMPLE 0x4003")]
    public const int EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_UPDATE_SCROLL"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SCROLL 0x4004")]
    public const int EVENT_CONSOLE_UPDATE_SCROLL = 0x4004;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_LAYOUT"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_LAYOUT 0x4005")]
    public const int EVENT_CONSOLE_LAYOUT = 0x4005;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_START_APPLICATION"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_START_APPLICATION 0x4006")]
    public const int EVENT_CONSOLE_START_APPLICATION = 0x4006;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_END_APPLICATION"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_END_APPLICATION 0x4007")]
    public const int EVENT_CONSOLE_END_APPLICATION = 0x4007;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_CONSOLE_END"]/*' />
    [NativeTypeName("#define EVENT_CONSOLE_END 0x40FF")]
    public const int EVENT_CONSOLE_END = 0x40FF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_CREATE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_CREATE 0x8000")]
    public const int EVENT_OBJECT_CREATE = 0x8000;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DESTROY"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DESTROY 0x8001")]
    public const int EVENT_OBJECT_DESTROY = 0x8001;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_SHOW"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_SHOW 0x8002")]
    public const int EVENT_OBJECT_SHOW = 0x8002;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_HIDE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_HIDE 0x8003")]
    public const int EVENT_OBJECT_HIDE = 0x8003;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_REORDER"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_REORDER 0x8004")]
    public const int EVENT_OBJECT_REORDER = 0x8004;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_FOCUS"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_FOCUS 0x8005")]
    public const int EVENT_OBJECT_FOCUS = 0x8005;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_SELECTION"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_SELECTION 0x8006")]
    public const int EVENT_OBJECT_SELECTION = 0x8006;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_SELECTIONADD"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONADD 0x8007")]
    public const int EVENT_OBJECT_SELECTIONADD = 0x8007;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_SELECTIONREMOVE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONREMOVE 0x8008")]
    public const int EVENT_OBJECT_SELECTIONREMOVE = 0x8008;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_SELECTIONWITHIN"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONWITHIN 0x8009")]
    public const int EVENT_OBJECT_SELECTIONWITHIN = 0x8009;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_STATECHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_STATECHANGE 0x800A")]
    public const int EVENT_OBJECT_STATECHANGE = 0x800A;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_LOCATIONCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_LOCATIONCHANGE 0x800B")]
    public const int EVENT_OBJECT_LOCATIONCHANGE = 0x800B;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_NAMECHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_NAMECHANGE 0x800C")]
    public const int EVENT_OBJECT_NAMECHANGE = 0x800C;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DESCRIPTIONCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DESCRIPTIONCHANGE 0x800D")]
    public const int EVENT_OBJECT_DESCRIPTIONCHANGE = 0x800D;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_VALUECHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_VALUECHANGE 0x800E")]
    public const int EVENT_OBJECT_VALUECHANGE = 0x800E;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_PARENTCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_PARENTCHANGE 0x800F")]
    public const int EVENT_OBJECT_PARENTCHANGE = 0x800F;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_HELPCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_HELPCHANGE 0x8010")]
    public const int EVENT_OBJECT_HELPCHANGE = 0x8010;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DEFACTIONCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DEFACTIONCHANGE 0x8011")]
    public const int EVENT_OBJECT_DEFACTIONCHANGE = 0x8011;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_ACCELERATORCHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_ACCELERATORCHANGE 0x8012")]
    public const int EVENT_OBJECT_ACCELERATORCHANGE = 0x8012;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_INVOKED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_INVOKED 0x8013")]
    public const int EVENT_OBJECT_INVOKED = 0x8013;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_TEXTSELECTIONCHANGED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_TEXTSELECTIONCHANGED 0x8014")]
    public const int EVENT_OBJECT_TEXTSELECTIONCHANGED = 0x8014;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_CONTENTSCROLLED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_CONTENTSCROLLED 0x8015")]
    public const int EVENT_OBJECT_CONTENTSCROLLED = 0x8015;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_SYSTEM_ARRANGMENTPREVIEW"]/*' />
    [NativeTypeName("#define EVENT_SYSTEM_ARRANGMENTPREVIEW 0x8016")]
    public const int EVENT_SYSTEM_ARRANGMENTPREVIEW = 0x8016;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_CLOAKED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_CLOAKED 0x8017")]
    public const int EVENT_OBJECT_CLOAKED = 0x8017;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_UNCLOAKED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_UNCLOAKED 0x8018")]
    public const int EVENT_OBJECT_UNCLOAKED = 0x8018;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_LIVEREGIONCHANGED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_LIVEREGIONCHANGED 0x8019")]
    public const int EVENT_OBJECT_LIVEREGIONCHANGED = 0x8019;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED 0x8020")]
    public const int EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED = 0x8020;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGSTART"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGSTART 0x8021")]
    public const int EVENT_OBJECT_DRAGSTART = 0x8021;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGCANCEL"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGCANCEL 0x8022")]
    public const int EVENT_OBJECT_DRAGCANCEL = 0x8022;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGCOMPLETE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGCOMPLETE 0x8023")]
    public const int EVENT_OBJECT_DRAGCOMPLETE = 0x8023;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGENTER"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGENTER 0x8024")]
    public const int EVENT_OBJECT_DRAGENTER = 0x8024;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGLEAVE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGLEAVE 0x8025")]
    public const int EVENT_OBJECT_DRAGLEAVE = 0x8025;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_DRAGDROPPED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_DRAGDROPPED 0x8026")]
    public const int EVENT_OBJECT_DRAGDROPPED = 0x8026;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_IME_SHOW"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_IME_SHOW 0x8027")]
    public const int EVENT_OBJECT_IME_SHOW = 0x8027;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_IME_HIDE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_IME_HIDE 0x8028")]
    public const int EVENT_OBJECT_IME_HIDE = 0x8028;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_IME_CHANGE"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_IME_CHANGE 0x8029")]
    public const int EVENT_OBJECT_IME_CHANGE = 0x8029;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED 0x8030")]
    public const int EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED = 0x8030;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_OBJECT_END"]/*' />
    [NativeTypeName("#define EVENT_OBJECT_END 0x80FF")]
    public const int EVENT_OBJECT_END = 0x80FF;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_AIA_START"]/*' />
    [NativeTypeName("#define EVENT_AIA_START 0xA000")]
    public const int EVENT_AIA_START = 0xA000;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_AIA_END"]/*' />
    [NativeTypeName("#define EVENT_AIA_END 0xAFFF")]
    public const int EVENT_AIA_END = 0xAFFF;
}
