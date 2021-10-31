// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051040A-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLXMLHttpRequest : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLXMLHttpRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint>)(lpVtbl[1]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint>)(lpVtbl[2]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint*, int>)(lpVtbl[3]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_readyState([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int*, int>)(lpVtbl[7]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_responseBody(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT*, int>)(lpVtbl[8]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_responseText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int>)(lpVtbl[9]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_responseXML(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, IDispatch**, int>)(lpVtbl[10]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_status([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int*, int>)(lpVtbl[11]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_statusText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int>)(lpVtbl[12]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT, int>)(lpVtbl[13]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT*, int>)(lpVtbl[14]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT abort()
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, int>)(lpVtbl[15]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT varUser, VARIANT varPassword)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[16]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, varUser, varPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT send(VARIANT varBody)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, VARIANT, int>)(lpVtbl[17]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0000)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort**, int>)(lpVtbl[18]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), __MIDL__IHTMLXMLHttpRequest0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLXMLHttpRequest0001)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort**, int>)(lpVtbl[19]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, __MIDL__IHTMLXMLHttpRequest0001);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue)
        {
            return ((delegate* unmanaged<IHTMLXMLHttpRequest*, ushort*, ushort*, int>)(lpVtbl[20]))((IHTMLXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
        }
    }
}
