// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC"]/*' />
public unsafe partial struct D3D12_SHADER_CACHE_SESSION_DISK_DESC
{
    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.Identifier"]/*' />
    public Guid Identifier;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.Flags"]/*' />
    public D3D12_SHADER_CACHE_FLAGS Flags;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.pDirectory"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pDirectory;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.MaximumInMemoryCacheSizeBytes"]/*' />
    public uint MaximumInMemoryCacheSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.MaximumInMemoryCacheEntries"]/*' />
    public uint MaximumInMemoryCacheEntries;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.MaximumValueFileSizeBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaximumValueFileSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DISK_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DISK_DESC.Version"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Version;
}
