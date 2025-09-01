// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN"]/*' />
public enum D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN
{
    /// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.D3D10_SB_CONSTANT_BUFFER_IMMEDIATE_INDEXED"]/*' />
    D3D10_SB_CONSTANT_BUFFER_IMMEDIATE_INDEXED = 0,

    /// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.D3D10_SB_CONSTANT_BUFFER_DYNAMIC_INDEXED"]/*' />
    D3D10_SB_CONSTANT_BUFFER_DYNAMIC_INDEXED = 1,
}
