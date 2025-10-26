// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_BYTECODE.xml' path='doc/member[@name="D3D12_SHADER_BYTECODE"]/*' />
[NativeTypeName("struct CD3DX12_SHADER_BYTECODE : D3D12_SHADER_BYTECODE")]
[NativeInheritance("D3D12_SHADER_BYTECODE")]
public unsafe partial struct D3D12_SHADER_BYTECODE
{
    public D3D12_SHADER_BYTECODE(ID3DBlob* pShaderBlob)
    {
        pShaderBytecode = pShaderBlob->GetBufferPointer();
        BytecodeLength = pShaderBlob->GetBufferSize();
    }

    public D3D12_SHADER_BYTECODE([NativeTypeName("const void *")] void* _pShaderBytecode, [NativeTypeName("SIZE_T")] nuint bytecodeLength)
    {
        pShaderBytecode = _pShaderBytecode;
        BytecodeLength = bytecodeLength;
    }
}
