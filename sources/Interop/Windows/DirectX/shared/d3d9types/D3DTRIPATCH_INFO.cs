// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DTRIPATCH_INFO.xml' path='doc/member[@name="D3DTRIPATCH_INFO"]/*' />
public partial struct D3DTRIPATCH_INFO
{
    /// <include file='D3DTRIPATCH_INFO.xml' path='doc/member[@name="D3DTRIPATCH_INFO.StartVertexOffset"]/*' />
    public uint StartVertexOffset;

    /// <include file='D3DTRIPATCH_INFO.xml' path='doc/member[@name="D3DTRIPATCH_INFO.NumVertices"]/*' />
    public uint NumVertices;

    /// <include file='D3DTRIPATCH_INFO.xml' path='doc/member[@name="D3DTRIPATCH_INFO.Basis"]/*' />
    public D3DBASISTYPE Basis;

    /// <include file='D3DTRIPATCH_INFO.xml' path='doc/member[@name="D3DTRIPATCH_INFO.Degree"]/*' />
    public D3DDEGREETYPE Degree;
}
