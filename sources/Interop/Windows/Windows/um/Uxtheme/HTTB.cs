// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HTTB
{
    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_BACKGROUNDSEG"]/*' />
    [NativeTypeName("#define HTTB_BACKGROUNDSEG 0x00000000")]
    public const int HTTB_BACKGROUNDSEG = 0x00000000;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_FIXEDBORDER"]/*' />
    [NativeTypeName("#define HTTB_FIXEDBORDER 0x00000002")]
    public const int HTTB_FIXEDBORDER = 0x00000002;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_CAPTION"]/*' />
    [NativeTypeName("#define HTTB_CAPTION 0x00000004")]
    public const int HTTB_CAPTION = 0x00000004;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_RESIZINGBORDER_LEFT"]/*' />
    [NativeTypeName("#define HTTB_RESIZINGBORDER_LEFT 0x00000010")]
    public const int HTTB_RESIZINGBORDER_LEFT = 0x00000010;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_RESIZINGBORDER_TOP"]/*' />
    [NativeTypeName("#define HTTB_RESIZINGBORDER_TOP 0x00000020")]
    public const int HTTB_RESIZINGBORDER_TOP = 0x00000020;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_RESIZINGBORDER_RIGHT"]/*' />
    [NativeTypeName("#define HTTB_RESIZINGBORDER_RIGHT 0x00000040")]
    public const int HTTB_RESIZINGBORDER_RIGHT = 0x00000040;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_RESIZINGBORDER_BOTTOM"]/*' />
    [NativeTypeName("#define HTTB_RESIZINGBORDER_BOTTOM 0x00000080")]
    public const int HTTB_RESIZINGBORDER_BOTTOM = 0x00000080;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_RESIZINGBORDER"]/*' />
    [NativeTypeName("#define HTTB_RESIZINGBORDER (HTTB_RESIZINGBORDER_LEFT | \\\r\n                                     HTTB_RESIZINGBORDER_TOP | \\\r\n                                     HTTB_RESIZINGBORDER_RIGHT | \\\r\n                                     HTTB_RESIZINGBORDER_BOTTOM)")]
    public const int HTTB_RESIZINGBORDER = (0x00000010 | 0x00000020 | 0x00000040 | 0x00000080);

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_SIZINGTEMPLATE"]/*' />
    [NativeTypeName("#define HTTB_SIZINGTEMPLATE 0x00000100")]
    public const int HTTB_SIZINGTEMPLATE = 0x00000100;

    /// <include file='HTTB.xml' path='doc/member[@name="HTTB.HTTB_SYSTEMSIZINGMARGINS"]/*' />
    [NativeTypeName("#define HTTB_SYSTEMSIZINGMARGINS 0x00000200")]
    public const int HTTB_SYSTEMSIZINGMARGINS = 0x00000200;
}
