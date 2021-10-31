// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CDE725B0-CCC9-4519-917E-325D72FAB4CE")]
    [NativeTypeName("struct IFolderView : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFolderView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderView*, Guid*, void**, int>)(lpVtbl[0]))((IFolderView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderView*, uint>)(lpVtbl[1]))((IFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderView*, uint>)(lpVtbl[2]))((IFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrentViewMode(uint* pViewMode)
        {
            return ((delegate* unmanaged<IFolderView*, uint*, int>)(lpVtbl[3]))((IFolderView*)Unsafe.AsPointer(ref this), pViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetCurrentViewMode(uint ViewMode)
        {
            return ((delegate* unmanaged<IFolderView*, uint, int>)(lpVtbl[4]))((IFolderView*)Unsafe.AsPointer(ref this), ViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView*, Guid*, void**, int>)(lpVtbl[5]))((IFolderView*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IFolderView*, int, ITEMIDLIST**, int>)(lpVtbl[6]))((IFolderView*)Unsafe.AsPointer(ref this), iItemIndex, ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ItemCount(uint uFlags, int* pcItems)
        {
            return ((delegate* unmanaged<IFolderView*, uint, int*, int>)(lpVtbl[7]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Items(uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView*, uint, Guid*, void**, int>)(lpVtbl[8]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSelectionMarkedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView*, int*, int>)(lpVtbl[9]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFocusedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView*, int*, int>)(lpVtbl[10]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, ITEMIDLIST*, POINT*, int>)(lpVtbl[11]))((IFolderView*)Unsafe.AsPointer(ref this), pidl, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, POINT*, int>)(lpVtbl[12]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDefaultSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, POINT*, int>)(lpVtbl[13]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetAutoArrange()
        {
            return ((delegate* unmanaged<IFolderView*, int>)(lpVtbl[14]))((IFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView*, int, uint, int>)(lpVtbl[15]))((IFolderView*)Unsafe.AsPointer(ref this), iItem, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SelectAndPositionItems(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView*, uint, ITEMIDLIST**, POINT*, uint, int>)(lpVtbl[16]))((IFolderView*)Unsafe.AsPointer(ref this), cidl, apidl, apt, dwFlags);
        }
    }
}
