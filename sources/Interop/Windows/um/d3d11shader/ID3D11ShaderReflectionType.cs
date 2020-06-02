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

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_TYPE_DESC *")] D3D11_SHADER_TYPE_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetMemberTypeByIndex((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetMemberTypeByName((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetMemberTypeName((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType)
        {
            return lpVtbl->IsEqual((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetSubType()
        {
            return lpVtbl->GetSubType((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetBaseClass()
        {
            return lpVtbl->GetBaseClass((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return lpVtbl->GetNumInterfaces((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D11ShaderReflectionType *")]
        public ID3D11ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return lpVtbl->GetInterfaceByIndex((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pType)
        {
            return lpVtbl->IsOfType((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface([NativeTypeName("ID3D11ShaderReflectionType *")] ID3D11ShaderReflectionType* pBase)
        {
            return lpVtbl->ImplementsInterface((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, D3D11_SHADER_TYPE_DESC*, int> GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*> GetMemberTypeByIndex;

            [NativeTypeName("ID3D11ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, sbyte*, ID3D11ShaderReflectionType*> GetMemberTypeByName;

            [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, uint, sbyte*> GetMemberTypeName;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int> IsEqual;

            [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*> GetSubType;

            [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*> GetBaseClass;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, uint> GetNumInterfaces;

            [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*> GetInterfaceByIndex;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int> IsOfType;

            [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int> ImplementsInterface;
        }
    }
}
