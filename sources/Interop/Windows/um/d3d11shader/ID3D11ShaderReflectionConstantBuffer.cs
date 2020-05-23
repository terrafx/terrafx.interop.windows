// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB62D63D-93DD-4318-8AE8-C6F83AD371B8")]
    public unsafe partial struct ID3D11ShaderReflectionConstantBuffer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11ShaderReflectionConstantBuffer* pThis, [NativeTypeName("D3D11_SHADER_BUFFER_DESC *")] D3D11_SHADER_BUFFER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public delegate ID3D11ShaderReflectionVariable* _GetVariableByIndex(ID3D11ShaderReflectionConstantBuffer* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public delegate ID3D11ShaderReflectionVariable* _GetVariableByName(ID3D11ShaderReflectionConstantBuffer* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_BUFFER_DESC *")] D3D11_SHADER_BUFFER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByIndex([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVariableByIndex>(lpVtbl->GetVariableByIndex)((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)((ID3D11ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVariableByIndex;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVariableByName;
        }
    }
}
