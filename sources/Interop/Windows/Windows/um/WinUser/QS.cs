// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class QS
{
    /// <include file='QS.xml' path='doc/member[@name="QS.QS_KEY"]/*' />
    [NativeTypeName("#define QS_KEY 0x0001")]
    public const int QS_KEY = 0x0001;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_MOUSEMOVE"]/*' />
    [NativeTypeName("#define QS_MOUSEMOVE 0x0002")]
    public const int QS_MOUSEMOVE = 0x0002;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_MOUSEBUTTON"]/*' />
    [NativeTypeName("#define QS_MOUSEBUTTON 0x0004")]
    public const int QS_MOUSEBUTTON = 0x0004;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_POSTMESSAGE"]/*' />
    [NativeTypeName("#define QS_POSTMESSAGE 0x0008")]
    public const int QS_POSTMESSAGE = 0x0008;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_TIMER"]/*' />
    [NativeTypeName("#define QS_TIMER 0x0010")]
    public const int QS_TIMER = 0x0010;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_PAINT"]/*' />
    [NativeTypeName("#define QS_PAINT 0x0020")]
    public const int QS_PAINT = 0x0020;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_SENDMESSAGE"]/*' />
    [NativeTypeName("#define QS_SENDMESSAGE 0x0040")]
    public const int QS_SENDMESSAGE = 0x0040;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_HOTKEY"]/*' />
    [NativeTypeName("#define QS_HOTKEY 0x0080")]
    public const int QS_HOTKEY = 0x0080;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_ALLPOSTMESSAGE"]/*' />
    [NativeTypeName("#define QS_ALLPOSTMESSAGE 0x0100")]
    public const int QS_ALLPOSTMESSAGE = 0x0100;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_RAWINPUT"]/*' />
    [NativeTypeName("#define QS_RAWINPUT 0x0400")]
    public const int QS_RAWINPUT = 0x0400;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_TOUCH"]/*' />
    [NativeTypeName("#define QS_TOUCH 0x0800")]
    public const int QS_TOUCH = 0x0800;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_POINTER"]/*' />
    [NativeTypeName("#define QS_POINTER 0x1000")]
    public const int QS_POINTER = 0x1000;

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_MOUSE"]/*' />
    [NativeTypeName("#define QS_MOUSE (QS_MOUSEMOVE     | \\\r\n                            QS_MOUSEBUTTON)")]
    public const int QS_MOUSE = (0x0002 | 0x0004);

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_INPUT"]/*' />
    [NativeTypeName("#define QS_INPUT (QS_MOUSE         | \\\r\n                            QS_KEY           | \\\r\n                            QS_RAWINPUT      | \\\r\n                            QS_TOUCH         | \\\r\n                            QS_POINTER)")]
    public const int QS_INPUT = ((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000);

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_ALLEVENTS"]/*' />
    [NativeTypeName("#define QS_ALLEVENTS (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY)")]
    public const int QS_ALLEVENTS = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) | 0x0008 | 0x0010 | 0x0020 | 0x0080);

    /// <include file='QS.xml' path='doc/member[@name="QS.QS_ALLINPUT"]/*' />
    [NativeTypeName("#define QS_ALLINPUT (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY        | \\\r\n                            QS_SENDMESSAGE)")]
    public const int QS_ALLINPUT = (((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) | 0x0008 | 0x0010 | 0x0020 | 0x0080 | 0x0040);
}
