// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D6100F3B-27C8-4132-AFEA-F0E4B1E00060")]
    [NativeTypeName("struct IHTMLCSSStyleDeclaration4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCSSStyleDeclaration4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAppearance([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAppearance([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitUserSelect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitUserSelect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxOrdinalGroup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxOrdinalGroup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxPack([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxPack([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxFlex(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxFlex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxOrient([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxOrient([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundSize([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackfaceVisibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationIterationCount([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationPlayState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationPlayState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransitionProperty([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransitionProperty([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransitionDuration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransitionDuration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransitionDelay([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransitionDelay([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundAttachment([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundClip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundClip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundPositionX(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackgroundPositionY(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBackground([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBackground([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTransformOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTransformOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTextSizeAdjust(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTextSizeAdjust(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitTextSizeAdjust(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitTextSizeAdjust(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImageSource([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImageSource([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImageSlice([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImageSlice([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImageWidth([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImageWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImageOutset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImageOutset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBorderImageRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBorderImageRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitBoxSizing([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitBoxSizing([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int put_webkitAnimationFillMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_webkitAnimationFillMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
        }
    }
}
