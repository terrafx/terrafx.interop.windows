// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CC
{
    /// <include file='CC.xml' path='doc/member[@name="CC.CC_NONE"]/*' />
    [NativeTypeName("#define CC_NONE 0")]
    public const int CC_NONE = 0;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_CIRCLES"]/*' />
    [NativeTypeName("#define CC_CIRCLES 1")]
    public const int CC_CIRCLES = 1;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_PIE"]/*' />
    [NativeTypeName("#define CC_PIE 2")]
    public const int CC_PIE = 2;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_CHORD"]/*' />
    [NativeTypeName("#define CC_CHORD 4")]
    public const int CC_CHORD = 4;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_ELLIPSES"]/*' />
    [NativeTypeName("#define CC_ELLIPSES 8")]
    public const int CC_ELLIPSES = 8;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_WIDE"]/*' />
    [NativeTypeName("#define CC_WIDE 16")]
    public const int CC_WIDE = 16;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_STYLED"]/*' />
    [NativeTypeName("#define CC_STYLED 32")]
    public const int CC_STYLED = 32;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_WIDESTYLED"]/*' />
    [NativeTypeName("#define CC_WIDESTYLED 64")]
    public const int CC_WIDESTYLED = 64;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_INTERIORS"]/*' />
    [NativeTypeName("#define CC_INTERIORS 128")]
    public const int CC_INTERIORS = 128;

    /// <include file='CC.xml' path='doc/member[@name="CC.CC_ROUNDRECT"]/*' />
    [NativeTypeName("#define CC_ROUNDRECT 256")]
    public const int CC_ROUNDRECT = 256;
}
