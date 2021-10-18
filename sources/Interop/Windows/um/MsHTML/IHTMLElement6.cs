// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106F8-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement6 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement6*, uint>)(lpVtbl[1]))((IHTMLElement6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement6*, uint>)(lpVtbl[2]))((IHTMLElement6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement6*, uint*, int>)(lpVtbl[3]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, VARIANT*, int>)(lpVtbl[7]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName, pvarAttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* strAttributeName)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, int>)(lpVtbl[9]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, strAttributeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNodeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[10]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, bstrname, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNodeNS(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[11]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, short*, int>)(lpVtbl[12]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pvarNS, name, pfHasAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, VARIANT*, int>)(lpVtbl[13]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* pvarAttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, VARIANT*, int>)(lpVtbl[14]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, pvarAttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, int>)(lpVtbl[15]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNode([NativeTypeName("BSTR")] ushort* strAttributeName, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[16]))((IHTMLElement6*)Unsafe.AsPointer(ref this), strAttributeName, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[17]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[18]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, short*, int>)(lpVtbl[19]))((IHTMLElement6*)Unsafe.AsPointer(ref this), name, pfHasAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagNameNS(VARIANT* varNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[20]))((IHTMLElement6*)Unsafe.AsPointer(ref this), varNS, bstrLocalName, pelColl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort**, int>)(lpVtbl[21]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort**, int>)(lpVtbl[22]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[23]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v, pel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int msMatchesSelector([NativeTypeName("BSTR")] ushort* v, [NativeTypeName("VARIANT_BOOL *")] short* pfMatches)
        {
            return ((delegate* unmanaged<IHTMLElement6*, ushort*, short*, int>)(lpVtbl[24]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onabort(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[25]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onabort(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[26]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplaythrough(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplaythrough(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[31]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[32]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondurationchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[33]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondurationchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[34]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_onemptied(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[35]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_onemptied(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[36]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_onended(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[37]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_onended(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[38]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[39]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[40]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_oninput(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[41]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_oninput(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[42]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[43]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[44]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadeddata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[45]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadeddata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[46]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadedmetadata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[47]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadedmetadata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[48]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[49]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[50]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpause(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[51]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpause(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[52]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[53]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[54]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplaying(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[55]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplaying(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[56]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_onprogress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[57]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_onprogress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[58]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_onratechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[59]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_onratechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[60]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[61]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[62]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeked(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[63]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeked(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[64]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeking(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[65]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeking(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[66]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[67]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[68]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstalled(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[69]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstalled(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[70]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsubmit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[71]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsubmit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[72]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsuspend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[73]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsuspend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[74]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_ontimeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[75]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_ontimeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[76]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_onvolumechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[77]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_onvolumechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[78]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_onwaiting(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT, int>)(lpVtbl[79]))((IHTMLElement6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_onwaiting(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement6*, VARIANT*, int>)(lpVtbl[80]))((IHTMLElement6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLElement6*, short*, int>)(lpVtbl[81]))((IHTMLElement6*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }
    }
}
