// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_VALUE_TYPE.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE"]/*' />
public enum D3D12_COMPILER_VALUE_TYPE
{
    /// <include file='D3D12_COMPILER_VALUE_TYPE.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE.D3D12_COMPILER_VALUE_TYPE_OBJECT_CODE"]/*' />
    D3D12_COMPILER_VALUE_TYPE_OBJECT_CODE = 0,

    /// <include file='D3D12_COMPILER_VALUE_TYPE.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE.D3D12_COMPILER_VALUE_TYPE_METADATA"]/*' />
    D3D12_COMPILER_VALUE_TYPE_METADATA = 1,

    /// <include file='D3D12_COMPILER_VALUE_TYPE.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE.D3D12_COMPILER_VALUE_TYPE_DEBUG_PDB"]/*' />
    D3D12_COMPILER_VALUE_TYPE_DEBUG_PDB = 2,

    /// <include file='D3D12_COMPILER_VALUE_TYPE.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE.D3D12_COMPILER_VALUE_TYPE_PERFORMANCE_DATA"]/*' />
    D3D12_COMPILER_VALUE_TYPE_PERFORMANCE_DATA = 3,
}
