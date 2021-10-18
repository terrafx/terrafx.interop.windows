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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollChaining([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollChaining([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZooming([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZooming([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomSnapType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomSnapType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollRails([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollRails([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomChaining([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomChaining([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollSnapType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollSnapType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomLimit([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomLimit([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomSnap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomSnap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomSnapPoints([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomSnapPoints([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomLimitMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomLimitMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_msContentZoomLimitMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_msContentZoomLimitMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollSnapX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollSnapX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollSnapY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollSnapY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollSnapPointsX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollSnapPointsX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollSnapPointsY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollSnapPointsY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridColumn(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridColumn(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridColumnAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridColumnAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridColumns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridColumns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridColumnSpan(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridColumnSpan(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridRow(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridRow(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridRowAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridRowAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridRows([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridRows([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_msGridRowSpan(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_msGridRowSpan(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_msWrapThrough([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_msWrapThrough([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_msWrapMargin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_msWrapMargin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_msWrapFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_msWrapFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationPlayState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationPlayState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationIterationCount([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_msAnimationFillMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_msAnimationFillMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_colorInterpolationFilters([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_colorInterpolationFilters([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnCount(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnCount(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnGap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnGap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnFill([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnFill([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnSpan([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnSpan([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int put_columns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_columns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnRuleColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnRuleColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnRuleStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnRuleStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int put_columnRuleWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[97]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_columnRuleWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[98]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int put_breakBefore([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[99]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_breakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[100]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int put_breakAfter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[101]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_breakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[102]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int put_breakInside([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[103]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_breakInside([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[104]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int put_floodColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[105]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int get_floodColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[106]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int put_floodOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[107]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int get_floodOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[108]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int put_lightingColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[109]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int get_lightingColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[110]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollLimitXMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[111]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollLimitXMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[112]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollLimitYMin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[113]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollLimitYMin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[114]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollLimitXMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[115]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollLimitXMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[116]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollLimitYMax(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[117]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollLimitYMax(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[118]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollLimit([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[119]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollLimit([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[120]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int put_textShadow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[121]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int get_textShadow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[122]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlowFrom([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[123]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlowFrom([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[124]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlowInto([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[125]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlowInto([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[126]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        [return: NativeTypeName("HRESULT")]
        public int put_msHyphens([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[127]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        [return: NativeTypeName("HRESULT")]
        public int get_msHyphens([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[128]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        [return: NativeTypeName("HRESULT")]
        public int put_msHyphenateLimitZone(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[129]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        [return: NativeTypeName("HRESULT")]
        public int get_msHyphenateLimitZone(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[130]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        [return: NativeTypeName("HRESULT")]
        public int put_msHyphenateLimitChars([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[131]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        [return: NativeTypeName("HRESULT")]
        public int get_msHyphenateLimitChars([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[132]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        [return: NativeTypeName("HRESULT")]
        public int put_msHyphenateLimitLines(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[133]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        [return: NativeTypeName("HRESULT")]
        public int get_msHyphenateLimitLines(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[134]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        [return: NativeTypeName("HRESULT")]
        public int put_msHighContrastAdjust([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[135]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        [return: NativeTypeName("HRESULT")]
        public int get_msHighContrastAdjust([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[136]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        [return: NativeTypeName("HRESULT")]
        public int put_enableBackground([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[137]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        [return: NativeTypeName("HRESULT")]
        public int get_enableBackground([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[138]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[139]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[140]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        [return: NativeTypeName("HRESULT")]
        public int put_msUserSelect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[141]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        [return: NativeTypeName("HRESULT")]
        public int get_msUserSelect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[142]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        [return: NativeTypeName("HRESULT")]
        public int put_msOverflowStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[143]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        [return: NativeTypeName("HRESULT")]
        public int get_msOverflowStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[144]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransformStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[145]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransformStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[146]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        [return: NativeTypeName("HRESULT")]
        public int put_msBackfaceVisibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[147]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        [return: NativeTypeName("HRESULT")]
        public int get_msBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[148]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        [return: NativeTypeName("HRESULT")]
        public int put_msPerspective(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[149]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        [return: NativeTypeName("HRESULT")]
        public int get_msPerspective(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[150]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        [return: NativeTypeName("HRESULT")]
        public int put_msPerspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[151]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        [return: NativeTypeName("HRESULT")]
        public int get_msPerspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[152]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransitionProperty([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[153]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransitionProperty([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[154]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransitionDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[155]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransitionDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[156]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[157]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[158]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransitionDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[159]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransitionDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[160]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[161]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[162]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTouchAction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[163]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTouchAction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[164]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        [return: NativeTypeName("HRESULT")]
        public int put_msScrollTranslation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[165]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        [return: NativeTypeName("HRESULT")]
        public int get_msScrollTranslation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[166]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlex([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[167]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlex([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[168]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexPositive(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[169]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexPositive(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[170]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexNegative(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[171]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexNegative(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[172]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexPreferredSize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[173]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexPreferredSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[174]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[175]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[176]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[177]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[178]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[179]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[180]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[181]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[182]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexItemAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[183]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexItemAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[184]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexPack([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[185]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexPack([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[186]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexLinePack([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[187]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexLinePack([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[188]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        [return: NativeTypeName("HRESULT")]
        public int put_msFlexOrder(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[189]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        [return: NativeTypeName("HRESULT")]
        public int get_msFlexOrder(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[190]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTouchSelect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[191]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTouchSelect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[192]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        [return: NativeTypeName("HRESULT")]
        public int put_transform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[193]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        [return: NativeTypeName("HRESULT")]
        public int get_transform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[194]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        [return: NativeTypeName("HRESULT")]
        public int put_transformOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[195]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        [return: NativeTypeName("HRESULT")]
        public int get_transformOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[196]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        [return: NativeTypeName("HRESULT")]
        public int put_transformStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[197]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        [return: NativeTypeName("HRESULT")]
        public int get_transformStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[198]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        [return: NativeTypeName("HRESULT")]
        public int put_backfaceVisibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[199]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        [return: NativeTypeName("HRESULT")]
        public int get_backfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[200]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        [return: NativeTypeName("HRESULT")]
        public int put_perspective(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT, int>)(lpVtbl[201]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        [return: NativeTypeName("HRESULT")]
        public int get_perspective(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, VARIANT*, int>)(lpVtbl[202]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        [return: NativeTypeName("HRESULT")]
        public int put_perspectiveOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[203]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        [return: NativeTypeName("HRESULT")]
        public int get_perspectiveOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[204]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        [return: NativeTypeName("HRESULT")]
        public int put_transitionProperty([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[205]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        [return: NativeTypeName("HRESULT")]
        public int get_transitionProperty([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[206]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        [return: NativeTypeName("HRESULT")]
        public int put_transitionDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[207]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        [return: NativeTypeName("HRESULT")]
        public int get_transitionDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[208]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        [return: NativeTypeName("HRESULT")]
        public int put_transitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[209]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        [return: NativeTypeName("HRESULT")]
        public int get_transitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[210]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        [return: NativeTypeName("HRESULT")]
        public int put_transitionDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[211]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        [return: NativeTypeName("HRESULT")]
        public int get_transitionDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[212]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        [return: NativeTypeName("HRESULT")]
        public int put_transition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[213]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        [return: NativeTypeName("HRESULT")]
        public int get_transition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[214]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontFeatureSettings([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[215]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontFeatureSettings([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[216]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[217]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[218]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[219]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[220]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[221]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[222]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[223]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[224]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[225]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[226]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationPlayState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[227]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationPlayState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[228]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationIterationCount([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[229]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationIterationCount([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[230]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        [return: NativeTypeName("HRESULT")]
        public int put_animation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[231]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        [return: NativeTypeName("HRESULT")]
        public int get_animation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[232]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        [return: NativeTypeName("HRESULT")]
        public int put_animationFillMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort*, int>)(lpVtbl[233]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        [return: NativeTypeName("HRESULT")]
        public int get_animationFillMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration2*, ushort**, int>)(lpVtbl[234]))((IHTMLCSSStyleDeclaration2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
