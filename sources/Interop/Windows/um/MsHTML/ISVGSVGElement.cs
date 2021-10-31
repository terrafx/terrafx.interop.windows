// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104E7-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGSVGElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGSVGElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint>)(lpVtbl[1]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint>)(lpVtbl[2]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint*, int>)(lpVtbl[3]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_x(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_x(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_y(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_y(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_width(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_width(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_height(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_height(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_contentScriptType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[15]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_contentScriptType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[16]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_contentStyleType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[17]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_contentStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[18]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT putref_viewport(ISVGRect* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, int>)(lpVtbl[19]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_viewport(ISVGRect** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[20]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_pixelUnitToMillimeterX(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[21]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_pixelUnitToMillimeterX(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[22]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_pixelUnitToMillimeterY(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[23]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_pixelUnitToMillimeterY(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[24]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_screenPixelToMillimeterX(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[25]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_screenPixelToMillimeterX(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[26]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_screenPixelToMillimeterY(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[27]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_screenPixelToMillimeterY(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[28]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_useCurrentView([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short, int>)(lpVtbl[29]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_useCurrentView([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[30]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT putref_currentView(ISVGViewSpec* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec*, int>)(lpVtbl[31]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_currentView(ISVGViewSpec** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec**, int>)(lpVtbl[32]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_currentScale(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[33]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_currentScale(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[34]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT putref_currentTranslate(ISVGPoint* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint*, int>)(lpVtbl[35]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_currentTranslate(ISVGPoint** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[36]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT suspendRedraw([NativeTypeName("ULONG")] uint maxWaitMilliseconds, [NativeTypeName("ULONG *")] uint* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, uint*, int>)(lpVtbl[37]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), maxWaitMilliseconds, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT unsuspendRedraw([NativeTypeName("ULONG")] uint suspendHandeID)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, int>)(lpVtbl[38]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), suspendHandeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT unsuspendRedrawAll()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[39]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT forceRedraw()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[40]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT pauseAnimations()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[41]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT unpauseAnimations()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[42]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT animationsPaused([NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[43]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT getCurrentTime(float* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[44]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT setCurrentTime(float seconds)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[45]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), seconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT getIntersectionList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[46]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT getEnclosureList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[47]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT checkIntersection(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[48]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT checkEnclosure(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[49]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT deselectAll()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[50]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT createSVGNumber(ISVGNumber** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGNumber**, int>)(lpVtbl[51]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT createSVGLength(ISVGLength** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGLength**, int>)(lpVtbl[52]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT createSVGAngle(ISVGAngle** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAngle**, int>)(lpVtbl[53]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT createSVGPoint(ISVGPoint** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[54]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT createSVGMatrix(ISVGMatrix** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix**, int>)(lpVtbl[55]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT createSVGRect(ISVGRect** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[56]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT createSVGTransform(ISVGTransform** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGTransform**, int>)(lpVtbl[57]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT createSVGTransformFromMatrix(ISVGMatrix* matrix, ISVGTransform** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix*, ISVGTransform**, int>)(lpVtbl[58]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), matrix, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT getElementById([NativeTypeName("BSTR")] ushort* elementId, IHTMLElement** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, IHTMLElement**, int>)(lpVtbl[59]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), elementId, pResult);
        }
    }
}
