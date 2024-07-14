// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE.IntraDistance"]/*' />
    public uint IntraDistance;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEQUENCE_STRUCTURE.InterFramePeriod"]/*' />
    public uint InterFramePeriod;
}
