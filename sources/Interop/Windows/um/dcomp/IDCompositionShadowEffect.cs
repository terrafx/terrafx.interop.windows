// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AD18AC0-CFD2-4C2F-BB62-96E54FDB6879")]
    public unsafe partial struct IDCompositionShadowEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation(float amount)
        {
            return lpVtbl->SetStandardDeviation((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetStandardDeviation1((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color)
        {
            return lpVtbl->SetColor((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRed(float amount)
        {
            return lpVtbl->SetRed((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRed([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetRed1((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreen(float amount)
        {
            return lpVtbl->SetGreen((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGreen([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetGreen1((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlue(float amount)
        {
            return lpVtbl->SetBlue((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlue([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBlue1((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlpha(float amount)
        {
            return lpVtbl->SetAlpha((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlpha([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAlpha1((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, float, int> SetStandardDeviation;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, IDCompositionAnimation*, int> SetStandardDeviation1;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_4F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, D2D_VECTOR_4F*, int> SetColor;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, float, int> SetRed;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, IDCompositionAnimation*, int> SetRed1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, float, int> SetGreen;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, IDCompositionAnimation*, int> SetGreen1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, float, int> SetBlue;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, IDCompositionAnimation*, int> SetBlue1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, float, int> SetAlpha;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionShadowEffect*, IDCompositionAnimation*, int> SetAlpha1;
        }
    }
}
