// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HDI
{
    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_WIDTH"]/*' />
    [NativeTypeName("#define HDI_WIDTH 0x0001")]
    public const int HDI_WIDTH = 0x0001;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_HEIGHT"]/*' />
    [NativeTypeName("#define HDI_HEIGHT HDI_WIDTH")]
    public const int HDI_HEIGHT = 0x0001;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_TEXT"]/*' />
    [NativeTypeName("#define HDI_TEXT 0x0002")]
    public const int HDI_TEXT = 0x0002;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_FORMAT"]/*' />
    [NativeTypeName("#define HDI_FORMAT 0x0004")]
    public const int HDI_FORMAT = 0x0004;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_LPARAM"]/*' />
    [NativeTypeName("#define HDI_LPARAM 0x0008")]
    public const int HDI_LPARAM = 0x0008;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_BITMAP"]/*' />
    [NativeTypeName("#define HDI_BITMAP 0x0010")]
    public const int HDI_BITMAP = 0x0010;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_IMAGE"]/*' />
    [NativeTypeName("#define HDI_IMAGE 0x0020")]
    public const int HDI_IMAGE = 0x0020;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_DI_SETITEM"]/*' />
    [NativeTypeName("#define HDI_DI_SETITEM 0x0040")]
    public const int HDI_DI_SETITEM = 0x0040;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_ORDER"]/*' />
    [NativeTypeName("#define HDI_ORDER 0x0080")]
    public const int HDI_ORDER = 0x0080;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_FILTER"]/*' />
    [NativeTypeName("#define HDI_FILTER 0x0100")]
    public const int HDI_FILTER = 0x0100;

    /// <include file='HDI.xml' path='doc/member[@name="HDI.HDI_STATE"]/*' />
    [NativeTypeName("#define HDI_STATE 0x0200")]
    public const int HDI_STATE = 0x0200;
}
