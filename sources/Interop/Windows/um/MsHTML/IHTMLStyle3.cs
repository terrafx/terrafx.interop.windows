// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F656-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLStyle3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLStyle3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLStyle3*, uint>)(lpVtbl[1]))((IHTMLStyle3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLStyle3*, uint>)(lpVtbl[2]))((IHTMLStyle3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, uint*, int>)(lpVtbl[3]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort*, int>)(lpVtbl[7]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort**, int>)(lpVtbl[8]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_zoom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[9]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_zoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[10]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort*, int>)(lpVtbl[11]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort**, int>)(lpVtbl[12]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort*, int>)(lpVtbl[13]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort**, int>)(lpVtbl[14]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarBaseColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[15]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarBaseColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[16]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarFaceColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[17]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarFaceColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[18]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbar3dLightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[19]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbar3dLightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[20]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[21]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[22]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarHighlightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[23]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarHighlightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[24]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarDarkShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[25]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarDarkShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[26]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarArrowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[27]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarArrowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[28]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarTrackColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[29]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarTrackColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[30]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_writingMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort*, int>)(lpVtbl[31]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_writingMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort**, int>)(lpVtbl[32]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAlignLast([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort*, int>)(lpVtbl[33]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, ushort**, int>)(lpVtbl[34]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_textKashidaSpace(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT, int>)(lpVtbl[35]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashidaSpace(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle3*, VARIANT*, int>)(lpVtbl[36]))((IHTMLStyle3*)Unsafe.AsPointer(ref this), p);
        }
    }
}
