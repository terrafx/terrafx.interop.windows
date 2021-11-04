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
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IShellFavoritesNameSpace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, void**, int>)(lpVtbl[0]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[1]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint>)(lpVtbl[2]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint*, int>)(lpVtbl[3]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT MoveSelectionUp()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[7]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MoveSelectionDown()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[8]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ResetSort()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[9]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT NewFolder()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[10]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Synchronize()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[11]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Import()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[12]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Export()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[13]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT InvokeContextMenuCommand([NativeTypeName("BSTR")] ushort* strCommand)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[14]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), strCommand);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT MoveSelectionTo()
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, int>)(lpVtbl[15]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_SubscriptionsEnabled([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[16]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[17]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DeleteSubscriptionForSelection([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, short*, int>)(lpVtbl[18]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetRoot([NativeTypeName("BSTR")] ushort* bstrFullPath)
        {
            return ((delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int>)(lpVtbl[19]))((IShellFavoritesNameSpace*)Unsafe.AsPointer(ref this), bstrFullPath);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> MoveSelectionUp;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> MoveSelectionDown;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> ResetSort;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> NewFolder;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> Synchronize;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> Import;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> Export;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int> InvokeContextMenuCommand;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, int> MoveSelectionTo;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, short*, int> get_SubscriptionsEnabled;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, short*, int> CreateSubscriptionForSelection;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, short*, int> DeleteSubscriptionForSelection;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellFavoritesNameSpace*, ushort*, int> SetRoot;
        }
    }
}
