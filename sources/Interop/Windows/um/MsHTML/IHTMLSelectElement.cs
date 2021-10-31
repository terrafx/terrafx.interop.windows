// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F244-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLSelectElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLSelectElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, uint>)(lpVtbl[1]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, uint>)(lpVtbl[2]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, uint*, int>)(lpVtbl[3]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_size([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int, int>)(lpVtbl[7]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_size([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int*, int>)(lpVtbl[8]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_multiple([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, short, int>)(lpVtbl[9]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_multiple([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, short*, int>)(lpVtbl[10]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, ushort*, int>)(lpVtbl[11]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int>)(lpVtbl[12]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_options(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, IDispatch**, int>)(lpVtbl[13]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, int>)(lpVtbl[14]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT*, int>)(lpVtbl[15]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_selectedIndex([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int, int>)(lpVtbl[16]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_selectedIndex([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int*, int>)(lpVtbl[17]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int>)(lpVtbl[18]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, ushort*, int>)(lpVtbl[19]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, ushort**, int>)(lpVtbl[20]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, short, int>)(lpVtbl[21]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, short*, int>)(lpVtbl[22]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_form(IHTMLFormElement** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, IHTMLFormElement**, int>)(lpVtbl[23]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT add(IHTMLElement* element, VARIANT before)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, IHTMLElement*, VARIANT, int>)(lpVtbl[24]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), element, before);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT remove([NativeTypeName("long")] int index = -1)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int, int>)(lpVtbl[25]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_length([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int, int>)(lpVtbl[26]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, int*, int>)(lpVtbl[27]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get__newEnum(IUnknown** p)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, IUnknown**, int>)(lpVtbl[28]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT item(VARIANT name, VARIANT index, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[29]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), name, index, pdisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT tags(VARIANT tagName, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLSelectElement*, VARIANT, IDispatch**, int>)(lpVtbl[30]))((IHTMLSelectElement*)Unsafe.AsPointer(ref this), tagName, pdisp);
        }
    }
}
