// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_STATISTICS"]/*' />
public partial struct D3D12_STATE_OBJECT_STATISTICS
{
    /// <include file='D3D12_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_STATISTICS.DefaultPSDBRegistered"]/*' />
    public BOOL DefaultPSDBRegistered;

    /// <include file='D3D12_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_STATISTICS.PipelineStateObjectStatistics"]/*' />
    public D3D12_CREATE_STATE_OBJECT_STATISTICS PipelineStateObjectStatistics;

    /// <include file='D3D12_STATE_OBJECT_STATISTICS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_STATISTICS.StateObjectStatistics"]/*' />
    public D3D12_CREATE_STATE_OBJECT_STATISTICS StateObjectStatistics;
}
