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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentRule(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int getPropertyValue([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getPropertyPriority([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyPriority)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int removeProperty([NativeTypeName("BSTR")] ushort* bstrPropertyName, [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, ushort**, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pbstrPropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int setProperty([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvarPropertyValue, VARIANT* pvarPropertyPriority = null)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), bstrPropertyName, pvarPropertyValue, pvarPropertyPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int item([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrPropertyName)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, int, ushort**, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), index, pbstrPropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontFamily([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontVariant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontWeight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontWeight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontSize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_font([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_font([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_color(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_color(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPositionX(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPositionY(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_letterSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_letterSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecoration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_verticalAlign(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_verticalAlign(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int put_textTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_textTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_textIndent(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_textIndent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_margin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_margin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int put_padding([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_padding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int put_border([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_border([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTop([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTop([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottom([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottom([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeft([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeft([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[97]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[98]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[99]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderWidth([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[100]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[101]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[102]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[103]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[104]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[105]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[106]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[107]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[108]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[109]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[110]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[111]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[112]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[113]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[114]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[115]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[116]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[117]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[118]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[119]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[120]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[121]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[122]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[123]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int put_styleFloat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[124]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[125]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        [return: NativeTypeName("HRESULT")]
        public int put_clear([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[126]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        [return: NativeTypeName("HRESULT")]
        public int get_clear([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[127]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        [return: NativeTypeName("HRESULT")]
        public int put_display([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[128]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        [return: NativeTypeName("HRESULT")]
        public int get_display([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[129]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        [return: NativeTypeName("HRESULT")]
        public int put_visibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[130]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        [return: NativeTypeName("HRESULT")]
        public int get_visibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[131]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyleType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[132]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[133]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStylePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[134]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[135]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyleImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[136]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[137]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[138]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[139]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        [return: NativeTypeName("HRESULT")]
        public int put_whiteSpace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[140]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        [return: NativeTypeName("HRESULT")]
        public int get_whiteSpace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[141]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        [return: NativeTypeName("HRESULT")]
        public int put_top(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[142]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        [return: NativeTypeName("HRESULT")]
        public int get_top(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[143]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        [return: NativeTypeName("HRESULT")]
        public int put_left(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[144]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        [return: NativeTypeName("HRESULT")]
        public int get_left(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[145]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        [return: NativeTypeName("HRESULT")]
        public int put_zIndex(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[146]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        [return: NativeTypeName("HRESULT")]
        public int get_zIndex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[147]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[148]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[149]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[150]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[151]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[152]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[153]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        [return: NativeTypeName("HRESULT")]
        public int put_cssText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[154]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        [return: NativeTypeName("HRESULT")]
        public int get_cssText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[155]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        [return: NativeTypeName("HRESULT")]
        public int put_cursor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[156]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        [return: NativeTypeName("HRESULT")]
        public int get_cursor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[157]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        [return: NativeTypeName("HRESULT")]
        public int put_clip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[158]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        [return: NativeTypeName("HRESULT")]
        public int get_clip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[159]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        [return: NativeTypeName("HRESULT")]
        public int put_filter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[160]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        [return: NativeTypeName("HRESULT")]
        public int get_filter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[161]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        [return: NativeTypeName("HRESULT")]
        public int put_tableLayout([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[162]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        [return: NativeTypeName("HRESULT")]
        public int get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[163]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[164]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[165]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        [return: NativeTypeName("HRESULT")]
        public int put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[166]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        [return: NativeTypeName("HRESULT")]
        public int get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[167]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        [return: NativeTypeName("HRESULT")]
        public int put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[168]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        [return: NativeTypeName("HRESULT")]
        public int get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[169]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        [return: NativeTypeName("HRESULT")]
        public int put_position([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[170]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        [return: NativeTypeName("HRESULT")]
        public int get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[171]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        [return: NativeTypeName("HRESULT")]
        public int put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[172]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        [return: NativeTypeName("HRESULT")]
        public int get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[173]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        [return: NativeTypeName("HRESULT")]
        public int put_bottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[174]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        [return: NativeTypeName("HRESULT")]
        public int get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[175]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        [return: NativeTypeName("HRESULT")]
        public int put_right(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[176]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        [return: NativeTypeName("HRESULT")]
        public int get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[177]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        [return: NativeTypeName("HRESULT")]
        public int put_imeMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[178]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        [return: NativeTypeName("HRESULT")]
        public int get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[179]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[180]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[181]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[182]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[183]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[184]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[185]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridChar(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[186]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[187]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridLine(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[188]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[189]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[190]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[191]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[192]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[193]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[194]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[195]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAutospace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[196]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[197]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[198]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[199]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[200]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[201]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        [return: NativeTypeName("HRESULT")]
        public int put_textJustify([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[202]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[203]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        [return: NativeTypeName("HRESULT")]
        public int put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[204]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[205]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        [return: NativeTypeName("HRESULT")]
        public int put_textKashida(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[206]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[207]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflowX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[208]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[209]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflowY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[210]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[211]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        [return: NativeTypeName("HRESULT")]
        public int put_accelerator([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[212]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        [return: NativeTypeName("HRESULT")]
        public int get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[213]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutFlow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[214]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[215]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        [return: NativeTypeName("HRESULT")]
        public int put_zoom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[216]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        [return: NativeTypeName("HRESULT")]
        public int get_zoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[217]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordWrap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[218]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[219]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        [return: NativeTypeName("HRESULT")]
        public int put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[220]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        [return: NativeTypeName("HRESULT")]
        public int get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[221]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarBaseColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[222]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarBaseColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[223]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarFaceColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[224]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarFaceColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[225]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbar3dLightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[226]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbar3dLightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[227]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[228]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[229]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarHighlightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[230]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarHighlightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[231]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarDarkShadowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[232]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarDarkShadowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[233]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarArrowColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[234]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(235)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarArrowColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[235]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(236)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbarTrackColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[236]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(237)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbarTrackColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[237]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(238)]
        [return: NativeTypeName("HRESULT")]
        public int put_writingMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[238]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(239)]
        [return: NativeTypeName("HRESULT")]
        public int get_writingMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[239]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(240)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAlignLast([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[240]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(241)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[241]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(242)]
        [return: NativeTypeName("HRESULT")]
        public int put_textKashidaSpace(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[242]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(243)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashidaSpace(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[243]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(244)]
        [return: NativeTypeName("HRESULT")]
        public int put_textOverflow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[244]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(245)]
        [return: NativeTypeName("HRESULT")]
        public int get_textOverflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[245]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(246)]
        [return: NativeTypeName("HRESULT")]
        public int put_minHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[246]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(247)]
        [return: NativeTypeName("HRESULT")]
        public int get_minHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[247]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(248)]
        [return: NativeTypeName("HRESULT")]
        public int put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[248]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(249)]
        [return: NativeTypeName("HRESULT")]
        public int get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[249]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(250)]
        [return: NativeTypeName("HRESULT")]
        public int put_maxHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[250]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(251)]
        [return: NativeTypeName("HRESULT")]
        public int get_maxHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[251]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(252)]
        [return: NativeTypeName("HRESULT")]
        public int put_minWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[252]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(253)]
        [return: NativeTypeName("HRESULT")]
        public int get_minWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[253]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(254)]
        [return: NativeTypeName("HRESULT")]
        public int put_maxWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[254]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(255)]
        [return: NativeTypeName("HRESULT")]
        public int get_maxWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[255]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(256)]
        [return: NativeTypeName("HRESULT")]
        public int put_content([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[256]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(257)]
        [return: NativeTypeName("HRESULT")]
        public int get_content([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[257]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(258)]
        [return: NativeTypeName("HRESULT")]
        public int put_captionSide([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[258]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(259)]
        [return: NativeTypeName("HRESULT")]
        public int get_captionSide([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[259]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(260)]
        [return: NativeTypeName("HRESULT")]
        public int put_counterIncrement([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[260]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(261)]
        [return: NativeTypeName("HRESULT")]
        public int get_counterIncrement([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[261]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(262)]
        [return: NativeTypeName("HRESULT")]
        public int put_counterReset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[262]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(263)]
        [return: NativeTypeName("HRESULT")]
        public int get_counterReset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[263]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(264)]
        [return: NativeTypeName("HRESULT")]
        public int put_outline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[264]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(265)]
        [return: NativeTypeName("HRESULT")]
        public int get_outline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[265]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(266)]
        [return: NativeTypeName("HRESULT")]
        public int put_outlineWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[266]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(267)]
        [return: NativeTypeName("HRESULT")]
        public int get_outlineWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[267]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(268)]
        [return: NativeTypeName("HRESULT")]
        public int put_outlineStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[268]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(269)]
        [return: NativeTypeName("HRESULT")]
        public int get_outlineStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[269]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(270)]
        [return: NativeTypeName("HRESULT")]
        public int put_outlineColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[270]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(271)]
        [return: NativeTypeName("HRESULT")]
        public int get_outlineColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[271]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(272)]
        [return: NativeTypeName("HRESULT")]
        public int put_boxSizing([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[272]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(273)]
        [return: NativeTypeName("HRESULT")]
        public int get_boxSizing([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[273]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(274)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderSpacing([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[274]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(275)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderSpacing([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[275]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(276)]
        [return: NativeTypeName("HRESULT")]
        public int put_orphans(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[276]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(277)]
        [return: NativeTypeName("HRESULT")]
        public int get_orphans(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[277]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(278)]
        [return: NativeTypeName("HRESULT")]
        public int put_widows(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[278]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(279)]
        [return: NativeTypeName("HRESULT")]
        public int get_widows(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[279]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(280)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageBreakInside([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[280]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(281)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[281]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(282)]
        [return: NativeTypeName("HRESULT")]
        public int put_emptyCells([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[282]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(283)]
        [return: NativeTypeName("HRESULT")]
        public int get_emptyCells([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[283]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(284)]
        [return: NativeTypeName("HRESULT")]
        public int put_msBlockProgression([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[284]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(285)]
        [return: NativeTypeName("HRESULT")]
        public int get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[285]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(286)]
        [return: NativeTypeName("HRESULT")]
        public int put_quotes([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[286]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(287)]
        [return: NativeTypeName("HRESULT")]
        public int get_quotes([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[287]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(288)]
        [return: NativeTypeName("HRESULT")]
        public int put_alignmentBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[288]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(289)]
        [return: NativeTypeName("HRESULT")]
        public int get_alignmentBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[289]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(290)]
        [return: NativeTypeName("HRESULT")]
        public int put_baselineShift(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[290]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(291)]
        [return: NativeTypeName("HRESULT")]
        public int get_baselineShift(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[291]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(292)]
        [return: NativeTypeName("HRESULT")]
        public int put_dominantBaseline([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[292]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(293)]
        [return: NativeTypeName("HRESULT")]
        public int get_dominantBaseline([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[293]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(294)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontSizeAdjust(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[294]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(295)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontSizeAdjust(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[295]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(296)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontStretch([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[296]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(297)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontStretch([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[297]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(298)]
        [return: NativeTypeName("HRESULT")]
        public int put_opacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[298]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(299)]
        [return: NativeTypeName("HRESULT")]
        public int get_opacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[299]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(300)]
        [return: NativeTypeName("HRESULT")]
        public int put_clipPath([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[300]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(301)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipPath([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[301]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(302)]
        [return: NativeTypeName("HRESULT")]
        public int put_clipRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[302]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(303)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[303]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(304)]
        [return: NativeTypeName("HRESULT")]
        public int put_fill([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[304]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(305)]
        [return: NativeTypeName("HRESULT")]
        public int get_fill([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[305]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(306)]
        [return: NativeTypeName("HRESULT")]
        public int put_fillOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[306]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(307)]
        [return: NativeTypeName("HRESULT")]
        public int get_fillOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[307]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(308)]
        [return: NativeTypeName("HRESULT")]
        public int put_fillRule([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[308]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(309)]
        [return: NativeTypeName("HRESULT")]
        public int get_fillRule([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[309]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(310)]
        [return: NativeTypeName("HRESULT")]
        public int put_kerning(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[310]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(311)]
        [return: NativeTypeName("HRESULT")]
        public int get_kerning(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[311]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(312)]
        [return: NativeTypeName("HRESULT")]
        public int put_marker([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[312]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(313)]
        [return: NativeTypeName("HRESULT")]
        public int get_marker([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[313]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(314)]
        [return: NativeTypeName("HRESULT")]
        public int put_markerEnd([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[314]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(315)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerEnd([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[315]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(316)]
        [return: NativeTypeName("HRESULT")]
        public int put_markerMid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[316]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(317)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerMid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[317]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(318)]
        [return: NativeTypeName("HRESULT")]
        public int put_markerStart([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[318]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(319)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerStart([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[319]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(320)]
        [return: NativeTypeName("HRESULT")]
        public int put_mask([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[320]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(321)]
        [return: NativeTypeName("HRESULT")]
        public int get_mask([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[321]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(322)]
        [return: NativeTypeName("HRESULT")]
        public int put_pointerEvents([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[322]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(323)]
        [return: NativeTypeName("HRESULT")]
        public int get_pointerEvents([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[323]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(324)]
        [return: NativeTypeName("HRESULT")]
        public int put_stopColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[324]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(325)]
        [return: NativeTypeName("HRESULT")]
        public int get_stopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[325]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(326)]
        [return: NativeTypeName("HRESULT")]
        public int put_stopOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[326]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(327)]
        [return: NativeTypeName("HRESULT")]
        public int get_stopOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[327]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(328)]
        [return: NativeTypeName("HRESULT")]
        public int put_stroke([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[328]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(329)]
        [return: NativeTypeName("HRESULT")]
        public int get_stroke([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[329]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(330)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeDasharray([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[330]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(331)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeDasharray([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[331]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(332)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeDashoffset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[332]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(333)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeDashoffset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[333]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(334)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeLinecap([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[334]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(335)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeLinecap([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[335]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(336)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeLinejoin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[336]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(337)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeLinejoin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[337]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(338)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeMiterlimit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[338]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(339)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeMiterlimit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[339]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(340)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeOpacity(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[340]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(341)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeOpacity(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[341]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(342)]
        [return: NativeTypeName("HRESULT")]
        public int put_strokeWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[342]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(343)]
        [return: NativeTypeName("HRESULT")]
        public int get_strokeWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[343]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(344)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAnchor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[344]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(345)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAnchor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[345]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(346)]
        [return: NativeTypeName("HRESULT")]
        public int put_glyphOrientationHorizontal(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[346]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(347)]
        [return: NativeTypeName("HRESULT")]
        public int get_glyphOrientationHorizontal(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[347]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(348)]
        [return: NativeTypeName("HRESULT")]
        public int put_glyphOrientationVertical(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[348]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(349)]
        [return: NativeTypeName("HRESULT")]
        public int get_glyphOrientationVertical(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[349]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(350)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[350]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(351)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[351]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(352)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopLeftRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[352]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(353)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopLeftRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[353]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(354)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopRightRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[354]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(355)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopRightRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[355]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(356)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomRightRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[356]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(357)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomRightRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[357]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(358)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomLeftRadius([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[358]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(359)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomLeftRadius([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[359]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(360)]
        [return: NativeTypeName("HRESULT")]
        public int put_clipTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[360]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(361)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[361]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(362)]
        [return: NativeTypeName("HRESULT")]
        public int put_clipRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[362]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(363)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[363]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(364)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[364]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(365)]
        [return: NativeTypeName("HRESULT")]
        public int put_clipLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT, int>)(lpVtbl[365]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(366)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, VARIANT*, int>)(lpVtbl[366]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(367)]
        [return: NativeTypeName("HRESULT")]
        public int put_cssFloat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[367]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(368)]
        [return: NativeTypeName("HRESULT")]
        public int get_cssFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[368]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(369)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundClip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[369]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(370)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundClip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[370]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(371)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[371]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(372)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[372]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(373)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundSize([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[373]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(374)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[374]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(375)]
        [return: NativeTypeName("HRESULT")]
        public int put_boxShadow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[375]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(376)]
        [return: NativeTypeName("HRESULT")]
        public int get_boxShadow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[376]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(377)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[377]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(378)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[378]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(379)]
        [return: NativeTypeName("HRESULT")]
        public int put_msTransformOrigin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort*, int>)(lpVtbl[379]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(380)]
        [return: NativeTypeName("HRESULT")]
        public int get_msTransformOrigin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCSSStyleDeclaration*, ushort**, int>)(lpVtbl[380]))((IHTMLCSSStyleDeclaration*)Unsafe.AsPointer(ref this), p);
        }
    }
}
