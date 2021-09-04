// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("05EDDA5C-98A3-4717-8ADB-C5E7DA991EB1")]
    [NativeTypeName("struct IUseToBrowseItem : IRelatedItem")]
    public unsafe partial struct IUseToBrowseItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUseToBrowseItem*, Guid*, void**, int>)(lpVtbl[0]))((IUseToBrowseItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUseToBrowseItem*, uint>)(lpVtbl[1]))((IUseToBrowseItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUseToBrowseItem*, uint>)(lpVtbl[2]))((IUseToBrowseItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IUseToBrowseItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((IUseToBrowseItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IUseToBrowseItem*, IShellItem**, int>)(lpVtbl[4]))((IUseToBrowseItem*)Unsafe.AsPointer(ref this), ppsi);
        }
    }
}
