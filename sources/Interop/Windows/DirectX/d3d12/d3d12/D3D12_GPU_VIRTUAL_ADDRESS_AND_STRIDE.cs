// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE"]/*' />
public partial struct D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE
{
    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.StartAddress"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong StartAddress;

    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.StrideInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong StrideInBytes;
}
