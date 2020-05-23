// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000117-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleInPlaceActiveObject
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceActiveObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceActiveObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceActiveObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceActiveObject* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceActiveObject* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateAcceleratorA(IOleInPlaceActiveObject* pThis, [NativeTypeName("LPMSG")] MSG* lpmsg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnFrameWindowActivate(IOleInPlaceActiveObject* pThis, [NativeTypeName("BOOL")] int fActivate);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnDocWindowActivate(IOleInPlaceActiveObject* pThis, [NativeTypeName("BOOL")] int fActivate);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ResizeBorder(IOleInPlaceActiveObject* pThis, [NativeTypeName("LPCRECT")] RECT* prcBorder, [NativeTypeName("IOleInPlaceUIWindow *")] IOleInPlaceUIWindow* pUIWindow, [NativeTypeName("BOOL")] int fFrameWindow);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnableModeless(IOleInPlaceActiveObject* pThis, [NativeTypeName("BOOL")] int fEnable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("LPMSG")] MSG* lpmsg)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateAcceleratorA>(lpVtbl->TranslateAcceleratorA)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), lpmsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFrameWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnFrameWindowActivate>(lpVtbl->OnFrameWindowActivate)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDocWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnDocWindowActivate>(lpVtbl->OnDocWindowActivate)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, [NativeTypeName("IOleInPlaceUIWindow *")] IOleInPlaceUIWindow* pUIWindow, [NativeTypeName("BOOL")] int fFrameWindow)
        {
            return Marshal.GetDelegateForFunctionPointer<_ResizeBorder>(lpVtbl->ResizeBorder)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), prcBorder, pUIWindow, fFrameWindow);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnableModeless>(lpVtbl->EnableModeless)((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnable);
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

            [NativeTypeName("HRESULT (LPMSG) __attribute__((stdcall))")]
            public IntPtr TranslateAcceleratorA;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnFrameWindowActivate;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnDocWindowActivate;

            [NativeTypeName("HRESULT (LPCRECT, IOleInPlaceUIWindow *, BOOL) __attribute__((stdcall))")]
            public IntPtr ResizeBorder;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr EnableModeless;
        }
    }
}
