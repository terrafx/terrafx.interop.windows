// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F3DB-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCurrentStyle : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCurrentStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint>)(lpVtbl[1]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint>)(lpVtbl[2]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint*, int>)(lpVtbl[3]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[7]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[8]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_color(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[9]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_backgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[10]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[11]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[12]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[13]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_fontWeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_fontSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[15]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[16]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_backgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[17]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_backgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[19]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_borderLeftColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[20]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_borderTopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[21]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_borderRightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[22]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_borderBottomColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[23]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[24]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[25]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[26]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[27]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_borderTopWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[28]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_borderRightWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[29]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_borderBottomWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[30]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_borderLeftWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[31]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_left(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[32]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_top(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[33]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[34]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[35]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_paddingLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[36]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_paddingTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[37]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_paddingRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[38]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_paddingBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[39]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[40]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[41]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_display([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[42]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[43]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_zIndex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[44]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_letterSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[45]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_lineHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[46]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_textIndent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[47]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_verticalAlign(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[48]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[49]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_marginTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[50]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_marginRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[51]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_marginBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[52]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_marginLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[53]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[54]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[55]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[56]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[57]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_clipTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[58]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_clipRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[59]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_clipBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[60]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_clipLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[61]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[62]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[63]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[64]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[65]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[66]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[67]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[68]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[69]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort*, int, VARIANT*, int>)(lpVtbl[70]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[71]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[72]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[73]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[74]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[75]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[76]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[77]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[78]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[79]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[80]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[81]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[82]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[83]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT get_blockDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[84]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[85]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[86]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[87]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[88]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[89]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[90]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[91]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[92]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[93]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[94]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[95]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[96]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[97]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_position;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_styleFloat;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_color;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_backgroundColor;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_fontFamily;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_fontStyle;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_fontVariant;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_fontWeight;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_fontSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_backgroundImage;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_backgroundPositionX;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_backgroundPositionY;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_backgroundRepeat;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderLeftColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderTopColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderRightColor;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderBottomColor;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderTopStyle;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderRightStyle;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderBottomStyle;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderLeftStyle;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderTopWidth;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderRightWidth;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderBottomWidth;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_borderLeftWidth;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_left;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_top;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_width;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_height;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_paddingLeft;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_paddingTop;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_paddingRight;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_paddingBottom;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textAlign;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textDecoration;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_display;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_visibility;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_zIndex;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_letterSpacing;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_lineHeight;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_textIndent;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_verticalAlign;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_backgroundAttachment;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_marginTop;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_marginRight;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_marginBottom;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_marginLeft;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_clear;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_listStyleType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_listStylePosition;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_listStyleImage;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_clipTop;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_clipRight;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_clipBottom;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_clipLeft;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_overflow;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_pageBreakBefore;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_pageBreakAfter;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_cursor;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_tableLayout;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderCollapse;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_direction;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_behavior;

            [NativeTypeName("HRESULT (BSTR, LONG, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort*, int, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_unicodeBidi;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_right;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_bottom;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_imeMode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_rubyAlign;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_rubyPosition;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_rubyOverhang;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textAutospace;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_lineBreak;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_wordBreak;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textJustify;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textJustifyTrim;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_textKashida;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_blockDirection;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_layoutGridChar;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int> get_layoutGridLine;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_layoutGridMode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_layoutGridType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderStyle;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderColor;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_borderWidth;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_padding;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_margin;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_accelerator;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_overflowX;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_overflowY;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int> get_textTransform;
        }
    }
}
