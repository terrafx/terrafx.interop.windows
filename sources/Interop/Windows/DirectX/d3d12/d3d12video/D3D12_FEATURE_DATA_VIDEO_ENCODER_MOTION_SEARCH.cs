// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.SessionInfo"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MotionSearchMode"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE MotionSearchMode;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MapSource"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.BidirectionalRefFrameEnabled"]/*' />
    public BOOL BidirectionalRefFrameEnabled;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MaxMotionHints"]/*' />
    public uint MaxMotionHints;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MinDeviation"]/*' />
    public uint MinDeviation;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MaxDeviation"]/*' />
    public uint MaxDeviation;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MapSourcePreferenceRanking"]/*' />
    public uint MapSourcePreferenceRanking;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH.MotionUnitPrecisionSupport"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAGS MotionUnitPrecisionSupport;
}
