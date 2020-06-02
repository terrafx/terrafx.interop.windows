// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000116-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleInPlaceFrame
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return lpVtbl->GetWindow((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return lpVtbl->ContextSensitiveHelp((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return lpVtbl->GetBorder((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return lpVtbl->RequestBorderSpace((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return lpVtbl->SetBorderSpace((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject([NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return lpVtbl->SetActiveObject((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertMenus([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OleMenuGroupWidths* lpMenuWidths)
        {
            return lpVtbl->InsertMenus((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMenu([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("HOLEMENU")] IntPtr holemenu, [NativeTypeName("HWND")] IntPtr hwndActiveObject)
        {
            return lpVtbl->SetMenu((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, holemenu, hwndActiveObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveMenus([NativeTypeName("HMENU")] IntPtr hmenuShared)
        {
            return lpVtbl->RemoveMenus((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStatusText([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return lpVtbl->SetStatusText((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return lpVtbl->EnableModeless((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID)
        {
            return lpVtbl->TranslateAcceleratorA((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lpmsg, wID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, IntPtr*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, int, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, RECT*, int> GetBorder;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, RECT*, int> RequestBorderSpace;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, RECT*, int> SetBorderSpace;

            [NativeTypeName("HRESULT (IOleInPlaceActiveObject *, LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, IOleInPlaceActiveObject*, ushort*, int> SetActiveObject;

            [NativeTypeName("HRESULT (HMENU, LPOLEMENUGROUPWIDTHS) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, IntPtr, OleMenuGroupWidths*, int> InsertMenus;

            [NativeTypeName("HRESULT (HMENU, HOLEMENU, HWND) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, IntPtr, IntPtr, IntPtr, int> SetMenu;

            [NativeTypeName("HRESULT (HMENU) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, IntPtr, int> RemoveMenus;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, ushort*, int> SetStatusText;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, int, int> EnableModeless;

            [NativeTypeName("HRESULT (LPMSG, WORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceFrame*, MSG*, ushort, int> TranslateAcceleratorA;
        }
    }
}
