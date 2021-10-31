// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1AF3A467-214F-4298-908E-06B03E0B39F9")]
    [NativeTypeName("struct IFolderView2 : IFolderView")]
    [NativeInheritance("IFolderView")]
    public unsafe partial struct IFolderView2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderView2*, Guid*, void**, int>)(lpVtbl[0]))((IFolderView2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderView2*, uint>)(lpVtbl[1]))((IFolderView2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderView2*, uint>)(lpVtbl[2]))((IFolderView2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentViewMode([NativeTypeName("UINT *")] uint* pViewMode)
        {
            return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[3]))((IFolderView2*)Unsafe.AsPointer(ref this), pViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentViewMode([NativeTypeName("UINT")] uint ViewMode)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, int>)(lpVtbl[4]))((IFolderView2*)Unsafe.AsPointer(ref this), ViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView2*, Guid*, void**, int>)(lpVtbl[5]))((IFolderView2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IFolderView2*, int, ITEMIDLIST**, int>)(lpVtbl[6]))((IFolderView2*)Unsafe.AsPointer(ref this), iItemIndex, ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ItemCount([NativeTypeName("UINT")] uint uFlags, int* pcItems)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, int*, int>)(lpVtbl[7]))((IFolderView2*)Unsafe.AsPointer(ref this), uFlags, pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Items([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, Guid*, void**, int>)(lpVtbl[8]))((IFolderView2*)Unsafe.AsPointer(ref this), uFlags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionMarkedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[9]))((IFolderView2*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocusedItem(int* piItem)
        {
            return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[10]))((IFolderView2*)Unsafe.AsPointer(ref this), piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, POINT*, int>)(lpVtbl[11]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView2*, POINT*, int>)(lpVtbl[12]))((IFolderView2*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultSpacing(POINT* ppt)
        {
            return ((delegate* unmanaged<IFolderView2*, POINT*, int>)(lpVtbl[13]))((IFolderView2*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutoArrange()
        {
            return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[14]))((IFolderView2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView2*, int, uint, int>)(lpVtbl[15]))((IFolderView2*)Unsafe.AsPointer(ref this), iItem, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SelectAndPositionItems([NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, ITEMIDLIST**, POINT*, uint, int>)(lpVtbl[16]))((IFolderView2*)Unsafe.AsPointer(ref this), cidl, apidl, apt, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetGroupBy([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, BOOL fAscending)
        {
            return ((delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL, int>)(lpVtbl[17]))((IFolderView2*)Unsafe.AsPointer(ref this), key, fAscending);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupBy(PROPERTYKEY* pkey, BOOL* pfAscending)
        {
            return ((delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL*, int>)(lpVtbl[18]))((IFolderView2*)Unsafe.AsPointer(ref this), pkey, pfAscending);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[19]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, propkey, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[20]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, propkey, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int>)(lpVtbl[21]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pszPropList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetExtendedTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int>)(lpVtbl[22]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pszPropList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetText(FVTEXTTYPE iType, [NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IFolderView2*, FVTEXTTYPE, ushort*, int>)(lpVtbl[23]))((IFolderView2*)Unsafe.AsPointer(ref this), iType, pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentFolderFlags([NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, uint, int>)(lpVtbl[24]))((IFolderView2*)Unsafe.AsPointer(ref this), dwMask, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentFolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[25]))((IFolderView2*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortColumnCount(int* pcColumns)
        {
            return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[26]))((IFolderView2*)Unsafe.AsPointer(ref this), pcColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetSortColumns([NativeTypeName("const SORTCOLUMN *")] SORTCOLUMN* rgSortColumns, int cColumns)
        {
            return ((delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int>)(lpVtbl[27]))((IFolderView2*)Unsafe.AsPointer(ref this), rgSortColumns, cColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortColumns(SORTCOLUMN* rgSortColumns, int cColumns)
        {
            return ((delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int>)(lpVtbl[28]))((IFolderView2*)Unsafe.AsPointer(ref this), rgSortColumns, cColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem(int iItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderView2*, int, Guid*, void**, int>)(lpVtbl[29]))((IFolderView2*)Unsafe.AsPointer(ref this), iItem, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int GetVisibleItem(int iStart, BOOL fPrevious, int* piItem)
        {
            return ((delegate* unmanaged<IFolderView2*, int, BOOL, int*, int>)(lpVtbl[30]))((IFolderView2*)Unsafe.AsPointer(ref this), iStart, fPrevious, piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedItem(int iStart, int* piItem)
        {
            return ((delegate* unmanaged<IFolderView2*, int, int*, int>)(lpVtbl[31]))((IFolderView2*)Unsafe.AsPointer(ref this), iStart, piItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection(BOOL fNoneImpliesFolder, IShellItemArray** ppsia)
        {
            return ((delegate* unmanaged<IFolderView2*, BOOL, IShellItemArray**, int>)(lpVtbl[32]))((IFolderView2*)Unsafe.AsPointer(ref this), fNoneImpliesFolder, ppsia);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionState([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, uint*, int>)(lpVtbl[33]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeVerbOnSelection([NativeTypeName("LPCSTR")] sbyte* pszVerb)
        {
            return ((delegate* unmanaged<IFolderView2*, sbyte*, int>)(lpVtbl[34]))((IFolderView2*)Unsafe.AsPointer(ref this), pszVerb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize)
        {
            return ((delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE, int, int>)(lpVtbl[35]))((IFolderView2*)Unsafe.AsPointer(ref this), uViewMode, iImageSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewModeAndIconSize(FOLDERVIEWMODE* puViewMode, int* piImageSize)
        {
            return ((delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE*, int*, int>)(lpVtbl[36]))((IFolderView2*)Unsafe.AsPointer(ref this), puViewMode, piImageSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int SetGroupSubsetCount([NativeTypeName("UINT")] uint cVisibleRows)
        {
            return ((delegate* unmanaged<IFolderView2*, uint, int>)(lpVtbl[37]))((IFolderView2*)Unsafe.AsPointer(ref this), cVisibleRows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupSubsetCount([NativeTypeName("UINT *")] uint* pcVisibleRows)
        {
            return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[38]))((IFolderView2*)Unsafe.AsPointer(ref this), pcVisibleRows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedraw(BOOL fRedrawOn)
        {
            return ((delegate* unmanaged<IFolderView2*, BOOL, int>)(lpVtbl[39]))((IFolderView2*)Unsafe.AsPointer(ref this), fRedrawOn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int IsMoveInSameFolder()
        {
            return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[40]))((IFolderView2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int DoRename()
        {
            return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[41]))((IFolderView2*)Unsafe.AsPointer(ref this));
        }
    }
}
