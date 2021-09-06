// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("96E5AE6D-6AE1-4B1C-900C-C6480EAA8828")]
    [NativeTypeName("struct IResultsFolder : IUnknown")]
    public unsafe partial struct IResultsFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IResultsFolder*, Guid*, void**, int>)(lpVtbl[0]))((IResultsFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IResultsFolder*, uint>)(lpVtbl[1]))((IResultsFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IResultsFolder*, uint>)(lpVtbl[2]))((IResultsFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddItem(IShellItem* psi)
        {
            return ((delegate* unmanaged<IResultsFolder*, IShellItem*, int>)(lpVtbl[3]))((IResultsFolder*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlAdded)
        {
            return ((delegate* unmanaged<IResultsFolder*, ITEMIDLIST*, ITEMIDLIST**, int>)(lpVtbl[4]))((IResultsFolder*)Unsafe.AsPointer(ref this), pidl, ppidlAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveItem(IShellItem* psi)
        {
            return ((delegate* unmanaged<IResultsFolder*, IShellItem*, int>)(lpVtbl[5]))((IResultsFolder*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IResultsFolder*, ITEMIDLIST*, int>)(lpVtbl[6]))((IResultsFolder*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAll()
        {
            return ((delegate* unmanaged<IResultsFolder*, int>)(lpVtbl[7]))((IResultsFolder*)Unsafe.AsPointer(ref this));
        }
    }
}
