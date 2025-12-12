// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION.FeatureFlags"]/*' />
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS FeatureFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION.OrderHintBitsMinus1"]/*' />
    public uint OrderHintBitsMinus1;
}
