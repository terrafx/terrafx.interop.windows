// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3F7F31AC-E15F-11D0-9C25-00C04FC99C8E")]
    [NativeTypeName("struct IXMLElement : IDispatch")]
    public unsafe partial struct IXMLElement
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLElement*, Guid*, void**, int>)(lpVtbl[0]))((IXMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLElement*, uint>)(lpVtbl[1]))((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLElement*, uint>)(lpVtbl[2]))((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLElement*, uint*, int>)(lpVtbl[3]))((IXMLElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLElement*, ushort**, int>)(lpVtbl[7]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLElement*, ushort*, int>)(lpVtbl[8]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parent([NativeTypeName("IXMLElement **")] IXMLElement** ppParent)
        {
            return ((delegate* stdcall<IXMLElement*, IXMLElement**, int>)(lpVtbl[9]))((IXMLElement*)Unsafe.AsPointer(ref this), ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
        {
            return ((delegate* stdcall<IXMLElement*, ushort*, VARIANT, int>)(lpVtbl[10]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, [NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return ((delegate* stdcall<IXMLElement*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
        {
            return ((delegate* stdcall<IXMLElement*, ushort*, int>)(lpVtbl[12]))((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_children([NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp)
        {
            return ((delegate* stdcall<IXMLElement*, IXMLElementCollection**, int>)(lpVtbl[13]))((IXMLElement*)Unsafe.AsPointer(ref this), pp);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return ((delegate* stdcall<IXMLElement*, int*, int>)(lpVtbl[14]))((IXMLElement*)Unsafe.AsPointer(ref this), plType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLElement*, ushort**, int>)(lpVtbl[15]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLElement*, ushort*, int>)(lpVtbl[16]))((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int addChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return ((delegate* stdcall<IXMLElement*, IXMLElement*, int, int, int>)(lpVtbl[17]))((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem)
        {
            return ((delegate* stdcall<IXMLElement*, IXMLElement*, int>)(lpVtbl[18]))((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem);
        }
    }
}
