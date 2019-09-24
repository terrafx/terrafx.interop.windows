// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
    public unsafe struct ID3D12ShaderReflectionVariable
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] ID3D12ShaderReflectionVariable* This,
            [Out] D3D12_SHADER_VARIABLE_DESC* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* __GetType(
            [In] ID3D12ShaderReflectionVariable* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionConstantBuffer* _GetBuffer(
            [In] ID3D12ShaderReflectionVariable* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate uint _GetInterfaceSlot(
            [In] ID3D12ShaderReflectionVariable* This,
            [In, NativeTypeName("UINT")] uint uArrayIndex
        );

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] D3D12_SHADER_VARIABLE_DESC* pDesc
        )
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        public ID3D12ShaderReflectionType* _GetType()
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(
                    This
                );
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(
                    This
                );
            }
        }

        public uint GetInterfaceSlot(
            [In, NativeTypeName("UINT")] uint uArrayIndex
        )
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterfaceSlot>(lpVtbl->GetInterfaceSlot)(
                    This,
                    uArrayIndex
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr GetDesc;

            public IntPtr _GetType;

            public IntPtr GetBuffer;

            public IntPtr GetInterfaceSlot;
        }
    }
}
