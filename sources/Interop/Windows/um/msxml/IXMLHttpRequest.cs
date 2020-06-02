// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED8C108D-4349-11D2-91A4-00C04F7969E8")]
    public unsafe partial struct IXMLHttpRequest
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword)
        {
            return lpVtbl->open((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue)
        {
            return lpVtbl->setRequestHeader((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** pbstrValue)
        {
            return lpVtbl->getResponseHeader((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, pbstrValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** pbstrHeaders)
        {
            return lpVtbl->getAllResponseHeaders((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrHeaders);
        }

        [return: NativeTypeName("HRESULT")]
        public int send(VARIANT varBody)
        {
            return lpVtbl->send((IXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return lpVtbl->abort((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("long *")] int* plStatus)
        {
            return lpVtbl->get_status((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_statusText([NativeTypeName("BSTR *")] ushort** pbstrStatus)
        {
            return lpVtbl->get_statusText((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseXML([NativeTypeName("IDispatch **")] IDispatch** ppBody)
        {
            return lpVtbl->get_responseXML((IXMLHttpRequest*)Unsafe.AsPointer(ref this), ppBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseText([NativeTypeName("BSTR *")] ushort** pbstrBody)
        {
            return lpVtbl->get_responseText((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseBody([NativeTypeName("VARIANT *")] VARIANT* pvarBody)
        {
            return lpVtbl->get_responseBody((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseStream([NativeTypeName("VARIANT *")] VARIANT* pvarBody)
        {
            return lpVtbl->get_responseStream((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* plState)
        {
            return lpVtbl->get_readyState((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plState);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange([NativeTypeName("IDispatch *")] IDispatch* pReadyStateSink)
        {
            return lpVtbl->put_onreadystatechange((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pReadyStateSink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int> open;

            [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort*, ushort*, int> setRequestHeader;

            [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort*, ushort**, int> getResponseHeader;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort**, int> getAllResponseHeaders;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, VARIANT, int> send;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, int> abort;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, int*, int> get_status;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort**, int> get_statusText;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, IDispatch**, int> get_responseXML;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, ushort**, int> get_responseText;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, VARIANT*, int> get_responseBody;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, VARIANT*, int> get_responseStream;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLHttpRequest*, IDispatch*, int> put_onreadystatechange;
        }
    }
}
