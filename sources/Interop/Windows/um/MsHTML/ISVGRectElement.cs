// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510513-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGRectElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGRectElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGRectElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGRectElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGRectElement*, uint>)(lpVtbl[1]))((ISVGRectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGRectElement*, uint>)(lpVtbl[2]))((ISVGRectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGRectElement*, uint*, int>)(lpVtbl[3]))((ISVGRectElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGRectElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGRectElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGRectElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGRectElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGRectElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGRectElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_x(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_x(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_y(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_y(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_width(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_width(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_height(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_height(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT putref_rx(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[15]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_rx(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[16]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT putref_ry(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength*, int>)(lpVtbl[17]))((ISVGRectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_ry(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGRectElement*, ISVGAnimatedLength**, int>)(lpVtbl[18]))((ISVGRectElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
