// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE"]/*' />
public enum D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_QUANTIZATION_MATRIX"]/*' />
    D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_QUANTIZATION_MATRIX = 0,

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_DIRTY_REGIONS"]/*' />
    D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_DIRTY_REGIONS = 1,

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE.D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_MOTION_VECTORS"]/*' />
    D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE_MOTION_VECTORS = 2,
}
