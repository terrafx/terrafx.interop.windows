// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.SessionInfo"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.MapSource"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.MapValuesType"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS.MapSourcePreferenceRanking"]/*' />
    public uint MapSourcePreferenceRanking;
}
