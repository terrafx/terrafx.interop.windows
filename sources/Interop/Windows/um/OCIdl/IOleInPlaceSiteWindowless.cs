// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("922EADA0-3424-11CF-B670-00AA004CD6D8")]
    public unsafe partial struct IOleInPlaceSiteWindowless
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return lpVtbl->GetWindow((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return lpVtbl->ContextSensitiveHelp((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return lpVtbl->CanInPlaceActivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return lpVtbl->OnInPlaceActivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return lpVtbl->OnUIActivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo)
        {
            return lpVtbl->GetWindowContext((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return lpVtbl->Scroll((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return lpVtbl->OnUIDeactivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return lpVtbl->OnInPlaceDeactivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return lpVtbl->DiscardUndoState((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return lpVtbl->DeactivateAndUndo((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return lpVtbl->OnPosRectChange((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->OnInPlaceActivateEx((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return lpVtbl->OnInPlaceDeactivateEx((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return lpVtbl->RequestUIActivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CanWindowlessActivate()
        {
            return lpVtbl->CanWindowlessActivate((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapture()
        {
            return lpVtbl->GetCapture((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCapture([NativeTypeName("BOOL")] int fCapture)
        {
            return lpVtbl->SetCapture((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fCapture);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFocus()
        {
            return lpVtbl->GetFocus((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFocus([NativeTypeName("BOOL")] int fFocus)
        {
            return lpVtbl->SetFocus((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fFocus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return lpVtbl->GetDC((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, grfFlags, phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr hDC)
        {
            return lpVtbl->ReleaseDC((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int fErase)
        {
            return lpVtbl->InvalidateRect((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, fErase);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateRgn([NativeTypeName("HRGN")] IntPtr hRGN, [NativeTypeName("BOOL")] int fErase)
        {
            return lpVtbl->InvalidateRgn((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hRGN, fErase);
        }

        [return: NativeTypeName("HRESULT")]
        public int ScrollRect([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy, [NativeTypeName("LPCRECT")] RECT* pRectScroll, [NativeTypeName("LPCRECT")] RECT* pRectClip)
        {
            return lpVtbl->ScrollRect((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), dx, dy, pRectScroll, pRectClip);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdjustRect([NativeTypeName("LPRECT")] RECT* prc)
        {
            return lpVtbl->AdjustRect((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), prc);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDefWindowMessage([NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return lpVtbl->OnDefWindowMessage((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, IntPtr*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> CanInPlaceActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> OnInPlaceActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> OnUIActivate;

            [NativeTypeName("HRESULT (IOleInPlaceFrame **, IOleInPlaceUIWindow **, LPRECT, LPRECT, LPOLEINPLACEFRAMEINFO) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OIFI*, int> GetWindowContext;

            [NativeTypeName("HRESULT (SIZE) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, SIZE, int> Scroll;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int> OnUIDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> OnInPlaceDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> DiscardUndoState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> DeactivateAndUndo;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, RECT*, int> OnPosRectChange;

            [NativeTypeName("HRESULT (BOOL *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int*, uint, int> OnInPlaceActivateEx;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int> OnInPlaceDeactivateEx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> RequestUIActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> CanWindowlessActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> GetCapture;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int> SetCapture;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int> GetFocus;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int> SetFocus;

            [NativeTypeName("HRESULT (LPCRECT, DWORD, HDC *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, RECT*, uint, IntPtr*, int> GetDC;

            [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, IntPtr, int> ReleaseDC;

            [NativeTypeName("HRESULT (LPCRECT, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, RECT*, int, int> InvalidateRect;

            [NativeTypeName("HRESULT (HRGN, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, IntPtr, int, int> InvalidateRgn;

            [NativeTypeName("HRESULT (INT, INT, LPCRECT, LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, int, int, RECT*, RECT*, int> ScrollRect;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, RECT*, int> AdjustRect;

            [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceSiteWindowless*, uint, nuint, nint, nint*, int> OnDefWindowMessage;
        }
    }
}
