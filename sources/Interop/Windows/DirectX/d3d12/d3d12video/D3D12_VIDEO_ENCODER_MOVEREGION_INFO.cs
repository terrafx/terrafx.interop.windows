// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_MOVEREGION_INFO
{
    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.NumMoveRegions"]/*' />
    public uint NumMoveRegions;

    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.pMoveRegions"]/*' />
    public D3D12_VIDEO_ENCODER_MOVE_RECT* pMoveRegions;

    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.MotionSearchModeConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG MotionSearchModeConfiguration;

    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.SourceDPBFrameReference"]/*' />
    public uint SourceDPBFrameReference;

    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.MotionUnitPrecision"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION MotionUnitPrecision;

    /// <include file='D3D12_VIDEO_ENCODER_MOVEREGION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVEREGION_INFO.Flags"]/*' />
    public D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAGS Flags;
}
