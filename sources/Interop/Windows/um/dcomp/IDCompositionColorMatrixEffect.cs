// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1170A22-3CE2-4966-90D4-55408BFC84C4")]
    [NativeTypeName("struct IDCompositionColorMatrixEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionColorMatrixEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, uint>)(lpVtbl[1]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, uint>)(lpVtbl[2]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, D2D_MATRIX_5X4_F*, int>)(lpVtbl[4]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, int, int, float, int>)(lpVtbl[5]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, int, int, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, D2D1_COLORMATRIX_ALPHA_MODE, int>)(lpVtbl[7]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clamp)
        {
            return ((delegate* stdcall<IDCompositionColorMatrixEffect*, int, int>)(lpVtbl[8]))((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), clamp);
        }
    }
}
