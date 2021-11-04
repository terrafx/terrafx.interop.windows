// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F657-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLRuleStyle3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLRuleStyle3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, uint>)(lpVtbl[1]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, uint>)(lpVtbl[2]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, uint*, int>)(lpVtbl[3]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_layoutFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int>)(lpVtbl[7]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int>)(lpVtbl[8]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_zoom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[9]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_zoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[10]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_wordWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int>)(lpVtbl[11]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int>)(lpVtbl[12]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int>)(lpVtbl[13]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int>)(lpVtbl[14]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_scrollbarBaseColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[15]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_scrollbarBaseColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[16]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_scrollbarFaceColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[17]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_scrollbarFaceColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[18]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_scrollbar3dLightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[19]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_scrollbar3dLightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[20]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_scrollbarShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[21]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_scrollbarShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[22]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_scrollbarHighlightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[23]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_scrollbarHighlightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[24]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_scrollbarDarkShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[25]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_scrollbarDarkShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[26]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_scrollbarArrowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[27]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_scrollbarArrowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[28]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_scrollbarTrackColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[29]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_scrollbarTrackColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[30]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_writingMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int>)(lpVtbl[31]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int>)(lpVtbl[32]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_textAlignLast([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int>)(lpVtbl[33]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int>)(lpVtbl[34]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_textKashidaSpace(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int>)(lpVtbl[35]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_textKashidaSpace(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int>)(lpVtbl[36]))((IHTMLRuleStyle3*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int> put_layoutFlow;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int> get_layoutFlow;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_zoom;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_zoom;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int> put_wordWrap;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int> get_wordWrap;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int> put_textUnderlinePosition;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int> get_textUnderlinePosition;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarBaseColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarBaseColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarFaceColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarFaceColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbar3dLightColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbar3dLightColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarShadowColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarShadowColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarHighlightColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarHighlightColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarDarkShadowColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarDarkShadowColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarArrowColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarArrowColor;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_scrollbarTrackColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_scrollbarTrackColor;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int> put_writingMode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int> get_writingMode;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort*, int> put_textAlignLast;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, ushort**, int> get_textAlignLast;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT, int> put_textKashidaSpace;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle3*, VARIANT*, int> get_textKashidaSpace;
        }
    }
}
