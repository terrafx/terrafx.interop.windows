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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IShellView*, IntPtr*, int>)(lpVtbl[3]))((IShellView*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IShellView*, BOOL, int>)(lpVtbl[4]))((IShellView*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorW(MSG* pmsg)
        {
            return ((delegate* unmanaged<IShellView*, MSG*, int>)(lpVtbl[5]))((IShellView*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless(BOOL fEnable)
        {
            return ((delegate* unmanaged<IShellView*, BOOL, int>)(lpVtbl[6]))((IShellView*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int UIActivate([NativeTypeName("UINT")] uint uState)
        {
            return ((delegate* unmanaged<IShellView*, uint, int>)(lpVtbl[7]))((IShellView*)Unsafe.AsPointer(ref this), uState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Refresh()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[8]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewWindow(IShellView* psvPrevious, [NativeTypeName("LPCFOLDERSETTINGS")] FOLDERSETTINGS* pfs, IShellBrowser* psb, RECT* prcView, [NativeTypeName("HWND *")] IntPtr* phWnd)
        {
            return ((delegate* unmanaged<IShellView*, IShellView*, FOLDERSETTINGS*, IShellBrowser*, RECT*, IntPtr*, int>)(lpVtbl[9]))((IShellView*)Unsafe.AsPointer(ref this), psvPrevious, pfs, psb, prcView, phWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyViewWindow()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[10]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentInfo([NativeTypeName("LPFOLDERSETTINGS")] FOLDERSETTINGS* pfs)
        {
            return ((delegate* unmanaged<IShellView*, FOLDERSETTINGS*, int>)(lpVtbl[11]))((IShellView*)Unsafe.AsPointer(ref this), pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int AddPropertySheetPages([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPFNSVADDPROPSHEETPAGE")] delegate* unmanaged<IntPtr, nint, BOOL> pfn, [NativeTypeName("LPARAM")] nint lparam)
        {
            return ((delegate* unmanaged<IShellView*, uint, delegate* unmanaged<IntPtr, nint, BOOL>, nint, int>)(lpVtbl[12]))((IShellView*)Unsafe.AsPointer(ref this), dwReserved, pfn, lparam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SaveViewState()
        {
            return ((delegate* unmanaged<IShellView*, int>)(lpVtbl[13]))((IShellView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SelectItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem, [NativeTypeName("SVSIF")] uint uFlags)
        {
            return ((delegate* unmanaged<IShellView*, ITEMIDLIST*, uint, int>)(lpVtbl[14]))((IShellView*)Unsafe.AsPointer(ref this), pidlItem, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemObject([NativeTypeName("UINT")] uint uItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellView*, uint, Guid*, void**, int>)(lpVtbl[15]))((IShellView*)Unsafe.AsPointer(ref this), uItem, riid, ppv);
        }
    }
}
