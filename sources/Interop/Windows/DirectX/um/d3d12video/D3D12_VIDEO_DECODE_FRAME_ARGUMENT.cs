// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_FRAME_ARGUMENT
{
    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Type"]/*' />
    public D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Size"]/*' />
    public uint Size;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.pData"]/*' />
    public void* pData;
}
