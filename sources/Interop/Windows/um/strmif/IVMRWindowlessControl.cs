// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0EB1088C-4DCD-46F0-878F-39DAE86A51B7")]
    [NativeTypeName("struct IVMRWindowlessControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRWindowlessControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, uint>)(lpVtbl[1]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, uint>)(lpVtbl[2]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNativeVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight, [NativeTypeName("LONG *")] int* lpARWidth, [NativeTypeName("LONG *")] int* lpARHeight)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int*, int*, int>)(lpVtbl[3]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight, lpARWidth, lpARHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMinIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int>)(lpVtbl[4]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMaxIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int>)(lpVtbl[5]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetVideoPosition([NativeTypeName("const LPRECT")] RECT* lpSRCRect, [NativeTypeName("const LPRECT")] RECT* lpDSTRect)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, RECT*, RECT*, int>)(lpVtbl[6]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVideoPosition([NativeTypeName("LPRECT")] RECT* lpSRCRect, [NativeTypeName("LPRECT")] RECT* lpDSTRect)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, RECT*, RECT*, int>)(lpVtbl[7]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAspectRatioMode([NativeTypeName("DWORD *")] uint* lpAspectRatioMode)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, uint*, int>)(lpVtbl[8]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpAspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint AspectRatioMode)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, uint, int>)(lpVtbl[9]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), AspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetVideoClippingWindow(HWND hwnd)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, HWND, int>)(lpVtbl[10]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RepaintVideo(HWND hwnd, HDC hdc)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, HWND, HDC, int>)(lpVtbl[11]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd, hdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DisplayModeChanged()
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, int>)(lpVtbl[12]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetCurrentImage(byte** lpDib)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, byte**, int>)(lpVtbl[13]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpDib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetBorderColor(COLORREF Clr)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF, int>)(lpVtbl[14]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBorderColor(COLORREF* lpClr)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF*, int>)(lpVtbl[15]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetColorKey(COLORREF Clr)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF, int>)(lpVtbl[16]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetColorKey(COLORREF* lpClr)
        {
            return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF*, int>)(lpVtbl[17]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
        }
    }
}
