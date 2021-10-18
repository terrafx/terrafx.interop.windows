// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104B8-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDocument7 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDocument7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument7*, uint>)(lpVtbl[1]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument7*, uint>)(lpVtbl[2]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, uint*, int>)(lpVtbl[3]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultView(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLWindow2**, int>)(lpVtbl[7]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int createCDATASection([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newCDATASectionNode)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLDOMNode**, int>)(lpVtbl[8]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), text, newCDATASectionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int getSelection(IHTMLSelection** ppIHTMLSelection)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLSelection**, int>)(lpVtbl[9]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), ppIHTMLSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagNameNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrLocalName, IHTMLElementCollection** pelColl)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[10]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrLocalName, pelColl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int createElementNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLElement**, int>)(lpVtbl[11]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrTag, newElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int createAttributeNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[12]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pvarNS, bstrAttrName, ppAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsthumbnailclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[13]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsthumbnailclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_characterSet([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int>)(lpVtbl[15]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] ushort* bstrTag, IHTMLElement** newElem)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLElement**, int>)(lpVtbl[16]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrTag, newElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int createAttribute([NativeTypeName("BSTR")] ushort* bstrAttrName, IHTMLDOMAttribute** ppAttribute)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[17]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrAttrName, ppAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByClassName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pel)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[18]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v, pel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int createProcessingInstruction([NativeTypeName("BSTR")] ushort* bstrTarget, [NativeTypeName("BSTR")] ushort* bstrData, IDOMProcessingInstruction** newProcessingInstruction)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, ushort*, IDOMProcessingInstruction**, int>)(lpVtbl[19]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), bstrTarget, bstrData, newProcessingInstruction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int adoptNode(IHTMLDOMNode* pNodeSource, IHTMLDOMNode3** ppNodeDest)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLDOMNode*, IHTMLDOMNode3**, int>)(lpVtbl[20]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pNodeSource, ppNodeDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmssitemodejumplistitemremoved(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[21]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmssitemodejumplistitemremoved(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[22]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_all(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElementCollection**, int>)(lpVtbl[23]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_inputEncoding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int>)(lpVtbl[24]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_xmlEncoding([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int>)(lpVtbl[25]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_xmlStandalone([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, short, int>)(lpVtbl[26]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_xmlStandalone([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, short*, int>)(lpVtbl[27]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_xmlVersion([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort*, int>)(lpVtbl[28]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_xmlVersion([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, ushort**, int>)(lpVtbl[29]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, short*, int>)(lpVtbl[30]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onabort(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[31]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onabort(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[32]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[33]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[34]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[35]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[36]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncanplaythrough(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[37]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncanplaythrough(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[38]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[39]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[40]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrag(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[41]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrag(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[42]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[43]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[44]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[45]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[46]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[47]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[48]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[49]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[50]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[51]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[52]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondurationchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[53]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondurationchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[54]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_onemptied(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[55]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_onemptied(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[56]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_onended(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[57]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_onended(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[58]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[59]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[60]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[61]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[62]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_oninput(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[63]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_oninput(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[64]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[65]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[66]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadeddata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[67]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadeddata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[68]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadedmetadata(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[69]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadedmetadata(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[70]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_onloadstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[71]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_onloadstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[72]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpause(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[73]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpause(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[74]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplay(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[75]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplay(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[76]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_onplaying(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[77]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_onplaying(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[78]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_onprogress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[79]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_onprogress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[80]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int put_onratechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[81]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_onratechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[82]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreset(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[83]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreset(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[84]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int put_onscroll(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[85]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_onscroll(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[86]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeked(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[87]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeked(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[88]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int put_onseeking(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[89]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_onseeking(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[90]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[91]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[92]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstalled(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[93]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstalled(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[94]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsubmit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[95]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsubmit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[96]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int put_onsuspend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[97]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_onsuspend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[98]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int put_ontimeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[99]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_ontimeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[100]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int put_onvolumechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[101]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_onvolumechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[102]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int put_onwaiting(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT, int>)(lpVtbl[103]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_onwaiting(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, VARIANT*, int>)(lpVtbl[104]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return ((delegate* unmanaged<IHTMLDocument7*, int>)(lpVtbl[105]))((IHTMLDocument7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int importNode(IHTMLDOMNode* pNodeSource, [NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMNode3** ppNodeDest)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLDOMNode*, short, IHTMLDOMNode3**, int>)(lpVtbl[106]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), pNodeSource, fDeep, ppNodeDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentWindow(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLWindow2**, int>)(lpVtbl[107]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int putref_body(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement*, int>)(lpVtbl[108]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_body(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement**, int>)(lpVtbl[109]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int get_head(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument7*, IHTMLElement**, int>)(lpVtbl[110]))((IHTMLDocument7*)Unsafe.AsPointer(ref this), p);
        }
    }
}
