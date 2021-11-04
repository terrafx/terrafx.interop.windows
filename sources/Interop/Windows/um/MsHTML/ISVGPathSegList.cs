// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510510-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGPathSegList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGPathSegList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGPathSegList*, uint>)(lpVtbl[1]))((ISVGPathSegList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGPathSegList*, uint>)(lpVtbl[2]))((ISVGPathSegList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, uint*, int>)(lpVtbl[3]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int, int>)(lpVtbl[7]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int*, int>)(lpVtbl[8]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT clear()
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int>)(lpVtbl[9]))((ISVGPathSegList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT initialize(ISVGPathSeg* newItem, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, ISVGPathSeg**, int>)(lpVtbl[10]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), newItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getItem([NativeTypeName("long")] int index, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int, ISVGPathSeg**, int>)(lpVtbl[11]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT insertItemBefore(ISVGPathSeg* newItem, [NativeTypeName("long")] int index, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, int, ISVGPathSeg**, int>)(lpVtbl[12]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT replaceItem(ISVGPathSeg* newItem, [NativeTypeName("long")] int index, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, int, ISVGPathSeg**, int>)(lpVtbl[13]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT removeItem([NativeTypeName("long")] int index, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, int, ISVGPathSeg**, int>)(lpVtbl[14]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT appendItem(ISVGPathSeg* newItem, ISVGPathSeg** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, ISVGPathSeg**, int>)(lpVtbl[15]))((ISVGPathSegList*)Unsafe.AsPointer(ref this), newItem, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int, int> put_numberOfItems;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int*, int> get_numberOfItems;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int> clear;

            [NativeTypeName("HRESULT (ISVGPathSeg *, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, ISVGPathSeg**, int> initialize;

            [NativeTypeName("HRESULT (long, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int, ISVGPathSeg**, int> getItem;

            [NativeTypeName("HRESULT (ISVGPathSeg *, long, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, int, ISVGPathSeg**, int> insertItemBefore;

            [NativeTypeName("HRESULT (ISVGPathSeg *, long, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, int, ISVGPathSeg**, int> replaceItem;

            [NativeTypeName("HRESULT (long, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, int, ISVGPathSeg**, int> removeItem;

            [NativeTypeName("HRESULT (ISVGPathSeg *, ISVGPathSeg **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegList*, ISVGPathSeg*, ISVGPathSeg**, int> appendItem;
        }
    }
}
