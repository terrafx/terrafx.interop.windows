// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG"]/*' />
public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.UpdateMap"]/*' />
    [NativeTypeName("UINT64")]
    public ulong UpdateMap;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.TemporalUpdate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TemporalUpdate;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.UpdateData"]/*' />
    [NativeTypeName("UINT64")]
    public ulong UpdateData;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.NumSegments"]/*' />
    [NativeTypeName("UINT64")]
    public ulong NumSegments;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG.SegmentsData"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA[8]")]
    public _SegmentsData_e__FixedBuffer SegmentsData;

    /// <include file='_SegmentsData_e__FixedBuffer.xml' path='doc/member[@name="_SegmentsData_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _SegmentsData_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA e0;
    }
}
