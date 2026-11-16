// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CCS
{
    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_TOP"]/*' />
    [NativeTypeName("#define CCS_TOP 0x00000001L")]
    public const int CCS_TOP = 0x00000001;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_NOMOVEY"]/*' />
    [NativeTypeName("#define CCS_NOMOVEY 0x00000002L")]
    public const int CCS_NOMOVEY = 0x00000002;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_BOTTOM"]/*' />
    [NativeTypeName("#define CCS_BOTTOM 0x00000003L")]
    public const int CCS_BOTTOM = 0x00000003;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_NORESIZE"]/*' />
    [NativeTypeName("#define CCS_NORESIZE 0x00000004L")]
    public const int CCS_NORESIZE = 0x00000004;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_NOPARENTALIGN"]/*' />
    [NativeTypeName("#define CCS_NOPARENTALIGN 0x00000008L")]
    public const int CCS_NOPARENTALIGN = 0x00000008;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_ADJUSTABLE"]/*' />
    [NativeTypeName("#define CCS_ADJUSTABLE 0x00000020L")]
    public const int CCS_ADJUSTABLE = 0x00000020;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_NODIVIDER"]/*' />
    [NativeTypeName("#define CCS_NODIVIDER 0x00000040L")]
    public const int CCS_NODIVIDER = 0x00000040;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_VERT"]/*' />
    [NativeTypeName("#define CCS_VERT 0x00000080L")]
    public const int CCS_VERT = 0x00000080;

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_LEFT"]/*' />
    [NativeTypeName("#define CCS_LEFT (CCS_VERT | CCS_TOP)")]
    public const int CCS_LEFT = (0x00000080 | 0x00000001);

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_RIGHT"]/*' />
    [NativeTypeName("#define CCS_RIGHT (CCS_VERT | CCS_BOTTOM)")]
    public const int CCS_RIGHT = (0x00000080 | 0x00000003);

    /// <include file='CCS.xml' path='doc/member[@name="CCS.CCS_NOMOVEX"]/*' />
    [NativeTypeName("#define CCS_NOMOVEX (CCS_VERT | CCS_NOMOVEY)")]
    public const int CCS_NOMOVEX = (0x00000080 | 0x00000002);
}
