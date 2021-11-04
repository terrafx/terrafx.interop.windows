// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DFD3B6B5-C10C-4BE9-85F6-A66969F402F6")]
    [NativeTypeName("struct IExplorerBrowser : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExplorerBrowser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerBrowser*, uint>)(lpVtbl[1]))((IExplorerBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerBrowser*, uint>)(lpVtbl[2]))((IExplorerBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(HWND hwndParent, [NativeTypeName("const RECT *")] RECT* prc, [NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, HWND, RECT*, FOLDERSETTINGS*, int>)(lpVtbl[3]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), hwndParent, prc, pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Destroy()
        {
            return ((delegate* unmanaged<IExplorerBrowser*, int>)(lpVtbl[4]))((IExplorerBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetRect(HDWP* phdwp, RECT rcBrowser)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, HDWP*, RECT, int>)(lpVtbl[5]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), phdwp, rcBrowser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPropertyBag([NativeTypeName("LPCWSTR")] ushort* pszPropertyBag)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, ushort*, int>)(lpVtbl[6]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), pszPropertyBag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetEmptyText([NativeTypeName("LPCWSTR")] ushort* pszEmptyText)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, ushort*, int>)(lpVtbl[7]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), pszEmptyText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetFolderSettings([NativeTypeName("const FOLDERSETTINGS *")] FOLDERSETTINGS* pfs)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, FOLDERSETTINGS*, int>)(lpVtbl[8]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Advise(IExplorerBrowserEvents* psbe, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, IExplorerBrowserEvents*, uint*, int>)(lpVtbl[9]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), psbe, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, uint, int>)(lpVtbl[10]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetOptions(EXPLORER_BROWSER_OPTIONS dwFlag)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, EXPLORER_BROWSER_OPTIONS, int>)(lpVtbl[11]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), dwFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetOptions(EXPLORER_BROWSER_OPTIONS* pdwFlag)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, EXPLORER_BROWSER_OPTIONS*, int>)(lpVtbl[12]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), pdwFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT BrowseToIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint uFlags)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), pidl, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT BrowseToObject(IUnknown* punk, uint uFlags)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, IUnknown*, uint, int>)(lpVtbl[14]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), punk, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT FillFromObject(IUnknown* punk, EXPLORER_BROWSER_FILL_FLAGS dwFlags)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, IUnknown*, EXPLORER_BROWSER_FILL_FLAGS, int>)(lpVtbl[15]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), punk, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT RemoveAll()
        {
            return ((delegate* unmanaged<IExplorerBrowser*, int>)(lpVtbl[16]))((IExplorerBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCurrentView([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IExplorerBrowser*, Guid*, void**, int>)(lpVtbl[17]))((IExplorerBrowser*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, uint> Release;

            [NativeTypeName("HRESULT (HWND, const RECT *, const FOLDERSETTINGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, HWND, RECT*, FOLDERSETTINGS*, int> Initialize;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, int> Destroy;

            [NativeTypeName("HRESULT (HDWP *, RECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, HDWP*, RECT, int> SetRect;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, ushort*, int> SetPropertyBag;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, ushort*, int> SetEmptyText;

            [NativeTypeName("HRESULT (const FOLDERSETTINGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, FOLDERSETTINGS*, int> SetFolderSettings;

            [NativeTypeName("HRESULT (IExplorerBrowserEvents *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, IExplorerBrowserEvents*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (EXPLORER_BROWSER_OPTIONS) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, EXPLORER_BROWSER_OPTIONS, int> SetOptions;

            [NativeTypeName("HRESULT (EXPLORER_BROWSER_OPTIONS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, EXPLORER_BROWSER_OPTIONS*, int> GetOptions;

            [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, ITEMIDLIST*, uint, int> BrowseToIDList;

            [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, IUnknown*, uint, int> BrowseToObject;

            [NativeTypeName("HRESULT (IUnknown *, EXPLORER_BROWSER_FILL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, IUnknown*, EXPLORER_BROWSER_FILL_FLAGS, int> FillFromObject;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, int> RemoveAll;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowser*, Guid*, void**, int> GetCurrentView;
        }
    }
}
