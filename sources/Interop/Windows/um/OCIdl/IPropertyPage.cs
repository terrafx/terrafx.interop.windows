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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPageSite([NativeTypeName("IPropertyPageSite *")] IPropertyPageSite* pPageSite)
        {
            return lpVtbl->SetPageSite((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return lpVtbl->Activate((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return lpVtbl->Deactivate((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo([NativeTypeName("PROPPAGEINFO *")] PROPPAGEINFO* pPageInfo)
        {
            return lpVtbl->GetPageInfo((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, [NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return lpVtbl->SetObjects((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return lpVtbl->Show((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return lpVtbl->Move((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return lpVtbl->IsPageDirty((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return lpVtbl->Apply((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return lpVtbl->Help((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return lpVtbl->TranslateAcceleratorA((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, uint> Release;

            [NativeTypeName("HRESULT (IPropertyPageSite *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, IPropertyPageSite*, int> SetPageSite;

            [NativeTypeName("HRESULT (HWND, LPCRECT, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, IntPtr, RECT*, int, int> Activate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, int> Deactivate;

            [NativeTypeName("HRESULT (PROPPAGEINFO *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, PROPPAGEINFO*, int> GetPageInfo;

            [NativeTypeName("HRESULT (ULONG, IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, uint, IUnknown**, int> SetObjects;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, uint, int> Show;

            [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, RECT*, int> Move;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, int> IsPageDirty;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, int> Apply;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, ushort*, int> Help;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyPage*, MSG*, int> TranslateAcceleratorA;
        }
    }
}
