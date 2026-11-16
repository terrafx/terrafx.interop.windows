// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IMC
{
    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETCANDIDATEPOS"]/*' />
    [NativeTypeName("#define IMC_GETCANDIDATEPOS 0x0007")]
    public const int IMC_GETCANDIDATEPOS = 0x0007;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETCANDIDATEPOS"]/*' />
    [NativeTypeName("#define IMC_SETCANDIDATEPOS 0x0008")]
    public const int IMC_SETCANDIDATEPOS = 0x0008;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETCOMPOSITIONFONT"]/*' />
    [NativeTypeName("#define IMC_GETCOMPOSITIONFONT 0x0009")]
    public const int IMC_GETCOMPOSITIONFONT = 0x0009;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETCOMPOSITIONFONT"]/*' />
    [NativeTypeName("#define IMC_SETCOMPOSITIONFONT 0x000A")]
    public const int IMC_SETCOMPOSITIONFONT = 0x000A;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETCOMPOSITIONWINDOW"]/*' />
    [NativeTypeName("#define IMC_GETCOMPOSITIONWINDOW 0x000B")]
    public const int IMC_GETCOMPOSITIONWINDOW = 0x000B;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETCOMPOSITIONWINDOW"]/*' />
    [NativeTypeName("#define IMC_SETCOMPOSITIONWINDOW 0x000C")]
    public const int IMC_SETCOMPOSITIONWINDOW = 0x000C;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETSTATUSWINDOWPOS"]/*' />
    [NativeTypeName("#define IMC_GETSTATUSWINDOWPOS 0x000F")]
    public const int IMC_GETSTATUSWINDOWPOS = 0x000F;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSTATUSWINDOWPOS"]/*' />
    [NativeTypeName("#define IMC_SETSTATUSWINDOWPOS 0x0010")]
    public const int IMC_SETSTATUSWINDOWPOS = 0x0010;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_CLOSESTATUSWINDOW"]/*' />
    [NativeTypeName("#define IMC_CLOSESTATUSWINDOW 0x0021")]
    public const int IMC_CLOSESTATUSWINDOW = 0x0021;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_OPENSTATUSWINDOW"]/*' />
    [NativeTypeName("#define IMC_OPENSTATUSWINDOW 0x0022")]
    public const int IMC_OPENSTATUSWINDOW = 0x0022;
}
