// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("30510746-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMNodeIterator : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMNodeIterator : IDOMNodeIterator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, Guid*, void**, int>)(lpVtbl[0]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, uint>)(lpVtbl[1]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, uint>)(lpVtbl[2]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, uint*, int>)(lpVtbl[3]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_root(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int>)(lpVtbl[7]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_whatToShow([NativeTypeName("ULONG *")] uint* p)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, uint*, int>)(lpVtbl[8]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_filter(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int>)(lpVtbl[9]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_expandEntityReferences([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, short*, int>)(lpVtbl[10]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT nextNode(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int>)(lpVtbl[11]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT previousNode(IDispatch** ppRetNode)
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int>)(lpVtbl[12]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this), ppRetNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT detach()
    {
        return ((delegate* unmanaged<IDOMNodeIterator*, int>)(lpVtbl[13]))((IDOMNodeIterator*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_root(IDispatch** p);

        [VtblIndex(8)]
        HRESULT get_whatToShow([NativeTypeName("ULONG *")] uint* p);

        [VtblIndex(9)]
        HRESULT get_filter(IDispatch** p);

        [VtblIndex(10)]
        HRESULT get_expandEntityReferences([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT nextNode(IDispatch** ppRetNode);

        [VtblIndex(12)]
        HRESULT previousNode(IDispatch** ppRetNode);

        [VtblIndex(13)]
        HRESULT detach();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int> get_root;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, uint*, int> get_whatToShow;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int> get_filter;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, short*, int> get_expandEntityReferences;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int> nextNode;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, IDispatch**, int> previousNode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IDOMNodeIterator*, int> detach;
    }
}
