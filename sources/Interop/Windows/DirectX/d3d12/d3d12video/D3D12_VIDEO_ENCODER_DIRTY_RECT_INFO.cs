// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO
{
    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.FullFrameIdentical"]/*' />
    public BOOL FullFrameIdentical;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.MapValuesType"]/*' />
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.NumDirtyRects"]/*' />
    public uint NumDirtyRects;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.pDirtyRects"]/*' />
    public RECT* pDirtyRects;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO.SourceDPBFrameReference"]/*' />
    public uint SourceDPBFrameReference;
}
