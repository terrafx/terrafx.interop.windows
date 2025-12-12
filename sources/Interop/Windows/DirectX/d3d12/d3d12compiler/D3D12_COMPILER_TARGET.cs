// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_TARGET.xml' path='doc/member[@name="D3D12_COMPILER_TARGET"]/*' />
public partial struct D3D12_COMPILER_TARGET
{
    /// <include file='D3D12_COMPILER_TARGET.xml' path='doc/member[@name="D3D12_COMPILER_TARGET.AdapterFamilyIndex"]/*' />
    public uint AdapterFamilyIndex;

    /// <include file='D3D12_COMPILER_TARGET.xml' path='doc/member[@name="D3D12_COMPILER_TARGET.ABIVersion"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ABIVersion;
}
