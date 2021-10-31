// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C2056CC-5EF4-101B-8BC8-00AA003E3B29")]
    [NativeTypeName("struct IOleInPlaceObjectWindowless : IOleInPlaceObject")]
    [NativeInheritance("IOleInPlaceObject")]
    public unsafe partial struct IOleInPlaceObjectWindowless
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint>)(lpVtbl[1]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint>)(lpVtbl[2]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int>)(lpVtbl[5]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UIDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int>)(lpVtbl[6]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, RECT*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int>)(lpVtbl[8]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnWindowMessage([NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint, nuint, nint, nint*, int>)(lpVtbl[9]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDropTarget(IDropTarget** ppDropTarget)
        {
            return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, IDropTarget**, int>)(lpVtbl[10]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), ppDropTarget);
        }
    }
}
