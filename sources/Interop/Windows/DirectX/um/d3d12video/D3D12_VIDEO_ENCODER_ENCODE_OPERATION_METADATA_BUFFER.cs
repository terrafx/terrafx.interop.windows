// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.pBuffer"]/*' />
    public ID3D12Resource* pBuffer;

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;
}
