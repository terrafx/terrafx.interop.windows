// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PFD
{
    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_TYPE_RGBA"]/*' />
    [NativeTypeName("#define PFD_TYPE_RGBA 0")]
    public const int PFD_TYPE_RGBA = 0;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_TYPE_COLORINDEX"]/*' />
    [NativeTypeName("#define PFD_TYPE_COLORINDEX 1")]
    public const int PFD_TYPE_COLORINDEX = 1;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_MAIN_PLANE"]/*' />
    [NativeTypeName("#define PFD_MAIN_PLANE 0")]
    public const int PFD_MAIN_PLANE = 0;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_OVERLAY_PLANE"]/*' />
    [NativeTypeName("#define PFD_OVERLAY_PLANE 1")]
    public const int PFD_OVERLAY_PLANE = 1;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_UNDERLAY_PLANE"]/*' />
    [NativeTypeName("#define PFD_UNDERLAY_PLANE (-1)")]
    public const int PFD_UNDERLAY_PLANE = (-1);

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DOUBLEBUFFER"]/*' />
    [NativeTypeName("#define PFD_DOUBLEBUFFER 0x00000001")]
    public const int PFD_DOUBLEBUFFER = 0x00000001;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_STEREO"]/*' />
    [NativeTypeName("#define PFD_STEREO 0x00000002")]
    public const int PFD_STEREO = 0x00000002;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DRAW_TO_WINDOW"]/*' />
    [NativeTypeName("#define PFD_DRAW_TO_WINDOW 0x00000004")]
    public const int PFD_DRAW_TO_WINDOW = 0x00000004;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DRAW_TO_BITMAP"]/*' />
    [NativeTypeName("#define PFD_DRAW_TO_BITMAP 0x00000008")]
    public const int PFD_DRAW_TO_BITMAP = 0x00000008;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SUPPORT_GDI"]/*' />
    [NativeTypeName("#define PFD_SUPPORT_GDI 0x00000010")]
    public const int PFD_SUPPORT_GDI = 0x00000010;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SUPPORT_OPENGL"]/*' />
    [NativeTypeName("#define PFD_SUPPORT_OPENGL 0x00000020")]
    public const int PFD_SUPPORT_OPENGL = 0x00000020;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_GENERIC_FORMAT"]/*' />
    [NativeTypeName("#define PFD_GENERIC_FORMAT 0x00000040")]
    public const int PFD_GENERIC_FORMAT = 0x00000040;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_NEED_PALETTE"]/*' />
    [NativeTypeName("#define PFD_NEED_PALETTE 0x00000080")]
    public const int PFD_NEED_PALETTE = 0x00000080;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_NEED_SYSTEM_PALETTE"]/*' />
    [NativeTypeName("#define PFD_NEED_SYSTEM_PALETTE 0x00000100")]
    public const int PFD_NEED_SYSTEM_PALETTE = 0x00000100;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SWAP_EXCHANGE"]/*' />
    [NativeTypeName("#define PFD_SWAP_EXCHANGE 0x00000200")]
    public const int PFD_SWAP_EXCHANGE = 0x00000200;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SWAP_COPY"]/*' />
    [NativeTypeName("#define PFD_SWAP_COPY 0x00000400")]
    public const int PFD_SWAP_COPY = 0x00000400;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SWAP_LAYER_BUFFERS"]/*' />
    [NativeTypeName("#define PFD_SWAP_LAYER_BUFFERS 0x00000800")]
    public const int PFD_SWAP_LAYER_BUFFERS = 0x00000800;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_GENERIC_ACCELERATED"]/*' />
    [NativeTypeName("#define PFD_GENERIC_ACCELERATED 0x00001000")]
    public const int PFD_GENERIC_ACCELERATED = 0x00001000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SUPPORT_DIRECTDRAW"]/*' />
    [NativeTypeName("#define PFD_SUPPORT_DIRECTDRAW 0x00002000")]
    public const int PFD_SUPPORT_DIRECTDRAW = 0x00002000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DIRECT3D_ACCELERATED"]/*' />
    [NativeTypeName("#define PFD_DIRECT3D_ACCELERATED 0x00004000")]
    public const int PFD_DIRECT3D_ACCELERATED = 0x00004000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_SUPPORT_COMPOSITION"]/*' />
    [NativeTypeName("#define PFD_SUPPORT_COMPOSITION 0x00008000")]
    public const int PFD_SUPPORT_COMPOSITION = 0x00008000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DEPTH_DONTCARE"]/*' />
    [NativeTypeName("#define PFD_DEPTH_DONTCARE 0x20000000")]
    public const int PFD_DEPTH_DONTCARE = 0x20000000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_DOUBLEBUFFER_DONTCARE"]/*' />
    [NativeTypeName("#define PFD_DOUBLEBUFFER_DONTCARE 0x40000000")]
    public const int PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;

    /// <include file='PFD.xml' path='doc/member[@name="PFD.PFD_STEREO_DONTCARE"]/*' />
    [NativeTypeName("#define PFD_STEREO_DONTCARE 0x80000000")]
    public const uint PFD_STEREO_DONTCARE = 0x80000000;
}
