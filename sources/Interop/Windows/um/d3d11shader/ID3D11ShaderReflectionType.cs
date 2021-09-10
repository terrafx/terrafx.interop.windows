// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6E6FFA6A-9BAE-4613-A51E-91652D508C21")]
    public unsafe partial struct ID3D11ShaderReflectionType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_SHADER_TYPE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, D3D11_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D11ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[1]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, sbyte*, ID3D11ShaderReflectionType*>)(lpVtbl[2]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(ID3D11ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D11ShaderReflectionType* GetSubType()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[5]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D11ShaderReflectionType* GetBaseClass()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[6]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaces()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ID3D11ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[8]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsOfType(ID3D11ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface(ID3D11ShaderReflectionType* pBase)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }
    }
}
