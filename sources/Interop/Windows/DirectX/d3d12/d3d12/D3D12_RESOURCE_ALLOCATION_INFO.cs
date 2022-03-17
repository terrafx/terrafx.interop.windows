// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO"]/*' />
public partial struct D3D12_RESOURCE_ALLOCATION_INFO
{
    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO.SizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;

    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO.Alignment"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Alignment;
}
