// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE"]/*' />
public enum D3D12_VIDEO_ENCODER_AV1_TX_MODE
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE.D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4 = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE.D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE.D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT = 2,
}
