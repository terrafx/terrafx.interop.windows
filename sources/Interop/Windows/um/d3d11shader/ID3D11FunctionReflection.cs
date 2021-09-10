// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("207BCECB-D683-4A06-A8A3-9B149B9F73A4")]
    public unsafe partial struct ID3D11FunctionReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_FUNCTION_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, D3D11_FUNCTION_DESC*, int>)(lpVtbl[0]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[1]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[2]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[3]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[4]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[5]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D11FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return ((delegate* unmanaged<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)(lpVtbl[6]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }
    }
}
