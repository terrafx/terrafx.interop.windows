// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
    public unsafe partial struct IDCompositionBrightnessEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
        {
            return lpVtbl->SetWhitePoint((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
        {
            return lpVtbl->SetBlackPoint((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(float whitePointX)
        {
            return lpVtbl->SetWhitePointX((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetWhitePointX1((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(float whitePointY)
        {
            return lpVtbl->SetWhitePointY((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetWhitePointY1((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(float blackPointX)
        {
            return lpVtbl->SetBlackPointX((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBlackPointX1((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(float blackPointY)
        {
            return lpVtbl->SetBlackPointY((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBlackPointY1((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int> SetWhitePoint;

            [NativeTypeName("HRESULT (const D2D1_VECTOR_2F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int> SetBlackPoint;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, float, int> SetWhitePointX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int> SetWhitePointX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, float, int> SetWhitePointY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int> SetWhitePointY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, float, int> SetBlackPointX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int> SetBlackPointX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, float, int> SetBlackPointY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int> SetBlackPointY1;
        }
    }
}
