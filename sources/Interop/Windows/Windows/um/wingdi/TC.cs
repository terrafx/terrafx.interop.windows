// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TC
{
    /// <include file='TC.xml' path='doc/member[@name="TC.TC_OP_CHARACTER"]/*' />
    [NativeTypeName("#define TC_OP_CHARACTER 0x00000001")]
    public const int TC_OP_CHARACTER = 0x00000001;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_OP_STROKE"]/*' />
    [NativeTypeName("#define TC_OP_STROKE 0x00000002")]
    public const int TC_OP_STROKE = 0x00000002;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_CP_STROKE"]/*' />
    [NativeTypeName("#define TC_CP_STROKE 0x00000004")]
    public const int TC_CP_STROKE = 0x00000004;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_CR_90"]/*' />
    [NativeTypeName("#define TC_CR_90 0x00000008")]
    public const int TC_CR_90 = 0x00000008;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_CR_ANY"]/*' />
    [NativeTypeName("#define TC_CR_ANY 0x00000010")]
    public const int TC_CR_ANY = 0x00000010;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SF_X_YINDEP"]/*' />
    [NativeTypeName("#define TC_SF_X_YINDEP 0x00000020")]
    public const int TC_SF_X_YINDEP = 0x00000020;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SA_DOUBLE"]/*' />
    [NativeTypeName("#define TC_SA_DOUBLE 0x00000040")]
    public const int TC_SA_DOUBLE = 0x00000040;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SA_INTEGER"]/*' />
    [NativeTypeName("#define TC_SA_INTEGER 0x00000080")]
    public const int TC_SA_INTEGER = 0x00000080;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SA_CONTIN"]/*' />
    [NativeTypeName("#define TC_SA_CONTIN 0x00000100")]
    public const int TC_SA_CONTIN = 0x00000100;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_EA_DOUBLE"]/*' />
    [NativeTypeName("#define TC_EA_DOUBLE 0x00000200")]
    public const int TC_EA_DOUBLE = 0x00000200;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_IA_ABLE"]/*' />
    [NativeTypeName("#define TC_IA_ABLE 0x00000400")]
    public const int TC_IA_ABLE = 0x00000400;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_UA_ABLE"]/*' />
    [NativeTypeName("#define TC_UA_ABLE 0x00000800")]
    public const int TC_UA_ABLE = 0x00000800;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SO_ABLE"]/*' />
    [NativeTypeName("#define TC_SO_ABLE 0x00001000")]
    public const int TC_SO_ABLE = 0x00001000;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_RA_ABLE"]/*' />
    [NativeTypeName("#define TC_RA_ABLE 0x00002000")]
    public const int TC_RA_ABLE = 0x00002000;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_VA_ABLE"]/*' />
    [NativeTypeName("#define TC_VA_ABLE 0x00004000")]
    public const int TC_VA_ABLE = 0x00004000;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_RESERVED"]/*' />
    [NativeTypeName("#define TC_RESERVED 0x00008000")]
    public const int TC_RESERVED = 0x00008000;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_SCROLLBLT"]/*' />
    [NativeTypeName("#define TC_SCROLLBLT 0x00010000")]
    public const int TC_SCROLLBLT = 0x00010000;
}
