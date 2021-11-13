// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00000113-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceObject : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IOleInPlaceObject : IOleInPlaceObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, uint>)(lpVtbl[1]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, uint>)(lpVtbl[2]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[5]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT UIDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[6]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, RECT*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[8]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IOleWindow.Interface
        {
            [VtblIndex(5)]
            HRESULT InPlaceDeactivate();

            [VtblIndex(6)]
            HRESULT UIDeactivate();

            [VtblIndex(7)]
            HRESULT SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect);

            [VtblIndex(8)]
            HRESULT ReactivateAndUndo();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, int> InPlaceDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, int> UIDeactivate;

            [NativeTypeName("HRESULT (LPCRECT, LPCRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, RECT*, RECT*, int> SetObjectRects;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleInPlaceObject*, int> ReactivateAndUndo;
        }
    }
}
