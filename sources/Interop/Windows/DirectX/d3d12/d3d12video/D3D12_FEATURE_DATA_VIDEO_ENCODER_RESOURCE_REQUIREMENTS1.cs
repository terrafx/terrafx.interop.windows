// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.InputFormat"]/*' />
    public DXGI_FORMAT InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.PictureTargetResolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.CompressedBitstreamBufferAccessAlignment"]/*' />
    public uint CompressedBitstreamBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderMetadataBufferAccessAlignment"]/*' />
    public uint EncoderMetadataBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.MaxEncoderOutputMetadataBufferSize"]/*' />
    public uint MaxEncoderOutputMetadataBufferSize;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.OptionalMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataQPMapTextureDimensions"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataQPMapTextureDimensions;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataSATDMapTextureDimensions"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataSATDMapTextureDimensions;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataBitAllocationMapTextureDimensions"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataBitAllocationMapTextureDimensions;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataFramePSNRComponentsNumber"]/*' />
    public uint EncoderOutputMetadataFramePSNRComponentsNumber;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataSubregionsPSNRComponentsNumber"]/*' />
    public uint EncoderOutputMetadataSubregionsPSNRComponentsNumber;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1.EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize"]/*' />
    public uint EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize;
}
