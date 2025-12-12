// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION"]/*' />
public partial struct D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.Enabled"]/*' />
    public BOOL Enabled;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.MapSource"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION.MapValuesType"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;
}
