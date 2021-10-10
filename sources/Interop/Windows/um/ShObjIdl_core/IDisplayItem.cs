// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6FD5997-9F6B-4888-8703-94E80E8CDE3F")]
    [NativeTypeName("struct IDisplayItem : IRelatedItem")]
    [NativeInheritance("IRelatedItem")]
    public unsafe partial struct IDisplayItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDisplayItem*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDisplayItem*, uint>)(lpVtbl[1]))((IDisplayItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDisplayItem*, uint>)(lpVtbl[2]))((IDisplayItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IDisplayItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((IDisplayItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IDisplayItem*, IShellItem**, int>)(lpVtbl[4]))((IDisplayItem*)Unsafe.AsPointer(ref this), ppsi);
        }
    }
}
