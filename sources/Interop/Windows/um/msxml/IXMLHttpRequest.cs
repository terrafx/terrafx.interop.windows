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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLHttpRequest* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLHttpRequest* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLHttpRequest* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLHttpRequest* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLHttpRequest* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLHttpRequest* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLHttpRequest* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _open(IXMLHttpRequest* pThis, [NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _setRequestHeader(IXMLHttpRequest* pThis, [NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getResponseHeader(IXMLHttpRequest* pThis, [NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** pbstrValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getAllResponseHeaders(IXMLHttpRequest* pThis, [NativeTypeName("BSTR *")] ushort** pbstrHeaders);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _send(IXMLHttpRequest* pThis, VARIANT varBody);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _abort(IXMLHttpRequest* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_status(IXMLHttpRequest* pThis, [NativeTypeName("long *")] int* plStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_statusText(IXMLHttpRequest* pThis, [NativeTypeName("BSTR *")] ushort** pbstrStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_responseXML(IXMLHttpRequest* pThis, [NativeTypeName("IDispatch **")] IDispatch** ppBody);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_responseText(IXMLHttpRequest* pThis, [NativeTypeName("BSTR *")] ushort** pbstrBody);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_responseBody(IXMLHttpRequest* pThis, [NativeTypeName("VARIANT *")] VARIANT* pvarBody);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_responseStream(IXMLHttpRequest* pThis, [NativeTypeName("VARIANT *")] VARIANT* pvarBody);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_readyState(IXMLHttpRequest* pThis, [NativeTypeName("long *")] int* plState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_onreadystatechange(IXMLHttpRequest* pThis, [NativeTypeName("IDispatch *")] IDispatch* pReadyStateSink);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword)
        {
            return Marshal.GetDelegateForFunctionPointer<_open>(lpVtbl->open)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_setRequestHeader>(lpVtbl->setRequestHeader)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** pbstrValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_getResponseHeader>(lpVtbl->getResponseHeader)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, pbstrValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** pbstrHeaders)
        {
            return Marshal.GetDelegateForFunctionPointer<_getAllResponseHeaders>(lpVtbl->getAllResponseHeaders)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrHeaders);
        }

        [return: NativeTypeName("HRESULT")]
        public int send(VARIANT varBody)
        {
            return Marshal.GetDelegateForFunctionPointer<_send>(lpVtbl->send)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return Marshal.GetDelegateForFunctionPointer<_abort>(lpVtbl->abort)((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("long *")] int* plStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_status>(lpVtbl->get_status)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_statusText([NativeTypeName("BSTR *")] ushort** pbstrStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_statusText>(lpVtbl->get_statusText)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseXML([NativeTypeName("IDispatch **")] IDispatch** ppBody)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_responseXML>(lpVtbl->get_responseXML)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), ppBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseText([NativeTypeName("BSTR *")] ushort** pbstrBody)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_responseText>(lpVtbl->get_responseText)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseBody([NativeTypeName("VARIANT *")] VARIANT* pvarBody)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_responseBody>(lpVtbl->get_responseBody)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_responseStream([NativeTypeName("VARIANT *")] VARIANT* pvarBody)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_responseStream>(lpVtbl->get_responseStream)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* plState)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_readyState>(lpVtbl->get_readyState)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plState);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange([NativeTypeName("IDispatch *")] IDispatch* pReadyStateSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_onreadystatechange>(lpVtbl->put_onreadystatechange)((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pReadyStateSink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
            public IntPtr open;

            [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
            public IntPtr setRequestHeader;

            [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
            public IntPtr getResponseHeader;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr getAllResponseHeaders;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr send;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr abort;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_status;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_statusText;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public IntPtr get_responseXML;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_responseText;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_responseBody;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_responseStream;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_readyState;

            [NativeTypeName("HRESULT (IDispatch *) __attribute__((stdcall))")]
            public IntPtr put_onreadystatechange;
        }
    }
}
