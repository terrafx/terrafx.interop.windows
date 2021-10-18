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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint*, int>)(lpVtbl[3]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_x(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_x(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_y(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_y(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int putref_width(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int putref_height(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_contentScriptType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[15]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_contentScriptType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[16]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_contentStyleType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[17]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_contentStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[18]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int putref_viewport(ISVGRect* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, int>)(lpVtbl[19]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_viewport(ISVGRect** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[20]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_pixelUnitToMillimeterX(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[21]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_pixelUnitToMillimeterX(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[22]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_pixelUnitToMillimeterY(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[23]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_pixelUnitToMillimeterY(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[24]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_screenPixelToMillimeterX(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[25]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenPixelToMillimeterX(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[26]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_screenPixelToMillimeterY(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[27]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenPixelToMillimeterY(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[28]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_useCurrentView([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short, int>)(lpVtbl[29]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_useCurrentView([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[30]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int putref_currentView(ISVGViewSpec* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec*, int>)(lpVtbl[31]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentView(ISVGViewSpec** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec**, int>)(lpVtbl[32]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_currentScale(float v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[33]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentScale(float* p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[34]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int putref_currentTranslate(ISVGPoint* v)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint*, int>)(lpVtbl[35]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentTranslate(ISVGPoint** p)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[36]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int suspendRedraw([NativeTypeName("ULONG")] uint maxWaitMilliseconds, [NativeTypeName("ULONG *")] uint* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, uint*, int>)(lpVtbl[37]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), maxWaitMilliseconds, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int unsuspendRedraw([NativeTypeName("ULONG")] uint suspendHandeID)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, uint, int>)(lpVtbl[38]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), suspendHandeID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int unsuspendRedrawAll()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[39]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int forceRedraw()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[40]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int pauseAnimations()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[41]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int unpauseAnimations()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[42]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int animationsPaused([NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[43]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int getCurrentTime(float* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[44]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int setCurrentTime(float seconds)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[45]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), seconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int getIntersectionList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[46]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int getEnclosureList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[47]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int checkIntersection(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[48]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int checkEnclosure(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[49]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int deselectAll()
        {
            return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[50]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGNumber(ISVGNumber** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGNumber**, int>)(lpVtbl[51]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGLength(ISVGLength** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGLength**, int>)(lpVtbl[52]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGAngle(ISVGAngle** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGAngle**, int>)(lpVtbl[53]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGPoint(ISVGPoint** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[54]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGMatrix(ISVGMatrix** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix**, int>)(lpVtbl[55]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGRect(ISVGRect** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[56]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGTransform(ISVGTransform** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGTransform**, int>)(lpVtbl[57]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int createSVGTransformFromMatrix(ISVGMatrix* matrix, ISVGTransform** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix*, ISVGTransform**, int>)(lpVtbl[58]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), matrix, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int getElementById([NativeTypeName("BSTR")] ushort* elementId, IHTMLElement** pResult)
        {
            return ((delegate* unmanaged<ISVGSVGElement*, ushort*, IHTMLElement**, int>)(lpVtbl[59]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), elementId, pResult);
        }
    }
}
