// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2"]/*' />
public partial struct D3D12_RESOURCE_DESC2
{
    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Dimension"]/*' />
    public D3D12_RESOURCE_DIMENSION Dimension;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Alignment"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Alignment;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Width"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Width;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.DepthOrArraySize"]/*' />
    [NativeTypeName("UINT16")]
    public ushort DepthOrArraySize;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.MipLevels"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MipLevels;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.SampleDesc"]/*' />
    public DXGI_SAMPLE_DESC SampleDesc;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Layout"]/*' />
    public D3D12_TEXTURE_LAYOUT Layout;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.Flags"]/*' />
    public D3D12_RESOURCE_FLAGS Flags;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.SamplerFeedbackMipRegion"]/*' />
    public D3D12_MIP_REGION SamplerFeedbackMipRegion;

    /// <include file='D3D12_RESOURCE_DESC2.xml' path='doc/member[@name="D3D12_RESOURCE_DESC2.LayoutGuid"]/*' />
    public Guid LayoutGuid;
}
