// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE"]/*' />
public enum D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME"]/*' />
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME"]/*' />
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME"]/*' />
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME"]/*' />
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME = 3,
}
