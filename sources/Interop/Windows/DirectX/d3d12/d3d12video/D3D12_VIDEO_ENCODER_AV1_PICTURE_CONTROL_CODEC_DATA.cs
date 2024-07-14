// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.Flags"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS Flags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.FrameType"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.CompoundPredictionType"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE CompoundPredictionType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.InterpolationFilter"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS InterpolationFilter;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.FrameRestorationConfig"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG FrameRestorationConfig;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.TxMode"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_TX_MODE TxMode;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.SuperResDenominator"]/*' />
    public uint SuperResDenominator;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.OrderHint"]/*' />
    public uint OrderHint;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.PictureIndex"]/*' />
    public uint PictureIndex;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.TemporalLayerIndexPlus1"]/*' />
    public uint TemporalLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.SpatialLayerIndexPlus1"]/*' />
    public uint SpatialLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.ReferenceFramesReconPictureDescriptors"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR[8]")]
    public _ReferenceFramesReconPictureDescriptors_e__FixedBuffer ReferenceFramesReconPictureDescriptors;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.ReferenceIndices"]/*' />
    [NativeTypeName("UINT[7]")]
    public _ReferenceIndices_e__FixedBuffer ReferenceIndices;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.PrimaryRefFrame"]/*' />
    public uint PrimaryRefFrame;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.RefreshFrameFlags"]/*' />
    public uint RefreshFrameFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.LoopFilter"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.LoopFilterDelta"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.Quantization"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.QuantizationDelta"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.CDEF"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.QPMapValuesCount"]/*' />
    public uint QPMapValuesCount;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.pRateControlQPMap"]/*' />
    [NativeTypeName("INT16 *")]
    public short* pRateControlQPMap;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.CustomSegmentation"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG CustomSegmentation;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA.CustomSegmentsMap"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP CustomSegmentsMap;

    /// <include file='_ReferenceFramesReconPictureDescriptors_e__FixedBuffer.xml' path='doc/member[@name="_ReferenceFramesReconPictureDescriptors_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _ReferenceFramesReconPictureDescriptors_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR e0;
    }

    /// <include file='_ReferenceIndices_e__FixedBuffer.xml' path='doc/member[@name="_ReferenceIndices_e__FixedBuffer"]/*' />
    [InlineArray(7)]
    public partial struct _ReferenceIndices_e__FixedBuffer
    {
        public uint e0;
    }
}
