// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER
{
    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER.pData"]/*' />
    public void* pData;

    /// <include file='D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_BUFFER.ByteSize"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ByteSize;
}
