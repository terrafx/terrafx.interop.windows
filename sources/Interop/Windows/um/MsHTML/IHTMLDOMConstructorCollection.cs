// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051049C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMConstructorCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMConstructorCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, uint>)(lpVtbl[1]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, uint>)(lpVtbl[2]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, uint*, int>)(lpVtbl[3]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attr(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[7]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_BehaviorUrnsCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[8]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_BookmarkCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[9]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_CompatibleInfo(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[10]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_CompatibleInfoCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[11]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_ControlRangeCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[12]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSCurrentStyleDeclaration(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[13]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSRuleList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[14]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSRuleStyleDeclaration(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[15]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSStyleDeclaration(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[16]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSStyleRule(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[17]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_CSSStyleSheet(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[18]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_DataTransfer(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[19]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_DOMImplementation(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[20]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_Element(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[21]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_Event(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[22]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_History(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[23]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTCElementBehaviorDefaults(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[24]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLAnchorElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[25]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLAreaElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[26]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLAreasCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[27]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBaseElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[28]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBaseFontElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[29]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBGSoundElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[30]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBlockElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[31]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBodyElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[32]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLBRElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[33]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLButtonElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[34]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[35]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLCommentElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[36]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLDDElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[37]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLDivElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[38]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLDocument(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[39]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLDListElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[40]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLDTElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[41]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLEmbedElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[42]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLFieldSetElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[43]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLFontElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[44]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLFormElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[45]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLFrameElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[46]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLFrameSetElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[47]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLGenericElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[48]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLHeadElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[49]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLHeadingElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[50]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLHRElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[51]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLHtmlElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[52]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLIFrameElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[53]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLImageElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[54]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLInputElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[55]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLIsIndexElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[56]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLLabelElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[57]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLLegendElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[58]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLLIElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[59]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLLinkElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[60]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLMapElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[61]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLMarqueeElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[62]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLMetaElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[63]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLModelessDialog(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[64]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLNamespaceInfo(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[65]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLNamespaceInfoCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[66]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLNextIdElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[67]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLNoShowElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[68]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLObjectElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[69]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLOListElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[70]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLOptionElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[71]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLParagraphElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[72]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLParamElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[73]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLPhraseElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[74]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLPluginsCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[75]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLPopup(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[76]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLScriptElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[77]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLSelectElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[78]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLSpanElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[79]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLStyleElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[80]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableCaptionElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[81]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableCellElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[82]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableColElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[83]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[84]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableRowElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[85]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTableSectionElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[86]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTextAreaElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[87]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTextElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[88]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLTitleElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[89]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLUListElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[90]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_HTMLUnknownElement(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[91]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_Image(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[92]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_Location(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[93]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_NamedNodeMap(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[94]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int get_Navigator(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[95]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_NodeList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[96]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_Option(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[97]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_Screen(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[98]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int get_Selection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[99]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_StaticNodeList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[100]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int get_Storage(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[101]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_StyleSheetList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[102]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int get_StyleSheetPage(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[103]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_StyleSheetPageList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[104]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int get_Text(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[105]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int get_TextRange(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[106]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int get_TextRangeCollection(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[107]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int get_TextRectangle(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[108]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_TextRectangleList(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[109]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int get_Window(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[110]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int get_XDomainRequest(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[111]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int get_XMLHttpRequest(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMConstructorCollection*, IDispatch**, int>)(lpVtbl[112]))((IHTMLDOMConstructorCollection*)Unsafe.AsPointer(ref this), p);
        }
    }
}
