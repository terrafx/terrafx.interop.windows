// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.EncodedPictureEffectiveResolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.HWLayoutMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.OptionalMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
}
