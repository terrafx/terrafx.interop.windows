// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DLGC
{
    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_WANTARROWS"]/*' />
    [NativeTypeName("#define DLGC_WANTARROWS 0x0001")]
    public const int DLGC_WANTARROWS = 0x0001;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_WANTTAB"]/*' />
    [NativeTypeName("#define DLGC_WANTTAB 0x0002")]
    public const int DLGC_WANTTAB = 0x0002;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_WANTALLKEYS"]/*' />
    [NativeTypeName("#define DLGC_WANTALLKEYS 0x0004")]
    public const int DLGC_WANTALLKEYS = 0x0004;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_WANTMESSAGE"]/*' />
    [NativeTypeName("#define DLGC_WANTMESSAGE 0x0004")]
    public const int DLGC_WANTMESSAGE = 0x0004;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_HASSETSEL"]/*' />
    [NativeTypeName("#define DLGC_HASSETSEL 0x0008")]
    public const int DLGC_HASSETSEL = 0x0008;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_DEFPUSHBUTTON"]/*' />
    [NativeTypeName("#define DLGC_DEFPUSHBUTTON 0x0010")]
    public const int DLGC_DEFPUSHBUTTON = 0x0010;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_UNDEFPUSHBUTTON"]/*' />
    [NativeTypeName("#define DLGC_UNDEFPUSHBUTTON 0x0020")]
    public const int DLGC_UNDEFPUSHBUTTON = 0x0020;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_RADIOBUTTON"]/*' />
    [NativeTypeName("#define DLGC_RADIOBUTTON 0x0040")]
    public const int DLGC_RADIOBUTTON = 0x0040;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_WANTCHARS"]/*' />
    [NativeTypeName("#define DLGC_WANTCHARS 0x0080")]
    public const int DLGC_WANTCHARS = 0x0080;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_STATIC"]/*' />
    [NativeTypeName("#define DLGC_STATIC 0x0100")]
    public const int DLGC_STATIC = 0x0100;

    /// <include file='DLGC.xml' path='doc/member[@name="DLGC.DLGC_BUTTON"]/*' />
    [NativeTypeName("#define DLGC_BUTTON 0x2000")]
    public const int DLGC_BUTTON = 0x2000;
}
