// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.ResolvedLayoutMetadata"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER ResolvedLayoutMetadata;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.OutputQPMap"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER OutputQPMap;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.OutputSATDMap"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER OutputSATDMap;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.OutputBitAllocationMap"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER OutputBitAllocationMap;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.ResolvedFramePSNRData"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER ResolvedFramePSNRData;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS.ResolvedSubregionsPSNRData"]/*' />
    public D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER ResolvedSubregionsPSNRData;
}
