// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE"]/*' />
public enum D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE
{
    /// <include file='D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_NONE"]/*' />
    D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_NONE = 0,

    /// <include file='D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_PRERASTERIZATION_SHADER"]/*' />
    D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_PRERASTERIZATION_SHADER = 1,

    /// <include file='D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE.D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_PIXEL_SHADER"]/*' />
    D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE_PIXEL_SHADER = 2,
}
