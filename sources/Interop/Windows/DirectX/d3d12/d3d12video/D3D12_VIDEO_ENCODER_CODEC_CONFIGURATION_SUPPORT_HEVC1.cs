// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.MinLumaCodingUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.MaxLumaCodingUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.MinLumaTransformUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.MaxLumaTransformUnitSize"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.max_transform_hierarchy_depth_inter"]/*' />
    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_inter;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.max_transform_hierarchy_depth_intra"]/*' />
    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_intra;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_diff_cu_chroma_qp_offset_depth_values"]/*' />
    public uint allowed_diff_cu_chroma_qp_offset_depth_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_log2_sao_offset_scale_luma_values"]/*' />
    public uint allowed_log2_sao_offset_scale_luma_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_log2_sao_offset_scale_chroma_values"]/*' />
    public uint allowed_log2_sao_offset_scale_chroma_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_log2_max_transform_skip_block_size_minus2_values"]/*' />
    public uint allowed_log2_max_transform_skip_block_size_minus2_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_chroma_qp_offset_list_len_minus1_values"]/*' />
    public uint allowed_chroma_qp_offset_list_len_minus1_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_cb_qp_offset_list_values"]/*' />
    [NativeTypeName("UINT[6]")]
    public _allowed_cb_qp_offset_list_values_e__FixedBuffer allowed_cb_qp_offset_list_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.allowed_cr_qp_offset_list_values"]/*' />
    [NativeTypeName("UINT[6]")]
    public _allowed_cr_qp_offset_list_values_e__FixedBuffer allowed_cr_qp_offset_list_values;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1.SupportFlags1"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1 SupportFlags1;

    /// <include file='_allowed_cb_qp_offset_list_values_e__FixedBuffer.xml' path='doc/member[@name="_allowed_cb_qp_offset_list_values_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _allowed_cb_qp_offset_list_values_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_allowed_cr_qp_offset_list_values_e__FixedBuffer.xml' path='doc/member[@name="_allowed_cr_qp_offset_list_values_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _allowed_cr_qp_offset_list_values_e__FixedBuffer
    {
        public uint e0;
    }
}
