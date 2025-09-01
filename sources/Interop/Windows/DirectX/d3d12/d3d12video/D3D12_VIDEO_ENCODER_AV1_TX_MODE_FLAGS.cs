// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using static TerraFX.Interop.DirectX.D3D12_VIDEO_ENCODER_AV1_TX_MODE;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS"]/*' />
[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4 = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT"]/*' />
    D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT = (1 << D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT),
}
