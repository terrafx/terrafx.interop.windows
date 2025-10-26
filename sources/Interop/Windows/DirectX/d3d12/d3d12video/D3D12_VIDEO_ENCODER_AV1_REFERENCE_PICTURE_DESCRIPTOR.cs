// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.ReconstructedPictureResourceIndex"]/*' />
    public uint ReconstructedPictureResourceIndex;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.TemporalLayerIndexPlus1"]/*' />
    public uint TemporalLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.SpatialLayerIndexPlus1"]/*' />
    public uint SpatialLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.FrameType"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.WarpedMotionInfo"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO WarpedMotionInfo;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.OrderHint"]/*' />
    public uint OrderHint;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.PictureIndex"]/*' />
    public uint PictureIndex;
}
