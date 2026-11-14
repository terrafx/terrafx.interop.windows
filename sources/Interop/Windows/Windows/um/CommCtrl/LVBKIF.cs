// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVBKIF
{
    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_SOURCE_NONE"]/*' />
    [NativeTypeName("#define LVBKIF_SOURCE_NONE 0x00000000")]
    public const int LVBKIF_SOURCE_NONE = 0x00000000;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_SOURCE_HBITMAP"]/*' />
    [NativeTypeName("#define LVBKIF_SOURCE_HBITMAP 0x00000001")]
    public const int LVBKIF_SOURCE_HBITMAP = 0x00000001;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_SOURCE_URL"]/*' />
    [NativeTypeName("#define LVBKIF_SOURCE_URL 0x00000002")]
    public const int LVBKIF_SOURCE_URL = 0x00000002;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_SOURCE_MASK"]/*' />
    [NativeTypeName("#define LVBKIF_SOURCE_MASK 0x00000003")]
    public const int LVBKIF_SOURCE_MASK = 0x00000003;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_STYLE_NORMAL"]/*' />
    [NativeTypeName("#define LVBKIF_STYLE_NORMAL 0x00000000")]
    public const int LVBKIF_STYLE_NORMAL = 0x00000000;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_STYLE_TILE"]/*' />
    [NativeTypeName("#define LVBKIF_STYLE_TILE 0x00000010")]
    public const int LVBKIF_STYLE_TILE = 0x00000010;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_STYLE_MASK"]/*' />
    [NativeTypeName("#define LVBKIF_STYLE_MASK 0x00000010")]
    public const int LVBKIF_STYLE_MASK = 0x00000010;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_FLAG_TILEOFFSET"]/*' />
    [NativeTypeName("#define LVBKIF_FLAG_TILEOFFSET 0x00000100")]
    public const int LVBKIF_FLAG_TILEOFFSET = 0x00000100;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_TYPE_WATERMARK"]/*' />
    [NativeTypeName("#define LVBKIF_TYPE_WATERMARK 0x10000000")]
    public const int LVBKIF_TYPE_WATERMARK = 0x10000000;

    /// <include file='LVBKIF.xml' path='doc/member[@name="LVBKIF.LVBKIF_FLAG_ALPHABLEND"]/*' />
    [NativeTypeName("#define LVBKIF_FLAG_ALPHABLEND 0x20000000")]
    public const int LVBKIF_FLAG_ALPHABLEND = 0x20000000;
}
