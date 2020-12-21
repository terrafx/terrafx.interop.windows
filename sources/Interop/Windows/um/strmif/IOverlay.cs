// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A1-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IOverlay : IUnknown")]
    public unsafe partial struct IOverlay
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, uint>)(lpVtbl[1]))((IOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, uint>)(lpVtbl[2]))((IOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("DWORD *")] uint* pdwColors, [NativeTypeName("PALETTEENTRY **")] PALETTEENTRY** ppPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, uint*, PALETTEENTRY**, int>)(lpVtbl[3]))((IOverlay*)Unsafe.AsPointer(ref this), pdwColors, ppPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("DWORD")] uint dwColors, [NativeTypeName("PALETTEENTRY *")] PALETTEENTRY* pPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, uint, PALETTEENTRY*, int>)(lpVtbl[4]))((IOverlay*)Unsafe.AsPointer(ref this), dwColors, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColorKey([NativeTypeName("COLORKEY *")] COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, COLORKEY*, int>)(lpVtbl[5]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("COLORKEY *")] COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, COLORKEY*, int>)(lpVtbl[6]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("COLORKEY *")] COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, COLORKEY*, int>)(lpVtbl[7]))((IOverlay*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowHandle([NativeTypeName("HWND *")] IntPtr* pHwnd)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, IntPtr*, int>)(lpVtbl[8]))((IOverlay*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipList([NativeTypeName("RECT *")] RECT* pSourceRect, [NativeTypeName("RECT *")] RECT* pDestinationRect, [NativeTypeName("RGNDATA **")] RGNDATA** ppRgnData)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, RECT*, RECT*, RGNDATA**, int>)(lpVtbl[9]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, ppRgnData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoPosition([NativeTypeName("RECT *")] RECT* pSourceRect, [NativeTypeName("RECT *")] RECT* pDestinationRect)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, RECT*, RECT*, int>)(lpVtbl[10]))((IOverlay*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IOverlayNotify *")] IOverlayNotify* pOverlayNotify, [NativeTypeName("DWORD")] uint dwInterests)
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, IOverlayNotify*, uint, int>)(lpVtbl[11]))((IOverlay*)Unsafe.AsPointer(ref this), pOverlayNotify, dwInterests);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise()
        {
            return ((delegate* unmanaged[Stdcall]<IOverlay*, int>)(lpVtbl[12]))((IOverlay*)Unsafe.AsPointer(ref this));
        }
    }
}
