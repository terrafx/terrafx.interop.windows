// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10EffectRasterizerVariable : ID3D10EffectVariable")]
    public unsafe partial struct ID3D10EffectRasterizerVariable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsValid()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, int>)(lpVtbl[0]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new ID3D10EffectType* GetType()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectType*>)(lpVtbl[1]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_EFFECT_VARIABLE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, D3D10_EFFECT_VARIABLE_DESC*, int>)(lpVtbl[2]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetAnnotationByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[3]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[4]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetMemberByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[5]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetMemberByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[6]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetMemberBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[7]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Semantic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVariable* GetElement([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, uint, ID3D10EffectVariable*>)(lpVtbl[8]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectConstantBuffer* GetParentConstantBuffer()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectConstantBuffer*>)(lpVtbl[9]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectScalarVariable* AsScalar()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectScalarVariable*>)(lpVtbl[10]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectVectorVariable* AsVector()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectVectorVariable*>)(lpVtbl[11]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectMatrixVariable* AsMatrix()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectMatrixVariable*>)(lpVtbl[12]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectStringVariable* AsString()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectStringVariable*>)(lpVtbl[13]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectShaderResourceVariable* AsShaderResource()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectShaderResourceVariable*>)(lpVtbl[14]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectRenderTargetViewVariable* AsRenderTargetView()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectRenderTargetViewVariable*>)(lpVtbl[15]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectDepthStencilViewVariable* AsDepthStencilView()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectDepthStencilViewVariable*>)(lpVtbl[16]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectConstantBuffer* AsConstantBuffer()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectConstantBuffer*>)(lpVtbl[17]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectShaderVariable* AsShader()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectShaderVariable*>)(lpVtbl[18]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectBlendVariable* AsBlend()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectBlendVariable*>)(lpVtbl[19]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectDepthStencilVariable* AsDepthStencil()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectDepthStencilVariable*>)(lpVtbl[20]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectRasterizerVariable* AsRasterizer()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectRasterizerVariable*>)(lpVtbl[21]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10EffectSamplerVariable* AsSampler()
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, ID3D10EffectSamplerVariable*>)(lpVtbl[22]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRawValue(void* pData, [NativeTypeName("UINT")] uint Offset, [NativeTypeName("UINT")] uint ByteCount)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, void*, uint, uint, int>)(lpVtbl[23]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), pData, Offset, ByteCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRawValue(void* pData, [NativeTypeName("UINT")] uint Offset, [NativeTypeName("UINT")] uint ByteCount)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, void*, uint, uint, int>)(lpVtbl[24]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), pData, Offset, ByteCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterizerState([NativeTypeName("UINT")] uint Index, ID3D10RasterizerState** ppRasterizerState)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, uint, ID3D10RasterizerState**, int>)(lpVtbl[25]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Index, ppRasterizerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackingStore([NativeTypeName("UINT")] uint Index, D3D10_RASTERIZER_DESC* pRasterizerDesc)
        {
            return ((delegate* unmanaged<ID3D10EffectRasterizerVariable*, uint, D3D10_RASTERIZER_DESC*, int>)(lpVtbl[26]))((ID3D10EffectRasterizerVariable*)Unsafe.AsPointer(ref this), Index, pRasterizerDesc);
        }
    }
}
