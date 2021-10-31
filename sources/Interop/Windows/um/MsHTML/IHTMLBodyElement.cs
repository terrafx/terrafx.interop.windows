// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F1D8-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLBodyElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLBodyElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint>)(lpVtbl[1]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint>)(lpVtbl[2]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint*, int>)(lpVtbl[3]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[7]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[8]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_bgProperties([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[9]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_bgProperties([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[10]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_leftMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[11]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_leftMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[12]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_topMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[13]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_topMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[14]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_rightMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[15]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_rightMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[16]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_bottomMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_bottomMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_noWrap([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, short, int>)(lpVtbl[19]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, short*, int>)(lpVtbl[20]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_text(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_text(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_link(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_link(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_vLink(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_vLink(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_aLink(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_aLink(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_onunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[33]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_onunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[34]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_scroll([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[35]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_scroll([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[36]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT put_onbeforeunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[39]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_onbeforeunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[40]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT createTextRange(IHTMLTxtRange** range)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, IHTMLTxtRange**, int>)(lpVtbl[41]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), range);
        }
    }
}
