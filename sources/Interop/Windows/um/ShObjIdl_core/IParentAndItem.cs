// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B3A4B685-B685-4805-99D9-5DEAD2873236")]
    [NativeTypeName("struct IParentAndItem : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IParentAndItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IParentAndItem*, Guid*, void**, int>)(lpVtbl[0]))((IParentAndItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IParentAndItem*, uint>)(lpVtbl[1]))((IParentAndItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IParentAndItem*, uint>)(lpVtbl[2]))((IParentAndItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetParentAndItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild)
        {
            return ((delegate* unmanaged<IParentAndItem*, ITEMIDLIST*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[3]))((IParentAndItem*)Unsafe.AsPointer(ref this), pidlParent, psf, pidlChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetParentAndItem([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlParent, IShellFolder** ppsf, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlChild)
        {
            return ((delegate* unmanaged<IParentAndItem*, ITEMIDLIST**, IShellFolder**, ITEMIDLIST**, int>)(lpVtbl[4]))((IParentAndItem*)Unsafe.AsPointer(ref this), ppidlParent, ppsf, ppidlChild);
        }
    }
}
