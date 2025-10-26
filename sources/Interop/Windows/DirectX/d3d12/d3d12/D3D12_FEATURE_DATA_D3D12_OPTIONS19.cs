// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS19
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MismatchingOutputDimensionsSupported"]/*' />
    public BOOL MismatchingOutputDimensionsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.SupportedSampleCountsWithNoOutputs"]/*' />
    public uint SupportedSampleCountsWithNoOutputs;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.PointSamplingAddressesNeverRoundUp"]/*' />
    public BOOL PointSamplingAddressesNeverRoundUp;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.RasterizerDesc2Supported"]/*' />
    public BOOL RasterizerDesc2Supported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.NarrowQuadrilateralLinesSupported"]/*' />
    public BOOL NarrowQuadrilateralLinesSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.AnisoFilterWithPointMipSupported"]/*' />
    public BOOL AnisoFilterWithPointMipSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxSamplerDescriptorHeapSize"]/*' />
    public uint MaxSamplerDescriptorHeapSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxSamplerDescriptorHeapSizeWithStaticSamplers"]/*' />
    public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxViewDescriptorHeapSize"]/*' />
    public uint MaxViewDescriptorHeapSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.ComputeOnlyCustomHeapSupported"]/*' />
    public BOOL ComputeOnlyCustomHeapSupported;
}
