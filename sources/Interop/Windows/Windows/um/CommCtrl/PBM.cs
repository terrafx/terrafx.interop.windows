// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PBM
{
    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETRANGE"]/*' />
    [NativeTypeName("#define PBM_SETRANGE (WM_USER+1)")]
    public const int PBM_SETRANGE = (0x0400 + 1);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETPOS"]/*' />
    [NativeTypeName("#define PBM_SETPOS (WM_USER+2)")]
    public const int PBM_SETPOS = (0x0400 + 2);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_DELTAPOS"]/*' />
    [NativeTypeName("#define PBM_DELTAPOS (WM_USER+3)")]
    public const int PBM_DELTAPOS = (0x0400 + 3);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETSTEP"]/*' />
    [NativeTypeName("#define PBM_SETSTEP (WM_USER+4)")]
    public const int PBM_SETSTEP = (0x0400 + 4);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_STEPIT"]/*' />
    [NativeTypeName("#define PBM_STEPIT (WM_USER+5)")]
    public const int PBM_STEPIT = (0x0400 + 5);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETRANGE32"]/*' />
    [NativeTypeName("#define PBM_SETRANGE32 (WM_USER+6)")]
    public const int PBM_SETRANGE32 = (0x0400 + 6);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETRANGE"]/*' />
    [NativeTypeName("#define PBM_GETRANGE (WM_USER+7)")]
    public const int PBM_GETRANGE = (0x0400 + 7);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETPOS"]/*' />
    [NativeTypeName("#define PBM_GETPOS (WM_USER+8)")]
    public const int PBM_GETPOS = (0x0400 + 8);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETBARCOLOR"]/*' />
    [NativeTypeName("#define PBM_SETBARCOLOR (WM_USER+9)")]
    public const int PBM_SETBARCOLOR = (0x0400 + 9);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETBKCOLOR"]/*' />
    [NativeTypeName("#define PBM_SETBKCOLOR CCM_SETBKCOLOR")]
    public const int PBM_SETBKCOLOR = (0x2000 + 1);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETMARQUEE"]/*' />
    [NativeTypeName("#define PBM_SETMARQUEE (WM_USER+10)")]
    public const int PBM_SETMARQUEE = (0x0400 + 10);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETSTEP"]/*' />
    [NativeTypeName("#define PBM_GETSTEP (WM_USER+13)")]
    public const int PBM_GETSTEP = (0x0400 + 13);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETBKCOLOR"]/*' />
    [NativeTypeName("#define PBM_GETBKCOLOR (WM_USER+14)")]
    public const int PBM_GETBKCOLOR = (0x0400 + 14);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETBARCOLOR"]/*' />
    [NativeTypeName("#define PBM_GETBARCOLOR (WM_USER+15)")]
    public const int PBM_GETBARCOLOR = (0x0400 + 15);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_SETSTATE"]/*' />
    [NativeTypeName("#define PBM_SETSTATE (WM_USER+16)")]
    public const int PBM_SETSTATE = (0x0400 + 16);

    /// <include file='PBM.xml' path='doc/member[@name="PBM.PBM_GETSTATE"]/*' />
    [NativeTypeName("#define PBM_GETSTATE (WM_USER+17)")]
    public const int PBM_GETSTATE = (0x0400 + 17);
}
