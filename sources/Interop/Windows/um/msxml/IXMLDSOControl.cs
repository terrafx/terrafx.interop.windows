// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("310AFA62-0575-11D2-9CA9-0060B0EC3D39")]
    public unsafe partial struct IXMLDSOControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDSOControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDSOControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDSOControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_XMLDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** ppDoc)
        {
            return lpVtbl->get_XMLDocument((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_XMLDocument([NativeTypeName("IXMLDOMDocument *")] IXMLDOMDocument* ppDoc)
        {
            return lpVtbl->put_XMLDocument((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_JavaDSOCompatible([NativeTypeName("BOOL *")] int* fJavaDSOCompatible)
        {
            return lpVtbl->get_JavaDSOCompatible((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_JavaDSOCompatible([NativeTypeName("BOOL")] int fJavaDSOCompatible)
        {
            return lpVtbl->put_JavaDSOCompatible((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* state)
        {
            return lpVtbl->get_readyState((IXMLDSOControl*)Unsafe.AsPointer(ref this), state);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, IXMLDOMDocument**, int> get_XMLDocument;

            [NativeTypeName("HRESULT (IXMLDOMDocument *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, IXMLDOMDocument*, int> put_XMLDocument;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, int*, int> get_JavaDSOCompatible;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, int, int> put_JavaDSOCompatible;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDSOControl*, int*, int> get_readyState;
        }
    }
}
