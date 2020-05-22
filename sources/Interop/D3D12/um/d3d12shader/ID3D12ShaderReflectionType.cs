// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12ShaderReflectionType* pThis, [NativeTypeName("D3D12_SHADER_TYPE_DESC *")] D3D12_SHADER_TYPE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public delegate ID3D12ShaderReflectionType* _GetMemberTypeByIndex(ID3D12ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public delegate ID3D12ShaderReflectionType* _GetMemberTypeByName(ID3D12ShaderReflectionType* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("LPCSTR")]
        public delegate sbyte* _GetMemberTypeName(ID3D12ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(ID3D12ShaderReflectionType* pThis, [NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public delegate ID3D12ShaderReflectionType* _GetSubType(ID3D12ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public delegate ID3D12ShaderReflectionType* _GetBaseClass(ID3D12ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNumInterfaces(ID3D12ShaderReflectionType* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public delegate ID3D12ShaderReflectionType* _GetInterfaceByIndex(ID3D12ShaderReflectionType* pThis, [NativeTypeName("UINT")] uint uIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsOfType(ID3D12ShaderReflectionType* pThis, [NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ImplementsInterface(ID3D12ShaderReflectionType* pThis, [NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pBase);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_TYPE_DESC *")] D3D12_SHADER_TYPE_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByIndex>(lpVtbl->GetMemberTypeByIndex)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByName>(lpVtbl->GetMemberTypeByName)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeName>(lpVtbl->GetMemberTypeName)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetSubType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSubType>(lpVtbl->GetSubType)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBaseClass>(lpVtbl->GetBaseClass)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumInterfaces>(lpVtbl->GetNumInterfaces)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterfaceByIndex>(lpVtbl->GetInterfaceByIndex)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsOfType>(lpVtbl->IsOfType)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pBase)
        {
            return Marshal.GetDelegateForFunctionPointer<_ImplementsInterface>(lpVtbl->ImplementsInterface)((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeByIndex;

            [NativeTypeName("ID3D12ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeByName;

            [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemberTypeName;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsEqual;

            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSubType;

            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBaseClass;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNumInterfaces;

            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInterfaceByIndex;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsOfType;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ImplementsInterface;
        }
    }
}
