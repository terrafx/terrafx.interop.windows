// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
    [NativeTypeName("struct IOleInPlaceSiteEx : IOleInPlaceSite")]
    public unsafe partial struct IOleInPlaceSiteEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, uint>)(lpVtbl[1]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, uint>)(lpVtbl[2]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int, int>)(lpVtbl[4]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[5]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[6]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[7]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int, int>)(lpVtbl[10]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[11]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[12]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[13]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int*, uint, int>)(lpVtbl[15]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int, int>)(lpVtbl[16]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSiteEx*, int>)(lpVtbl[17]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }
    }
}
