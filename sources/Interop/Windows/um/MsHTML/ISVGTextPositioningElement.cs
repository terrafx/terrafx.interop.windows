// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051051B-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTextPositioningElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTextPositioningElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, uint>)(lpVtbl[1]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, uint>)(lpVtbl[2]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, uint*, int>)(lpVtbl[3]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_x(ISVGAnimatedLengthList* v)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int>)(lpVtbl[7]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_x(ISVGAnimatedLengthList** p)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int>)(lpVtbl[8]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_y(ISVGAnimatedLengthList* v)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int>)(lpVtbl[9]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_y(ISVGAnimatedLengthList** p)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int>)(lpVtbl[10]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int putref_dx(ISVGAnimatedLengthList* v)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int>)(lpVtbl[11]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_dx(ISVGAnimatedLengthList** p)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int>)(lpVtbl[12]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int putref_dy(ISVGAnimatedLengthList* v)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList*, int>)(lpVtbl[13]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_dy(ISVGAnimatedLengthList** p)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedLengthList**, int>)(lpVtbl[14]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int putref_rotate(ISVGAnimatedNumberList* v)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedNumberList*, int>)(lpVtbl[15]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_rotate(ISVGAnimatedNumberList** p)
        {
            return ((delegate* unmanaged<ISVGTextPositioningElement*, ISVGAnimatedNumberList**, int>)(lpVtbl[16]))((ISVGTextPositioningElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
