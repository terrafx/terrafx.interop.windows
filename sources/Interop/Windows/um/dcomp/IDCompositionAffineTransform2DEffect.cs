// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0B74B9E8-CDD6-492F-BBBC-5ED32157026D")]
    [NativeTypeName("struct IDCompositionAffineTransform2DEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionAffineTransform2DEffect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint>)(lpVtbl[1]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint>)(lpVtbl[2]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE, int>)(lpVtbl[4]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(D2D1_BORDER_MODE borderMode)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D1_BORDER_MODE, int>)(lpVtbl[5]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrix([NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[6]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), transformMatrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, float value)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, int, int, float, int>)(lpVtbl[7]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, int, int, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(float sharpness)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, float, int>)(lpVtbl[9]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionAffineTransform2DEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
