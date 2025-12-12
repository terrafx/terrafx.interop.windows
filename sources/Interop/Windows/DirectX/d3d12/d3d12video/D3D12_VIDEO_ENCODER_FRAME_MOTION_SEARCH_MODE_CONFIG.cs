// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG"]/*' />
public partial struct D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG.MotionSearchMode"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE MotionSearchMode;

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG.SearchDeviationLimit"]/*' />
    public uint SearchDeviationLimit;
}
