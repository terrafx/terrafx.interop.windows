// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_DESC"]/*' />
public partial struct D3D12_VIDEO_DECODER_DESC
{
    /// <include file='D3D12_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_DESC.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_DECODER_DESC.Configuration"]/*' />
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
}
