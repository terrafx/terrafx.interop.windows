// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MOUSEEVENTF
{
    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_MOVE"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_MOVE 0x0001")]
    public const int MOUSEEVENTF_MOVE = 0x0001;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_LEFTDOWN"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_LEFTDOWN 0x0002")]
    public const int MOUSEEVENTF_LEFTDOWN = 0x0002;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_LEFTUP"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_LEFTUP 0x0004")]
    public const int MOUSEEVENTF_LEFTUP = 0x0004;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_RIGHTDOWN"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_RIGHTDOWN 0x0008")]
    public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_RIGHTUP"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_RIGHTUP 0x0010")]
    public const int MOUSEEVENTF_RIGHTUP = 0x0010;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_MIDDLEDOWN"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_MIDDLEDOWN 0x0020")]
    public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_MIDDLEUP"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_MIDDLEUP 0x0040")]
    public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_XDOWN"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_XDOWN 0x0080")]
    public const int MOUSEEVENTF_XDOWN = 0x0080;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_XUP"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_XUP 0x0100")]
    public const int MOUSEEVENTF_XUP = 0x0100;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_WHEEL"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_WHEEL 0x0800")]
    public const int MOUSEEVENTF_WHEEL = 0x0800;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_HWHEEL"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_HWHEEL 0x01000")]
    public const int MOUSEEVENTF_HWHEEL = 0x01000;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_MOVE_NOCOALESCE"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_MOVE_NOCOALESCE 0x2000")]
    public const int MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_VIRTUALDESK"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_VIRTUALDESK 0x4000")]
    public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;

    /// <include file='MOUSEEVENTF.xml' path='doc/member[@name="MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE"]/*' />
    [NativeTypeName("#define MOUSEEVENTF_ABSOLUTE 0x8000")]
    public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
}
