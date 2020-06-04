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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyPage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyPage*, uint>)(lpVtbl[1]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyPage*, uint>)(lpVtbl[2]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPageSite([NativeTypeName("IPropertyPageSite *")] IPropertyPageSite* pPageSite)
        {
            return ((delegate* stdcall<IPropertyPage*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return ((delegate* stdcall<IPropertyPage*, IntPtr, RECT*, int, int>)(lpVtbl[4]))((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* stdcall<IPropertyPage*, int>)(lpVtbl[5]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo([NativeTypeName("PROPPAGEINFO *")] PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* stdcall<IPropertyPage*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, [NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* stdcall<IPropertyPage*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return ((delegate* stdcall<IPropertyPage*, uint, int>)(lpVtbl[8]))((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* stdcall<IPropertyPage*, RECT*, int>)(lpVtbl[9]))((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return ((delegate* stdcall<IPropertyPage*, int>)(lpVtbl[10]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return ((delegate* stdcall<IPropertyPage*, int>)(lpVtbl[11]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* stdcall<IPropertyPage*, ushort*, int>)(lpVtbl[12]))((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return ((delegate* stdcall<IPropertyPage*, MSG*, int>)(lpVtbl[13]))((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
