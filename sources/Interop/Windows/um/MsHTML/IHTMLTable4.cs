// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106C2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTable4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTable4 : IHTMLTable4.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTable4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTable4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTable4*, uint>)(lpVtbl[1]))((IHTMLTable4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTable4*, uint>)(lpVtbl[2]))((IHTMLTable4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTable4*, uint*, int>)(lpVtbl[3]))((IHTMLTable4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTable4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTable4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTable4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTable4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTable4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTable4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_tHead(IHTMLTableSection* v)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableSection*, int>)(lpVtbl[7]))((IHTMLTable4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_tHead(IHTMLTableSection** p)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int>)(lpVtbl[8]))((IHTMLTable4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_tFoot(IHTMLTableSection* v)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableSection*, int>)(lpVtbl[9]))((IHTMLTable4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_tFoot(IHTMLTableSection** p)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int>)(lpVtbl[10]))((IHTMLTable4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_caption(IHTMLTableCaption* v)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableCaption*, int>)(lpVtbl[11]))((IHTMLTable4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_caption(IHTMLTableCaption** p)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableCaption**, int>)(lpVtbl[12]))((IHTMLTable4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row)
        {
            return ((delegate* unmanaged<IHTMLTable4*, int, IDispatch**, int>)(lpVtbl[13]))((IHTMLTable4*)Unsafe.AsPointer(ref this), index, row);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT deleteRow([NativeTypeName("long")] int index = -1)
        {
            return ((delegate* unmanaged<IHTMLTable4*, int, int>)(lpVtbl[14]))((IHTMLTable4*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT createTBody(IHTMLTableSection** tbody)
        {
            return ((delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int>)(lpVtbl[15]))((IHTMLTable4*)Unsafe.AsPointer(ref this), tbody);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT putref_tHead(IHTMLTableSection* v);

            [VtblIndex(8)]
            HRESULT get_tHead(IHTMLTableSection** p);

            [VtblIndex(9)]
            HRESULT putref_tFoot(IHTMLTableSection* v);

            [VtblIndex(10)]
            HRESULT get_tFoot(IHTMLTableSection** p);

            [VtblIndex(11)]
            HRESULT putref_caption(IHTMLTableCaption* v);

            [VtblIndex(12)]
            HRESULT get_caption(IHTMLTableCaption** p);

            [VtblIndex(13)]
            HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row);

            [VtblIndex(14)]
            HRESULT deleteRow([NativeTypeName("long")] int index = -1);

            [VtblIndex(15)]
            HRESULT createTBody(IHTMLTableSection** tbody);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IHTMLTableSection *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableSection*, int> putref_tHead;

            [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int> get_tHead;

            [NativeTypeName("HRESULT (IHTMLTableSection *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableSection*, int> putref_tFoot;

            [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int> get_tFoot;

            [NativeTypeName("HRESULT (IHTMLTableCaption *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableCaption*, int> putref_caption;

            [NativeTypeName("HRESULT (IHTMLTableCaption **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableCaption**, int> get_caption;

            [NativeTypeName("HRESULT (long, IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, int, IDispatch**, int> insertRow;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, int, int> deleteRow;

            [NativeTypeName("HRESULT (IHTMLTableSection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLTable4*, IHTMLTableSection**, int> createTBody;
        }
    }
}
