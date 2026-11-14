// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LPD
{
    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_DOUBLEBUFFER"]/*' />
    [NativeTypeName("#define LPD_DOUBLEBUFFER 0x00000001")]
    public const int LPD_DOUBLEBUFFER = 0x00000001;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_STEREO"]/*' />
    [NativeTypeName("#define LPD_STEREO 0x00000002")]
    public const int LPD_STEREO = 0x00000002;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SUPPORT_GDI"]/*' />
    [NativeTypeName("#define LPD_SUPPORT_GDI 0x00000010")]
    public const int LPD_SUPPORT_GDI = 0x00000010;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SUPPORT_OPENGL"]/*' />
    [NativeTypeName("#define LPD_SUPPORT_OPENGL 0x00000020")]
    public const int LPD_SUPPORT_OPENGL = 0x00000020;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SHARE_DEPTH"]/*' />
    [NativeTypeName("#define LPD_SHARE_DEPTH 0x00000040")]
    public const int LPD_SHARE_DEPTH = 0x00000040;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SHARE_STENCIL"]/*' />
    [NativeTypeName("#define LPD_SHARE_STENCIL 0x00000080")]
    public const int LPD_SHARE_STENCIL = 0x00000080;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SHARE_ACCUM"]/*' />
    [NativeTypeName("#define LPD_SHARE_ACCUM 0x00000100")]
    public const int LPD_SHARE_ACCUM = 0x00000100;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SWAP_EXCHANGE"]/*' />
    [NativeTypeName("#define LPD_SWAP_EXCHANGE 0x00000200")]
    public const int LPD_SWAP_EXCHANGE = 0x00000200;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_SWAP_COPY"]/*' />
    [NativeTypeName("#define LPD_SWAP_COPY 0x00000400")]
    public const int LPD_SWAP_COPY = 0x00000400;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_TRANSPARENT"]/*' />
    [NativeTypeName("#define LPD_TRANSPARENT 0x00001000")]
    public const int LPD_TRANSPARENT = 0x00001000;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_TYPE_RGBA"]/*' />
    [NativeTypeName("#define LPD_TYPE_RGBA 0")]
    public const int LPD_TYPE_RGBA = 0;

    /// <include file='LPD.xml' path='doc/member[@name="LPD.LPD_TYPE_COLORINDEX"]/*' />
    [NativeTypeName("#define LPD_TYPE_COLORINDEX 1")]
    public const int LPD_TYPE_COLORINDEX = 1;
}
