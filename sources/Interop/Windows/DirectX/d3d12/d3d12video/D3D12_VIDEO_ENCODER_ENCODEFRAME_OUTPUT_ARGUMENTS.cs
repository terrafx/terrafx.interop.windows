// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS"]/*' />
public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.Bitstream"]/*' />
    public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM Bitstream;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.ReconstructedPicture"]/*' />
    public D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE ReconstructedPicture;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS.EncoderOutputMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER EncoderOutputMetadata;
}
