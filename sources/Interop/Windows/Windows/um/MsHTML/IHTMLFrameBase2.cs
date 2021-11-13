// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F6DB-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLFrameBase2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLFrameBase2 : IHTMLFrameBase2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, uint>)(lpVtbl[1]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, uint>)(lpVtbl[2]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, uint*, int>)(lpVtbl[3]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_contentWindow(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, IHTMLWindow2**, int>)(lpVtbl[7]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, VARIANT, int>)(lpVtbl[8]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, VARIANT*, int>)(lpVtbl[9]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, VARIANT, int>)(lpVtbl[10]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, VARIANT*, int>)(lpVtbl[11]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, ushort**, int>)(lpVtbl[12]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_allowTransparency([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, short, int>)(lpVtbl[13]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_allowTransparency([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLFrameBase2*, short*, int>)(lpVtbl[14]))((IHTMLFrameBase2*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_contentWindow(IHTMLWindow2** p);

            [VtblIndex(8)]
            HRESULT put_onload(VARIANT v);

            [VtblIndex(9)]
            HRESULT get_onload(VARIANT* p);

            [VtblIndex(10)]
            HRESULT put_onreadystatechange(VARIANT v);

            [VtblIndex(11)]
            HRESULT get_onreadystatechange(VARIANT* p);

            [VtblIndex(12)]
            HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(13)]
            HRESULT put_allowTransparency([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(14)]
            HRESULT get_allowTransparency([NativeTypeName("VARIANT_BOOL *")] short* p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, IHTMLWindow2**, int> get_contentWindow;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, VARIANT, int> put_onload;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, VARIANT*, int> get_onload;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, VARIANT, int> put_onreadystatechange;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, VARIANT*, int> get_onreadystatechange;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, ushort**, int> get_readyState;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, short, int> put_allowTransparency;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLFrameBase2*, short*, int> get_allowTransparency;
        }
    }
}
