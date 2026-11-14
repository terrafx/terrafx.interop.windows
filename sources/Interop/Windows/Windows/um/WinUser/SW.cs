// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SW
{
    /// <include file='SW.xml' path='doc/member[@name="SW.SW_HIDE"]/*' />
    [NativeTypeName("#define SW_HIDE 0")]
    public const int SW_HIDE = 0;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWNORMAL"]/*' />
    [NativeTypeName("#define SW_SHOWNORMAL 1")]
    public const int SW_SHOWNORMAL = 1;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_NORMAL"]/*' />
    [NativeTypeName("#define SW_NORMAL 1")]
    public const int SW_NORMAL = 1;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWMINIMIZED"]/*' />
    [NativeTypeName("#define SW_SHOWMINIMIZED 2")]
    public const int SW_SHOWMINIMIZED = 2;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWMAXIMIZED"]/*' />
    [NativeTypeName("#define SW_SHOWMAXIMIZED 3")]
    public const int SW_SHOWMAXIMIZED = 3;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_MAXIMIZE"]/*' />
    [NativeTypeName("#define SW_MAXIMIZE 3")]
    public const int SW_MAXIMIZE = 3;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWNOACTIVATE"]/*' />
    [NativeTypeName("#define SW_SHOWNOACTIVATE 4")]
    public const int SW_SHOWNOACTIVATE = 4;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOW"]/*' />
    [NativeTypeName("#define SW_SHOW 5")]
    public const int SW_SHOW = 5;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_MINIMIZE"]/*' />
    [NativeTypeName("#define SW_MINIMIZE 6")]
    public const int SW_MINIMIZE = 6;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWMINNOACTIVE"]/*' />
    [NativeTypeName("#define SW_SHOWMINNOACTIVE 7")]
    public const int SW_SHOWMINNOACTIVE = 7;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWNA"]/*' />
    [NativeTypeName("#define SW_SHOWNA 8")]
    public const int SW_SHOWNA = 8;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_RESTORE"]/*' />
    [NativeTypeName("#define SW_RESTORE 9")]
    public const int SW_RESTORE = 9;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SHOWDEFAULT"]/*' />
    [NativeTypeName("#define SW_SHOWDEFAULT 10")]
    public const int SW_SHOWDEFAULT = 10;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_FORCEMINIMIZE"]/*' />
    [NativeTypeName("#define SW_FORCEMINIMIZE 11")]
    public const int SW_FORCEMINIMIZE = 11;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_MAX"]/*' />
    [NativeTypeName("#define SW_MAX 11")]
    public const int SW_MAX = 11;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_PARENTCLOSING"]/*' />
    [NativeTypeName("#define SW_PARENTCLOSING 1")]
    public const int SW_PARENTCLOSING = 1;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_OTHERZOOM"]/*' />
    [NativeTypeName("#define SW_OTHERZOOM 2")]
    public const int SW_OTHERZOOM = 2;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_PARENTOPENING"]/*' />
    [NativeTypeName("#define SW_PARENTOPENING 3")]
    public const int SW_PARENTOPENING = 3;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_OTHERUNZOOM"]/*' />
    [NativeTypeName("#define SW_OTHERUNZOOM 4")]
    public const int SW_OTHERUNZOOM = 4;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SCROLLCHILDREN"]/*' />
    [NativeTypeName("#define SW_SCROLLCHILDREN 0x0001")]
    public const int SW_SCROLLCHILDREN = 0x0001;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_INVALIDATE"]/*' />
    [NativeTypeName("#define SW_INVALIDATE 0x0002")]
    public const int SW_INVALIDATE = 0x0002;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_ERASE"]/*' />
    [NativeTypeName("#define SW_ERASE 0x0004")]
    public const int SW_ERASE = 0x0004;

    /// <include file='SW.xml' path='doc/member[@name="SW.SW_SMOOTHSCROLL"]/*' />
    [NativeTypeName("#define SW_SMOOTHSCROLL 0x0010")]
    public const int SW_SMOOTHSCROLL = 0x0010;
}
