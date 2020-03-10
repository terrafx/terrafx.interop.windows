// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11FunctionReflection* pThis, [NativeTypeName("D3D11_FUNCTION_DESC *")] D3D11_FUNCTION_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public delegate ID3D11ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(ID3D11FunctionReflection* pThis, [NativeTypeName("UINT")] uint BufferIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public delegate ID3D11ShaderReflectionConstantBuffer* _GetConstantBufferByName(ID3D11FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDesc(ID3D11FunctionReflection* pThis, [NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public delegate ID3D11ShaderReflectionVariable* _GetVariableByName(ID3D11FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDescByName(ID3D11FunctionReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11FunctionParameterReflection *")]
        public delegate ID3D11FunctionParameterReflection* _GetFunctionParameter(ID3D11FunctionReflection* pThis, [NativeTypeName("INT")] int ParameterIndex);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_FUNCTION_DESC *")] D3D11_FUNCTION_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("ID3D11FunctionParameterReflection *")]
        public ID3D11FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFunctionParameter>(lpVtbl->GetFunctionParameter)((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByIndex;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDesc;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDescByName;

            [NativeTypeName("ID3D11FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFunctionParameter;
        }
    }
}
