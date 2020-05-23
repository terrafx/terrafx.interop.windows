// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("51F23923-F3E5-4BD1-91CB-606177D8DB4C")]
    public unsafe partial struct ID3D11ShaderReflectionVariable
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11ShaderReflectionVariable* pThis, [NativeTypeName("D3D11_SHADER_VARIABLE_DESC *")] D3D11_SHADER_VARIABLE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetType(ID3D11ShaderReflectionVariable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public delegate ID3D11ShaderReflectionConstantBuffer* _GetBuffer(ID3D11ShaderReflectionVariable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetInterfaceSlot(ID3D11ShaderReflectionVariable* pThis, [NativeTypeName("UINT")] uint uArrayIndex);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_VARIABLE_DESC *")] D3D11_SHADER_VARIABLE_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public new ID3D11ShaderReflectionType* GetType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetBuffer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetInterfaceSlot([NativeTypeName("UINT")] uint uArrayIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterfaceSlot>(lpVtbl->GetInterfaceSlot)((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_SHADER_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBuffer;

            [NativeTypeName("UINT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInterfaceSlot;
        }
    }
}
