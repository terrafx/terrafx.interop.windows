// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE"]/*' />
public enum D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE
{
    /// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE"]/*' />
    D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE = 0,

    /// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED"]/*' />
    D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED = 1,
}
