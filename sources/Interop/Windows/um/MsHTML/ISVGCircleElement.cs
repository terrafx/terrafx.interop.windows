// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510514-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGCircleElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGCircleElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGCircleElement*, uint>)(lpVtbl[1]))((ISVGCircleElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGCircleElement*, uint>)(lpVtbl[2]))((ISVGCircleElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, uint*, int>)(lpVtbl[3]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_cx(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_cx(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_cy(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_cy(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_r(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_r(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGCircleElement*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int> putref_cx;

            [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int> get_cx;

            [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int> putref_cy;

            [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int> get_cy;

            [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength*, int> putref_r;

            [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGCircleElement*, ISVGAnimatedLength**, int> get_r;
        }
    }
}
