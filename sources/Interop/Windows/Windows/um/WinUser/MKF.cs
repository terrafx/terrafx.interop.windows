// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MKF
{
    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_MOUSEKEYSON"]/*' />
    [NativeTypeName("#define MKF_MOUSEKEYSON 0x00000001")]
    public const int MKF_MOUSEKEYSON = 0x00000001;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_AVAILABLE"]/*' />
    [NativeTypeName("#define MKF_AVAILABLE 0x00000002")]
    public const int MKF_AVAILABLE = 0x00000002;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_HOTKEYACTIVE"]/*' />
    [NativeTypeName("#define MKF_HOTKEYACTIVE 0x00000004")]
    public const int MKF_HOTKEYACTIVE = 0x00000004;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_CONFIRMHOTKEY"]/*' />
    [NativeTypeName("#define MKF_CONFIRMHOTKEY 0x00000008")]
    public const int MKF_CONFIRMHOTKEY = 0x00000008;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_HOTKEYSOUND"]/*' />
    [NativeTypeName("#define MKF_HOTKEYSOUND 0x00000010")]
    public const int MKF_HOTKEYSOUND = 0x00000010;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_INDICATOR"]/*' />
    [NativeTypeName("#define MKF_INDICATOR 0x00000020")]
    public const int MKF_INDICATOR = 0x00000020;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_MODIFIERS"]/*' />
    [NativeTypeName("#define MKF_MODIFIERS 0x00000040")]
    public const int MKF_MODIFIERS = 0x00000040;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_REPLACENUMBERS"]/*' />
    [NativeTypeName("#define MKF_REPLACENUMBERS 0x00000080")]
    public const int MKF_REPLACENUMBERS = 0x00000080;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_LEFTBUTTONSEL"]/*' />
    [NativeTypeName("#define MKF_LEFTBUTTONSEL 0x10000000")]
    public const int MKF_LEFTBUTTONSEL = 0x10000000;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_RIGHTBUTTONSEL"]/*' />
    [NativeTypeName("#define MKF_RIGHTBUTTONSEL 0x20000000")]
    public const int MKF_RIGHTBUTTONSEL = 0x20000000;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_LEFTBUTTONDOWN"]/*' />
    [NativeTypeName("#define MKF_LEFTBUTTONDOWN 0x01000000")]
    public const int MKF_LEFTBUTTONDOWN = 0x01000000;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_RIGHTBUTTONDOWN"]/*' />
    [NativeTypeName("#define MKF_RIGHTBUTTONDOWN 0x02000000")]
    public const int MKF_RIGHTBUTTONDOWN = 0x02000000;

    /// <include file='MKF.xml' path='doc/member[@name="MKF.MKF_MOUSEMODE"]/*' />
    [NativeTypeName("#define MKF_MOUSEMODE 0x80000000")]
    public const uint MKF_MOUSEMODE = 0x80000000;
}
