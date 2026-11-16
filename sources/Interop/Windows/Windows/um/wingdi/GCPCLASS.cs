// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GCPCLASS
{
    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_LATIN"]/*' />
    [NativeTypeName("#define GCPCLASS_LATIN 1")]
    public const int GCPCLASS_LATIN = 1;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_HEBREW"]/*' />
    [NativeTypeName("#define GCPCLASS_HEBREW 2")]
    public const int GCPCLASS_HEBREW = 2;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_ARABIC"]/*' />
    [NativeTypeName("#define GCPCLASS_ARABIC 2")]
    public const int GCPCLASS_ARABIC = 2;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_NEUTRAL"]/*' />
    [NativeTypeName("#define GCPCLASS_NEUTRAL 3")]
    public const int GCPCLASS_NEUTRAL = 3;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_LOCALNUMBER"]/*' />
    [NativeTypeName("#define GCPCLASS_LOCALNUMBER 4")]
    public const int GCPCLASS_LOCALNUMBER = 4;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_LATINNUMBER"]/*' />
    [NativeTypeName("#define GCPCLASS_LATINNUMBER 5")]
    public const int GCPCLASS_LATINNUMBER = 5;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_LATINNUMERICTERMINATOR"]/*' />
    [NativeTypeName("#define GCPCLASS_LATINNUMERICTERMINATOR 6")]
    public const int GCPCLASS_LATINNUMERICTERMINATOR = 6;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_LATINNUMERICSEPARATOR"]/*' />
    [NativeTypeName("#define GCPCLASS_LATINNUMERICSEPARATOR 7")]
    public const int GCPCLASS_LATINNUMERICSEPARATOR = 7;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_NUMERICSEPARATOR"]/*' />
    [NativeTypeName("#define GCPCLASS_NUMERICSEPARATOR 8")]
    public const int GCPCLASS_NUMERICSEPARATOR = 8;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_PREBOUNDLTR"]/*' />
    [NativeTypeName("#define GCPCLASS_PREBOUNDLTR 0x80")]
    public const int GCPCLASS_PREBOUNDLTR = 0x80;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_PREBOUNDRTL"]/*' />
    [NativeTypeName("#define GCPCLASS_PREBOUNDRTL 0x40")]
    public const int GCPCLASS_PREBOUNDRTL = 0x40;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_POSTBOUNDLTR"]/*' />
    [NativeTypeName("#define GCPCLASS_POSTBOUNDLTR 0x20")]
    public const int GCPCLASS_POSTBOUNDLTR = 0x20;

    /// <include file='GCPCLASS.xml' path='doc/member[@name="GCPCLASS.GCPCLASS_POSTBOUNDRTL"]/*' />
    [NativeTypeName("#define GCPCLASS_POSTBOUNDRTL 0x10")]
    public const int GCPCLASS_POSTBOUNDRTL = 0x10;
}
