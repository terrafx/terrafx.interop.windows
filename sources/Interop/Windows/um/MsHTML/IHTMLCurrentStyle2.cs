// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F658-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCurrentStyle2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCurrentStyle2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint>)(lpVtbl[1]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint>)(lpVtbl[2]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint*, int>)(lpVtbl[3]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[7]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[8]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[9]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasLayout([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, short*, int>)(lpVtbl[10]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarBaseColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[11]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarFaceColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[12]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbar3dLightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[13]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarHighlightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[15]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarDarkShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[16]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarArrowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[17]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarTrackColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_writingMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[19]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_zoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[20]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_filter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[21]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, ushort**, int>)(lpVtbl[22]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashidaSpace(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, VARIANT*, int>)(lpVtbl[23]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_isBlock([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle2*, short*, int>)(lpVtbl[24]))((IHTMLCurrentStyle2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
