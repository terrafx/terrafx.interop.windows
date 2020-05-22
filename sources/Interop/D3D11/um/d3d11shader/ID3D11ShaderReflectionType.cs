// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6E6FFA6A-9BAE-4613-A51E-91652D508C21")]
    public unsafe partial struct ID3D11ShaderReflectionType
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11ShaderReflectionType* pThis, [NativeTypeName("D3D11_SHADER_TYPE_DESC *")] D3D11_SHADER_TYPE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetMemberTypeByIndex(ID3D11ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetMemberTypeByName(ID3D11ShaderReflectionType* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("LPCSTR")]
        public delegate sbyte* _GetMemberTypeName(ID3D11ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(ID3D11ShaderReflectionType* pThis, [NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetSubType(ID3D11ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetBaseClass(ID3D11ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNumInterfaces(ID3D11ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public delegate ID3D11ShaderReflectionType* _GetInterfaceByIndex(ID3D11ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint uIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsOfType(ID3D11ShaderReflectionType* pThis, [NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ImplementsInterface(ID3D11ShaderReflectionType* pThis, [NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pBase);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_TYPE_DESC *")] D3D11_SHADER_TYPE_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByIndex>(lpVtbl->GetMemberTypeByIndex)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByName>(lpVtbl->GetMemberTypeByName)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeName>(lpVtbl->GetMemberTypeName)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetSubType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSubType>(lpVtbl->GetSubType)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetBaseClass()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBaseClass>(lpVtbl->GetBaseClass)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumInterfaces>(lpVtbl->GetNumInterfaces)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterfaceByIndex>(lpVtbl->GetInterfaceByIndex)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsOfType>(lpVtbl->IsOfType)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pBase)
        {
            return Marshal.GetDelegateForFunctionPointer<_ImplementsInterface>(lpVtbl->ImplementsInterface)((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeByIndex;

            [NativeTypeName("ID3D11ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeByName;

            [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeName;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsEqual;

            [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSubType;

            [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBaseClass;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNumInterfaces;

            [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInterfaceByIndex;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsOfType;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ImplementsInterface;
        }
    }
}
