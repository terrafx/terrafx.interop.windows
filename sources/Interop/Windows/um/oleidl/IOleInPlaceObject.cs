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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceObject* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceObject* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InPlaceDeactivate(IOleInPlaceObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UIDeactivate(IOleInPlaceObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetObjectRects(IOleInPlaceObject* pThis, [NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReactivateAndUndo(IOleInPlaceObject* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceObject*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceObject*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int InPlaceDeactivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_InPlaceDeactivate>(lpVtbl->InPlaceDeactivate)((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UIDeactivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_UIDeactivate>(lpVtbl->UIDeactivate)((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetObjectRects>(lpVtbl->SetObjectRects)((IOleInPlaceObject*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReactivateAndUndo()
        {
            return Marshal.GetDelegateForFunctionPointer<_ReactivateAndUndo>(lpVtbl->ReactivateAndUndo)((IOleInPlaceObject*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public IntPtr GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr ContextSensitiveHelp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr InPlaceDeactivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr UIDeactivate;

            [NativeTypeName("HRESULT (LPCRECT, LPCRECT) __attribute__((stdcall))")]
            public IntPtr SetObjectRects;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ReactivateAndUndo;
        }
    }
}
