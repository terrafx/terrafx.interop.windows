// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000113-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceObject : IOleWindow")]
    public unsafe partial struct IOleInPlaceObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, uint>)(lpVtbl[1]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, uint>)(lpVtbl[2]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int, int>)(lpVtbl[4]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[5]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UIDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[6]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, RECT*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceObject*, int>)(lpVtbl[8]))((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }
    }
}
