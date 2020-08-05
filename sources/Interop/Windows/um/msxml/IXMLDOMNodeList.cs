// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF82-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNodeList : IDispatch")]
    public unsafe partial struct IXMLDOMNodeList
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, uint>)(lpVtbl[1]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, uint>)(lpVtbl[2]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, uint*, int>)(lpVtbl[3]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_item([NativeTypeName("long")] int index, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** listItem)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, int, IXMLDOMNode**, int>)(lpVtbl[7]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* listLength)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, int*, int>)(lpVtbl[8]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), listLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int nextNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextItem)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, IXMLDOMNode**, int>)(lpVtbl[9]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), nextItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, int>)(lpVtbl[10]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get__newEnum([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* stdcall<IXMLDOMNodeList*, IUnknown**, int>)(lpVtbl[11]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), ppUnk);
        }
    }
}
