// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT GetDesc(D3D12_FUNCTION_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, D3D12_FUNCTION_DESC*, int>)(lpVtbl[0]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[1]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[2]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, uint, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[3]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionVariable*>)(lpVtbl[4]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, sbyte*, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[5]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D12FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return ((delegate* unmanaged<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)(lpVtbl[6]))((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }
    }
}
