// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9842AD7D-D9CF-4908-AED7-48B51DA5E7C2")]
    [NativeTypeName("struct IDCompositionRectangleClip : IDCompositionClip")]
    [NativeInheritance("IDCompositionClip")]
    public unsafe partial struct IDCompositionRectangleClip : IDCompositionRectangleClip.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[1]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[2]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetLeft(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetLeft(float left)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[4]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetTop(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetTop(float top)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[6]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetRight(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetRight(float right)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[8]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetBottom(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetBottom(float bottom)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[10]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetTopLeftRadiusX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetTopLeftRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[12]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetTopLeftRadiusY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetTopLeftRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[14]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetTopRightRadiusX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetTopRightRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[16]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTopRightRadiusY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetTopRightRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[18]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetBottomLeftRadiusX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetBottomLeftRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[20]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetBottomLeftRadiusY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetBottomLeftRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[22]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetBottomRightRadiusX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[23]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetBottomRightRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[24]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetBottomRightRadiusY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[25]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBottomRightRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[26]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        public interface Interface : IDCompositionClip.Interface
        {
            [VtblIndex(3)]
            HRESULT SetLeft(IDCompositionAnimation* animation);

            [VtblIndex(4)]
            HRESULT SetLeft(float left);

            [VtblIndex(5)]
            HRESULT SetTop(IDCompositionAnimation* animation);

            [VtblIndex(6)]
            HRESULT SetTop(float top);

            [VtblIndex(7)]
            HRESULT SetRight(IDCompositionAnimation* animation);

            [VtblIndex(8)]
            HRESULT SetRight(float right);

            [VtblIndex(9)]
            HRESULT SetBottom(IDCompositionAnimation* animation);

            [VtblIndex(10)]
            HRESULT SetBottom(float bottom);

            [VtblIndex(11)]
            HRESULT SetTopLeftRadiusX(IDCompositionAnimation* animation);

            [VtblIndex(12)]
            HRESULT SetTopLeftRadiusX(float radius);

            [VtblIndex(13)]
            HRESULT SetTopLeftRadiusY(IDCompositionAnimation* animation);

            [VtblIndex(14)]
            HRESULT SetTopLeftRadiusY(float radius);

            [VtblIndex(15)]
            HRESULT SetTopRightRadiusX(IDCompositionAnimation* animation);

            [VtblIndex(16)]
            HRESULT SetTopRightRadiusX(float radius);

            [VtblIndex(17)]
            HRESULT SetTopRightRadiusY(IDCompositionAnimation* animation);

            [VtblIndex(18)]
            HRESULT SetTopRightRadiusY(float radius);

            [VtblIndex(19)]
            HRESULT SetBottomLeftRadiusX(IDCompositionAnimation* animation);

            [VtblIndex(20)]
            HRESULT SetBottomLeftRadiusX(float radius);

            [VtblIndex(21)]
            HRESULT SetBottomLeftRadiusY(IDCompositionAnimation* animation);

            [VtblIndex(22)]
            HRESULT SetBottomLeftRadiusY(float radius);

            [VtblIndex(23)]
            HRESULT SetBottomRightRadiusX(IDCompositionAnimation* animation);

            [VtblIndex(24)]
            HRESULT SetBottomRightRadiusX(float radius);

            [VtblIndex(25)]
            HRESULT SetBottomRightRadiusY(IDCompositionAnimation* animation);

            [VtblIndex(26)]
            HRESULT SetBottomRightRadiusY(float radius);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetLeft;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetLeft1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTop;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetTop1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetRight;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetRight1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottom;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetBottom1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopLeftRadiusX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetTopLeftRadiusX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopLeftRadiusY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetTopLeftRadiusY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopRightRadiusX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetTopRightRadiusX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetTopRightRadiusY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetTopRightRadiusY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomLeftRadiusX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetBottomLeftRadiusX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomLeftRadiusY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetBottomLeftRadiusY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomRightRadiusX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetBottomRightRadiusX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int> SetBottomRightRadiusY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRectangleClip*, float, int> SetBottomRightRadiusY1;
        }
    }
}
