// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3C5A1C94-C951-4CB7-BB6D-3B93F30CCE93")]
    [NativeTypeName("struct IDelegateItem : IRelatedItem")]
    [NativeInheritance("IRelatedItem")]
    public unsafe partial struct IDelegateItem : IDelegateItem.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDelegateItem*, Guid*, void**, int>)(lpVtbl[0]))((IDelegateItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDelegateItem*, uint>)(lpVtbl[1]))((IDelegateItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDelegateItem*, uint>)(lpVtbl[2]))((IDelegateItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IDelegateItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((IDelegateItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IDelegateItem*, IShellItem**, int>)(lpVtbl[4]))((IDelegateItem*)Unsafe.AsPointer(ref this), ppsi);
        }

        public interface Interface : IRelatedItem.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateItem*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateItem*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateItem*, uint> Release;

            [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateItem*, ITEMIDLIST**, int> GetItemIDList;

            [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateItem*, IShellItem**, int> GetItem;
        }
    }
}
