// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A0FFBC28-5482-4366-BE27-3E81E78E06C2")]
    [NativeTypeName("struct ISearchFolderItemFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISearchFolderItemFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint>)(lpVtbl[1]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint>)(lpVtbl[2]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszDisplayName)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ushort*, int>)(lpVtbl[3]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), pszDisplayName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFolderTypeID([NativeTypeName("FOLDERTYPEID")] Guid ftid)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid, int>)(lpVtbl[4]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), ftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFolderLogicalViewMode(FOLDERLOGICALVIEWMODE flvm)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, FOLDERLOGICALVIEWMODE, int>)(lpVtbl[5]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), flvm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetIconSize(int iIconSize)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, int, int>)(lpVtbl[6]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), iIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetVisibleColumns(uint cVisibleColumns, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKey)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int>)(lpVtbl[7]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cVisibleColumns, rgKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetSortColumns(uint cSortColumns, SORTCOLUMN* rgSortColumns)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, SORTCOLUMN*, int>)(lpVtbl[8]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cSortColumns, rgSortColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGroupColumn([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyGroup)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, PROPERTYKEY*, int>)(lpVtbl[9]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), keyGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetStacks(uint cStackKeys, PROPERTYKEY* rgStackKeys)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int>)(lpVtbl[10]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cStackKeys, rgStackKeys);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetScope(IShellItemArray* psiaScope)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, IShellItemArray*, int>)(lpVtbl[11]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), psiaScope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetCondition(ICondition* pCondition)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ICondition*, int>)(lpVtbl[12]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), pCondition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetShellItem([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int>)(lpVtbl[13]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ITEMIDLIST**, int>)(lpVtbl[14]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), ppidl);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, ushort*, int> SetDisplayName;

            [NativeTypeName("HRESULT (FOLDERTYPEID) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, Guid, int> SetFolderTypeID;

            [NativeTypeName("HRESULT (FOLDERLOGICALVIEWMODE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, FOLDERLOGICALVIEWMODE, int> SetFolderLogicalViewMode;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, int, int> SetIconSize;

            [NativeTypeName("HRESULT (UINT, const PROPERTYKEY *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int> SetVisibleColumns;

            [NativeTypeName("HRESULT (UINT, SORTCOLUMN *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, uint, SORTCOLUMN*, int> SetSortColumns;

            [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, PROPERTYKEY*, int> SetGroupColumn;

            [NativeTypeName("HRESULT (UINT, PROPERTYKEY *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int> SetStacks;

            [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, IShellItemArray*, int> SetScope;

            [NativeTypeName("HRESULT (ICondition *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, ICondition*, int> SetCondition;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int> GetShellItem;

            [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchFolderItemFactory*, ITEMIDLIST**, int> GetIDList;
        }
    }
}
