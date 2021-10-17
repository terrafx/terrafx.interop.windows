// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4A2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLStyle2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLStyle2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLStyle2*, uint>)(lpVtbl[1]))((IHTMLStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLStyle2*, uint>)(lpVtbl[2]))((IHTMLStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, uint*, int>)(lpVtbl[3]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_tableLayout([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[7]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[8]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[9]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[10]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[11]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[12]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[13]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[14]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int setExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("BSTR")] ushort* language = null)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, ushort*, ushort*, int>)(lpVtbl[15]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, expression, language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, VARIANT*, int>)(lpVtbl[16]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, expression);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int removeExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, short*, int>)(lpVtbl[17]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_position([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[18]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[19]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[20]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[21]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_bottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int>)(lpVtbl[22]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int>)(lpVtbl[23]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_right(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int>)(lpVtbl[24]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int>)(lpVtbl[25]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_pixelBottom([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, int, int>)(lpVtbl[26]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_pixelBottom([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, int*, int>)(lpVtbl[27]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_pixelRight([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, int, int>)(lpVtbl[28]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_pixelRight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, int*, int>)(lpVtbl[29]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_posBottom(float v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, float, int>)(lpVtbl[30]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_posBottom(float* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, float*, int>)(lpVtbl[31]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_posRight(float v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, float, int>)(lpVtbl[32]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_posRight(float* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, float*, int>)(lpVtbl[33]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_imeMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[34]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[35]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[36]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[37]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[38]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[39]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[40]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[41]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridChar(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int>)(lpVtbl[42]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int>)(lpVtbl[43]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridLine(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int>)(lpVtbl[44]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int>)(lpVtbl[45]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[46]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[47]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[48]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[49]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[50]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[51]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int put_wordBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[52]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[53]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int put_lineBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[54]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[55]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_textJustify([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[56]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[57]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[58]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[59]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int put_textKashida(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int>)(lpVtbl[60]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int>)(lpVtbl[61]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_textAutospace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[62]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[63]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflowX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[64]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[65]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_overflowY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[66]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[67]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_accelerator([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int>)(lpVtbl[68]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int>)(lpVtbl[69]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
