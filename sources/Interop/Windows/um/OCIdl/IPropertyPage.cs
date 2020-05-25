// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IPropertyPage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyPage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyPage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyPage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPageSite(IPropertyPage* pThis, [NativeTypeName("IPropertyPageSite *")] IPropertyPageSite* pPageSite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Activate(IPropertyPage* pThis, [NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Deactivate(IPropertyPage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPageInfo(IPropertyPage* pThis, [NativeTypeName("PROPPAGEINFO *")] PROPPAGEINFO* pPageInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetObjects(IPropertyPage* pThis, [NativeTypeName("ULONG")] uint cObjects, [NativeTypeName("IUnknown **")] IUnknown** ppUnk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Show(IPropertyPage* pThis, [NativeTypeName("UINT")] uint nCmdShow);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Move(IPropertyPage* pThis, [NativeTypeName("LPCRECT")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsPageDirty(IPropertyPage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Apply(IPropertyPage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Help(IPropertyPage* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszHelpDir);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateAcceleratorA(IPropertyPage* pThis, [NativeTypeName("MSG *")] MSG* pMsg);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPageSite([NativeTypeName("IPropertyPageSite *")] IPropertyPageSite* pPageSite)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPageSite>(lpVtbl->SetPageSite)((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return Marshal.GetDelegateForFunctionPointer<_Activate>(lpVtbl->Activate)((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return Marshal.GetDelegateForFunctionPointer<_Deactivate>(lpVtbl->Deactivate)((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo([NativeTypeName("PROPPAGEINFO *")] PROPPAGEINFO* pPageInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPageInfo>(lpVtbl->GetPageInfo)((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, [NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetObjects>(lpVtbl->SetObjects)((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return Marshal.GetDelegateForFunctionPointer<_Show>(lpVtbl->Show)((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_Move>(lpVtbl->Move)((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsPageDirty>(lpVtbl->IsPageDirty)((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return Marshal.GetDelegateForFunctionPointer<_Apply>(lpVtbl->Apply)((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return Marshal.GetDelegateForFunctionPointer<_Help>(lpVtbl->Help)((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateAcceleratorA>(lpVtbl->TranslateAcceleratorA)((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IPropertyPageSite *) __attribute__((stdcall))")]
            public IntPtr SetPageSite;

            [NativeTypeName("HRESULT (HWND, LPCRECT, BOOL) __attribute__((stdcall))")]
            public IntPtr Activate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Deactivate;

            [NativeTypeName("HRESULT (PROPPAGEINFO *) __attribute__((stdcall))")]
            public IntPtr GetPageInfo;

            [NativeTypeName("HRESULT (ULONG, IUnknown **) __attribute__((stdcall))")]
            public IntPtr SetObjects;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr Show;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public IntPtr Move;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsPageDirty;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Apply;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr Help;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public IntPtr TranslateAcceleratorA;
        }
    }
}
