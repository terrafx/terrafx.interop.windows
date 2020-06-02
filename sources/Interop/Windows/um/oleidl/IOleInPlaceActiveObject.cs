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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return lpVtbl->GetWindow((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return lpVtbl->ContextSensitiveHelp((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("LPMSG")] MSG* lpmsg)
        {
            return lpVtbl->TranslateAcceleratorA((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), lpmsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFrameWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return lpVtbl->OnFrameWindowActivate((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDocWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return lpVtbl->OnDocWindowActivate((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, [NativeTypeName("IOleInPlaceUIWindow *")] IOleInPlaceUIWindow* pUIWindow, [NativeTypeName("BOOL")] int fFrameWindow)
        {
            return lpVtbl->ResizeBorder((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), prcBorder, pUIWindow, fFrameWindow);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return lpVtbl->EnableModeless((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, IntPtr*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, int, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (LPMSG) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, MSG*, int> TranslateAcceleratorA;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, int, int> OnFrameWindowActivate;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, int, int> OnDocWindowActivate;

            [NativeTypeName("HRESULT (LPCRECT, IOleInPlaceUIWindow *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, RECT*, IOleInPlaceUIWindow*, int, int> ResizeBorder;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceActiveObject*, int, int> EnableModeless;
        }
    }
}
