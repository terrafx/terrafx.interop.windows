// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GCS
{
    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPREADSTR"]/*' />
    [NativeTypeName("#define GCS_COMPREADSTR 0x0001")]
    public const int GCS_COMPREADSTR = 0x0001;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPREADATTR"]/*' />
    [NativeTypeName("#define GCS_COMPREADATTR 0x0002")]
    public const int GCS_COMPREADATTR = 0x0002;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPREADCLAUSE"]/*' />
    [NativeTypeName("#define GCS_COMPREADCLAUSE 0x0004")]
    public const int GCS_COMPREADCLAUSE = 0x0004;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPSTR"]/*' />
    [NativeTypeName("#define GCS_COMPSTR 0x0008")]
    public const int GCS_COMPSTR = 0x0008;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPATTR"]/*' />
    [NativeTypeName("#define GCS_COMPATTR 0x0010")]
    public const int GCS_COMPATTR = 0x0010;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_COMPCLAUSE"]/*' />
    [NativeTypeName("#define GCS_COMPCLAUSE 0x0020")]
    public const int GCS_COMPCLAUSE = 0x0020;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_CURSORPOS"]/*' />
    [NativeTypeName("#define GCS_CURSORPOS 0x0080")]
    public const int GCS_CURSORPOS = 0x0080;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_DELTASTART"]/*' />
    [NativeTypeName("#define GCS_DELTASTART 0x0100")]
    public const int GCS_DELTASTART = 0x0100;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_RESULTREADSTR"]/*' />
    [NativeTypeName("#define GCS_RESULTREADSTR 0x0200")]
    public const int GCS_RESULTREADSTR = 0x0200;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_RESULTREADCLAUSE"]/*' />
    [NativeTypeName("#define GCS_RESULTREADCLAUSE 0x0400")]
    public const int GCS_RESULTREADCLAUSE = 0x0400;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_RESULTSTR"]/*' />
    [NativeTypeName("#define GCS_RESULTSTR 0x0800")]
    public const int GCS_RESULTSTR = 0x0800;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_RESULTCLAUSE"]/*' />
    [NativeTypeName("#define GCS_RESULTCLAUSE 0x1000")]
    public const int GCS_RESULTCLAUSE = 0x1000;
}
