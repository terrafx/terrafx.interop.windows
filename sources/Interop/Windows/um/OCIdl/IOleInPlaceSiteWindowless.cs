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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CanInPlaceActivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceActivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnUIActivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowContext(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Scroll(IOleInPlaceSiteWindowless* pThis, SIZE scrollExtant);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnUIDeactivate(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL")] int fUndoable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceDeactivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DiscardUndoState(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeactivateAndUndo(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnPosRectChange(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("LPCRECT")] RECT* lprcPosRect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceActivateEx(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceDeactivateEx(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL")] int fNoRedraw);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestUIActivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CanWindowlessActivate(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCapture(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCapture(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL")] int fCapture);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFocus(IOleInPlaceSiteWindowless* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFocus(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("BOOL")] int fFocus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDC(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("HDC *")] IntPtr* phDC);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseDC(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("HDC")] IntPtr hDC);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InvalidateRect(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int fErase);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InvalidateRgn(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("HRGN")] IntPtr hRGN, [NativeTypeName("BOOL")] int fErase);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ScrollRect(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy, [NativeTypeName("LPCRECT")] RECT* pRectScroll, [NativeTypeName("LPCRECT")] RECT* pRectClip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AdjustRect(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("LPRECT")] RECT* prc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnDefWindowMessage(IOleInPlaceSiteWindowless* pThis, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_CanInPlaceActivate>(lpVtbl->CanInPlaceActivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceActivate>(lpVtbl->OnInPlaceActivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnUIActivate>(lpVtbl->OnUIActivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindowContext>(lpVtbl->GetWindowContext)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return Marshal.GetDelegateForFunctionPointer<_Scroll>(lpVtbl->Scroll)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnUIDeactivate>(lpVtbl->OnUIDeactivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceDeactivate>(lpVtbl->OnInPlaceDeactivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return Marshal.GetDelegateForFunctionPointer<_DiscardUndoState>(lpVtbl->DiscardUndoState)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return Marshal.GetDelegateForFunctionPointer<_DeactivateAndUndo>(lpVtbl->DeactivateAndUndo)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnPosRectChange>(lpVtbl->OnPosRectChange)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceActivateEx>(lpVtbl->OnInPlaceActivateEx)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceDeactivateEx>(lpVtbl->OnInPlaceDeactivateEx)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestUIActivate>(lpVtbl->RequestUIActivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CanWindowlessActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_CanWindowlessActivate>(lpVtbl->CanWindowlessActivate)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapture()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCapture>(lpVtbl->GetCapture)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCapture([NativeTypeName("BOOL")] int fCapture)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCapture>(lpVtbl->SetCapture)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fCapture);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFocus()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFocus>(lpVtbl->GetFocus)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFocus([NativeTypeName("BOOL")] int fFocus)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFocus>(lpVtbl->SetFocus)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), fFocus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDC>(lpVtbl->GetDC)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, grfFlags, phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr hDC)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseDC>(lpVtbl->ReleaseDC)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int fErase)
        {
            return Marshal.GetDelegateForFunctionPointer<_InvalidateRect>(lpVtbl->InvalidateRect)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), pRect, fErase);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateRgn([NativeTypeName("HRGN")] IntPtr hRGN, [NativeTypeName("BOOL")] int fErase)
        {
            return Marshal.GetDelegateForFunctionPointer<_InvalidateRgn>(lpVtbl->InvalidateRgn)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), hRGN, fErase);
        }

        [return: NativeTypeName("HRESULT")]
        public int ScrollRect([NativeTypeName("INT")] int dx, [NativeTypeName("INT")] int dy, [NativeTypeName("LPCRECT")] RECT* pRectScroll, [NativeTypeName("LPCRECT")] RECT* pRectClip)
        {
            return Marshal.GetDelegateForFunctionPointer<_ScrollRect>(lpVtbl->ScrollRect)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), dx, dy, pRectScroll, pRectClip);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdjustRect([NativeTypeName("LPRECT")] RECT* prc)
        {
            return Marshal.GetDelegateForFunctionPointer<_AdjustRect>(lpVtbl->AdjustRect)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), prc);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDefWindowMessage([NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnDefWindowMessage>(lpVtbl->OnDefWindowMessage)((IOleInPlaceSiteWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public IntPtr GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr ContextSensitiveHelp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr CanInPlaceActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnInPlaceActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnUIActivate;

            [NativeTypeName("HRESULT (IOleInPlaceFrame **, IOleInPlaceUIWindow **, LPRECT, LPRECT, LPOLEINPLACEFRAMEINFO) __attribute__((stdcall))")]
            public IntPtr GetWindowContext;

            [NativeTypeName("HRESULT (SIZE) __attribute__((stdcall))")]
            public IntPtr Scroll;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnUIDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnInPlaceDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr DiscardUndoState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr DeactivateAndUndo;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public IntPtr OnPosRectChange;

            [NativeTypeName("HRESULT (BOOL *, DWORD) __attribute__((stdcall))")]
            public IntPtr OnInPlaceActivateEx;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnInPlaceDeactivateEx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RequestUIActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr CanWindowlessActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr GetCapture;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr SetCapture;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr GetFocus;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr SetFocus;

            [NativeTypeName("HRESULT (LPCRECT, DWORD, HDC *) __attribute__((stdcall))")]
            public IntPtr GetDC;

            [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
            public IntPtr ReleaseDC;

            [NativeTypeName("HRESULT (LPCRECT, BOOL) __attribute__((stdcall))")]
            public IntPtr InvalidateRect;

            [NativeTypeName("HRESULT (HRGN, BOOL) __attribute__((stdcall))")]
            public IntPtr InvalidateRgn;

            [NativeTypeName("HRESULT (INT, INT, LPCRECT, LPCRECT) __attribute__((stdcall))")]
            public IntPtr ScrollRect;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
            public IntPtr AdjustRect;

            [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
            public IntPtr OnDefWindowMessage;
        }
    }
}
