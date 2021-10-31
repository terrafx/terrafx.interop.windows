// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F80C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDocument5 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDocument5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument5*, uint>)(lpVtbl[1]))((IHTMLDocument5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument5*, uint>)(lpVtbl[2]))((IHTMLDocument5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, uint*, int>)(lpVtbl[3]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_onmousewheel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[7]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_onmousewheel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_doctype(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, IHTMLDOMNode**, int>)(lpVtbl[9]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_implementation(IHTMLDOMImplementation** p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, IHTMLDOMImplementation**, int>)(lpVtbl[10]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT createAttribute([NativeTypeName("BSTR")] ushort* bstrattrName, IHTMLDOMAttribute** ppattribute)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[11]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), bstrattrName, ppattribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT createComment([NativeTypeName("BSTR")] ushort* bstrdata, IHTMLDOMNode** ppRetNode)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, ushort*, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), bstrdata, ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_onfocusin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[13]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_onfocusin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_onfocusout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[15]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_onfocusout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[16]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_onactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[17]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_onactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[18]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_ondeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[19]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_ondeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[20]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_onbeforeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[21]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_onbeforeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[22]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_onbeforedeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT, int>)(lpVtbl[23]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_onbeforedeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, VARIANT*, int>)(lpVtbl[24]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_compatMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument5*, ushort**, int>)(lpVtbl[25]))((IHTMLDocument5*)Unsafe.AsPointer(ref this), p);
        }
    }
}
