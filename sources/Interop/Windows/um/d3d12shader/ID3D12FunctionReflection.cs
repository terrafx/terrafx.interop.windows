// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_FUNCTION_DESC *")] D3D12_FUNCTION_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return lpVtbl->GetConstantBufferByIndex((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetConstantBufferByName((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDesc((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetVariableByName((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDescByName((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("ID3D12FunctionParameterReflection *")]
        public ID3D12FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return lpVtbl->GetFunctionParameter((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, D3D12_FUNCTION_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, uint, D3D12_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;

            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, sbyte*, ID3D12ShaderReflectionVariable*> GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, sbyte*, D3D12_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;

            [NativeTypeName("ID3D12FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*> GetFunctionParameter;
        }
    }
}
