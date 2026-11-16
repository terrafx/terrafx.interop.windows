// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IN
{
    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSA_NET"]/*' />
    [NativeTypeName("#define IN_CLASSA_NET 0xff000000")]
    public const uint IN_CLASSA_NET = 0xff000000;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSA_NSHIFT"]/*' />
    [NativeTypeName("#define IN_CLASSA_NSHIFT 24")]
    public const int IN_CLASSA_NSHIFT = 24;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSA_HOST"]/*' />
    [NativeTypeName("#define IN_CLASSA_HOST 0x00ffffff")]
    public const int IN_CLASSA_HOST = 0x00ffffff;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSA_MAX"]/*' />
    [NativeTypeName("#define IN_CLASSA_MAX 128")]
    public const int IN_CLASSA_MAX = 128;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSB_NET"]/*' />
    [NativeTypeName("#define IN_CLASSB_NET 0xffff0000")]
    public const uint IN_CLASSB_NET = 0xffff0000;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSB_NSHIFT"]/*' />
    [NativeTypeName("#define IN_CLASSB_NSHIFT 16")]
    public const int IN_CLASSB_NSHIFT = 16;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSB_HOST"]/*' />
    [NativeTypeName("#define IN_CLASSB_HOST 0x0000ffff")]
    public const int IN_CLASSB_HOST = 0x0000ffff;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSB_MAX"]/*' />
    [NativeTypeName("#define IN_CLASSB_MAX 65536")]
    public const int IN_CLASSB_MAX = 65536;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSC_NET"]/*' />
    [NativeTypeName("#define IN_CLASSC_NET 0xffffff00")]
    public const uint IN_CLASSC_NET = 0xffffff00;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSC_NSHIFT"]/*' />
    [NativeTypeName("#define IN_CLASSC_NSHIFT 8")]
    public const int IN_CLASSC_NSHIFT = 8;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSC_HOST"]/*' />
    [NativeTypeName("#define IN_CLASSC_HOST 0x000000ff")]
    public const int IN_CLASSC_HOST = 0x000000ff;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSD_NET"]/*' />
    [NativeTypeName("#define IN_CLASSD_NET 0xf0000000")]
    public const uint IN_CLASSD_NET = 0xf0000000;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSD_NSHIFT"]/*' />
    [NativeTypeName("#define IN_CLASSD_NSHIFT 28")]
    public const int IN_CLASSD_NSHIFT = 28;

    /// <include file='IN.xml' path='doc/member[@name="IN.IN_CLASSD_HOST"]/*' />
    [NativeTypeName("#define IN_CLASSD_HOST 0x0fffffff")]
    public const int IN_CLASSD_HOST = 0x0fffffff;
}
