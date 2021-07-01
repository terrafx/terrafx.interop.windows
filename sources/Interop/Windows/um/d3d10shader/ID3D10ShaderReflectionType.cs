// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C530AD7D-9B16-4395-A979-BA2ECFF83ADD")]
    public unsafe partial struct ID3D10ShaderReflectionType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_SHADER_TYPE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionType*, D3D10_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionType*, uint, ID3D10ShaderReflectionType*>)(lpVtbl[1]))((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionType*, sbyte*, ID3D10ShaderReflectionType*>)(lpVtbl[2]))((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }
    }
}
