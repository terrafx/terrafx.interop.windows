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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleInPlaceFrame* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleInPlaceFrame* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleInPlaceFrame* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IOleInPlaceFrame* pThis, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ContextSensitiveHelp(IOleInPlaceFrame* pThis, [NativeTypeName("BOOL")] int fEnterMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBorder(IOleInPlaceFrame* pThis, [NativeTypeName("LPRECT")] RECT* lprectBorder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestBorderSpace(IOleInPlaceFrame* pThis, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBorderSpace(IOleInPlaceFrame* pThis, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetActiveObject(IOleInPlaceFrame* pThis, [NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InsertMenus(IOleInPlaceFrame* pThis, [NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OleMenuGroupWidths* lpMenuWidths);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMenu(IOleInPlaceFrame* pThis, [NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("HOLEMENU")] IntPtr holemenu, [NativeTypeName("HWND")] IntPtr hwndActiveObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveMenus(IOleInPlaceFrame* pThis, [NativeTypeName("HMENU")] IntPtr hmenuShared);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStatusText(IOleInPlaceFrame* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszStatusText);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnableModeless(IOleInPlaceFrame* pThis, [NativeTypeName("BOOL")] int fEnable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateAcceleratorA(IOleInPlaceFrame* pThis, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_ContextSensitiveHelp>(lpVtbl->ContextSensitiveHelp)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBorder>(lpVtbl->GetBorder)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestBorderSpace>(lpVtbl->RequestBorderSpace)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBorderSpace>(lpVtbl->SetBorderSpace)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject([NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetActiveObject>(lpVtbl->SetActiveObject)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertMenus([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OleMenuGroupWidths* lpMenuWidths)
        {
            return Marshal.GetDelegateForFunctionPointer<_InsertMenus>(lpVtbl->InsertMenus)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMenu([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("HOLEMENU")] IntPtr holemenu, [NativeTypeName("HWND")] IntPtr hwndActiveObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMenu>(lpVtbl->SetMenu)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, holemenu, hwndActiveObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveMenus([NativeTypeName("HMENU")] IntPtr hmenuShared)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveMenus>(lpVtbl->RemoveMenus)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStatusText([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStatusText>(lpVtbl->SetStatusText)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnableModeless>(lpVtbl->EnableModeless)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateAcceleratorA>(lpVtbl->TranslateAcceleratorA)((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lpmsg, wID);
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

            [NativeTypeName("HRESULT (HMENU, LPOLEMENUGROUPWIDTHS) __attribute__((stdcall))")]
            public IntPtr InsertMenus;

            [NativeTypeName("HRESULT (HMENU, HOLEMENU, HWND) __attribute__((stdcall))")]
            public IntPtr SetMenu;

            [NativeTypeName("HRESULT (HMENU) __attribute__((stdcall))")]
            public IntPtr RemoveMenus;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr SetStatusText;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr EnableModeless;

            [NativeTypeName("HRESULT (LPMSG, WORD) __attribute__((stdcall))")]
            public IntPtr TranslateAcceleratorA;
        }
    }
}
