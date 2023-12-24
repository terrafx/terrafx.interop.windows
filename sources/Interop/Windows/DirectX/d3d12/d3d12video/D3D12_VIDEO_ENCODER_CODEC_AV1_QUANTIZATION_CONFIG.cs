// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.BaseQIndex"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BaseQIndex;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.YDCDeltaQ"]/*' />
    [NativeTypeName("INT64")]
    public long YDCDeltaQ;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.UDCDeltaQ"]/*' />
    [NativeTypeName("INT64")]
    public long UDCDeltaQ;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.UACDeltaQ"]/*' />
    [NativeTypeName("INT64")]
    public long UACDeltaQ;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.VDCDeltaQ"]/*' />
    [NativeTypeName("INT64")]
    public long VDCDeltaQ;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.VACDeltaQ"]/*' />
    [NativeTypeName("INT64")]
    public long VACDeltaQ;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.UsingQMatrix"]/*' />
    [NativeTypeName("UINT64")]
    public ulong UsingQMatrix;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.QMY"]/*' />
    [NativeTypeName("UINT64")]
    public ulong QMY;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.QMU"]/*' />
    [NativeTypeName("UINT64")]
    public ulong QMU;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG.QMV"]/*' />
    [NativeTypeName("UINT64")]
    public ulong QMV;
}
