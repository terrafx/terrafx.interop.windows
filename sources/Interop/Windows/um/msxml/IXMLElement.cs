// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3F7F31AC-E15F-11D0-9C25-00C04FC99C8E")]
    public unsafe partial struct IXMLElement
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_tagName((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] ushort* p)
        {
            return lpVtbl->put_tagName((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parent([NativeTypeName("IXMLElement **")] IXMLElement** ppParent)
        {
            return lpVtbl->get_parent((IXMLElement*)Unsafe.AsPointer(ref this), ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
        {
            return lpVtbl->setAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, [NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return lpVtbl->getAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
        {
            return lpVtbl->removeAttribute((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_children([NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp)
        {
            return lpVtbl->get_children((IXMLElement*)Unsafe.AsPointer(ref this), pp);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return lpVtbl->get_type((IXMLElement*)Unsafe.AsPointer(ref this), plType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return lpVtbl->get_text((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* p)
        {
            return lpVtbl->put_text((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int addChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return lpVtbl->addChild((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem)
        {
            return lpVtbl->removeChild((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort**, int> get_tagName;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort*, int> put_tagName;

            [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, IXMLElement**, int> get_parent;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort*, VARIANT, int> setAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort*, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort*, int> removeAttribute;

            [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, IXMLElementCollection**, int> get_children;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, int*, int> get_type;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, ushort*, int> put_text;

            [NativeTypeName("HRESULT (IXMLElement *, long, long) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, IXMLElement*, int, int, int> addChild;

            [NativeTypeName("HRESULT (IXMLElement *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLElement*, IXMLElement*, int> removeChild;
        }
    }
}
