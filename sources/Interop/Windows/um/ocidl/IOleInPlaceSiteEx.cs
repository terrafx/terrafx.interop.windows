// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
    [NativeTypeName("struct IOleInPlaceSiteEx : IOleInPlaceSite")]
    [NativeInheritance("IOleInPlaceSite")]
    public unsafe partial struct IOleInPlaceSiteEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, uint>)(lpVtbl[1]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, uint>)(lpVtbl[2]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CanInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[5]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnInPlaceActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[6]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[7]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnUIDeactivate(BOOL fUndoable)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, BOOL, int>)(lpVtbl[10]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[11]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DiscardUndoState()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[12]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DeactivateAndUndo()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[13]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT OnInPlaceActivateEx(BOOL* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, BOOL*, uint, int>)(lpVtbl[15]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw)
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, BOOL, int>)(lpVtbl[16]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT RequestUIActivate()
        {
            return ((delegate* unmanaged<IOleInPlaceSiteEx*, int>)(lpVtbl[17]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }
    }
}
