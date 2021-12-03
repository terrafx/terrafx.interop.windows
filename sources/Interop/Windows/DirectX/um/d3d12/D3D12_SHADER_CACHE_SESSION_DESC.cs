// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC"]/*' />
public partial struct D3D12_SHADER_CACHE_SESSION_DESC
{
    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.Identifier"]/*' />
    public Guid Identifier;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.Mode"]/*' />
    public D3D12_SHADER_CACHE_MODE Mode;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.Flags"]/*' />
    public D3D12_SHADER_CACHE_FLAGS Flags;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.MaximumInMemoryCacheSizeBytes"]/*' />
    public uint MaximumInMemoryCacheSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.MaximumInMemoryCacheEntries"]/*' />
    public uint MaximumInMemoryCacheEntries;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.MaximumValueFileSizeBytes"]/*' />
    public uint MaximumValueFileSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC.Version"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Version;
}
