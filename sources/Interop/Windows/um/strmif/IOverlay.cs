// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A1-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IOverlay : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOverlay
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOverlay*, uint>)(lpVtbl[1]))((IOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOverlay*, uint>)(lpVtbl[2]))((IOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPalette([NativeTypeName("DWORD *")] uint* pdwColors, PALETTEENTRY** ppPalette)
        {
            return ((delegate* unmanaged<IOverlay*, uint*, PALETTEENTRY**, int>)(lpVtbl[3]))((IOverlay*)Unsafe.AsPointer(ref this), pdwColors, ppPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPalette([NativeTypeName("DWORD")] uint dwColors, PALETTEENTRY* pPalette)
        {
            return ((delegate* unmanaged<IOverlay*, uint, PALETTEENTRY*, int>)(lpVtbl[4]))((IOverlay*)Unsafe.AsPointer(ref this), dwColors, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDefaultColorKey(COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[5]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetColorKey(COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[6]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetColorKey(COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged<IOverlay*, COLORKEY*, int>)(lpVtbl[7]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWindowHandle(HWND* pHwnd)
        {
            return ((delegate* unmanaged<IOverlay*, HWND*, int>)(lpVtbl[8]))((IOverlay*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetClipList(RECT* pSourceRect, RECT* pDestinationRect, RGNDATA** ppRgnData)
        {
            return ((delegate* unmanaged<IOverlay*, RECT*, RECT*, RGNDATA**, int>)(lpVtbl[9]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, ppRgnData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetVideoPosition(RECT* pSourceRect, RECT* pDestinationRect)
        {
            return ((delegate* unmanaged<IOverlay*, RECT*, RECT*, int>)(lpVtbl[10]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Advise(IOverlayNotify* pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests)
        {
            return ((delegate* unmanaged<IOverlay*, IOverlayNotify*, uint, int>)(lpVtbl[11]))((IOverlay*)Unsafe.AsPointer(ref this), pOverlayNotify, dwInterests);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Unadvise()
        {
            return ((delegate* unmanaged<IOverlay*, int>)(lpVtbl[12]))((IOverlay*)Unsafe.AsPointer(ref this));
        }
    }
}
