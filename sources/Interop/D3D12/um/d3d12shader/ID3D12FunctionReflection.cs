// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12FunctionReflection* This, D3D12_FUNCTION_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(ID3D12FunctionReflection* This, [NativeTypeName("UINT")] uint BufferIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByName(ID3D12FunctionReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDesc(ID3D12FunctionReflection* This, [NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionVariable* _GetVariableByName(ID3D12FunctionReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDescByName(ID3D12FunctionReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12FunctionParameterReflection* _GetFunctionParameter(ID3D12FunctionReflection* This, [NativeTypeName("INT")] int ParameterIndex);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_FUNCTION_DESC* pDesc)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint BufferIndex)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)(This, BufferIndex);
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)(This, ResourceIndex, pDesc);
            }
        }

        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)(This, Name, pDesc);
            }
        }

        public ID3D12FunctionParameterReflection* GetFunctionParameter([NativeTypeName("INT")] int ParameterIndex)
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFunctionParameter>(lpVtbl->GetFunctionParameter)(This, ParameterIndex);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr GetDesc;

            public IntPtr GetConstantBufferByIndex;

            public IntPtr GetConstantBufferByName;

            public IntPtr GetResourceBindingDesc;

            public IntPtr GetVariableByName;

            public IntPtr GetResourceBindingDescByName;

            public IntPtr GetFunctionParameter;
        }
    }
}
