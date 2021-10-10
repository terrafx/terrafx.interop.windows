// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D10EffectPass
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("BOOL")]
        public int IsValid()
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, int>)(lpVtbl[0]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_PASS_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_DESC*, int>)(lpVtbl[1]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int>)(lpVtbl[2]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeometryShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int>)(lpVtbl[4]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D10EffectVariable* GetAnnotationByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, uint, ID3D10EffectVariable*>)(lpVtbl[5]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[6]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Apply([NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, uint, int>)(lpVtbl[7]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask)
        {
            return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_STATE_BLOCK_MASK*, int>)(lpVtbl[8]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pStateBlockMask);
        }
    }
}
