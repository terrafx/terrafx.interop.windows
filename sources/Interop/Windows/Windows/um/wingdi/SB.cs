// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SB
{
    /// <include file='SB.xml' path='doc/member[@name="SB.SB_NONE"]/*' />
    [NativeTypeName("#define SB_NONE 0x00000000")]
    public const int SB_NONE = 0x00000000;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_CONST_ALPHA"]/*' />
    [NativeTypeName("#define SB_CONST_ALPHA 0x00000001")]
    public const int SB_CONST_ALPHA = 0x00000001;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PIXEL_ALPHA"]/*' />
    [NativeTypeName("#define SB_PIXEL_ALPHA 0x00000002")]
    public const int SB_PIXEL_ALPHA = 0x00000002;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_PREMULT_ALPHA"]/*' />
    [NativeTypeName("#define SB_PREMULT_ALPHA 0x00000004")]
    public const int SB_PREMULT_ALPHA = 0x00000004;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GRAD_RECT"]/*' />
    [NativeTypeName("#define SB_GRAD_RECT 0x00000010")]
    public const int SB_GRAD_RECT = 0x00000010;

    /// <include file='SB.xml' path='doc/member[@name="SB.SB_GRAD_TRI"]/*' />
    [NativeTypeName("#define SB_GRAD_TRI 0x00000020")]
    public const int SB_GRAD_TRI = 0x00000020;
}
