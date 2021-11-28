// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3050F21F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElementCollection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElementCollection : IHTMLElementCollection.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, uint>)(lpVtbl[1]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, uint>)(lpVtbl[2]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, uint*, int>)(lpVtbl[3]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, ushort**, int>)(lpVtbl[7]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), String);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_length([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, int, int>)(lpVtbl[8]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, int*, int>)(lpVtbl[9]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get__newEnum(IUnknown** p)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, IUnknown**, int>)(lpVtbl[10]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[11]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), name, index, pdisp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT tags(VARIANT tagName, IDispatch** pdisp)
    {
        return ((delegate* unmanaged<IHTMLElementCollection*, VARIANT, IDispatch**, int>)(lpVtbl[12]))((IHTMLElementCollection*)Unsafe.AsPointer(ref this), tagName, pdisp);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);

        [VtblIndex(8)]
        HRESULT put_length([NativeTypeName("long")] int v);

        [VtblIndex(9)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(10)]
        HRESULT get__newEnum(IUnknown** p);

        [VtblIndex(11)]
        HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp);

        [VtblIndex(12)]
        HRESULT tags(VARIANT tagName, IDispatch** pdisp);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_length;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__newEnum;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, IDispatch**, int> item;

        [NativeTypeName("HRESULT (VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDispatch**, int> tags;
    }
}
