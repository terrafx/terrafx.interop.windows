// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DMBIN
{
    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_FIRST"]/*' />
    [NativeTypeName("#define DMBIN_FIRST DMBIN_UPPER")]
    public const int DMBIN_FIRST = 1;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_UPPER"]/*' />
    [NativeTypeName("#define DMBIN_UPPER 1")]
    public const int DMBIN_UPPER = 1;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_ONLYONE"]/*' />
    [NativeTypeName("#define DMBIN_ONLYONE 1")]
    public const int DMBIN_ONLYONE = 1;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_LOWER"]/*' />
    [NativeTypeName("#define DMBIN_LOWER 2")]
    public const int DMBIN_LOWER = 2;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_MIDDLE"]/*' />
    [NativeTypeName("#define DMBIN_MIDDLE 3")]
    public const int DMBIN_MIDDLE = 3;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_MANUAL"]/*' />
    [NativeTypeName("#define DMBIN_MANUAL 4")]
    public const int DMBIN_MANUAL = 4;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_ENVELOPE"]/*' />
    [NativeTypeName("#define DMBIN_ENVELOPE 5")]
    public const int DMBIN_ENVELOPE = 5;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_ENVMANUAL"]/*' />
    [NativeTypeName("#define DMBIN_ENVMANUAL 6")]
    public const int DMBIN_ENVMANUAL = 6;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_AUTO"]/*' />
    [NativeTypeName("#define DMBIN_AUTO 7")]
    public const int DMBIN_AUTO = 7;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_TRACTOR"]/*' />
    [NativeTypeName("#define DMBIN_TRACTOR 8")]
    public const int DMBIN_TRACTOR = 8;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_SMALLFMT"]/*' />
    [NativeTypeName("#define DMBIN_SMALLFMT 9")]
    public const int DMBIN_SMALLFMT = 9;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_LARGEFMT"]/*' />
    [NativeTypeName("#define DMBIN_LARGEFMT 10")]
    public const int DMBIN_LARGEFMT = 10;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_LARGECAPACITY"]/*' />
    [NativeTypeName("#define DMBIN_LARGECAPACITY 11")]
    public const int DMBIN_LARGECAPACITY = 11;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_CASSETTE"]/*' />
    [NativeTypeName("#define DMBIN_CASSETTE 14")]
    public const int DMBIN_CASSETTE = 14;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_FORMSOURCE"]/*' />
    [NativeTypeName("#define DMBIN_FORMSOURCE 15")]
    public const int DMBIN_FORMSOURCE = 15;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_LAST"]/*' />
    [NativeTypeName("#define DMBIN_LAST DMBIN_FORMSOURCE")]
    public const int DMBIN_LAST = 15;

    /// <include file='DMBIN.xml' path='doc/member[@name="DMBIN.DMBIN_USER"]/*' />
    [NativeTypeName("#define DMBIN_USER 256")]
    public const int DMBIN_USER = 256;
}
