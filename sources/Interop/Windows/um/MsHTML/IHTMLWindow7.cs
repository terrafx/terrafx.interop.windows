// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104B7-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLWindow7 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLWindow7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLWindow7*, uint>)(lpVtbl[1]))((IHTMLWindow7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLWindow7*, uint>)(lpVtbl[2]))((IHTMLWindow7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, uint*, int>)(lpVtbl[3]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getSelection(IHTMLSelection** ppIHTMLSelection)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, IHTMLSelection**, int>)(lpVtbl[7]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), ppIHTMLSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int getComputedStyle(IHTMLDOMNode* varArgIn, [NativeTypeName("BSTR")] ushort* bstrPseudoElt, IHTMLCSSStyleDeclaration** ppComputedStyle)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, IHTMLDOMNode*, ushort*, IHTMLCSSStyleDeclaration**, int>)(lpVtbl[8]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), varArgIn, bstrPseudoElt, ppComputedStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_styleMedia(IHTMLStyleMedia** p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, IHTMLStyleMedia**, int>)(lpVtbl[9]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_performance(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[10]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_performance(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[11]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_innerWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[12]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_innerHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[13]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageXOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[14]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageYOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[15]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[16]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[17]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_outerWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[18]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_outerHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, int*, int>)(lpVtbl[19]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_onabort(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[20]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_onabort(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[21]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[22]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[23]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplaythrough(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[24]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplaythrough(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[25]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[26]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[27]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_onclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[28]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_onclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[29]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncontextmenu(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[30]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncontextmenu(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[31]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondblclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[32]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondblclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[33]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrag(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[34]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrag(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[35]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[36]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[37]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[38]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[39]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[40]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[41]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[42]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[43]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[44]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[45]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[46]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[47]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondurationchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[48]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondurationchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[49]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocusin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[50]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocusin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[51]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocusout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[52]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocusout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[53]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int put_oninput(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[54]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_oninput(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[55]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_onemptied(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[56]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_onemptied(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[57]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_onended(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[58]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_onended(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[59]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeydown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[60]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeydown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[61]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeypress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[62]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeypress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[63]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeyup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[64]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeyup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[65]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadeddata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[66]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadeddata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[67]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadedmetadata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[68]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadedmetadata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[69]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[70]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[71]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousedown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[72]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousedown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[73]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[74]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[75]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[76]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[77]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousemove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[78]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousemove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[79]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[80]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[81]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[82]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[83]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[84]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[85]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousewheel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[86]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousewheel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[87]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int put_onoffline(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[88]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_onoffline(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[89]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int put_ononline(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[90]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_ononline(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[91]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int put_onprogress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[92]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_onprogress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[93]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int put_onratechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[94]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int get_onratechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[95]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[96]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[97]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[98]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[99]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeked(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[100]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeked(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[101]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeking(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[102]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeking(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[103]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[104]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[105]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstalled(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[106]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstalled(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[107]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstorage(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[108]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstorage(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[109]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsubmit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[110]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsubmit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[111]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsuspend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[112]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsuspend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[113]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int put_ontimeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[114]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int get_ontimeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[115]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpause(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[116]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpause(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[117]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[118]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[119]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplaying(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[120]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplaying(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[121]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int put_onvolumechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[122]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int get_onvolumechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[123]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int put_onwaiting(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT, int>)(lpVtbl[124]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int get_onwaiting(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow7*, VARIANT*, int>)(lpVtbl[125]))((IHTMLWindow7*)Unsafe.AsPointer(ref this), p);
        }
    }
}
