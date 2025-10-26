// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.MotionSearchModeConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG MotionSearchModeConfiguration;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.NumHintsPerPixel"]/*' />
    public uint NumHintsPerPixel;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.ppMotionVectorMaps"]/*' />
    public ID3D12Resource** ppMotionVectorMaps;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.pMotionVectorMapsSubresources"]/*' />
    public uint* pMotionVectorMapsSubresources;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.ppMotionVectorMapsMetadata"]/*' />
    public ID3D12Resource** ppMotionVectorMapsMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.pMotionVectorMapsMetadataSubresources"]/*' />
    public uint* pMotionVectorMapsMetadataSubresources;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.MotionUnitPrecision"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION MotionUnitPrecision;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS.PictureControlConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1 PictureControlConfiguration;
}
