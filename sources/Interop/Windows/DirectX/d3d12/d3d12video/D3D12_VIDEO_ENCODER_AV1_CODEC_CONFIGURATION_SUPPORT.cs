// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedFeatureFlags"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS SupportedFeatureFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.RequiredFeatureFlags"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS RequiredFeatureFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedInterpolationFilters"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS SupportedInterpolationFilters;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedRestorationParams"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[3][3]")]
    public _SupportedRestorationParams_e__FixedBuffer SupportedRestorationParams;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedSegmentationModes"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS SupportedSegmentationModes;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedTxModes"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[4]")]
    public _SupportedTxModes_e__FixedBuffer SupportedTxModes;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SegmentationBlockSize"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE SegmentationBlockSize;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.PostEncodeValuesFlags"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS PostEncodeValuesFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.MaxTemporalLayers"]/*' />
    public uint MaxTemporalLayers;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.MaxSpatialLayers"]/*' />
    public uint MaxSpatialLayers;

    /// <include file='_SupportedRestorationParams_e__FixedBuffer.xml' path='doc/member[@name="_SupportedRestorationParams_e__FixedBuffer"]/*' />
    [InlineArray(3 * 3)]
    public partial struct _SupportedRestorationParams_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS e0_0;
    }

    /// <include file='_SupportedTxModes_e__FixedBuffer.xml' path='doc/member[@name="_SupportedTxModes_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _SupportedTxModes_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS e0;
    }
}
