// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BUFFER_SRV_BYTE_OFFSET.xml' path='doc/member[@name="D3D12_BUFFER_SRV_BYTE_OFFSET"]/*' />
public partial struct D3D12_BUFFER_SRV_BYTE_OFFSET
{
    /// <include file='D3D12_BUFFER_SRV_BYTE_OFFSET.xml' path='doc/member[@name="D3D12_BUFFER_SRV_BYTE_OFFSET.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_BUFFER_SRV_BYTE_OFFSET.xml' path='doc/member[@name="D3D12_BUFFER_SRV_BYTE_OFFSET.Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Size;

    /// <include file='D3D12_BUFFER_SRV_BYTE_OFFSET.xml' path='doc/member[@name="D3D12_BUFFER_SRV_BYTE_OFFSET.StructureByteStride"]/*' />
    public uint StructureByteStride;

    /// <include file='D3D12_BUFFER_SRV_BYTE_OFFSET.xml' path='doc/member[@name="D3D12_BUFFER_SRV_BYTE_OFFSET.Flags"]/*' />
    public D3D12_BUFFER_SRV_FLAGS Flags;
}
