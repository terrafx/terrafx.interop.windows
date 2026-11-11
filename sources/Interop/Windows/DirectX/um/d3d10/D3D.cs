// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D
{
    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_MAJOR_VERSION"]/*' />
    [NativeTypeName("#define D3D_MAJOR_VERSION ( 10 )")]
    public const int D3D_MAJOR_VERSION = (10);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_MINOR_VERSION"]/*' />
    [NativeTypeName("#define D3D_MINOR_VERSION ( 0 )")]
    public const int D3D_MINOR_VERSION = (0);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SPEC_DATE_DAY"]/*' />
    [NativeTypeName("#define D3D_SPEC_DATE_DAY ( 8 )")]
    public const int D3D_SPEC_DATE_DAY = (8);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SPEC_DATE_MONTH"]/*' />
    [NativeTypeName("#define D3D_SPEC_DATE_MONTH ( 8 )")]
    public const int D3D_SPEC_DATE_MONTH = (8);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SPEC_DATE_YEAR"]/*' />
    [NativeTypeName("#define D3D_SPEC_DATE_YEAR ( 2006 )")]
    public const int D3D_SPEC_DATE_YEAR = (2006);

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_SPEC_VERSION"]/*' />
    [NativeTypeName("#define D3D_SPEC_VERSION ( 1.050005 )")]
    public const double D3D_SPEC_VERSION = (1.050005);
}
