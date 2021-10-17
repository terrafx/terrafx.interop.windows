// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051085C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCSSStyleDeclaration3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCSSStyleDeclaration3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_flex([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_flex([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexDirection([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexGrow(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexGrow(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexShrink(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexShrink(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_flexBasis(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_flexBasis(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_justifyContent([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_justifyContent([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_alignItems([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_alignItems([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_alignSelf([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_alignSelf([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_alignContent([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_alignContent([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImageSource([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImageSource([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImageSlice([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImageSlice([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImageWidth([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImageWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImageOutset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImageOutset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderImageRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderImageRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_msImeAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_msImeAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTextCombineHorizontal([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTextCombineHorizontal([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_touchAction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_touchAction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration3*, ushort**, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
        }
    }
}
