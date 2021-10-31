// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("922EADA0-3424-11CF-B670-00AA004CD6D8")]
    [NativeTypeName("struct IOleInPlaceSiteWindowless : IOleInPlaceSiteEx")]
    [NativeInheritance("IOleInPlaceSiteEx")]
    public unsafe partial struct IOleInPlaceSiteWindowless
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, uint>)(lpVtbl[1]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, uint>)(lpVtbl[2]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CanInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[5]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[6]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[7]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnUIDeactivate(BOOL fUndoable)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL, int>)(lpVtbl[10]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[11]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DiscardUndoState()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[12]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DeactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[13]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT OnInPlaceActivateEx(BOOL* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL*, uint, int>)(lpVtbl[15]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL, int>)(lpVtbl[16]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT RequestUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[17]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CanWindowlessActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[18]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetCapture()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[19]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetCapture(BOOL fCapture)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL, int>)(lpVtbl[20]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fCapture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetFocus()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int>)(lpVtbl[21]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetFocus(BOOL fFocus)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, BOOL, int>)(lpVtbl[22]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetDC([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, RECT*, uint, IntPtr*, int>)(lpVtbl[23]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, grfFlags, phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT ReleaseDC([NativeTypeName("HDC")] IntPtr hDC)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, IntPtr, int>)(lpVtbl[24]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, BOOL fErase)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, RECT*, BOOL, int>)(lpVtbl[25]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, fErase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT InvalidateRgn([NativeTypeName("HRGN")] IntPtr hRGN, BOOL fErase)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, IntPtr, BOOL, int>)(lpVtbl[26]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hRGN, fErase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT ScrollRect([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy, [NativeTypeName("LPCRECT")] RECT* pRectScroll, [NativeTypeName("LPCRECT")] RECT* pRectClip)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, int, int, RECT*, RECT*, int>)(lpVtbl[27]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), dx, dy, pRectScroll, pRectClip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT AdjustRect([NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, RECT*, int>)(lpVtbl[28]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT OnDefWindowMessage([NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteWindowless*, uint, nuint, nint, nint*, int>)(lpVtbl[29]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
        }
    }
}
