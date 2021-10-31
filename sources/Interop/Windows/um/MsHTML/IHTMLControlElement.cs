// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4E9-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLControlElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLControlElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLControlElement*, uint>)(lpVtbl[1]))((IHTMLControlElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLControlElement*, uint>)(lpVtbl[2]))((IHTMLControlElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, uint*, int>)(lpVtbl[3]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_tabIndex(short v)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, short, int>)(lpVtbl[7]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_tabIndex(short* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, short*, int>)(lpVtbl[8]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT focus()
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int>)(lpVtbl[9]))((IHTMLControlElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_accessKey([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, ushort*, int>)(lpVtbl[10]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_accessKey([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, ushort**, int>)(lpVtbl[11]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT, int>)(lpVtbl[12]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT*, int>)(lpVtbl[13]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT, int>)(lpVtbl[14]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT*, int>)(lpVtbl[15]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_onresize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT, int>)(lpVtbl[16]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_onresize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, VARIANT*, int>)(lpVtbl[17]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT blur()
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int>)(lpVtbl[18]))((IHTMLControlElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT addFilter(IUnknown* pUnk)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, IUnknown*, int>)(lpVtbl[19]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), pUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT removeFilter(IUnknown* pUnk)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, IUnknown*, int>)(lpVtbl[20]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), pUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_clientHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int*, int>)(lpVtbl[21]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_clientWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int*, int>)(lpVtbl[22]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_clientTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int*, int>)(lpVtbl[23]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_clientLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLControlElement*, int*, int>)(lpVtbl[24]))((IHTMLControlElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
