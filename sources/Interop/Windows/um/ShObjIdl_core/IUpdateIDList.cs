// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6589B6D2-5F8D-4B9E-B7E0-23CDD9717D8C")]
    [NativeTypeName("struct IUpdateIDList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUpdateIDList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUpdateIDList*, Guid*, void**, int>)(lpVtbl[0]))((IUpdateIDList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUpdateIDList*, uint>)(lpVtbl[1]))((IUpdateIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUpdateIDList*, uint>)(lpVtbl[2]))((IUpdateIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Update(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlIn, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
        {
            return ((delegate* unmanaged<IUpdateIDList*, IBindCtx*, ITEMIDLIST*, ITEMIDLIST**, int>)(lpVtbl[3]))((IUpdateIDList*)Unsafe.AsPointer(ref this), pbc, pidlIn, ppidlOut);
        }
    }
}
