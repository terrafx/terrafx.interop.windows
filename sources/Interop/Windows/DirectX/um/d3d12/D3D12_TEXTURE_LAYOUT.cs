// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT"]/*' />
public enum D3D12_TEXTURE_LAYOUT
{
    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_UNKNOWN"]/*' />
    D3D12_TEXTURE_LAYOUT_UNKNOWN = 0,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_ROW_MAJOR"]/*' />
    D3D12_TEXTURE_LAYOUT_ROW_MAJOR = 1,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE"]/*' />
    D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE = 2,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE"]/*' />
    D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE = 3,
}
