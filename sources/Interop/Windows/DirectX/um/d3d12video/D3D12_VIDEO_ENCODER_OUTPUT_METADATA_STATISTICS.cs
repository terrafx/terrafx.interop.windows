// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS"]/*' />
public partial struct D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS
{
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageQP"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageQP;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.IntraCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IntraCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.InterCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InterCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.SkipCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SkipCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageMotionEstimationXDirection"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageMotionEstimationXDirection;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageMotionEstimationYDirection"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageMotionEstimationYDirection;
}
