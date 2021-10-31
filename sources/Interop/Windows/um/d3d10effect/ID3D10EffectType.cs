// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D10EffectType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public BOOL IsValid()
        {
            return ((delegate* unmanaged<ID3D10EffectType*, int>)(lpVtbl[0]))((ID3D10EffectType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_EFFECT_TYPE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, D3D10_EFFECT_TYPE_DESC*, int>)(lpVtbl[1]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D10EffectType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, uint, ID3D10EffectType*>)(lpVtbl[2]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public ID3D10EffectType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, sbyte*, ID3D10EffectType*>)(lpVtbl[3]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D10EffectType* GetMemberTypeBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, sbyte*, ID3D10EffectType*>)(lpVtbl[4]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), Semantic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberName([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, uint, sbyte*>)(lpVtbl[5]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberSemantic([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectType*, uint, sbyte*>)(lpVtbl[6]))((ID3D10EffectType*)Unsafe.AsPointer(ref this), Index);
        }
    }
}
