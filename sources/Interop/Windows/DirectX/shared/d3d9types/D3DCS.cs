// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCS
{
    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_LEFT"]/*' />
    [NativeTypeName("#define D3DCS_LEFT 0x00000001L")]
    public const int D3DCS_LEFT = 0x00000001;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_RIGHT"]/*' />
    [NativeTypeName("#define D3DCS_RIGHT 0x00000002L")]
    public const int D3DCS_RIGHT = 0x00000002;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_TOP"]/*' />
    [NativeTypeName("#define D3DCS_TOP 0x00000004L")]
    public const int D3DCS_TOP = 0x00000004;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_BOTTOM"]/*' />
    [NativeTypeName("#define D3DCS_BOTTOM 0x00000008L")]
    public const int D3DCS_BOTTOM = 0x00000008;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_FRONT"]/*' />
    [NativeTypeName("#define D3DCS_FRONT 0x00000010L")]
    public const int D3DCS_FRONT = 0x00000010;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_BACK"]/*' />
    [NativeTypeName("#define D3DCS_BACK 0x00000020L")]
    public const int D3DCS_BACK = 0x00000020;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE0"]/*' />
    [NativeTypeName("#define D3DCS_PLANE0 0x00000040L")]
    public const int D3DCS_PLANE0 = 0x00000040;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE1"]/*' />
    [NativeTypeName("#define D3DCS_PLANE1 0x00000080L")]
    public const int D3DCS_PLANE1 = 0x00000080;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE2"]/*' />
    [NativeTypeName("#define D3DCS_PLANE2 0x00000100L")]
    public const int D3DCS_PLANE2 = 0x00000100;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE3"]/*' />
    [NativeTypeName("#define D3DCS_PLANE3 0x00000200L")]
    public const int D3DCS_PLANE3 = 0x00000200;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE4"]/*' />
    [NativeTypeName("#define D3DCS_PLANE4 0x00000400L")]
    public const int D3DCS_PLANE4 = 0x00000400;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_PLANE5"]/*' />
    [NativeTypeName("#define D3DCS_PLANE5 0x00000800L")]
    public const int D3DCS_PLANE5 = 0x00000800;

    /// <include file='D3DCS.xml' path='doc/member[@name="D3DCS.D3DCS_ALL"]/*' />
    [NativeTypeName("#define D3DCS_ALL (D3DCS_LEFT   | \\\r\n                   D3DCS_RIGHT  | \\\r\n                   D3DCS_TOP    | \\\r\n                   D3DCS_BOTTOM | \\\r\n                   D3DCS_FRONT  | \\\r\n                   D3DCS_BACK   | \\\r\n                   D3DCS_PLANE0 | \\\r\n                   D3DCS_PLANE1 | \\\r\n                   D3DCS_PLANE2 | \\\r\n                   D3DCS_PLANE3 | \\\r\n                   D3DCS_PLANE4 | \\\r\n                   D3DCS_PLANE5)")]
    public const int D3DCS_ALL = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);
}
