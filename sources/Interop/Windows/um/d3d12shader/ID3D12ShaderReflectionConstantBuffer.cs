// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7")]
    public unsafe struct ID3D12ShaderReflectionConstantBuffer
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] ID3D12ShaderReflectionConstantBuffer* This,
            [Out] D3D12_SHADER_BUFFER_DESC* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionVariable* _GetVariableByIndex(
            [In] ID3D12ShaderReflectionConstantBuffer* This,
            [In, NativeTypeName("UINT")] uint Index
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionVariable* _GetVariableByName(
            [In] ID3D12ShaderReflectionConstantBuffer* This,
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        );

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] D3D12_SHADER_BUFFER_DESC* pDesc
        )
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        public ID3D12ShaderReflectionVariable* GetVariableByIndex(
            [In, NativeTypeName("UINT")] uint Index
        )
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVariableByIndex>(lpVtbl->GetVariableByIndex)(
                    This,
                    Index
                );
            }
        }

        public ID3D12ShaderReflectionVariable* GetVariableByName(
            [In, NativeTypeName("LPCSTR")] sbyte* Name
        )
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)(
                    This,
                    Name
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr GetDesc;

            public IntPtr GetVariableByIndex;

            public IntPtr GetVariableByName;
        }
    }
}
