// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510516-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGLineElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGLineElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGLineElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGLineElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGLineElement*, uint>)(lpVtbl[1]))((ISVGLineElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGLineElement*, uint>)(lpVtbl[2]))((ISVGLineElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGLineElement*, uint*, int>)(lpVtbl[3]))((ISVGLineElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGLineElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGLineElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGLineElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGLineElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGLineElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGLineElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_x1(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGLineElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_x1(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGLineElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_y1(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGLineElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_y1(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGLineElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_x2(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGLineElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_x2(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGLineElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_y2(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGLineElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_y2(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLineElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGLineElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
