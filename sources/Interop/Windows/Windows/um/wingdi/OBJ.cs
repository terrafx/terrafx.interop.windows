// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OBJ
{
    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_PEN"]/*' />
    [NativeTypeName("#define OBJ_PEN 1")]
    public const int OBJ_PEN = 1;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_BRUSH"]/*' />
    [NativeTypeName("#define OBJ_BRUSH 2")]
    public const int OBJ_BRUSH = 2;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_DC"]/*' />
    [NativeTypeName("#define OBJ_DC 3")]
    public const int OBJ_DC = 3;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_METADC"]/*' />
    [NativeTypeName("#define OBJ_METADC 4")]
    public const int OBJ_METADC = 4;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_PAL"]/*' />
    [NativeTypeName("#define OBJ_PAL 5")]
    public const int OBJ_PAL = 5;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_FONT"]/*' />
    [NativeTypeName("#define OBJ_FONT 6")]
    public const int OBJ_FONT = 6;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_BITMAP"]/*' />
    [NativeTypeName("#define OBJ_BITMAP 7")]
    public const int OBJ_BITMAP = 7;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_REGION"]/*' />
    [NativeTypeName("#define OBJ_REGION 8")]
    public const int OBJ_REGION = 8;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_METAFILE"]/*' />
    [NativeTypeName("#define OBJ_METAFILE 9")]
    public const int OBJ_METAFILE = 9;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_MEMDC"]/*' />
    [NativeTypeName("#define OBJ_MEMDC 10")]
    public const int OBJ_MEMDC = 10;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_EXTPEN"]/*' />
    [NativeTypeName("#define OBJ_EXTPEN 11")]
    public const int OBJ_EXTPEN = 11;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_ENHMETADC"]/*' />
    [NativeTypeName("#define OBJ_ENHMETADC 12")]
    public const int OBJ_ENHMETADC = 12;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_ENHMETAFILE"]/*' />
    [NativeTypeName("#define OBJ_ENHMETAFILE 13")]
    public const int OBJ_ENHMETAFILE = 13;

    /// <include file='OBJ.xml' path='doc/member[@name="OBJ.OBJ_COLORSPACE"]/*' />
    [NativeTypeName("#define OBJ_COLORSPACE 14")]
    public const int OBJ_COLORSPACE = 14;
}
