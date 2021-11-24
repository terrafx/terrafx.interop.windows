// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("30510469-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAttributeCollection3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAttributeCollection3 : IHTMLAttributeCollection3.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, uint>)(lpVtbl[1]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, uint>)(lpVtbl[2]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, uint*, int>)(lpVtbl[3]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[7]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setNamedItem(IHTMLDOMAttribute* pNodeIn, IHTMLDOMAttribute** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[8]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), pNodeIn, ppNodeOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[9]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item([NativeTypeName("long")] int index, IHTMLDOMAttribute** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, int, IHTMLDOMAttribute**, int>)(lpVtbl[10]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), index, ppNodeOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection3*, int*, int>)(lpVtbl[11]))((IHTMLAttributeCollection3*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** ppNodeOut);

        [VtblIndex(8)]
        HRESULT setNamedItem(IHTMLDOMAttribute* pNodeIn, IHTMLDOMAttribute** ppNodeOut);

        [VtblIndex(9)]
        HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** ppNodeOut);

        [VtblIndex(10)]
        HRESULT item([NativeTypeName("long")] int index, IHTMLDOMAttribute** ppNodeOut);

        [VtblIndex(11)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, ushort*, IHTMLDOMAttribute**, int> getNamedItem;

        [NativeTypeName("HRESULT (IHTMLDOMAttribute *, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int> setNamedItem;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, ushort*, IHTMLDOMAttribute**, int> removeNamedItem;

        [NativeTypeName("HRESULT (long, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, int, IHTMLDOMAttribute**, int> item;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLAttributeCollection3*, int*, int> get_length;
    }
}
