// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC"]/*' />
public partial struct D3D12_RESOURCE_DESC
{
    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Dimension"]/*' />
    public D3D12_RESOURCE_DIMENSION Dimension;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Alignment"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Alignment;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Width"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Width;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.DepthOrArraySize"]/*' />
    [NativeTypeName("UINT16")]
    public ushort DepthOrArraySize;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.MipLevels"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MipLevels;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.SampleDesc"]/*' />
    public DXGI_SAMPLE_DESC SampleDesc;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Layout"]/*' />
    public D3D12_TEXTURE_LAYOUT Layout;

    /// <include file='D3D12_RESOURCE_DESC.xml' path='doc/member[@name="D3D12_RESOURCE_DESC.Flags"]/*' />
    public D3D12_RESOURCE_FLAGS Flags;
}
