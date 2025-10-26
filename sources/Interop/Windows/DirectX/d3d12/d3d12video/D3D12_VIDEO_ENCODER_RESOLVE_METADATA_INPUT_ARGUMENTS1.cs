// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.EncoderCodec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC EncoderCodec;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.EncoderProfile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncoderProfile;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.EncoderInputFormat"]/*' />
    public DXGI_FORMAT EncoderInputFormat;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.EncodedPictureEffectiveResolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.HWLayoutMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.OptionalMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
}
