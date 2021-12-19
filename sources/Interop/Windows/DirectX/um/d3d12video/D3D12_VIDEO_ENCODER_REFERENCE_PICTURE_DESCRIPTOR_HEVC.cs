// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.ReconstructedPictureResourceIndex"]/*' />
    public uint ReconstructedPictureResourceIndex;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.IsRefUsedByCurrentPic"]/*' />
    public BOOL IsRefUsedByCurrentPic;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.IsLongTermReference"]/*' />
    public BOOL IsLongTermReference;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.PictureOrderCountNumber"]/*' />
    public uint PictureOrderCountNumber;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.TemporalLayerIndex"]/*' />
    public uint TemporalLayerIndex;
}
