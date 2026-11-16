// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WH
{
    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MIN"]/*' />
    [NativeTypeName("#define WH_MIN (-1)")]
    public const int WH_MIN = (-1);

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MSGFILTER"]/*' />
    [NativeTypeName("#define WH_MSGFILTER (-1)")]
    public const int WH_MSGFILTER = (-1);

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_JOURNALRECORD"]/*' />
    [NativeTypeName("#define WH_JOURNALRECORD 0")]
    public const int WH_JOURNALRECORD = 0;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_JOURNALPLAYBACK"]/*' />
    [NativeTypeName("#define WH_JOURNALPLAYBACK 1")]
    public const int WH_JOURNALPLAYBACK = 1;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_KEYBOARD"]/*' />
    [NativeTypeName("#define WH_KEYBOARD 2")]
    public const int WH_KEYBOARD = 2;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_GETMESSAGE"]/*' />
    [NativeTypeName("#define WH_GETMESSAGE 3")]
    public const int WH_GETMESSAGE = 3;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_CALLWNDPROC"]/*' />
    [NativeTypeName("#define WH_CALLWNDPROC 4")]
    public const int WH_CALLWNDPROC = 4;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_CBT"]/*' />
    [NativeTypeName("#define WH_CBT 5")]
    public const int WH_CBT = 5;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_SYSMSGFILTER"]/*' />
    [NativeTypeName("#define WH_SYSMSGFILTER 6")]
    public const int WH_SYSMSGFILTER = 6;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MOUSE"]/*' />
    [NativeTypeName("#define WH_MOUSE 7")]
    public const int WH_MOUSE = 7;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_DEBUG"]/*' />
    [NativeTypeName("#define WH_DEBUG 9")]
    public const int WH_DEBUG = 9;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_SHELL"]/*' />
    [NativeTypeName("#define WH_SHELL 10")]
    public const int WH_SHELL = 10;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_FOREGROUNDIDLE"]/*' />
    [NativeTypeName("#define WH_FOREGROUNDIDLE 11")]
    public const int WH_FOREGROUNDIDLE = 11;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_CALLWNDPROCRET"]/*' />
    [NativeTypeName("#define WH_CALLWNDPROCRET 12")]
    public const int WH_CALLWNDPROCRET = 12;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_KEYBOARD_LL"]/*' />
    [NativeTypeName("#define WH_KEYBOARD_LL 13")]
    public const int WH_KEYBOARD_LL = 13;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MOUSE_LL"]/*' />
    [NativeTypeName("#define WH_MOUSE_LL 14")]
    public const int WH_MOUSE_LL = 14;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MAX"]/*' />
    [NativeTypeName("#define WH_MAX 14")]
    public const int WH_MAX = 14;

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MINHOOK"]/*' />
    [NativeTypeName("#define WH_MINHOOK WH_MIN")]
    public const int WH_MINHOOK = (-1);

    /// <include file='WH.xml' path='doc/member[@name="WH.WH_MAXHOOK"]/*' />
    [NativeTypeName("#define WH_MAXHOOK WH_MAX")]
    public const int WH_MAXHOOK = 14;
}
