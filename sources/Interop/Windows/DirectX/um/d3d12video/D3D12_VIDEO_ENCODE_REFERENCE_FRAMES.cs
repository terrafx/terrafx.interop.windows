// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODE_REFERENCE_FRAMES"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODE_REFERENCE_FRAMES
{
    /// <include file='D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.NumTexture2Ds"]/*' />
    public uint NumTexture2Ds;

    /// <include file='D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.ppTexture2Ds"]/*' />
    public ID3D12Resource** ppTexture2Ds;

    /// <include file='D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODE_REFERENCE_FRAMES.pSubresources"]/*' />
    public uint* pSubresources;
}
