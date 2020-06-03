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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDSOControl*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDSOControl*, uint>)(lpVtbl[1]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDSOControl*, uint>)(lpVtbl[2]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDSOControl*, uint*, int>)(lpVtbl[3]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDSOControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDSOControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDSOControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_XMLDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** ppDoc)
        {
            return ((delegate* stdcall<IXMLDSOControl*, IXMLDOMDocument**, int>)(lpVtbl[7]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_XMLDocument([NativeTypeName("IXMLDOMDocument *")] IXMLDOMDocument* ppDoc)
        {
            return ((delegate* stdcall<IXMLDSOControl*, IXMLDOMDocument*, int>)(lpVtbl[8]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_JavaDSOCompatible([NativeTypeName("BOOL *")] int* fJavaDSOCompatible)
        {
            return ((delegate* stdcall<IXMLDSOControl*, int*, int>)(lpVtbl[9]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_JavaDSOCompatible([NativeTypeName("BOOL")] int fJavaDSOCompatible)
        {
            return ((delegate* stdcall<IXMLDSOControl*, int, int>)(lpVtbl[10]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* state)
        {
            return ((delegate* stdcall<IXMLDSOControl*, int*, int>)(lpVtbl[11]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), state);
        }
    }
}
