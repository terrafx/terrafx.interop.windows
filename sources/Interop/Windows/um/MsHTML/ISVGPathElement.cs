// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510512-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGPathElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGPathElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGPathElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPathElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGPathElement*, uint>)(lpVtbl[1]))((ISVGPathElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGPathElement*, uint>)(lpVtbl[2]))((ISVGPathElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGPathElement*, uint*, int>)(lpVtbl[3]))((ISVGPathElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGPathElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPathElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGPathElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPathElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGPathElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPathElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_pathLength(ISVGAnimatedNumber* v)
        {
            return ((delegate* unmanaged<ISVGPathElement*, ISVGAnimatedNumber*, int>)(lpVtbl[7]))((ISVGPathElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_pathLength(ISVGAnimatedNumber** p)
        {
            return ((delegate* unmanaged<ISVGPathElement*, ISVGAnimatedNumber**, int>)(lpVtbl[8]))((ISVGPathElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int getTotalLength(float* pfltResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float*, int>)(lpVtbl[9]))((ISVGPathElement*)Unsafe.AsPointer(ref this), pfltResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getPointAtLength(float fltdistance, ISVGPoint** ppPointResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, ISVGPoint**, int>)(lpVtbl[10]))((ISVGPathElement*)Unsafe.AsPointer(ref this), fltdistance, ppPointResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int getPathSegAtLength(float fltdistance, [NativeTypeName("long *")] int* plResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, int*, int>)(lpVtbl[11]))((ISVGPathElement*)Unsafe.AsPointer(ref this), fltdistance, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegClosePath(ISVGPathSegClosePath** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, ISVGPathSegClosePath**, int>)(lpVtbl[12]))((ISVGPathElement*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegMovetoAbs(float x, float y, ISVGPathSegMovetoAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegMovetoAbs**, int>)(lpVtbl[13]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegMovetoRel(float x, float y, ISVGPathSegMovetoRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegMovetoRel**, int>)(lpVtbl[14]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoAbs(float x, float y, ISVGPathSegLinetoAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegLinetoAbs**, int>)(lpVtbl[15]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoRel(float x, float y, ISVGPathSegLinetoRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegLinetoRel**, int>)(lpVtbl[16]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2, ISVGPathSegCurvetoCubicAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, float, float, ISVGPathSegCurvetoCubicAbs**, int>)(lpVtbl[17]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x1, y1, x2, y2, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2, ISVGPathSegCurvetoCubicRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, float, float, ISVGPathSegCurvetoCubicRel**, int>)(lpVtbl[18]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x1, y1, x2, y2, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1, ISVGPathSegCurvetoQuadraticAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, ISVGPathSegCurvetoQuadraticAbs**, int>)(lpVtbl[19]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x1, y1, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1, ISVGPathSegCurvetoQuadraticRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, ISVGPathSegCurvetoQuadraticRel**, int>)(lpVtbl[20]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x1, y1, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, [NativeTypeName("VARIANT_BOOL")] short largeArcFlag, [NativeTypeName("VARIANT_BOOL")] short sweepFlag, ISVGPathSegArcAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, float, short, short, ISVGPathSegArcAbs**, int>)(lpVtbl[21]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, r1, r2, angle, largeArcFlag, sweepFlag, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, [NativeTypeName("VARIANT_BOOL")] short largeArcFlag, [NativeTypeName("VARIANT_BOOL")] short sweepFlag, ISVGPathSegArcRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, float, short, short, ISVGPathSegArcRel**, int>)(lpVtbl[22]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, r1, r2, angle, largeArcFlag, sweepFlag, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoHorizontalAbs(float x, ISVGPathSegLinetoHorizontalAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, ISVGPathSegLinetoHorizontalAbs**, int>)(lpVtbl[23]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoHorizontalRel(float x, ISVGPathSegLinetoHorizontalRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, ISVGPathSegLinetoHorizontalRel**, int>)(lpVtbl[24]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoVerticalAbs(float y, ISVGPathSegLinetoVerticalAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, ISVGPathSegLinetoVerticalAbs**, int>)(lpVtbl[25]))((ISVGPathElement*)Unsafe.AsPointer(ref this), y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegLinetoVerticalRel(float y, ISVGPathSegLinetoVerticalRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, ISVGPathSegLinetoVerticalRel**, int>)(lpVtbl[26]))((ISVGPathElement*)Unsafe.AsPointer(ref this), y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2, ISVGPathSegCurvetoCubicSmoothAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, ISVGPathSegCurvetoCubicSmoothAbs**, int>)(lpVtbl[27]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x2, y2, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2, ISVGPathSegCurvetoCubicSmoothRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, float, float, ISVGPathSegCurvetoCubicSmoothRel**, int>)(lpVtbl[28]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, x2, y2, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y, ISVGPathSegCurvetoQuadraticSmoothAbs** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegCurvetoQuadraticSmoothAbs**, int>)(lpVtbl[29]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPathSegCurvetoQuadraticSmoothRel(float x, float y, ISVGPathSegCurvetoQuadraticSmoothRel** ppResult)
        {
            return ((delegate* unmanaged<ISVGPathElement*, float, float, ISVGPathSegCurvetoQuadraticSmoothRel**, int>)(lpVtbl[30]))((ISVGPathElement*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }
    }
}
