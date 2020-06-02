// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9842AD7D-D9CF-4908-AED7-48B51DA5E7C2")]
    public unsafe partial struct IDCompositionRectangleClip
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLeft(float left)
        {
            return lpVtbl->SetLeft((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLeft([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetLeft1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTop(float top)
        {
            return lpVtbl->SetTop((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTop([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTop1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRight(float right)
        {
            return lpVtbl->SetRight((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRight([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetRight1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottom(float bottom)
        {
            return lpVtbl->SetBottom((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottom([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBottom1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX(float radius)
        {
            return lpVtbl->SetTopLeftRadiusX((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTopLeftRadiusX1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY(float radius)
        {
            return lpVtbl->SetTopLeftRadiusY((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTopLeftRadiusY1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX(float radius)
        {
            return lpVtbl->SetTopRightRadiusX((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTopRightRadiusX1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY(float radius)
        {
            return lpVtbl->SetTopRightRadiusY((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetTopRightRadiusY1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX(float radius)
        {
            return lpVtbl->SetBottomLeftRadiusX((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBottomLeftRadiusX1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY(float radius)
        {
            return lpVtbl->SetBottomLeftRadiusY((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBottomLeftRadiusY1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX(float radius)
        {
            return lpVtbl->SetBottomRightRadiusX((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBottomRightRadiusX1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY(float radius)
        {
            return lpVtbl->SetBottomRightRadiusY((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetBottomRightRadiusY1((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, uint> Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetLeft;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetLeft1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetTop;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTop1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetRight;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetRight1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetBottom;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottom1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetTopLeftRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopLeftRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetTopLeftRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopLeftRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetTopRightRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopRightRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetTopRightRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopRightRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetBottomLeftRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomLeftRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetBottomLeftRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomLeftRadiusY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetBottomRightRadiusX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomRightRadiusX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, float, int> SetBottomRightRadiusY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomRightRadiusY1;
        }
    }
}
