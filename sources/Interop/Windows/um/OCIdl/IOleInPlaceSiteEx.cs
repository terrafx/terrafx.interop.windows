// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
    public unsafe partial struct IOleInPlaceSiteEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceSiteEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceSiteEx* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceSiteEx* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CanInPlaceActivate(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceActivate(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnUIActivate(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowContext(IOleInPlaceSiteEx* pThis, [NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Scroll(IOleInPlaceSiteEx* pThis, SIZE scrollExtant);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnUIDeactivate(IOleInPlaceSiteEx* pThis, [NativeTypeName("BOOL")] int fUndoable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceDeactivate(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DiscardUndoState(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeactivateAndUndo(IOleInPlaceSiteEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnPosRectChange(IOleInPlaceSiteEx* pThis, [NativeTypeName("LPCRECT")] RECT* lprcPosRect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceActivateEx(IOleInPlaceSiteEx* pThis, [NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnInPlaceDeactivateEx(IOleInPlaceSiteEx* pThis, [NativeTypeName("BOOL")] int fNoRedraw);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestUIActivate(IOleInPlaceSiteEx* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_CanInPlaceActivate>(lpVtbl->CanInPlaceActivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceActivate>(lpVtbl->OnInPlaceActivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnUIActivate>(lpVtbl->OnUIActivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindowContext>(lpVtbl->GetWindowContext)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return Marshal.GetDelegateForFunctionPointer<_Scroll>(lpVtbl->Scroll)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnUIDeactivate>(lpVtbl->OnUIDeactivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceDeactivate>(lpVtbl->OnInPlaceDeactivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return Marshal.GetDelegateForFunctionPointer<_DiscardUndoState>(lpVtbl->DiscardUndoState)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return Marshal.GetDelegateForFunctionPointer<_DeactivateAndUndo>(lpVtbl->DeactivateAndUndo)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnPosRectChange>(lpVtbl->OnPosRectChange)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceActivateEx>(lpVtbl->OnInPlaceActivateEx)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnInPlaceDeactivateEx>(lpVtbl->OnInPlaceDeactivateEx)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestUIActivate>(lpVtbl->RequestUIActivate)((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
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
        }
    }
}
