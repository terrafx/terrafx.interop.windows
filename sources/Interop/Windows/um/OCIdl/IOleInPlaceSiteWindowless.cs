// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("922EADA0-3424-11CF-B670-00AA004CD6D8")]
    [NativeTypeName("struct IOleInPlaceSiteWindowless : IOleInPlaceSiteEx")]
    public unsafe partial struct IOleInPlaceSiteWindowless
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, uint>)(lpVtbl[1]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, uint>)(lpVtbl[2]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int>)(lpVtbl[4]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[5]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[6]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[7]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int>)(lpVtbl[10]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[11]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[12]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[13]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int*, uint, int>)(lpVtbl[15]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int>)(lpVtbl[16]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[17]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanWindowlessActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[18]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapture()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[19]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCapture([NativeTypeName("BOOL")] int fCapture)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int>)(lpVtbl[20]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fCapture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocus()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int>)(lpVtbl[21]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus([NativeTypeName("BOOL")] int fFocus)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int>)(lpVtbl[22]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, RECT*, uint, IntPtr*, int>)(lpVtbl[23]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, grfFlags, phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr hDC)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, IntPtr, int>)(lpVtbl[24]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int fErase)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, RECT*, int, int>)(lpVtbl[25]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, fErase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvalidateRgn([NativeTypeName("HRGN")] IntPtr hRGN, [NativeTypeName("BOOL")] int fErase)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, IntPtr, int, int>)(lpVtbl[26]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hRGN, fErase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScrollRect([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy, [NativeTypeName("LPCRECT")] RECT* pRectScroll, [NativeTypeName("LPCRECT")] RECT* pRectClip)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, int, int, RECT*, RECT*, int>)(lpVtbl[27]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), dx, dy, pRectScroll, pRectClip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdjustRect([NativeTypeName("LPRECT")] RECT* prc)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, RECT*, int>)(lpVtbl[28]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDefWindowMessage([NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteWindowless*, uint, nuint, nint, nint*, int>)(lpVtbl[29]))((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
        }
    }
}
