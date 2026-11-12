// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MLIR_PROGRAM_BINDING_TYPE.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_TYPE"]/*' />
public enum D3D12_MLIR_PROGRAM_BINDING_TYPE
{
    /// <include file='D3D12_MLIR_PROGRAM_BINDING_TYPE.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_TYPE.D3D12_MLIR_PROGRAM_BINDING_TYPE_GPU_VIRTUAL_ADDRESS"]/*' />
    D3D12_MLIR_PROGRAM_BINDING_TYPE_GPU_VIRTUAL_ADDRESS = 0,

    /// <include file='D3D12_MLIR_PROGRAM_BINDING_TYPE.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_TYPE.D3D12_MLIR_PROGRAM_BINDING_TYPE_GPU_DESCRIPTOR"]/*' />
    D3D12_MLIR_PROGRAM_BINDING_TYPE_GPU_DESCRIPTOR = 1,

    /// <include file='D3D12_MLIR_PROGRAM_BINDING_TYPE.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING_TYPE.D3D12_MLIR_PROGRAM_BINDING_TYPE_CPU"]/*' />
    D3D12_MLIR_PROGRAM_BINDING_TYPE_CPU = 2,
}
