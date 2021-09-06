// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77F295D5-2D6F-4E19-B8AE-322F3E721AB5")]
    [NativeTypeName("struct ITransferMediumItem : IRelatedItem")]
    public unsafe partial struct ITransferMediumItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITransferMediumItem*, Guid*, void**, int>)(lpVtbl[0]))((ITransferMediumItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITransferMediumItem*, uint>)(lpVtbl[1]))((ITransferMediumItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITransferMediumItem*, uint>)(lpVtbl[2]))((ITransferMediumItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<ITransferMediumItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((ITransferMediumItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<ITransferMediumItem*, IShellItem**, int>)(lpVtbl[4]))((ITransferMediumItem*)Unsafe.AsPointer(ref this), ppsi);
        }
    }
}
