// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9842AD7D-D9CF-4908-AED7-48B51DA5E7C2")]
    [NativeTypeName("struct IDCompositionRectangleClip : IDCompositionClip")]
    public unsafe partial struct IDCompositionRectangleClip
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[1]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[2]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLeft(float left)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[4]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLeft([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTop(float top)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[6]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTop([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRight(float right)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[8]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRight([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottom(float bottom)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[10]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottom([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[12]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[14]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[16]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[18]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[20]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[22]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomLeftRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[24]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[23]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY(float radius)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[26]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBottomRightRadiusY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[25]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
