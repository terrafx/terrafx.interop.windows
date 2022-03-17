// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.SequenceControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.PictureControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC PictureControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.pInputFrame"]/*' />
    public ID3D12Resource* pInputFrame;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.InputFrameSubresource"]/*' />
    public uint InputFrameSubresource;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS.CurrentFrameBitstreamMetadataSize"]/*' />
    public uint CurrentFrameBitstreamMetadataSize;
}
