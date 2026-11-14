// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DTSS_TCI
{
    /// <include file='D3DTSS_TCI.xml' path='doc/member[@name="D3DTSS_TCI.D3DTSS_TCI_PASSTHRU"]/*' />
    [NativeTypeName("#define D3DTSS_TCI_PASSTHRU 0x00000000")]
    public const int D3DTSS_TCI_PASSTHRU = 0x00000000;

    /// <include file='D3DTSS_TCI.xml' path='doc/member[@name="D3DTSS_TCI.D3DTSS_TCI_CAMERASPACENORMAL"]/*' />
    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACENORMAL 0x00010000")]
    public const int D3DTSS_TCI_CAMERASPACENORMAL = 0x00010000;

    /// <include file='D3DTSS_TCI.xml' path='doc/member[@name="D3DTSS_TCI.D3DTSS_TCI_CAMERASPACEPOSITION"]/*' />
    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEPOSITION 0x00020000")]
    public const int D3DTSS_TCI_CAMERASPACEPOSITION = 0x00020000;

    /// <include file='D3DTSS_TCI.xml' path='doc/member[@name="D3DTSS_TCI.D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR"]/*' />
    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR 0x00030000")]
    public const int D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR = 0x00030000;

    /// <include file='D3DTSS_TCI.xml' path='doc/member[@name="D3DTSS_TCI.D3DTSS_TCI_SPHEREMAP"]/*' />
    [NativeTypeName("#define D3DTSS_TCI_SPHEREMAP 0x00040000")]
    public const int D3DTSS_TCI_SPHEREMAP = 0x00040000;
}
