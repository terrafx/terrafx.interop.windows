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
    public unsafe partial struct ISearchFolderItemFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint>)(lpVtbl[1]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint>)(lpVtbl[2]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszDisplayName)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ushort*, int>)(lpVtbl[3]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), pszDisplayName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFolderTypeID([NativeTypeName("FOLDERTYPEID")] Guid ftid)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid, int>)(lpVtbl[4]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), ftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFolderLogicalViewMode(FOLDERLOGICALVIEWMODE flvm)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, FOLDERLOGICALVIEWMODE, int>)(lpVtbl[5]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), flvm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconSize(int iIconSize)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, int, int>)(lpVtbl[6]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), iIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVisibleColumns([NativeTypeName("UINT")] uint cVisibleColumns, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKey)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int>)(lpVtbl[7]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cVisibleColumns, rgKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSortColumns([NativeTypeName("UINT")] uint cSortColumns, SORTCOLUMN* rgSortColumns)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, SORTCOLUMN*, int>)(lpVtbl[8]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cSortColumns, rgSortColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGroupColumn([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyGroup)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, PROPERTYKEY*, int>)(lpVtbl[9]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), keyGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStacks([NativeTypeName("UINT")] uint cStackKeys, PROPERTYKEY* rgStackKeys)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, uint, PROPERTYKEY*, int>)(lpVtbl[10]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), cStackKeys, rgStackKeys);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScope(IShellItemArray* psiaScope)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, IShellItemArray*, int>)(lpVtbl[11]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), psiaScope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCondition(ICondition* pCondition)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ICondition*, int>)(lpVtbl[12]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), pCondition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShellItem([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, Guid*, void**, int>)(lpVtbl[13]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<ISearchFolderItemFactory*, ITEMIDLIST**, int>)(lpVtbl[14]))((ISearchFolderItemFactory*)Unsafe.AsPointer(ref this), ppidl);
        }
    }
}
