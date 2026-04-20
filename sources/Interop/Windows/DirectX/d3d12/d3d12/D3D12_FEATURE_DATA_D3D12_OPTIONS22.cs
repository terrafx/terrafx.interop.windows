// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS22.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS22"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS22
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS22.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS22.ShaderExecutionReorderingActuallyReorders"]/*' />
    public BOOL ShaderExecutionReorderingActuallyReorders;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS22.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS22.CreateByteOffsetViewsSupported"]/*' />
    public BOOL CreateByteOffsetViewsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS22.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS22.Max1DDispatchSize"]/*' />
    public uint Max1DDispatchSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS22.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS22.Max1DDispatchMeshSize"]/*' />
    public uint Max1DDispatchMeshSize;
}
