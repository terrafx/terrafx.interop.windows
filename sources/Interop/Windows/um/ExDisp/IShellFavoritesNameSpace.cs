// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55136804-B2DE-11D1-B9F2-00A0C98BC547")]
    [NativeTypeName("struct IShellFavoritesNameSpace : IDispatch")]
    public unsafe partial struct IShellFavoritesNameSpace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, void**, int>)(lpVtbl[0]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[1]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[2]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint*, int>)(lpVtbl[3]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveSelectionUp()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[7]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveSelectionDown()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[8]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetSort()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[9]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NewFolder()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[10]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Synchronize()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[11]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Import()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[12]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Export()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[13]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[14]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), strCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveSelectionTo()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[15]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[16]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[17]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[18]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[19]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), bstrFullPath);
        }
    }
}
