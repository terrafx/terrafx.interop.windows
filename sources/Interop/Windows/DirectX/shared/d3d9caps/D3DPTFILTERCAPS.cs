// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPTFILTERCAPS
{
    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MINFPOINT"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFPOINT 0x00000100L")]
    public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MINFLINEAR"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFLINEAR 0x00000200L")]
    public const int D3DPTFILTERCAPS_MINFLINEAR = 0x00000200;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MINFANISOTROPIC"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFANISOTROPIC 0x00000400L")]
    public const int D3DPTFILTERCAPS_MINFANISOTROPIC = 0x00000400;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MINFPYRAMIDALQUAD"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFPYRAMIDALQUAD 0x00000800L")]
    public const int D3DPTFILTERCAPS_MINFPYRAMIDALQUAD = 0x00000800;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MINFGAUSSIANQUAD"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MINFGAUSSIANQUAD 0x00001000L")]
    public const int D3DPTFILTERCAPS_MINFGAUSSIANQUAD = 0x00001000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MIPFPOINT"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MIPFPOINT 0x00010000L")]
    public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MIPFLINEAR"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MIPFLINEAR 0x00020000L")]
    public const int D3DPTFILTERCAPS_MIPFLINEAR = 0x00020000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_CONVOLUTIONMONO"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_CONVOLUTIONMONO 0x00040000L")]
    public const int D3DPTFILTERCAPS_CONVOLUTIONMONO = 0x00040000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MAGFPOINT"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPOINT 0x01000000L")]
    public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MAGFLINEAR"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFLINEAR 0x02000000L")]
    public const int D3DPTFILTERCAPS_MAGFLINEAR = 0x02000000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MAGFANISOTROPIC"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFANISOTROPIC 0x04000000L")]
    public const int D3DPTFILTERCAPS_MAGFANISOTROPIC = 0x04000000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD 0x08000000L")]
    public const int D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD = 0x08000000;

    /// <include file='D3DPTFILTERCAPS.xml' path='doc/member[@name="D3DPTFILTERCAPS.D3DPTFILTERCAPS_MAGFGAUSSIANQUAD"]/*' />
    [NativeTypeName("#define D3DPTFILTERCAPS_MAGFGAUSSIANQUAD 0x10000000L")]
    public const int D3DPTFILTERCAPS_MAGFGAUSSIANQUAD = 0x10000000;
}
