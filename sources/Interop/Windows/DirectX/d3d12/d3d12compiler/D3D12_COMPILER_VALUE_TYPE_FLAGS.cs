// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using static TerraFX.Interop.DirectX.D3D12_COMPILER_VALUE_TYPE;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS"]/*' />
[Flags]
public enum D3D12_COMPILER_VALUE_TYPE_FLAGS
{
    /// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS.D3D12_COMPILER_VALUE_TYPE_FLAGS_NONE"]/*' />
    D3D12_COMPILER_VALUE_TYPE_FLAGS_NONE = 0,

    /// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS.D3D12_COMPILER_VALUE_TYPE_FLAGS_OBJECT_CODE"]/*' />
    D3D12_COMPILER_VALUE_TYPE_FLAGS_OBJECT_CODE = (1 << D3D12_COMPILER_VALUE_TYPE_OBJECT_CODE),

    /// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS.D3D12_COMPILER_VALUE_TYPE_FLAGS_METADATA"]/*' />
    D3D12_COMPILER_VALUE_TYPE_FLAGS_METADATA = (1 << D3D12_COMPILER_VALUE_TYPE_METADATA),

    /// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS.D3D12_COMPILER_VALUE_TYPE_FLAGS_DEBUG_PDB"]/*' />
    D3D12_COMPILER_VALUE_TYPE_FLAGS_DEBUG_PDB = (1 << D3D12_COMPILER_VALUE_TYPE_DEBUG_PDB),

    /// <include file='D3D12_COMPILER_VALUE_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_COMPILER_VALUE_TYPE_FLAGS.D3D12_COMPILER_VALUE_TYPE_FLAGS_PERFORMANCE_DATA"]/*' />
    D3D12_COMPILER_VALUE_TYPE_FLAGS_PERFORMANCE_DATA = (1 << D3D12_COMPILER_VALUE_TYPE_PERFORMANCE_DATA),
}
