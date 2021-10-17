// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F1FF-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement*, uint>)(lpVtbl[1]))((IHTMLElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement*, uint>)(lpVtbl[2]))((IHTMLElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement*, uint*, int>)(lpVtbl[3]))((IHTMLElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, VARIANT, int, int>)(lpVtbl[7]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int, short*, int>)(lpVtbl[9]))((IHTMLElement*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_className([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[10]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_className([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[11]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_id([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[12]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_id([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[13]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[14]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int>)(lpVtbl[15]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_style(IHTMLStyle** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLStyle**, int>)(lpVtbl[16]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_onhelp(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_onhelp(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_onclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[19]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_onclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[20]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondblclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondblclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeydown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeydown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeyup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeyup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeypress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeypress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousemove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[33]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousemove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[34]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousedown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[35]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousedown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[36]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_document(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int>)(lpVtbl[39]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_title([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[40]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_title([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[41]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_language([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[42]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_language([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[43]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselectstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[44]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselectstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[45]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int scrollIntoView(VARIANT varargStart)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[46]))((IHTMLElement*)Unsafe.AsPointer(ref this), varargStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int contains(IHTMLElement* pChild, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLElement*, short*, int>)(lpVtbl[47]))((IHTMLElement*)Unsafe.AsPointer(ref this), pChild, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_sourceIndex([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, int*, int>)(lpVtbl[48]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_recordNumber(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[49]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_lang([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[50]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_lang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[51]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, int*, int>)(lpVtbl[52]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, int*, int>)(lpVtbl[53]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, int*, int>)(lpVtbl[54]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, int*, int>)(lpVtbl[55]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetParent(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int>)(lpVtbl[56]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_innerHTML([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[57]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_innerHTML([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[58]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_innerText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[59]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_innerText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[60]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_outerHTML([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[61]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_outerHTML([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[62]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_outerText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, int>)(lpVtbl[63]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_outerText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[64]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int insertAdjacentHTML([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* html)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, ushort*, int>)(lpVtbl[65]))((IHTMLElement*)Unsafe.AsPointer(ref this), where, html);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int insertAdjacentText([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort*, ushort*, int>)(lpVtbl[66]))((IHTMLElement*)Unsafe.AsPointer(ref this), where, text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentTextEdit(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLElement**, int>)(lpVtbl[67]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_isTextEdit([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, short*, int>)(lpVtbl[68]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int click()
        {
            return ((delegate* unmanaged<IHTMLElement*, int>)(lpVtbl[69]))((IHTMLElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_filters(IHTMLFiltersCollection** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IHTMLFiltersCollection**, int>)(lpVtbl[70]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[71]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[72]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLElement*, ushort**, int>)(lpVtbl[73]))((IHTMLElement*)Unsafe.AsPointer(ref this), String);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[74]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[75]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int put_onafterupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[76]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_onafterupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[77]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerrorupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[78]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerrorupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[79]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowexit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[80]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowexit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[81]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[82]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[83]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondatasetchanged(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[84]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondatasetchanged(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[85]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[86]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondataavailable(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[87]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondatasetcomplete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[88]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondatasetcomplete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[89]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfilterchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT, int>)(lpVtbl[90]))((IHTMLElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfilterchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement*, VARIANT*, int>)(lpVtbl[91]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_children(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int>)(lpVtbl[92]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_all(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLElement*, IDispatch**, int>)(lpVtbl[93]))((IHTMLElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
