// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_ANALYSIS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_FRAME_ANALYSIS
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.pDownscaledFrame"]/*' />
    public ID3D12Resource* pDownscaledFrame;

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.Subresource"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Subresource;

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_ANALYSIS.DownscaledReferences"]/*' />
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES DownscaledReferences;
}
