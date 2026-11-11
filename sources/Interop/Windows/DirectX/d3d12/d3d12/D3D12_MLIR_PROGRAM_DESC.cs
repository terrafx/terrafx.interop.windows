// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MLIR_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_DESC"]/*' />
public unsafe partial struct D3D12_MLIR_PROGRAM_DESC
{
    /// <include file='D3D12_MLIR_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_DESC.ProgramName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* ProgramName;

    /// <include file='D3D12_MLIR_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_DESC.pBytecode"]/*' />
    [NativeTypeName("const void *")]
    public void* pBytecode;

    /// <include file='D3D12_MLIR_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_DESC.BytecodeSizeInBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint BytecodeSizeInBytes;
}
