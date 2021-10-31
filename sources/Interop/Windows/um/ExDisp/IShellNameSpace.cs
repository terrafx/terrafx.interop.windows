// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
    [NativeTypeName("struct IShellNameSpace : IShellFavoritesNameSpace")]
    [NativeInheritance("IShellFavoritesNameSpace")]
    public unsafe partial struct IShellNameSpace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellNameSpace*, Guid*, void**, int>)(lpVtbl[0]))((IShellNameSpace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint>)(lpVtbl[1]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint>)(lpVtbl[2]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint*, int>)(lpVtbl[3]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellNameSpace*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellNameSpace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT MoveSelectionUp()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[7]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MoveSelectionDown()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[8]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ResetSort()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[9]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT NewFolder()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[10]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Synchronize()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[11]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Import()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[12]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Export()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[13]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand)
        {
            return ((delegate* unmanaged<IShellNameSpace*, ushort*, int>)(lpVtbl[14]))((IShellNameSpace*)Unsafe.AsPointer(ref this), strCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT MoveSelectionTo()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[15]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellNameSpace*, short*, int>)(lpVtbl[16]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellNameSpace*, short*, int>)(lpVtbl[17]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellNameSpace*, short*, int>)(lpVtbl[18]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath)
        {
            return ((delegate* unmanaged<IShellNameSpace*, ushort*, int>)(lpVtbl[19]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrFullPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_EnumOptions([NativeTypeName("LONG *")] int* pgrfEnumFlags)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int*, int>)(lpVtbl[20]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pgrfEnumFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_EnumOptions([NativeTypeName("LONG")] int lVal)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int, int>)(lpVtbl[21]))((IShellNameSpace*)Unsafe.AsPointer(ref this), lVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_SelectedItem(IDispatch** pItem)
        {
            return ((delegate* unmanaged<IShellNameSpace*, IDispatch**, int>)(lpVtbl[22]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_SelectedItem(IDispatch* pItem)
        {
            return ((delegate* unmanaged<IShellNameSpace*, IDispatch*, int>)(lpVtbl[23]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_Root(VARIANT* pvar)
        {
            return ((delegate* unmanaged<IShellNameSpace*, VARIANT*, int>)(lpVtbl[24]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_Root(VARIANT var)
        {
            return ((delegate* unmanaged<IShellNameSpace*, VARIANT, int>)(lpVtbl[25]))((IShellNameSpace*)Unsafe.AsPointer(ref this), var);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_Depth(int* piDepth)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int*, int>)(lpVtbl[26]))((IShellNameSpace*)Unsafe.AsPointer(ref this), piDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_Depth(int iDepth)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int, int>)(lpVtbl[27]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_Mode([NativeTypeName("UINT *")] uint* puMode)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint*, int>)(lpVtbl[28]))((IShellNameSpace*)Unsafe.AsPointer(ref this), puMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_Mode([NativeTypeName("UINT")] uint uMode)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint, int>)(lpVtbl[29]))((IShellNameSpace*)Unsafe.AsPointer(ref this), uMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_Flags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint*, int>)(lpVtbl[30]))((IShellNameSpace*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_Flags([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint, int>)(lpVtbl[31]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_TVFlags([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint, int>)(lpVtbl[32]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_TVFlags([NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* unmanaged<IShellNameSpace*, uint*, int>)(lpVtbl[33]))((IShellNameSpace*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_Columns([NativeTypeName("BSTR *")] ushort** bstrColumns)
        {
            return ((delegate* unmanaged<IShellNameSpace*, ushort**, int>)(lpVtbl[34]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_Columns([NativeTypeName("BSTR")] ushort* bstrColumns)
        {
            return ((delegate* unmanaged<IShellNameSpace*, ushort*, int>)(lpVtbl[35]))((IShellNameSpace*)Unsafe.AsPointer(ref this), bstrColumns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_CountViewTypes(int* piTypes)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int*, int>)(lpVtbl[36]))((IShellNameSpace*)Unsafe.AsPointer(ref this), piTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetViewType(int iType)
        {
            return ((delegate* unmanaged<IShellNameSpace*, int, int>)(lpVtbl[37]))((IShellNameSpace*)Unsafe.AsPointer(ref this), iType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT SelectedItems(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellNameSpace*, IDispatch**, int>)(lpVtbl[38]))((IShellNameSpace*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT Expand(VARIANT var, int iDepth)
        {
            return ((delegate* unmanaged<IShellNameSpace*, VARIANT, int, int>)(lpVtbl[39]))((IShellNameSpace*)Unsafe.AsPointer(ref this), var, iDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT UnselectAll()
        {
            return ((delegate* unmanaged<IShellNameSpace*, int>)(lpVtbl[40]))((IShellNameSpace*)Unsafe.AsPointer(ref this));
        }
    }
}
