// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104BE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IRulesAppliedCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IRulesAppliedCollection : IRulesAppliedCollection.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, Guid*, void**, int>)(lpVtbl[0]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, uint>)(lpVtbl[1]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, uint>)(lpVtbl[2]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, uint*, int>)(lpVtbl[3]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT item([NativeTypeName("long")] int index, IRulesApplied** ppRulesApplied)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, int, IRulesApplied**, int>)(lpVtbl[7]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), index, ppRulesApplied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, int*, int>)(lpVtbl[8]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_element(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, IHTMLElement**, int>)(lpVtbl[9]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT propertyInheritedFrom([NativeTypeName("BSTR")] ushort* name, IRulesApplied** ppRulesApplied)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, ushort*, IRulesApplied**, int>)(lpVtbl[10]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, ppRulesApplied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_propertyCount([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, int*, int>)(lpVtbl[11]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT property([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrProperty)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, int, ushort**, int>)(lpVtbl[12]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), index, pbstrProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT propertyInheritedTrace([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long")] int index, IRulesApplied** ppRulesApplied)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, ushort*, int, IRulesApplied**, int>)(lpVtbl[13]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, index, ppRulesApplied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT propertyInheritedTraceLength([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long *")] int* pLength)
        {
            return ((delegate* unmanaged<IRulesAppliedCollection*, ushort*, int*, int>)(lpVtbl[14]))((IRulesAppliedCollection*)Unsafe.AsPointer(ref this), name, pLength);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT item([NativeTypeName("long")] int index, IRulesApplied** ppRulesApplied);

            [VtblIndex(8)]
            HRESULT get_length([NativeTypeName("long *")] int* p);

            [VtblIndex(9)]
            HRESULT get_element(IHTMLElement** p);

            [VtblIndex(10)]
            HRESULT propertyInheritedFrom([NativeTypeName("BSTR")] ushort* name, IRulesApplied** ppRulesApplied);

            [VtblIndex(11)]
            HRESULT get_propertyCount([NativeTypeName("long *")] int* p);

            [VtblIndex(12)]
            HRESULT property([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrProperty);

            [VtblIndex(13)]
            HRESULT propertyInheritedTrace([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long")] int index, IRulesApplied** ppRulesApplied);

            [VtblIndex(14)]
            HRESULT propertyInheritedTraceLength([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("long *")] int* pLength);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long, IRulesApplied **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, int, IRulesApplied**, int> item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, int*, int> get_length;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, IHTMLElement**, int> get_element;

            [NativeTypeName("HRESULT (BSTR, IRulesApplied **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, ushort*, IRulesApplied**, int> propertyInheritedFrom;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, int*, int> get_propertyCount;

            [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, int, ushort**, int> property;

            [NativeTypeName("HRESULT (BSTR, long, IRulesApplied **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, ushort*, int, IRulesApplied**, int> propertyInheritedTrace;

            [NativeTypeName("HRESULT (BSTR, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesAppliedCollection*, ushort*, int*, int> propertyInheritedTraceLength;
        }
    }
}
