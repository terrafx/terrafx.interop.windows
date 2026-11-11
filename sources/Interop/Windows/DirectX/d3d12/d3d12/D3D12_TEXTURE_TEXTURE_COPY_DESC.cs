// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_TEXTURE_COPY_DESC"]/*' />
public unsafe partial struct D3D12_TEXTURE_TEXTURE_COPY_DESC
{
    /// <include file='D3D12_TEXTURE_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_TEXTURE_COPY_DESC.pDest"]/*' />
    public ID3D12Resource* pDest;

    /// <include file='D3D12_TEXTURE_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_TEXTURE_COPY_DESC.DestSubresourceIndex"]/*' />
    public uint DestSubresourceIndex;

    /// <include file='D3D12_TEXTURE_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_TEXTURE_COPY_DESC.pSource"]/*' />
    public ID3D12Resource* pSource;

    /// <include file='D3D12_TEXTURE_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_TEXTURE_COPY_DESC.SourceSubresourceIndex"]/*' />
    public uint SourceSubresourceIndex;
}
