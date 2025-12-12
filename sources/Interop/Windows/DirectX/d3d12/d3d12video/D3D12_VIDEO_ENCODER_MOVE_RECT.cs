// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_MOVE_RECT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVE_RECT"]/*' />
public partial struct D3D12_VIDEO_ENCODER_MOVE_RECT
{
    /// <include file='D3D12_VIDEO_ENCODER_MOVE_RECT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVE_RECT.SourcePoint"]/*' />
    public POINT SourcePoint;

    /// <include file='D3D12_VIDEO_ENCODER_MOVE_RECT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOVE_RECT.DestRect"]/*' />
    public RECT DestRect;
}
