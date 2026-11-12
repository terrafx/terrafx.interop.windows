// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MLIR_PROGRAM_BINDING_FLAGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_FLAGS"]/*' />
public enum D3D12_MLIR_PROGRAM_BINDING_FLAGS
{
    /// <include file='D3D12_MLIR_PROGRAM_BINDING_FLAGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_FLAGS.D3D12_MLIR_PROGRAM_BINDING_FLAG_NONE"]/*' />
    D3D12_MLIR_PROGRAM_BINDING_FLAG_NONE = 0,

    /// <include file='D3D12_MLIR_PROGRAM_BINDING_FLAGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_FLAGS.D3D12_MLIR_PROGRAM_BINDING_FLAG_VOLATILE_DESCRIPTOR"]/*' />
    D3D12_MLIR_PROGRAM_BINDING_FLAG_VOLATILE_DESCRIPTOR = 0x1,
}
