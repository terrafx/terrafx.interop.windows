// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS20.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS20"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS20
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS20.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS20.ComputeOnlyWriteWatchSupported"]/*' />
    public BOOL ComputeOnlyWriteWatchSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS20.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS20.RecreateAtTier"]/*' />
    public D3D12_RECREATE_AT_TIER RecreateAtTier;
}
