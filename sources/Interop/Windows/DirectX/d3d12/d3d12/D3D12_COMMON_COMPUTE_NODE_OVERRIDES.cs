// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES"]/*' />
public unsafe partial struct D3D12_COMMON_COMPUTE_NODE_OVERRIDES
{
    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.pLocalRootArgumentsTableIndex"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* pLocalRootArgumentsTableIndex;

    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.pProgramEntry"]/*' />
    [NativeTypeName("const BOOL *")]
    public BOOL* pProgramEntry;

    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.pNewName"]/*' />
    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pNewName;

    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.pShareInputOf"]/*' />
    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pShareInputOf;

    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.NumOutputOverrides"]/*' />
    public uint NumOutputOverrides;

    /// <include file='D3D12_COMMON_COMPUTE_NODE_OVERRIDES.xml' path='doc/member[@name="D3D12_COMMON_COMPUTE_NODE_OVERRIDES.pOutputOverrides"]/*' />
    [NativeTypeName("const D3D12_NODE_OUTPUT_OVERRIDES *")]
    public D3D12_NODE_OUTPUT_OVERRIDES* pOutputOverrides;
}
