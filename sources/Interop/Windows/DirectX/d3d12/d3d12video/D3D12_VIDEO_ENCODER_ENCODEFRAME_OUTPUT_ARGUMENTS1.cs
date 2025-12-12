// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.Bitstream"]/*' />
    public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1 Bitstream;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.ReconstructedPicture"]/*' />
    public D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE ReconstructedPicture;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.EncoderOutputMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER EncoderOutputMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1.FrameAnalysisReconstructedPicture"]/*' />
    public D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE FrameAnalysisReconstructedPicture;
}
