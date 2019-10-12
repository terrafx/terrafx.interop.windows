// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
    public unsafe partial struct ID3D12ShaderReflectionVariable
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12ShaderReflectionVariable* This, D3D12_SHADER_VARIABLE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* __GetType(ID3D12ShaderReflectionVariable* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetBuffer(ID3D12ShaderReflectionVariable* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate uint _GetInterfaceSlot(ID3D12ShaderReflectionVariable* This, [NativeTypeName("UINT")] uint uArrayIndex);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_SHADER_VARIABLE_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        public ID3D12ShaderReflectionType* _GetType()
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This);
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(This);
            }
        }

        public uint GetInterfaceSlot([NativeTypeName("UINT")] uint uArrayIndex)
        {
            fixed (ID3D12ShaderReflectionVariable* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterfaceSlot>(lpVtbl->GetInterfaceSlot)(This, uArrayIndex);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr GetDesc;

            public IntPtr _GetType;

            public IntPtr GetBuffer;

            public IntPtr GetInterfaceSlot;
        }
    }
}
