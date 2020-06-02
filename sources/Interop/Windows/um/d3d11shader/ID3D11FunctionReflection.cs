// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("207BCECB-D683-4A06-A8A3-9B149B9F73A4")]
    public unsafe partial struct ID3D11FunctionReflection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_FUNCTION_DESC *")] D3D11_FUNCTION_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return lpVtbl->GetConstantBufferByIndex((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetConstantBufferByName((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDesc((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetVariableByName((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDescByName((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("ID3D11FunctionParameterReflection *")]
        public ID3D11FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return lpVtbl->GetFunctionParameter((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, D3D11_FUNCTION_DESC*, int> GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionVariable*> GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;

            [NativeTypeName("ID3D11FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*> GetFunctionParameter;
        }
    }
}
