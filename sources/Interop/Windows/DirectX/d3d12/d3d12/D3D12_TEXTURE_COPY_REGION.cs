// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_REGION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_REGION"]/*' />
public unsafe partial struct D3D12_TEXTURE_COPY_REGION
{
    /// <include file='D3D12_TEXTURE_COPY_REGION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_REGION.DestX"]/*' />
    public uint DestX;

    /// <include file='D3D12_TEXTURE_COPY_REGION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_REGION.DestY"]/*' />
    public uint DestY;

    /// <include file='D3D12_TEXTURE_COPY_REGION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_REGION.DestZ"]/*' />
    public uint DestZ;

    /// <include file='D3D12_TEXTURE_COPY_REGION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_REGION.pSourceBox"]/*' />
    [NativeTypeName("const D3D12_BOX *")]
    public D3D12_BOX* pSourceBox;
}
