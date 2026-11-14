// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MB
{
    /// <include file='MB.xml' path='doc/member[@name="MB.MB_OK"]/*' />
    [NativeTypeName("#define MB_OK 0x00000000L")]
    public const int MB_OK = 0x00000000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_OKCANCEL"]/*' />
    [NativeTypeName("#define MB_OKCANCEL 0x00000001L")]
    public const int MB_OKCANCEL = 0x00000001;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ABORTRETRYIGNORE"]/*' />
    [NativeTypeName("#define MB_ABORTRETRYIGNORE 0x00000002L")]
    public const int MB_ABORTRETRYIGNORE = 0x00000002;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_YESNOCANCEL"]/*' />
    [NativeTypeName("#define MB_YESNOCANCEL 0x00000003L")]
    public const int MB_YESNOCANCEL = 0x00000003;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_YESNO"]/*' />
    [NativeTypeName("#define MB_YESNO 0x00000004L")]
    public const int MB_YESNO = 0x00000004;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_RETRYCANCEL"]/*' />
    [NativeTypeName("#define MB_RETRYCANCEL 0x00000005L")]
    public const int MB_RETRYCANCEL = 0x00000005;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_CANCELTRYCONTINUE"]/*' />
    [NativeTypeName("#define MB_CANCELTRYCONTINUE 0x00000006L")]
    public const int MB_CANCELTRYCONTINUE = 0x00000006;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONHAND"]/*' />
    [NativeTypeName("#define MB_ICONHAND 0x00000010L")]
    public const int MB_ICONHAND = 0x00000010;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONQUESTION"]/*' />
    [NativeTypeName("#define MB_ICONQUESTION 0x00000020L")]
    public const int MB_ICONQUESTION = 0x00000020;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONEXCLAMATION"]/*' />
    [NativeTypeName("#define MB_ICONEXCLAMATION 0x00000030L")]
    public const int MB_ICONEXCLAMATION = 0x00000030;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONASTERISK"]/*' />
    [NativeTypeName("#define MB_ICONASTERISK 0x00000040L")]
    public const int MB_ICONASTERISK = 0x00000040;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_USERICON"]/*' />
    [NativeTypeName("#define MB_USERICON 0x00000080L")]
    public const int MB_USERICON = 0x00000080;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONWARNING"]/*' />
    [NativeTypeName("#define MB_ICONWARNING MB_ICONEXCLAMATION")]
    public const int MB_ICONWARNING = 0x00000030;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONERROR"]/*' />
    [NativeTypeName("#define MB_ICONERROR MB_ICONHAND")]
    public const int MB_ICONERROR = 0x00000010;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONINFORMATION"]/*' />
    [NativeTypeName("#define MB_ICONINFORMATION MB_ICONASTERISK")]
    public const int MB_ICONINFORMATION = 0x00000040;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONSTOP"]/*' />
    [NativeTypeName("#define MB_ICONSTOP MB_ICONHAND")]
    public const int MB_ICONSTOP = 0x00000010;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFBUTTON1"]/*' />
    [NativeTypeName("#define MB_DEFBUTTON1 0x00000000L")]
    public const int MB_DEFBUTTON1 = 0x00000000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFBUTTON2"]/*' />
    [NativeTypeName("#define MB_DEFBUTTON2 0x00000100L")]
    public const int MB_DEFBUTTON2 = 0x00000100;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFBUTTON3"]/*' />
    [NativeTypeName("#define MB_DEFBUTTON3 0x00000200L")]
    public const int MB_DEFBUTTON3 = 0x00000200;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFBUTTON4"]/*' />
    [NativeTypeName("#define MB_DEFBUTTON4 0x00000300L")]
    public const int MB_DEFBUTTON4 = 0x00000300;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_APPLMODAL"]/*' />
    [NativeTypeName("#define MB_APPLMODAL 0x00000000L")]
    public const int MB_APPLMODAL = 0x00000000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_SYSTEMMODAL"]/*' />
    [NativeTypeName("#define MB_SYSTEMMODAL 0x00001000L")]
    public const int MB_SYSTEMMODAL = 0x00001000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_TASKMODAL"]/*' />
    [NativeTypeName("#define MB_TASKMODAL 0x00002000L")]
    public const int MB_TASKMODAL = 0x00002000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_HELP"]/*' />
    [NativeTypeName("#define MB_HELP 0x00004000L")]
    public const int MB_HELP = 0x00004000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_NOFOCUS"]/*' />
    [NativeTypeName("#define MB_NOFOCUS 0x00008000L")]
    public const int MB_NOFOCUS = 0x00008000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_SETFOREGROUND"]/*' />
    [NativeTypeName("#define MB_SETFOREGROUND 0x00010000L")]
    public const int MB_SETFOREGROUND = 0x00010000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFAULT_DESKTOP_ONLY"]/*' />
    [NativeTypeName("#define MB_DEFAULT_DESKTOP_ONLY 0x00020000L")]
    public const int MB_DEFAULT_DESKTOP_ONLY = 0x00020000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_TOPMOST"]/*' />
    [NativeTypeName("#define MB_TOPMOST 0x00040000L")]
    public const int MB_TOPMOST = 0x00040000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_RIGHT"]/*' />
    [NativeTypeName("#define MB_RIGHT 0x00080000L")]
    public const int MB_RIGHT = 0x00080000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_RTLREADING"]/*' />
    [NativeTypeName("#define MB_RTLREADING 0x00100000L")]
    public const int MB_RTLREADING = 0x00100000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_SERVICE_NOTIFICATION"]/*' />
    [NativeTypeName("#define MB_SERVICE_NOTIFICATION 0x00200000L")]
    public const int MB_SERVICE_NOTIFICATION = 0x00200000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_SERVICE_NOTIFICATION_NT3X"]/*' />
    [NativeTypeName("#define MB_SERVICE_NOTIFICATION_NT3X 0x00040000L")]
    public const int MB_SERVICE_NOTIFICATION_NT3X = 0x00040000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_TYPEMASK"]/*' />
    [NativeTypeName("#define MB_TYPEMASK 0x0000000FL")]
    public const int MB_TYPEMASK = 0x0000000F;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_ICONMASK"]/*' />
    [NativeTypeName("#define MB_ICONMASK 0x000000F0L")]
    public const int MB_ICONMASK = 0x000000F0;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_DEFMASK"]/*' />
    [NativeTypeName("#define MB_DEFMASK 0x00000F00L")]
    public const int MB_DEFMASK = 0x00000F00;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_MODEMASK"]/*' />
    [NativeTypeName("#define MB_MODEMASK 0x00003000L")]
    public const int MB_MODEMASK = 0x00003000;

    /// <include file='MB.xml' path='doc/member[@name="MB.MB_MISCMASK"]/*' />
    [NativeTypeName("#define MB_MISCMASK 0x0000C000L")]
    public const int MB_MISCMASK = 0x0000C000;
}
