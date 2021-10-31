// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29EC8E6C-46D3-411F-BAAA-611A6C9CAC66")]
    [NativeTypeName("struct IShellFolderViewDual3 : IShellFolderViewDual2")]
    [NativeInheritance("IShellFolderViewDual2")]
    public unsafe partial struct IShellFolderViewDual3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint>)(lpVtbl[1]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint>)(lpVtbl[2]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint*, int>)(lpVtbl[3]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, IDispatch**, int>)(lpVtbl[7]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, IDispatch**, int>)(lpVtbl[8]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Folder(Folder** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, Folder**, int>)(lpVtbl[9]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SelectedItems(FolderItems** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, FolderItems**, int>)(lpVtbl[10]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_FocusedItem(FolderItem** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, FolderItem**, int>)(lpVtbl[11]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SelectItem(VARIANT* pvfi, int dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, VARIANT*, int, int>)(lpVtbl[12]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pvfi, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PopupItemMenu(FolderItem* pfi, VARIANT vx, VARIANT vy, [NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, FolderItem*, VARIANT, VARIANT, ushort**, int>)(lpVtbl[13]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pfi, vx, vy, pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Script(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, IDispatch**, int>)(lpVtbl[14]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, int*, int>)(lpVtbl[15]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), plViewOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_CurrentViewMode([NativeTypeName("UINT *")] uint* pViewMode)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint*, int>)(lpVtbl[16]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_CurrentViewMode([NativeTypeName("UINT")] uint ViewMode)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint, int>)(lpVtbl[17]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), ViewMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SelectItemRelative(int iRelative)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, int, int>)(lpVtbl[18]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), iRelative);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_GroupBy([NativeTypeName("BSTR *")] ushort** pbstrGroupBy)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, ushort**, int>)(lpVtbl[19]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pbstrGroupBy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_GroupBy([NativeTypeName("BSTR")] ushort* bstrGroupBy)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, ushort*, int>)(lpVtbl[20]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), bstrGroupBy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_FolderFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint*, int>)(lpVtbl[21]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_FolderFlags([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, uint, int>)(lpVtbl[22]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_SortColumns([NativeTypeName("BSTR *")] ushort** pbstrSortColumns)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, ushort**, int>)(lpVtbl[23]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), pbstrSortColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_SortColumns([NativeTypeName("BSTR")] ushort* bstrSortColumns)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, ushort*, int>)(lpVtbl[24]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), bstrSortColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_IconSize(int iIconSize)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, int, int>)(lpVtbl[25]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), iIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_IconSize(int* piIconSize)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, int*, int>)(lpVtbl[26]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), piIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT FilterView([NativeTypeName("BSTR")] ushort* bstrFilterText)
        {
            return ((delegate* unmanaged<IShellFolderViewDual3*, ushort*, int>)(lpVtbl[27]))((IShellFolderViewDual3*)Unsafe.AsPointer(ref this), bstrFilterText);
        }
    }
}
