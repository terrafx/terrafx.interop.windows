// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC"]/*' />
public unsafe partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC
{
    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.NumOmmHistogramEntries"]/*' />
    public uint NumOmmHistogramEntries;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.pOmmHistogram"]/*' />
    [NativeTypeName("const D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY *")]
    public D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY* pOmmHistogram;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.InputBuffer"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong InputBuffer;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC.PerOmmDescs"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE PerOmmDescs;
}
