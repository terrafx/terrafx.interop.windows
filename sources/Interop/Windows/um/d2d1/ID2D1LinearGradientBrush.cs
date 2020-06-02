// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906AB-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1LinearGradientBrush
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            lpVtbl->SetOpacity((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->SetTransform((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return lpVtbl->GetOpacity((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->GetTransform((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint)
        {
            lpVtbl->SetStartPoint((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), startPoint);
        }

        public void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint)
        {
            lpVtbl->SetEndPoint((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), endPoint);
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetStartPoint()
        {
            D2D_POINT_2F result;
            return *lpVtbl->GetStartPoint((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetEndPoint()
        {
            D2D_POINT_2F result;
            return *lpVtbl->GetEndPoint((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        public void GetGradientStopCollection([NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            lpVtbl->GetGradientStopCollection((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), gradientStopCollection);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, float, void> SetOpacity;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void> SetTransform;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, float> GetOpacity;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void> GetTransform;

            [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_POINT_2F, void> SetStartPoint;

            [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_POINT_2F, void> SetEndPoint;

            [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*> GetStartPoint;

            [NativeTypeName("D2D1_POINT_2F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*> GetEndPoint;

            [NativeTypeName("void (ID2D1GradientStopCollection **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1LinearGradientBrush*, ID2D1GradientStopCollection**, void> GetGradientStopCollection;
        }
    }
}
