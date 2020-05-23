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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceUIWindow* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceUIWindow* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceUIWindow* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceUIWindow* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceUIWindow* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBorder(IOleInPlaceUIWindow* pThis, [NativeTypeName("LPRECT")] RECT* lprectBorder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestBorderSpace(IOleInPlaceUIWindow* pThis, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBorderSpace(IOleInPlaceUIWindow* pThis, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetActiveObject(IOleInPlaceUIWindow* pThis, [NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBorder>(lpVtbl->GetBorder)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestBorderSpace>(lpVtbl->RequestBorderSpace)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBorderSpace>(lpVtbl->SetBorderSpace)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject([NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetActiveObject>(lpVtbl->SetActiveObject)((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
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

            [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
            public IntPtr GetBorder;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public IntPtr RequestBorderSpace;

            [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
            public IntPtr SetBorderSpace;

            [NativeTypeName("HRESULT (IOleInPlaceActiveObject *, LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr SetActiveObject;
        }
    }
}
