// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A0-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IOverlayNotify : IUnknown")]
    public unsafe partial struct IOverlayNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOverlayNotify*, Guid*, void**, int>)(lpVtbl[0]))((IOverlayNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOverlayNotify*, uint>)(lpVtbl[1]))((IOverlayNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOverlayNotify*, uint>)(lpVtbl[2]))((IOverlayNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPaletteChange([NativeTypeName("DWORD")] uint dwColors, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette)
        {
            return ((delegate* stdcall<IOverlayNotify*, uint, PALETTEENTRY*, int>)(lpVtbl[3]))((IOverlayNotify*)Unsafe.AsPointer(ref this), dwColors, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClipChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect, [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData)
        {
            return ((delegate* stdcall<IOverlayNotify*, RECT*, RECT*, RGNDATA*, int>)(lpVtbl[4]))((IOverlayNotify*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, pRgnData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey)
        {
            return ((delegate* stdcall<IOverlayNotify*, COLORKEY*, int>)(lpVtbl[5]))((IOverlayNotify*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPositionChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect)
        {
            return ((delegate* stdcall<IOverlayNotify*, RECT*, RECT*, int>)(lpVtbl[6]))((IOverlayNotify*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
        }
    }
}
