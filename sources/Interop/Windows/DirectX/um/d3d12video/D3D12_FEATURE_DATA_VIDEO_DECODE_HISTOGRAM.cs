// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.DecodeProfile"]/*' />
    public Guid DecodeProfile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.DecodeFormat"]/*' />
    public DXGI_FORMAT DecodeFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Components"]/*' />
    public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.BinCount"]/*' />
    public uint BinCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.CounterBitDepth"]/*' />
    public uint CounterBitDepth;
}
