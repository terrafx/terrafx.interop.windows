// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC"]/*' />
public enum D3D12_COMPARISON_FUNC
{
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NEVER"]/*' />
    D3D12_COMPARISON_FUNC_NEVER = 1,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS"]/*' />
    D3D12_COMPARISON_FUNC_LESS = 2,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_EQUAL"]/*' />
    D3D12_COMPARISON_FUNC_EQUAL = 3,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS_EQUAL"]/*' />
    D3D12_COMPARISON_FUNC_LESS_EQUAL = 4,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER"]/*' />
    D3D12_COMPARISON_FUNC_GREATER = 5,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NOT_EQUAL"]/*' />
    D3D12_COMPARISON_FUNC_NOT_EQUAL = 6,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER_EQUAL"]/*' />
    D3D12_COMPARISON_FUNC_GREATER_EQUAL = 7,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_ALWAYS"]/*' />
    D3D12_COMPARISON_FUNC_ALWAYS = 8,
}
