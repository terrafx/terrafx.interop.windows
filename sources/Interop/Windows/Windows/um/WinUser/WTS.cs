// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WTS
{
    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_CONSOLE_CONNECT"]/*' />
    [NativeTypeName("#define WTS_CONSOLE_CONNECT 0x1")]
    public const int WTS_CONSOLE_CONNECT = 0x1;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_CONSOLE_DISCONNECT"]/*' />
    [NativeTypeName("#define WTS_CONSOLE_DISCONNECT 0x2")]
    public const int WTS_CONSOLE_DISCONNECT = 0x2;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_REMOTE_CONNECT"]/*' />
    [NativeTypeName("#define WTS_REMOTE_CONNECT 0x3")]
    public const int WTS_REMOTE_CONNECT = 0x3;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_REMOTE_DISCONNECT"]/*' />
    [NativeTypeName("#define WTS_REMOTE_DISCONNECT 0x4")]
    public const int WTS_REMOTE_DISCONNECT = 0x4;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_LOGON"]/*' />
    [NativeTypeName("#define WTS_SESSION_LOGON 0x5")]
    public const int WTS_SESSION_LOGON = 0x5;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_LOGOFF"]/*' />
    [NativeTypeName("#define WTS_SESSION_LOGOFF 0x6")]
    public const int WTS_SESSION_LOGOFF = 0x6;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_LOCK"]/*' />
    [NativeTypeName("#define WTS_SESSION_LOCK 0x7")]
    public const int WTS_SESSION_LOCK = 0x7;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_UNLOCK"]/*' />
    [NativeTypeName("#define WTS_SESSION_UNLOCK 0x8")]
    public const int WTS_SESSION_UNLOCK = 0x8;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_REMOTE_CONTROL"]/*' />
    [NativeTypeName("#define WTS_SESSION_REMOTE_CONTROL 0x9")]
    public const int WTS_SESSION_REMOTE_CONTROL = 0x9;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_CREATE"]/*' />
    [NativeTypeName("#define WTS_SESSION_CREATE 0xa")]
    public const int WTS_SESSION_CREATE = 0xa;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_TERMINATE"]/*' />
    [NativeTypeName("#define WTS_SESSION_TERMINATE 0xb")]
    public const int WTS_SESSION_TERMINATE = 0xb;

    /// <include file='WTS.xml' path='doc/member[@name="WTS.WTS_SESSION_DESKTOP_READY"]/*' />
    [NativeTypeName("#define WTS_SESSION_DESKTOP_READY 0xf")]
    public const int WTS_SESSION_DESKTOP_READY = 0xf;
}
