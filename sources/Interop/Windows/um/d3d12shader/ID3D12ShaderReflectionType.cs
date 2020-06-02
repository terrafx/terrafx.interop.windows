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

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_TYPE_DESC *")] D3D12_SHADER_TYPE_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetMemberTypeByIndex((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetMemberTypeByName((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetMemberTypeName((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return lpVtbl->IsEqual((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetSubType()
        {
            return lpVtbl->GetSubType((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            return lpVtbl->GetBaseClass((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return lpVtbl->GetNumInterfaces((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return lpVtbl->GetInterfaceByIndex((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return lpVtbl->IsOfType((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pBase)
        {
            return lpVtbl->ImplementsInterface((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, D3D12_SHADER_TYPE_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*> GetMemberTypeByIndex;

            [NativeTypeName("ID3D12ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, sbyte*, ID3D12ShaderReflectionType*> GetMemberTypeByName;

            [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, uint, sbyte*> GetMemberTypeName;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> IsEqual;

            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*> GetSubType;

            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*> GetBaseClass;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, uint> GetNumInterfaces;

            [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*> GetInterfaceByIndex;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> IsOfType;

            [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> ImplementsInterface;
        }
    }
}
