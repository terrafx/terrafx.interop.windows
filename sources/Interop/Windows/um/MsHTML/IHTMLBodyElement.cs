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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint*, int>)(lpVtbl[3]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[7]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[8]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_bgProperties([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[9]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_bgProperties([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[10]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_leftMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[11]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_leftMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[12]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_topMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[13]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_topMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[14]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_rightMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[15]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_rightMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[16]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_bottomMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_bottomMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_noWrap([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, short, int>)(lpVtbl[19]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, short*, int>)(lpVtbl[20]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_text(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_text(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_link(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_link(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_vLink(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_vLink(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_aLink(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_aLink(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_onunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[33]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_onunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[34]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_scroll([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[35]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_scroll([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[36]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[39]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[40]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int createTextRange(IHTMLTxtRange** range)
        {
            return ((delegate* unmanaged<IHTMLBodyElement*, IHTMLTxtRange**, int>)(lpVtbl[41]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), range);
        }
    }
}
