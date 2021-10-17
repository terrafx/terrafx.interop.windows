// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F3CF-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLRuleStyle : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLRuleStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, uint>)(lpVtbl[1]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, uint>)(lpVtbl[2]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, uint*, int>)(lpVtbl[3]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontFamily([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[7]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[8]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[9]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[10]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontVariant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[11]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[12]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontWeight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[13]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontWeight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[14]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_fontSize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[15]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontSize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[16]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_font([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[17]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_font([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[18]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_color(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[19]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_color(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[20]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_background([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[21]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_background([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[22]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[23]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[24]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[25]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[26]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[27]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[28]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[29]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[30]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[31]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[32]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPositionX(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[33]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionX(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[34]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_backgroundPositionY(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[35]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundPositionY(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[36]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[37]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[38]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_letterSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[39]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_letterSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[40]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecoration([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[41]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[42]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecorationNone([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short, int>)(lpVtbl[43]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecorationNone([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short*, int>)(lpVtbl[44]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecorationUnderline([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short, int>)(lpVtbl[45]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecorationUnderline([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short*, int>)(lpVtbl[46]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecorationOverline([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short, int>)(lpVtbl[47]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecorationOverline([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short*, int>)(lpVtbl[48]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short, int>)(lpVtbl[49]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short*, int>)(lpVtbl[50]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_textDecorationBlink([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short, int>)(lpVtbl[51]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDecorationBlink([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, short*, int>)(lpVtbl[52]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_verticalAlign(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[53]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_verticalAlign(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[54]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_textTransform([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[55]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_textTransform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[56]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[57]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[58]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_textIndent(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[59]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_textIndent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[60]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[61]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[62]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[63]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[64]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[65]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[66]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[67]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[68]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[69]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[70]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_margin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[71]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_margin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[72]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[73]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[74]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingRight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[75]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingRight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[76]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingBottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[77]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingBottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[78]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_paddingLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[79]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_paddingLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[80]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int put_padding([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[81]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_padding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[82]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int put_border([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[83]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_border([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[84]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTop([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[85]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTop([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[86]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRight([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[87]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRight([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[88]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottom([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[89]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottom([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[90]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeft([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[91]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeft([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[92]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[93]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[94]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[95]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[96]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[97]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[98]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[99]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[100]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[101]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[102]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderWidth([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[103]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[104]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[105]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[106]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[107]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[108]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[109]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[110]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[111]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[112]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[113]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[114]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderTopStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[115]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[116]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderRightStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[117]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[118]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[119]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[120]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[121]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[122]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[123]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[124]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[125]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[126]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        [return: NativeTypeName("HRESULT")]
        public int put_styleFloat([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[127]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        [return: NativeTypeName("HRESULT")]
        public int get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[128]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        [return: NativeTypeName("HRESULT")]
        public int put_clear([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[129]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        [return: NativeTypeName("HRESULT")]
        public int get_clear([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[130]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        [return: NativeTypeName("HRESULT")]
        public int put_display([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[131]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        [return: NativeTypeName("HRESULT")]
        public int get_display([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[132]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        [return: NativeTypeName("HRESULT")]
        public int put_visibility([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[133]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        [return: NativeTypeName("HRESULT")]
        public int get_visibility([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[134]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyleType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[135]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[136]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStylePosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[137]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[138]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyleImage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[139]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[140]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        [return: NativeTypeName("HRESULT")]
        public int put_listStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[141]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        [return: NativeTypeName("HRESULT")]
        public int get_listStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[142]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        [return: NativeTypeName("HRESULT")]
        public int put_whiteSpace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[143]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        [return: NativeTypeName("HRESULT")]
        public int get_whiteSpace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[144]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        [return: NativeTypeName("HRESULT")]
        public int put_top(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[145]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        [return: NativeTypeName("HRESULT")]
        public int get_top(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[146]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        [return: NativeTypeName("HRESULT")]
        public int put_left(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[147]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        [return: NativeTypeName("HRESULT")]
        public int get_left(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[148]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        [return: NativeTypeName("HRESULT")]
        public int get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[149]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        [return: NativeTypeName("HRESULT")]
        public int put_zIndex(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT, int>)(lpVtbl[150]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        [return: NativeTypeName("HRESULT")]
        public int get_zIndex(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, VARIANT*, int>)(lpVtbl[151]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[152]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[153]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[154]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[155]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[156]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[157]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        [return: NativeTypeName("HRESULT")]
        public int put_cssText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[158]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        [return: NativeTypeName("HRESULT")]
        public int get_cssText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[159]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        [return: NativeTypeName("HRESULT")]
        public int put_cursor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[160]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        [return: NativeTypeName("HRESULT")]
        public int get_cursor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[161]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        [return: NativeTypeName("HRESULT")]
        public int put_clip([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[162]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        [return: NativeTypeName("HRESULT")]
        public int get_clip([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[163]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        [return: NativeTypeName("HRESULT")]
        public int put_filter([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int>)(lpVtbl[164]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        [return: NativeTypeName("HRESULT")]
        public int get_filter([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort**, int>)(lpVtbl[165]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, VARIANT, int, int>)(lpVtbl[166]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int, VARIANT*, int>)(lpVtbl[167]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle*, ushort*, int, short*, int>)(lpVtbl[168]))((IHTMLRuleStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
        }
    }
}
