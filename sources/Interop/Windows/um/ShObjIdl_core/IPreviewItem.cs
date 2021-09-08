// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36149969-0A8F-49C8-8B00-4AECB20222FB")]
    [NativeTypeName("struct IPreviewItem : IRelatedItem")]
    [NativeInheritance("IRelatedItem")]
    public unsafe partial struct IPreviewItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPreviewItem*, Guid*, void**, int>)(lpVtbl[0]))((IPreviewItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPreviewItem*, uint>)(lpVtbl[1]))((IPreviewItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPreviewItem*, uint>)(lpVtbl[2]))((IPreviewItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IPreviewItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((IPreviewItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IPreviewItem*, IShellItem**, int>)(lpVtbl[4]))((IPreviewItem*)Unsafe.AsPointer(ref this), ppsi);
        }
    }
}
