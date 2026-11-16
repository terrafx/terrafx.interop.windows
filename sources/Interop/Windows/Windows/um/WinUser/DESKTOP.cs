// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DESKTOP
{
    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_READOBJECTS"]/*' />
    [NativeTypeName("#define DESKTOP_READOBJECTS 0x0001L")]
    public const int DESKTOP_READOBJECTS = 0x0001;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_CREATEWINDOW"]/*' />
    [NativeTypeName("#define DESKTOP_CREATEWINDOW 0x0002L")]
    public const int DESKTOP_CREATEWINDOW = 0x0002;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_CREATEMENU"]/*' />
    [NativeTypeName("#define DESKTOP_CREATEMENU 0x0004L")]
    public const int DESKTOP_CREATEMENU = 0x0004;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_HOOKCONTROL"]/*' />
    [NativeTypeName("#define DESKTOP_HOOKCONTROL 0x0008L")]
    public const int DESKTOP_HOOKCONTROL = 0x0008;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_JOURNALRECORD"]/*' />
    [NativeTypeName("#define DESKTOP_JOURNALRECORD 0x0010L")]
    public const int DESKTOP_JOURNALRECORD = 0x0010;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_JOURNALPLAYBACK"]/*' />
    [NativeTypeName("#define DESKTOP_JOURNALPLAYBACK 0x0020L")]
    public const int DESKTOP_JOURNALPLAYBACK = 0x0020;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_ENUMERATE"]/*' />
    [NativeTypeName("#define DESKTOP_ENUMERATE 0x0040L")]
    public const int DESKTOP_ENUMERATE = 0x0040;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_WRITEOBJECTS"]/*' />
    [NativeTypeName("#define DESKTOP_WRITEOBJECTS 0x0080L")]
    public const int DESKTOP_WRITEOBJECTS = 0x0080;

    /// <include file='DESKTOP.xml' path='doc/member[@name="DESKTOP.DESKTOP_SWITCHDESKTOP"]/*' />
    [NativeTypeName("#define DESKTOP_SWITCHDESKTOP 0x0100L")]
    public const int DESKTOP_SWITCHDESKTOP = 0x0100;
}
