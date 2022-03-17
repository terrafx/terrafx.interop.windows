// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CONSTANT_BUFFER_VIEW_DESC.xml' path='doc/member[@name="D3D12_CONSTANT_BUFFER_VIEW_DESC"]/*' />
public partial struct D3D12_CONSTANT_BUFFER_VIEW_DESC
{
    /// <include file='D3D12_CONSTANT_BUFFER_VIEW_DESC.xml' path='doc/member[@name="D3D12_CONSTANT_BUFFER_VIEW_DESC.BufferLocation"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong BufferLocation;

    /// <include file='D3D12_CONSTANT_BUFFER_VIEW_DESC.xml' path='doc/member[@name="D3D12_CONSTANT_BUFFER_VIEW_DESC.SizeInBytes"]/*' />
    public uint SizeInBytes;
}
