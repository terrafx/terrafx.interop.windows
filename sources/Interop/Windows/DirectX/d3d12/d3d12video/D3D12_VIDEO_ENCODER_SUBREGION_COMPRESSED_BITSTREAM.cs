// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM
{
    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.BufferMode"]/*' />
    public D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE BufferMode;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.ExpectedSubregionCount"]/*' />
    public uint ExpectedSubregionCount;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.pSubregionBitstreamsBaseOffsets"]/*' />
    [NativeTypeName("UINT64 *")]
    public ulong* pSubregionBitstreamsBaseOffsets;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.ppSubregionBitstreams"]/*' />
    public ID3D12Resource** ppSubregionBitstreams;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.ppSubregionSizes"]/*' />
    public ID3D12Resource** ppSubregionSizes;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.ppSubregionOffsets"]/*' />
    public ID3D12Resource** ppSubregionOffsets;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.ppSubregionFences"]/*' />
    public ID3D12Fence** ppSubregionFences;

    /// <include file='D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM.pSubregionFenceValues"]/*' />
    [NativeTypeName("UINT64 *")]
    public ulong* pSubregionFenceValues;
}
