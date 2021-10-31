// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F21E-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTable : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTable*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTable*, uint>)(lpVtbl[1]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTable*, uint>)(lpVtbl[2]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTable*, uint*, int>)(lpVtbl[3]))((IHTMLTable*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTable*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTable*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTable*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTable*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTable*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTable*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_cols([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTable*, int, int>)(lpVtbl[7]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_cols([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, int*, int>)(lpVtbl[8]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_border(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[9]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_border(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[10]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_frame([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort*, int>)(lpVtbl[11]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_frame([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort**, int>)(lpVtbl[12]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_rules([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort*, int>)(lpVtbl[13]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_rules([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort**, int>)(lpVtbl[14]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_cellSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[15]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_cellSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[16]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_cellPadding(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[17]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_cellPadding(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[18]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort*, int>)(lpVtbl[19]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort**, int>)(lpVtbl[20]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[21]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[22]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_borderColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[23]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_borderColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[24]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_borderColorLight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[25]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_borderColorLight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[26]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_borderColorDark(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[27]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_borderColorDark(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[28]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort*, int>)(lpVtbl[29]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort**, int>)(lpVtbl[30]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT refresh()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[31]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_rows(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLElementCollection**, int>)(lpVtbl[32]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[33]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[34]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[35]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[36]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_dataPageSize([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTable*, int, int>)(lpVtbl[37]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_dataPageSize([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, int*, int>)(lpVtbl[38]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT nextPage()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[39]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT previousPage()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[40]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_tHead(IHTMLTableSection** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLTableSection**, int>)(lpVtbl[41]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_tFoot(IHTMLTableSection** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLTableSection**, int>)(lpVtbl[42]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_tBodies(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLElementCollection**, int>)(lpVtbl[43]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_caption(IHTMLTableCaption** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLTableCaption**, int>)(lpVtbl[44]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT createTHead(IDispatch** head)
        {
            return ((delegate* unmanaged<IHTMLTable*, IDispatch**, int>)(lpVtbl[45]))((IHTMLTable*)Unsafe.AsPointer(ref this), head);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT deleteTHead()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[46]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT createTFoot(IDispatch** foot)
        {
            return ((delegate* unmanaged<IHTMLTable*, IDispatch**, int>)(lpVtbl[47]))((IHTMLTable*)Unsafe.AsPointer(ref this), foot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT deleteTFoot()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[48]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT createCaption(IHTMLTableCaption** caption)
        {
            return ((delegate* unmanaged<IHTMLTable*, IHTMLTableCaption**, int>)(lpVtbl[49]))((IHTMLTable*)Unsafe.AsPointer(ref this), caption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT deleteCaption()
        {
            return ((delegate* unmanaged<IHTMLTable*, int>)(lpVtbl[50]))((IHTMLTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row)
        {
            return ((delegate* unmanaged<IHTMLTable*, int, IDispatch**, int>)(lpVtbl[51]))((IHTMLTable*)Unsafe.AsPointer(ref this), index, row);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT deleteRow([NativeTypeName("long")] int index = -1)
        {
            return ((delegate* unmanaged<IHTMLTable*, int, int>)(lpVtbl[52]))((IHTMLTable*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTable*, ushort**, int>)(lpVtbl[53]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT, int>)(lpVtbl[54]))((IHTMLTable*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTable*, VARIANT*, int>)(lpVtbl[55]))((IHTMLTable*)Unsafe.AsPointer(ref this), p);
        }
    }
}
