// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D10EffectTechnique
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public BOOL IsValid()
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, int>)(lpVtbl[0]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public HRESULT GetDesc(D3D10_TECHNIQUE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_TECHNIQUE_DESC*, int>)(lpVtbl[1]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D10EffectVariable* GetAnnotationByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectVariable*>)(lpVtbl[2]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[3]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D10EffectPass* GetPassByIndex(uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectPass*>)(lpVtbl[4]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D10EffectPass* GetPassByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectPass*>)(lpVtbl[5]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_STATE_BLOCK_MASK*, int>)(lpVtbl[6]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pStateBlockMask);
        }
    }
}
