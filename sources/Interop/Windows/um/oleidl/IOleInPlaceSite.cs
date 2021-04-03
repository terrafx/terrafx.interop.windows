// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000119-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceSite : IOleWindow")]
    public unsafe partial struct IOleInPlaceSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, uint>)(lpVtbl[1]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, uint>)(lpVtbl[2]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int, int>)(lpVtbl[4]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[5]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[6]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[7]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int, int>)(lpVtbl[10]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[11]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[12]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[13]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), lprcPosRect);
        }
    }
}
