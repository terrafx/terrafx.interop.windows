// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IPropertyPage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyPage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyPage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyPage*, uint>)(lpVtbl[1]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyPage*, uint>)(lpVtbl[2]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPageSite(IPropertyPageSite* pPageSite)
        {
            return ((delegate* unmanaged<IPropertyPage*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return ((delegate* unmanaged<IPropertyPage*, IntPtr, RECT*, int, int>)(lpVtbl[4]))((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[5]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo(PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* unmanaged<IPropertyPage*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPropertyPage*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return ((delegate* unmanaged<IPropertyPage*, uint, int>)(lpVtbl[8]))((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* unmanaged<IPropertyPage*, RECT*, int>)(lpVtbl[9]))((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[10]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return ((delegate* unmanaged<IPropertyPage*, int>)(lpVtbl[11]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* unmanaged<IPropertyPage*, ushort*, int>)(lpVtbl[12]))((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator(MSG* pMsg)
        {
            return ((delegate* unmanaged<IPropertyPage*, MSG*, int>)(lpVtbl[13]))((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
