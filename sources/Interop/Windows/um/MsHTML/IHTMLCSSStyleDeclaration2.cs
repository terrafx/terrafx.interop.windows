// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107D1-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCSSStyleDeclaration2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCSSStyleDeclaration2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_msScrollChaining([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_msScrollChaining([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_msContentZooming([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_msContentZooming([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_msContentZoomSnapType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_msContentZoomSnapType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_msScrollRails([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_msScrollRails([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_msContentZoomChaining([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_msContentZoomChaining([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_msScrollSnapType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_msScrollSnapType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_msContentZoomLimit([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_msContentZoomLimit([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_msContentZoomSnap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_msContentZoomSnap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_msContentZoomSnapPoints([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_msContentZoomSnapPoints([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_msContentZoomLimitMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_msContentZoomLimitMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_msContentZoomLimitMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_msContentZoomLimitMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_msScrollSnapX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_msScrollSnapX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_msScrollSnapY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_msScrollSnapY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_msScrollSnapPointsX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_msScrollSnapPointsX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_msScrollSnapPointsY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_msScrollSnapPointsY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_msGridColumn(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_msGridColumn(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT put_msGridColumnAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_msGridColumnAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_msGridColumns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_msGridColumns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_msGridColumnSpan(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_msGridColumnSpan(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_msGridRow(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_msGridRow(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_msGridRowAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_msGridRowAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_msGridRows([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_msGridRows([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_msGridRowSpan(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_msGridRowSpan(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT put_msWrapThrough([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_msWrapThrough([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT put_msWrapMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_msWrapMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT put_msWrapFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_msWrapFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT put_msAnimationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_msAnimationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT put_msAnimationDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_msAnimationDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT put_msAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT get_msAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT put_msAnimationDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT get_msAnimationDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT put_msAnimationDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT get_msAnimationDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT put_msAnimationPlayState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT get_msAnimationPlayState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT put_msAnimationIterationCount([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT get_msAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT put_msAnimation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT get_msAnimation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT put_msAnimationFillMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT get_msAnimationFillMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT put_colorInterpolationFilters([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT get_colorInterpolationFilters([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT put_columnCount(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT get_columnCount(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT put_columnWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT get_columnWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT put_columnGap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT get_columnGap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT put_columnFill([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT get_columnFill([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT put_columnSpan([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT get_columnSpan([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT put_columns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT get_columns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT put_columnRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT get_columnRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT put_columnRuleColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT get_columnRuleColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT put_columnRuleStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT get_columnRuleStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HRESULT put_columnRuleWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[97]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public HRESULT get_columnRuleWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[98]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public HRESULT put_breakBefore([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[99]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public HRESULT get_breakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[100]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public HRESULT put_breakAfter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[101]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public HRESULT get_breakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[102]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public HRESULT put_breakInside([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[103]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public HRESULT get_breakInside([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[104]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public HRESULT put_floodColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[105]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public HRESULT get_floodColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[106]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public HRESULT put_floodOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[107]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public HRESULT get_floodOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[108]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public HRESULT put_lightingColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[109]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public HRESULT get_lightingColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[110]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public HRESULT put_msScrollLimitXMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[111]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public HRESULT get_msScrollLimitXMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[112]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public HRESULT put_msScrollLimitYMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[113]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HRESULT get_msScrollLimitYMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[114]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public HRESULT put_msScrollLimitXMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[115]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        public HRESULT get_msScrollLimitXMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[116]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        public HRESULT put_msScrollLimitYMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[117]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        public HRESULT get_msScrollLimitYMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[118]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        public HRESULT put_msScrollLimit([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[119]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        public HRESULT get_msScrollLimit([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[120]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        public HRESULT put_textShadow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[121]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        public HRESULT get_textShadow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[122]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        public HRESULT put_msFlowFrom([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[123]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        public HRESULT get_msFlowFrom([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[124]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        public HRESULT put_msFlowInto([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[125]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        public HRESULT get_msFlowInto([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[126]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        public HRESULT put_msHyphens([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[127]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        public HRESULT get_msHyphens([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[128]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        public HRESULT put_msHyphenateLimitZone(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[129]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        public HRESULT get_msHyphenateLimitZone(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[130]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        public HRESULT put_msHyphenateLimitChars([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[131]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        public HRESULT get_msHyphenateLimitChars([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[132]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        public HRESULT put_msHyphenateLimitLines(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[133]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        public HRESULT get_msHyphenateLimitLines(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[134]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        public HRESULT put_msHighContrastAdjust([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[135]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        public HRESULT get_msHighContrastAdjust([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[136]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        public HRESULT put_enableBackground([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[137]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        public HRESULT get_enableBackground([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[138]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        public HRESULT put_msFontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[139]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        public HRESULT get_msFontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[140]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        public HRESULT put_msUserSelect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[141]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        public HRESULT get_msUserSelect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[142]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        public HRESULT put_msOverflowStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[143]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        public HRESULT get_msOverflowStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[144]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        public HRESULT put_msTransformStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[145]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        public HRESULT get_msTransformStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[146]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        public HRESULT put_msBackfaceVisibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[147]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        public HRESULT get_msBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[148]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        public HRESULT put_msPerspective(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[149]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        public HRESULT get_msPerspective(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[150]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        public HRESULT put_msPerspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[151]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        public HRESULT get_msPerspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[152]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        public HRESULT put_msTransitionProperty([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[153]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        public HRESULT get_msTransitionProperty([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[154]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        public HRESULT put_msTransitionDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[155]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        public HRESULT get_msTransitionDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[156]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        public HRESULT put_msTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[157]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        public HRESULT get_msTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[158]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        public HRESULT put_msTransitionDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[159]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        public HRESULT get_msTransitionDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[160]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        public HRESULT put_msTransition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[161]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        public HRESULT get_msTransition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[162]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        public HRESULT put_msTouchAction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[163]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        public HRESULT get_msTouchAction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[164]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        public HRESULT put_msScrollTranslation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[165]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        public HRESULT get_msScrollTranslation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[166]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        public HRESULT put_msFlex([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[167]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        public HRESULT get_msFlex([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[168]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        public HRESULT put_msFlexPositive(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[169]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        public HRESULT get_msFlexPositive(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[170]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        public HRESULT put_msFlexNegative(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[171]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        public HRESULT get_msFlexNegative(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[172]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        public HRESULT put_msFlexPreferredSize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[173]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        public HRESULT get_msFlexPreferredSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[174]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        public HRESULT put_msFlexFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[175]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        public HRESULT get_msFlexFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[176]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        public HRESULT put_msFlexDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[177]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        public HRESULT get_msFlexDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[178]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        public HRESULT put_msFlexWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[179]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        public HRESULT get_msFlexWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[180]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        public HRESULT put_msFlexAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[181]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        public HRESULT get_msFlexAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[182]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        public HRESULT put_msFlexItemAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[183]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        public HRESULT get_msFlexItemAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[184]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        public HRESULT put_msFlexPack([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[185]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        public HRESULT get_msFlexPack([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[186]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        public HRESULT put_msFlexLinePack([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[187]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        public HRESULT get_msFlexLinePack([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[188]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        public HRESULT put_msFlexOrder(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[189]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        public HRESULT get_msFlexOrder(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[190]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        public HRESULT put_msTouchSelect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[191]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        public HRESULT get_msTouchSelect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[192]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        public HRESULT put_transform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[193]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        public HRESULT get_transform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[194]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        public HRESULT put_transformOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[195]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        public HRESULT get_transformOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[196]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        public HRESULT put_transformStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[197]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        public HRESULT get_transformStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[198]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        public HRESULT put_backfaceVisibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[199]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        public HRESULT get_backfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[200]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        public HRESULT put_perspective(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[201]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        public HRESULT get_perspective(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[202]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        public HRESULT put_perspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[203]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        public HRESULT get_perspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[204]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        public HRESULT put_transitionProperty([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[205]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        public HRESULT get_transitionProperty([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[206]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        public HRESULT put_transitionDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[207]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        public HRESULT get_transitionDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[208]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        public HRESULT put_transitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[209]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        public HRESULT get_transitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[210]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        public HRESULT put_transitionDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[211]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        public HRESULT get_transitionDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[212]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        public HRESULT put_transition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[213]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        public HRESULT get_transition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[214]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        public HRESULT put_fontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[215]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        public HRESULT get_fontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[216]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        public HRESULT put_animationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[217]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        public HRESULT get_animationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[218]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        public HRESULT put_animationDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[219]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        public HRESULT get_animationDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[220]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        public HRESULT put_animationTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[221]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        public HRESULT get_animationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[222]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        public HRESULT put_animationDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[223]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        public HRESULT get_animationDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[224]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        public HRESULT put_animationDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[225]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        public HRESULT get_animationDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[226]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        public HRESULT put_animationPlayState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[227]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        public HRESULT get_animationPlayState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[228]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        public HRESULT put_animationIterationCount([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[229]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        public HRESULT get_animationIterationCount([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[230]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        public HRESULT put_animation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[231]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        public HRESULT get_animation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[232]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        public HRESULT put_animationFillMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[233]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        public HRESULT get_animationFillMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[234]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
