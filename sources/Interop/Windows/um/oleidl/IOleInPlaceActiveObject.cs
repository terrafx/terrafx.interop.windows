// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000117-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceActiveObject : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IOleInPlaceActiveObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint>)(lpVtbl[1]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint>)(lpVtbl[2]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, MSG*, int>)(lpVtbl[5]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), lpmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnFrameWindowActivate(BOOL fActivate)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int>)(lpVtbl[6]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnDocWindowActivate(BOOL fActivate)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int>)(lpVtbl[7]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, IOleInPlaceUIWindow* pUIWindow, BOOL fFrameWindow)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, RECT*, IOleInPlaceUIWindow*, BOOL, int>)(lpVtbl[8]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), prcBorder, pUIWindow, fFrameWindow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int>)(lpVtbl[9]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (LPMSG) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, MSG*, int> TranslateAccelerator;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> OnFrameWindowActivate;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> OnDocWindowActivate;

            [NativeTypeName("HRESULT (LPCRECT, IOleInPlaceUIWindow *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, RECT*, IOleInPlaceUIWindow*, BOOL, int> ResizeBorder;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> EnableModeless;
        }
    }
}
