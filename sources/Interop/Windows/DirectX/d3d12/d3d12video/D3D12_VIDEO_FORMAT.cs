// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT"]/*' />
public partial struct D3D12_VIDEO_FORMAT
{
    /// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FORMAT.ColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
