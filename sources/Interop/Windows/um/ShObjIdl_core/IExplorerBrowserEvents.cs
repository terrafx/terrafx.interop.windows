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
    public unsafe partial struct IExplorerBrowserEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, uint>)(lpVtbl[1]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, uint>)(lpVtbl[2]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[3]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnViewCreated(IShellView* psv)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, IShellView*, int>)(lpVtbl[4]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), psv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[5]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
        {
            return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int>)(lpVtbl[6]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
        }
    }
}
