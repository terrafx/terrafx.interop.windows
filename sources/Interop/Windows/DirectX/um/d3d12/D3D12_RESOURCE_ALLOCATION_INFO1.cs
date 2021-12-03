// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_ALLOCATION_INFO1.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO1"]/*' />
public partial struct D3D12_RESOURCE_ALLOCATION_INFO1
{
    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO1.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO1.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO1.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO1.Alignment"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Alignment;

    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO1.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO1.SizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;
}
