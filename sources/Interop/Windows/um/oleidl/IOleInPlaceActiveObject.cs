// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000117-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceActiveObject : IOleWindow")]
    public unsafe partial struct IOleInPlaceActiveObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint>)(lpVtbl[1]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint>)(lpVtbl[2]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, int, int>)(lpVtbl[4]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, MSG*, int>)(lpVtbl[5]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), lpmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFrameWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, int, int>)(lpVtbl[6]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDocWindowActivate([NativeTypeName("BOOL")] int fActivate)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, int, int>)(lpVtbl[7]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, IOleInPlaceUIWindow* pUIWindow, [NativeTypeName("BOOL")] int fFrameWindow)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, RECT*, IOleInPlaceUIWindow*, int, int>)(lpVtbl[8]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), prcBorder, pUIWindow, fFrameWindow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IOleInPlaceActiveObject*, int, int>)(lpVtbl[9]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnable);
        }
    }
}
