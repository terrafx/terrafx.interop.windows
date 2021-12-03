// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS9
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.MeshShaderPipelineStatsSupported"]/*' />
    public BOOL MeshShaderPipelineStatsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.MeshShaderSupportsFullRangeRenderTargetArrayIndex"]/*' />
    public BOOL MeshShaderSupportsFullRangeRenderTargetArrayIndex;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.AtomicInt64OnTypedResourceSupported"]/*' />
    public BOOL AtomicInt64OnTypedResourceSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.AtomicInt64OnGroupSharedSupported"]/*' />
    public BOOL AtomicInt64OnGroupSharedSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.DerivativesInMeshAndAmplificationShadersSupported"]/*' />
    public BOOL DerivativesInMeshAndAmplificationShadersSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS9.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS9.WaveMMATier"]/*' />
    public D3D12_WAVE_MMA_TIER WaveMMATier;
}
