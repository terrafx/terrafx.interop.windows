// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000115-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleInPlaceUIWindow
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return lpVtbl->GetWindow((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return lpVtbl->ContextSensitiveHelp((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return lpVtbl->GetBorder((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return lpVtbl->RequestBorderSpace((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return lpVtbl->SetBorderSpace((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject([NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return lpVtbl->SetActiveObject((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, IntPtr*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, int, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, RECT*, int> GetBorder;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, RECT*, int> RequestBorderSpace;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, RECT*, int> SetBorderSpace;

            [NativeTypeName("HRESULT (IOleInPlaceActiveObject *, LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleInPlaceUIWindow*, IOleInPlaceActiveObject*, ushort*, int> SetActiveObject;
        }
    }
}
