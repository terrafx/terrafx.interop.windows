// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12FunctionReflection* pThis, [NativeTypeName("D3D12_FUNCTION_DESC *")] D3D12_FUNCTION_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(ID3D12FunctionReflection* pThis, [NativeTypeName("UINT")] uint BufferIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByName(ID3D12FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDesc(ID3D12FunctionReflection* pThis, [NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public delegate ID3D12ShaderReflectionVariable* _GetVariableByName(ID3D12FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDescByName(ID3D12FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12FunctionParameterReflection *")]
        public delegate ID3D12FunctionParameterReflection* _GetFunctionParameter(ID3D12FunctionReflection* pThis, [NativeTypeName("INT")] int ParameterIndex);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_FUNCTION_DESC *")] D3D12_FUNCTION_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("ID3D12FunctionParameterReflection *")]
        public ID3D12FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFunctionParameter>(lpVtbl->GetFunctionParameter)((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByIndex;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDesc;

            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDescByName;

            [NativeTypeName("ID3D12FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFunctionParameter;
        }
    }
}
