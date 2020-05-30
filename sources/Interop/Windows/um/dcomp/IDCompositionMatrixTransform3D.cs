// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B3363F0-643B-41b7-B6E0-CCF22D34467C")]
    public unsafe partial struct IDCompositionMatrixTransform3D
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionMatrixTransform3D* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionMatrixTransform3D* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionMatrixTransform3D* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrix(IDCompositionMatrixTransform3D* pThis, [NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement(IDCompositionMatrixTransform3D* pThis, int row, int column, float value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMatrixElement1(IDCompositionMatrixTransform3D* pThis, int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrix>(lpVtbl->SetMatrix)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement>(lpVtbl->SetMatrixElement)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMatrixElement1>(lpVtbl->SetMatrixElement1)((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const D3DMATRIX &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrix;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetMatrixElement1;
        }
    }
}
