// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01E44665-24AC-101B-84ED-08002B2EC713")]
    [NativeTypeName("struct IPropertyPage2 : IPropertyPage")]
    public unsafe partial struct IPropertyPage2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyPage2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint>)(lpVtbl[1]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint>)(lpVtbl[2]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPageSite(IPropertyPageSite* pPageSite)
        {
            return ((delegate* unmanaged<IPropertyPage2*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return ((delegate* unmanaged<IPropertyPage2*, IntPtr, RECT*, int, int>)(lpVtbl[4]))((IPropertyPage2*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[5]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo(PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* unmanaged<IPropertyPage2*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage2*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return ((delegate* unmanaged<IPropertyPage2*, uint, int>)(lpVtbl[8]))((IPropertyPage2*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* unmanaged<IPropertyPage2*, RECT*, int>)(lpVtbl[9]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[10]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return ((delegate* unmanaged<IPropertyPage2*, int>)(lpVtbl[11]))((IPropertyPage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* unmanaged<IPropertyPage2*, ushort*, int>)(lpVtbl[12]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator(MSG* pMsg)
        {
            return ((delegate* unmanaged<IPropertyPage2*, MSG*, int>)(lpVtbl[13]))((IPropertyPage2*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EditProperty([NativeTypeName("DISPID")] int dispID)
        {
            return ((delegate* unmanaged<IPropertyPage2*, int, int>)(lpVtbl[14]))((IPropertyPage2*)Unsafe.AsPointer(ref this), dispID);
        }
    }
}
