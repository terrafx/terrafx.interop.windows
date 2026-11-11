// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO"]/*' />
public partial struct D3D12_SHADER_CACHE_SESSION_INFO
{
    /// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO.CurrentSizeBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CurrentSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO.MaximumSizeBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaximumSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO.ReservedSizeBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ReservedSizeBytes;

    /// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO.EntryCount"]/*' />
    public uint EntryCount;

    /// <include file='D3D12_SHADER_CACHE_SESSION_INFO.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_INFO.LifetimeEvictedEntryCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong LifetimeEvictedEntryCount;
}
