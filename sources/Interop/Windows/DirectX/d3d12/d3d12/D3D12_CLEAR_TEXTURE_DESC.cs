// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC"]/*' />
public unsafe partial struct D3D12_CLEAR_TEXTURE_DESC
{
    /// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC.pTexture"]/*' />
    public ID3D12Resource* pTexture;

    /// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC.SubresourceIndex"]/*' />
    public uint SubresourceIndex;

    /// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC.ClearValue"]/*' />
    public D3D12_CLEAR_DATA ClearValue;

    /// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_CLEAR_TEXTURE_DESC.xml' path='doc/member[@name="D3D12_CLEAR_TEXTURE_DESC.pRegion"]/*' />
    [NativeTypeName("const D3D12_BOX *")]
    public D3D12_BOX* pRegion;
}
