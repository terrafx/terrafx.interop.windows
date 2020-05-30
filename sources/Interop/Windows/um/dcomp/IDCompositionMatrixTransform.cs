// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("16CDFF07-C503-419c-83F2-0965C7AF1FA6")]
    public unsafe partial struct IDCompositionMatrixTransform
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionMatrixTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionMatrixTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionMatrixTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrix(IDCompositionMatrixTransform* pThis, [NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement(IDCompositionMatrixTransform* pThis, int row, int column, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement1(IDCompositionMatrixTransform* pThis, int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrix>(lpVtbl->SetMatrix)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement>(lpVtbl->SetMatrixElement)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement1>(lpVtbl->SetMatrixElement1)((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrix;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement1;
        }
    }
}
