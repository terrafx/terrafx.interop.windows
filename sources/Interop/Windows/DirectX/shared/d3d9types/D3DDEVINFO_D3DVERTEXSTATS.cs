// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS"]/*' />
public partial struct D3DDEVINFO_D3DVERTEXSTATS
{
    /// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS.NumRenderedTriangles"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumRenderedTriangles;

    /// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS.NumExtraClippingTriangles"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumExtraClippingTriangles;
}
