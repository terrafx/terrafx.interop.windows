// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CACHE_FILE_DESC.xml' path='doc/member[@name="D3D12_CACHE_FILE_DESC"]/*' />
public unsafe partial struct D3D12_CACHE_FILE_DESC
{
    /// <include file='D3D12_CACHE_FILE_DESC.xml' path='doc/member[@name="D3D12_CACHE_FILE_DESC.Types"]/*' />
    public D3D12_CACHE_VALUE_TYPE_FLAGS Types;

    /// <include file='D3D12_CACHE_FILE_DESC.xml' path='doc/member[@name="D3D12_CACHE_FILE_DESC.MaximumSizeBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaximumSizeBytes;

    /// <include file='D3D12_CACHE_FILE_DESC.xml' path='doc/member[@name="D3D12_CACHE_FILE_DESC.pPath"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pPath;
}
