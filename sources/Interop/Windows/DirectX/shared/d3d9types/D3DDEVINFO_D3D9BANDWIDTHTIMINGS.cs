// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS"]/*' />
public partial struct D3DDEVINFO_D3D9BANDWIDTHTIMINGS
{
    /// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS.MaxBandwidthUtilized"]/*' />
    public float MaxBandwidthUtilized;

    /// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS.FrontEndUploadMemoryUtilizedPercent"]/*' />
    public float FrontEndUploadMemoryUtilizedPercent;

    /// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS.VertexRateUtilizedPercent"]/*' />
    public float VertexRateUtilizedPercent;

    /// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS.TriangleSetupRateUtilizedPercent"]/*' />
    public float TriangleSetupRateUtilizedPercent;

    /// <include file='D3DDEVINFO_D3D9BANDWIDTHTIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9BANDWIDTHTIMINGS.FillRateUtilizedPercent"]/*' />
    public float FillRateUtilizedPercent;
}
