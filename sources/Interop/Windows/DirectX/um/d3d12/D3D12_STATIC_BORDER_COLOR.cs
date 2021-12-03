// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR"]/*' />
public enum D3D12_STATIC_BORDER_COLOR
{
    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK"]/*' />
    D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK = 0,

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK = (D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE"]/*' />
    D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE = (D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK + 1),
}
