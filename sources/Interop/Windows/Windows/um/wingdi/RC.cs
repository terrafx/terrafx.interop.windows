// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RC
{
    /// <include file='RC.xml' path='doc/member[@name="RC.RC_BITBLT"]/*' />
    [NativeTypeName("#define RC_BITBLT 1")]
    public const int RC_BITBLT = 1;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_BANDING"]/*' />
    [NativeTypeName("#define RC_BANDING 2")]
    public const int RC_BANDING = 2;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_SCALING"]/*' />
    [NativeTypeName("#define RC_SCALING 4")]
    public const int RC_SCALING = 4;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_BITMAP64"]/*' />
    [NativeTypeName("#define RC_BITMAP64 8")]
    public const int RC_BITMAP64 = 8;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_GDI20_OUTPUT"]/*' />
    [NativeTypeName("#define RC_GDI20_OUTPUT 0x0010")]
    public const int RC_GDI20_OUTPUT = 0x0010;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_GDI20_STATE"]/*' />
    [NativeTypeName("#define RC_GDI20_STATE 0x0020")]
    public const int RC_GDI20_STATE = 0x0020;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_SAVEBITMAP"]/*' />
    [NativeTypeName("#define RC_SAVEBITMAP 0x0040")]
    public const int RC_SAVEBITMAP = 0x0040;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_DI_BITMAP"]/*' />
    [NativeTypeName("#define RC_DI_BITMAP 0x0080")]
    public const int RC_DI_BITMAP = 0x0080;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_PALETTE"]/*' />
    [NativeTypeName("#define RC_PALETTE 0x0100")]
    public const int RC_PALETTE = 0x0100;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_DIBTODEV"]/*' />
    [NativeTypeName("#define RC_DIBTODEV 0x0200")]
    public const int RC_DIBTODEV = 0x0200;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_BIGFONT"]/*' />
    [NativeTypeName("#define RC_BIGFONT 0x0400")]
    public const int RC_BIGFONT = 0x0400;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_STRETCHBLT"]/*' />
    [NativeTypeName("#define RC_STRETCHBLT 0x0800")]
    public const int RC_STRETCHBLT = 0x0800;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_FLOODFILL"]/*' />
    [NativeTypeName("#define RC_FLOODFILL 0x1000")]
    public const int RC_FLOODFILL = 0x1000;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_STRETCHDIB"]/*' />
    [NativeTypeName("#define RC_STRETCHDIB 0x2000")]
    public const int RC_STRETCHDIB = 0x2000;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_OP_DX_OUTPUT"]/*' />
    [NativeTypeName("#define RC_OP_DX_OUTPUT 0x4000")]
    public const int RC_OP_DX_OUTPUT = 0x4000;

    /// <include file='RC.xml' path='doc/member[@name="RC.RC_DEVBITS"]/*' />
    [NativeTypeName("#define RC_DEVBITS 0x8000")]
    public const int RC_DEVBITS = 0x8000;
}
