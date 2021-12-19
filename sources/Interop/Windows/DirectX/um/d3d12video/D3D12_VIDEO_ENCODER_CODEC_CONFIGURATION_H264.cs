// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.ConfigurationFlags"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS ConfigurationFlags;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.DirectModeConfig"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES DirectModeConfig;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264.DisableDeblockingFilterConfig"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES DisableDeblockingFilterConfig;
}
