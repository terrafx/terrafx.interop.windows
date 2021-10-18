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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint*, int>)(lpVtbl[3]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[7]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[8]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_color(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[9]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[10]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[11]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[12]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[13]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontWeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[15]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[16]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[17]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[19]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[20]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[21]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[22]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[23]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[24]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[25]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[26]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[27]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[28]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[29]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[30]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[31]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_left(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[32]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_top(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[33]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[34]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[35]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[36]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[37]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[38]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[39]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[40]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[41]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_display([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[42]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_visibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[43]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_zIndex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[44]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_letterSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[45]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[46]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_textIndent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[47]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_verticalAlign(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[48]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[49]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[50]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[51]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[52]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[53]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_clear([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[54]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[55]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[56]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[57]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[58]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[59]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[60]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[61]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[62]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[63]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[64]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_cursor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[65]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[66]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[67]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[68]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[69]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort*, int, VARIANT*, int>)(lpVtbl[70]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[71]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[72]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[73]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[74]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[75]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[76]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[77]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[78]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[79]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[80]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[81]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[82]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[83]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_blockDirection([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[84]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[85]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, VARIANT*, int>)(lpVtbl[86]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[87]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[88]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[89]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[90]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[91]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_padding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[92]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_margin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[93]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[94]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[95]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[96]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_textTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCurrentStyle*, ushort**, int>)(lpVtbl[97]))((IHTMLCurrentStyle*)Unsafe.AsPointer(ref this), p);
        }
    }
}
