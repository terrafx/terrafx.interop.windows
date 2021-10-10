// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10Effect : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10Effect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Effect*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Effect*, uint>)(lpVtbl[1]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Effect*, uint>)(lpVtbl[2]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public int IsValid()
        {
            return ((delegate* unmanaged<ID3D10Effect*, int>)(lpVtbl[3]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("BOOL")]
        public int IsPool()
        {
            return ((delegate* unmanaged<ID3D10Effect*, int>)(lpVtbl[4]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(ID3D10Device** ppDevice)
        {
            return ((delegate* unmanaged<ID3D10Effect*, ID3D10Device**, int>)(lpVtbl[5]))((ID3D10Effect*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_EFFECT_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10Effect*, D3D10_EFFECT_DESC*, int>)(lpVtbl[6]))((ID3D10Effect*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public ID3D10EffectConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectConstantBuffer*>)(lpVtbl[7]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ID3D10EffectConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectConstantBuffer*>)(lpVtbl[8]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public ID3D10EffectVariable* GetVariableByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectVariable*>)(lpVtbl[9]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public ID3D10EffectVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[10]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public ID3D10EffectVariable* GetVariableBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
        {
            return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[11]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Semantic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public ID3D10EffectTechnique* GetTechniqueByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectTechnique*>)(lpVtbl[12]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public ID3D10EffectTechnique* GetTechniqueByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectTechnique*>)(lpVtbl[13]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Optimize()
        {
            return ((delegate* unmanaged<ID3D10Effect*, int>)(lpVtbl[14]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("BOOL")]
        public int IsOptimized()
        {
            return ((delegate* unmanaged<ID3D10Effect*, int>)(lpVtbl[15]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
        }
    }
}
