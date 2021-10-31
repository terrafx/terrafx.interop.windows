// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000119-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceSite : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IOleInPlaceSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, uint>)(lpVtbl[1]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, uint>)(lpVtbl[2]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CanInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[5]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[6]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[7]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnUIDeactivate(BOOL fUndoable)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, BOOL, int>)(lpVtbl[10]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[11]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DiscardUndoState()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[12]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DeactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, int>)(lpVtbl[13]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged<IOleInPlaceSite*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), lprcPosRect);
        }
    }
}
