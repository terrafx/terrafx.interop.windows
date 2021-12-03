// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION"]/*' />
public partial struct D3D12_VIDEO_DECODE_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.DecodeProfile"]/*' />
    public Guid DecodeProfile;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.BitstreamEncryption"]/*' />
    public D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.InterlaceType"]/*' />
    public D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType;
}
