// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.FullFrameIdentical"]/*' />
    public BOOL FullFrameIdentical;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.MapValuesType"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.pDirtyRegionsMap"]/*' />
    public ID3D12Resource* pDirtyRegionsMap;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS.SourceDPBFrameReference"]/*' />
    public uint SourceDPBFrameReference;
}
