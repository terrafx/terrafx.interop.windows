// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_TYPE_DESC *")] D3D12_SHADER_TYPE_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, D3D12_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[1]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, sbyte*, ID3D12ShaderReflectionType*>)(lpVtbl[2]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetSubType()
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[5]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[6]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public ID3D12ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[8]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pType)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface([NativeTypeName("ID3D12ShaderReflectionType *")] ID3D12ShaderReflectionType* pBase)
        {
            return ((delegate* stdcall<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }
    }
}
