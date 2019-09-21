// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
    public unsafe struct ID3D12FunctionReflection
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] ID3D12FunctionReflection* This,
            [Out] D3D12_FUNCTION_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("UINT")] uint BufferIndex
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByName(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetResourceBindingDesc(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("UINT")] uint ResourceIndex,
            [Out] D3D12_SHADER_INPUT_BIND_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionVariable* _GetVariableByName(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetResourceBindingDescByName(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("LPCSTR")] sbyte* Name,
            [Out] D3D12_SHADER_INPUT_BIND_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12FunctionParameterReflection* _GetFunctionParameter(
            [In] ID3D12FunctionReflection* This,
            [In, NativeTypeName("INT")] int ParameterIndex
        );
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] D3D12_FUNCTION_DESC* pDesc
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(
            [In, NativeTypeName("UINT")] uint BufferIndex
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)(
                    This,
                    BufferIndex
                );
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc(
            [In, NativeTypeName("UINT")] uint ResourceIndex,
            [Out] D3D12_SHADER_INPUT_BIND_DESC* pDesc
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)(
                    This,
                    ResourceIndex,
                    pDesc
                );
            }
        }

        public ID3D12ShaderReflectionVariable* GetVariableByName(
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName(
            [In, NativeTypeName("LPCSTR")] sbyte* Name,
            [Out] D3D12_SHADER_INPUT_BIND_DESC* pDesc
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)(
                    This,
                    Name,
                    pDesc
                );
            }
        }

        public ID3D12FunctionParameterReflection* GetFunctionParameter(
            [In, NativeTypeName("INT")] int ParameterIndex
        )
        {
            fixed (ID3D12FunctionReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFunctionParameter>(lpVtbl->GetFunctionParameter)(
                    This,
                    ParameterIndex
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IntPtr GetDesc;

            public IntPtr GetConstantBufferByIndex;

            public IntPtr GetConstantBufferByName;

            public IntPtr GetResourceBindingDesc;

            public IntPtr GetVariableByName;

            public IntPtr GetResourceBindingDescByName;

            public IntPtr GetFunctionParameter;
            #endregion
        }
        #endregion
    }
}
