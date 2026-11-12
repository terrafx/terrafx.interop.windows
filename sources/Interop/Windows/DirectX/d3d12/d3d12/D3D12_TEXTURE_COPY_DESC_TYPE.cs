// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_DESC_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC_TYPE"]/*' />
public enum D3D12_TEXTURE_COPY_DESC_TYPE
{
    /// <include file='D3D12_TEXTURE_COPY_DESC_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC_TYPE.D3D12_TEXTURE_COPY_DESC_TYPE_TEXTURE_TO_TEXTURE"]/*' />
    D3D12_TEXTURE_COPY_DESC_TYPE_TEXTURE_TO_TEXTURE = 0,

    /// <include file='D3D12_TEXTURE_COPY_DESC_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC_TYPE.D3D12_TEXTURE_COPY_DESC_TYPE_BUFFER_TO_TEXTURE"]/*' />
    D3D12_TEXTURE_COPY_DESC_TYPE_BUFFER_TO_TEXTURE = (D3D12_TEXTURE_COPY_DESC_TYPE_TEXTURE_TO_TEXTURE + 1),

    /// <include file='D3D12_TEXTURE_COPY_DESC_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC_TYPE.D3D12_TEXTURE_COPY_DESC_TYPE_TEXTURE_TO_BUFFER"]/*' />
    D3D12_TEXTURE_COPY_DESC_TYPE_TEXTURE_TO_BUFFER = (D3D12_TEXTURE_COPY_DESC_TYPE_BUFFER_TO_TEXTURE + 1),
}
