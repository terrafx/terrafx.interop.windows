// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_LAYOUT_FILTER.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT_FILTER"]/*' />
public partial struct D3D12_TEXTURE_LAYOUT_FILTER
{
    /// <include file='D3D12_TEXTURE_LAYOUT_FILTER.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT_FILTER.Desc"]/*' />
    public D3D12_RESOURCE_DESC2 Desc;

    /// <include file='D3D12_TEXTURE_LAYOUT_FILTER.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT_FILTER.Support1"]/*' />
    public D3D12_FORMAT_SUPPORT1 Support1;

    /// <include file='D3D12_TEXTURE_LAYOUT_FILTER.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT_FILTER.Support2"]/*' />
    public D3D12_FORMAT_SUPPORT2 Support2;

    /// <include file='D3D12_TEXTURE_LAYOUT_FILTER.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT_FILTER.Flags"]/*' />
    public D3D12_TEXTURE_LAYOUT_FILTER_FLAGS Flags;
}
