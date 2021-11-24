// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1AF3A467-214F-4298-908E-06B03E0B39F9")]
[NativeTypeName("struct IFolderView2 : IFolderView")]
[NativeInheritance("IFolderView")]
public unsafe partial struct IFolderView2 : IFolderView2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT GetCurrentViewMode(uint* pViewMode)
    {
        return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[3]))((IFolderView2*)Unsafe.AsPointer(ref this), pViewMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCurrentViewMode(uint ViewMode)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, int>)(lpVtbl[4]))((IFolderView2*)Unsafe.AsPointer(ref this), ViewMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2*, Guid*, void**, int>)(lpVtbl[5]))((IFolderView2*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IFolderView2*, int, ITEMIDLIST**, int>)(lpVtbl[6]))((IFolderView2*)Unsafe.AsPointer(ref this), iItemIndex, ppidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ItemCount(uint uFlags, int* pcItems)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, int*, int>)(lpVtbl[7]))((IFolderView2*)Unsafe.AsPointer(ref this), uFlags, pcItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Items(uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, Guid*, void**, int>)(lpVtbl[8]))((IFolderView2*)Unsafe.AsPointer(ref this), uFlags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSelectionMarkedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[9]))((IFolderView2*)Unsafe.AsPointer(ref this), piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFocusedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[10]))((IFolderView2*)Unsafe.AsPointer(ref this), piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, POINT*, int>)(lpVtbl[11]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, ppt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2*, POINT*, int>)(lpVtbl[12]))((IFolderView2*)Unsafe.AsPointer(ref this), ppt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefaultSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView2*, POINT*, int>)(lpVtbl[13]))((IFolderView2*)Unsafe.AsPointer(ref this), ppt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetAutoArrange()
    {
        return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[14]))((IFolderView2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView2*, int, uint, int>)(lpVtbl[15]))((IFolderView2*)Unsafe.AsPointer(ref this), iItem, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SelectAndPositionItems(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, ITEMIDLIST**, POINT*, uint, int>)(lpVtbl[16]))((IFolderView2*)Unsafe.AsPointer(ref this), cidl, apidl, apt, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetGroupBy([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, BOOL fAscending)
    {
        return ((delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL, int>)(lpVtbl[17]))((IFolderView2*)Unsafe.AsPointer(ref this), key, fAscending);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetGroupBy(PROPERTYKEY* pkey, BOOL* pfAscending)
    {
        return ((delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL*, int>)(lpVtbl[18]))((IFolderView2*)Unsafe.AsPointer(ref this), pkey, pfAscending);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[19]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, propkey, propvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[20]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, propkey, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int>)(lpVtbl[21]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pszPropList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetExtendedTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int>)(lpVtbl[22]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pszPropList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetText(FVTEXTTYPE iType, [NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IFolderView2*, FVTEXTTYPE, ushort*, int>)(lpVtbl[23]))((IFolderView2*)Unsafe.AsPointer(ref this), iType, pwszText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetCurrentFolderFlags([NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, uint, int>)(lpVtbl[24]))((IFolderView2*)Unsafe.AsPointer(ref this), dwMask, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetCurrentFolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[25]))((IFolderView2*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetSortColumnCount(int* pcColumns)
    {
        return ((delegate* unmanaged<IFolderView2*, int*, int>)(lpVtbl[26]))((IFolderView2*)Unsafe.AsPointer(ref this), pcColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetSortColumns([NativeTypeName("const SORTCOLUMN *")] SORTCOLUMN* rgSortColumns, int cColumns)
    {
        return ((delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int>)(lpVtbl[27]))((IFolderView2*)Unsafe.AsPointer(ref this), rgSortColumns, cColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, int cColumns)
    {
        return ((delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int>)(lpVtbl[28]))((IFolderView2*)Unsafe.AsPointer(ref this), rgSortColumns, cColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetItem(int iItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView2*, int, Guid*, void**, int>)(lpVtbl[29]))((IFolderView2*)Unsafe.AsPointer(ref this), iItem, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetVisibleItem(int iStart, BOOL fPrevious, int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2*, int, BOOL, int*, int>)(lpVtbl[30]))((IFolderView2*)Unsafe.AsPointer(ref this), iStart, fPrevious, piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetSelectedItem(int iStart, int* piItem)
    {
        return ((delegate* unmanaged<IFolderView2*, int, int*, int>)(lpVtbl[31]))((IFolderView2*)Unsafe.AsPointer(ref this), iStart, piItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetSelection(BOOL fNoneImpliesFolder, IShellItemArray** ppsia)
    {
        return ((delegate* unmanaged<IFolderView2*, BOOL, IShellItemArray**, int>)(lpVtbl[32]))((IFolderView2*)Unsafe.AsPointer(ref this), fNoneImpliesFolder, ppsia);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetSelectionState([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IFolderView2*, ITEMIDLIST*, uint*, int>)(lpVtbl[33]))((IFolderView2*)Unsafe.AsPointer(ref this), pidl, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT InvokeVerbOnSelection([NativeTypeName("LPCSTR")] sbyte* pszVerb)
    {
        return ((delegate* unmanaged<IFolderView2*, sbyte*, int>)(lpVtbl[34]))((IFolderView2*)Unsafe.AsPointer(ref this), pszVerb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize)
    {
        return ((delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE, int, int>)(lpVtbl[35]))((IFolderView2*)Unsafe.AsPointer(ref this), uViewMode, iImageSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetViewModeAndIconSize(FOLDERVIEWMODE* puViewMode, int* piImageSize)
    {
        return ((delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE*, int*, int>)(lpVtbl[36]))((IFolderView2*)Unsafe.AsPointer(ref this), puViewMode, piImageSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetGroupSubsetCount(uint cVisibleRows)
    {
        return ((delegate* unmanaged<IFolderView2*, uint, int>)(lpVtbl[37]))((IFolderView2*)Unsafe.AsPointer(ref this), cVisibleRows);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetGroupSubsetCount(uint* pcVisibleRows)
    {
        return ((delegate* unmanaged<IFolderView2*, uint*, int>)(lpVtbl[38]))((IFolderView2*)Unsafe.AsPointer(ref this), pcVisibleRows);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetRedraw(BOOL fRedrawOn)
    {
        return ((delegate* unmanaged<IFolderView2*, BOOL, int>)(lpVtbl[39]))((IFolderView2*)Unsafe.AsPointer(ref this), fRedrawOn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT IsMoveInSameFolder()
    {
        return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[40]))((IFolderView2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT DoRename()
    {
        return ((delegate* unmanaged<IFolderView2*, int>)(lpVtbl[41]))((IFolderView2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IFolderView.Interface
    {
        [VtblIndex(17)]
        HRESULT SetGroupBy([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, BOOL fAscending);

        [VtblIndex(18)]
        HRESULT GetGroupBy(PROPERTYKEY* pkey, BOOL* pfAscending);

        [VtblIndex(19)]
        HRESULT SetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [VtblIndex(20)]
        HRESULT GetViewProperty([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar);

        [VtblIndex(21)]
        HRESULT SetTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList);

        [VtblIndex(22)]
        HRESULT SetExtendedTileViewProperties([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszPropList);

        [VtblIndex(23)]
        HRESULT SetText(FVTEXTTYPE iType, [NativeTypeName("LPCWSTR")] ushort* pwszText);

        [VtblIndex(24)]
        HRESULT SetCurrentFolderFlags([NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(25)]
        HRESULT GetCurrentFolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(26)]
        HRESULT GetSortColumnCount(int* pcColumns);

        [VtblIndex(27)]
        HRESULT SetSortColumns([NativeTypeName("const SORTCOLUMN *")] SORTCOLUMN* rgSortColumns, int cColumns);

        [VtblIndex(28)]
        HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, int cColumns);

        [VtblIndex(29)]
        HRESULT GetItem(int iItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(30)]
        HRESULT GetVisibleItem(int iStart, BOOL fPrevious, int* piItem);

        [VtblIndex(31)]
        HRESULT GetSelectedItem(int iStart, int* piItem);

        [VtblIndex(32)]
        HRESULT GetSelection(BOOL fNoneImpliesFolder, IShellItemArray** ppsia);

        [VtblIndex(33)]
        HRESULT GetSelectionState([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(34)]
        HRESULT InvokeVerbOnSelection([NativeTypeName("LPCSTR")] sbyte* pszVerb);

        [VtblIndex(35)]
        HRESULT SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize);

        [VtblIndex(36)]
        HRESULT GetViewModeAndIconSize(FOLDERVIEWMODE* puViewMode, int* piImageSize);

        [VtblIndex(37)]
        HRESULT SetGroupSubsetCount(uint cVisibleRows);

        [VtblIndex(38)]
        HRESULT GetGroupSubsetCount(uint* pcVisibleRows);

        [VtblIndex(39)]
        HRESULT SetRedraw(BOOL fRedrawOn);

        [VtblIndex(40)]
        HRESULT IsMoveInSameFolder();

        [VtblIndex(41)]
        HRESULT DoRename();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint*, int> GetCurrentViewMode;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, int> SetCurrentViewMode;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, Guid*, void**, int> GetFolder;

        [NativeTypeName("HRESULT (int, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int, ITEMIDLIST**, int> Item;

        [NativeTypeName("HRESULT (UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, int*, int> ItemCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, Guid*, void**, int> Items;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int*, int> GetSelectionMarkedItem;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int*, int> GetFocusedItem;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, POINT*, int> GetItemPosition;

        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, POINT*, int> GetSpacing;

        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, POINT*, int> GetDefaultSpacing;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int> GetAutoArrange;

        [NativeTypeName("HRESULT (int, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int, uint, int> SelectItem;

        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, ITEMIDLIST**, POINT*, uint, int> SelectAndPositionItems;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL, int> SetGroupBy;

        [NativeTypeName("HRESULT (PROPERTYKEY *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, PROPERTYKEY*, BOOL*, int> GetGroupBy;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, const PROPERTYKEY &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int> SetViewProperty;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, PROPERTYKEY*, PROPVARIANT*, int> GetViewProperty;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int> SetTileViewProperties;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, ushort*, int> SetExtendedTileViewProperties;

        [NativeTypeName("HRESULT (FVTEXTTYPE, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, FVTEXTTYPE, ushort*, int> SetText;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, uint, int> SetCurrentFolderFlags;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint*, int> GetCurrentFolderFlags;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int*, int> GetSortColumnCount;

        [NativeTypeName("HRESULT (const SORTCOLUMN *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int> SetSortColumns;

        [NativeTypeName("HRESULT (SORTCOLUMN *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, SORTCOLUMN*, int, int> GetSortColumns;

        [NativeTypeName("HRESULT (int, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int, Guid*, void**, int> GetItem;

        [NativeTypeName("HRESULT (int, BOOL, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int, BOOL, int*, int> GetVisibleItem;

        [NativeTypeName("HRESULT (int, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int, int*, int> GetSelectedItem;

        [NativeTypeName("HRESULT (BOOL, IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, BOOL, IShellItemArray**, int> GetSelection;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, ITEMIDLIST*, uint*, int> GetSelectionState;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, sbyte*, int> InvokeVerbOnSelection;

        [NativeTypeName("HRESULT (FOLDERVIEWMODE, int) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE, int, int> SetViewModeAndIconSize;

        [NativeTypeName("HRESULT (FOLDERVIEWMODE *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, FOLDERVIEWMODE*, int*, int> GetViewModeAndIconSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint, int> SetGroupSubsetCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, uint*, int> GetGroupSubsetCount;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, BOOL, int> SetRedraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int> IsMoveInSameFolder;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IFolderView2*, int> DoRename;
    }
}
