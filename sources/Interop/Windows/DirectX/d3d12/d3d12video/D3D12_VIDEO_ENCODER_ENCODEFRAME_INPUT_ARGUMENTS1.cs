// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.SequenceControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.PictureControlDesc"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1 PictureControlDesc;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.pInputFrame"]/*' />
    public ID3D12Resource* pInputFrame;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.InputFrameSubresource"]/*' />
    public uint InputFrameSubresource;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.CurrentFrameBitstreamMetadataSize"]/*' />
    public uint CurrentFrameBitstreamMetadataSize;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1.OptionalMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;
}
