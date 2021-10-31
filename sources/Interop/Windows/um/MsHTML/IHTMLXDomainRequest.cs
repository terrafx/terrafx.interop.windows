// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510454-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLXDomainRequest : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLXDomainRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, uint>)(lpVtbl[1]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, uint>)(lpVtbl[2]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, uint*, int>)(lpVtbl[3]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, ushort**, int>)(lpVtbl[7]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_timeout([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, int, int>)(lpVtbl[8]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_timeout([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, int*, int>)(lpVtbl[9]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_contentType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, ushort**, int>)(lpVtbl[10]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_onprogress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT, int>)(lpVtbl[11]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_onprogress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT*, int>)(lpVtbl[12]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT, int>)(lpVtbl[13]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT*, int>)(lpVtbl[14]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_ontimeout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT, int>)(lpVtbl[15]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_ontimeout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT*, int>)(lpVtbl[16]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT, int>)(lpVtbl[17]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT*, int>)(lpVtbl[18]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT abort()
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, int>)(lpVtbl[19]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, ushort*, ushort*, int>)(lpVtbl[20]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT send(VARIANT varBody)
        {
            return ((delegate* unmanaged<IHTMLXDomainRequest*, VARIANT, int>)(lpVtbl[21]))((IHTMLXDomainRequest*)Unsafe.AsPointer(ref this), varBody);
        }
    }
}
