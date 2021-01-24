// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D10EffectTechnique
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsValid()
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, int>)(lpVtbl[0]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D10_TECHNIQUE_DESC *")] D3D10_TECHNIQUE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_TECHNIQUE_DESC*, int>)(lpVtbl[1]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10EffectVariable *")]
        public ID3D10EffectVariable* GetAnnotationByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectVariable*>)(lpVtbl[2]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10EffectVariable *")]
        public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[3]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10EffectPass *")]
        public ID3D10EffectPass* GetPassByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectPass*>)(lpVtbl[4]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10EffectPass *")]
        public ID3D10EffectPass* GetPassByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectPass*>)(lpVtbl[5]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeStateBlockMask([NativeTypeName("D3D10_STATE_BLOCK_MASK *")] D3D10_STATE_BLOCK_MASK* pStateBlockMask)
        {
            return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_STATE_BLOCK_MASK*, int>)(lpVtbl[6]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pStateBlockMask);
        }
    }
}
