// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F23C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTableRow : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTableRow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTableRow*, uint>)(lpVtbl[1]))((IHTMLTableRow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTableRow*, uint>)(lpVtbl[2]))((IHTMLTableRow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, uint*, int>)(lpVtbl[3]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, ushort*, int>)(lpVtbl[7]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, ushort**, int>)(lpVtbl[8]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, ushort*, int>)(lpVtbl[9]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, ushort**, int>)(lpVtbl[10]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[11]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[12]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_borderColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[13]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_borderColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[14]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_borderColorLight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[15]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_borderColorLight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[16]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_borderColorDark(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[17]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_borderColorDark(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[18]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_rowIndex([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, int*, int>)(lpVtbl[19]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_sectionRowIndex([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, int*, int>)(lpVtbl[20]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_cells(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, IHTMLElementCollection**, int>)(lpVtbl[21]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT insertCell([NativeTypeName("long")] int index, IDispatch** row)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, int, IDispatch**, int>)(lpVtbl[22]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), index, row);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT deleteCell([NativeTypeName("long")] int index = -1)
        {
            return ((delegate* unmanaged<IHTMLTableRow*, int, int>)(lpVtbl[23]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), index);
        }
    }
}
