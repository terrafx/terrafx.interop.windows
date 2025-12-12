// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS21.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS21"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS21
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS21.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS21.WorkGraphsTier"]/*' />
    public D3D12_WORK_GRAPHS_TIER WorkGraphsTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS21.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS21.ExecuteIndirectTier"]/*' />
    public D3D12_EXECUTE_INDIRECT_TIER ExecuteIndirectTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS21.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS21.SampleCmpGradientAndBiasSupported"]/*' />
    public BOOL SampleCmpGradientAndBiasSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS21.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS21.ExtendedCommandInfoSupported"]/*' />
    public BOOL ExtendedCommandInfoSupported;
}
