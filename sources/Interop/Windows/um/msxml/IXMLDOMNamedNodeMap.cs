// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMNamedNodeMap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, uint>)(lpVtbl[1]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, uint>)(lpVtbl[2]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, uint*, int>)(lpVtbl[3]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int getNamedItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int>)(lpVtbl[7]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int setNamedItem([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newItem, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nameItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[8]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), newItem, nameItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeNamedItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, ushort*, IXMLDOMNode**, int>)(lpVtbl[9]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_item([NativeTypeName("long")] int index, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** listItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, int, IXMLDOMNode**, int>)(lpVtbl[10]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* listLength)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, int*, int>)(lpVtbl[11]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), listLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int getQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[12]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int nextNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextItem)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), nextItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, int>)(lpVtbl[15]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get__newEnum([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* stdcall<IXMLDOMNamedNodeMap*, IUnknown**, int>)(lpVtbl[16]))((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), ppUnk);
        }
    }
}
