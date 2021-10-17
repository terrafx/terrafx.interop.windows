// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F23D-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTableCell : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTableCell
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTableCell*, uint>)(lpVtbl[1]))((IHTMLTableCell*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTableCell*, uint>)(lpVtbl[2]))((IHTMLTableCell*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, uint*, int>)(lpVtbl[3]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_rowSpan([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int, int>)(lpVtbl[7]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_rowSpan([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int*, int>)(lpVtbl[8]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_colSpan([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int, int>)(lpVtbl[9]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_colSpan([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int*, int>)(lpVtbl[10]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort*, int>)(lpVtbl[11]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort**, int>)(lpVtbl[12]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_vAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort*, int>)(lpVtbl[13]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_vAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort**, int>)(lpVtbl[14]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[15]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[16]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_noWrap([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, short, int>)(lpVtbl[17]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, short*, int>)(lpVtbl[18]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort*, int>)(lpVtbl[19]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, ushort**, int>)(lpVtbl[20]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[21]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[22]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColorLight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[23]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColorLight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[24]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColorDark(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[25]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColorDark(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[26]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[27]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[28]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT, int>)(lpVtbl[29]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, VARIANT*, int>)(lpVtbl[30]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_cellIndex([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTableCell*, int*, int>)(lpVtbl[31]))((IHTMLTableCell*)Unsafe.AsPointer(ref this), p);
        }
    }
}
