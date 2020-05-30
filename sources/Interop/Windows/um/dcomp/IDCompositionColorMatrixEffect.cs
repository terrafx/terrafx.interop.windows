// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1170A22-3CE2-4966-90D4-55408BFC84C4")]
    public unsafe partial struct IDCompositionColorMatrixEffect
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionColorMatrixEffect* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionColorMatrixEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionColorMatrixEffect* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInput(IDCompositionColorMatrixEffect* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrix(IDCompositionColorMatrixEffect* pThis, [NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement(IDCompositionColorMatrixEffect* pThis, int row, int column, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement1(IDCompositionColorMatrixEffect* pThis, int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlphaMode(IDCompositionColorMatrixEffect* pThis, D2D1_COLORMATRIX_ALPHA_MODE mode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClampOutput(IDCompositionColorMatrixEffect* pThis, [NativeTypeName("BOOL")] int clamp);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInput>(lpVtbl->SetInput)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D2D1_MATRIX_5X4_F &")] D2D_MATRIX_5X4_F* matrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrix>(lpVtbl->SetMatrix)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement>(lpVtbl->SetMatrixElement)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement1>(lpVtbl->SetMatrixElement1)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlphaMode>(lpVtbl->SetAlphaMode)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clamp)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClampOutput>(lpVtbl->SetClampOutput)((IDCompositionColorMatrixEffect*)Unsafe.AsPointer(ref this), clamp);
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

            [NativeTypeName("HRESULT (const D2D1_MATRIX_5X4_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrix;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement1;

            [NativeTypeName("HRESULT (D2D1_COLORMATRIX_ALPHA_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetAlphaMode;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetClampOutput;
        }
    }
}
