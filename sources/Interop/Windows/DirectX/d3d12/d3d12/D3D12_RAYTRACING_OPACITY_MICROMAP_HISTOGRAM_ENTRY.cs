// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY"]/*' />
public partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY
{
    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.Count"]/*' />
    public uint Count;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.SubdivisionLevel"]/*' />
    public uint SubdivisionLevel;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY.Format"]/*' />
    public D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT Format;
}
