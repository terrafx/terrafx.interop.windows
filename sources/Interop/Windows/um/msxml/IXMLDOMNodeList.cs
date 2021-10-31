// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF82-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNodeList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDOMNodeList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, uint>)(lpVtbl[1]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, uint>)(lpVtbl[2]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, uint*, int>)(lpVtbl[3]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode** listItem)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, int, IXMLDOMNode**, int>)(lpVtbl[7]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_length([NativeTypeName("long *")] int* listLength)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, int*, int>)(lpVtbl[8]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), listLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT nextNode(IXMLDOMNode** nextItem)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, IXMLDOMNode**, int>)(lpVtbl[9]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), nextItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT reset()
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, int>)(lpVtbl[10]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get__newEnum(IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IXMLDOMNodeList*, IUnknown**, int>)(lpVtbl[11]))((IXMLDOMNodeList*)Unsafe.AsPointer(ref this), ppUnk);
        }
    }
}
