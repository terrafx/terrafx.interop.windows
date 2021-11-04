// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E3-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellView : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IShellView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellView*, Guid*, void**, int>)(lpVtbl[0]))((IShellView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellView*, uint>)(lpVtbl[1]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellView*, uint>)(lpVtbl[2]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IShellView*, HWND*, int>)(lpVtbl[3]))((IShellView*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IShellView*, BOOL, int>)(lpVtbl[4]))((IShellView*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TranslateAcceleratorW(MSG* pmsg)
        {
            return ((delegate* unmanaged<IShellView*, MSG*, int>)(lpVtbl[5]))((IShellView*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<IShellView*, BOOL, int>)(lpVtbl[6]))((IShellView*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UIActivate(uint uState)
        {
            return ((delegate* unmanaged<IShellView*, uint, int>)(lpVtbl[7]))((IShellView*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Refresh()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[8]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateViewWindow(IShellView* psvPrevious, [NativeTypeName("LPCFOLDERSETTINGS")] FOLDERSETTINGS* pfs, IShellBrowser* psb, RECT* prcView, HWND* phWnd)
        {
            return ((delegate* unmanaged<IShellView*, IShellView*, FOLDERSETTINGS*, IShellBrowser*, RECT*, HWND*, int>)(lpVtbl[9]))((IShellView*)Unsafe.AsPointer(ref this), psvPrevious, pfs, psb, prcView, phWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DestroyViewWindow()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[10]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs)
        {
            return ((delegate* unmanaged<IShellView*, FOLDERSETTINGS*, int>)(lpVtbl[11]))((IShellView*)Unsafe.AsPointer(ref this), pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddPropertySheetPages([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPFNSVADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfn, LPARAM lparam)
        {
            return ((delegate* unmanaged<IShellView*, uint, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int>)(lpVtbl[12]))((IShellView*)Unsafe.AsPointer(ref this), dwReserved, pfn, lparam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SaveViewState()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[13]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SelectItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem, [NativeTypeName("SVSIF")] uint uFlags)
        {
            return ((delegate* unmanaged<IShellView*, ITEMIDLIST*, uint, int>)(lpVtbl[14]))((IShellView*)Unsafe.AsPointer(ref this), pidlItem, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetItemObject(uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellView*, uint, Guid*, void**, int>)(lpVtbl[15]))((IShellView*)Unsafe.AsPointer(ref this), uItem, riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, BOOL, int> ContextSensitiveHelp;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, MSG*, int> TranslateAcceleratorW;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, BOOL, int> EnableModeless;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, uint, int> UIActivate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, int> Refresh;

            [NativeTypeName("HRESULT (IShellView *, LPCFOLDERSETTINGS, IShellBrowser *, RECT *, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, IShellView*, FOLDERSETTINGS*, IShellBrowser*, RECT*, HWND*, int> CreateViewWindow;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, int> DestroyViewWindow;

            [NativeTypeName("HRESULT (LPFOLDERSETTINGS) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, FOLDERSETTINGS*, int> GetCurrentInfo;

            [NativeTypeName("HRESULT (DWORD, LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, uint, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int> AddPropertySheetPages;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, int> SaveViewState;

            [NativeTypeName("HRESULT (LPCITEMIDLIST, SVSIF) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, ITEMIDLIST*, uint, int> SelectItem;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellView*, uint, Guid*, void**, int> GetItemObject;
        }
    }
}
