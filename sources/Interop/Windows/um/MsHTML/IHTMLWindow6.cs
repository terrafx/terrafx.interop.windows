// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510453-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLWindow6 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLWindow6 : IHTMLWindow6.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLWindow6*, uint>)(lpVtbl[1]))((IHTMLWindow6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLWindow6*, uint>)(lpVtbl[2]))((IHTMLWindow6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, uint*, int>)(lpVtbl[3]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_XDomainRequest(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT, int>)(lpVtbl[7]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_XDomainRequest(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT*, int>)(lpVtbl[8]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_sessionStorage(IHTMLStorage** p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, IHTMLStorage**, int>)(lpVtbl[9]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_localStorage(IHTMLStorage** p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, IHTMLStorage**, int>)(lpVtbl[10]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_onhashchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT, int>)(lpVtbl[11]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_onhashchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT*, int>)(lpVtbl[12]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_maxConnectionsPerServer([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, int*, int>)(lpVtbl[13]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT postMessage([NativeTypeName("BSTR")] ushort* msg, VARIANT targetOrigin)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, ushort*, VARIANT, int>)(lpVtbl[14]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), msg, targetOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT toStaticHTML([NativeTypeName("BSTR")] ushort* bstrHTML, [NativeTypeName("BSTR *")] ushort** pbstrStaticHTML)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, ushort*, ushort**, int>)(lpVtbl[15]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), bstrHTML, pbstrStaticHTML);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_onmessage(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT, int>)(lpVtbl[16]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_onmessage(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, VARIANT*, int>)(lpVtbl[17]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT msWriteProfilerMark([NativeTypeName("BSTR")] ushort* bstrProfilerMarkName)
        {
            return ((delegate* unmanaged<IHTMLWindow6*, ushort*, int>)(lpVtbl[18]))((IHTMLWindow6*)Unsafe.AsPointer(ref this), bstrProfilerMarkName);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_XDomainRequest(VARIANT v);

            [VtblIndex(8)]
            HRESULT get_XDomainRequest(VARIANT* p);

            [VtblIndex(9)]
            HRESULT get_sessionStorage(IHTMLStorage** p);

            [VtblIndex(10)]
            HRESULT get_localStorage(IHTMLStorage** p);

            [VtblIndex(11)]
            HRESULT put_onhashchange(VARIANT v);

            [VtblIndex(12)]
            HRESULT get_onhashchange(VARIANT* p);

            [VtblIndex(13)]
            HRESULT get_maxConnectionsPerServer([NativeTypeName("long *")] int* p);

            [VtblIndex(14)]
            HRESULT postMessage([NativeTypeName("BSTR")] ushort* msg, VARIANT targetOrigin);

            [VtblIndex(15)]
            HRESULT toStaticHTML([NativeTypeName("BSTR")] ushort* bstrHTML, [NativeTypeName("BSTR *")] ushort** pbstrStaticHTML);

            [VtblIndex(16)]
            HRESULT put_onmessage(VARIANT v);

            [VtblIndex(17)]
            HRESULT get_onmessage(VARIANT* p);

            [VtblIndex(18)]
            HRESULT msWriteProfilerMark([NativeTypeName("BSTR")] ushort* bstrProfilerMarkName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT, int> put_XDomainRequest;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT*, int> get_XDomainRequest;

            [NativeTypeName("HRESULT (IHTMLStorage **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, IHTMLStorage**, int> get_sessionStorage;

            [NativeTypeName("HRESULT (IHTMLStorage **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, IHTMLStorage**, int> get_localStorage;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT, int> put_onhashchange;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT*, int> get_onhashchange;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, int*, int> get_maxConnectionsPerServer;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, ushort*, VARIANT, int> postMessage;

            [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, ushort*, ushort**, int> toStaticHTML;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT, int> put_onmessage;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, VARIANT*, int> get_onmessage;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLWindow6*, ushort*, int> msWriteProfilerMark;
        }
    }
}
