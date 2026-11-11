// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC"]/*' />
public unsafe partial struct D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC
{
    /// <include file='D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC.pComponentName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pComponentName;

    /// <include file='D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC.Flags"]/*' />
    public D3D12_SHADER_CACHE_SESSION_REGISTERED_FLAGS Flags;
}
