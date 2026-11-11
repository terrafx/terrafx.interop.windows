// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WGL
{
    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_FONT_LINES"]/*' />
    [NativeTypeName("#define WGL_FONT_LINES 0")]
    public const int WGL_FONT_LINES = 0;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_FONT_POLYGONS"]/*' />
    [NativeTypeName("#define WGL_FONT_POLYGONS 1")]
    public const int WGL_FONT_POLYGONS = 1;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_MAIN_PLANE"]/*' />
    [NativeTypeName("#define WGL_SWAP_MAIN_PLANE 0x00000001")]
    public const int WGL_SWAP_MAIN_PLANE = 0x00000001;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY1"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY1 0x00000002")]
    public const int WGL_SWAP_OVERLAY1 = 0x00000002;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY2"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY2 0x00000004")]
    public const int WGL_SWAP_OVERLAY2 = 0x00000004;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY3"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY3 0x00000008")]
    public const int WGL_SWAP_OVERLAY3 = 0x00000008;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY4"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY4 0x00000010")]
    public const int WGL_SWAP_OVERLAY4 = 0x00000010;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY5"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY5 0x00000020")]
    public const int WGL_SWAP_OVERLAY5 = 0x00000020;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY6"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY6 0x00000040")]
    public const int WGL_SWAP_OVERLAY6 = 0x00000040;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY7"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY7 0x00000080")]
    public const int WGL_SWAP_OVERLAY7 = 0x00000080;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY8"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY8 0x00000100")]
    public const int WGL_SWAP_OVERLAY8 = 0x00000100;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY9"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY9 0x00000200")]
    public const int WGL_SWAP_OVERLAY9 = 0x00000200;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY10"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY10 0x00000400")]
    public const int WGL_SWAP_OVERLAY10 = 0x00000400;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY11"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY11 0x00000800")]
    public const int WGL_SWAP_OVERLAY11 = 0x00000800;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY12"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY12 0x00001000")]
    public const int WGL_SWAP_OVERLAY12 = 0x00001000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY13"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY13 0x00002000")]
    public const int WGL_SWAP_OVERLAY13 = 0x00002000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY14"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY14 0x00004000")]
    public const int WGL_SWAP_OVERLAY14 = 0x00004000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_OVERLAY15"]/*' />
    [NativeTypeName("#define WGL_SWAP_OVERLAY15 0x00008000")]
    public const int WGL_SWAP_OVERLAY15 = 0x00008000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY1"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY1 0x00010000")]
    public const int WGL_SWAP_UNDERLAY1 = 0x00010000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY2"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY2 0x00020000")]
    public const int WGL_SWAP_UNDERLAY2 = 0x00020000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY3"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY3 0x00040000")]
    public const int WGL_SWAP_UNDERLAY3 = 0x00040000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY4"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY4 0x00080000")]
    public const int WGL_SWAP_UNDERLAY4 = 0x00080000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY5"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY5 0x00100000")]
    public const int WGL_SWAP_UNDERLAY5 = 0x00100000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY6"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY6 0x00200000")]
    public const int WGL_SWAP_UNDERLAY6 = 0x00200000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY7"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY7 0x00400000")]
    public const int WGL_SWAP_UNDERLAY7 = 0x00400000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY8"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY8 0x00800000")]
    public const int WGL_SWAP_UNDERLAY8 = 0x00800000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY9"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY9 0x01000000")]
    public const int WGL_SWAP_UNDERLAY9 = 0x01000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY10"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY10 0x02000000")]
    public const int WGL_SWAP_UNDERLAY10 = 0x02000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY11"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY11 0x04000000")]
    public const int WGL_SWAP_UNDERLAY11 = 0x04000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY12"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY12 0x08000000")]
    public const int WGL_SWAP_UNDERLAY12 = 0x08000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY13"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY13 0x10000000")]
    public const int WGL_SWAP_UNDERLAY13 = 0x10000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY14"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY14 0x20000000")]
    public const int WGL_SWAP_UNDERLAY14 = 0x20000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAP_UNDERLAY15"]/*' />
    [NativeTypeName("#define WGL_SWAP_UNDERLAY15 0x40000000")]
    public const int WGL_SWAP_UNDERLAY15 = 0x40000000;

    /// <include file='WGL.xml' path='doc/member[@name="WGL.WGL_SWAPMULTIPLE_MAX"]/*' />
    [NativeTypeName("#define WGL_SWAPMULTIPLE_MAX 16")]
    public const int WGL_SWAPMULTIPLE_MAX = 16;
}
