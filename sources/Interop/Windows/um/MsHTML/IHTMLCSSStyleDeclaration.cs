// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510740-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCSSStyleDeclaration : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCSSStyleDeclaration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_parentRule(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT getPropertyValue([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT getPropertyPriority([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyPriority)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT removeProperty([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT setProperty([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvarPropertyValue, VARIANT* pvarPropertyPriority = null)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pvarPropertyValue, pvarPropertyPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT item([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrPropertyName)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int, ushort**, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), index, pbstrPropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_fontFamily([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_fontStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_fontVariant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_fontWeight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_fontWeight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_fontSize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_fontSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_font([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_font([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_color(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_color(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_backgroundColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_backgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_backgroundImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_backgroundPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_backgroundPositionX(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_backgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_backgroundPositionY(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_backgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_wordSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_wordSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_letterSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_letterSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT put_verticalAlign(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_verticalAlign(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT put_textTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT put_textIndent(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_textIndent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT put_lineHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_lineHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT put_marginTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_marginTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT put_marginRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_marginRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT put_marginBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT get_marginBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT put_marginLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_marginLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT put_margin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT put_paddingTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_paddingTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT put_paddingRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT get_paddingRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT put_paddingBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT get_paddingBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT put_paddingLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT get_paddingLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT put_padding([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT put_border([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT get_border([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT put_borderTop([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT get_borderTop([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT put_borderRight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT get_borderRight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT put_borderBottom([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT get_borderBottom([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT put_borderLeft([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT get_borderLeft([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT put_borderColor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT put_borderTopColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT get_borderTopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT put_borderRightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT get_borderRightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT put_borderBottomColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HRESULT get_borderBottomColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[97]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public HRESULT put_borderLeftColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[98]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public HRESULT get_borderLeftColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[99]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public HRESULT put_borderWidth([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[100]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[101]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public HRESULT put_borderTopWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[102]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public HRESULT get_borderTopWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[103]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public HRESULT put_borderRightWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[104]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public HRESULT get_borderRightWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[105]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public HRESULT put_borderBottomWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[106]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public HRESULT get_borderBottomWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[107]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public HRESULT put_borderLeftWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[108]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public HRESULT get_borderLeftWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[109]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[110]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[111]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public HRESULT put_borderTopStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[112]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[113]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HRESULT put_borderRightStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[114]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[115]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        public HRESULT put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[116]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        public HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[117]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        public HRESULT put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[118]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        public HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[119]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        public HRESULT put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[120]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        public HRESULT get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[121]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        public HRESULT put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[122]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        public HRESULT get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[123]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        public HRESULT put_styleFloat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[124]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        public HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[125]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        public HRESULT put_clear([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[126]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        public HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[127]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        public HRESULT put_display([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[128]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        public HRESULT get_display([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[129]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        public HRESULT put_visibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[130]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        public HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[131]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        public HRESULT put_listStyleType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[132]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        public HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[133]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        public HRESULT put_listStylePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[134]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        public HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[135]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        public HRESULT put_listStyleImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[136]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        public HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[137]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        public HRESULT put_listStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[138]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        public HRESULT get_listStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[139]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        public HRESULT put_whiteSpace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[140]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        public HRESULT get_whiteSpace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[141]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        public HRESULT put_top(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[142]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        public HRESULT get_top(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[143]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        public HRESULT put_left(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[144]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        public HRESULT get_left(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[145]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        public HRESULT put_zIndex(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[146]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        public HRESULT get_zIndex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[147]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        public HRESULT put_overflow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[148]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        public HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[149]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        public HRESULT put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[150]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        public HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[151]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        public HRESULT put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[152]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        public HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[153]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        public HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[154]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        public HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[155]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        public HRESULT put_cursor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[156]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        public HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[157]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        public HRESULT put_clip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[158]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        public HRESULT get_clip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[159]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        public HRESULT put_filter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[160]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        public HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[161]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        public HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[162]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        public HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[163]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        public HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[164]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        public HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[165]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[166]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[167]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[168]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[169]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        public HRESULT put_position([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[170]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[171]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        public HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[172]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        public HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[173]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        public HRESULT put_bottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[174]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        public HRESULT get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[175]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        public HRESULT put_right(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[176]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        public HRESULT get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[177]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        public HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[178]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        public HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[179]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        public HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[180]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        public HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[181]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        public HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[182]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        public HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[183]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        public HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[184]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        public HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[185]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        public HRESULT put_layoutGridChar(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[186]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        public HRESULT get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[187]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        public HRESULT put_layoutGridLine(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[188]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        public HRESULT get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[189]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        public HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[190]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        public HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[191]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        public HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[192]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        public HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[193]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        public HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[194]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        public HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[195]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        public HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[196]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        public HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[197]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        public HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[198]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        public HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[199]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        public HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[200]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        public HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[201]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        public HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[202]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        public HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[203]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        public HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[204]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        public HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[205]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        public HRESULT put_textKashida(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[206]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        public HRESULT get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[207]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        public HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[208]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        public HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[209]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        public HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[210]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        public HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[211]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        public HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[212]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        public HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[213]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        public HRESULT put_layoutFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[214]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        public HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[215]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        public HRESULT put_zoom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[216]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        public HRESULT get_zoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[217]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        public HRESULT put_wordWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[218]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        public HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[219]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        public HRESULT put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[220]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        public HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[221]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        public HRESULT put_scrollbarBaseColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[222]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        public HRESULT get_scrollbarBaseColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[223]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        public HRESULT put_scrollbarFaceColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[224]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        public HRESULT get_scrollbarFaceColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[225]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        public HRESULT put_scrollbar3dLightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[226]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        public HRESULT get_scrollbar3dLightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[227]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        public HRESULT put_scrollbarShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[228]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        public HRESULT get_scrollbarShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[229]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        public HRESULT put_scrollbarHighlightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[230]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        public HRESULT get_scrollbarHighlightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[231]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        public HRESULT put_scrollbarDarkShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[232]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        public HRESULT get_scrollbarDarkShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[233]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        public HRESULT put_scrollbarArrowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[234]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(235)]
        public HRESULT get_scrollbarArrowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[235]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(236)]
        public HRESULT put_scrollbarTrackColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[236]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(237)]
        public HRESULT get_scrollbarTrackColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[237]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(238)]
        public HRESULT put_writingMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[238]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(239)]
        public HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[239]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(240)]
        public HRESULT put_textAlignLast([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[240]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(241)]
        public HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[241]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(242)]
        public HRESULT put_textKashidaSpace(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[242]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(243)]
        public HRESULT get_textKashidaSpace(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[243]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(244)]
        public HRESULT put_textOverflow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[244]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(245)]
        public HRESULT get_textOverflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[245]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(246)]
        public HRESULT put_minHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[246]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(247)]
        public HRESULT get_minHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[247]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(248)]
        public HRESULT put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[248]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(249)]
        public HRESULT get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[249]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(250)]
        public HRESULT put_maxHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[250]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(251)]
        public HRESULT get_maxHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[251]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(252)]
        public HRESULT put_minWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[252]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(253)]
        public HRESULT get_minWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[253]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(254)]
        public HRESULT put_maxWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[254]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(255)]
        public HRESULT get_maxWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[255]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(256)]
        public HRESULT put_content([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[256]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(257)]
        public HRESULT get_content([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[257]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(258)]
        public HRESULT put_captionSide([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[258]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(259)]
        public HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[259]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(260)]
        public HRESULT put_counterIncrement([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[260]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(261)]
        public HRESULT get_counterIncrement([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[261]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(262)]
        public HRESULT put_counterReset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[262]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(263)]
        public HRESULT get_counterReset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[263]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(264)]
        public HRESULT put_outline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[264]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(265)]
        public HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[265]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(266)]
        public HRESULT put_outlineWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[266]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(267)]
        public HRESULT get_outlineWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[267]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(268)]
        public HRESULT put_outlineStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[268]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(269)]
        public HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[269]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(270)]
        public HRESULT put_outlineColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[270]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(271)]
        public HRESULT get_outlineColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[271]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(272)]
        public HRESULT put_boxSizing([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[272]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(273)]
        public HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[273]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(274)]
        public HRESULT put_borderSpacing([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[274]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(275)]
        public HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[275]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(276)]
        public HRESULT put_orphans(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[276]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(277)]
        public HRESULT get_orphans(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[277]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(278)]
        public HRESULT put_widows(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[278]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(279)]
        public HRESULT get_widows(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[279]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(280)]
        public HRESULT put_pageBreakInside([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[280]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(281)]
        public HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[281]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(282)]
        public HRESULT put_emptyCells([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[282]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(283)]
        public HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[283]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(284)]
        public HRESULT put_msBlockProgression([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[284]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(285)]
        public HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[285]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(286)]
        public HRESULT put_quotes([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[286]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(287)]
        public HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[287]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(288)]
        public HRESULT put_alignmentBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[288]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(289)]
        public HRESULT get_alignmentBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[289]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(290)]
        public HRESULT put_baselineShift(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[290]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(291)]
        public HRESULT get_baselineShift(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[291]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(292)]
        public HRESULT put_dominantBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[292]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(293)]
        public HRESULT get_dominantBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[293]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(294)]
        public HRESULT put_fontSizeAdjust(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[294]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(295)]
        public HRESULT get_fontSizeAdjust(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[295]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(296)]
        public HRESULT put_fontStretch([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[296]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(297)]
        public HRESULT get_fontStretch([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[297]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(298)]
        public HRESULT put_opacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[298]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(299)]
        public HRESULT get_opacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[299]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(300)]
        public HRESULT put_clipPath([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[300]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(301)]
        public HRESULT get_clipPath([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[301]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(302)]
        public HRESULT put_clipRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[302]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(303)]
        public HRESULT get_clipRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[303]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(304)]
        public HRESULT put_fill([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[304]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(305)]
        public HRESULT get_fill([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[305]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(306)]
        public HRESULT put_fillOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[306]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(307)]
        public HRESULT get_fillOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[307]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(308)]
        public HRESULT put_fillRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[308]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(309)]
        public HRESULT get_fillRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[309]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(310)]
        public HRESULT put_kerning(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[310]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(311)]
        public HRESULT get_kerning(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[311]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(312)]
        public HRESULT put_marker([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[312]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(313)]
        public HRESULT get_marker([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[313]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(314)]
        public HRESULT put_markerEnd([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[314]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(315)]
        public HRESULT get_markerEnd([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[315]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(316)]
        public HRESULT put_markerMid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[316]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(317)]
        public HRESULT get_markerMid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[317]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(318)]
        public HRESULT put_markerStart([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[318]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(319)]
        public HRESULT get_markerStart([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[319]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(320)]
        public HRESULT put_mask([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[320]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(321)]
        public HRESULT get_mask([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[321]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(322)]
        public HRESULT put_pointerEvents([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[322]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(323)]
        public HRESULT get_pointerEvents([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[323]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(324)]
        public HRESULT put_stopColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[324]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(325)]
        public HRESULT get_stopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[325]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(326)]
        public HRESULT put_stopOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[326]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(327)]
        public HRESULT get_stopOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[327]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(328)]
        public HRESULT put_stroke([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[328]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(329)]
        public HRESULT get_stroke([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[329]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(330)]
        public HRESULT put_strokeDasharray([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[330]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(331)]
        public HRESULT get_strokeDasharray([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[331]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(332)]
        public HRESULT put_strokeDashoffset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[332]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(333)]
        public HRESULT get_strokeDashoffset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[333]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(334)]
        public HRESULT put_strokeLinecap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[334]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(335)]
        public HRESULT get_strokeLinecap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[335]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(336)]
        public HRESULT put_strokeLinejoin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[336]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(337)]
        public HRESULT get_strokeLinejoin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[337]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(338)]
        public HRESULT put_strokeMiterlimit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[338]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(339)]
        public HRESULT get_strokeMiterlimit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[339]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(340)]
        public HRESULT put_strokeOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[340]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(341)]
        public HRESULT get_strokeOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[341]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(342)]
        public HRESULT put_strokeWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[342]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(343)]
        public HRESULT get_strokeWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[343]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(344)]
        public HRESULT put_textAnchor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[344]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(345)]
        public HRESULT get_textAnchor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[345]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(346)]
        public HRESULT put_glyphOrientationHorizontal(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[346]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(347)]
        public HRESULT get_glyphOrientationHorizontal(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[347]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(348)]
        public HRESULT put_glyphOrientationVertical(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[348]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(349)]
        public HRESULT get_glyphOrientationVertical(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[349]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(350)]
        public HRESULT put_borderRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[350]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(351)]
        public HRESULT get_borderRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[351]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(352)]
        public HRESULT put_borderTopLeftRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[352]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(353)]
        public HRESULT get_borderTopLeftRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[353]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(354)]
        public HRESULT put_borderTopRightRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[354]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(355)]
        public HRESULT get_borderTopRightRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[355]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(356)]
        public HRESULT put_borderBottomRightRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[356]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(357)]
        public HRESULT get_borderBottomRightRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[357]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(358)]
        public HRESULT put_borderBottomLeftRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[358]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(359)]
        public HRESULT get_borderBottomLeftRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[359]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(360)]
        public HRESULT put_clipTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[360]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(361)]
        public HRESULT get_clipTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[361]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(362)]
        public HRESULT put_clipRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[362]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(363)]
        public HRESULT get_clipRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[363]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(364)]
        public HRESULT get_clipBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[364]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(365)]
        public HRESULT put_clipLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[365]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(366)]
        public HRESULT get_clipLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[366]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(367)]
        public HRESULT put_cssFloat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[367]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(368)]
        public HRESULT get_cssFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[368]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(369)]
        public HRESULT put_backgroundClip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[369]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(370)]
        public HRESULT get_backgroundClip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[370]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(371)]
        public HRESULT put_backgroundOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[371]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(372)]
        public HRESULT get_backgroundOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[372]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(373)]
        public HRESULT put_backgroundSize([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[373]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(374)]
        public HRESULT get_backgroundSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[374]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(375)]
        public HRESULT put_boxShadow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[375]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(376)]
        public HRESULT get_boxShadow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[376]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(377)]
        public HRESULT put_msTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[377]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(378)]
        public HRESULT get_msTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[378]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(379)]
        public HRESULT put_msTransformOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[379]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(380)]
        public HRESULT get_msTransformOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[380]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }
    }
}
