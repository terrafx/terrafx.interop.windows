// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2B8DE2FF-8D2D-11D1-B2FC-00C04FD915A9")]
    [NativeTypeName("struct IXMLElement2 : IDispatch")]
    public unsafe partial struct IXMLElement2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLElement2*, Guid*, void**, int>)(lpVtbl[0]))((IXMLElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLElement2*, uint>)(lpVtbl[1]))((IXMLElement2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLElement2*, uint>)(lpVtbl[2]))((IXMLElement2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLElement2*, uint*, int>)(lpVtbl[3]))((IXMLElement2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLElement2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLElement2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort**, int>)(lpVtbl[7]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort*, int>)(lpVtbl[8]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parent([NativeTypeName("IXMLElement2 **")] IXMLElement2** ppParent)
        {
            return ((delegate* stdcall<IXMLElement2*, IXMLElement2**, int>)(lpVtbl[9]))((IXMLElement2*)Unsafe.AsPointer(ref this), ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort*, VARIANT, int>)(lpVtbl[10]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, [NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort*, int>)(lpVtbl[12]))((IXMLElement2*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_children([NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp)
        {
            return ((delegate* stdcall<IXMLElement2*, IXMLElementCollection**, int>)(lpVtbl[13]))((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return ((delegate* stdcall<IXMLElement2*, int*, int>)(lpVtbl[14]))((IXMLElement2*)Unsafe.AsPointer(ref this), plType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort**, int>)(lpVtbl[15]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLElement2*, ushort*, int>)(lpVtbl[16]))((IXMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int addChild([NativeTypeName("IXMLElement2 *")] IXMLElement2* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return ((delegate* stdcall<IXMLElement2*, IXMLElement2*, int, int, int>)(lpVtbl[17]))((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLElement2 *")] IXMLElement2* pChildElem)
        {
            return ((delegate* stdcall<IXMLElement2*, IXMLElement2*, int>)(lpVtbl[18]))((IXMLElement2*)Unsafe.AsPointer(ref this), pChildElem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp)
        {
            return ((delegate* stdcall<IXMLElement2*, IXMLElementCollection**, int>)(lpVtbl[19]))((IXMLElement2*)Unsafe.AsPointer(ref this), pp);
        }
    }
}
