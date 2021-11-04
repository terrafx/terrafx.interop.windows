// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104F5-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGPointList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGPointList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGPointList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPointList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGPointList*, uint>)(lpVtbl[1]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGPointList*, uint>)(lpVtbl[2]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGPointList*, uint*, int>)(lpVtbl[3]))((ISVGPointList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGPointList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPointList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGPointList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPointList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPointList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, int>)(lpVtbl[7]))((ISVGPointList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ISVGPointList*, int*, int>)(lpVtbl[8]))((ISVGPointList*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT clear()
        {
            return ((delegate* unmanaged<ISVGPointList*, int>)(lpVtbl[9]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT initialize(ISVGPoint* pNewItem, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int>)(lpVtbl[10]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getItem([NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int>)(lpVtbl[11]))((ISVGPointList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT insertItemBefore(ISVGPoint* pNewItem, [NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int>)(lpVtbl[12]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT replaceItem(ISVGPoint* pNewItem, [NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int>)(lpVtbl[13]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT removeItem([NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int>)(lpVtbl[14]))((ISVGPointList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT appendItem(ISVGPoint* pNewItem, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int>)(lpVtbl[15]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int, int> put_numberOfItems;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int*, int> get_numberOfItems;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int> clear;

            [NativeTypeName("HRESULT (ISVGPoint *, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int> initialize;

            [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int> getItem;

            [NativeTypeName("HRESULT (ISVGPoint *, long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int> insertItemBefore;

            [NativeTypeName("HRESULT (ISVGPoint *, long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int> replaceItem;

            [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int> removeItem;

            [NativeTypeName("HRESULT (ISVGPoint *, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int> appendItem;
        }
    }
}
