// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES"]/*' />
public unsafe partial struct D3D12_NODE_OUTPUT_OVERRIDES
{
    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.OutputIndex"]/*' />
    public uint OutputIndex;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pNewName"]/*' />
    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pNewName;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pAllowSparseNodes"]/*' />
    [NativeTypeName("const BOOL *")]
    public BOOL* pAllowSparseNodes;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pMaxRecords"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* pMaxRecords;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pMaxRecordsSharedWithOutputIndex"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* pMaxRecordsSharedWithOutputIndex;
}
