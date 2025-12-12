// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.IntraRefreshFrameIndex"]/*' />
    public uint IntraRefreshFrameIndex;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.Flags"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.PictureControlCodecData"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1 PictureControlCodecData;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.ReferenceFrames"]/*' />
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.MotionVectors"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS MotionVectors;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.DirtyRects"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS DirtyRects;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.QuantizationTextureMap"]/*' />
    public D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP QuantizationTextureMap;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1.FrameAnalysis"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_ANALYSIS FrameAnalysis;
}
