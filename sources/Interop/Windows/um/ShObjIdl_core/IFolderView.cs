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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentViewMode([NativeTypeName("UINT *")] uint* pViewMode)
        {
            return ((delegate* unmanaged<IFolderView*, uint*, int>)(lpVtbl[3]))((IFolderView*)Unsafe.AsPointer(ref this), pViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentViewMode([NativeTypeName("UINT")] uint ViewMode)
        {
            return ((delegate* unmanaged<IFolderView*, uint, int>)(lpVtbl[4]))((IFolderView*)Unsafe.AsPointer(ref this), ViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView*, Guid*, void**, int>)(lpVtbl[5]))((IFolderView*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IFolderView*, int, ITEMIDLIST**, int>)(lpVtbl[6]))((IFolderView*)Unsafe.AsPointer(ref this), iItemIndex, ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ItemCount([NativeTypeName("UINT")] uint uFlags, int* pcItems)
        {
            return ((delegate* unmanaged<IFolderView*, uint, int*, int>)(lpVtbl[7]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Items([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView*, uint, Guid*, void**, int>)(lpVtbl[8]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionMarkedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView*, int*, int>)(lpVtbl[9]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocusedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView*, int*, int>)(lpVtbl[10]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, ITEMIDLIST*, POINT*, int>)(lpVtbl[11]))((IFolderView*)Unsafe.AsPointer(ref this), pidl, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, POINT*, int>)(lpVtbl[12]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView*, POINT*, int>)(lpVtbl[13]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutoArrange()
        {
            return ((delegate* unmanaged<IFolderView*, int>)(lpVtbl[14]))((IFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView*, int, uint, int>)(lpVtbl[15]))((IFolderView*)Unsafe.AsPointer(ref this), iItem, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SelectAndPositionItems([NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView*, uint, ITEMIDLIST**, POINT*, uint, int>)(lpVtbl[16]))((IFolderView*)Unsafe.AsPointer(ref this), cidl, apidl, apt, dwFlags);
        }
    }
}
