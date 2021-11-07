// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("361BBDC7-E6EE-4E13-BE58-58E2240C810F")]
    [NativeTypeName("struct IExplorerBrowserEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExplorerBrowserEvents : IExplorerBrowserEvents.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, uint>)(lpVtbl[1]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, uint>)(lpVtbl[2]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[3]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnViewCreated(IShellView* psv)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, IShellView*, int>)(lpVtbl[4]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), psv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[5]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[6]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);

            [VtblIndex(4)]
            HRESULT OnViewCreated(IShellView* psv);

            [VtblIndex(5)]
            HRESULT OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);

            [VtblIndex(6)]
            HRESULT OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, uint> Release;

            [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> OnNavigationPending;

            [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, IShellView*, int> OnViewCreated;

            [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> OnNavigationComplete;

            [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
            public delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> OnNavigationFailed;
        }
    }
}
