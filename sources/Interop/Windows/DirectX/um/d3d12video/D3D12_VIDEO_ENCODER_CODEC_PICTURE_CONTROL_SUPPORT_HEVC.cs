// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.MaxL0ReferencesForP"]/*' />
    public uint MaxL0ReferencesForP;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.MaxL0ReferencesForB"]/*' />
    public uint MaxL0ReferencesForB;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.MaxL1ReferencesForB"]/*' />
    public uint MaxL1ReferencesForB;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.MaxLongTermReferences"]/*' />
    public uint MaxLongTermReferences;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC.MaxDPBCapacity"]/*' />
    public uint MaxDPBCapacity;
}
