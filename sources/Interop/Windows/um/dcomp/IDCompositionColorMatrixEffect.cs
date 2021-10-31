// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1170A22-3CE2-4966-90D4-55408BFC84C4")]
    [NativeTypeName("struct IDCompositionColorMatrixEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionColorMatrixEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint>)(lpVtbl[1]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint>)(lpVtbl[2]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, D2D_MATRIX_5X4_F*, int>)(lpVtbl[4]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetMatrixElement(int row, int column, float value)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, int, int, float, int>)(lpVtbl[6]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, int, int, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, D2D1_COLORMATRIX_ALPHA_MODE, int>)(lpVtbl[7]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetClampOutput(BOOL clamp)
        {
            return ((delegate* unmanaged<IDCompositionColorMatrixEffect*, BOOL, int>)(lpVtbl[8]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), clamp);
        }
    }
}
