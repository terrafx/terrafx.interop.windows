// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    public unsafe partial struct ID2D1InkStyle
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1InkStyle* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1InkStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1InkStyle* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1InkStyle* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetNibTransform(ID2D1InkStyle* pThis, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetNibTransform(ID2D1InkStyle* pThis, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetNibShape(ID2D1InkStyle* pThis, D2D1_INK_NIB_SHAPE nibShape);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_INK_NIB_SHAPE _GetNibShape(ID2D1InkStyle* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetNibTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_SetNibTransform>(lpVtbl->SetNibTransform)((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            Marshal.GetDelegateForFunctionPointer<_GetNibTransform>(lpVtbl->GetNibTransform)((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
        {
            Marshal.GetDelegateForFunctionPointer<_SetNibShape>(lpVtbl->SetNibShape)((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
        }

        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNibShape>(lpVtbl->GetNibShape)((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetNibTransform;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNibTransform;

            [NativeTypeName("void (D2D1_INK_NIB_SHAPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetNibShape;

            [NativeTypeName("D2D1_INK_NIB_SHAPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNibShape;
        }
    }
}
