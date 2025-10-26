// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX.pQuantizationMap"]/*' />
    public ID3D12Resource* pQuantizationMap;
}
