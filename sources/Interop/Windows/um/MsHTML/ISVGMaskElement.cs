// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051052E-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGMaskElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGMaskElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGMaskElement*, uint>)(lpVtbl[1]))((ISVGMaskElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGMaskElement*, uint>)(lpVtbl[2]))((ISVGMaskElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, uint*, int>)(lpVtbl[3]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_maskUnits(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[7]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_maskUnits(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[8]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_maskContentUnits(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[9]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_maskContentUnits(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[10]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_x(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_x(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_y(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_y(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT putref_width(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength*, int>)(lpVtbl[15]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_width(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength**, int>)(lpVtbl[16]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT putref_height(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength*, int>)(lpVtbl[17]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_height(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMaskElement*, ISVGAnimatedLength**, int>)(lpVtbl[18]))((ISVGMaskElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
