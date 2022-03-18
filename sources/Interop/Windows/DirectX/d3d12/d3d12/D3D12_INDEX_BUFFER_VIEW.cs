// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW"]/*' />
public partial struct D3D12_INDEX_BUFFER_VIEW
{
    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.BufferLocation"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong BufferLocation;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.SizeInBytes"]/*' />
    public uint SizeInBytes;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.Format"]/*' />
    public DXGI_FORMAT Format;
}
