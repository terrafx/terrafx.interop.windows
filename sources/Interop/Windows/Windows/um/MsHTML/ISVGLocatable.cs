// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("305104DB-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGLocatable : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGLocatable : ISVGLocatable.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGLocatable*, Guid*, void**, int>)(lpVtbl[0]))((ISVGLocatable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGLocatable*, uint>)(lpVtbl[1]))((ISVGLocatable*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGLocatable*, uint>)(lpVtbl[2]))((ISVGLocatable*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGLocatable*, uint*, int>)(lpVtbl[3]))((ISVGLocatable*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGLocatable*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGLocatable*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGLocatable*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGLocatable*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGLocatable*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGLocatable*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nearestViewportElement(ISVGElement** p)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGElement**, int>)(lpVtbl[7]))((ISVGLocatable*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_farthestViewportElement(ISVGElement** p)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGElement**, int>)(lpVtbl[8]))((ISVGLocatable*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT getBBox(ISVGRect** ppResult)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGRect**, int>)(lpVtbl[9]))((ISVGLocatable*)Unsafe.AsPointer(ref this), ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getCTM(ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGMatrix**, int>)(lpVtbl[10]))((ISVGLocatable*)Unsafe.AsPointer(ref this), ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getScreenCTM(ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGMatrix**, int>)(lpVtbl[11]))((ISVGLocatable*)Unsafe.AsPointer(ref this), ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT getTransformToElement(ISVGElement* pElement, ISVGMatrix** ppResult)
    {
        return ((delegate* unmanaged<ISVGLocatable*, ISVGElement*, ISVGMatrix**, int>)(lpVtbl[12]))((ISVGLocatable*)Unsafe.AsPointer(ref this), pElement, ppResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_nearestViewportElement(ISVGElement** p);

        [VtblIndex(8)]
        HRESULT get_farthestViewportElement(ISVGElement** p);

        [VtblIndex(9)]
        HRESULT getBBox(ISVGRect** ppResult);

        [VtblIndex(10)]
        HRESULT getCTM(ISVGMatrix** ppResult);

        [VtblIndex(11)]
        HRESULT getScreenCTM(ISVGMatrix** ppResult);

        [VtblIndex(12)]
        HRESULT getTransformToElement(ISVGElement* pElement, ISVGMatrix** ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (ISVGElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGElement**, int> get_nearestViewportElement;

        [NativeTypeName("HRESULT (ISVGElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGElement**, int> get_farthestViewportElement;

        [NativeTypeName("HRESULT (ISVGRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGRect**, int> getBBox;

        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGMatrix**, int> getCTM;

        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGMatrix**, int> getScreenCTM;

        [NativeTypeName("HRESULT (ISVGElement *, ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGLocatable*, ISVGElement*, ISVGMatrix**, int> getTransformToElement;
    }
}
