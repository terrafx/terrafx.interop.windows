// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM"]/*' />
public unsafe partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.pTexture2D"]/*' />
    public ID3D12Resource* pTexture2D;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.Subresource"]/*' />
    public uint Subresource;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM.ReferenceSet"]/*' />
    public D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet;
}
