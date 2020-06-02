// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    public unsafe partial struct ID2D1InkStyle
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetNibTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->SetNibTransform((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->GetNibTransform((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
        {
            lpVtbl->SetNibShape((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
        }

        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            return lpVtbl->GetNibShape((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void> SetNibTransform;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void> GetNibTransform;

            [NativeTypeName("void (D2D1_INK_NIB_SHAPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE, void> SetNibShape;

            [NativeTypeName("D2D1_INK_NIB_SHAPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE> GetNibShape;
        }
    }
}
