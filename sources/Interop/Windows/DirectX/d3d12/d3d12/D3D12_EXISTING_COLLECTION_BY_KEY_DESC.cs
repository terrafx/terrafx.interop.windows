// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_EXISTING_COLLECTION_BY_KEY_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_BY_KEY_DESC"]/*' />
public unsafe partial struct D3D12_EXISTING_COLLECTION_BY_KEY_DESC
{
    /// <include file='D3D12_EXISTING_COLLECTION_BY_KEY_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_BY_KEY_DESC.pKey"]/*' />
    [NativeTypeName("const void *")]
    public void* pKey;

    /// <include file='D3D12_EXISTING_COLLECTION_BY_KEY_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_BY_KEY_DESC.KeySize"]/*' />
    public uint KeySize;

    /// <include file='D3D12_EXISTING_COLLECTION_BY_KEY_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_BY_KEY_DESC.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_EXISTING_COLLECTION_BY_KEY_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_BY_KEY_DESC.pExports"]/*' />
    [NativeTypeName("const D3D12_EXPORT_DESC *")]
    public D3D12_EXPORT_DESC* pExports;
}
