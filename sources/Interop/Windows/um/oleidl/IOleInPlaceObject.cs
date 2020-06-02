// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000113-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleInPlaceObject
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleInPlaceObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return lpVtbl->GetWindow((IOleInPlaceObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return lpVtbl->ContextSensitiveHelp((IOleInPlaceObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int InPlaceDeactivate()
        {
            return lpVtbl->InPlaceDeactivate((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UIDeactivate()
        {
            return lpVtbl->UIDeactivate((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
        {
            return lpVtbl->SetObjectRects((IOleInPlaceObject*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReactivateAndUndo()
        {
            return lpVtbl->ReactivateAndUndo((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, IntPtr*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, int, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, int> InPlaceDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, int> UIDeactivate;

            [NativeTypeName("HRESULT (LPCRECT, LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, RECT*, RECT*, int> SetObjectRects;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceObject*, int> ReactivateAndUndo;
        }
    }
}
