// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000119-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleInPlaceSite
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, uint>)(lpVtbl[1]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, uint>)(lpVtbl[2]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int, int>)(lpVtbl[4]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[5]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[6]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[7]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OIFI* lpFrameInfo)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OIFI*, int>)(lpVtbl[8]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int, int>)(lpVtbl[10]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[11]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[12]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return ((delegate* stdcall<IOleInPlaceSite*, int>)(lpVtbl[13]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* stdcall<IOleInPlaceSite*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), lprcPosRect);
        }
    }
}
