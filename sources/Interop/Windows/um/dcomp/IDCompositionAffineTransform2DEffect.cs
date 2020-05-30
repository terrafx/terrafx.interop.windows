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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionAffineTransform2DEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionAffineTransform2DEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionAffineTransform2DEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionAffineTransform2DEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInterpolationMode(IDCompositionAffineTransform2DEffect* pThis, D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBorderMode(IDCompositionAffineTransform2DEffect* pThis, D2D1_BORDER_MODE borderMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransformMatrix(IDCompositionAffineTransform2DEffect* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransformMatrixElement(IDCompositionAffineTransform2DEffect* pThis, int row, int column, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTransformMatrixElement1(IDCompositionAffineTransform2DEffect* pThis, int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSharpness(IDCompositionAffineTransform2DEffect* pThis, float sharpness);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSharpness1(IDCompositionAffineTransform2DEffect* pThis, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterpolationMode(D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE interpolationMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(D2D1_BORDER_MODE borderMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBorderMode>(lpVtbl->SetBorderMode)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), borderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrix([NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* transformMatrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransformMatrix>(lpVtbl->SetTransformMatrix)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), transformMatrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransformMatrixElement>(lpVtbl->SetTransformMatrixElement)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTransformMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTransformMatrixElement1>(lpVtbl->SetTransformMatrixElement1)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(float sharpness)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSharpness>(lpVtbl->SetSharpness)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSharpness1>(lpVtbl->SetSharpness1)((IDCompositionAffineTransform2DEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInput;

            [NativeTypeName("HRESULT (D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInterpolationMode;

            [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetBorderMode;

            [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransformMatrix;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransformMatrixElement;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTransformMatrixElement1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSharpness;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSharpness1;
        }
    }
}
