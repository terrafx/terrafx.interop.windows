// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OUT
{
    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_DEFAULT_PRECIS"]/*' />
    [NativeTypeName("#define OUT_DEFAULT_PRECIS 0")]
    public const int OUT_DEFAULT_PRECIS = 0;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_STRING_PRECIS"]/*' />
    [NativeTypeName("#define OUT_STRING_PRECIS 1")]
    public const int OUT_STRING_PRECIS = 1;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_CHARACTER_PRECIS"]/*' />
    [NativeTypeName("#define OUT_CHARACTER_PRECIS 2")]
    public const int OUT_CHARACTER_PRECIS = 2;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_STROKE_PRECIS"]/*' />
    [NativeTypeName("#define OUT_STROKE_PRECIS 3")]
    public const int OUT_STROKE_PRECIS = 3;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_TT_PRECIS"]/*' />
    [NativeTypeName("#define OUT_TT_PRECIS 4")]
    public const int OUT_TT_PRECIS = 4;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_DEVICE_PRECIS"]/*' />
    [NativeTypeName("#define OUT_DEVICE_PRECIS 5")]
    public const int OUT_DEVICE_PRECIS = 5;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_RASTER_PRECIS"]/*' />
    [NativeTypeName("#define OUT_RASTER_PRECIS 6")]
    public const int OUT_RASTER_PRECIS = 6;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_TT_ONLY_PRECIS"]/*' />
    [NativeTypeName("#define OUT_TT_ONLY_PRECIS 7")]
    public const int OUT_TT_ONLY_PRECIS = 7;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_OUTLINE_PRECIS"]/*' />
    [NativeTypeName("#define OUT_OUTLINE_PRECIS 8")]
    public const int OUT_OUTLINE_PRECIS = 8;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_SCREEN_OUTLINE_PRECIS"]/*' />
    [NativeTypeName("#define OUT_SCREEN_OUTLINE_PRECIS 9")]
    public const int OUT_SCREEN_OUTLINE_PRECIS = 9;

    /// <include file='OUT.xml' path='doc/member[@name="OUT.OUT_PS_ONLY_PRECIS"]/*' />
    [NativeTypeName("#define OUT_PS_ONLY_PRECIS 10")]
    public const int OUT_PS_ONLY_PRECIS = 10;
}
