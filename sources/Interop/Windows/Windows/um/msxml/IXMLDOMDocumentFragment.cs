// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3EFAA413-272F-11D2-836F-0000F87A7782")]
[NativeTypeName("struct IXMLDOMDocumentFragment : IXMLDOMNode")]
[NativeInheritance("IXMLDOMNode")]
public unsafe partial struct IXMLDOMDocumentFragment : IXMLDOMDocumentFragment.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, uint>)(lpVtbl[1]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, uint>)(lpVtbl[2]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, uint*, int>)(lpVtbl[3]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[7]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode** parent)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), parent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList** childList)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), childList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode** firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), firstChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode** lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), lastChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), previousSibling);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nextSibling);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), attributeMap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), childNode, oldChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), newChild, outNewChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int>)(lpVtbl[22]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), hasChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), XMLDOMDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), deep, cloneRoot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[25]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nodeType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[26]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), text);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, int>)(lpVtbl[27]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), text);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int>)(lpVtbl[28]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), isSpecified);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode** definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), definitionNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), typedValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), typedValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, int>)(lpVtbl[33]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[34]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), xmlString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), queryString, resultList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), queryString, resultNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int>)(lpVtbl[38]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), isParsed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[39]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), namespaceURI);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[40]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), prefixString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int>)(lpVtbl[41]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), nameString);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
    {
        return ((delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMDocumentFragment*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
    }

    public interface Interface : IXMLDOMNode.Interface
    {
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_nodeName;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int> get_nodeValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT, int> put_nodeValue;

        [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, DOMNodeType*, int> get_nodeType;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_parentNode;

        [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNodeList**, int> get_childNodes;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_firstChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_lastChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_previousSibling;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_nextSibling;

        [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNamedNodeMap**, int> get_attributes;

        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int> hasChildNodes;

        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMDocument**, int> get_ownerDocument;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, short, IXMLDOMNode**, int> cloneNode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_nodeTypeString;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int> get_specified;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode**, int> get_definition;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int> get_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT, int> put_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, VARIANT*, int> get_dataType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, int> put_dataType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_xml;

        [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, ushort**, int> transformNode;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, IXMLDOMNodeList**, int> selectNodes;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort*, IXMLDOMNode**, int> selectSingleNode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, short*, int> get_parsed;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_namespaceURI;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_prefix;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, ushort**, int> get_baseName;

        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<IXMLDOMDocumentFragment*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;
    }
}
