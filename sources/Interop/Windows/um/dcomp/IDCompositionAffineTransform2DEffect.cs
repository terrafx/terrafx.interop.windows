// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0B74B9E8-CDD6-492F-BBBC-5ED32157026D")]
    public unsafe partial struct IDCompositionAffineTransform2DEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode)
        {
            return lpVtbl->SetInterpolationMode((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(D2D1_BORDER_MODE borderMode)
        {
            return lpVtbl->SetBorderMode((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrix([NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix)
        {
            return lpVtbl->SetTransformMatrix((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), transformMatrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, float value)
        {
            return lpVtbl->SetTransformMatrixElement((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTransformMatrixElement1((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(float sharpness)
        {
            return lpVtbl->SetSharpness((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetSharpness1((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE, int> SetInterpolationMode;

            [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D1_BORDER_MODE, int> SetBorderMode;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, D2D_MATRIX_3X2_F*, int> SetTransformMatrix;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, int, int, float, int> SetTransformMatrixElement;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, int, int, IDCompositionAnimation*, int> SetTransformMatrixElement1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, float, int> SetSharpness;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionAffineTransform2DEffect*, IDCompositionAnimation*, int> SetSharpness1;
        }
    }
}
