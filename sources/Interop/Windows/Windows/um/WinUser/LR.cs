// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LR
{
    /// <include file='LR.xml' path='doc/member[@name="LR.LR_DEFAULTCOLOR"]/*' />
    [NativeTypeName("#define LR_DEFAULTCOLOR 0x00000000")]
    public const int LR_DEFAULTCOLOR = 0x00000000;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_MONOCHROME"]/*' />
    [NativeTypeName("#define LR_MONOCHROME 0x00000001")]
    public const int LR_MONOCHROME = 0x00000001;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_COLOR"]/*' />
    [NativeTypeName("#define LR_COLOR 0x00000002")]
    public const int LR_COLOR = 0x00000002;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_COPYRETURNORG"]/*' />
    [NativeTypeName("#define LR_COPYRETURNORG 0x00000004")]
    public const int LR_COPYRETURNORG = 0x00000004;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_COPYDELETEORG"]/*' />
    [NativeTypeName("#define LR_COPYDELETEORG 0x00000008")]
    public const int LR_COPYDELETEORG = 0x00000008;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_LOADFROMFILE"]/*' />
    [NativeTypeName("#define LR_LOADFROMFILE 0x00000010")]
    public const int LR_LOADFROMFILE = 0x00000010;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_LOADTRANSPARENT"]/*' />
    [NativeTypeName("#define LR_LOADTRANSPARENT 0x00000020")]
    public const int LR_LOADTRANSPARENT = 0x00000020;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_DEFAULTSIZE"]/*' />
    [NativeTypeName("#define LR_DEFAULTSIZE 0x00000040")]
    public const int LR_DEFAULTSIZE = 0x00000040;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_VGACOLOR"]/*' />
    [NativeTypeName("#define LR_VGACOLOR 0x00000080")]
    public const int LR_VGACOLOR = 0x00000080;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_LOADMAP3DCOLORS"]/*' />
    [NativeTypeName("#define LR_LOADMAP3DCOLORS 0x00001000")]
    public const int LR_LOADMAP3DCOLORS = 0x00001000;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_CREATEDIBSECTION"]/*' />
    [NativeTypeName("#define LR_CREATEDIBSECTION 0x00002000")]
    public const int LR_CREATEDIBSECTION = 0x00002000;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_COPYFROMRESOURCE"]/*' />
    [NativeTypeName("#define LR_COPYFROMRESOURCE 0x00004000")]
    public const int LR_COPYFROMRESOURCE = 0x00004000;

    /// <include file='LR.xml' path='doc/member[@name="LR.LR_SHARED"]/*' />
    [NativeTypeName("#define LR_SHARED 0x00008000")]
    public const int LR_SHARED = 0x00008000;
}
