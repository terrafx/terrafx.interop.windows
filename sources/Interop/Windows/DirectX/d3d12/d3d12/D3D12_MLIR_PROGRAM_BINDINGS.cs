// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MLIR_PROGRAM_BINDINGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDINGS"]/*' />
public unsafe partial struct D3D12_MLIR_PROGRAM_BINDINGS
{
    /// <include file='D3D12_MLIR_PROGRAM_BINDINGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDINGS.NumBindings"]/*' />
    public uint NumBindings;

    /// <include file='D3D12_MLIR_PROGRAM_BINDINGS.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDINGS.pBindings"]/*' />
    [NativeTypeName("const D3D12_MLIR_PROGRAM_BINDING *")]
    public D3D12_MLIR_PROGRAM_BINDING* pBindings;
}
