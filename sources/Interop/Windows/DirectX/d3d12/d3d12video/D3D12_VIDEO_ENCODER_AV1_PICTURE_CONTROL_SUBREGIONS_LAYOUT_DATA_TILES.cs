// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.RowCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong RowCount;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.ColCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ColCount;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.RowHeights"]/*' />
    [NativeTypeName("UINT64[64]")]
    public _RowHeights_e__FixedBuffer RowHeights;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.ColWidths"]/*' />
    [NativeTypeName("UINT64[64]")]
    public _ColWidths_e__FixedBuffer ColWidths;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES.ContextUpdateTileId"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ContextUpdateTileId;

    /// <include file='_RowHeights_e__FixedBuffer.xml' path='doc/member[@name="_RowHeights_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _RowHeights_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_ColWidths_e__FixedBuffer.xml' path='doc/member[@name="_ColWidths_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _ColWidths_e__FixedBuffer
    {
        public ulong e0;
    }
}
