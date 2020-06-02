// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2B8DE2FE-8D2D-11D1-B2FC-00C04FD915A9")]
    public unsafe partial struct IXMLDocument2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_root([NativeTypeName("IXMLElement2 **")] IXMLElement2** p)
        {
            return lpVtbl->get_root((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_fileSize((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_fileModifiedDate((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_fileUpdatedDate((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_URL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return lpVtbl->put_URL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_mimeType((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return lpVtbl->get_readyState((IXMLDocument2*)Unsafe.AsPointer(ref this), pl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_charset((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return lpVtbl->put_charset((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_version((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_doctype((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_dtdURL((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, [NativeTypeName("IXMLElement2 **")] IXMLElement2** ppElem)
        {
            return lpVtbl->createElement((IXMLDocument2*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* pf)
        {
            return lpVtbl->get_async((IXMLDocument2*)Unsafe.AsPointer(ref this), pf);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short f)
        {
            return lpVtbl->put_async((IXMLDocument2*)Unsafe.AsPointer(ref this), f);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, IXMLElement2**, int> get_root;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_fileSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_fileModifiedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_fileUpdatedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_URL;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort*, int> put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_mimeType;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_charset;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort*, int> put_charset;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_version;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_doctype;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, ushort**, int> get_dtdURL;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, VARIANT, VARIANT, IXMLElement2**, int> createElement;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, short*, int> get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDocument2*, short, int> put_async;
        }
    }
}
