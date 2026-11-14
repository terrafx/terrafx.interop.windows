// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SWP
{
    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NONE"]/*' />
    [NativeTypeName("#define SWP_NONE 0x0000")]
    public const int SWP_NONE = 0x0000;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOSIZE"]/*' />
    [NativeTypeName("#define SWP_NOSIZE 0x0001")]
    public const int SWP_NOSIZE = 0x0001;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOMOVE"]/*' />
    [NativeTypeName("#define SWP_NOMOVE 0x0002")]
    public const int SWP_NOMOVE = 0x0002;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOZORDER"]/*' />
    [NativeTypeName("#define SWP_NOZORDER 0x0004")]
    public const int SWP_NOZORDER = 0x0004;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOREDRAW"]/*' />
    [NativeTypeName("#define SWP_NOREDRAW 0x0008")]
    public const int SWP_NOREDRAW = 0x0008;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOACTIVATE"]/*' />
    [NativeTypeName("#define SWP_NOACTIVATE 0x0010")]
    public const int SWP_NOACTIVATE = 0x0010;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_FRAMECHANGED"]/*' />
    [NativeTypeName("#define SWP_FRAMECHANGED 0x0020")]
    public const int SWP_FRAMECHANGED = 0x0020;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_SHOWWINDOW"]/*' />
    [NativeTypeName("#define SWP_SHOWWINDOW 0x0040")]
    public const int SWP_SHOWWINDOW = 0x0040;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_HIDEWINDOW"]/*' />
    [NativeTypeName("#define SWP_HIDEWINDOW 0x0080")]
    public const int SWP_HIDEWINDOW = 0x0080;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOCOPYBITS"]/*' />
    [NativeTypeName("#define SWP_NOCOPYBITS 0x0100")]
    public const int SWP_NOCOPYBITS = 0x0100;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOOWNERZORDER"]/*' />
    [NativeTypeName("#define SWP_NOOWNERZORDER 0x0200")]
    public const int SWP_NOOWNERZORDER = 0x0200;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOSENDCHANGING"]/*' />
    [NativeTypeName("#define SWP_NOSENDCHANGING 0x0400")]
    public const int SWP_NOSENDCHANGING = 0x0400;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_DRAWFRAME"]/*' />
    [NativeTypeName("#define SWP_DRAWFRAME SWP_FRAMECHANGED")]
    public const int SWP_DRAWFRAME = 0x0020;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_NOREPOSITION"]/*' />
    [NativeTypeName("#define SWP_NOREPOSITION SWP_NOOWNERZORDER")]
    public const int SWP_NOREPOSITION = 0x0200;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_DEFERERASE"]/*' />
    [NativeTypeName("#define SWP_DEFERERASE 0x2000")]
    public const int SWP_DEFERERASE = 0x2000;

    /// <include file='SWP.xml' path='doc/member[@name="SWP.SWP_ASYNCWINDOWPOS"]/*' />
    [NativeTypeName("#define SWP_ASYNCWINDOWPOS 0x4000")]
    public const int SWP_ASYNCWINDOWPOS = 0x4000;
}
